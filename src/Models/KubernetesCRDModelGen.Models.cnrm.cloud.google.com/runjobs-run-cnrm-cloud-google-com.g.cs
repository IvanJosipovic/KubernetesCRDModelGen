using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.run.cnrm.cloud.google.com;
/// <summary>Settings for the Binary Authorization feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecBinaryAuthorization
{
    /// <summary>If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass.</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>If True, indicates to use the default project's binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecProjectRef
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

/// <summary>The name of the secret in Cloud Secret Manager. Format: {secretName} if the secret is in the same project. projects/{project}/secrets/{secretName} if the secret is in a different project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef
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

/// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefVersionRef
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

/// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>The name of the secret in Cloud Secret Manager. Format: {secretName} if the secret is in the same project. projects/{project}/secrets/{secretName} if the secret is in a different project.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef SecretRef { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefVersionRef VersionRef { get; set; }
}

/// <summary>Source for the environment variable's value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER, and mnay not exceed 32768 characters.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any route environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "", and the maximum length is 32768 bytes.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value.</summary>
    [JsonPropertyName("valueSource")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSource? ValueSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>The header field name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server. Defaults to '/'.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to 8080.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>DEPRECATED. `liveness_probe` is deprecated. This field is not supported by the Cloud Run API. Periodic probe of container liveness. Container will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes This field is not supported in Cloud Run Job currently.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; containerPort &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>If specified, used to specify which protocol to use. Allowed values are "http1" and "h2c".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersResources
{
    /// <summary>Only memory and CPU are supported. Note: The only supported values for CPU are '1', '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go.</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>The header field name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server. Defaults to '/'.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to 8080.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>DEPRECATED. `startup_probe` is deprecated. This field is not supported by the Cloud Run API. Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes This field is not supported in Cloud Run Job currently.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HTTPGet specifies the http request to perform. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeoutSeconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet or TCPSocket must be specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1RunJobSpecTemplateTemplateContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud SQL volumes, it can be left empty, or must otherwise be /cloudsql. All instances defined in the Volume will be available as /cloudsql/[instance]. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run.</summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersEnv>? Env { get; set; }

    /// <summary>URL of the Container image in Google Container Registry or Google Artifact Registry. More info: https://kubernetes.io/docs/concepts/containers/images.</summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>DEPRECATED. `liveness_probe` is deprecated. This field is not supported by the Cloud Run API. Periodic probe of container liveness. Container will be restarted if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes This field is not supported in Cloud Run Job currently.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta1RunJobSpecTemplateTemplateContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container. Only a single port can be specified. The specified ports must be listening on all interfaces (0.0.0.0) within the container to be accessible.  If omitted, a port number will be chosen and passed to the container through the PORT environment variable for the container to listen on.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources.</summary>
    [JsonPropertyName("resources")]
    public V1beta1RunJobSpecTemplateTemplateContainersResources? Resources { get; set; }

    /// <summary>DEPRECATED. `startup_probe` is deprecated. This field is not supported by the Cloud Run API. Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes This field is not supported in Cloud Run Job currently.</summary>
    [JsonPropertyName("startupProbe")]
    public V1beta1RunJobSpecTemplateTemplateContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateEncryptionKeyRef
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

/// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateServiceAccountRef
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

/// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstanceInstanceRefs
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

/// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstance
{
    /// <summary></summary>
    [JsonPropertyName("instanceRefs")]
    public IList<V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstanceInstanceRefs>? InstanceRefs { get; set; }
}

/// <summary>Ephemeral storage used as a shared volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesEmptyDir
{
    /// <summary>The different types of medium supported for EmptyDir. Default value: "MEMORY" Possible values: ["MEMORY"].</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field's values are of the 'Quantity' k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecretItemsVersionRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume's default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>The relative path of the secret in the container.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific version</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1RunJobSpecTemplateTemplateVolumesSecretItemsVersionRef VersionRef { get; set; }
}

/// <summary>The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecretSecretRef
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

/// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default. Must be a value between 0000 and 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1RunJobSpecTemplateTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1RunJobSpecTemplateTemplateVolumesSecretSecretRef SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstance? CloudSqlInstance { get; set; }

    /// <summary>Ephemeral storage used as a shared volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1beta1RunJobSpecTemplateTemplateVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret.</summary>
    [JsonPropertyName("secret")]
    public V1beta1RunJobSpecTemplateTemplateVolumesSecret? Secret { get; set; }
}

/// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessConnectorRef
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

/// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesNetworkRef
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

/// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesSubnetworkRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfaces
{
    /// <summary>The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesNetworkRef? NetworkRef { get; set; }

    /// <summary>The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Network tags applied to this Cloud Run job.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}, where {project} can be project id or number.</summary>
    [JsonPropertyName("connectorRef")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccessConnectorRef? ConnectorRef { get; set; }

    /// <summary>Traffic VPC egress settings. Possible values: ["ALL_TRAFFIC", "PRIVATE_RANGES_ONLY"].</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Direct VPC egress settings. Currently only single network interface is supported.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>Describes the task(s) that will be created when executing an execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplate
{
    /// <summary>Holds the single container that defines the unit of execution for this task.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKeyRef")]
    public V1beta1RunJobSpecTemplateTemplateEncryptionKeyRef? EncryptionKeyRef { get; set; }

    /// <summary>The execution environment being used to host this Task. Possible values: ["EXECUTION_ENVIRONMENT_GEN1", "EXECUTION_ENVIRONMENT_GEN2"].</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Number of retries allowed per Task, before marking this Task failed.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1RunJobSpecTemplateTemplateServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Max allowed time duration the Task may be active before the system will actively try to mark it failed and kill associated containers. This applies per attempt of a task, meaning each retry can run for the full timeout.  A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>A list of Volumes to make available to containers.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1RunJobSpecTemplateTemplateVolumes>? Volumes { get; set; }

    /// <summary>VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc.</summary>
    [JsonPropertyName("vpcAccess")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccess? VpcAccess { get; set; }
}

/// <summary>The template used to create executions for this Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplate
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.  Cloud Run API v2 does not support annotations with 'run.googleapis.com', 'cloud.googleapis.com', 'serving.knative.dev', or 'autoscaling.knative.dev' namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2 ExecutionTemplate.  This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Specifies the maximum desired number of tasks the execution should run at given time. Must be &lt;= taskCount. When the job is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual number of tasks running in steady state will be less than this number when there are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max parallelism.</summary>
    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    /// <summary>Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is limited to 1 and the success of that task signals the success of the execution. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/.</summary>
    [JsonPropertyName("taskCount")]
    public int? TaskCount { get; set; }

    /// <summary>Describes the task(s) that will be created when executing an execution.</summary>
    [JsonPropertyName("template")]
    public V1beta1RunJobSpecTemplateTemplate Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpec
{
    /// <summary>Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.  Cloud Run API v2 does not support annotations with 'run.googleapis.com', 'cloud.googleapis.com', 'serving.knative.dev', or 'autoscaling.knative.dev' namespaces, and they will be rejected on new resources. All system annotations in v1 now have a corresponding field in v2 Job.  This field follows Kubernetes annotations' namespacing, limits, and rules.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Settings for the Binary Authorization feature.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1RunJobSpecBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA. If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.  For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: ["UNIMPLEMENTED", "PRELAUNCH", "EARLY_ACCESS", "ALPHA", "BETA", "GA", "DEPRECATED"].</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>Immutable. The location of the cloud run job.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1RunJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The template used to create executions for this Job.</summary>
    [JsonPropertyName("template")]
    public V1beta1RunJobSpecTemplate Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobStatusConditions
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
public partial class V1beta1RunJobStatusLatestCreatedExecution
{
    /// <summary>Completion timestamp of the execution.  A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("completionTime")]
    public string? CompletionTime { get; set; }

    /// <summary>Creation timestamp of the execution.  A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Name of the execution.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobStatusTerminalCondition
{
    /// <summary>A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.  A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RunJobStatusConditions>? Conditions { get; set; }

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

    /// <summary>Number of executions created for this job.</summary>
    [JsonPropertyName("executionCount")]
    public int? ExecutionCount { get; set; }

    /// <summary>For a deleted resource, the time after which it will be permamently deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Email address of the last authenticated modifier.</summary>
    [JsonPropertyName("lastModifier")]
    public string? LastModifier { get; set; }

    /// <summary>Name of the last created execution.</summary>
    [JsonPropertyName("latestCreatedExecution")]
    public IList<V1beta1RunJobStatusLatestCreatedExecution>? LatestCreatedExecution { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Returns true if the Job is currently being acted upon by the system to bring it into the desired state.  When a new Job is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Job to the desired state. This process is called reconciliation. While reconciliation is in process, observedGeneration and latest_succeeded_execution, will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the state matches the Job, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.  If reconciliation succeeded, the following fields will match: observedGeneration and generation, latest_succeeded_execution and latestCreatedExecution.  If reconciliation failed, observedGeneration and latest_succeeded_execution will have the state of the last succeeded execution or empty for newly created Job. Additional information on the failure can be found in terminalCondition and conditions.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The Condition of this Job, containing its readiness status, and detailed error information in case it did not reach the desired state.</summary>
    [JsonPropertyName("terminalCondition")]
    public IList<V1beta1RunJobStatusTerminalCondition>? TerminalCondition { get; set; }

    /// <summary>Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RunJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RunJobSpec>, IStatus<V1beta1RunJobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RunJob";
    public const string KubeGroup = "run.cnrm.cloud.google.com";
    public const string KubePluralName = "runjobs";
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
    public V1beta1RunJobSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1RunJobStatus? Status { get; set; }
}