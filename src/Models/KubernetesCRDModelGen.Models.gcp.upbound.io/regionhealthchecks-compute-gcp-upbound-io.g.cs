using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1RegionHealthCheckSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProviderGrpcHealthCheck
{
    /// <summary>The gRPC service name for the health check. The value of grpcServiceName has the following meanings by convention:</summary>
    [JsonPropertyName("grpcServiceName")]
    public string? GrpcServiceName { get; set; }

    /// <summary>The port number for the health check request. Must be specified if portName and portSpecification are not set or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProviderHttp2HealthCheck
{
    /// <summary>The value of the host header in the HTTP2 health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP2 health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP2 health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProviderHttpHealthCheck
{
    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProviderHttpsHealthCheck
{
    /// <summary>The value of the host header in the HTTPS health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTPS health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTPS health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs. This is false by default, which means no health check logging will be done.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProviderSslHealthCheck
{
    /// <summary>The TCP port number for the SSL health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the SSL connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProviderTcpHealthCheck
{
    /// <summary>The TCP port number for the TCP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the TCP connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecForProvider
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("grpcHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecForProviderGrpcHealthCheck>? GrpcHealthCheck { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("http2HealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecForProviderHttp2HealthCheck>? Http2HealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("httpHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecForProviderHttpHealthCheck>? HttpHealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("httpsHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecForProviderHttpsHealthCheck>? HttpsHealthCheck { get; set; }

    /// <summary>Configure logging on this health check. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1RegionHealthCheckSpecForProviderLogConfig>? LogConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the created health check should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("sslHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecForProviderSslHealthCheck>? SslHealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("tcpHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecForProviderTcpHealthCheck>? TcpHealthCheck { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProviderGrpcHealthCheck
{
    /// <summary>The gRPC service name for the health check. The value of grpcServiceName has the following meanings by convention:</summary>
    [JsonPropertyName("grpcServiceName")]
    public string? GrpcServiceName { get; set; }

    /// <summary>The port number for the health check request. Must be specified if portName and portSpecification are not set or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProviderHttp2HealthCheck
{
    /// <summary>The value of the host header in the HTTP2 health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP2 health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP2 health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProviderHttpHealthCheck
{
    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProviderHttpsHealthCheck
{
    /// <summary>The value of the host header in the HTTPS health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTPS health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTPS health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs. This is false by default, which means no health check logging will be done.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProviderSslHealthCheck
{
    /// <summary>The TCP port number for the SSL health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the SSL connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProviderTcpHealthCheck
{
    /// <summary>The TCP port number for the TCP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the TCP connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecInitProvider
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("grpcHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecInitProviderGrpcHealthCheck>? GrpcHealthCheck { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("http2HealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecInitProviderHttp2HealthCheck>? Http2HealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("httpHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecInitProviderHttpHealthCheck>? HttpHealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("httpsHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecInitProviderHttpsHealthCheck>? HttpsHealthCheck { get; set; }

    /// <summary>Configure logging on this health check. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1RegionHealthCheckSpecInitProviderLogConfig>? LogConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("sslHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecInitProviderSslHealthCheck>? SslHealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("tcpHealthCheck")]
    public IList<V1beta1RegionHealthCheckSpecInitProviderTcpHealthCheck>? TcpHealthCheck { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1RegionHealthCheckSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1RegionHealthCheckSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1RegionHealthCheckSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionHealthCheckSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionHealthCheckSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionHealthCheckSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RegionHealthCheckSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionHealthCheckSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RegionHealthCheckSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RegionHealthCheckSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RegionHealthCheckSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RegionHealthCheckSpec defines the desired state of RegionHealthCheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionHealthCheckSpecDeletionPolicyEnum>))]
    public V1beta1RegionHealthCheckSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionHealthCheckSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionHealthCheckSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegionHealthCheckSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionHealthCheckSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RegionHealthCheckSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionHealthCheckSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProviderGrpcHealthCheck
{
    /// <summary>The gRPC service name for the health check. The value of grpcServiceName has the following meanings by convention:</summary>
    [JsonPropertyName("grpcServiceName")]
    public string? GrpcServiceName { get; set; }

    /// <summary>The port number for the health check request. Must be specified if portName and portSpecification are not set or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProviderHttp2HealthCheck
{
    /// <summary>The value of the host header in the HTTP2 health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP2 health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP2 health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProviderHttpHealthCheck
{
    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProviderHttpsHealthCheck
{
    /// <summary>The value of the host header in the HTTPS health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTPS health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTPS health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProviderLogConfig
{
    /// <summary>Indicates whether or not to export logs. This is false by default, which means no health check logging will be done.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProviderSslHealthCheck
{
    /// <summary>The TCP port number for the SSL health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the SSL connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProviderTcpHealthCheck
{
    /// <summary>The TCP port number for the TCP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value is NONE. Possible values are: NONE, PROXY_V1.</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the TCP connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusAtProvider
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public double? CheckIntervalSec { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("grpcHealthCheck")]
    public IList<V1beta1RegionHealthCheckStatusAtProviderGrpcHealthCheck>? GrpcHealthCheck { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("http2HealthCheck")]
    public IList<V1beta1RegionHealthCheckStatusAtProviderHttp2HealthCheck>? Http2HealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("httpHealthCheck")]
    public IList<V1beta1RegionHealthCheckStatusAtProviderHttpHealthCheck>? HttpHealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("httpsHealthCheck")]
    public IList<V1beta1RegionHealthCheckStatusAtProviderHttpsHealthCheck>? HttpsHealthCheck { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/healthChecks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configure logging on this health check. Structure is documented below.</summary>
    [JsonPropertyName("logConfig")]
    public IList<V1beta1RegionHealthCheckStatusAtProviderLogConfig>? LogConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the created health check should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("sslHealthCheck")]
    public IList<V1beta1RegionHealthCheckStatusAtProviderSslHealthCheck>? SslHealthCheck { get; set; }

    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("tcpHealthCheck")]
    public IList<V1beta1RegionHealthCheckStatusAtProviderTcpHealthCheck>? TcpHealthCheck { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>The type of the health check. One of HTTP, HTTP2, HTTPS, TCP, or SSL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatusConditions
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

/// <summary>RegionHealthCheckStatus defines the observed state of RegionHealthCheck.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionHealthCheckStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionHealthCheckStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionHealthCheckStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionHealthCheck is the Schema for the RegionHealthChecks API. Health Checks determine whether instances are responsive and able to do work.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionHealthCheck : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionHealthCheckSpec>, IStatus<V1beta1RegionHealthCheckStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionHealthCheck";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionhealthchecks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionHealthCheckSpec defines the desired state of RegionHealthCheck</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionHealthCheckSpec Spec { get; set; }

    /// <summary>RegionHealthCheckStatus defines the observed state of RegionHealthCheck.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionHealthCheckStatus? Status { get; set; }
}