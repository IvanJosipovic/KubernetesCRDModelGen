using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appengine.cnrm.cloud.google.com;
public partial class V1alpha1AppEngineStandardAppVersionSpecAutomaticScalingStandardSchedulerSettings
{
    /// <summary>Maximum number of instances to run for this version. Set to zero to disable maxInstances configuration.</summary>
    [JsonPropertyName("maxInstances")]
    public int? MaxInstances { get; set; }

    /// <summary>Minimum number of instances to run for this version. Set to zero to disable minInstances configuration.</summary>
    [JsonPropertyName("minInstances")]
    public int? MinInstances { get; set; }

    /// <summary>Target CPU utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetCpuUtilization")]
    public double? TargetCpuUtilization { get; set; }

    /// <summary>Target throughput utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetThroughputUtilization")]
    public double? TargetThroughputUtilization { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecAutomaticScaling
{
    /// <summary>Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance.  Defaults to a runtime-specific value.</summary>
    [JsonPropertyName("maxConcurrentRequests")]
    public int? MaxConcurrentRequests { get; set; }

    /// <summary>Maximum number of idle instances that should be maintained for this version.</summary>
    [JsonPropertyName("maxIdleInstances")]
    public int? MaxIdleInstances { get; set; }

    /// <summary>Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxPendingLatency")]
    public string? MaxPendingLatency { get; set; }

    /// <summary>Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.</summary>
    [JsonPropertyName("minIdleInstances")]
    public int? MinIdleInstances { get; set; }

    /// <summary>Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minPendingLatency")]
    public string? MinPendingLatency { get; set; }

    /// <summary>Scheduler settings for standard environment.</summary>
    [JsonPropertyName("standardSchedulerSettings")]
    public V1alpha1AppEngineStandardAppVersionSpecAutomaticScalingStandardSchedulerSettings? StandardSchedulerSettings { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecBasicScaling
{
    /// <summary>Duration of time after the last request that an instance must wait before the instance is shut down. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Defaults to 900s.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].</summary>
    [JsonPropertyName("maxInstances")]
    public int MaxInstances { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecDeploymentFiles
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>SHA1 checksum of the file.</summary>
    [JsonPropertyName("sha1Sum")]
    public string? Sha1Sum { get; set; }

    /// <summary>Source URL.</summary>
    [JsonPropertyName("sourceUrl")]
    public string SourceUrl { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecDeploymentZip
{
    /// <summary>files count.</summary>
    [JsonPropertyName("filesCount")]
    public int? FilesCount { get; set; }

    /// <summary>Source URL.</summary>
    [JsonPropertyName("sourceUrl")]
    public string SourceUrl { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecDeployment
{
    /// <summary>Manifest of the files stored in Google Cloud Storage that are included as part of this version. All files must be readable using the credentials supplied with this call.</summary>
    [JsonPropertyName("files")]
    public IList<V1alpha1AppEngineStandardAppVersionSpecDeploymentFiles>? Files { get; set; }

    /// <summary>Zip File.</summary>
    [JsonPropertyName("zip")]
    public V1alpha1AppEngineStandardAppVersionSpecDeploymentZip? Zip { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecEntrypoint
{
    /// <summary>The format should be a shell command that can be fed to bash -c.</summary>
    [JsonPropertyName("shell")]
    public string Shell { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecHandlersScript
{
    /// <summary>Path to the script from the application root directory.</summary>
    [JsonPropertyName("scriptPath")]
    public string ScriptPath { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecHandlersStaticFiles
{
    /// <summary>Whether files should also be uploaded as code data. By default, files declared in static file handlers are uploaded as static data and are only served to end users; they cannot be read by the application. If enabled, uploads are charged against both your code and static data storage resource quotas.</summary>
    [JsonPropertyName("applicationReadable")]
    public bool? ApplicationReadable { get; set; }

    /// <summary>Time a static file served by this handler should be cached by web proxies and browsers. A duration in seconds with up to nine fractional digits, terminated by 's'. Example "3.5s".</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>HTTP headers to use for all responses from these URLs. An object containing a list of "key:value" value pairs.".</summary>
    [JsonPropertyName("httpHeaders")]
    public IDictionary<string, string>? HttpHeaders { get; set; }

    /// <summary>MIME type used to serve all files served by this handler. Defaults to file-specific MIME types, which are derived from each file's filename extension.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>Path to the static files matched by the URL pattern, from the application root directory. The path can refer to text matched in groupings in the URL pattern.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether this handler should match the request if the file referenced by the handler does not exist.</summary>
    [JsonPropertyName("requireMatchingFile")]
    public bool? RequireMatchingFile { get; set; }

    /// <summary>Regular expression that matches the file paths for all files that should be referenced by this handler.</summary>
    [JsonPropertyName("uploadPathRegex")]
    public string? UploadPathRegex { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecHandlers
{
    /// <summary>Actions to take when the user is not logged in. Possible values: ["AUTH_FAIL_ACTION_REDIRECT", "AUTH_FAIL_ACTION_UNAUTHORIZED"].</summary>
    [JsonPropertyName("authFailAction")]
    public string? AuthFailAction { get; set; }

    /// <summary>Methods to restrict access to a URL based on login status. Possible values: ["LOGIN_OPTIONAL", "LOGIN_ADMIN", "LOGIN_REQUIRED"].</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>30x code to use when performing redirects for the secure field. Possible values: ["REDIRECT_HTTP_RESPONSE_CODE_301", "REDIRECT_HTTP_RESPONSE_CODE_302", "REDIRECT_HTTP_RESPONSE_CODE_303", "REDIRECT_HTTP_RESPONSE_CODE_307"].</summary>
    [JsonPropertyName("redirectHttpResponseCode")]
    public string? RedirectHttpResponseCode { get; set; }

    /// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto".</summary>
    [JsonPropertyName("script")]
    public V1alpha1AppEngineStandardAppVersionSpecHandlersScript? Script { get; set; }

    /// <summary>Security (HTTPS) enforcement for this URL. Possible values: ["SECURE_DEFAULT", "SECURE_NEVER", "SECURE_OPTIONAL", "SECURE_ALWAYS"].</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }

    /// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them.</summary>
    [JsonPropertyName("staticFiles")]
    public V1alpha1AppEngineStandardAppVersionSpecHandlersStaticFiles? StaticFiles { get; set; }

    /// <summary>URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings. All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.</summary>
    [JsonPropertyName("urlRegex")]
    public string? UrlRegex { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecLibraries
{
    /// <summary>Name of the library. Example "django".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Version of the library to select, or "latest".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecManualScaling
{
    /// <summary>Number of instances to assign to the service at the start.  **Note:** When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2 Modules API set_num_instances() you must use 'lifecycle.ignore_changes = ["manual_scaling"[0].instances]' to prevent drift detection.</summary>
    [JsonPropertyName("instances")]
    public int Instances { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecServiceRef
{
    /// <summary>Allowed value: The `name` field of an `AppEngineService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpecVpcAccessConnector
{
    /// <summary>The egress setting for the connector, controlling what traffic is diverted through it.</summary>
    [JsonPropertyName("egressSetting")]
    public string? EgressSetting { get; set; }

    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionSpec
{
    /// <summary>Allows App Engine second generation runtimes to access the legacy bundled services.</summary>
    [JsonPropertyName("appEngineApis")]
    public bool? AppEngineApis { get; set; }

    /// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics.</summary>
    [JsonPropertyName("automaticScaling")]
    public V1alpha1AppEngineStandardAppVersionSpecAutomaticScaling? AutomaticScaling { get; set; }

    /// <summary>Basic scaling creates instances when your application receives requests. Each instance will be shut down when the application becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity.</summary>
    [JsonPropertyName("basicScaling")]
    public V1alpha1AppEngineStandardAppVersionSpecBasicScaling? BasicScaling { get; set; }

    /// <summary>If set to 'true', the service will be deleted if it is the last version.</summary>
    [JsonPropertyName("deleteServiceOnDestroy")]
    public bool? DeleteServiceOnDestroy { get; set; }

    /// <summary>Code and application artifacts that make up this version.</summary>
    [JsonPropertyName("deployment")]
    public V1alpha1AppEngineStandardAppVersionSpecDeployment Deployment { get; set; }

    /// <summary>The entrypoint for the application.</summary>
    [JsonPropertyName("entrypoint")]
    public V1alpha1AppEngineStandardAppVersionSpecEntrypoint Entrypoint { get; set; }

    /// <summary>Environment variables available to the application.</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>An ordered list of URL-matching patterns that should be applied to incoming requests. The first matching URL handles the request and other request handlers are not attempted.</summary>
    [JsonPropertyName("handlers")]
    public IList<V1alpha1AppEngineStandardAppVersionSpecHandlers>? Handlers { get; set; }

    /// <summary>A list of the types of messages that this application is able to receive. Possible values: ["INBOUND_SERVICE_MAIL", "INBOUND_SERVICE_MAIL_BOUNCE", "INBOUND_SERVICE_XMPP_ERROR", "INBOUND_SERVICE_XMPP_MESSAGE", "INBOUND_SERVICE_XMPP_SUBSCRIBE", "INBOUND_SERVICE_XMPP_PRESENCE", "INBOUND_SERVICE_CHANNEL_PRESENCE", "INBOUND_SERVICE_WARMUP"].</summary>
    [JsonPropertyName("inboundServices")]
    public IList<string>? InboundServices { get; set; }

    /// <summary>Instance class that is used to run this version. Valid values are AutomaticScaling: F1, F2, F4, F4_1G BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8 Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>Configuration for third-party Python runtime libraries that are required by the application.</summary>
    [JsonPropertyName("libraries")]
    public IList<V1alpha1AppEngineStandardAppVersionSpecLibraries>? Libraries { get; set; }

    /// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time.</summary>
    [JsonPropertyName("manualScaling")]
    public V1alpha1AppEngineStandardAppVersionSpecManualScaling? ManualScaling { get; set; }

    /// <summary>If set to 'true', the application version will not be deleted.</summary>
    [JsonPropertyName("noopOnDestroy")]
    public bool? NoopOnDestroy { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Immutable. Optional. The versionId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Desired runtime. Example python27.</summary>
    [JsonPropertyName("runtime")]
    public string Runtime { get; set; }

    /// <summary>The version of the API in the given runtime environment. Please see the app.yaml reference for valid values at 'https://cloud.google.com/appengine/docs/standard/&lt;language&gt;/config/appref'\ Substitute '&lt;language&gt;' with 'python', 'java', 'php', 'ruby', 'go' or 'nodejs'.</summary>
    [JsonPropertyName("runtimeApiVersion")]
    public string? RuntimeApiVersion { get; set; }

    /// <summary>The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1AppEngineStandardAppVersionSpecServiceRef ServiceRef { get; set; }

    /// <summary>Whether multiple requests can be dispatched to this version at once.</summary>
    [JsonPropertyName("threadsafe")]
    public bool? Threadsafe { get; set; }

    /// <summary>Enables VPC connectivity for standard apps.</summary>
    [JsonPropertyName("vpcAccessConnector")]
    public V1alpha1AppEngineStandardAppVersionSpecVpcAccessConnector? VpcAccessConnector { get; set; }
}

public partial class V1alpha1AppEngineStandardAppVersionStatusConditions
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

public partial class V1alpha1AppEngineStandardAppVersionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AppEngineStandardAppVersionStatusConditions>? Conditions { get; set; }

    /// <summary>Full path to the Version resource in the API. Example, "v1".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppEngineStandardAppVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppEngineStandardAppVersionSpec>, IStatus<V1alpha1AppEngineStandardAppVersionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppEngineStandardAppVersion";
    public const string KubeGroup = "appengine.cnrm.cloud.google.com";
    public const string KubePluralName = "appenginestandardappversions";
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
    public V1alpha1AppEngineStandardAppVersionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1AppEngineStandardAppVersionStatus? Status { get; set; }
}