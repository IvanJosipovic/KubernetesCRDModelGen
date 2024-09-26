using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderContentMatchersJsonPathMatcher
{
    /// <summary>Options to perform JSONPath content matching. Default value is EXACT_MATCH. Possible values are: EXACT_MATCH, REGEX_MATCH.</summary>
    [JsonPropertyName("jsonMatcher")]
    public string? JsonMatcher { get; set; }

    /// <summary>JSONPath within the response output pointing to the expected ContentMatcher::content to match against.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderContentMatchers
{
    /// <summary>String or regex content to match (max 1024 bytes)</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Information needed to perform a JSONPath content match. Used for ContentMatcherOption::MATCHES_JSON_PATH and ContentMatcherOption::NOT_MATCHES_JSON_PATH. Structure is documented below.</summary>
    [JsonPropertyName("jsonPathMatcher")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderContentMatchersJsonPathMatcher>? JsonPathMatcher { get; set; }

    /// <summary>The type of content matcher that will be applied to the server output, compared to the content string when the check is run. Default value is CONTAINS_STRING. Possible values are: CONTAINS_STRING, NOT_CONTAINS_STRING, MATCHES_REGEX, NOT_MATCHES_REGEX, MATCHES_JSON_PATH, NOT_MATCHES_JSON_PATH.</summary>
    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderHttpCheckAcceptedResponseStatusCodes
{
    /// <summary>A class of status codes to accept. Possible values are: STATUS_CLASS_1XX, STATUS_CLASS_2XX, STATUS_CLASS_3XX, STATUS_CLASS_4XX, STATUS_CLASS_5XX, STATUS_CLASS_ANY.</summary>
    [JsonPropertyName("statusClass")]
    public string? StatusClass { get; set; }

    /// <summary>A status code to accept.</summary>
    [JsonPropertyName("statusValue")]
    public double? StatusValue { get; set; }
}

/// <summary>The password to authenticate. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderHttpCheckAuthInfoPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderHttpCheckAuthInfo
{
    /// <summary>The password to authenticate. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1UptimeCheckConfigSpecForProviderHttpCheckAuthInfoPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username to authenticate.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderHttpCheckPingConfig
{
    /// <summary>Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.</summary>
    [JsonPropertyName("pingsCount")]
    public double? PingsCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderHttpCheckServiceAgentAuthentication
{
    /// <summary>The type of authentication to use. Possible values are: SERVICE_AGENT_AUTHENTICATION_TYPE_UNSPECIFIED, OIDC_TOKEN.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderHttpCheck
{
    /// <summary>If present, the check will only pass if the HTTP response status code is in this set of status codes. If empty, the HTTP status code will only pass if the HTTP status code is 200-299. Structure is documented below.</summary>
    [JsonPropertyName("acceptedResponseStatusCodes")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderHttpCheckAcceptedResponseStatusCodes>? AcceptedResponseStatusCodes { get; set; }

    /// <summary>The authentication information. Optional when creating an HTTP check; defaults to empty. Structure is documented below.</summary>
    [JsonPropertyName("authInfo")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderHttpCheckAuthInfo>? AuthInfo { get; set; }

    /// <summary>The request body associated with the HTTP POST request. If content_type is URL_ENCODED, the body passed in must be URL-encoded. Users can provide a Content-Length header via the headers field or the API will do so. If the request_method is GET and body is not empty, the API will return an error. The maximum byte size is 1 megabyte. Note - As with all bytes fields JSON representations are base64 encoded. e.g. foo=bar in URL-encoded form is foo%3Dbar and in base64 encoding is Zm9vJTI1M0RiYXI=.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>The content type to use for the check. Possible values are: TYPE_UNSPECIFIED, URL_ENCODED, USER_PROVIDED.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>A user provided content type header to use for the check. The invalid configurations outlined in the content_type field apply to custom_content_type, as well as the following 1. content_typeisURL_ENCODEDandcustom_content_typeis set. 2.content_typeisUSER_PROVIDEDandcustom_content_type` is not set.</summary>
    [JsonPropertyName("customContentType")]
    public string? CustomContentType { get; set; }

    /// <summary>The list of headers to send as part of the uptime check request. If two headers have the same key and different values, they should be entered as a single header, with the value being a comma-separated list of all the desired values as described in RFC 2616 (page 31). Entering two separate headers with the same key in a Create call will cause the first to be overwritten by the second. The maximum number of headers allowed is 100.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Boolean specifying whether to encrypt the header information. Encryption should be specified for any headers related to authentication that you do not wish to be seen when retrieving the configuration. The server will be responsible for encrypting the headers. On Get/List calls, if mask_headers is set to true then the headers will be obscured with ******.</summary>
    [JsonPropertyName("maskHeaders")]
    public bool? MaskHeaders { get; set; }

    /// <summary>The path to the page to run the check against. Will be combined with the host (specified within the MonitoredResource) and port to construct the full URL. If the provided path does not begin with /, a / will be prepended automatically. Optional (defaults to /).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Contains information needed to add pings to an HTTP check. Structure is documented below.</summary>
    [JsonPropertyName("pingConfig")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderHttpCheckPingConfig>? PingConfig { get; set; }

    /// <summary>The port to the page to run the check against. Will be combined with host (specified within the monitored_resource) and path to construct the full URL. Optional (defaults to 80 without SSL, or 443 with SSL).</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The HTTP request method to use for the check. If set to METHOD_UNSPECIFIED then request_method defaults to GET. Default value is GET. Possible values are: METHOD_UNSPECIFIED, GET, POST.</summary>
    [JsonPropertyName("requestMethod")]
    public string? RequestMethod { get; set; }

    /// <summary>The authentication information using the Monitoring Service Agent. Optional when creating an HTTPS check; defaults to empty. Do not use with other authentication fields. Structure is documented below.</summary>
    [JsonPropertyName("serviceAgentAuthentication")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderHttpCheckServiceAgentAuthentication>? ServiceAgentAuthentication { get; set; }

    /// <summary>If true, use HTTPS instead of HTTP to run the check.</summary>
    [JsonPropertyName("useSsl")]
    public bool? UseSsl { get; set; }

    /// <summary>Boolean specifying whether to include SSL certificate validation as a part of the Uptime check. Only applies to checks where monitored_resource is set to uptime_url. If use_ssl is false, setting validate_ssl to true has no effect.</summary>
    [JsonPropertyName("validateSsl")]
    public bool? ValidateSsl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderMonitoredResource
{
    /// <summary>Values for all of the labels listed in the associated monitored resource descriptor. For example, Compute Engine VM instances use the labels project_id, instance_id, and zone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The monitored resource type. This field must match the type field of a MonitoredResourceDescriptor object. For example, the type of a Compute Engine VM instance is gce_instance. For a list of types, see Monitoring resource types and Logging resource types.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in monitoring to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in monitoring to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderResourceGroup
{
    /// <summary>The group of resources being monitored. Should be the name of a group</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Reference to a Group in monitoring to populate groupId.</summary>
    [JsonPropertyName("groupIdRef")]
    public V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdRef? GroupIdRef { get; set; }

    /// <summary>Selector for a Group in monitoring to populate groupId.</summary>
    [JsonPropertyName("groupIdSelector")]
    public V1beta1UptimeCheckConfigSpecForProviderResourceGroupGroupIdSelector? GroupIdSelector { get; set; }

    /// <summary>The resource type of the group members. Possible values are: RESOURCE_TYPE_UNSPECIFIED, INSTANCE, AWS_ELB_LOAD_BALANCER.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfunctions2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfunctions2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2
{
    /// <summary>The fully qualified name of the cloud function resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Function in cloudfunctions2 to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameRef? NameRef { get; set; }

    /// <summary>Selector for a Function in cloudfunctions2 to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2NameSelector? NameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitor
{
    /// <summary>Target a Synthetic Monitor GCFv2 Instance Structure is documented below.</summary>
    [JsonPropertyName("cloudFunctionV2")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitorCloudFunctionV2>? CloudFunctionV2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderTcpCheckPingConfig
{
    /// <summary>Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.</summary>
    [JsonPropertyName("pingsCount")]
    public double? PingsCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProviderTcpCheck
{
    /// <summary>Contains information needed to add pings to a TCP check. Structure is documented below.</summary>
    [JsonPropertyName("pingConfig")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderTcpCheckPingConfig>? PingConfig { get; set; }

    /// <summary>The port to the page to run the check against. Will be combined with host (specified within the monitored_resource) to construct the full URL.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecForProvider
{
    /// <summary>The checker type to use for the check. If the monitored resource type is servicedirectory_service, checker_type must be set to VPC_CHECKERS. Possible values are: STATIC_IP_CHECKERS, VPC_CHECKERS.</summary>
    [JsonPropertyName("checkerType")]
    public string? CheckerType { get; set; }

    /// <summary>The expected content on the page the check is run against. Currently, only the first entry in the list is supported, and other entries will be ignored. The server will look for an exact match of the string in the page response's content. This field is optional and should only be specified if a content match is required. Structure is documented below.</summary>
    [JsonPropertyName("contentMatchers")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderContentMatchers>? ContentMatchers { get; set; }

    /// <summary>A human-friendly name for the uptime check configuration. The display name should be unique within a Stackdriver Workspace in order to make it easier to identify; however, uniqueness is not enforced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Contains information needed to make an HTTP or HTTPS check. Structure is documented below.</summary>
    [JsonPropertyName("httpCheck")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderHttpCheck>? HttpCheck { get; set; }

    /// <summary>The [monitored resource] (https://cloud.google.com/monitoring/api/resources) associated with the configuration. The following monitored resource types are supported for uptime checks:</summary>
    [JsonPropertyName("monitoredResource")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderMonitoredResource>? MonitoredResource { get; set; }

    /// <summary>How often, in seconds, the uptime check is performed. Currently, the only supported values are 60s (1 minute), 300s (5 minutes), 600s (10 minutes), and 900s (15 minutes). Optional, defaults to 300s.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The group resource associated with the configuration. Structure is documented below.</summary>
    [JsonPropertyName("resourceGroup")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderResourceGroup>? ResourceGroup { get; set; }

    /// <summary>The list of regions from which the check will be run. Some regions contain one location, and others contain more than one. If this field is specified, enough regions to include a minimum of 3 locations must be provided, or an error message is returned. Not specifying this field will result in uptime checks running from all regions.</summary>
    [JsonPropertyName("selectedRegions")]
    public IList<string>? SelectedRegions { get; set; }

    /// <summary>A Synthetic Monitor deployed to a Cloud Functions V2 instance. Structure is documented below.</summary>
    [JsonPropertyName("syntheticMonitor")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderSyntheticMonitor>? SyntheticMonitor { get; set; }

    /// <summary>Contains information needed to make a TCP check. Structure is documented below.</summary>
    [JsonPropertyName("tcpCheck")]
    public IList<V1beta1UptimeCheckConfigSpecForProviderTcpCheck>? TcpCheck { get; set; }

    /// <summary>The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). See the accepted formats</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>User-supplied key/value data to be used for organizing and identifying the UptimeCheckConfig objects. The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderContentMatchersJsonPathMatcher
{
    /// <summary>Options to perform JSONPath content matching. Default value is EXACT_MATCH. Possible values are: EXACT_MATCH, REGEX_MATCH.</summary>
    [JsonPropertyName("jsonMatcher")]
    public string? JsonMatcher { get; set; }

    /// <summary>JSONPath within the response output pointing to the expected ContentMatcher::content to match against.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderContentMatchers
{
    /// <summary>String or regex content to match (max 1024 bytes)</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Information needed to perform a JSONPath content match. Used for ContentMatcherOption::MATCHES_JSON_PATH and ContentMatcherOption::NOT_MATCHES_JSON_PATH. Structure is documented below.</summary>
    [JsonPropertyName("jsonPathMatcher")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderContentMatchersJsonPathMatcher>? JsonPathMatcher { get; set; }

    /// <summary>The type of content matcher that will be applied to the server output, compared to the content string when the check is run. Default value is CONTAINS_STRING. Possible values are: CONTAINS_STRING, NOT_CONTAINS_STRING, MATCHES_REGEX, NOT_MATCHES_REGEX, MATCHES_JSON_PATH, NOT_MATCHES_JSON_PATH.</summary>
    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderHttpCheckAcceptedResponseStatusCodes
{
    /// <summary>A class of status codes to accept. Possible values are: STATUS_CLASS_1XX, STATUS_CLASS_2XX, STATUS_CLASS_3XX, STATUS_CLASS_4XX, STATUS_CLASS_5XX, STATUS_CLASS_ANY.</summary>
    [JsonPropertyName("statusClass")]
    public string? StatusClass { get; set; }

    /// <summary>A status code to accept.</summary>
    [JsonPropertyName("statusValue")]
    public double? StatusValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderHttpCheckAuthInfo
{
    /// <summary>The username to authenticate.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderHttpCheckPingConfig
{
    /// <summary>Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.</summary>
    [JsonPropertyName("pingsCount")]
    public double? PingsCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderHttpCheckServiceAgentAuthentication
{
    /// <summary>The type of authentication to use. Possible values are: SERVICE_AGENT_AUTHENTICATION_TYPE_UNSPECIFIED, OIDC_TOKEN.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderHttpCheck
{
    /// <summary>If present, the check will only pass if the HTTP response status code is in this set of status codes. If empty, the HTTP status code will only pass if the HTTP status code is 200-299. Structure is documented below.</summary>
    [JsonPropertyName("acceptedResponseStatusCodes")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderHttpCheckAcceptedResponseStatusCodes>? AcceptedResponseStatusCodes { get; set; }

    /// <summary>The authentication information. Optional when creating an HTTP check; defaults to empty. Structure is documented below.</summary>
    [JsonPropertyName("authInfo")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderHttpCheckAuthInfo>? AuthInfo { get; set; }

    /// <summary>The request body associated with the HTTP POST request. If content_type is URL_ENCODED, the body passed in must be URL-encoded. Users can provide a Content-Length header via the headers field or the API will do so. If the request_method is GET and body is not empty, the API will return an error. The maximum byte size is 1 megabyte. Note - As with all bytes fields JSON representations are base64 encoded. e.g. foo=bar in URL-encoded form is foo%3Dbar and in base64 encoding is Zm9vJTI1M0RiYXI=.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>The content type to use for the check. Possible values are: TYPE_UNSPECIFIED, URL_ENCODED, USER_PROVIDED.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>A user provided content type header to use for the check. The invalid configurations outlined in the content_type field apply to custom_content_type, as well as the following 1. content_typeisURL_ENCODEDandcustom_content_typeis set. 2.content_typeisUSER_PROVIDEDandcustom_content_type` is not set.</summary>
    [JsonPropertyName("customContentType")]
    public string? CustomContentType { get; set; }

    /// <summary>The list of headers to send as part of the uptime check request. If two headers have the same key and different values, they should be entered as a single header, with the value being a comma-separated list of all the desired values as described in RFC 2616 (page 31). Entering two separate headers with the same key in a Create call will cause the first to be overwritten by the second. The maximum number of headers allowed is 100.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Boolean specifying whether to encrypt the header information. Encryption should be specified for any headers related to authentication that you do not wish to be seen when retrieving the configuration. The server will be responsible for encrypting the headers. On Get/List calls, if mask_headers is set to true then the headers will be obscured with ******.</summary>
    [JsonPropertyName("maskHeaders")]
    public bool? MaskHeaders { get; set; }

    /// <summary>The path to the page to run the check against. Will be combined with the host (specified within the MonitoredResource) and port to construct the full URL. If the provided path does not begin with /, a / will be prepended automatically. Optional (defaults to /).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Contains information needed to add pings to an HTTP check. Structure is documented below.</summary>
    [JsonPropertyName("pingConfig")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderHttpCheckPingConfig>? PingConfig { get; set; }

    /// <summary>The port to the page to run the check against. Will be combined with host (specified within the monitored_resource) and path to construct the full URL. Optional (defaults to 80 without SSL, or 443 with SSL).</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The HTTP request method to use for the check. If set to METHOD_UNSPECIFIED then request_method defaults to GET. Default value is GET. Possible values are: METHOD_UNSPECIFIED, GET, POST.</summary>
    [JsonPropertyName("requestMethod")]
    public string? RequestMethod { get; set; }

    /// <summary>The authentication information using the Monitoring Service Agent. Optional when creating an HTTPS check; defaults to empty. Do not use with other authentication fields. Structure is documented below.</summary>
    [JsonPropertyName("serviceAgentAuthentication")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderHttpCheckServiceAgentAuthentication>? ServiceAgentAuthentication { get; set; }

    /// <summary>If true, use HTTPS instead of HTTP to run the check.</summary>
    [JsonPropertyName("useSsl")]
    public bool? UseSsl { get; set; }

    /// <summary>Boolean specifying whether to include SSL certificate validation as a part of the Uptime check. Only applies to checks where monitored_resource is set to uptime_url. If use_ssl is false, setting validate_ssl to true has no effect.</summary>
    [JsonPropertyName("validateSsl")]
    public bool? ValidateSsl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderMonitoredResource
{
    /// <summary>Values for all of the labels listed in the associated monitored resource descriptor. For example, Compute Engine VM instances use the labels project_id, instance_id, and zone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The monitored resource type. This field must match the type field of a MonitoredResourceDescriptor object. For example, the type of a Compute Engine VM instance is gce_instance. For a list of types, see Monitoring resource types and Logging resource types.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in monitoring to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in monitoring to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderResourceGroup
{
    /// <summary>The group of resources being monitored. Should be the name of a group</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Reference to a Group in monitoring to populate groupId.</summary>
    [JsonPropertyName("groupIdRef")]
    public V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdRef? GroupIdRef { get; set; }

    /// <summary>Selector for a Group in monitoring to populate groupId.</summary>
    [JsonPropertyName("groupIdSelector")]
    public V1beta1UptimeCheckConfigSpecInitProviderResourceGroupGroupIdSelector? GroupIdSelector { get; set; }

    /// <summary>The resource type of the group members. Possible values are: RESOURCE_TYPE_UNSPECIFIED, INSTANCE, AWS_ELB_LOAD_BALANCER.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfunctions2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfunctions2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2
{
    /// <summary>The fully qualified name of the cloud function resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Function in cloudfunctions2 to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameRef? NameRef { get; set; }

    /// <summary>Selector for a Function in cloudfunctions2 to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2NameSelector? NameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitor
{
    /// <summary>Target a Synthetic Monitor GCFv2 Instance Structure is documented below.</summary>
    [JsonPropertyName("cloudFunctionV2")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitorCloudFunctionV2>? CloudFunctionV2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderTcpCheckPingConfig
{
    /// <summary>Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.</summary>
    [JsonPropertyName("pingsCount")]
    public double? PingsCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProviderTcpCheck
{
    /// <summary>Contains information needed to add pings to a TCP check. Structure is documented below.</summary>
    [JsonPropertyName("pingConfig")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderTcpCheckPingConfig>? PingConfig { get; set; }

    /// <summary>The port to the page to run the check against. Will be combined with host (specified within the monitored_resource) to construct the full URL.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecInitProvider
{
    /// <summary>The checker type to use for the check. If the monitored resource type is servicedirectory_service, checker_type must be set to VPC_CHECKERS. Possible values are: STATIC_IP_CHECKERS, VPC_CHECKERS.</summary>
    [JsonPropertyName("checkerType")]
    public string? CheckerType { get; set; }

    /// <summary>The expected content on the page the check is run against. Currently, only the first entry in the list is supported, and other entries will be ignored. The server will look for an exact match of the string in the page response's content. This field is optional and should only be specified if a content match is required. Structure is documented below.</summary>
    [JsonPropertyName("contentMatchers")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderContentMatchers>? ContentMatchers { get; set; }

    /// <summary>A human-friendly name for the uptime check configuration. The display name should be unique within a Stackdriver Workspace in order to make it easier to identify; however, uniqueness is not enforced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Contains information needed to make an HTTP or HTTPS check. Structure is documented below.</summary>
    [JsonPropertyName("httpCheck")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderHttpCheck>? HttpCheck { get; set; }

    /// <summary>The [monitored resource] (https://cloud.google.com/monitoring/api/resources) associated with the configuration. The following monitored resource types are supported for uptime checks:</summary>
    [JsonPropertyName("monitoredResource")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderMonitoredResource>? MonitoredResource { get; set; }

    /// <summary>How often, in seconds, the uptime check is performed. Currently, the only supported values are 60s (1 minute), 300s (5 minutes), 600s (10 minutes), and 900s (15 minutes). Optional, defaults to 300s.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The group resource associated with the configuration. Structure is documented below.</summary>
    [JsonPropertyName("resourceGroup")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderResourceGroup>? ResourceGroup { get; set; }

    /// <summary>The list of regions from which the check will be run. Some regions contain one location, and others contain more than one. If this field is specified, enough regions to include a minimum of 3 locations must be provided, or an error message is returned. Not specifying this field will result in uptime checks running from all regions.</summary>
    [JsonPropertyName("selectedRegions")]
    public IList<string>? SelectedRegions { get; set; }

    /// <summary>A Synthetic Monitor deployed to a Cloud Functions V2 instance. Structure is documented below.</summary>
    [JsonPropertyName("syntheticMonitor")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderSyntheticMonitor>? SyntheticMonitor { get; set; }

    /// <summary>Contains information needed to make a TCP check. Structure is documented below.</summary>
    [JsonPropertyName("tcpCheck")]
    public IList<V1beta1UptimeCheckConfigSpecInitProviderTcpCheck>? TcpCheck { get; set; }

    /// <summary>The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). See the accepted formats</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>User-supplied key/value data to be used for organizing and identifying the UptimeCheckConfig objects. The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecProviderConfigRefPolicy
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
public partial class V1beta1UptimeCheckConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1UptimeCheckConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UptimeCheckConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1UptimeCheckConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1UptimeCheckConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1UptimeCheckConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>UptimeCheckConfigSpec defines the desired state of UptimeCheckConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UptimeCheckConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UptimeCheckConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UptimeCheckConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1UptimeCheckConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UptimeCheckConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderContentMatchersJsonPathMatcher
{
    /// <summary>Options to perform JSONPath content matching. Default value is EXACT_MATCH. Possible values are: EXACT_MATCH, REGEX_MATCH.</summary>
    [JsonPropertyName("jsonMatcher")]
    public string? JsonMatcher { get; set; }

    /// <summary>JSONPath within the response output pointing to the expected ContentMatcher::content to match against.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderContentMatchers
{
    /// <summary>String or regex content to match (max 1024 bytes)</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Information needed to perform a JSONPath content match. Used for ContentMatcherOption::MATCHES_JSON_PATH and ContentMatcherOption::NOT_MATCHES_JSON_PATH. Structure is documented below.</summary>
    [JsonPropertyName("jsonPathMatcher")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderContentMatchersJsonPathMatcher>? JsonPathMatcher { get; set; }

    /// <summary>The type of content matcher that will be applied to the server output, compared to the content string when the check is run. Default value is CONTAINS_STRING. Possible values are: CONTAINS_STRING, NOT_CONTAINS_STRING, MATCHES_REGEX, NOT_MATCHES_REGEX, MATCHES_JSON_PATH, NOT_MATCHES_JSON_PATH.</summary>
    [JsonPropertyName("matcher")]
    public string? Matcher { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderHttpCheckAcceptedResponseStatusCodes
{
    /// <summary>A class of status codes to accept. Possible values are: STATUS_CLASS_1XX, STATUS_CLASS_2XX, STATUS_CLASS_3XX, STATUS_CLASS_4XX, STATUS_CLASS_5XX, STATUS_CLASS_ANY.</summary>
    [JsonPropertyName("statusClass")]
    public string? StatusClass { get; set; }

    /// <summary>A status code to accept.</summary>
    [JsonPropertyName("statusValue")]
    public double? StatusValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderHttpCheckAuthInfo
{
    /// <summary>The username to authenticate.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderHttpCheckPingConfig
{
    /// <summary>Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.</summary>
    [JsonPropertyName("pingsCount")]
    public double? PingsCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderHttpCheckServiceAgentAuthentication
{
    /// <summary>The type of authentication to use. Possible values are: SERVICE_AGENT_AUTHENTICATION_TYPE_UNSPECIFIED, OIDC_TOKEN.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderHttpCheck
{
    /// <summary>If present, the check will only pass if the HTTP response status code is in this set of status codes. If empty, the HTTP status code will only pass if the HTTP status code is 200-299. Structure is documented below.</summary>
    [JsonPropertyName("acceptedResponseStatusCodes")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderHttpCheckAcceptedResponseStatusCodes>? AcceptedResponseStatusCodes { get; set; }

    /// <summary>The authentication information. Optional when creating an HTTP check; defaults to empty. Structure is documented below.</summary>
    [JsonPropertyName("authInfo")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderHttpCheckAuthInfo>? AuthInfo { get; set; }

    /// <summary>The request body associated with the HTTP POST request. If content_type is URL_ENCODED, the body passed in must be URL-encoded. Users can provide a Content-Length header via the headers field or the API will do so. If the request_method is GET and body is not empty, the API will return an error. The maximum byte size is 1 megabyte. Note - As with all bytes fields JSON representations are base64 encoded. e.g. foo=bar in URL-encoded form is foo%3Dbar and in base64 encoding is Zm9vJTI1M0RiYXI=.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>The content type to use for the check. Possible values are: TYPE_UNSPECIFIED, URL_ENCODED, USER_PROVIDED.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>A user provided content type header to use for the check. The invalid configurations outlined in the content_type field apply to custom_content_type, as well as the following 1. content_typeisURL_ENCODEDandcustom_content_typeis set. 2.content_typeisUSER_PROVIDEDandcustom_content_type` is not set.</summary>
    [JsonPropertyName("customContentType")]
    public string? CustomContentType { get; set; }

    /// <summary>The list of headers to send as part of the uptime check request. If two headers have the same key and different values, they should be entered as a single header, with the value being a comma-separated list of all the desired values as described in RFC 2616 (page 31). Entering two separate headers with the same key in a Create call will cause the first to be overwritten by the second. The maximum number of headers allowed is 100.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Boolean specifying whether to encrypt the header information. Encryption should be specified for any headers related to authentication that you do not wish to be seen when retrieving the configuration. The server will be responsible for encrypting the headers. On Get/List calls, if mask_headers is set to true then the headers will be obscured with ******.</summary>
    [JsonPropertyName("maskHeaders")]
    public bool? MaskHeaders { get; set; }

    /// <summary>The path to the page to run the check against. Will be combined with the host (specified within the MonitoredResource) and port to construct the full URL. If the provided path does not begin with /, a / will be prepended automatically. Optional (defaults to /).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Contains information needed to add pings to an HTTP check. Structure is documented below.</summary>
    [JsonPropertyName("pingConfig")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderHttpCheckPingConfig>? PingConfig { get; set; }

    /// <summary>The port to the page to run the check against. Will be combined with host (specified within the monitored_resource) and path to construct the full URL. Optional (defaults to 80 without SSL, or 443 with SSL).</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The HTTP request method to use for the check. If set to METHOD_UNSPECIFIED then request_method defaults to GET. Default value is GET. Possible values are: METHOD_UNSPECIFIED, GET, POST.</summary>
    [JsonPropertyName("requestMethod")]
    public string? RequestMethod { get; set; }

    /// <summary>The authentication information using the Monitoring Service Agent. Optional when creating an HTTPS check; defaults to empty. Do not use with other authentication fields. Structure is documented below.</summary>
    [JsonPropertyName("serviceAgentAuthentication")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderHttpCheckServiceAgentAuthentication>? ServiceAgentAuthentication { get; set; }

    /// <summary>If true, use HTTPS instead of HTTP to run the check.</summary>
    [JsonPropertyName("useSsl")]
    public bool? UseSsl { get; set; }

    /// <summary>Boolean specifying whether to include SSL certificate validation as a part of the Uptime check. Only applies to checks where monitored_resource is set to uptime_url. If use_ssl is false, setting validate_ssl to true has no effect.</summary>
    [JsonPropertyName("validateSsl")]
    public bool? ValidateSsl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderMonitoredResource
{
    /// <summary>Values for all of the labels listed in the associated monitored resource descriptor. For example, Compute Engine VM instances use the labels project_id, instance_id, and zone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The monitored resource type. This field must match the type field of a MonitoredResourceDescriptor object. For example, the type of a Compute Engine VM instance is gce_instance. For a list of types, see Monitoring resource types and Logging resource types.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderResourceGroup
{
    /// <summary>The group of resources being monitored. Should be the name of a group</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>The resource type of the group members. Possible values are: RESOURCE_TYPE_UNSPECIFIED, INSTANCE, AWS_ELB_LOAD_BALANCER.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderSyntheticMonitorCloudFunctionV2
{
    /// <summary>The fully qualified name of the cloud function resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderSyntheticMonitor
{
    /// <summary>Target a Synthetic Monitor GCFv2 Instance Structure is documented below.</summary>
    [JsonPropertyName("cloudFunctionV2")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderSyntheticMonitorCloudFunctionV2>? CloudFunctionV2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderTcpCheckPingConfig
{
    /// <summary>Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.</summary>
    [JsonPropertyName("pingsCount")]
    public double? PingsCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProviderTcpCheck
{
    /// <summary>Contains information needed to add pings to a TCP check. Structure is documented below.</summary>
    [JsonPropertyName("pingConfig")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderTcpCheckPingConfig>? PingConfig { get; set; }

    /// <summary>The port to the page to run the check against. Will be combined with host (specified within the monitored_resource) to construct the full URL.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusAtProvider
{
    /// <summary>The checker type to use for the check. If the monitored resource type is servicedirectory_service, checker_type must be set to VPC_CHECKERS. Possible values are: STATIC_IP_CHECKERS, VPC_CHECKERS.</summary>
    [JsonPropertyName("checkerType")]
    public string? CheckerType { get; set; }

    /// <summary>The expected content on the page the check is run against. Currently, only the first entry in the list is supported, and other entries will be ignored. The server will look for an exact match of the string in the page response's content. This field is optional and should only be specified if a content match is required. Structure is documented below.</summary>
    [JsonPropertyName("contentMatchers")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderContentMatchers>? ContentMatchers { get; set; }

    /// <summary>A human-friendly name for the uptime check configuration. The display name should be unique within a Stackdriver Workspace in order to make it easier to identify; however, uniqueness is not enforced.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Contains information needed to make an HTTP or HTTPS check. Structure is documented below.</summary>
    [JsonPropertyName("httpCheck")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderHttpCheck>? HttpCheck { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The [monitored resource] (https://cloud.google.com/monitoring/api/resources) associated with the configuration. The following monitored resource types are supported for uptime checks:</summary>
    [JsonPropertyName("monitoredResource")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderMonitoredResource>? MonitoredResource { get; set; }

    /// <summary>A unique resource name for this UptimeCheckConfig. The format is projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID].</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>How often, in seconds, the uptime check is performed. Currently, the only supported values are 60s (1 minute), 300s (5 minutes), 600s (10 minutes), and 900s (15 minutes). Optional, defaults to 300s.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The group resource associated with the configuration. Structure is documented below.</summary>
    [JsonPropertyName("resourceGroup")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderResourceGroup>? ResourceGroup { get; set; }

    /// <summary>The list of regions from which the check will be run. Some regions contain one location, and others contain more than one. If this field is specified, enough regions to include a minimum of 3 locations must be provided, or an error message is returned. Not specifying this field will result in uptime checks running from all regions.</summary>
    [JsonPropertyName("selectedRegions")]
    public IList<string>? SelectedRegions { get; set; }

    /// <summary>A Synthetic Monitor deployed to a Cloud Functions V2 instance. Structure is documented below.</summary>
    [JsonPropertyName("syntheticMonitor")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderSyntheticMonitor>? SyntheticMonitor { get; set; }

    /// <summary>Contains information needed to make a TCP check. Structure is documented below.</summary>
    [JsonPropertyName("tcpCheck")]
    public IList<V1beta1UptimeCheckConfigStatusAtProviderTcpCheck>? TcpCheck { get; set; }

    /// <summary>The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). See the accepted formats</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>The id of the uptime check</summary>
    [JsonPropertyName("uptimeCheckId")]
    public string? UptimeCheckId { get; set; }

    /// <summary>User-supplied key/value data to be used for organizing and identifying the UptimeCheckConfig objects. The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatusConditions
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

/// <summary>UptimeCheckConfigStatus defines the observed state of UptimeCheckConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UptimeCheckConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UptimeCheckConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UptimeCheckConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>UptimeCheckConfig is the Schema for the UptimeCheckConfigs API. This message configures which resources and services to monitor for availability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UptimeCheckConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UptimeCheckConfigSpec>, IStatus<V1beta1UptimeCheckConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UptimeCheckConfig";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "uptimecheckconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UptimeCheckConfigSpec defines the desired state of UptimeCheckConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1UptimeCheckConfigSpec Spec { get; set; }

    /// <summary>UptimeCheckConfigStatus defines the observed state of UptimeCheckConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1UptimeCheckConfigStatus? Status { get; set; }
}