using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudrun.gcp.m.upbound.io;
/// <summary>Service is the Schema for the Services API. A Cloud Run service has a unique endpoint and autoscales containers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Service>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "cloudrun.gcp.m.upbound.io";
    public const string KubePluralName = "services";
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
    public IList<V1beta1Service> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderMetadataNamespaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderMetadataNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderMetadataNamespaceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderMetadataNamespaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderMetadataNamespaceSelector
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
    public V1beta1ServiceSpecForProviderMetadataNamespaceSelectorPolicy? Policy { get; set; }
}

/// <summary>Metadata associated with this Service, including name, namespace, labels, and annotations. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation keys to configure features on a Revision template:</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number. It will default to the resource's project.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceRef")]
    public V1beta1ServiceSpecForProviderMetadataNamespaceRef? NamespaceRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta1ServiceSpecForProviderMetadataNamespaceSelector? NamespaceSelector { get; set; }
}

/// <summary>Optional metadata for this Revision, including labels and annotations. Name will be generated by the Configuration. To set minimum instances for this revision, use the "autoscaling.knative.dev/minScale" annotation key. To set maximum instances for this revision, use the "autoscaling.knative.dev/maxScale" annotation key. To set Cloud SQL connections for the revision, use the "run.googleapis.com/cloudsql-instances" annotation key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation keys to configure features on a Revision template:</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number. It will default to the resource's project.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector
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
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Selects a key (version) of a secret in Secret Manager. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific version.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef? NameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector? NameSelector { get; set; }
}

