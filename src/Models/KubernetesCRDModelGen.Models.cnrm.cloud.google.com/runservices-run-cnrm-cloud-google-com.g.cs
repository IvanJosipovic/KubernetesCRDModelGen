using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.run.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RunServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RunService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RunServiceList";
    public const string KubeGroup = "run.cnrm.cloud.google.com";
    public const string KubePluralName = "runservices";
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
    public IList<V1beta1RunService> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings for the Binary Authorization feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass.</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The name of the secret in Cloud Secret Manager. Format: {secretName} if the secret is in the same project. projects/{project}/secrets/{secretName} if the secret is in a different project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersEnvValueSourceSecretKeyRefSecretRef
{
    /// <summary>Allowed value: The `name` field of a `SecretManagerSecret` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersEnvValueSourceSecretKeyRefVersionRef
{
    /// <summary>Allowed value: The `version` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>The name of the secret in Cloud Secret Manager. Format: {secretName} if the secret is in the same project. projects/{project}/secrets/{secretName} if the secret is in a different project.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1RunServiceSpecTemplateContainersEnvValueSourceSecretKeyRefSecretRef SecretRef { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1RunServiceSpecTemplateContainersEnvValueSourceSecretKeyRefVersionRef? VersionRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Source for the environment variable's value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1RunServiceSpecTemplateContainersEnvValueSourceSecretKeyRef? SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER, and mnay not exceed 32768 characters.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any route environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "", and the maximum length is 32768 bytes.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value.</summary>
    [JsonPropertyName("valueSource")]
    public V1beta1RunServiceSpecTemplateContainersEnvValueSource? ValueSource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GRPC specifies an action involving a GRPC port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersLivenessProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTPGet specifies the http request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1RunServiceSpecTemplateContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server. Defaults to '/'.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1RunServiceSpecTemplateContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1RunServiceSpecTemplateContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>If specified, used to specify which protocol to use. Allowed values are "http1" and "h2c".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersResources
{
    /// <summary>Determines whether CPU should be throttled or not outside of requests.</summary>
    [JsonPropertyName("cpuIdle")]
    public bool? CpuIdle { get; set; }

    /// <summary>Only memory and CPU are supported. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go.</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Determines whether CPU should be boosted on startup of a new container instance above the requested CPU threshold, this can help reduce cold-start latency.</summary>
    [JsonPropertyName("startupCpuBoost")]
    public bool? StartupCpuBoost { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GRPC specifies an action involving a GRPC port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersStartupProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>The header field name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1RunServiceSpecTemplateContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server. Defaults to '/'.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1RunServiceSpecTemplateContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1RunServiceSpecTemplateContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1RunServiceSpecTemplateContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run.</summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Containers which should be started before this container. If specified the container will wait to start until all containers with the listed names are healthy.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>List of environment variables to set in the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1RunServiceSpecTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images.</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta1RunServiceSpecTemplateContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible.  If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1RunServiceSpecTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources.</summary>
    [JsonPropertyName("resources")]
    public V1beta1RunServiceSpecTemplateContainersResources? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("startupProbe")]
    public V1beta1RunServiceSpecTemplateContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1RunServiceSpecTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateEncryptionKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Scaling settings for this Revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateScaling
{
    /// <summary>Maximum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public int? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of serving instances that this resource should have.</summary>
    [JsonPropertyName("minInstanceCount")]
    public int? MinInstanceCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateServiceAccountRef
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumesCloudSqlInstanceInstances
{
    /// <summary>Allowed value: The `connectionName` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumesCloudSqlInstance
{
    /// <summary></summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1RunServiceSpecTemplateVolumesCloudSqlInstanceInstances>? Instances { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Ephemeral storage used as a shared volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumesEmptyDir
{
    /// <summary>The different types of medium supported for EmptyDir. Default value: "MEMORY" Possible values: ["MEMORY"].</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field's values are of the 'Quantity' k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumesSecretItemsVersionRef
{
    /// <summary>Allowed value: The `version` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>The relative path of the secret in the container.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1RunServiceSpecTemplateVolumesSecretItemsVersionRef? VersionRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumesSecretSecretRef
{
    /// <summary>Allowed value: The `name` field of a `SecretManagerSecret` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1RunServiceSpecTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1RunServiceSpecTemplateVolumesSecretSecretRef SecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public V1beta1RunServiceSpecTemplateVolumesCloudSqlInstance? CloudSqlInstance { get; set; }

    /// <summary>Ephemeral storage used as a shared volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1beta1RunServiceSpecTemplateVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret.</summary>
    [JsonPropertyName("secret")]
    public V1beta1RunServiceSpecTemplateVolumesSecret? Secret { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVpcAccessConnectorRef
{
    /// <summary>Allowed value: The `selfLink` field of a `VPCAccessConnector` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVpcAccessNetworkInterfacesNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVpcAccessNetworkInterfacesSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1RunServiceSpecTemplateVpcAccessNetworkInterfacesNetworkRef? NetworkRef { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1RunServiceSpecTemplateVpcAccessNetworkInterfacesSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Network tags applied to this Cloud Run service.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connectorRef")]
    public V1beta1RunServiceSpecTemplateVpcAccessConnectorRef? ConnectorRef { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values: ["ALL_TRAFFIC", "PRIVATE_RANGES_ONLY"].</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1RunServiceSpecTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The template used to create revisions for this Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.  Cloud Run API v2 does not support annotations with 'run.googleapis.com', 'cloud.googleapis.com', 'serving.knative.dev', or 'autoscaling.knative.dev' namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 RevisionTemplate.  This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Holds the containers that define the unit of execution for this Service.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1RunServiceSpecTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKeyRef")]
    public V1beta1RunServiceSpecTemplateEncryptionKeyRef? EncryptionKeyRef { get; set; }

    /// <summary>The sandbox environment to host this Revision. Possible values: ["EXECUTION_ENVIRONMENT_GEN1", "EXECUTION_ENVIRONMENT_GEN2"].</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.  Cloud Run API v2 does not support labels with 'run.googleapis.com', 'cloud.googleapis.com', 'serving.knative.dev', or 'autoscaling.knative.dev' namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 RevisionTemplate.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Sets the maximum number of requests that each serving instance can receive.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public int? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>The unique name for the revision. If this field is omitted, it will be automatically generated based on the Service name.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Scaling settings for this Revision.</summary>
    [JsonPropertyName("scaling")]
    public V1beta1RunServiceSpecTemplateScaling? Scaling { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1RunServiceSpecTemplateServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Enables session affinity. For more information, go to https://cloud.google.com/run/docs/configuring/session-affinity.</summary>
    [JsonPropertyName("sessionAffinity")]
    public bool? SessionAffinity { get; set; }

    /// <summary>Max allowed time for an instance to respond to a request.  A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1RunServiceSpecTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc.</summary>
    [JsonPropertyName("vpcAccess")]
    public V1beta1RunServiceSpecTemplateVpcAccess? VpcAccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpecTraffic
{
    /// <summary>Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Revision to which to send this portion of traffic, if traffic allocation is by revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Indicates a string to be part of the URI to exclusively reference this target.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The allocation type for this traffic target. Possible values: ["TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST", "TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION"].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceSpec
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.  Cloud Run API v2 does not support annotations with 'run.googleapis.com', 'cloud.googleapis.com', 'serving.knative.dev', or 'autoscaling.knative.dev' namespaces, and they will be rejected in new resources. All system annotations in v1 now have a corresponding field in v2 Service.  This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1RunServiceSpecBinaryAuthorization? BinaryAuthorization { get; set; }

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

    /// <summary>Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values: ["INGRESS_TRAFFIC_ALL", "INGRESS_TRAFFIC_INTERNAL_ONLY", "INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER"].</summary>
    [JsonPropertyName("ingress")]
    public string? Ingress { get; set; }

    /// <summary>The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.  For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: ["UNIMPLEMENTED", "PRELAUNCH", "EARLY_ACCESS", "ALPHA", "BETA", "GA", "DEPRECATED"].</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>Immutable. The location of the cloud run service.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1RunServiceSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The template used to create revisions for this Service.</summary>
    [JsonPropertyName("template")]
    public V1beta1RunServiceSpecTemplate Template { get; set; }

    /// <summary>Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is empty or not provided, defaults to 100% traffic to the latest Ready Revision.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1RunServiceSpecTraffic>? Traffic { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceStatusConditions
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
#nullable disable

#nullable enable
/// <summary>The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceStatusTerminalCondition
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>How to interpret failures of this condition, one of Error, Warning, Info.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * "Ready": True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceStatusTrafficStatuses
{
    /// <summary>Specifies percent of the traffic to this Revision.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Revision to which this traffic is sent.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Indicates the string used in the URI to exclusively reference this target.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The allocation type for this traffic target.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Displays the target URI.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunServiceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RunServiceStatusConditions>? Conditions { get; set; }

    /// <summary>The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Email address of the authenticated creator.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>The deletion time.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>For a deleted resource, the time after which it will be permamently deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Email address of the last authenticated modifier.</summary>
    [JsonPropertyName("lastModifier")]
    public string? LastModifier { get; set; }

    /// <summary>Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
    [JsonPropertyName("latestCreatedRevision")]
    public string? LatestCreatedRevision { get; set; }

    /// <summary>Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
    [JsonPropertyName("latestReadyRevision")]
    public string? LatestReadyRevision { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Returns true if the Service is currently being acted upon by the system to bring it into the desired state.  When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.  If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision.  If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in terminalCondition and conditions.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
    [JsonPropertyName("terminalCondition")]
    public V1beta1RunServiceStatusTerminalCondition? TerminalCondition { get; set; }

    /// <summary>Detailed status information for corresponding traffic targets. See comments in reconciling for additional information on reconciliation process in Cloud Run.</summary>
    [JsonPropertyName("trafficStatuses")]
    public IList<V1beta1RunServiceStatusTrafficStatuses>? TrafficStatuses { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RunService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RunServiceSpec>, IStatus<V1beta1RunServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RunService";
    public const string KubeGroup = "run.cnrm.cloud.google.com";
    public const string KubePluralName = "runservices";
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
    public V1beta1RunServiceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1RunServiceStatus? Status { get; set; }
}
#nullable disable
