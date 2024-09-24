using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudrun.gcp.upbound.io;
public enum V1beta1V2ServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1V2ServiceSpecForProviderBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

public enum V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelector? SecretSelector { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSourceSecretKeyRef>? SecretKeyRef { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Structure is documented below.</summary>
    [JsonPropertyName("valueSource")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersEnvValueSource>? ValueSource { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeGrpc
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeGrpc>? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeHttpGet>? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbeTcpSocket>? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersResources
{
    /// <summary>Determines whether CPU is only allocated during requests. True by default if the parent resources field is not set. However, if resources is set, this field must be explicitly set to true to preserve the default behavior.</summary>
    [JsonPropertyName("cpuIdle")]
    public bool? CpuIdle { get; set; }

    /// <summary>Only memory and CPU are supported. Use key cpu for CPU limit and memory for memory limit. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Determines whether CPU should be boosted on startup of a new container instance above the requested CPU threshold, this can help reduce cold-start latency.</summary>
    [JsonPropertyName("startupCpuBoost")]
    public bool? StartupCpuBoost { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeGrpc
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeGrpc>? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeHttpGet>? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbeTcpSocket>? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Containers which should be started before this container. If specified the container will wait to start until all containers with the listed names are healthy.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes Structure is documented below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersResources>? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes Structure is documented below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersStartupProbe>? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateScaling
{
    /// <summary>Maximum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesCloudSqlInstance
{
    /// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesGcs
{
    /// <summary>GCS Bucket name</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesGcsBucketSelector? BucketSelector { get; set; }

    /// <summary>If true, mount the NFS volume as read only</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesNfs
{
    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Hostname or IP address of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2ServiceSpecForProviderTemplateVolumesSecretSecretSelector? SecretSelector { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVolumesCloudSqlInstance>? CloudSqlInstance { get; set; }

    /// <summary>Represents a GCS Bucket mounted as a volume. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVolumesGcs>? Gcs { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Represents an NFS mount. Structure is documented below.</summary>
    [JsonPropertyName("nfs")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVolumesNfs>? Nfs { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVolumesSecret>? Secret { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Network tags applied to this Cloud Run service.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connector")]
    public string? Connector { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values are: ALL_TRAFFIC, PRIVATE_RANGES_ONLY.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported. Structure is documented below.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 RevisionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Holds the containers that define the unit of execution for this Service. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>The sandbox environment to host this Revision. Possible values are: EXECUTION_ENVIRONMENT_GEN1, EXECUTION_ENVIRONMENT_GEN2.</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 RevisionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Sets the maximum number of requests that each serving instance can receive.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public double? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>The unique name for the revision. If this field is omitted, it will be automatically generated based on the Service name.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Scaling settings for this Revision. Structure is documented below.</summary>
    [JsonPropertyName("scaling")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateScaling>? Scaling { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Enables session affinity. For more information, go to https://cloud.google.com/run/docs/configuring/session-affinity</summary>
    [JsonPropertyName("sessionAffinity")]
    public bool? SessionAffinity { get; set; }

    /// <summary>Max allowed time for an instance to respond to a request. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccess")]
    public IList<V1beta1V2ServiceSpecForProviderTemplateVpcAccess>? VpcAccess { get; set; }
}

public partial class V1beta1V2ServiceSpecForProviderTraffic
{
    /// <summary>Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>Revision to which to send this portion of traffic, if traffic allocation is by revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Indicates a string to be part of the URI to exclusively reference this target.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The allocation type for this traffic target. Possible values are: TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST, TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1V2ServiceSpecForProvider
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 RevisionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1V2ServiceSpecForProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>One or more custom audiences that you want this service to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests. For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.</summary>
    [JsonPropertyName("customAudiences")]
    public IList<string>? CustomAudiences { get; set; }

    /// <summary>User-provided description of the Service. This field currently has a 512-character limit.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values are: INGRESS_TRAFFIC_ALL, INGRESS_TRAFFIC_INTERNAL_ONLY, INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER.</summary>
    [JsonPropertyName("ingress")]
    public string? Ingress { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 RevisionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The launch stage as defined by Google Cloud Platform Launch Stages. Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features. For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values are: UNIMPLEMENTED, PRELAUNCH, EARLY_ACCESS, ALPHA, BETA, GA, DEPRECATED.</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The location of the cloud run service</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The template used to create revisions for this Service. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2ServiceSpecForProviderTemplate>? Template { get; set; }

    /// <summary>Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is empty or not provided, defaults to 100% traffic to the latest Ready Revision. Structure is documented below.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1V2ServiceSpecForProviderTraffic>? Traffic { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

public enum V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRefSecretSelector? SecretSelector { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSourceSecretKeyRef>? SecretKeyRef { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Structure is documented below.</summary>
    [JsonPropertyName("valueSource")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersEnvValueSource>? ValueSource { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeGrpc
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeGrpc>? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeHttpGet>? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbeTcpSocket>? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersResources
{
    /// <summary>Determines whether CPU is only allocated during requests. True by default if the parent resources field is not set. However, if resources is set, this field must be explicitly set to true to preserve the default behavior.</summary>
    [JsonPropertyName("cpuIdle")]
    public bool? CpuIdle { get; set; }

    /// <summary>Only memory and CPU are supported. Use key cpu for CPU limit and memory for memory limit. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Determines whether CPU should be boosted on startup of a new container instance above the requested CPU threshold, this can help reduce cold-start latency.</summary>
    [JsonPropertyName("startupCpuBoost")]
    public bool? StartupCpuBoost { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeGrpc
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeGrpc>? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeHttpGet>? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbeTcpSocket>? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Containers which should be started before this container. If specified the container will wait to start until all containers with the listed names are healthy.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes Structure is documented below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersResources>? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes Structure is documented below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersStartupProbe>? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateScaling
{
    /// <summary>Maximum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesCloudSqlInstance
{
    /// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesGcs
{
    /// <summary>GCS Bucket name</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesGcsBucketSelector? BucketSelector { get; set; }

    /// <summary>If true, mount the NFS volume as read only</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesNfs
{
    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Hostname or IP address of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRefPolicy? Policy { get; set; }
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1V2ServiceSpecInitProviderTemplateVolumesSecretSecretSelector? SecretSelector { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVolumesCloudSqlInstance>? CloudSqlInstance { get; set; }

    /// <summary>Represents a GCS Bucket mounted as a volume. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVolumesGcs>? Gcs { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Represents an NFS mount. Structure is documented below.</summary>
    [JsonPropertyName("nfs")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVolumesNfs>? Nfs { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVolumesSecret>? Secret { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Network tags applied to this Cloud Run service.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connector")]
    public string? Connector { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values are: ALL_TRAFFIC, PRIVATE_RANGES_ONLY.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported. Structure is documented below.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 RevisionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Holds the containers that define the unit of execution for this Service. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>The sandbox environment to host this Revision. Possible values are: EXECUTION_ENVIRONMENT_GEN1, EXECUTION_ENVIRONMENT_GEN2.</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 RevisionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Sets the maximum number of requests that each serving instance can receive.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public double? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>The unique name for the revision. If this field is omitted, it will be automatically generated based on the Service name.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Scaling settings for this Revision. Structure is documented below.</summary>
    [JsonPropertyName("scaling")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateScaling>? Scaling { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Enables session affinity. For more information, go to https://cloud.google.com/run/docs/configuring/session-affinity</summary>
    [JsonPropertyName("sessionAffinity")]
    public bool? SessionAffinity { get; set; }

    /// <summary>Max allowed time for an instance to respond to a request. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccess")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplateVpcAccess>? VpcAccess { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProviderTraffic
{
    /// <summary>Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>Revision to which to send this portion of traffic, if traffic allocation is by revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Indicates a string to be part of the URI to exclusively reference this target.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The allocation type for this traffic target. Possible values are: TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST, TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1V2ServiceSpecInitProvider
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 RevisionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1V2ServiceSpecInitProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>One or more custom audiences that you want this service to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests. For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.</summary>
    [JsonPropertyName("customAudiences")]
    public IList<string>? CustomAudiences { get; set; }

    /// <summary>User-provided description of the Service. This field currently has a 512-character limit.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values are: INGRESS_TRAFFIC_ALL, INGRESS_TRAFFIC_INTERNAL_ONLY, INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER.</summary>
    [JsonPropertyName("ingress")]
    public string? Ingress { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 RevisionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The launch stage as defined by Google Cloud Platform Launch Stages. Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features. For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values are: UNIMPLEMENTED, PRELAUNCH, EARLY_ACCESS, ALPHA, BETA, GA, DEPRECATED.</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The template used to create revisions for this Service. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2ServiceSpecInitProviderTemplate>? Template { get; set; }

    /// <summary>Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is empty or not provided, defaults to 100% traffic to the latest Ready Revision. Structure is documented below.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1V2ServiceSpecInitProviderTraffic>? Traffic { get; set; }
}

public enum V1beta1V2ServiceSpecManagementPoliciesEnum
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

public enum V1beta1V2ServiceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1V2ServiceSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1V2ServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1V2ServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1V2ServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1V2ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1V2ServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1V2ServiceSpecDeletionPolicyEnum>))]
    public V1beta1V2ServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1V2ServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1V2ServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1V2ServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1V2ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1V2ServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1V2ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderConditions
{
    /// <summary>(Output) A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>(Output) Last time the condition transitioned from one status to another. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>(Output) Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>(Output) A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>(Output) A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>(Output) How to interpret failures of this condition, one of Error, Warning, Info</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>(Output) State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>(Output) type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * "Ready": True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersEnvValueSourceSecretKeyRef>? SecretKeyRef { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Structure is documented below.</summary>
    [JsonPropertyName("valueSource")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersEnvValueSource>? ValueSource { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeGrpc
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeGrpc>? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeHttpGet>? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbeTcpSocket>? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersResources
{
    /// <summary>Determines whether CPU is only allocated during requests. True by default if the parent resources field is not set. However, if resources is set, this field must be explicitly set to true to preserve the default behavior.</summary>
    [JsonPropertyName("cpuIdle")]
    public bool? CpuIdle { get; set; }

    /// <summary>Only memory and CPU are supported. Use key cpu for CPU limit and memory for memory limit. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Determines whether CPU should be boosted on startup of a new container instance above the requested CPU threshold, this can help reduce cold-start latency.</summary>
    [JsonPropertyName("startupCpuBoost")]
    public bool? StartupCpuBoost { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeGrpc
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeGrpc>? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeHttpGet>? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbeTcpSocket>? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Containers which should be started before this container. If specified the container will wait to start until all containers with the listed names are healthy.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes Structure is documented below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersResources>? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes Structure is documented below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersStartupProbe>? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateScaling
{
    /// <summary>Maximum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVolumesCloudSqlInstance
{
    /// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVolumesGcs
{
    /// <summary>GCS Bucket name</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>If true, mount the NFS volume as read only</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVolumesNfs
{
    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Hostname or IP address of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVolumesCloudSqlInstance>? CloudSqlInstance { get; set; }

    /// <summary>Represents a GCS Bucket mounted as a volume. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVolumesGcs>? Gcs { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Represents an NFS mount. Structure is documented below.</summary>
    [JsonPropertyName("nfs")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVolumesNfs>? Nfs { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVolumesSecret>? Secret { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Network tags applied to this Cloud Run service.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connector")]
    public string? Connector { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values are: ALL_TRAFFIC, PRIVATE_RANGES_ONLY.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported. Structure is documented below.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 RevisionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Holds the containers that define the unit of execution for this Service. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKey")]
    public string? EncryptionKey { get; set; }

    /// <summary>The sandbox environment to host this Revision. Possible values are: EXECUTION_ENVIRONMENT_GEN1, EXECUTION_ENVIRONMENT_GEN2.</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 RevisionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Sets the maximum number of requests that each serving instance can receive.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public double? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>The unique name for the revision. If this field is omitted, it will be automatically generated based on the Service name.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Scaling settings for this Revision. Structure is documented below.</summary>
    [JsonPropertyName("scaling")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateScaling>? Scaling { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Enables session affinity. For more information, go to https://cloud.google.com/run/docs/configuring/session-affinity</summary>
    [JsonPropertyName("sessionAffinity")]
    public bool? SessionAffinity { get; set; }

    /// <summary>Max allowed time for an instance to respond to a request. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccess")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplateVpcAccess>? VpcAccess { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTerminalCondition
{
    /// <summary>(Output) A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>(Output) Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>(Output) Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>(Output) A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>(Output) A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>(Output) How to interpret failures of this condition, one of Error, Warning, Info</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>(Output) State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>(Output) type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * "Ready": True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTraffic
{
    /// <summary>Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>Revision to which to send this portion of traffic, if traffic allocation is by revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Indicates a string to be part of the URI to exclusively reference this target.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The allocation type for this traffic target. Possible values are: TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST, TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProviderTrafficStatuses
{
    /// <summary>(Output) Specifies percent of the traffic to this Revision.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>(Output) Revision to which this traffic is sent.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>(Output) Indicates the string used in the URI to exclusively reference this target.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>(Output) The allocation type for this traffic target.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>(Output) Displays the target URI.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1V2ServiceStatusAtProvider
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 RevisionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public IList<V1beta1V2ServiceStatusAtProviderBinaryAuthorization>? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Service does not reach its Serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1V2ServiceStatusAtProviderConditions>? Conditions { get; set; }

    /// <summary>The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Email address of the authenticated creator.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>One or more custom audiences that you want this service to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests. For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.</summary>
    [JsonPropertyName("customAudiences")]
    public IList<string>? CustomAudiences { get; set; }

    /// <summary>The deletion time.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>User-provided description of the Service. This field currently has a 512-character limit.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>For a deleted resource, the time after which it will be permamently deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>A number that monotonically increases every time the user modifies the desired state. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/services/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values are: INGRESS_TRAFFIC_ALL, INGRESS_TRAFFIC_INTERNAL_ONLY, INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER.</summary>
    [JsonPropertyName("ingress")]
    public string? Ingress { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with run.googleapis.com, cloud.googleapis.com, serving.knative.dev, or autoscaling.knative.dev namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 RevisionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Email address of the last authenticated modifier.</summary>
    [JsonPropertyName("lastModifier")]
    public string? LastModifier { get; set; }

    /// <summary>Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
    [JsonPropertyName("latestCreatedRevision")]
    public string? LatestCreatedRevision { get; set; }

    /// <summary>Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
    [JsonPropertyName("latestReadyRevision")]
    public string? LatestReadyRevision { get; set; }

    /// <summary>The launch stage as defined by Google Cloud Platform Launch Stages. Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features. For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values are: UNIMPLEMENTED, PRELAUNCH, EARLY_ACCESS, ALPHA, BETA, GA, DEPRECATED.</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The location of the cloud run service</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The generation of this Service currently serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.</summary>
    [JsonPropertyName("observedGeneration")]
    public string? ObservedGeneration { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Returns true if the Service is currently being acted upon by the system to bring it into the desired state. When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state. If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision. If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in terminalCondition and conditions.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The template used to create revisions for this Service. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1V2ServiceStatusAtProviderTemplate>? Template { get; set; }

    /// <summary>The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("terminalCondition")]
    public IList<V1beta1V2ServiceStatusAtProviderTerminalCondition>? TerminalCondition { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is empty or not provided, defaults to 100% traffic to the latest Ready Revision. Structure is documented below.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1V2ServiceStatusAtProviderTraffic>? Traffic { get; set; }

    /// <summary>Detailed status information for corresponding traffic targets. See comments in reconciling for additional information on reconciliation process in Cloud Run. Structure is documented below.</summary>
    [JsonPropertyName("trafficStatuses")]
    public IList<V1beta1V2ServiceStatusAtProviderTrafficStatuses>? TrafficStatuses { get; set; }

    /// <summary>Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The main URI in which this Service is serving traffic.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1V2ServiceStatusConditions
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

public partial class V1beta1V2ServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1V2ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1V2ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1V2Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1V2ServiceSpec>, IStatus<V1beta1V2ServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "V2Service";
    public const string KubeGroup = "cloudrun.gcp.upbound.io";
    public const string KubePluralName = "v2services";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>V2ServiceSpec defines the desired state of V2Service</summary>
    [JsonPropertyName("spec")]
    public V1beta1V2ServiceSpec Spec { get; set; }

    /// <summary>V2ServiceStatus defines the observed state of V2Service.</summary>
    [JsonPropertyName("status")]
    public V1beta1V2ServiceStatus? Status { get; set; }
}