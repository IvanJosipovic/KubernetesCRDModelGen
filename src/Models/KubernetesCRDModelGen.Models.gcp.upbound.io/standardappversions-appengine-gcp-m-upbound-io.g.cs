using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appengine.gcp.m.upbound.io;
/// <summary>StandardAppVersion is the Schema for the StandardAppVersions API. Standard App Version resource to create a new version of standard GAE Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StandardAppVersionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StandardAppVersion>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StandardAppVersionList";
    public const string KubeGroup = "appengine.gcp.m.upbound.io";
    public const string KubePluralName = "standardappversions";
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
    public IList<V1beta1StandardAppVersion> Items { get; set; }
}

/// <summary>Scheduler settings for standard environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderAutomaticScalingStandardSchedulerSettings
{
    /// <summary>Maximum number of instances to run for this version. Set to zero to disable maxInstances configuration. Note: Starting from March 2025, App Engine sets the maxInstances default for standard environment deployments to 20. This change doesn't impact existing apps. To override the default, specify a new value between 0 and 2147483647, and deploy a new version or redeploy over an existing version. To disable the maxInstances default configuration setting, specify the maximum permitted value 2147483647.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances to run for this version. Set to zero to disable minInstances configuration.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>Target CPU utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetCpuUtilization")]
    public double? TargetCpuUtilization { get; set; }

    /// <summary>Target throughput utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetThroughputUtilization")]
    public double? TargetThroughputUtilization { get; set; }
}

/// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderAutomaticScaling
{
    /// <summary>Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance. Defaults to a runtime-specific value.</summary>
    [JsonPropertyName("maxConcurrentRequests")]
    public double? MaxConcurrentRequests { get; set; }

    /// <summary>Maximum number of idle instances that should be maintained for this version.</summary>
    [JsonPropertyName("maxIdleInstances")]
    public double? MaxIdleInstances { get; set; }

    /// <summary>Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxPendingLatency")]
    public string? MaxPendingLatency { get; set; }

    /// <summary>Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minPendingLatency")]
    public string? MinPendingLatency { get; set; }

    /// <summary>Scheduler settings for standard environment. Structure is documented below.</summary>
    [JsonPropertyName("standardSchedulerSettings")]
    public V1beta1StandardAppVersionSpecForProviderAutomaticScalingStandardSchedulerSettings? StandardSchedulerSettings { get; set; }
}

