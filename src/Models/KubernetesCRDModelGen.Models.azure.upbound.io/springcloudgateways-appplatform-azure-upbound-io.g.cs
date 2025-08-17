using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
#nullable enable
/// <summary>SpringCloudGateway is the Schema for the SpringCloudGateways API. Manages a Spring Cloud Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudGateway>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudGatewayList";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudgateways";
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
    public IList<V1beta1SpringCloudGateway> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderApiMetadata
{
    /// <summary>Detailed description of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Location of additional documentation for the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }

    /// <summary>Base URL that API consumers will use to access APIs on the Gateway instance.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Specifies the title describing the context of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Specifies the version of APIs available on this Gateway instance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderClientAuthorization
{
    /// <summary>Specifies the Spring Cloud Certificate IDs of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Specifies whether the client certificate verification is enabled.</summary>
    [JsonPropertyName("verificationEnabled")]
    public bool? VerificationEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderCors
{
    /// <summary>Allowed headers in cross-site requests. The special value * allows actual requests to send any header.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Allowed HTTP methods on cross-site requests. The special value * allows all methods. If not set, GET and HEAD are allowed by default. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Allowed origin patterns to make cross-site requests.</summary>
    [JsonPropertyName("allowedOriginPatterns")]
    public IList<string>? AllowedOriginPatterns { get; set; }

    /// <summary>Allowed origins to make cross-site requests. The special value * allows all domains.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>is user credentials are supported on cross-site requests?</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>HTTP response headers to expose for cross-site requests.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>How long, in seconds, the response from a pre-flight request can be cached by clients.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderLocalResponseCachePerInstance
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderLocalResponseCachePerRoute
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 2Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the sensitive environment variables of the Spring Cloud Gateway as a map of key-value pairs. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderSensitiveEnvironmentVariablesSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user's behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecForProvider
{
    /// <summary>A api_metadata block as defined below.</summary>
    [JsonPropertyName("apiMetadata")]
    public IList<V1beta1SpringCloudGatewaySpecForProviderApiMetadata>? ApiMetadata { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies a list of application performance monitoring types used in the Spring Cloud Gateway. The allowed values are AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringTypes")]
    public IList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>A client_authorization block as defined below.</summary>
    [JsonPropertyName("clientAuthorization")]
    public IList<V1beta1SpringCloudGatewaySpecForProviderClientAuthorization>? ClientAuthorization { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1SpringCloudGatewaySpecForProviderCors>? Cors { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Gateway as a map of key-value pairs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Gateway. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerInstance")]
    public IList<V1beta1SpringCloudGatewaySpecForProviderLocalResponseCachePerInstance>? LocalResponseCachePerInstance { get; set; }

    /// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerRoute")]
    public IList<V1beta1SpringCloudGatewaySpecForProviderLocalResponseCachePerRoute>? LocalResponseCachePerRoute { get; set; }

    /// <summary>Indicates whether the Spring Cloud Gateway exposes endpoint.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public IList<V1beta1SpringCloudGatewaySpecForProviderQuota>? Quota { get; set; }

    /// <summary>Specifies the sensitive environment variables of the Spring Cloud Gateway as a map of key-value pairs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sensitiveEnvironmentVariablesSecretRef")]
    public V1beta1SpringCloudGatewaySpecForProviderSensitiveEnvironmentVariablesSecretRef? SensitiveEnvironmentVariablesSecretRef { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Gateway to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }

    /// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdRef")]
    public V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdRef? SpringCloudServiceIdRef { get; set; }

    /// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdSelector")]
    public V1beta1SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelector? SpringCloudServiceIdSelector { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public IList<V1beta1SpringCloudGatewaySpecForProviderSso>? Sso { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProviderApiMetadata
{
    /// <summary>Detailed description of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Location of additional documentation for the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }

    /// <summary>Base URL that API consumers will use to access APIs on the Gateway instance.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Specifies the title describing the context of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Specifies the version of APIs available on this Gateway instance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProviderClientAuthorization
{
    /// <summary>Specifies the Spring Cloud Certificate IDs of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Specifies whether the client certificate verification is enabled.</summary>
    [JsonPropertyName("verificationEnabled")]
    public bool? VerificationEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProviderCors
{
    /// <summary>Allowed headers in cross-site requests. The special value * allows actual requests to send any header.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Allowed HTTP methods on cross-site requests. The special value * allows all methods. If not set, GET and HEAD are allowed by default. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Allowed origin patterns to make cross-site requests.</summary>
    [JsonPropertyName("allowedOriginPatterns")]
    public IList<string>? AllowedOriginPatterns { get; set; }

    /// <summary>Allowed origins to make cross-site requests. The special value * allows all domains.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>is user credentials are supported on cross-site requests?</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>HTTP response headers to expose for cross-site requests.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>How long, in seconds, the response from a pre-flight request can be cached by clients.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProviderLocalResponseCachePerInstance
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProviderLocalResponseCachePerRoute
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 2Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user's behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecInitProvider
{
    /// <summary>A api_metadata block as defined below.</summary>
    [JsonPropertyName("apiMetadata")]
    public IList<V1beta1SpringCloudGatewaySpecInitProviderApiMetadata>? ApiMetadata { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies a list of application performance monitoring types used in the Spring Cloud Gateway. The allowed values are AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringTypes")]
    public IList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>A client_authorization block as defined below.</summary>
    [JsonPropertyName("clientAuthorization")]
    public IList<V1beta1SpringCloudGatewaySpecInitProviderClientAuthorization>? ClientAuthorization { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1SpringCloudGatewaySpecInitProviderCors>? Cors { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Gateway as a map of key-value pairs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Gateway. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerInstance")]
    public IList<V1beta1SpringCloudGatewaySpecInitProviderLocalResponseCachePerInstance>? LocalResponseCachePerInstance { get; set; }

    /// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerRoute")]
    public IList<V1beta1SpringCloudGatewaySpecInitProviderLocalResponseCachePerRoute>? LocalResponseCachePerRoute { get; set; }

    /// <summary>Indicates whether the Spring Cloud Gateway exposes endpoint.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public IList<V1beta1SpringCloudGatewaySpecInitProviderQuota>? Quota { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public IList<V1beta1SpringCloudGatewaySpecInitProviderSso>? Sso { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpringCloudGatewaySpec defines the desired state of SpringCloudGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewaySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProviderApiMetadata
{
    /// <summary>Detailed description of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Location of additional documentation for the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }

    /// <summary>Base URL that API consumers will use to access APIs on the Gateway instance.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Specifies the title describing the context of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Specifies the version of APIs available on this Gateway instance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProviderClientAuthorization
{
    /// <summary>Specifies the Spring Cloud Certificate IDs of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Specifies whether the client certificate verification is enabled.</summary>
    [JsonPropertyName("verificationEnabled")]
    public bool? VerificationEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProviderCors
{
    /// <summary>Allowed headers in cross-site requests. The special value * allows actual requests to send any header.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Allowed HTTP methods on cross-site requests. The special value * allows all methods. If not set, GET and HEAD are allowed by default. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Allowed origin patterns to make cross-site requests.</summary>
    [JsonPropertyName("allowedOriginPatterns")]
    public IList<string>? AllowedOriginPatterns { get; set; }

    /// <summary>Allowed origins to make cross-site requests. The special value * allows all domains.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>is user credentials are supported on cross-site requests?</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>HTTP response headers to expose for cross-site requests.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>How long, in seconds, the response from a pre-flight request can be cached by clients.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProviderLocalResponseCachePerInstance
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProviderLocalResponseCachePerRoute
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 2Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user's behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusAtProvider
{
    /// <summary>A api_metadata block as defined below.</summary>
    [JsonPropertyName("apiMetadata")]
    public IList<V1beta1SpringCloudGatewayStatusAtProviderApiMetadata>? ApiMetadata { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies a list of application performance monitoring types used in the Spring Cloud Gateway. The allowed values are AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringTypes")]
    public IList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>A client_authorization block as defined below.</summary>
    [JsonPropertyName("clientAuthorization")]
    public IList<V1beta1SpringCloudGatewayStatusAtProviderClientAuthorization>? ClientAuthorization { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1SpringCloudGatewayStatusAtProviderCors>? Cors { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Gateway as a map of key-value pairs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Gateway. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerInstance")]
    public IList<V1beta1SpringCloudGatewayStatusAtProviderLocalResponseCachePerInstance>? LocalResponseCachePerInstance { get; set; }

    /// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerRoute")]
    public IList<V1beta1SpringCloudGatewayStatusAtProviderLocalResponseCachePerRoute>? LocalResponseCachePerRoute { get; set; }

    /// <summary>Indicates whether the Spring Cloud Gateway exposes endpoint.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public IList<V1beta1SpringCloudGatewayStatusAtProviderQuota>? Quota { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Gateway to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public IList<V1beta1SpringCloudGatewayStatusAtProviderSso>? Sso { get; set; }

    /// <summary>URL of the Spring Cloud Gateway, exposed when 'public_network_access_enabled' is true.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatusConditions
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
#nullable disable

#nullable enable
/// <summary>SpringCloudGatewayStatus defines the observed state of SpringCloudGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudGatewayStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SpringCloudGateway is the Schema for the SpringCloudGateways API. Manages a Spring Cloud Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudGatewaySpec>, IStatus<V1beta1SpringCloudGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudGateway";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudgateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudGatewaySpec defines the desired state of SpringCloudGateway</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudGatewaySpec Spec { get; set; }

    /// <summary>SpringCloudGatewayStatus defines the observed state of SpringCloudGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudGatewayStatus? Status { get; set; }
}
#nullable disable