/// <summary>Source for the environment variable's value. Only supports secret_key_ref. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFrom
{
    /// <summary>Selects a key (version) of a secret in Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Only supports secret_key_ref. Structure is documented below.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The ConfigMap to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFrom
{
    /// <summary>The ConfigMap to select from. Structure is documented below.</summary>
    [JsonPropertyName("configMapRef")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is 240.</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid port number (between 1 and 65535). Defaults to "8080".</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be "TCP". Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Compute Resources required by this container. Used to set values such as max memory Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>TcpSocket specifies an action involving a TCP port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is 240.</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TcpSocket specifies an action involving a TCP port. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Structure is documented below.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Docker image name. This is most often a reference to a container located in the container registry, such as gcr.io/cloudrun/hello</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Structure is documented below.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of open ports in the container. Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resources required by this container. Used to set values such as max memory Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. Structure is documented below.</summary>
    [JsonPropertyName("startupProbe")]
    public V1beta1ServiceSpecForProviderTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Only supports SecretVolumeSources. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>A filesystem specified by the Container Storage Interface (CSI). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesCsi
{
    /// <summary>Unique name representing the type of file system to be created. Cloud Run supports the following values:</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Driver-specific attributes. The following options are supported for available drivers:</summary>
    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. The default is "" which means to use the node's default medium. Must be an empty string (default) or Memory.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field's values are of the 'Quantity' k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>A filesystem backed by a Network File System share. This filesystem requires the run.googleapis.com/execution-environment annotation to be unset or set to "gen2" Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesNfs
{
    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>IP address or hostname of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretItems
{
    /// <summary>A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific version.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Mode bits to use on this file, must be a value between 0000 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelector
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
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The secret's value will be presented as the content of a file whose name is defined in the item path. If no items are defined, the name of the file is the secret_name. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumesSecret
{
    /// <summary>Mode bits to use on created files by default. Must be a value between 0000 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret_name. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a key and a path. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project. If the secret is in another project, you must define an alias. An alias definition has the form: {alias}:projects/{project-id|project-number}/secrets/{secret-name}. If multiple alias definitions are needed, they must be separated by commas. The alias definitions must be set on the run.googleapis.com/secrets annotation.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameRef")]
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRef? SecretNameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameSelector")]
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelector? SecretNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpecVolumes
{
    /// <summary>A filesystem specified by the Container Storage Interface (CSI). Structure is documented below.</summary>
    [JsonPropertyName("csi")]
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesCsi? Csi { get; set; }

    /// <summary>Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs). Structure is documented below.</summary>
    [JsonPropertyName("emptyDir")]
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A filesystem backed by a Network File System share. This filesystem requires the run.googleapis.com/execution-environment annotation to be unset or set to "gen2" Structure is documented below.</summary>
    [JsonPropertyName("nfs")]
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesNfs? Nfs { get; set; }

    /// <summary>The secret's value will be presented as the content of a file whose name is defined in the item path. If no items are defined, the name of the file is the secret_name. Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public V1beta1ServiceSpecForProviderTemplateSpecVolumesSecret? Secret { get; set; }
}

/// <summary>RevisionSpec holds the desired state of the Revision (from the client). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplateSpec
{
    /// <summary>ContainerConcurrency specifies the maximum allowed in-flight (concurrent) requests per container of the Revision. If not specified or 0, defaults to 80 when requested CPU &gt;= 1 and defaults to 1 when requested CPU &lt; 1.</summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>Containers defines the unit of execution for this Revision. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecContainers>? Containers { get; set; }

    /// <summary>Node Selector describes the hardware requirements of the resources. Use the following node selector keys to configure features on a Revision:</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>Volume represents a named volume in a container. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1ServiceSpecForProviderTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>template holds the latest specification for the Revision to be stamped out. The template references the container image, and may also include labels and annotations that should be attached to the Revision. To correlate a Revision, and/or to force a Revision to be created when the spec doesn't otherwise change, a nonce label may be provided in the template metadata. For more details, see: https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions Cloud Run does not currently support referencing a build that is responsible for materializing the container image from source. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTemplate
{
    /// <summary>Optional metadata for this Revision, including labels and annotations. Name will be generated by the Configuration. To set minimum instances for this revision, use the "autoscaling.knative.dev/minScale" annotation key. To set maximum instances for this revision, use the "autoscaling.knative.dev/maxScale" annotation key. To set Cloud SQL connections for the revision, use the "run.googleapis.com/cloudsql-instances" annotation key. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServiceSpecForProviderTemplateMetadata? Metadata { get; set; }

    /// <summary>RevisionSpec holds the desired state of the Revision (from the client). Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceSpecForProviderTemplateSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderTraffic
{
    /// <summary>LatestRevision may be optionally provided to indicate that the latest ready Revision of the Configuration should be used for this traffic target. When provided LatestRevision must be true if RevisionName is empty; it must be false when RevisionName is non-empty.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProvider
{
    /// <summary>If set to true, the revision name (template.metadata.name) will be omitted and autogenerated by Cloud Run. This cannot be set to true while template.metadata.name is also set. (For legacy support, if template.metadata.name is unset in state while this field is set to false, the revision name will still autogenerate.)</summary>
    [JsonPropertyName("autogenerateRevisionName")]
    public bool? AutogenerateRevisionName { get; set; }

    /// <summary>The location of the cloud run instance. eg us-central1</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Metadata associated with this Service, including name, namespace, labels, and annotations. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServiceSpecForProviderMetadata? Metadata { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>template holds the latest specification for the Revision to be stamped out. The template references the container image, and may also include labels and annotations that should be attached to the Revision. To correlate a Revision, and/or to force a Revision to be created when the spec doesn't otherwise change, a nonce label may be provided in the template metadata. For more details, see: https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions Cloud Run does not currently support referencing a build that is responsible for materializing the container image from source. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public V1beta1ServiceSpecForProviderTemplate? Template { get; set; }

    /// <summary>Traffic specifies how to distribute traffic over a collection of Knative Revisions and Configurations Structure is documented below.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1ServiceSpecForProviderTraffic>? Traffic { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderMetadataNamespaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderMetadataNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderMetadataNamespaceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderMetadataNamespaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderMetadataNamespaceSelector
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
    public V1beta1ServiceSpecInitProviderMetadataNamespaceSelectorPolicy? Policy { get; set; }
}

/// <summary>Metadata associated with this Service, including name, namespace, labels, and annotations. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation keys to configure features on a Revision template:</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number. It will default to the resource's project.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceRef")]
    public V1beta1ServiceSpecInitProviderMetadataNamespaceRef? NamespaceRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta1ServiceSpecInitProviderMetadataNamespaceSelector? NamespaceSelector { get; set; }
}

/// <summary>Optional metadata for this Revision, including labels and annotations. Name will be generated by the Configuration. To set minimum instances for this revision, use the "autoscaling.knative.dev/minScale" annotation key. To set maximum instances for this revision, use the "autoscaling.knative.dev/maxScale" annotation key. To set Cloud SQL connections for the revision, use the "run.googleapis.com/cloudsql-instances" annotation key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation keys to configure features on a Revision template:</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number. It will default to the resource's project.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector
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
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Selects a key (version) of a secret in Secret Manager. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific version.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef? NameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector? NameSelector { get; set; }
}

/// <summary>Source for the environment variable's value. Only supports secret_key_ref. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFrom
{
    /// <summary>Selects a key (version) of a secret in Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Only supports secret_key_ref. Structure is documented below.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The ConfigMap to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFrom
{
    /// <summary>The ConfigMap to select from. Structure is documented below.</summary>
    [JsonPropertyName("configMapRef")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is 240.</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid port number (between 1 and 65535). Defaults to "8080".</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be "TCP". Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Compute Resources required by this container. Used to set values such as max memory Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>TcpSocket specifies an action involving a TCP port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is 240.</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TcpSocket specifies an action involving a TCP port. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Structure is documented below.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Docker image name. This is most often a reference to a container located in the container registry, such as gcr.io/cloudrun/hello</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Structure is documented below.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of open ports in the container. Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resources required by this container. Used to set values such as max memory Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. Structure is documented below.</summary>
    [JsonPropertyName("startupProbe")]
    public V1beta1ServiceSpecInitProviderTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Only supports SecretVolumeSources. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>A filesystem specified by the Container Storage Interface (CSI). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesCsi
{
    /// <summary>Unique name representing the type of file system to be created. Cloud Run supports the following values:</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Driver-specific attributes. The following options are supported for available drivers:</summary>
    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. The default is "" which means to use the node's default medium. Must be an empty string (default) or Memory.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field's values are of the 'Quantity' k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>A filesystem backed by a Network File System share. This filesystem requires the run.googleapis.com/execution-environment annotation to be unset or set to "gen2" Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesNfs
{
    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>IP address or hostname of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretItems
{
    /// <summary>A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific version.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Mode bits to use on this file, must be a value between 0000 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelector
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
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The secret's value will be presented as the content of a file whose name is defined in the item path. If no items are defined, the name of the file is the secret_name. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecret
{
    /// <summary>Mode bits to use on created files by default. Must be a value between 0000 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret_name. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a key and a path. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project. If the secret is in another project, you must define an alias. An alias definition has the form: {alias}:projects/{project-id|project-number}/secrets/{secret-name}. If multiple alias definitions are needed, they must be separated by commas. The alias definitions must be set on the run.googleapis.com/secrets annotation.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameRef")]
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRef? SecretNameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameSelector")]
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelector? SecretNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpecVolumes
{
    /// <summary>A filesystem specified by the Container Storage Interface (CSI). Structure is documented below.</summary>
    [JsonPropertyName("csi")]
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesCsi? Csi { get; set; }

    /// <summary>Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs). Structure is documented below.</summary>
    [JsonPropertyName("emptyDir")]
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A filesystem backed by a Network File System share. This filesystem requires the run.googleapis.com/execution-environment annotation to be unset or set to "gen2" Structure is documented below.</summary>
    [JsonPropertyName("nfs")]
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesNfs? Nfs { get; set; }

    /// <summary>The secret's value will be presented as the content of a file whose name is defined in the item path. If no items are defined, the name of the file is the secret_name. Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public V1beta1ServiceSpecInitProviderTemplateSpecVolumesSecret? Secret { get; set; }
}

/// <summary>RevisionSpec holds the desired state of the Revision (from the client). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplateSpec
{
    /// <summary>ContainerConcurrency specifies the maximum allowed in-flight (concurrent) requests per container of the Revision. If not specified or 0, defaults to 80 when requested CPU &gt;= 1 and defaults to 1 when requested CPU &lt; 1.</summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>Containers defines the unit of execution for this Revision. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecContainers>? Containers { get; set; }

    /// <summary>Node Selector describes the hardware requirements of the resources. Use the following node selector keys to configure features on a Revision:</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>Volume represents a named volume in a container. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1ServiceSpecInitProviderTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>template holds the latest specification for the Revision to be stamped out. The template references the container image, and may also include labels and annotations that should be attached to the Revision. To correlate a Revision, and/or to force a Revision to be created when the spec doesn't otherwise change, a nonce label may be provided in the template metadata. For more details, see: https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions Cloud Run does not currently support referencing a build that is responsible for materializing the container image from source. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTemplate
{
    /// <summary>Optional metadata for this Revision, including labels and annotations. Name will be generated by the Configuration. To set minimum instances for this revision, use the "autoscaling.knative.dev/minScale" annotation key. To set maximum instances for this revision, use the "autoscaling.knative.dev/maxScale" annotation key. To set Cloud SQL connections for the revision, use the "run.googleapis.com/cloudsql-instances" annotation key. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServiceSpecInitProviderTemplateMetadata? Metadata { get; set; }

    /// <summary>RevisionSpec holds the desired state of the Revision (from the client). Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceSpecInitProviderTemplateSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderTraffic
{
    /// <summary>LatestRevision may be optionally provided to indicate that the latest ready Revision of the Configuration should be used for this traffic target. When provided LatestRevision must be true if RevisionName is empty; it must be false when RevisionName is non-empty.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProvider
{
    /// <summary>If set to true, the revision name (template.metadata.name) will be omitted and autogenerated by Cloud Run. This cannot be set to true while template.metadata.name is also set. (For legacy support, if template.metadata.name is unset in state while this field is set to false, the revision name will still autogenerate.)</summary>
    [JsonPropertyName("autogenerateRevisionName")]
    public bool? AutogenerateRevisionName { get; set; }

    /// <summary>Metadata associated with this Service, including name, namespace, labels, and annotations. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServiceSpecInitProviderMetadata? Metadata { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>template holds the latest specification for the Revision to be stamped out. The template references the container image, and may also include labels and annotations that should be attached to the Revision. To correlate a Revision, and/or to force a Revision to be created when the spec doesn't otherwise change, a nonce label may be provided in the template metadata. For more details, see: https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions Cloud Run does not currently support referencing a build that is responsible for materializing the container image from source. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public V1beta1ServiceSpecInitProviderTemplate? Template { get; set; }

    /// <summary>Traffic specifies how to distribute traffic over a collection of Knative Revisions and Configurations Structure is documented below.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1ServiceSpecInitProviderTraffic>? Traffic { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecProviderConfigRef
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
public partial class V1beta1ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ServiceSpec defines the desired state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Metadata associated with this Service, including name, namespace, labels, and annotations. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation keys to configure features on a Revision template:</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>(Output) A sequence number representing a specific generation of the desired state.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number. It will default to the resource's project.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>(Output) An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. They may only be valid for a particular resource or set of resources.</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>(Output) SelfLink is a URL representing this object.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>(Output) The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>(Output) UID is a unique id generated by the server on successful creation of a resource and is not allowed to change on PUT operations.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderStatusConditions
{
    /// <summary>(Output) Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>(Output) One-word CamelCase reason for the condition's current status.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>The current status of the Service. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>(Output) Type of domain mapping condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderStatusTraffic
{
    /// <summary>LatestRevision may be optionally provided to indicate that the latest ready Revision of the Configuration should be used for this traffic target. When provided LatestRevision must be true if RevisionName is empty; it must be false when RevisionName is non-empty.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>(Output) URL displays the URL for accessing tagged traffic targets. URL is displayed in status, and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname, but may not contain anything else (e.g. basic auth, url path, etc.)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderStatus
{
    /// <summary>(Output) Array of observed Service Conditions, indicating the current ready state of the service. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceStatusAtProviderStatusConditions>? Conditions { get; set; }

    /// <summary>(Output) From ConfigurationStatus. LatestCreatedRevisionName is the last revision that was created from this Service's Configuration. It might not be ready yet, for that use LatestReadyRevisionName.</summary>
    [JsonPropertyName("latestCreatedRevisionName")]
    public string? LatestCreatedRevisionName { get; set; }

    /// <summary>(Output) From ConfigurationStatus. LatestReadyRevisionName holds the name of the latest Revision stamped out from this Service's Configuration that has had its "Ready" condition become "True".</summary>
    [JsonPropertyName("latestReadyRevisionName")]
    public string? LatestReadyRevisionName { get; set; }

    /// <summary>(Output) ObservedGeneration is the 'Generation' of the Route that was last processed by the controller. Clients polling for completed reconciliation should poll until observedGeneration = metadata.generation and the Ready condition's status is True or False.</summary>
    [JsonPropertyName("observedGeneration")]
    public double? ObservedGeneration { get; set; }

    /// <summary>(Output) Traffic specifies how to distribute traffic over a collection of Knative Revisions and Configurations Structure is documented below.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1ServiceStatusAtProviderStatusTraffic>? Traffic { get; set; }

    /// <summary>(Output) From RouteStatus. URL holds the url that will distribute traffic over the provided traffic targets. It generally has the form https://{route-hash}-{project-hash}-{cluster-level-suffix}.a.run.app</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Optional metadata for this Revision, including labels and annotations. Name will be generated by the Configuration. To set minimum instances for this revision, use the "autoscaling.knative.dev/minScale" annotation key. To set maximum instances for this revision, use the "autoscaling.knative.dev/maxScale" annotation key. To set Cloud SQL connections for the revision, use the "run.googleapis.com/cloudsql-instances" annotation key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation keys to configure features on a Revision template:</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>(Output) A sequence number representing a specific generation of the desired state.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number. It will default to the resource's project.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>(Output) An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. They may only be valid for a particular resource or set of resources.</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>(Output) SelfLink is a URL representing this object.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>(Output) UID is a unique id generated by the server on successful creation of a resource and is not allowed to change on PUT operations.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Selects a key (version) of a secret in Secret Manager. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific version.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Source for the environment variable's value. Only supports secret_key_ref. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvValueFrom
{
    /// <summary>Selects a key (version) of a secret in Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnv
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Only supports secret_key_ref. Structure is documented below.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The ConfigMap to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The Secret to select from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFrom
{
    /// <summary>The ConfigMap to select from. Structure is documented below.</summary>
    [JsonPropertyName("configMapRef")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from. Structure is documented below.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is 240.</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid port number (between 1 and 65535). Defaults to "8080".</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be "TCP". Defaults to "TCP".</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Compute Resources required by this container. Used to set values such as max memory Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. The values of the map is string form of the 'quantity' k8s type: https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>Custom headers to set in the request. HTTP allows repeated headers. Structure is documented below.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>TcpSocket specifies an action involving a TCP port. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>Port number to access on the container. Number must be in the range 1 to 65535. If not specified, defaults to the same value as container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbe
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>GRPC specifies an action involving a GRPC port. Structure is documented below.</summary>
    [JsonPropertyName("grpc")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>HttpGet specifies the http request to perform. Structure is documented below.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is 240.</summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>TcpSocket specifies an action involving a TCP port. Structure is documented below.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainersVolumeMounts
{
    /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecContainers
{
    /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>List of environment variables to set in the container. Structure is documented below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>List of sources to populate environment variables in the container. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Structure is documented below.</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>Docker image name. This is most often a reference to a container located in the container registry, such as gcr.io/cloudrun/hello</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Structure is documented below.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of open ports in the container. Structure is documented below.</summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resources required by this container. Used to set values such as max memory Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails. Structure is documented below.</summary>
    [JsonPropertyName("startupProbe")]
    public V1beta1ServiceStatusAtProviderTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container's filesystem. Only supports SecretVolumeSources. Structure is documented below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>A filesystem specified by the Container Storage Interface (CSI). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecVolumesCsi
{
    /// <summary>Unique name representing the type of file system to be created. Cloud Run supports the following values:</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Driver-specific attributes. The following options are supported for available drivers:</summary>
    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. The default is "" which means to use the node's default medium. Must be an empty string (default) or Memory.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field's values are of the 'Quantity' k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>A filesystem backed by a Network File System share. This filesystem requires the run.googleapis.com/execution-environment annotation to be unset or set to "gen2" Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecVolumesNfs
{
    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>IP address or hostname of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecVolumesSecretItems
{
    /// <summary>A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific version.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Mode bits to use on this file, must be a value between 0000 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>The secret's value will be presented as the content of a file whose name is defined in the item path. If no items are defined, the name of the file is the secret_name. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecVolumesSecret
{
    /// <summary>Mode bits to use on created files by default. Must be a value between 0000 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret_name. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a key and a path. Structure is documented below.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project. If the secret is in another project, you must define an alias. An alias definition has the form: {alias}:projects/{project-id|project-number}/secrets/{secret-name}. If multiple alias definitions are needed, they must be separated by commas. The alias definitions must be set on the run.googleapis.com/secrets annotation.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpecVolumes
{
    /// <summary>A filesystem specified by the Container Storage Interface (CSI). Structure is documented below.</summary>
    [JsonPropertyName("csi")]
    public V1beta1ServiceStatusAtProviderTemplateSpecVolumesCsi? Csi { get; set; }

    /// <summary>Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs). Structure is documented below.</summary>
    [JsonPropertyName("emptyDir")]
    public V1beta1ServiceStatusAtProviderTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A filesystem backed by a Network File System share. This filesystem requires the run.googleapis.com/execution-environment annotation to be unset or set to "gen2" Structure is documented below.</summary>
    [JsonPropertyName("nfs")]
    public V1beta1ServiceStatusAtProviderTemplateSpecVolumesNfs? Nfs { get; set; }

    /// <summary>The secret's value will be presented as the content of a file whose name is defined in the item path. If no items are defined, the name of the file is the secret_name. Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public V1beta1ServiceStatusAtProviderTemplateSpecVolumesSecret? Secret { get; set; }
}

/// <summary>RevisionSpec holds the desired state of the Revision (from the client). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplateSpec
{
    /// <summary>ContainerConcurrency specifies the maximum allowed in-flight (concurrent) requests per container of the Revision. If not specified or 0, defaults to 80 when requested CPU &gt;= 1 and defaults to 1 when requested CPU &lt; 1.</summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>Containers defines the unit of execution for this Revision. Structure is documented below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecContainers>? Containers { get; set; }

    /// <summary>Node Selector describes the hardware requirements of the resources. Use the following node selector keys to configure features on a Revision:</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project's default service account.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>(Output, Deprecated) ServingState holds a value describing the state the resources are in for this Revision. It is expected that the system will manipulate this based on routability and load.</summary>
    [JsonPropertyName("servingState")]
    public string? ServingState { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than periodSeconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>Volume represents a named volume in a container. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1ServiceStatusAtProviderTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>template holds the latest specification for the Revision to be stamped out. The template references the container image, and may also include labels and annotations that should be attached to the Revision. To correlate a Revision, and/or to force a Revision to be created when the spec doesn't otherwise change, a nonce label may be provided in the template metadata. For more details, see: https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions Cloud Run does not currently support referencing a build that is responsible for materializing the container image from source. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTemplate
{
    /// <summary>Optional metadata for this Revision, including labels and annotations. Name will be generated by the Configuration. To set minimum instances for this revision, use the "autoscaling.knative.dev/minScale" annotation key. To set maximum instances for this revision, use the "autoscaling.knative.dev/maxScale" annotation key. To set Cloud SQL connections for the revision, use the "run.googleapis.com/cloudsql-instances" annotation key. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServiceStatusAtProviderTemplateMetadata? Metadata { get; set; }

    /// <summary>RevisionSpec holds the desired state of the Revision (from the client). Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceStatusAtProviderTemplateSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderTraffic
{
    /// <summary>LatestRevision may be optionally provided to indicate that the latest ready Revision of the Configuration should be used for this traffic target. When provided LatestRevision must be true if RevisionName is empty; it must be false when RevisionName is non-empty.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>(Output) URL displays the URL for accessing tagged traffic targets. URL is displayed in status, and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname, but may not contain anything else (e.g. basic auth, url path, etc.)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProvider
{
    /// <summary>If set to true, the revision name (template.metadata.name) will be omitted and autogenerated by Cloud Run. This cannot be set to true while template.metadata.name is also set. (For legacy support, if template.metadata.name is unset in state while this field is set to false, the revision name will still autogenerate.)</summary>
    [JsonPropertyName("autogenerateRevisionName")]
    public bool? AutogenerateRevisionName { get; set; }

    /// <summary>an identifier for the resource with format locations/{{location}}/namespaces/{{project}}/services/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location of the cloud run instance. eg us-central1</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Metadata associated with this Service, including name, namespace, labels, and annotations. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServiceStatusAtProviderMetadata? Metadata { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The current status of the Service. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public IList<V1beta1ServiceStatusAtProviderStatus>? Status { get; set; }

    /// <summary>template holds the latest specification for the Revision to be stamped out. The template references the container image, and may also include labels and annotations that should be attached to the Revision. To correlate a Revision, and/or to force a Revision to be created when the spec doesn't otherwise change, a nonce label may be provided in the template metadata. For more details, see: https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions Cloud Run does not currently support referencing a build that is responsible for materializing the container image from source. Structure is documented below.</summary>
    [JsonPropertyName("template")]
    public V1beta1ServiceStatusAtProviderTemplate? Template { get; set; }

    /// <summary>Traffic specifies how to distribute traffic over a collection of Knative Revisions and Configurations Structure is documented below.</summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta1ServiceStatusAtProviderTraffic>? Traffic { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusConditions
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

/// <summary>ServiceStatus defines the observed state of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Service is the Schema for the Services API. A Cloud Run service has a unique endpoint and autoscales containers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceSpec>, IStatus<V1beta1ServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Service";
    public const string KubeGroup = "cloudrun.gcp.m.upbound.io";
    public const string KubePluralName = "services";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceSpec defines the desired state of Service</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceSpec Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceStatus? Status { get; set; }
}