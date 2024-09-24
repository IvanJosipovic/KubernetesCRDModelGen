using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serving.knative.dev;
/// <summary>Selects a key of a ConfigMap.</summary>
public partial class V1RevisionSpecContainersEnvValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Selects a key of a secret in the pod's namespace</summary>
public partial class V1RevisionSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
public partial class V1RevisionSpecContainersEnvValueFrom
{
    /// <summary>Selects a key of a ConfigMap.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1RevisionSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-fieldref</summary>
    [JsonPropertyName("fieldRef")]
    public JsonNode? FieldRef { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-fieldref</summary>
    [JsonPropertyName("resourceFieldRef")]
    public JsonNode? ResourceFieldRef { get; set; }

    /// <summary>Selects a key of a secret in the pod's namespace</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1RevisionSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>EnvVar represents an environment variable present in a Container.</summary>
public partial class V1RevisionSpecContainersEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
    [JsonPropertyName("valueFrom")]
    public V1RevisionSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The ConfigMap to select from</summary>
public partial class V1RevisionSpecContainersEnvFromConfigMapRef
{
    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from</summary>
public partial class V1RevisionSpecContainersEnvFromSecretRef
{
    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EnvFromSource represents the source of a set of ConfigMaps</summary>
public partial class V1RevisionSpecContainersEnvFrom
{
    /// <summary>The ConfigMap to select from</summary>
    [JsonPropertyName("configMapRef")]
    public V1RevisionSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from</summary>
    [JsonPropertyName("secretRef")]
    public V1RevisionSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1RevisionSpecContainersLivenessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1RevisionSpecContainersLivenessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1RevisionSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1RevisionSpecContainersLivenessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1RevisionSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1RevisionSpecContainersLivenessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1RevisionSpecContainersLivenessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1RevisionSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1RevisionSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1RevisionSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1RevisionSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerPort represents a network port in a single container.</summary>
public partial class V1RevisionSpecContainersPorts
{
    /// <summary>Number of port to expose on the pod's IP address. This must be a valid port number, 0 &lt; x &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int ContainerPort { get; set; }

    /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1RevisionSpecContainersReadinessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1RevisionSpecContainersReadinessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1RevisionSpecContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1RevisionSpecContainersReadinessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1RevisionSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1RevisionSpecContainersReadinessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }
}

/// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1RevisionSpecContainersReadinessProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1RevisionSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1RevisionSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1RevisionSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1RevisionSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
public partial class V1RevisionSpecContainersResourcesClaims
{
    /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
public partial class V1RevisionSpecContainersResources
{
    /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.   This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.   This field is immutable. It can only be set for containers.</summary>
    [JsonPropertyName("claims")]
    public IList<V1RevisionSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1RevisionSpecContainersSecurityContextCapabilities
{
    /// <summary>This is accessible behind a feature flag - kubernetes.containerspec-addcapabilities</summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary>Removed capabilities</summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
public partial class V1RevisionSpecContainersSecurityContextSeccompProfile
{
    /// <summary>localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:   Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
public partial class V1RevisionSpecContainersSecurityContext
{
    /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("capabilities")]
    public V1RevisionSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary>Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("seccompProfile")]
    public V1RevisionSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }
}

/// <summary>Exec specifies the action to take.</summary>
public partial class V1RevisionSpecContainersStartupProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port.</summary>
public partial class V1RevisionSpecContainersStartupProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).   If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
public partial class V1RevisionSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform.</summary>
public partial class V1RevisionSpecContainersStartupProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1RevisionSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }

    /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port.</summary>
public partial class V1RevisionSpecContainersStartupProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }
}

/// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
public partial class V1RevisionSpecContainersStartupProbe
{
    /// <summary>Exec specifies the action to take.</summary>
    [JsonPropertyName("exec")]
    public V1RevisionSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1RevisionSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1RevisionSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1RevisionSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
public partial class V1RevisionSpecContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary>A single application container that you want to run within a pod.</summary>
public partial class V1RevisionSpecContainers
{
    /// <summary>Arguments to the entrypoint. The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Cannot be updated.</summary>
    [JsonPropertyName("env")]
    public IList<V1RevisionSpecContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1RevisionSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Container image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("livenessProbe")]
    public V1RevisionSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated.</summary>
    [JsonPropertyName("ports")]
    public IList<V1RevisionSpecContainersPorts>? Ports { get; set; }

    /// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("readinessProbe")]
    public V1RevisionSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("resources")]
    public V1RevisionSpecContainersResources? Resources { get; set; }

    /// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
    [JsonPropertyName("securityContext")]
    public V1RevisionSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("startupProbe")]
    public V1RevisionSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary>Pod volumes to mount into the container's filesystem. Cannot be updated.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1RevisionSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
