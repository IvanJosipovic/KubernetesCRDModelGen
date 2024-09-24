using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
public partial class V1beta1ComputeHealthCheckSpecGrpcHealthCheck
{
    /// <summary>The gRPC service name for the health check. The value of grpcServiceName has the following meanings by convention:   - Empty serviceName means the overall status of all services at the backend.   - Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service. The grpcServiceName can only be ASCII.</summary>
    [JsonPropertyName("grpcServiceName")]
    public string? GrpcServiceName { get; set; }

    /// <summary>The port number for the health check request. Must be specified if portName and portSpecification are not set or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:    * 'USE_FIXED_PORT': The port number in 'port' is used for health checking.    * 'USE_NAMED_PORT': The 'portName' is used for health checking.    * 'USE_SERVING_PORT': For NetworkEndpointGroup, the port specified for each   network endpoint is used for health checking. For other backends, the   port or named port specified in the Backend Service is used for health   checking.  If not specified, gRPC health check follows behavior specified in 'port' and 'portName' fields. Possible values: ["USE_FIXED_PORT", "USE_NAMED_PORT", "USE_SERVING_PORT"].</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }
}

public partial class V1beta1ComputeHealthCheckSpecHttp2HealthCheck
{
    /// <summary>The value of the host header in the HTTP2 health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP2 health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:    * 'USE_FIXED_PORT': The port number in 'port' is used for health checking.    * 'USE_NAMED_PORT': The 'portName' is used for health checking.    * 'USE_SERVING_PORT': For NetworkEndpointGroup, the port specified for each   network endpoint is used for health checking. For other backends, the   port or named port specified in the Backend Service is used for health   checking.  If not specified, HTTP2 health check follows behavior specified in 'port' and 'portName' fields. Possible values: ["USE_FIXED_PORT", "USE_NAMED_PORT", "USE_SERVING_PORT"].</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value: "NONE" Possible values: ["NONE", "PROXY_V1"].</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP2 health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

public partial class V1beta1ComputeHealthCheckSpecHttpHealthCheck
{
    /// <summary>The value of the host header in the HTTP health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTP health check request. The default value is 80.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:    * 'USE_FIXED_PORT': The port number in 'port' is used for health checking.    * 'USE_NAMED_PORT': The 'portName' is used for health checking.    * 'USE_SERVING_PORT': For NetworkEndpointGroup, the port specified for each   network endpoint is used for health checking. For other backends, the   port or named port specified in the Backend Service is used for health   checking.  If not specified, HTTP health check follows behavior specified in 'port' and 'portName' fields. Possible values: ["USE_FIXED_PORT", "USE_NAMED_PORT", "USE_SERVING_PORT"].</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value: "NONE" Possible values: ["NONE", "PROXY_V1"].</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTP health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

public partial class V1beta1ComputeHealthCheckSpecHttpsHealthCheck
{
    /// <summary>The value of the host header in the HTTPS health check request. If left empty (default value), the public IP on behalf of which this health check is performed will be used.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The TCP port number for the HTTPS health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:    * 'USE_FIXED_PORT': The port number in 'port' is used for health checking.    * 'USE_NAMED_PORT': The 'portName' is used for health checking.    * 'USE_SERVING_PORT': For NetworkEndpointGroup, the port specified for each   network endpoint is used for health checking. For other backends, the   port or named port specified in the Backend Service is used for health   checking.  If not specified, HTTPS health check follows behavior specified in 'port' and 'portName' fields. Possible values: ["USE_FIXED_PORT", "USE_NAMED_PORT", "USE_SERVING_PORT"].</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value: "NONE" Possible values: ["NONE", "PROXY_V1"].</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The request path of the HTTPS health check request. The default value is /.</summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

public partial class V1beta1ComputeHealthCheckSpecLogConfig
{
    /// <summary>Indicates whether or not to export logs. This is false by default, which means no health check logging will be done.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }
}

public partial class V1beta1ComputeHealthCheckSpecSslHealthCheck
{
    /// <summary>The TCP port number for the SSL health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:    * 'USE_FIXED_PORT': The port number in 'port' is used for health checking.    * 'USE_NAMED_PORT': The 'portName' is used for health checking.    * 'USE_SERVING_PORT': For NetworkEndpointGroup, the port specified for each   network endpoint is used for health checking. For other backends, the   port or named port specified in the Backend Service is used for health   checking.  If not specified, SSL health check follows behavior specified in 'port' and 'portName' fields. Possible values: ["USE_FIXED_PORT", "USE_NAMED_PORT", "USE_SERVING_PORT"].</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value: "NONE" Possible values: ["NONE", "PROXY_V1"].</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the SSL connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

public partial class V1beta1ComputeHealthCheckSpecTcpHealthCheck
{
    /// <summary>The TCP port number for the TCP health check request. The default value is 443.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Port name as defined in InstanceGroup#NamedPort#name. If both port and port_name are defined, port takes precedence.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Specifies how port is selected for health checking, can be one of the following values:    * 'USE_FIXED_PORT': The port number in 'port' is used for health checking.    * 'USE_NAMED_PORT': The 'portName' is used for health checking.    * 'USE_SERVING_PORT': For NetworkEndpointGroup, the port specified for each   network endpoint is used for health checking. For other backends, the   port or named port specified in the Backend Service is used for health   checking.  If not specified, TCP health check follows behavior specified in 'port' and 'portName' fields. Possible values: ["USE_FIXED_PORT", "USE_NAMED_PORT", "USE_SERVING_PORT"].</summary>
    [JsonPropertyName("portSpecification")]
    public string? PortSpecification { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value: "NONE" Possible values: ["NONE", "PROXY_V1"].</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The application data to send once the TCP connection has been established (default value is empty). If both request and response are empty, the connection establishment alone will indicate health. The request data can only be ASCII.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }

