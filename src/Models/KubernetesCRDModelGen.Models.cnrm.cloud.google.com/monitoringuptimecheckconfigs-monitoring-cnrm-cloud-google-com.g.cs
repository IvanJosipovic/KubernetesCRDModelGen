using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.cnrm.cloud.google.com;
public partial class V1beta1MonitoringUptimeCheckConfigSpecContentMatchers
{
    /// <summary></summary>
    [JsonPropertyName("content")]
    public string Content { get; set; }

    /// <summary> Possible values: CONTENT_MATCHER_OPTION_UNSPECIFIED, CONTAINS_STRING, NOT_CONTAINS_STRING, MATCHES_REGEX, NOT_MATCHES_REGEX</summary>
    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfoPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfoPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfoPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfoPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfoPasswordValueFrom? ValueFrom { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfo
{
    /// <summary></summary>
    [JsonPropertyName("password")]
    public V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfoPassword Password { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecHttpCheck
{
    /// <summary>The authentication information. Optional when creating an HTTP check; defaults to empty.</summary>
    [JsonPropertyName("authInfo")]
    public V1beta1MonitoringUptimeCheckConfigSpecHttpCheckAuthInfo? AuthInfo { get; set; }

    /// <summary>The request body associated with the HTTP POST request. If `content_type` is `URL_ENCODED`, the body passed in must be URL-encoded. Users can provide a `Content-Length` header via the `headers` field or the API will do so. If the `request_method` is `GET` and `body` is not empty, the API will return an error. The maximum byte size is 1 megabyte. Note: As with all `bytes` fields JSON representations are base64 encoded. e.g.: "foo=bar" in URL-encoded form is "foo%3Dbar" and in base64 encoding is "Zm9vJTI1M0RiYXI=".</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Immutable. The content type to use for the check.  Possible values: TYPE_UNSPECIFIED, URL_ENCODED</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The list of headers to send as part of the Uptime check request. If two headers have the same key and different values, they should be entered as a single header, with the value being a comma-separated list of all the desired values as described at https://www.w3.org/Protocols/rfc2616/rfc2616.txt (page 31). Entering two separate headers with the same key in a Create call will cause the first to be overwritten by the second. The maximum number of headers allowed is 100.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Immutable. Boolean specifying whether to encrypt the header information. Encryption should be specified for any headers related to authentication that you do not wish to be seen when retrieving the configuration. The server will be responsible for encrypting the headers. On Get/List calls, if `mask_headers` is set to `true` then the headers will be obscured with `******.`</summary>
    [JsonPropertyName("maskHeaders")]
    public bool? MaskHeaders { get; set; }

    /// <summary>Optional (defaults to "/"). The path to the page against which to run the check. Will be combined with the `host` (specified within the `monitored_resource`) and `port` to construct the full URL. If the provided path does not begin with "/", a "/" will be prepended automatically.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional (defaults to 80 when `use_ssl` is `false`, and 443 when `use_ssl` is `true`). The TCP port on the HTTP server against which to run the check. Will be combined with host (specified within the `monitored_resource`) and `path` to construct the full URL.</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>Immutable. The HTTP request method to use for the check. If set to `METHOD_UNSPECIFIED` then `request_method` defaults to `GET`.</summary>
    [JsonPropertyName("requestMethod")]
    public string? RequestMethod { get; set; }

    /// <summary>If `true`, use HTTPS instead of HTTP to run the check.</summary>
    [JsonPropertyName("useSsl")]
    public bool? UseSsl { get; set; }

    /// <summary>Boolean specifying whether to include SSL certificate validation as a part of the Uptime check. Only applies to checks where `monitored_resource` is set to `uptime_url`. If `use_ssl` is `false`, setting `validate_ssl` to `true` has no effect.</summary>
    [JsonPropertyName("validateSsl")]
    public bool? ValidateSsl { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecMonitoredResource
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("filterLabels")]
    public IDictionary<string, string> FilterLabels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecProjectRef
{
    /// <summary>The project for this uptime check config.  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecResourceGroupGroupRef
{
    /// <summary>The group of resources being monitored. Should be only the `[GROUP_ID]`, and not the full-path `projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]`.  Allowed value: The Google Cloud resource name of a `MonitoringGroup` resource (format: `projects/{{project}}/groups/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecResourceGroup
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("groupRef")]
    public V1beta1MonitoringUptimeCheckConfigSpecResourceGroupGroupRef? GroupRef { get; set; }

    /// <summary>Immutable. The resource type of the group members. Possible values: RESOURCE_TYPE_UNSPECIFIED, INSTANCE, AWS_ELB_LOAD_BALANCER</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpecTcpCheck
{
    /// <summary>The TCP port on the server against which to run the check. Will be combined with host (specified within the `monitored_resource`) to construct the full URL. Required.</summary>
    [JsonPropertyName("port")]
    public long Port { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigSpec
{
    /// <summary>The content that is expected to appear in the data returned by the target server against which the check is run.  Currently, only the first entry in the `content_matchers` list is supported, and additional entries will be ignored. This field is optional and should only be specified if a content match is required as part of the/ Uptime check.</summary>
    [JsonPropertyName("contentMatchers")]
    public IList<V1beta1MonitoringUptimeCheckConfigSpecContentMatchers>? ContentMatchers { get; set; }

    /// <summary>A human-friendly name for the Uptime check configuration. The display name should be unique within a Stackdriver Workspace in order to make it easier to identify; however, uniqueness is not enforced. Required.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Contains information needed to make an HTTP or HTTPS check.</summary>
    [JsonPropertyName("httpCheck")]
    public V1beta1MonitoringUptimeCheckConfigSpecHttpCheck? HttpCheck { get; set; }

    /// <summary>Immutable. The [monitored resource](https://cloud.google.com/monitoring/api/resources) associated with the configuration. The following monitored resource types are supported for Uptime checks:   `uptime_url`,   `gce_instance`,   `gae_app`,   `aws_ec2_instance`,   `aws_elb_load_balancer`</summary>
    [JsonPropertyName("monitoredResource")]
    public V1beta1MonitoringUptimeCheckConfigSpecMonitoredResource? MonitoredResource { get; set; }

    /// <summary>How often, in seconds, the Uptime check is performed. Currently, the only supported values are `60s` (1 minute), `300s` (5 minutes), `600s` (10 minutes), and `900s` (15 minutes). Optional, defaults to `60s`.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1MonitoringUptimeCheckConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. The group resource associated with the configuration.</summary>
    [JsonPropertyName("resourceGroup")]
    public V1beta1MonitoringUptimeCheckConfigSpecResourceGroup? ResourceGroup { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The list of regions from which the check will be run. Some regions contain one location, and others contain more than one. If this field is specified, enough regions must be provided to include a minimum of 3 locations.  Not specifying this field will result in Uptime checks running from all available regions.</summary>
    [JsonPropertyName("selectedRegions")]
    public IList<string>? SelectedRegions { get; set; }

    /// <summary>Contains information needed to make a TCP check.</summary>
    [JsonPropertyName("tcpCheck")]
    public V1beta1MonitoringUptimeCheckConfigSpecTcpCheck? TcpCheck { get; set; }

    /// <summary>The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). Required.</summary>
    [JsonPropertyName("timeout")]
    public string Timeout { get; set; }
}

public partial class V1beta1MonitoringUptimeCheckConfigStatusConditions
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

public partial class V1beta1MonitoringUptimeCheckConfigStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitoringUptimeCheckConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitoringUptimeCheckConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitoringUptimeCheckConfigSpec>, IStatus<V1beta1MonitoringUptimeCheckConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitoringUptimeCheckConfig";
    public const string KubeGroup = "monitoring.cnrm.cloud.google.com";
    public const string KubePluralName = "monitoringuptimecheckconfigs";
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
    public V1beta1MonitoringUptimeCheckConfigSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1MonitoringUptimeCheckConfigStatus? Status { get; set; }
}