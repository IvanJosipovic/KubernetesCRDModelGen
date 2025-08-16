using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serving.knative.dev;
/// <summary>Configuration represents the "floating HEAD" of a linear history of Revisions. Users create new Revisions by updating the Configuration's spec. The "latest created" revision's name is available under status, as is the "latest ready" revision's name. See also: https://github.com/knative/serving/blob/main/docs/spec/overview.md#configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1Configuration>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ConfigurationList";
    public const string KubeGroup = "serving.knative.dev";
    public const string KubePluralName = "configurations";
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
    public IList<V1Configuration> Items { get; set; }
}

/// <summary>Selects a key of a ConfigMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Selects a key of a secret in the pod's namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersEnvValueFrom
{
    /// <summary>Selects a key of a ConfigMap.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1ConfigurationSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-fieldref</summary>
    [JsonPropertyName("fieldRef")]
    public JsonNode? FieldRef { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-fieldref</summary>
    [JsonPropertyName("resourceFieldRef")]
    public JsonNode? ResourceFieldRef { get; set; }

    /// <summary>Selects a key of a secret in the pod's namespace</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1ConfigurationSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>EnvVar represents an environment variable present in a Container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
    [JsonPropertyName("valueFrom")]
    public V1ConfigurationSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The ConfigMap to select from</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EnvFromSource represents the source of a set of ConfigMaps or Secrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersEnvFrom
{
    /// <summary>The ConfigMap to select from</summary>
    [JsonPropertyName("configMapRef")]
    public V1ConfigurationSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>Optional text to prepend to the name of each environment variable. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from</summary>
    [JsonPropertyName("secretRef")]
    public V1ConfigurationSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>Exec specifies a command to execute in the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersLivenessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies a GRPC HealthCheckRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).  If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies an HTTP GET request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1ConfigurationSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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

/// <summary>TCPSocket specifies a connection to a TCP port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersLivenessProbe
{
    /// <summary>Exec specifies a command to execute in the container.</summary>
    [JsonPropertyName("exec")]
    public V1ConfigurationSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies a GRPC HealthCheckRequest.</summary>
    [JsonPropertyName("grpc")]
    public V1ConfigurationSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies an HTTP GET request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1ConfigurationSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies a connection to a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1ConfigurationSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ContainerPort represents a network port in a single container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersPorts
{
    /// <summary>Number of port to expose on the pod's IP address. This must be a valid port number, 0 &lt; x &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Exec specifies a command to execute in the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersReadinessProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies a GRPC HealthCheckRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersReadinessProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).  If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies an HTTP GET request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersReadinessProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1ConfigurationSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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

/// <summary>TCPSocket specifies a connection to a TCP port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }
}

/// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersReadinessProbe
{
    /// <summary>Exec specifies a command to execute in the container.</summary>
    [JsonPropertyName("exec")]
    public V1ConfigurationSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies a GRPC HealthCheckRequest.</summary>
    [JsonPropertyName("grpc")]
    public V1ConfigurationSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies an HTTP GET request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1ConfigurationSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies a connection to a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1ConfigurationSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersSecurityContextCapabilities
{
    /// <summary>This is accessible behind a feature flag - kubernetes.containerspec-addcapabilities</summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary>Removed capabilities</summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary>The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    /// <summary>localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:  Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersSecurityContext
{
    /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.</summary>
    [JsonPropertyName("capabilities")]
    public V1ConfigurationSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary>Run container in privileged mode. This can only be set to explicitly to 'false'</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

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
    public V1ConfigurationSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }
}

/// <summary>Exec specifies a command to execute in the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersStartupProbeExec
{
    /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>GRPC specifies a GRPC HealthCheckRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).  If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>HTTPGet specifies an HTTP GET request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1ConfigurationSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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

/// <summary>TCPSocket specifies a connection to a TCP port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }
}

/// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersStartupProbe
{
    /// <summary>Exec specifies a command to execute in the container.</summary>
    [JsonPropertyName("exec")]
    public V1ConfigurationSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies a GRPC HealthCheckRequest.</summary>
    [JsonPropertyName("grpc")]
    public V1ConfigurationSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies an HTTP GET request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1ConfigurationSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TCPSocket specifies a connection to a TCP port.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1ConfigurationSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-volumes-mount-propagation</summary>
    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecContainers
{
    /// <summary>Arguments to the entrypoint. The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Cannot be updated.</summary>
    [JsonPropertyName("env")]
    public IList<V1ConfigurationSpecTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1ConfigurationSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Container image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("livenessProbe")]
    public V1ConfigurationSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated.</summary>
    [JsonPropertyName("ports")]
    public IList<V1ConfigurationSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("readinessProbe")]
    public V1ConfigurationSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("resources")]
    public V1ConfigurationSpecTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
    [JsonPropertyName("securityContext")]
    public V1ConfigurationSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("startupProbe")]
    public V1ConfigurationSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary>Pod volumes to mount into the container's filesystem. Cannot be updated.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1ConfigurationSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecImagePullSecrets
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesConfigMapItems
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesConfigMap
{
    /// <summary>defaultMode is optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1ConfigurationSpecTemplateSpecVolumesConfigMapItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional specify whether the ConfigMap or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesConfigMapItems
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesConfigMap
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesConfigMapItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional specify whether the ConfigMap or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems
{
    /// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
    [JsonPropertyName("fieldRef")]
    public V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    /// <summary>Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

/// <summary>downwardAPI information about the downwardAPI data to project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPI
{
    /// <summary>Items is a list of DownwardAPIVolume file</summary>
    [JsonPropertyName("items")]
    public IList<V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPIItems>? Items { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesSecretItems
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesSecret
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesSecretItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional field specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken
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

/// <summary>Projection that may be projected along with other supported volume types. Exactly one of these fields must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjectedSources
{
    /// <summary>configMap information about the configMap data to project</summary>
    [JsonPropertyName("configMap")]
    public V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesConfigMap? ConfigMap { get; set; }

    /// <summary>downwardAPI information about the downwardAPI data to project</summary>
    [JsonPropertyName("downwardAPI")]
    public V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesDownwardAPI? DownwardAPI { get; set; }

    /// <summary>secret information about the secret data to project</summary>
    [JsonPropertyName("secret")]
    public V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesSecret? Secret { get; set; }

    /// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
    [JsonPropertyName("serviceAccountToken")]
    public V1ConfigurationSpecTemplateSpecVolumesProjectedSourcesServiceAccountToken? ServiceAccountToken { get; set; }
}

/// <summary>projected items for all in one resources secrets, configmaps, and downward API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesProjected
{
    /// <summary>defaultMode are the mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>sources is the list of volume projections. Each entry in this list handles one source.</summary>
    [JsonPropertyName("sources")]
    public IList<V1ConfigurationSpecTemplateSpecVolumesProjectedSources>? Sources { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesSecretItems
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumesSecret
{
    /// <summary>defaultMode is Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>items If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1ConfigurationSpecTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>optional field specify whether the Secret or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>secretName is the name of the secret in the pod's namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Volume represents a named volume in a pod that may be accessed by any container in the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpecVolumes
{
    /// <summary>configMap represents a configMap that should populate this volume</summary>
    [JsonPropertyName("configMap")]
    public V1ConfigurationSpecTemplateSpecVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-volumes-csi</summary>
    [JsonPropertyName("csi")]
    public JsonNode? Csi { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-volumes-emptydir</summary>
    [JsonPropertyName("emptyDir")]
    public JsonNode? EmptyDir { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-volumes-hostpath</summary>
    [JsonPropertyName("hostPath")]
    public JsonNode? HostPath { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-volumes-image</summary>
    [JsonPropertyName("image")]
    public JsonNode? Image { get; set; }

    /// <summary>name of the volume. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-persistent-volume-claim</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public JsonNode? PersistentVolumeClaim { get; set; }

    /// <summary>projected items for all in one resources secrets, configmaps, and downward API</summary>
    [JsonPropertyName("projected")]
    public V1ConfigurationSpecTemplateSpecVolumesProjected? Projected { get; set; }

    /// <summary>secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
    [JsonPropertyName("secret")]
    public V1ConfigurationSpecTemplateSpecVolumesSecret? Secret { get; set; }
}

/// <summary>RevisionSpec holds the desired state of the Revision (from the client).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplateSpec
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
    public IList<V1ConfigurationSpecTemplateSpecContainers> Containers { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-dnsconfig</summary>
    [JsonPropertyName("dnsConfig")]
    public JsonNode? DnsConfig { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-dnspolicy</summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary>EnableServiceLinks indicates whether information aboutservices should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Knative defaults this to false.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-hostaliases</summary>
    [JsonPropertyName("hostAliases")]
    public IList<JsonNode>? HostAliases { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-hostipc</summary>
    [JsonPropertyName("hostIPC")]
    public bool? HostIPC { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-hostnetwork</summary>
    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-hostpid</summary>
    [JsonPropertyName("hostPID")]
    public bool? HostPID { get; set; }

    /// <summary>IdleTimeoutSeconds is the maximum duration in seconds a request will be allowed to stay open while not receiving any bytes from the user's application. If unspecified, a system default will be provided.</summary>
    [JsonPropertyName("idleTimeoutSeconds")]
    public long? IdleTimeoutSeconds { get; set; }

    /// <summary>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1ConfigurationSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-init-containers</summary>
    [JsonPropertyName("initContainers")]
    public IList<JsonNode>? InitContainers { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-nodeselector</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-priorityclassname</summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>ResponseStartTimeoutSeconds is the maximum duration in seconds that the request routing layer will wait for a request delivered to a container to begin sending any network traffic.</summary>
    [JsonPropertyName("responseStartTimeoutSeconds")]
    public long? ResponseStartTimeoutSeconds { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-runtimeclassname</summary>
    [JsonPropertyName("runtimeClassName")]
    public string? RuntimeClassName { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-schedulername</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-securitycontext</summary>
    [JsonPropertyName("securityContext")]
    public JsonNode? SecurityContext { get; set; }

    /// <summary>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>This is accessible behind a feature flag - kubernetes.podspec-shareprocessnamespace</summary>
    [JsonPropertyName("shareProcessNamespace")]
    public bool? ShareProcessNamespace { get; set; }

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
    public IList<V1ConfigurationSpecTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>Template holds the latest specification for the Revision to be stamped out.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>RevisionSpec holds the desired state of the Revision (from the client).</summary>
    [JsonPropertyName("spec")]
    public V1ConfigurationSpecTemplateSpec? Spec { get; set; }
}

/// <summary>ConfigurationSpec holds the desired state of the Configuration (from the client).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpec
{
    /// <summary>Template holds the latest specification for the Revision to be stamped out.</summary>
    [JsonPropertyName("template")]
    public V1ConfigurationSpecTemplate? Template { get; set; }
}

/// <summary>Condition defines a readiness condition for a Knative resource. See: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#typical-status-properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationStatusConditions
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

/// <summary>ConfigurationStatus communicates the observed state of the Configuration (from the controller).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>LatestCreatedRevisionName is the last revision that was created from this Configuration. It might not be ready yet, for that use LatestReadyRevisionName.</summary>
    [JsonPropertyName("latestCreatedRevisionName")]
    public string? LatestCreatedRevisionName { get; set; }

    /// <summary>LatestReadyRevisionName holds the name of the latest Revision stamped out from this Configuration that has had its "Ready" condition become "True".</summary>
    [JsonPropertyName("latestReadyRevisionName")]
    public string? LatestReadyRevisionName { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Configuration represents the "floating HEAD" of a linear history of Revisions. Users create new Revisions by updating the Configuration's spec. The "latest created" revision's name is available under status, as is the "latest ready" revision's name. See also: https://github.com/knative/serving/blob/main/docs/spec/overview.md#configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Configuration : IKubernetesObject<V1ObjectMeta>, ISpec<V1ConfigurationSpec>, IStatus<V1ConfigurationStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Configuration";
    public const string KubeGroup = "serving.knative.dev";
    public const string KubePluralName = "configurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigurationSpec holds the desired state of the Configuration (from the client).</summary>
    [JsonPropertyName("spec")]
    public V1ConfigurationSpec? Spec { get; set; }

    /// <summary>ConfigurationStatus communicates the observed state of the Configuration (from the controller).</summary>
    [JsonPropertyName("status")]
    public V1ConfigurationStatus? Status { get; set; }
}