    /// <summary>The bytes to match against the beginning of the response data. If left empty (the default value), any response will indicate health. The response data can only be ASCII.</summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }
}

public partial class V1beta1ComputeHealthCheckSpec
{
    /// <summary>How often (in seconds) to send a health check. The default value is 5 seconds.</summary>
    [JsonPropertyName("checkIntervalSec")]
    public int? CheckIntervalSec { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("grpcHealthCheck")]
    public V1beta1ComputeHealthCheckSpecGrpcHealthCheck? GrpcHealthCheck { get; set; }

    /// <summary>A so-far unhealthy instance will be marked healthy after this many consecutive successes. The default value is 2.</summary>
    [JsonPropertyName("healthyThreshold")]
    public int? HealthyThreshold { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("http2HealthCheck")]
    public V1beta1ComputeHealthCheckSpecHttp2HealthCheck? Http2HealthCheck { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("httpHealthCheck")]
    public V1beta1ComputeHealthCheckSpecHttpHealthCheck? HttpHealthCheck { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("httpsHealthCheck")]
    public V1beta1ComputeHealthCheckSpecHttpsHealthCheck? HttpsHealthCheck { get; set; }

    /// <summary>Location represents the geographical location of the ComputeHealthCheck. Specify a region name or "global" for global resources. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Configure logging on this health check.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1ComputeHealthCheckSpecLogConfig? LogConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("sslHealthCheck")]
    public V1beta1ComputeHealthCheckSpecSslHealthCheck? SslHealthCheck { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("tcpHealthCheck")]
    public V1beta1ComputeHealthCheckSpecTcpHealthCheck? TcpHealthCheck { get; set; }

    /// <summary>How long (in seconds) to wait before claiming failure. The default value is 5 seconds.  It is invalid for timeoutSec to have greater value than checkIntervalSec.</summary>
    [JsonPropertyName("timeoutSec")]
    public int? TimeoutSec { get; set; }

    /// <summary>A so-far healthy instance will be marked unhealthy after this many consecutive failures. The default value is 2.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public int? UnhealthyThreshold { get; set; }
}

public partial class V1beta1ComputeHealthCheckStatusConditions
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

public partial class V1beta1ComputeHealthCheckStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeHealthCheckStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The type of the health check. One of HTTP, HTTPS, TCP, or SSL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeHealthCheck : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeHealthCheckSpec>, IStatus<V1beta1ComputeHealthCheckStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeHealthCheck";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computehealthchecks";
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
    public V1beta1ComputeHealthCheckSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeHealthCheckStatus? Status { get; set; }
}