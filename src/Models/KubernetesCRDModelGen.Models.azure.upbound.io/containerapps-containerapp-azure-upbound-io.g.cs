using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerapp.azure.upbound.io;
/// <summary>ContainerApp is the Schema for the ContainerApps API. Manages a Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerAppList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ContainerApp>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerAppList";
    public const string KubeGroup = "containerapp.azure.upbound.io";
    public const string KubePluralName = "containerapps";
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
    public IList<V1beta1ContainerApp> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderDapr
{
    /// <summary>The Dapr Application Identifier. The Dapr Application Identifier.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The port which the application is listening on. This is the same as the ingress port. The port which the application is listening on. This is the same as the `ingress` port.</summary>
    [JsonPropertyName("appPort")]
    public double? AppPort { get; set; }

    /// <summary>The protocol for the app. Possible values include http and grpc. Defaults to http. The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.</summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderIngressCors
{
    /// <summary>Whether user credentials are allowed in the cross-origin request is enabled. Defaults to false.</summary>
    [JsonPropertyName("allowCredentialsEnabled")]
    public bool? AllowCredentialsEnabled { get; set; }

    /// <summary>Specifies the list of request headers that are permitted in the actual request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Specifies the list of HTTP methods are allowed when accessing the resource in a cross-origin request.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Specifies the list of origins that are allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Specifies the list of headers exposed to the browser in the response to a cross-origin request.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>Specifies the number of seconds that the browser can cache the results of a preflight request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderIngressIpSecurityRestriction
{
    /// <summary>The IP-filter action. Allow or Deny. The action. Allow or Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describe the IP restriction rule that is being sent to the container-app. Describe the IP restriction rule that is being sent to the container-app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The incoming IP address or range of IP addresses (in CIDR notation). The incoming IP address or range of IP addresses (in CIDR notation).</summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. Name for the IP restriction rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderIngressTrafficWeight
{
    /// <summary>The label to apply to the revision as a name prefix for routing traffic. The label to apply to the revision as a name prefix for routing traffic.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>This traffic Weight applies to the latest stable Container Revision. At most only one traffic_weight block can have the latest_revision set to true. This traffic Weight relates to the latest stable Container Revision.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>The percentage of traffic which should be sent this revision. The percentage of traffic to send to this revision.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one. The suffix string to append to the revision. This must be unique for the Container App's lifetime. A default hash created by the service will be used if this value is omitted.</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderIngress
{
    /// <summary>Should this ingress allow insecure connections? Should this ingress allow insecure connections?</summary>
    [JsonPropertyName("allowInsecureConnections")]
    public bool? AllowInsecureConnections { get; set; }

    /// <summary>The client certificate mode for the Ingress. Possible values are require, accept, and ignore. Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1ContainerAppSpecForProviderIngressCors>? Cors { get; set; }

    /// <summary>The exposed port on the container for the Ingress traffic. The exposed port on the container for the Ingress traffic.</summary>
    [JsonPropertyName("exposedPort")]
    public double? ExposedPort { get; set; }

    /// <summary>Are connections to this Ingress from outside the Container App Environment enabled? Defaults to false. Is this an external Ingress.</summary>
    [JsonPropertyName("externalEnabled")]
    public bool? ExternalEnabled { get; set; }

    /// <summary>One or more ip_security_restriction blocks for IP-filtering rules as defined below.</summary>
    [JsonPropertyName("ipSecurityRestriction")]
    public IList<V1beta1ContainerAppSpecForProviderIngressIpSecurityRestriction>? IpSecurityRestriction { get; set; }

    /// <summary>The target port on the container for the Ingress traffic. The target port on the container for the Ingress traffic.</summary>
    [JsonPropertyName("targetPort")]
    public double? TargetPort { get; set; }

    /// <summary>One or more traffic_weight blocks as detailed below.</summary>
    [JsonPropertyName("trafficWeight")]
    public IList<V1beta1ContainerAppSpecForProviderIngressTrafficWeight>? TrafficWeight { get; set; }

    /// <summary>The transport method for the Ingress. Possible values are auto, http, http2 and tcp. Defaults to auto. The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderRegistry
{
    /// <summary>Resource ID for the User Assigned Managed identity to use when pulling from the Container Registry. ID of the System or User Managed Identity used to pull images from the Container Registry</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The name of the Secret Reference containing the password value for this user on the Container Registry, username must also be supplied. The name of the Secret Reference containing the password value for this user on the Container Registry.</summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>The hostname for the Container Registry. The hostname for the Container Registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The username to use for this Container Registry, password_secret_name must also be supplied.. The username to use for this Container Registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerAppSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerAppSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The secret name. The secret name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderSecretNameSecretRef
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

/// <summary>The value for this secret. The value for this secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderSecretValueSecretRef
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
public partial class V1beta1ContainerAppSpecForProviderSecret
{
    /// <summary>The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity. The identity to use for accessing key vault reference.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The ID of a Key Vault secret. This can be a versioned or version-less ID. The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The secret name. The secret name.</summary>
    [JsonPropertyName("nameSecretRef")]
    public V1beta1ContainerAppSpecForProviderSecretNameSecretRef? NameSecretRef { get; set; }

    /// <summary>The value for this secret. The value for this secret.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ContainerAppSpecForProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateAzureQueueScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateAzureQueueScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateAzureQueueScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the length of the queue to trigger scaling actions.</summary>
    [JsonPropertyName("queueLength")]
    public double? QueueLength { get; set; }

    /// <summary>The name of the Azure Queue</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerEnv
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the environment variable for the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the secret that contains the value for this environment variable. The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this secret. The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerLivenessProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerReadinessProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3. The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.</summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerStartupProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerStartupProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainerVolumeMounts
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path in the container at which to mount this volume. The path in the container at which to mount this volume.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The sub path of the volume to be mounted in the container. The sub path of the volume to be mounted in the container.</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateContainer
{
    /// <summary>A list of extra arguments to pass to the container. A list of args to pass to the container.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A command to pass to the container to override the default. This is provided as a list of command line elements without spaces. A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The amount of vCPU to allocate to the container. Possible values include 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, and 2.0. When there's a workload profile specified, there's no such constraint. The amount of vCPU to allocate to the container. Possible values include `0.25`, `0.5`, `0.75`, `1.0`, `1.25`, `1.5`, `1.75`, and `2.0`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.0` / `2.0` or `0.5` / `1.0`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>The image to use to create the container. The image to use to create the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>The amount of memory to allocate to the container. Possible values are 0.5Gi, 1Gi, 1.5Gi, 2Gi, 2.5Gi, 3Gi, 3.5Gi and 4Gi. When there's a workload profile specified, there's no such constraint. The amount of memory to allocate to the container. Possible values include `0.5Gi`, `1.0Gi`, `1.5Gi`, `2.0Gi`, `2.5Gi`, `3.0Gi`, `3.5Gi`, and `4.0Gi`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.25` / `2.5Gi` or `0.75` / `1.5Gi`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateCustomScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateCustomScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateCustomScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The Custom rule type. Possible values include: activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid,solace-event-queue, and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>- A map of string key-value pairs to configure the Custom Scale Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateHttpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateHttpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateHttpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateInitContainerEnv
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the environment variable for the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the secret that contains the value for this environment variable. The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this secret. The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateInitContainerVolumeMounts
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path in the container at which to mount this volume. The path in the container at which to mount this volume.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The sub path of the volume to be mounted in the container. The sub path of the volume to be mounted in the container.</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateInitContainer
{
    /// <summary>A list of extra arguments to pass to the container. A list of args to pass to the container.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A command to pass to the container to override the default. This is provided as a list of command line elements without spaces. A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The amount of vCPU to allocate to the container. Possible values include 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, and 2.0. When there's a workload profile specified, there's no such constraint. The amount of vCPU to allocate to the container. Possible values include `0.25`, `0.5`, `0.75`, `1.0`, `1.25`, `1.5`, `1.75`, and `2.0`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.0` / `2.0` or `0.5` / `1.0`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>The image to use to create the container. The image to use to create the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The amount of memory to allocate to the container. Possible values are 0.5Gi, 1Gi, 1.5Gi, 2Gi, 2.5Gi, 3Gi, 3.5Gi and 4Gi. When there's a workload profile specified, there's no such constraint. The amount of memory to allocate to the container. Possible values include `0.5Gi`, `1.0Gi`, `1.5Gi`, `2.0Gi`, `2.5Gi`, `3.0Gi`, `3.5Gi`, and `4.0Gi`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.25` / `2.5Gi` or `0.75` / `1.5Gi`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateTcpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateTcpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateTcpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplateVolume
{
    /// <summary>Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751. Mount options used while mounting the AzureFile. Must be a comma-separated string.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the AzureFile storage. The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>The type of storage volume. Possible values are AzureFile, EmptyDir and Secret. Defaults to EmptyDir. The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProviderTemplate
{
    /// <summary>One or more azure_queue_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("azureQueueScaleRule")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateAzureQueueScaleRule>? AzureQueueScaleRule { get; set; }

    /// <summary>One or more container blocks as detailed below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateContainer>? Container { get; set; }

    /// <summary>One or more custom_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("customScaleRule")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateCustomScaleRule>? CustomScaleRule { get; set; }

    /// <summary>One or more http_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("httpScaleRule")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateHttpScaleRule>? HttpScaleRule { get; set; }

    /// <summary>The definition of an init container that is part of the group as documented in the init_container block below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>The maximum number of replicas for this container. The maximum number of replicas for this container.</summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>The minimum number of replicas for this container. The minimum number of replicas for this container.</summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one. The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>One or more tcp_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("tcpScaleRule")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateTcpScaleRule>? TcpScaleRule { get; set; }

    /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed. The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>A volume block as detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1ContainerAppSpecForProviderTemplateVolume>? Volume { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecForProvider
{
    /// <summary>The ID of the Container App Environment within which this Container App should exist. Changing this forces a new resource to be created. The ID of the Container App Environment to host this Container App.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdRef")]
    public V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdRef? ContainerAppEnvironmentIdRef { get; set; }

    /// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdSelector")]
    public V1beta1ContainerAppSpecForProviderContainerAppEnvironmentIdSelector? ContainerAppEnvironmentIdSelector { get; set; }

    /// <summary>A dapr block as detailed below.</summary>
    [JsonPropertyName("dapr")]
    public IList<V1beta1ContainerAppSpecForProviderDapr>? Dapr { get; set; }

    /// <summary>An identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ContainerAppSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>An ingress block as detailed below.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1beta1ContainerAppSpecForProviderIngress>? Ingress { get; set; }

    /// <summary>The maximum of inactive revisions allowed for this Container App.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public double? MaxInactiveRevisions { get; set; }

    /// <summary>A registry block as detailed below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta1ContainerAppSpecForProviderRegistry>? Registry { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ContainerAppSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ContainerAppSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The revisions operational mode for the Container App. Possible values include Single and Multiple. In Single mode, a single revision is in operation at any given time. In Multiple mode, more than one revision can be active at a time and can be configured with load distribution via the traffic_weight block in the ingress configuration.</summary>
    [JsonPropertyName("revisionMode")]
    public string? RevisionMode { get; set; }

    /// <summary>One or more secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1ContainerAppSpecForProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the Container App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as detailed below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1ContainerAppSpecForProviderTemplate>? Template { get; set; }

    /// <summary>The name of the Workload Profile in the Container App Environment to place this Container App.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderDapr
{
    /// <summary>The Dapr Application Identifier. The Dapr Application Identifier.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The port which the application is listening on. This is the same as the ingress port. The port which the application is listening on. This is the same as the `ingress` port.</summary>
    [JsonPropertyName("appPort")]
    public double? AppPort { get; set; }

    /// <summary>The protocol for the app. Possible values include http and grpc. Defaults to http. The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.</summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderIngressCors
{
    /// <summary>Whether user credentials are allowed in the cross-origin request is enabled. Defaults to false.</summary>
    [JsonPropertyName("allowCredentialsEnabled")]
    public bool? AllowCredentialsEnabled { get; set; }

    /// <summary>Specifies the list of request headers that are permitted in the actual request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Specifies the list of HTTP methods are allowed when accessing the resource in a cross-origin request.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Specifies the list of origins that are allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Specifies the list of headers exposed to the browser in the response to a cross-origin request.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>Specifies the number of seconds that the browser can cache the results of a preflight request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderIngressIpSecurityRestriction
{
    /// <summary>The IP-filter action. Allow or Deny. The action. Allow or Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describe the IP restriction rule that is being sent to the container-app. Describe the IP restriction rule that is being sent to the container-app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The incoming IP address or range of IP addresses (in CIDR notation). The incoming IP address or range of IP addresses (in CIDR notation).</summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. Name for the IP restriction rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderIngressTrafficWeight
{
    /// <summary>The label to apply to the revision as a name prefix for routing traffic. The label to apply to the revision as a name prefix for routing traffic.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>This traffic Weight applies to the latest stable Container Revision. At most only one traffic_weight block can have the latest_revision set to true. This traffic Weight relates to the latest stable Container Revision.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>The percentage of traffic which should be sent this revision. The percentage of traffic to send to this revision.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one. The suffix string to append to the revision. This must be unique for the Container App's lifetime. A default hash created by the service will be used if this value is omitted.</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderIngress
{
    /// <summary>Should this ingress allow insecure connections? Should this ingress allow insecure connections?</summary>
    [JsonPropertyName("allowInsecureConnections")]
    public bool? AllowInsecureConnections { get; set; }

    /// <summary>The client certificate mode for the Ingress. Possible values are require, accept, and ignore. Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1ContainerAppSpecInitProviderIngressCors>? Cors { get; set; }

    /// <summary>The exposed port on the container for the Ingress traffic. The exposed port on the container for the Ingress traffic.</summary>
    [JsonPropertyName("exposedPort")]
    public double? ExposedPort { get; set; }

    /// <summary>Are connections to this Ingress from outside the Container App Environment enabled? Defaults to false. Is this an external Ingress.</summary>
    [JsonPropertyName("externalEnabled")]
    public bool? ExternalEnabled { get; set; }

    /// <summary>One or more ip_security_restriction blocks for IP-filtering rules as defined below.</summary>
    [JsonPropertyName("ipSecurityRestriction")]
    public IList<V1beta1ContainerAppSpecInitProviderIngressIpSecurityRestriction>? IpSecurityRestriction { get; set; }

    /// <summary>The target port on the container for the Ingress traffic. The target port on the container for the Ingress traffic.</summary>
    [JsonPropertyName("targetPort")]
    public double? TargetPort { get; set; }

    /// <summary>One or more traffic_weight blocks as detailed below.</summary>
    [JsonPropertyName("trafficWeight")]
    public IList<V1beta1ContainerAppSpecInitProviderIngressTrafficWeight>? TrafficWeight { get; set; }

    /// <summary>The transport method for the Ingress. Possible values are auto, http, http2 and tcp. Defaults to auto. The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderRegistry
{
    /// <summary>Resource ID for the User Assigned Managed identity to use when pulling from the Container Registry. ID of the System or User Managed Identity used to pull images from the Container Registry</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The name of the Secret Reference containing the password value for this user on the Container Registry, username must also be supplied. The name of the Secret Reference containing the password value for this user on the Container Registry.</summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>The hostname for the Container Registry. The hostname for the Container Registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The username to use for this Container Registry, password_secret_name must also be supplied.. The username to use for this Container Registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The secret name. The secret name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderSecretNameSecretRef
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

/// <summary>The value for this secret. The value for this secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderSecretValueSecretRef
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
public partial class V1beta1ContainerAppSpecInitProviderSecret
{
    /// <summary>The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity. The identity to use for accessing key vault reference.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The ID of a Key Vault secret. This can be a versioned or version-less ID. The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The secret name. The secret name.</summary>
    [JsonPropertyName("nameSecretRef")]
    public V1beta1ContainerAppSpecInitProviderSecretNameSecretRef NameSecretRef { get; set; }

    /// <summary>The value for this secret. The value for this secret.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ContainerAppSpecInitProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateAzureQueueScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateAzureQueueScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateAzureQueueScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the length of the queue to trigger scaling actions.</summary>
    [JsonPropertyName("queueLength")]
    public double? QueueLength { get; set; }

    /// <summary>The name of the Azure Queue</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerEnv
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the environment variable for the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the secret that contains the value for this environment variable. The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this secret. The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerLivenessProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerReadinessProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3. The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.</summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerStartupProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerStartupProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainerVolumeMounts
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path in the container at which to mount this volume. The path in the container at which to mount this volume.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The sub path of the volume to be mounted in the container. The sub path of the volume to be mounted in the container.</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateContainer
{
    /// <summary>A list of extra arguments to pass to the container. A list of args to pass to the container.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A command to pass to the container to override the default. This is provided as a list of command line elements without spaces. A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The amount of vCPU to allocate to the container. Possible values include 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, and 2.0. When there's a workload profile specified, there's no such constraint. The amount of vCPU to allocate to the container. Possible values include `0.25`, `0.5`, `0.75`, `1.0`, `1.25`, `1.5`, `1.75`, and `2.0`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.0` / `2.0` or `0.5` / `1.0`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>The image to use to create the container. The image to use to create the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>The amount of memory to allocate to the container. Possible values are 0.5Gi, 1Gi, 1.5Gi, 2Gi, 2.5Gi, 3Gi, 3.5Gi and 4Gi. When there's a workload profile specified, there's no such constraint. The amount of memory to allocate to the container. Possible values include `0.5Gi`, `1.0Gi`, `1.5Gi`, `2.0Gi`, `2.5Gi`, `3.0Gi`, `3.5Gi`, and `4.0Gi`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.25` / `2.5Gi` or `0.75` / `1.5Gi`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateCustomScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateCustomScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateCustomScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The Custom rule type. Possible values include: activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid,solace-event-queue, and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>- A map of string key-value pairs to configure the Custom Scale Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateHttpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateHttpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateHttpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateInitContainerEnv
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the environment variable for the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the secret that contains the value for this environment variable. The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this secret. The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateInitContainerVolumeMounts
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path in the container at which to mount this volume. The path in the container at which to mount this volume.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The sub path of the volume to be mounted in the container. The sub path of the volume to be mounted in the container.</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateInitContainer
{
    /// <summary>A list of extra arguments to pass to the container. A list of args to pass to the container.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A command to pass to the container to override the default. This is provided as a list of command line elements without spaces. A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The amount of vCPU to allocate to the container. Possible values include 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, and 2.0. When there's a workload profile specified, there's no such constraint. The amount of vCPU to allocate to the container. Possible values include `0.25`, `0.5`, `0.75`, `1.0`, `1.25`, `1.5`, `1.75`, and `2.0`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.0` / `2.0` or `0.5` / `1.0`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>The image to use to create the container. The image to use to create the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The amount of memory to allocate to the container. Possible values are 0.5Gi, 1Gi, 1.5Gi, 2Gi, 2.5Gi, 3Gi, 3.5Gi and 4Gi. When there's a workload profile specified, there's no such constraint. The amount of memory to allocate to the container. Possible values include `0.5Gi`, `1.0Gi`, `1.5Gi`, `2.0Gi`, `2.5Gi`, `3.0Gi`, `3.5Gi`, and `4.0Gi`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.25` / `2.5Gi` or `0.75` / `1.5Gi`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateTcpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateTcpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateTcpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplateVolume
{
    /// <summary>Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751. Mount options used while mounting the AzureFile. Must be a comma-separated string.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the AzureFile storage. The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>The type of storage volume. Possible values are AzureFile, EmptyDir and Secret. Defaults to EmptyDir. The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProviderTemplate
{
    /// <summary>One or more azure_queue_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("azureQueueScaleRule")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateAzureQueueScaleRule>? AzureQueueScaleRule { get; set; }

    /// <summary>One or more container blocks as detailed below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateContainer>? Container { get; set; }

    /// <summary>One or more custom_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("customScaleRule")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateCustomScaleRule>? CustomScaleRule { get; set; }

    /// <summary>One or more http_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("httpScaleRule")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateHttpScaleRule>? HttpScaleRule { get; set; }

    /// <summary>The definition of an init container that is part of the group as documented in the init_container block below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>The maximum number of replicas for this container. The maximum number of replicas for this container.</summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>The minimum number of replicas for this container. The minimum number of replicas for this container.</summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one. The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>One or more tcp_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("tcpScaleRule")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateTcpScaleRule>? TcpScaleRule { get; set; }

    /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed. The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>A volume block as detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplateVolume>? Volume { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecInitProvider
{
    /// <summary>The ID of the Container App Environment within which this Container App should exist. Changing this forces a new resource to be created. The ID of the Container App Environment to host this Container App.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdRef")]
    public V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdRef? ContainerAppEnvironmentIdRef { get; set; }

    /// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdSelector")]
    public V1beta1ContainerAppSpecInitProviderContainerAppEnvironmentIdSelector? ContainerAppEnvironmentIdSelector { get; set; }

    /// <summary>A dapr block as detailed below.</summary>
    [JsonPropertyName("dapr")]
    public IList<V1beta1ContainerAppSpecInitProviderDapr>? Dapr { get; set; }

    /// <summary>An identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ContainerAppSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>An ingress block as detailed below.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1beta1ContainerAppSpecInitProviderIngress>? Ingress { get; set; }

    /// <summary>The maximum of inactive revisions allowed for this Container App.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public double? MaxInactiveRevisions { get; set; }

    /// <summary>A registry block as detailed below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta1ContainerAppSpecInitProviderRegistry>? Registry { get; set; }

    /// <summary>The revisions operational mode for the Container App. Possible values include Single and Multiple. In Single mode, a single revision is in operation at any given time. In Multiple mode, more than one revision can be active at a time and can be configured with load distribution via the traffic_weight block in the ingress configuration.</summary>
    [JsonPropertyName("revisionMode")]
    public string? RevisionMode { get; set; }

    /// <summary>One or more secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1ContainerAppSpecInitProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the Container App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as detailed below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1ContainerAppSpecInitProviderTemplate>? Template { get; set; }

    /// <summary>The name of the Workload Profile in the Container App Environment to place this Container App.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecProviderConfigRefPolicy
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
public partial class V1beta1ContainerAppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerAppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ContainerAppSpec defines the desired state of ContainerApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ContainerAppSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ContainerAppSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ContainerAppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ContainerAppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderDapr
{
    /// <summary>The Dapr Application Identifier. The Dapr Application Identifier.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The port which the application is listening on. This is the same as the ingress port. The port which the application is listening on. This is the same as the `ingress` port.</summary>
    [JsonPropertyName("appPort")]
    public double? AppPort { get; set; }

    /// <summary>The protocol for the app. Possible values include http and grpc. Defaults to http. The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.</summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Container App.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Container App.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderIngressCors
{
    /// <summary>Whether user credentials are allowed in the cross-origin request is enabled. Defaults to false.</summary>
    [JsonPropertyName("allowCredentialsEnabled")]
    public bool? AllowCredentialsEnabled { get; set; }

    /// <summary>Specifies the list of request headers that are permitted in the actual request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Specifies the list of HTTP methods are allowed when accessing the resource in a cross-origin request.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Specifies the list of origins that are allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Specifies the list of headers exposed to the browser in the response to a cross-origin request.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>Specifies the number of seconds that the browser can cache the results of a preflight request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderIngressCustomDomain
{
    /// <summary>The Binding type.</summary>
    [JsonPropertyName("certificateBindingType")]
    public string? CertificateBindingType { get; set; }

    /// <summary>The ID of the Container App Environment Certificate.</summary>
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; set; }

    /// <summary>The hostname of the Certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderIngressIpSecurityRestriction
{
    /// <summary>The IP-filter action. Allow or Deny. The action. Allow or Deny.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describe the IP restriction rule that is being sent to the container-app. Describe the IP restriction rule that is being sent to the container-app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The incoming IP address or range of IP addresses (in CIDR notation). The incoming IP address or range of IP addresses (in CIDR notation).</summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. Name for the IP restriction rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderIngressTrafficWeight
{
    /// <summary>The label to apply to the revision as a name prefix for routing traffic. The label to apply to the revision as a name prefix for routing traffic.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>This traffic Weight applies to the latest stable Container Revision. At most only one traffic_weight block can have the latest_revision set to true. This traffic Weight relates to the latest stable Container Revision.</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>The percentage of traffic which should be sent this revision. The percentage of traffic to send to this revision.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one. The suffix string to append to the revision. This must be unique for the Container App's lifetime. A default hash created by the service will be used if this value is omitted.</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderIngress
{
    /// <summary>Should this ingress allow insecure connections? Should this ingress allow insecure connections?</summary>
    [JsonPropertyName("allowInsecureConnections")]
    public bool? AllowInsecureConnections { get; set; }

    /// <summary>The client certificate mode for the Ingress. Possible values are require, accept, and ignore. Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.</summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1ContainerAppStatusAtProviderIngressCors>? Cors { get; set; }

    /// <summary>One or more custom_domain block as detailed below.</summary>
    [JsonPropertyName("customDomain")]
    public IList<V1beta1ContainerAppStatusAtProviderIngressCustomDomain>? CustomDomain { get; set; }

    /// <summary>The exposed port on the container for the Ingress traffic. The exposed port on the container for the Ingress traffic.</summary>
    [JsonPropertyName("exposedPort")]
    public double? ExposedPort { get; set; }

    /// <summary>Are connections to this Ingress from outside the Container App Environment enabled? Defaults to false. Is this an external Ingress.</summary>
    [JsonPropertyName("externalEnabled")]
    public bool? ExternalEnabled { get; set; }

    /// <summary>The FQDN of the ingress. The FQDN of the ingress.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>One or more ip_security_restriction blocks for IP-filtering rules as defined below.</summary>
    [JsonPropertyName("ipSecurityRestriction")]
    public IList<V1beta1ContainerAppStatusAtProviderIngressIpSecurityRestriction>? IpSecurityRestriction { get; set; }

    /// <summary>The target port on the container for the Ingress traffic. The target port on the container for the Ingress traffic.</summary>
    [JsonPropertyName("targetPort")]
    public double? TargetPort { get; set; }

    /// <summary>One or more traffic_weight blocks as detailed below.</summary>
    [JsonPropertyName("trafficWeight")]
    public IList<V1beta1ContainerAppStatusAtProviderIngressTrafficWeight>? TrafficWeight { get; set; }

    /// <summary>The transport method for the Ingress. Possible values are auto, http, http2 and tcp. Defaults to auto. The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderRegistry
{
    /// <summary>Resource ID for the User Assigned Managed identity to use when pulling from the Container Registry. ID of the System or User Managed Identity used to pull images from the Container Registry</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The name of the Secret Reference containing the password value for this user on the Container Registry, username must also be supplied. The name of the Secret Reference containing the password value for this user on the Container Registry.</summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>The hostname for the Container Registry. The hostname for the Container Registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>The username to use for this Container Registry, password_secret_name must also be supplied.. The username to use for this Container Registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderSecret
{
    /// <summary>The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity. The identity to use for accessing key vault reference.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>The ID of a Key Vault secret. This can be a versioned or version-less ID. The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateAzureQueueScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateAzureQueueScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateAzureQueueScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the length of the queue to trigger scaling actions.</summary>
    [JsonPropertyName("queueLength")]
    public double? QueueLength { get; set; }

    /// <summary>The name of the Azure Queue</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerEnv
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the environment variable for the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the secret that contains the value for this environment variable. The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this secret. The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerLivenessProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed. The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerReadinessProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3. The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.</summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerStartupProbeHeader
{
    /// <summary>The name of the Volume to be mounted in the container. The HTTP Header Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value for this secret. The HTTP Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerStartupProbe
{
    /// <summary>The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3. The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.</summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes. The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds. The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.</summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10 How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`</summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>The path in the container at which to mount this volume. The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number on which to connect. Possible values are between 1 and 65535. The port number on which to connect. Possible values are between `1` and `65535`.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed. The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1. Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Type of probe. Possible values are TCP, HTTP, and HTTPS. Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainerVolumeMounts
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path in the container at which to mount this volume. The path in the container at which to mount this volume.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The sub path of the volume to be mounted in the container. The sub path of the volume to be mounted in the container.</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateContainer
{
    /// <summary>A list of extra arguments to pass to the container. A list of args to pass to the container.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A command to pass to the container to override the default. This is provided as a list of command line elements without spaces. A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The amount of vCPU to allocate to the container. Possible values include 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, and 2.0. When there's a workload profile specified, there's no such constraint. The amount of vCPU to allocate to the container. Possible values include `0.25`, `0.5`, `0.75`, `1.0`, `1.25`, `1.5`, `1.75`, and `2.0`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.0` / `2.0` or `0.5` / `1.0`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>The amount of ephemeral storage available to the Container App. The amount of ephemeral storage available to the Container App.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>The image to use to create the container. The image to use to create the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>The amount of memory to allocate to the container. Possible values are 0.5Gi, 1Gi, 1.5Gi, 2Gi, 2.5Gi, 3Gi, 3.5Gi and 4Gi. When there's a workload profile specified, there's no such constraint. The amount of memory to allocate to the container. Possible values include `0.5Gi`, `1.0Gi`, `1.5Gi`, `2.0Gi`, `2.5Gi`, `3.0Gi`, `3.5Gi`, and `4.0Gi`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.25` / `2.5Gi` or `0.75` / `1.5Gi`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateCustomScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateCustomScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateCustomScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The Custom rule type. Possible values include: activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid,solace-event-queue, and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>- A map of string key-value pairs to configure the Custom Scale Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateHttpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateHttpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateHttpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateInitContainerEnv
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the environment variable for the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the secret that contains the value for this environment variable. The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The value for this secret. The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateInitContainerVolumeMounts
{
    /// <summary>The name of the Volume to be mounted in the container. The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path in the container at which to mount this volume. The path in the container at which to mount this volume.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The sub path of the volume to be mounted in the container. The sub path of the volume to be mounted in the container.</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateInitContainer
{
    /// <summary>A list of extra arguments to pass to the container. A list of args to pass to the container.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A command to pass to the container to override the default. This is provided as a list of command line elements without spaces. A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The amount of vCPU to allocate to the container. Possible values include 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, and 2.0. When there's a workload profile specified, there's no such constraint. The amount of vCPU to allocate to the container. Possible values include `0.25`, `0.5`, `0.75`, `1.0`, `1.25`, `1.5`, `1.75`, and `2.0`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.0` / `2.0` or `0.5` / `1.0`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>The amount of ephemeral storage available to the Container App. The amount of ephemeral storage available to the Container App.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>The image to use to create the container. The image to use to create the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The amount of memory to allocate to the container. Possible values are 0.5Gi, 1Gi, 1.5Gi, 2Gi, 2.5Gi, 3Gi, 3.5Gi and 4Gi. When there's a workload profile specified, there's no such constraint. The amount of memory to allocate to the container. Possible values include `0.5Gi`, `1.0Gi`, `1.5Gi`, `2.0Gi`, `2.5Gi`, `3.0Gi`, `3.5Gi`, and `4.0Gi`. **NOTE:** `cpu` and `memory` must be specified in `0.25'/'0.5Gi` combination increments. e.g. `1.25` / `2.5Gi` or `0.75` / `1.5Gi`. When there's a workload profile specified, there's no such constraint.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateTcpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateTcpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateTcpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplateVolume
{
    /// <summary>Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751. Mount options used while mounting the AzureFile. Must be a comma-separated string.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>The name of the Volume to be mounted in the container. The name of the volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the AzureFile storage. The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>The type of storage volume. Possible values are AzureFile, EmptyDir and Secret. Defaults to EmptyDir. The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProviderTemplate
{
    /// <summary>One or more azure_queue_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("azureQueueScaleRule")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateAzureQueueScaleRule>? AzureQueueScaleRule { get; set; }

    /// <summary>One or more container blocks as detailed below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateContainer>? Container { get; set; }

    /// <summary>One or more custom_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("customScaleRule")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateCustomScaleRule>? CustomScaleRule { get; set; }

    /// <summary>One or more http_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("httpScaleRule")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateHttpScaleRule>? HttpScaleRule { get; set; }

    /// <summary>The definition of an init container that is part of the group as documented in the init_container block below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>The maximum number of replicas for this container. The maximum number of replicas for this container.</summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>The minimum number of replicas for this container. The minimum number of replicas for this container.</summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one. The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>One or more tcp_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("tcpScaleRule")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateTcpScaleRule>? TcpScaleRule { get; set; }

    /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed. The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>A volume block as detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplateVolume>? Volume { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusAtProvider
{
    /// <summary>The ID of the Container App Environment within which this Container App should exist. Changing this forces a new resource to be created. The ID of the Container App Environment to host this Container App.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>A dapr block as detailed below.</summary>
    [JsonPropertyName("dapr")]
    public IList<V1beta1ContainerAppStatusAtProviderDapr>? Dapr { get; set; }

    /// <summary>The ID of the Container App.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ContainerAppStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>An ingress block as detailed below.</summary>
    [JsonPropertyName("ingress")]
    public IList<V1beta1ContainerAppStatusAtProviderIngress>? Ingress { get; set; }

    /// <summary>The FQDN of the Latest Revision of the Container App. The FQDN of the Latest Revision of the Container App.</summary>
    [JsonPropertyName("latestRevisionFqdn")]
    public string? LatestRevisionFqdn { get; set; }

    /// <summary>The name of the latest Container Revision. The name of the latest Container Revision.</summary>
    [JsonPropertyName("latestRevisionName")]
    public string? LatestRevisionName { get; set; }

    /// <summary>The location this Container App is deployed in. This is the same as the Environment in which it is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum of inactive revisions allowed for this Container App.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public double? MaxInactiveRevisions { get; set; }

    /// <summary>A list of the Public IP Addresses which the Container App uses for outbound network access.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public IList<string>? OutboundIpAddresses { get; set; }

    /// <summary>A registry block as detailed below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta1ContainerAppStatusAtProviderRegistry>? Registry { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The revisions operational mode for the Container App. Possible values include Single and Multiple. In Single mode, a single revision is in operation at any given time. In Multiple mode, more than one revision can be active at a time and can be configured with load distribution via the traffic_weight block in the ingress configuration.</summary>
    [JsonPropertyName("revisionMode")]
    public string? RevisionMode { get; set; }

    /// <summary>One or more secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1ContainerAppStatusAtProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the Container App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as detailed below.</summary>
    [JsonPropertyName("template")]
    public IList<V1beta1ContainerAppStatusAtProviderTemplate>? Template { get; set; }

    /// <summary>The name of the Workload Profile in the Container App Environment to place this Container App.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatusConditions
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

/// <summary>ContainerAppStatus defines the observed state of ContainerApp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerAppStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ContainerAppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerAppStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ContainerApp is the Schema for the ContainerApps API. Manages a Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerAppSpec>, IStatus<V1beta1ContainerAppStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerApp";
    public const string KubeGroup = "containerapp.azure.upbound.io";
    public const string KubePluralName = "containerapps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerAppSpec defines the desired state of ContainerApp</summary>
    [JsonPropertyName("spec")]
    public V1beta1ContainerAppSpec Spec { get; set; }

    /// <summary>ContainerAppStatus defines the observed state of ContainerApp.</summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerAppStatus? Status { get; set; }
}