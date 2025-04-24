using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appengine.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionMetadata
{
}

/// <summary>Serving configuration for Google Cloud Endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecApiConfig
{
    /// <summary>Action to take when users access resources that require authentication. Default value: "AUTH_FAIL_ACTION_REDIRECT" Possible values: ["AUTH_FAIL_ACTION_REDIRECT", "AUTH_FAIL_ACTION_UNAUTHORIZED"].</summary>
    [JsonPropertyName("authFailAction")]
    public string? AuthFailAction { get; set; }

    /// <summary>Level of login required to access this resource. Default value: "LOGIN_OPTIONAL" Possible values: ["LOGIN_OPTIONAL", "LOGIN_ADMIN", "LOGIN_REQUIRED"].</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>Path to the script from the application root directory.</summary>
    [JsonPropertyName("script")]
    public string Script { get; set; }

    /// <summary>Security (HTTPS) enforcement for this URL. Possible values: ["SECURE_DEFAULT", "SECURE_NEVER", "SECURE_OPTIONAL", "SECURE_ALWAYS"].</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }

    /// <summary>URL to serve the endpoint at.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Target scaling by CPU usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecAutomaticScalingCpuUtilization
{
    /// <summary>Period of time over which CPU utilization is calculated.</summary>
    [JsonPropertyName("aggregationWindowLength")]
    public string? AggregationWindowLength { get; set; }

    /// <summary>Target CPU utilization ratio to maintain when scaling. Must be between 0 and 1.</summary>
    [JsonPropertyName("targetUtilization")]
    public double TargetUtilization { get; set; }
}

/// <summary>Target scaling by disk usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecAutomaticScalingDiskUtilization
{
    /// <summary>Target bytes read per second.</summary>
    [JsonPropertyName("targetReadBytesPerSecond")]
    public int? TargetReadBytesPerSecond { get; set; }

    /// <summary>Target ops read per seconds.</summary>
    [JsonPropertyName("targetReadOpsPerSecond")]
    public int? TargetReadOpsPerSecond { get; set; }

    /// <summary>Target bytes written per second.</summary>
    [JsonPropertyName("targetWriteBytesPerSecond")]
    public int? TargetWriteBytesPerSecond { get; set; }

    /// <summary>Target ops written per second.</summary>
    [JsonPropertyName("targetWriteOpsPerSecond")]
    public int? TargetWriteOpsPerSecond { get; set; }
}

/// <summary>Target scaling by network usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecAutomaticScalingNetworkUtilization
{
    /// <summary>Target bytes received per second.</summary>
    [JsonPropertyName("targetReceivedBytesPerSecond")]
    public int? TargetReceivedBytesPerSecond { get; set; }

    /// <summary>Target packets received per second.</summary>
    [JsonPropertyName("targetReceivedPacketsPerSecond")]
    public int? TargetReceivedPacketsPerSecond { get; set; }

    /// <summary>Target bytes sent per second.</summary>
    [JsonPropertyName("targetSentBytesPerSecond")]
    public int? TargetSentBytesPerSecond { get; set; }

    /// <summary>Target packets sent per second.</summary>
    [JsonPropertyName("targetSentPacketsPerSecond")]
    public int? TargetSentPacketsPerSecond { get; set; }
}

/// <summary>Target scaling by request utilization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecAutomaticScalingRequestUtilization
{
    /// <summary>Target number of concurrent requests.</summary>
    [JsonPropertyName("targetConcurrentRequests")]
    public double? TargetConcurrentRequests { get; set; }

    /// <summary>Target requests per second.</summary>
    [JsonPropertyName("targetRequestCountPerSecond")]
    public string? TargetRequestCountPerSecond { get; set; }
}

/// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecAutomaticScaling
{
    /// <summary>The time period that the Autoscaler should wait before it starts collecting information from a new instance. This prevents the autoscaler from collecting information when the instance is initializing, during which the collected usage would not be reliable. Default: 120s.</summary>
    [JsonPropertyName("coolDownPeriod")]
    public string? CoolDownPeriod { get; set; }

    /// <summary>Target scaling by CPU usage.</summary>
    [JsonPropertyName("cpuUtilization")]
    public AppEngineFlexibleAppVersionSpecAutomaticScalingCpuUtilization CpuUtilization { get; set; }

    /// <summary>Target scaling by disk usage.</summary>
    [JsonPropertyName("diskUtilization")]
    public AppEngineFlexibleAppVersionSpecAutomaticScalingDiskUtilization? DiskUtilization { get; set; }

    /// <summary>Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance.  Defaults to a runtime-specific value.</summary>
    [JsonPropertyName("maxConcurrentRequests")]
    public int? MaxConcurrentRequests { get; set; }

    /// <summary>Maximum number of idle instances that should be maintained for this version.</summary>
    [JsonPropertyName("maxIdleInstances")]
    public int? MaxIdleInstances { get; set; }

    /// <summary>Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it.</summary>
    [JsonPropertyName("maxPendingLatency")]
    public string? MaxPendingLatency { get; set; }

    /// <summary>Maximum number of instances that should be started to handle requests for this version. Default: 20.</summary>
    [JsonPropertyName("maxTotalInstances")]
    public int? MaxTotalInstances { get; set; }

    /// <summary>Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.</summary>
    [JsonPropertyName("minIdleInstances")]
    public int? MinIdleInstances { get; set; }

    /// <summary>Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it.</summary>
    [JsonPropertyName("minPendingLatency")]
    public string? MinPendingLatency { get; set; }

    /// <summary>Minimum number of running instances that should be maintained for this version. Default: 2.</summary>
    [JsonPropertyName("minTotalInstances")]
    public int? MinTotalInstances { get; set; }

    /// <summary>Target scaling by network usage.</summary>
    [JsonPropertyName("networkUtilization")]
    public AppEngineFlexibleAppVersionSpecAutomaticScalingNetworkUtilization? NetworkUtilization { get; set; }

    /// <summary>Target scaling by request utilization.</summary>
    [JsonPropertyName("requestUtilization")]
    public AppEngineFlexibleAppVersionSpecAutomaticScalingRequestUtilization? RequestUtilization { get; set; }
}

/// <summary>Options for the build operations performed as a part of the version deployment. Only applicable when creating a version using source code directly.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecDeploymentCloudBuildOptions
{
    /// <summary>Path to the yaml file used in deployment, used to determine runtime configuration details.</summary>
    [JsonPropertyName("appYamlPath")]
    public string AppYamlPath { get; set; }

    /// <summary>The Cloud Build timeout used as part of any dependent builds performed by version creation. Defaults to 10 minutes.  A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("cloudBuildTimeout")]
    public string? CloudBuildTimeout { get; set; }
}

/// <summary>The Docker image for the container that runs the version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecDeploymentContainer
{
    /// <summary>URI to the hosted container image in Google Container Registry. The URI must be fully qualified and include a tag or digest. Examples: "gcr.io/my-project/image:tag" or "gcr.io/my-project/image@digest".</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecDeploymentFiles
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

/// <summary>Zip File.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecDeploymentZip
{
    /// <summary>files count.</summary>
    [JsonPropertyName("filesCount")]
    public int? FilesCount { get; set; }

    /// <summary>Source URL.</summary>
    [JsonPropertyName("sourceUrl")]
    public string SourceUrl { get; set; }
}

/// <summary>Code and application artifacts that make up this version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecDeployment
{
    /// <summary>Options for the build operations performed as a part of the version deployment. Only applicable when creating a version using source code directly.</summary>
    [JsonPropertyName("cloudBuildOptions")]
    public AppEngineFlexibleAppVersionSpecDeploymentCloudBuildOptions? CloudBuildOptions { get; set; }

    /// <summary>The Docker image for the container that runs the version.</summary>
    [JsonPropertyName("container")]
    public AppEngineFlexibleAppVersionSpecDeploymentContainer? Container { get; set; }

    /// <summary>Manifest of the files stored in Google Cloud Storage that are included as part of this version. All files must be readable using the credentials supplied with this call.</summary>
    [JsonPropertyName("files")]
    public IList<AppEngineFlexibleAppVersionSpecDeploymentFiles>? Files { get; set; }

    /// <summary>Zip File.</summary>
    [JsonPropertyName("zip")]
    public AppEngineFlexibleAppVersionSpecDeploymentZip? Zip { get; set; }
}

/// <summary>Code and application artifacts that make up this version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecEndpointsApiService
{
    /// <summary>Endpoints service configuration ID as specified by the Service Management API. For example "2016-09-19r1".  By default, the rollout strategy for Endpoints is "FIXED". This means that Endpoints starts up with a particular configuration ID. When a new configuration is rolled out, Endpoints must be given the new configuration ID. The configId field is used to give the configuration ID and is required in this case.  Endpoints also has a rollout strategy called "MANAGED". When using this, Endpoints fetches the latest configuration and does not need the configuration ID. In this case, configId must be omitted.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>Enable or disable trace sampling. By default, this is set to false for enabled.</summary>
    [JsonPropertyName("disableTraceSampling")]
    public bool? DisableTraceSampling { get; set; }

    /// <summary>Endpoints service name which is the name of the "service" resource in the Service Management API. For example "myapi.endpoints.myproject.cloud.goog".</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Endpoints rollout strategy. If FIXED, configId must be specified. If MANAGED, configId must be omitted. Default value: "FIXED" Possible values: ["FIXED", "MANAGED"].</summary>
    [JsonPropertyName("rolloutStrategy")]
    public string? RolloutStrategy { get; set; }
}

/// <summary>The entrypoint for the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecEntrypoint
{
    /// <summary>The format should be a shell command that can be fed to bash -c.</summary>
    [JsonPropertyName("shell")]
    public string Shell { get; set; }
}

/// <summary>Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for Node.js in the App Engine standard environment, for example "script:" "auto".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecHandlersScript
{
    /// <summary>Path to the script from the application root directory.</summary>
    [JsonPropertyName("scriptPath")]
    public string ScriptPath { get; set; }
}

/// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecHandlersStaticFiles
{
    /// <summary>Whether files should also be uploaded as code data. By default, files declared in static file handlers are uploaded as static data and are only served to end users; they cannot be read by the application. If enabled, uploads are charged against both your code and static data storage resource quotas.</summary>
    [JsonPropertyName("applicationReadable")]
    public bool? ApplicationReadable { get; set; }

    /// <summary>Time a static file served by this handler should be cached by web proxies and browsers. A duration in seconds with up to nine fractional digits, terminated by 's'. Example "3.5s". Default is '0s'.</summary>
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
public partial class AppEngineFlexibleAppVersionSpecHandlers
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
    public AppEngineFlexibleAppVersionSpecHandlersScript? Script { get; set; }

    /// <summary>Security (HTTPS) enforcement for this URL. Possible values: ["SECURE_DEFAULT", "SECURE_NEVER", "SECURE_OPTIONAL", "SECURE_ALWAYS"].</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }

    /// <summary>Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files. Static file handlers describe which files in the application directory are static files, and which URLs serve them.</summary>
    [JsonPropertyName("staticFiles")]
    public AppEngineFlexibleAppVersionSpecHandlersStaticFiles? StaticFiles { get; set; }

    /// <summary>URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings. All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.</summary>
    [JsonPropertyName("urlRegex")]
    public string? UrlRegex { get; set; }
}

/// <summary>Health checking configuration for VM instances. Unhealthy instances are killed and replaced with new instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecLivenessCheck
{
    /// <summary>Interval between health checks.</summary>
    [JsonPropertyName("checkInterval")]
    public string? CheckInterval { get; set; }

    /// <summary>Number of consecutive failed checks required before considering the VM unhealthy. Default: 4.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>Host header to send when performing a HTTP Readiness check. Example: "myapp.appspot.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The initial delay before starting to execute the checks. Default: "300s".</summary>
    [JsonPropertyName("initialDelay")]
    public string? InitialDelay { get; set; }

    /// <summary>The request path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Number of consecutive successful checks required before considering the VM healthy. Default: 2.</summary>
    [JsonPropertyName("successThreshold")]
    public double? SuccessThreshold { get; set; }

    /// <summary>Time before the check is considered failed. Default: "4s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecManualScaling
{
    /// <summary>Number of instances to assign to the service at the start.  **Note:** When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2 Modules API set_num_instances() you must use 'lifecycle.ignore_changes = ["manual_scaling"[0].instances]' to prevent drift detection.</summary>
    [JsonPropertyName("instances")]
    public int Instances { get; set; }
}

/// <summary>Extra network settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecNetwork
{
    /// <summary>List of ports, or port pairs, to forward from the virtual machine to the application container.</summary>
    [JsonPropertyName("forwardedPorts")]
    public IList<string>? ForwardedPorts { get; set; }

    /// <summary>Tag to apply to the instance during creation.</summary>
    [JsonPropertyName("instanceTag")]
    public string? InstanceTag { get; set; }

    /// <summary>Google Compute Engine network where the virtual machines are created. Specify the short name, not the resource path.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Enable session affinity.</summary>
    [JsonPropertyName("sessionAffinity")]
    public bool? SessionAffinity { get; set; }

    /// <summary>Google Cloud Platform sub-network where the virtual machines are created. Specify the short name, not the resource path.  If the network that the instance is being created in is a Legacy network, then the IP address is allocated from the IPv4Range. If the network that the instance is being created in is an auto Subnet Mode Network, then only network name should be specified (not the subnetworkName) and the IP address is created from the IPCidrRange of the subnetwork that exists in that zone for that network. If the network that the instance is being created in is a custom Subnet Mode Network, then the subnetworkName must be specified and the IP address is created from the IPCidrRange of the subnetwork. If specified, the subnetwork must exist in the same region as the App Engine flexible environment application.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary>Configures readiness health checking for instances. Unhealthy instances are not put into the backend traffic rotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecReadinessCheck
{
    /// <summary>A maximum time limit on application initialization, measured from moment the application successfully replies to a healthcheck until it is ready to serve traffic. Default: "300s".</summary>
    [JsonPropertyName("appStartTimeout")]
    public string? AppStartTimeout { get; set; }

    /// <summary>Interval between health checks.  Default: "5s".</summary>
    [JsonPropertyName("checkInterval")]
    public string? CheckInterval { get; set; }

    /// <summary>Number of consecutive failed checks required before removing traffic. Default: 2.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>Host header to send when performing a HTTP Readiness check. Example: "myapp.appspot.com".</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The request path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Number of consecutive successful checks required before receiving traffic. Default: 2.</summary>
    [JsonPropertyName("successThreshold")]
    public double? SuccessThreshold { get; set; }

    /// <summary>Time before the check is considered failed. Default: "4s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecResourcesVolumes
{
    /// <summary>Unique name for the volume.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Volume size in gigabytes.</summary>
    [JsonPropertyName("sizeGb")]
    public int SizeGb { get; set; }

    /// <summary>Underlying volume type, e.g. 'tmpfs'.</summary>
    [JsonPropertyName("volumeType")]
    public string VolumeType { get; set; }
}

/// <summary>Machine resources for a version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecResources
{
    /// <summary>Number of CPU cores needed.</summary>
    [JsonPropertyName("cpu")]
    public int? Cpu { get; set; }

    /// <summary>Disk size (GB) needed.</summary>
    [JsonPropertyName("diskGb")]
    public int? DiskGb { get; set; }

    /// <summary>Memory (GB) needed.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>List of ports, or port pairs, to forward from the virtual machine to the application container.</summary>
    [JsonPropertyName("volumes")]
    public IList<AppEngineFlexibleAppVersionSpecResourcesVolumes>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecServiceRef
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

/// <summary>Enables VPC connectivity for standard apps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpecVpcAccessConnector
{
    /// <summary>Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionSpec
{
    /// <summary>Serving configuration for Google Cloud Endpoints.</summary>
    [JsonPropertyName("apiConfig")]
    public AppEngineFlexibleAppVersionSpecApiConfig? ApiConfig { get; set; }

    /// <summary>Automatic scaling is based on request rate, response latencies, and other application metrics.</summary>
    [JsonPropertyName("automaticScaling")]
    public AppEngineFlexibleAppVersionSpecAutomaticScaling? AutomaticScaling { get; set; }

    /// <summary>Metadata settings that are supplied to this version to enable beta runtime features.</summary>
    [JsonPropertyName("betaSettings")]
    public IDictionary<string, string>? BetaSettings { get; set; }

    /// <summary>Duration that static files should be cached by web proxies and browsers. Only applicable if the corresponding StaticFilesHandler does not specify its own expiration time.</summary>
    [JsonPropertyName("defaultExpiration")]
    public string? DefaultExpiration { get; set; }

    /// <summary>If set to 'true', the service will be deleted if it is the last version.</summary>
    [JsonPropertyName("deleteServiceOnDestroy")]
    public bool? DeleteServiceOnDestroy { get; set; }

    /// <summary>Code and application artifacts that make up this version.</summary>
    [JsonPropertyName("deployment")]
    public AppEngineFlexibleAppVersionSpecDeployment? Deployment { get; set; }

    /// <summary>Code and application artifacts that make up this version.</summary>
    [JsonPropertyName("endpointsApiService")]
    public AppEngineFlexibleAppVersionSpecEndpointsApiService? EndpointsApiService { get; set; }

    /// <summary>The entrypoint for the application.</summary>
    [JsonPropertyName("entrypoint")]
    public AppEngineFlexibleAppVersionSpecEntrypoint? Entrypoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>An ordered list of URL-matching patterns that should be applied to incoming requests. The first matching URL handles the request and other request handlers are not attempted.</summary>
    [JsonPropertyName("handlers")]
    public IList<AppEngineFlexibleAppVersionSpecHandlers>? Handlers { get; set; }

    /// <summary>A list of the types of messages that this application is able to receive. Possible values: ["INBOUND_SERVICE_MAIL", "INBOUND_SERVICE_MAIL_BOUNCE", "INBOUND_SERVICE_XMPP_ERROR", "INBOUND_SERVICE_XMPP_MESSAGE", "INBOUND_SERVICE_XMPP_SUBSCRIBE", "INBOUND_SERVICE_XMPP_PRESENCE", "INBOUND_SERVICE_CHANNEL_PRESENCE", "INBOUND_SERVICE_WARMUP"].</summary>
    [JsonPropertyName("inboundServices")]
    public IList<string>? InboundServices { get; set; }

    /// <summary>Instance class that is used to run this version. Valid values are AutomaticScaling: F1, F2, F4, F4_1G ManualScaling: B1, B2, B4, B8, B4_1G Defaults to F1 for AutomaticScaling and B1 for ManualScaling.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>Health checking configuration for VM instances. Unhealthy instances are killed and replaced with new instances.</summary>
    [JsonPropertyName("livenessCheck")]
    public AppEngineFlexibleAppVersionSpecLivenessCheck LivenessCheck { get; set; }

    /// <summary>A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time.</summary>
    [JsonPropertyName("manualScaling")]
    public AppEngineFlexibleAppVersionSpecManualScaling? ManualScaling { get; set; }

    /// <summary>Extra network settings.</summary>
    [JsonPropertyName("network")]
    public AppEngineFlexibleAppVersionSpecNetwork? Network { get; set; }

    /// <summary>Files that match this pattern will not be built into this version. Only applicable for Go runtimes.</summary>
    [JsonPropertyName("nobuildFilesRegex")]
    public string? NobuildFilesRegex { get; set; }

    /// <summary>If set to 'true', the application version will not be deleted.</summary>
    [JsonPropertyName("noopOnDestroy")]
    public bool? NoopOnDestroy { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configures readiness health checking for instances. Unhealthy instances are not put into the backend traffic rotation.</summary>
    [JsonPropertyName("readinessCheck")]
    public AppEngineFlexibleAppVersionSpecReadinessCheck ReadinessCheck { get; set; }

    /// <summary>Immutable. Optional. The versionId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Machine resources for a version.</summary>
    [JsonPropertyName("resources")]
    public AppEngineFlexibleAppVersionSpecResources? Resources { get; set; }

    /// <summary>Desired runtime. Example python27.</summary>
    [JsonPropertyName("runtime")]
    public string Runtime { get; set; }

    /// <summary>The version of the API in the given runtime environment. Please see the app.yaml reference for valid values at 'https://cloud.google.com/appengine/docs/standard/&lt;language&gt;/config/appref'\ Substitute '&lt;language&gt;' with 'python', 'java', 'php', 'ruby', 'go' or 'nodejs'.</summary>
    [JsonPropertyName("runtimeApiVersion")]
    public string? RuntimeApiVersion { get; set; }

    /// <summary>The channel of the runtime to use. Only available for some runtimes.</summary>
    [JsonPropertyName("runtimeChannel")]
    public string? RuntimeChannel { get; set; }

    /// <summary>The path or name of the app's main executable.</summary>
    [JsonPropertyName("runtimeMainExecutablePath")]
    public string? RuntimeMainExecutablePath { get; set; }

    /// <summary>The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceRef")]
    public AppEngineFlexibleAppVersionSpecServiceRef ServiceRef { get; set; }

    /// <summary>Current serving status of this version. Only the versions with a SERVING status create instances and can be billed. Default value: "SERVING" Possible values: ["SERVING", "STOPPED"].</summary>
    [JsonPropertyName("servingStatus")]
    public string? ServingStatus { get; set; }

    /// <summary>Enables VPC connectivity for standard apps.</summary>
    [JsonPropertyName("vpcAccessConnector")]
    public AppEngineFlexibleAppVersionSpecVpcAccessConnector? VpcAccessConnector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<AppEngineFlexibleAppVersionStatusConditions>? Conditions { get; set; }

    /// <summary>Full path to the Version resource in the API. Example, "v1".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AppEngineFlexibleAppVersion
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public AppEngineFlexibleAppVersionMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public AppEngineFlexibleAppVersionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public AppEngineFlexibleAppVersionStatus? Status { get; set; }
}