/// <summary>Basic scaling creates instances when your application receives requests. Each instance will be shut down when the application becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderBasicScaling
{
    /// <summary>Duration of time after the last request that an instance must wait before the instance is shut down. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Defaults to 900s.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderDeploymentFiles
{
    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SHA1 checksum of the file</summary>
    [JsonPropertyName("sha1Sum")]
    public string? Sha1Sum { get; set; }

    /// <summary>Source URL</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }
}

/// <summary>Zip File Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderDeploymentZip
{
    /// <summary>files count</summary>
    [JsonPropertyName("filesCount")]
    public double? FilesCount { get; set; }

    /// <summary>Source URL</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }
}

/// <summary>Code and application artifacts that make up this version. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderDeployment
{
    /// <summary>Manifest of the files stored in Google Cloud Storage that are included as part of this version. All files must be readable using the credentials supplied with this call. Structure is documented below.</summary>
    [JsonPropertyName("files")]
    public IList<V1beta1StandardAppVersionSpecForProviderDeploymentFiles>? Files { get; set; }

    /// <summary>Zip File Structure is documented below.</summary>
    [JsonPropertyName("zip")]
    public V1beta1StandardAppVersionSpecForProviderDeploymentZip? Zip { get; set; }
}

/// <summary>The entrypoint for the application. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderEntrypoint
{
    /// <summary>The format should be a shell command that can be fed to bash -c.</summary>
    [JsonPropertyName("shell")]
    public string? Shell { get; set; }
}

/// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderHandlersScript
{
    /// <summary>Path to the script from the application root directory.</summary>
    [JsonPropertyName("scriptPath")]
    public string? ScriptPath { get; set; }
}

/// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderHandlersStaticFiles
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderHandlers
{
    /// <summary>Actions to take when the user is not logged in. Possible values are: AUTH_FAIL_ACTION_REDIRECT, AUTH_FAIL_ACTION_UNAUTHORIZED.</summary>
    [JsonPropertyName("authFailAction")]
    public string? AuthFailAction { get; set; }

    /// <summary>Methods to restrict access to a URL based on login status. Possible values are: LOGIN_OPTIONAL, LOGIN_ADMIN, LOGIN_REQUIRED.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>30x code to use when performing redirects for the secure field. Possible values are: REDIRECT_HTTP_RESPONSE_CODE_301, REDIRECT_HTTP_RESPONSE_CODE_302, REDIRECT_HTTP_RESPONSE_CODE_303, REDIRECT_HTTP_RESPONSE_CODE_307.</summary>
    [JsonPropertyName("redirectHttpResponseCode")]
    public string? RedirectHttpResponseCode { get; set; }

    /// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto". Structure is documented below.</summary>
    [JsonPropertyName("script")]
    public V1beta1StandardAppVersionSpecForProviderHandlersScript? Script { get; set; }

    /// <summary>Security (HTTPS) enforcement for this URL. Possible values are: SECURE_DEFAULT, SECURE_NEVER, SECURE_OPTIONAL, SECURE_ALWAYS.</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }

    /// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them. Structure is documented below.</summary>
    [JsonPropertyName("staticFiles")]
    public V1beta1StandardAppVersionSpecForProviderHandlersStaticFiles? StaticFiles { get; set; }

    /// <summary>URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings. All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.</summary>
    [JsonPropertyName("urlRegex")]
    public string? UrlRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderLibraries
{
    /// <summary>Name of the library. Example "django".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Version of the library to select, or "latest".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderManualScaling
{
    /// <summary>Number of instances to assign to the service at the start. Note: When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2 Modules API set_num_instances() you must use lifecycle.ignore_changes = ["manual_scaling"[0].instances] to prevent drift detection.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StandardAppVersionSpecForProviderServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderServiceAccountSelector
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
    public V1beta1StandardAppVersionSpecForProviderServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>Enables VPC connectivity for standard apps. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProviderVpcAccessConnector
{
    /// <summary>The egress setting for the connector, controlling what traffic is diverted through it.</summary>
    [JsonPropertyName("egressSetting")]
    public string? EgressSetting { get; set; }

    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecForProvider
{
    /// <summary>Allows App Engine second generation runtimes to access the legacy bundled services.</summary>
    [JsonPropertyName("appEngineApis")]
    public bool? AppEngineApis { get; set; }

    /// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics. Structure is documented below.</summary>
    [JsonPropertyName("automaticScaling")]
    public V1beta1StandardAppVersionSpecForProviderAutomaticScaling? AutomaticScaling { get; set; }

    /// <summary>Basic scaling creates instances when your application receives requests. Each instance will be shut down when the application becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity. Structure is documented below.</summary>
    [JsonPropertyName("basicScaling")]
    public V1beta1StandardAppVersionSpecForProviderBasicScaling? BasicScaling { get; set; }

    /// <summary>If set to true, the service will be deleted if it is the last version.</summary>
    [JsonPropertyName("deleteServiceOnDestroy")]
    public bool? DeleteServiceOnDestroy { get; set; }

    /// <summary>Code and application artifacts that make up this version. Structure is documented below.</summary>
    [JsonPropertyName("deployment")]
    public V1beta1StandardAppVersionSpecForProviderDeployment? Deployment { get; set; }

    /// <summary>The entrypoint for the application. Structure is documented below.</summary>
    [JsonPropertyName("entrypoint")]
    public V1beta1StandardAppVersionSpecForProviderEntrypoint? Entrypoint { get; set; }

    /// <summary>Environment variables available to the application.</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>An ordered list of URL-matching patterns that should be applied to incoming requests. The first matching URL handles the request and other request handlers are not attempted. Structure is documented below.</summary>
    [JsonPropertyName("handlers")]
    public IList<V1beta1StandardAppVersionSpecForProviderHandlers>? Handlers { get; set; }

    /// <summary>A list of the types of messages that this application is able to receive. Each value may be one of: INBOUND_SERVICE_MAIL, INBOUND_SERVICE_MAIL_BOUNCE, INBOUND_SERVICE_XMPP_ERROR, INBOUND_SERVICE_XMPP_MESSAGE, INBOUND_SERVICE_XMPP_SUBSCRIBE, INBOUND_SERVICE_XMPP_PRESENCE, INBOUND_SERVICE_CHANNEL_PRESENCE, INBOUND_SERVICE_WARMUP.</summary>
    [JsonPropertyName("inboundServices")]
    public IList<string>? InboundServices { get; set; }

    /// <summary>Instance class that is used to run this version. Valid values are AutomaticScaling: F1, F2, F4, F4_1G BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8 Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>Configuration for third-party Python runtime libraries that are required by the application. Structure is documented below.</summary>
    [JsonPropertyName("libraries")]
    public IList<V1beta1StandardAppVersionSpecForProviderLibraries>? Libraries { get; set; }

    /// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time. Structure is documented below.</summary>
    [JsonPropertyName("manualScaling")]
    public V1beta1StandardAppVersionSpecForProviderManualScaling? ManualScaling { get; set; }

    /// <summary>If set to true, the application version will not be deleted.</summary>
    [JsonPropertyName("noopOnDestroy")]
    public bool? NoopOnDestroy { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Desired runtime. Example python27.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>The version of the API in the given runtime environment. Please see the app.yaml reference for valid values at https://cloud.google.com/appengine/docs/standard/&lt;language&gt;/config/appref Substitute &lt;language&gt; with python, java, php, ruby, go or nodejs.</summary>
    [JsonPropertyName("runtimeApiVersion")]
    public string? RuntimeApiVersion { get; set; }

    /// <summary>AppEngine service resource</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }

    /// <summary>The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1StandardAppVersionSpecForProviderServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1StandardAppVersionSpecForProviderServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Whether multiple requests can be dispatched to this version at once.</summary>
    [JsonPropertyName("threadsafe")]
    public bool? Threadsafe { get; set; }

    /// <summary>Enables VPC connectivity for standard apps. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessConnector")]
    public V1beta1StandardAppVersionSpecForProviderVpcAccessConnector? VpcAccessConnector { get; set; }
}

/// <summary>Scheduler settings for standard environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderAutomaticScalingStandardSchedulerSettings
{
    /// <summary>Maximum number of instances to run for this version. Set to zero to disable maxInstances configuration. Note: Starting from March 2025, App Engine sets the maxInstances default for standard environment deployments to 20. This change doesn't impact existing apps. To override the default, specify a new value between 0 and 2147483647, and deploy a new version or redeploy over an existing version. To disable the maxInstances default configuration setting, specify the maximum permitted value 2147483647.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances to run for this version. Set to zero to disable minInstances configuration.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>Target CPU utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetCpuUtilization")]
    public double? TargetCpuUtilization { get; set; }

    /// <summary>Target throughput utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetThroughputUtilization")]
    public double? TargetThroughputUtilization { get; set; }
}

/// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderAutomaticScaling
{
    /// <summary>Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance. Defaults to a runtime-specific value.</summary>
    [JsonPropertyName("maxConcurrentRequests")]
    public double? MaxConcurrentRequests { get; set; }

    /// <summary>Maximum number of idle instances that should be maintained for this version.</summary>
    [JsonPropertyName("maxIdleInstances")]
    public double? MaxIdleInstances { get; set; }

    /// <summary>Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxPendingLatency")]
    public string? MaxPendingLatency { get; set; }

    /// <summary>Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minPendingLatency")]
    public string? MinPendingLatency { get; set; }

    /// <summary>Scheduler settings for standard environment. Structure is documented below.</summary>
    [JsonPropertyName("standardSchedulerSettings")]
    public V1beta1StandardAppVersionSpecInitProviderAutomaticScalingStandardSchedulerSettings? StandardSchedulerSettings { get; set; }
}

/// <summary>Basic scaling creates instances when your application receives requests. Each instance will be shut down when the application becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderBasicScaling
{
    /// <summary>Duration of time after the last request that an instance must wait before the instance is shut down. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Defaults to 900s.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderDeploymentFiles
{
    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SHA1 checksum of the file</summary>
    [JsonPropertyName("sha1Sum")]
    public string? Sha1Sum { get; set; }

    /// <summary>Source URL</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }
}

/// <summary>Zip File Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderDeploymentZip
{
    /// <summary>files count</summary>
    [JsonPropertyName("filesCount")]
    public double? FilesCount { get; set; }

    /// <summary>Source URL</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }
}

/// <summary>Code and application artifacts that make up this version. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderDeployment
{
    /// <summary>Manifest of the files stored in Google Cloud Storage that are included as part of this version. All files must be readable using the credentials supplied with this call. Structure is documented below.</summary>
    [JsonPropertyName("files")]
    public IList<V1beta1StandardAppVersionSpecInitProviderDeploymentFiles>? Files { get; set; }

    /// <summary>Zip File Structure is documented below.</summary>
    [JsonPropertyName("zip")]
    public V1beta1StandardAppVersionSpecInitProviderDeploymentZip? Zip { get; set; }
}

/// <summary>The entrypoint for the application. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderEntrypoint
{
    /// <summary>The format should be a shell command that can be fed to bash -c.</summary>
    [JsonPropertyName("shell")]
    public string? Shell { get; set; }
}

/// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderHandlersScript
{
    /// <summary>Path to the script from the application root directory.</summary>
    [JsonPropertyName("scriptPath")]
    public string? ScriptPath { get; set; }
}

/// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderHandlersStaticFiles
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderHandlers
{
    /// <summary>Actions to take when the user is not logged in. Possible values are: AUTH_FAIL_ACTION_REDIRECT, AUTH_FAIL_ACTION_UNAUTHORIZED.</summary>
    [JsonPropertyName("authFailAction")]
    public string? AuthFailAction { get; set; }

    /// <summary>Methods to restrict access to a URL based on login status. Possible values are: LOGIN_OPTIONAL, LOGIN_ADMIN, LOGIN_REQUIRED.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>30x code to use when performing redirects for the secure field. Possible values are: REDIRECT_HTTP_RESPONSE_CODE_301, REDIRECT_HTTP_RESPONSE_CODE_302, REDIRECT_HTTP_RESPONSE_CODE_303, REDIRECT_HTTP_RESPONSE_CODE_307.</summary>
    [JsonPropertyName("redirectHttpResponseCode")]
    public string? RedirectHttpResponseCode { get; set; }

    /// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto". Structure is documented below.</summary>
    [JsonPropertyName("script")]
    public V1beta1StandardAppVersionSpecInitProviderHandlersScript? Script { get; set; }

    /// <summary>Security (HTTPS) enforcement for this URL. Possible values are: SECURE_DEFAULT, SECURE_NEVER, SECURE_OPTIONAL, SECURE_ALWAYS.</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }

    /// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them. Structure is documented below.</summary>
    [JsonPropertyName("staticFiles")]
    public V1beta1StandardAppVersionSpecInitProviderHandlersStaticFiles? StaticFiles { get; set; }

    /// <summary>URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings. All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.</summary>
    [JsonPropertyName("urlRegex")]
    public string? UrlRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderLibraries
{
    /// <summary>Name of the library. Example "django".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Version of the library to select, or "latest".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderManualScaling
{
    /// <summary>Number of instances to assign to the service at the start. Note: When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2 Modules API set_num_instances() you must use lifecycle.ignore_changes = ["manual_scaling"[0].instances] to prevent drift detection.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StandardAppVersionSpecInitProviderServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderServiceAccountSelector
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
    public V1beta1StandardAppVersionSpecInitProviderServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>Enables VPC connectivity for standard apps. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProviderVpcAccessConnector
{
    /// <summary>The egress setting for the connector, controlling what traffic is diverted through it.</summary>
    [JsonPropertyName("egressSetting")]
    public string? EgressSetting { get; set; }

    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecInitProvider
{
    /// <summary>Allows App Engine second generation runtimes to access the legacy bundled services.</summary>
    [JsonPropertyName("appEngineApis")]
    public bool? AppEngineApis { get; set; }

    /// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics. Structure is documented below.</summary>
    [JsonPropertyName("automaticScaling")]
    public V1beta1StandardAppVersionSpecInitProviderAutomaticScaling? AutomaticScaling { get; set; }

    /// <summary>Basic scaling creates instances when your application receives requests. Each instance will be shut down when the application becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity. Structure is documented below.</summary>
    [JsonPropertyName("basicScaling")]
    public V1beta1StandardAppVersionSpecInitProviderBasicScaling? BasicScaling { get; set; }

    /// <summary>If set to true, the service will be deleted if it is the last version.</summary>
    [JsonPropertyName("deleteServiceOnDestroy")]
    public bool? DeleteServiceOnDestroy { get; set; }

    /// <summary>Code and application artifacts that make up this version. Structure is documented below.</summary>
    [JsonPropertyName("deployment")]
    public V1beta1StandardAppVersionSpecInitProviderDeployment? Deployment { get; set; }

    /// <summary>The entrypoint for the application. Structure is documented below.</summary>
    [JsonPropertyName("entrypoint")]
    public V1beta1StandardAppVersionSpecInitProviderEntrypoint? Entrypoint { get; set; }

    /// <summary>Environment variables available to the application.</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>An ordered list of URL-matching patterns that should be applied to incoming requests. The first matching URL handles the request and other request handlers are not attempted. Structure is documented below.</summary>
    [JsonPropertyName("handlers")]
    public IList<V1beta1StandardAppVersionSpecInitProviderHandlers>? Handlers { get; set; }

    /// <summary>A list of the types of messages that this application is able to receive. Each value may be one of: INBOUND_SERVICE_MAIL, INBOUND_SERVICE_MAIL_BOUNCE, INBOUND_SERVICE_XMPP_ERROR, INBOUND_SERVICE_XMPP_MESSAGE, INBOUND_SERVICE_XMPP_SUBSCRIBE, INBOUND_SERVICE_XMPP_PRESENCE, INBOUND_SERVICE_CHANNEL_PRESENCE, INBOUND_SERVICE_WARMUP.</summary>
    [JsonPropertyName("inboundServices")]
    public IList<string>? InboundServices { get; set; }

    /// <summary>Instance class that is used to run this version. Valid values are AutomaticScaling: F1, F2, F4, F4_1G BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8 Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>Configuration for third-party Python runtime libraries that are required by the application. Structure is documented below.</summary>
    [JsonPropertyName("libraries")]
    public IList<V1beta1StandardAppVersionSpecInitProviderLibraries>? Libraries { get; set; }

    /// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time. Structure is documented below.</summary>
    [JsonPropertyName("manualScaling")]
    public V1beta1StandardAppVersionSpecInitProviderManualScaling? ManualScaling { get; set; }

    /// <summary>If set to true, the application version will not be deleted.</summary>
    [JsonPropertyName("noopOnDestroy")]
    public bool? NoopOnDestroy { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Desired runtime. Example python27.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>The version of the API in the given runtime environment. Please see the app.yaml reference for valid values at https://cloud.google.com/appengine/docs/standard/&lt;language&gt;/config/appref Substitute &lt;language&gt; with python, java, php, ruby, go or nodejs.</summary>
    [JsonPropertyName("runtimeApiVersion")]
    public string? RuntimeApiVersion { get; set; }

    /// <summary>The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1StandardAppVersionSpecInitProviderServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1StandardAppVersionSpecInitProviderServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Whether multiple requests can be dispatched to this version at once.</summary>
    [JsonPropertyName("threadsafe")]
    public bool? Threadsafe { get; set; }

    /// <summary>Enables VPC connectivity for standard apps. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessConnector")]
    public V1beta1StandardAppVersionSpecInitProviderVpcAccessConnector? VpcAccessConnector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpecProviderConfigRef
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
public partial class V1beta1StandardAppVersionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>StandardAppVersionSpec defines the desired state of StandardAppVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StandardAppVersionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StandardAppVersionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StandardAppVersionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StandardAppVersionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Scheduler settings for standard environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderAutomaticScalingStandardSchedulerSettings
{
    /// <summary>Maximum number of instances to run for this version. Set to zero to disable maxInstances configuration. Note: Starting from March 2025, App Engine sets the maxInstances default for standard environment deployments to 20. This change doesn't impact existing apps. To override the default, specify a new value between 0 and 2147483647, and deploy a new version or redeploy over an existing version. To disable the maxInstances default configuration setting, specify the maximum permitted value 2147483647.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances to run for this version. Set to zero to disable minInstances configuration.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>Target CPU utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetCpuUtilization")]
    public double? TargetCpuUtilization { get; set; }

    /// <summary>Target throughput utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.</summary>
    [JsonPropertyName("targetThroughputUtilization")]
    public double? TargetThroughputUtilization { get; set; }
}

/// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderAutomaticScaling
{
    /// <summary>Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance. Defaults to a runtime-specific value.</summary>
    [JsonPropertyName("maxConcurrentRequests")]
    public double? MaxConcurrentRequests { get; set; }

    /// <summary>Maximum number of idle instances that should be maintained for this version.</summary>
    [JsonPropertyName("maxIdleInstances")]
    public double? MaxIdleInstances { get; set; }

    /// <summary>Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxPendingLatency")]
    public string? MaxPendingLatency { get; set; }

    /// <summary>Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minPendingLatency")]
    public string? MinPendingLatency { get; set; }

    /// <summary>Scheduler settings for standard environment. Structure is documented below.</summary>
    [JsonPropertyName("standardSchedulerSettings")]
    public V1beta1StandardAppVersionStatusAtProviderAutomaticScalingStandardSchedulerSettings? StandardSchedulerSettings { get; set; }
}

/// <summary>Basic scaling creates instances when your application receives requests. Each instance will be shut down when the application becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderBasicScaling
{
    /// <summary>Duration of time after the last request that an instance must wait before the instance is shut down. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Defaults to 900s.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderDeploymentFiles
{
    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SHA1 checksum of the file</summary>
    [JsonPropertyName("sha1Sum")]
    public string? Sha1Sum { get; set; }

    /// <summary>Source URL</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }
}

/// <summary>Zip File Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderDeploymentZip
{
    /// <summary>files count</summary>
    [JsonPropertyName("filesCount")]
    public double? FilesCount { get; set; }

    /// <summary>Source URL</summary>
    [JsonPropertyName("sourceUrl")]
    public string? SourceUrl { get; set; }
}

/// <summary>Code and application artifacts that make up this version. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderDeployment
{
    /// <summary>Manifest of the files stored in Google Cloud Storage that are included as part of this version. All files must be readable using the credentials supplied with this call. Structure is documented below.</summary>
    [JsonPropertyName("files")]
    public IList<V1beta1StandardAppVersionStatusAtProviderDeploymentFiles>? Files { get; set; }

    /// <summary>Zip File Structure is documented below.</summary>
    [JsonPropertyName("zip")]
    public V1beta1StandardAppVersionStatusAtProviderDeploymentZip? Zip { get; set; }
}

/// <summary>The entrypoint for the application. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderEntrypoint
{
    /// <summary>The format should be a shell command that can be fed to bash -c.</summary>
    [JsonPropertyName("shell")]
    public string? Shell { get; set; }
}

/// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderHandlersScript
{
    /// <summary>Path to the script from the application root directory.</summary>
    [JsonPropertyName("scriptPath")]
    public string? ScriptPath { get; set; }
}

/// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderHandlersStaticFiles
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderHandlers
{
    /// <summary>Actions to take when the user is not logged in. Possible values are: AUTH_FAIL_ACTION_REDIRECT, AUTH_FAIL_ACTION_UNAUTHORIZED.</summary>
    [JsonPropertyName("authFailAction")]
    public string? AuthFailAction { get; set; }

    /// <summary>Methods to restrict access to a URL based on login status. Possible values are: LOGIN_OPTIONAL, LOGIN_ADMIN, LOGIN_REQUIRED.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>30x code to use when performing redirects for the secure field. Possible values are: REDIRECT_HTTP_RESPONSE_CODE_301, REDIRECT_HTTP_RESPONSE_CODE_302, REDIRECT_HTTP_RESPONSE_CODE_303, REDIRECT_HTTP_RESPONSE_CODE_307.</summary>
    [JsonPropertyName("redirectHttpResponseCode")]
    public string? RedirectHttpResponseCode { get; set; }

    /// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto". Structure is documented below.</summary>
    [JsonPropertyName("script")]
    public V1beta1StandardAppVersionStatusAtProviderHandlersScript? Script { get; set; }

    /// <summary>Security (HTTPS) enforcement for this URL. Possible values are: SECURE_DEFAULT, SECURE_NEVER, SECURE_OPTIONAL, SECURE_ALWAYS.</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }

    /// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them. Structure is documented below.</summary>
    [JsonPropertyName("staticFiles")]
    public V1beta1StandardAppVersionStatusAtProviderHandlersStaticFiles? StaticFiles { get; set; }

    /// <summary>URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings. All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.</summary>
    [JsonPropertyName("urlRegex")]
    public string? UrlRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderLibraries
{
    /// <summary>Name of the library. Example "django".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Version of the library to select, or "latest".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderManualScaling
{
    /// <summary>Number of instances to assign to the service at the start. Note: When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2 Modules API set_num_instances() you must use lifecycle.ignore_changes = ["manual_scaling"[0].instances] to prevent drift detection.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }
}

/// <summary>Enables VPC connectivity for standard apps. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProviderVpcAccessConnector
{
    /// <summary>The egress setting for the connector, controlling what traffic is diverted through it.</summary>
    [JsonPropertyName("egressSetting")]
    public string? EgressSetting { get; set; }

    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusAtProvider
{
    /// <summary>Allows App Engine second generation runtimes to access the legacy bundled services.</summary>
    [JsonPropertyName("appEngineApis")]
    public bool? AppEngineApis { get; set; }

    /// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics. Structure is documented below.</summary>
    [JsonPropertyName("automaticScaling")]
    public V1beta1StandardAppVersionStatusAtProviderAutomaticScaling? AutomaticScaling { get; set; }

    /// <summary>Basic scaling creates instances when your application receives requests. Each instance will be shut down when the application becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity. Structure is documented below.</summary>
    [JsonPropertyName("basicScaling")]
    public V1beta1StandardAppVersionStatusAtProviderBasicScaling? BasicScaling { get; set; }

    /// <summary>If set to true, the service will be deleted if it is the last version.</summary>
    [JsonPropertyName("deleteServiceOnDestroy")]
    public bool? DeleteServiceOnDestroy { get; set; }

    /// <summary>Code and application artifacts that make up this version. Structure is documented below.</summary>
    [JsonPropertyName("deployment")]
    public V1beta1StandardAppVersionStatusAtProviderDeployment? Deployment { get; set; }

    /// <summary>The entrypoint for the application. Structure is documented below.</summary>
    [JsonPropertyName("entrypoint")]
    public V1beta1StandardAppVersionStatusAtProviderEntrypoint? Entrypoint { get; set; }

    /// <summary>Environment variables available to the application.</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>An ordered list of URL-matching patterns that should be applied to incoming requests. The first matching URL handles the request and other request handlers are not attempted. Structure is documented below.</summary>
    [JsonPropertyName("handlers")]
    public IList<V1beta1StandardAppVersionStatusAtProviderHandlers>? Handlers { get; set; }

    /// <summary>an identifier for the resource with format apps/{{project}}/services/{{service}}/versions/{{version_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of the types of messages that this application is able to receive. Each value may be one of: INBOUND_SERVICE_MAIL, INBOUND_SERVICE_MAIL_BOUNCE, INBOUND_SERVICE_XMPP_ERROR, INBOUND_SERVICE_XMPP_MESSAGE, INBOUND_SERVICE_XMPP_SUBSCRIBE, INBOUND_SERVICE_XMPP_PRESENCE, INBOUND_SERVICE_CHANNEL_PRESENCE, INBOUND_SERVICE_WARMUP.</summary>
    [JsonPropertyName("inboundServices")]
    public IList<string>? InboundServices { get; set; }

    /// <summary>Instance class that is used to run this version. Valid values are AutomaticScaling: F1, F2, F4, F4_1G BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8 Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>Configuration for third-party Python runtime libraries that are required by the application. Structure is documented below.</summary>
    [JsonPropertyName("libraries")]
    public IList<V1beta1StandardAppVersionStatusAtProviderLibraries>? Libraries { get; set; }

    /// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time. Structure is documented below.</summary>
    [JsonPropertyName("manualScaling")]
    public V1beta1StandardAppVersionStatusAtProviderManualScaling? ManualScaling { get; set; }

    /// <summary>Full path to the Version resource in the API. Example, "v1".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>If set to true, the application version will not be deleted.</summary>
    [JsonPropertyName("noopOnDestroy")]
    public bool? NoopOnDestroy { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Desired runtime. Example python27.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>The version of the API in the given runtime environment. Please see the app.yaml reference for valid values at https://cloud.google.com/appengine/docs/standard/&lt;language&gt;/config/appref Substitute &lt;language&gt; with python, java, php, ruby, go or nodejs.</summary>
    [JsonPropertyName("runtimeApiVersion")]
    public string? RuntimeApiVersion { get; set; }

    /// <summary>AppEngine service resource</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Whether multiple requests can be dispatched to this version at once.</summary>
    [JsonPropertyName("threadsafe")]
    public bool? Threadsafe { get; set; }

    /// <summary>Enables VPC connectivity for standard apps. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessConnector")]
    public V1beta1StandardAppVersionStatusAtProviderVpcAccessConnector? VpcAccessConnector { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatusConditions
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

/// <summary>StandardAppVersionStatus defines the observed state of StandardAppVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StandardAppVersionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StandardAppVersionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StandardAppVersionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StandardAppVersion is the Schema for the StandardAppVersions API. Standard App Version resource to create a new version of standard GAE Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StandardAppVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StandardAppVersionSpec>, IStatus<V1beta1StandardAppVersionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StandardAppVersion";
    public const string KubeGroup = "appengine.gcp.m.upbound.io";
    public const string KubePluralName = "standardappversions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StandardAppVersionSpec defines the desired state of StandardAppVersion</summary>
    [JsonPropertyName("spec")]
    public V1beta1StandardAppVersionSpec Spec { get; set; }

    /// <summary>StandardAppVersionStatus defines the observed state of StandardAppVersion.</summary>
    [JsonPropertyName("status")]
    public V1beta1StandardAppVersionStatus? Status { get; set; }
}