public partial class V1RevisionSpecImagePullSecrets
{
    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1RevisionSpecVolumesConfigMapItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>configMap represents a configMap that should populate this volume</summary>
public partial class V1RevisionSpecVolumesConfigMap
{
    /// <summary>defaultMode is optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1RevisionSpecVolumesConfigMapItems>? Items { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional specify whether the ConfigMap or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesConfigMapItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>configMap information about the configMap data to project</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesConfigMap
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1RevisionSpecVolumesProjectedSourcesConfigMapItems>? Items { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional specify whether the ConfigMap or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>DownwardAPIVolumeFile represents information to create the file containing the pod field</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesDownwardAPIItems
{
    /// <summary>Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.</summary>
    [JsonPropertyName("fieldRef")]
    public V1RevisionSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    /// <summary>Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1RevisionSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

/// <summary>downwardAPI information about the downwardAPI data to project</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesDownwardAPI
{
    /// <summary>Items is a list of DownwardAPIVolume file</summary>
    [JsonPropertyName("items")]
    public IList<V1RevisionSpecVolumesProjectedSourcesDownwardAPIItems>? Items { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesSecretItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>secret information about the secret data to project</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesSecret
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1RevisionSpecVolumesProjectedSourcesSecretItems>? Items { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional field specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
public partial class V1RevisionSpecVolumesProjectedSourcesServiceAccountToken
{
    /// <summary>audience is the intended audience of the token. A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>expirationSeconds is the requested duration of validity of the service account token. As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.</summary>
    [JsonPropertyName("expirationSeconds")]
    public long? ExpirationSeconds { get; set; }

    /// <summary>path is the path relative to the mount point of the file to project the token into.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>Projection that may be projected along with other supported volume types</summary>
public partial class V1RevisionSpecVolumesProjectedSources
{
    /// <summary>configMap information about the configMap data to project</summary>
    [JsonPropertyName("configMap")]
    public V1RevisionSpecVolumesProjectedSourcesConfigMap? ConfigMap { get; set; }

    /// <summary>downwardAPI information about the downwardAPI data to project</summary>
    [JsonPropertyName("downwardAPI")]
    public V1RevisionSpecVolumesProjectedSourcesDownwardAPI? DownwardAPI { get; set; }

    /// <summary>secret information about the secret data to project</summary>
    [JsonPropertyName("secret")]
    public V1RevisionSpecVolumesProjectedSourcesSecret? Secret { get; set; }

    /// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
    [JsonPropertyName("serviceAccountToken")]
    public V1RevisionSpecVolumesProjectedSourcesServiceAccountToken? ServiceAccountToken { get; set; }
}

/// <summary>projected items for all in one resources secrets, configmaps, and downward API</summary>
public partial class V1RevisionSpecVolumesProjected
{
    /// <summary>defaultMode are the mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>sources is the list of volume projections</summary>
    [JsonPropertyName("sources")]
    public IList<V1RevisionSpecVolumesProjectedSources>? Sources { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
public partial class V1RevisionSpecVolumesSecretItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
public partial class V1RevisionSpecVolumesSecret
{
    /// <summary>defaultMode is Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>items If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1RevisionSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>optional field specify whether the Secret or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>secretName is the name of the secret in the pod's namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Volume represents a named volume in a pod that may be accessed by any container in the pod.</summary>
public partial class V1RevisionSpecVolumes
{
    /// <summary>configMap represents a configMap that should populate this volume</summary>
    [JsonPropertyName("configMap")]
    public V1RevisionSpecVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-emptydir</summary>
    [JsonPropertyName("emptyDir")]
    public JsonNode? EmptyDir { get; set; }

    /// <summary>name of the volume. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-persistent-volume-claim</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public JsonNode? PersistentVolumeClaim { get; set; }

    /// <summary>projected items for all in one resources secrets, configmaps, and downward API</summary>
    [JsonPropertyName("projected")]
    public V1RevisionSpecVolumesProjected? Projected { get; set; }

    /// <summary>secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
    [JsonPropertyName("secret")]
    public V1RevisionSpecVolumesSecret? Secret { get; set; }
}

/// <summary>RevisionSpec holds the desired state of the Revision (from the client).</summary>
public partial class V1RevisionSpec
{
    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-affinity</summary>
    [JsonPropertyName("affinity")]
    public JsonNode? Affinity { get; set; }

    /// <summary>AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.</summary>
    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary>ContainerConcurrency specifies the maximum allowed in-flight (concurrent) requests per container of the Revision.  Defaults to `0` which means concurrency to the application is not limited, and the system decides the target concurrency for the autoscaler.</summary>
    [JsonPropertyName("containerConcurrency")]
    public long? ContainerConcurrency { get; set; }

    /// <summary>List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.</summary>
    [JsonPropertyName("containers")]
    public IList<V1RevisionSpecContainers> Containers { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-dnsconfig</summary>
    [JsonPropertyName("dnsConfig")]
    public JsonNode? DnsConfig { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-dnspolicy</summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary>EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Knative defaults this to false.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-hostaliases</summary>
    [JsonPropertyName("hostAliases")]
    public IList<JsonNode>? HostAliases { get; set; }

    /// <summary>IdleTimeoutSeconds is the maximum duration in seconds a request will be allowed to stay open while not receiving any bytes from the user's application. If unspecified, a system default will be provided.</summary>
    [JsonPropertyName("idleTimeoutSeconds")]
    public long? IdleTimeoutSeconds { get; set; }

    /// <summary>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1RevisionSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, Liveness probes, or Startup probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/</summary>
    [JsonPropertyName("initContainers")]
    public IList<JsonNode>? InitContainers { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-nodeselector</summary>
    [JsonPropertyName("nodeSelector")]
    public JsonNode? NodeSelector { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-priorityclassname</summary>
    [JsonPropertyName("priorityClassName")]
    public JsonNode? PriorityClassName { get; set; }

    /// <summary>ResponseStartTimeoutSeconds is the maximum duration in seconds that the request routing layer will wait for a request delivered to a container to begin sending any network traffic.</summary>
    [JsonPropertyName("responseStartTimeoutSeconds")]
    public long? ResponseStartTimeoutSeconds { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-runtimeclassname</summary>
    [JsonPropertyName("runtimeClassName")]
    public JsonNode? RuntimeClassName { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-schedulername</summary>
    [JsonPropertyName("schedulerName")]
    public JsonNode? SchedulerName { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-securitycontext</summary>
    [JsonPropertyName("securityContext")]
    public JsonNode? SecurityContext { get; set; }

    /// <summary>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-shareproccessnamespace</summary>
    [JsonPropertyName("shareProcessNamespace")]
    public JsonNode? ShareProcessNamespace { get; set; }

    /// <summary>TimeoutSeconds is the maximum duration in seconds that the request instance is allowed to respond to a request. If unspecified, a system default will be provided.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public long? TimeoutSeconds { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-tolerations</summary>
    [JsonPropertyName("tolerations")]
    public IList<JsonNode>? Tolerations { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-topologyspreadconstraints</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<JsonNode>? TopologySpreadConstraints { get; set; }

    /// <summary>List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes</summary>
    [JsonPropertyName("volumes")]
    public IList<V1RevisionSpecVolumes>? Volumes { get; set; }
}

/// <summary>Condition defines a readiness condition for a Knative resource. See: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#typical-status-properties</summary>
public partial class V1RevisionStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ContainerStatus holds the information of container name and image digest value</summary>
public partial class V1RevisionStatusContainerStatuses
{
    /// <summary></summary>
    [JsonPropertyName("imageDigest")]
    public string? ImageDigest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ContainerStatus holds the information of container name and image digest value</summary>
public partial class V1RevisionStatusInitContainerStatuses
{
    /// <summary></summary>
    [JsonPropertyName("imageDigest")]
    public string? ImageDigest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RevisionStatus communicates the observed state of the Revision (from the controller).</summary>
public partial class V1RevisionStatus
{
    /// <summary>ActualReplicas reflects the amount of ready pods running this revision.</summary>
    [JsonPropertyName("actualReplicas")]
    public int? ActualReplicas { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1RevisionStatusConditions>? Conditions { get; set; }

    /// <summary>ContainerStatuses is a slice of images present in .Spec.Container[*].Image to their respective digests and their container name. The digests are resolved during the creation of Revision. ContainerStatuses holds the container name and image digests for both serving and non serving containers. ref: http://bit.ly/image-digests</summary>
    [JsonPropertyName("containerStatuses")]
    public IList<V1RevisionStatusContainerStatuses>? ContainerStatuses { get; set; }

    /// <summary>DesiredReplicas reflects the desired amount of pods running this revision.</summary>
    [JsonPropertyName("desiredReplicas")]
    public int? DesiredReplicas { get; set; }

    /// <summary>InitContainerStatuses is a slice of images present in .Spec.InitContainer[*].Image to their respective digests and their container name. The digests are resolved during the creation of Revision. ContainerStatuses holds the container name and image digests for both serving and non serving containers. ref: http://bit.ly/image-digests</summary>
    [JsonPropertyName("initContainerStatuses")]
    public IList<V1RevisionStatusInitContainerStatuses>? InitContainerStatuses { get; set; }

    /// <summary>LogURL specifies the generated logging url for this particular revision based on the revision url template specified in the controller's config.</summary>
    [JsonPropertyName("logUrl")]
    public string? LogUrl { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Revision is an immutable snapshot of code and configuration.  A revision references a container image. Revisions are created by updates to a Configuration.   See also: https://github.com/knative/serving/blob/main/docs/spec/overview.md#revision</summary>
public partial class V1Revision : IKubernetesObject<V1ObjectMeta>, ISpec<V1RevisionSpec>, IStatus<V1RevisionStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Revision";
    public const string KubeGroup = "serving.knative.dev";
    public const string KubePluralName = "revisions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RevisionSpec holds the desired state of the Revision (from the client).</summary>
    [JsonPropertyName("spec")]
    public V1RevisionSpec? Spec { get; set; }

    /// <summary>RevisionStatus communicates the observed state of the Revision (from the controller).</summary>
    [JsonPropertyName("status")]
    public V1RevisionStatus? Status { get; set; }
}