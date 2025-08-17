using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigateway.aws.m.upbound.io;
#nullable enable
/// <summary>MethodSettings is the Schema for the MethodSettingss API. Manages API Gateway Stage Method Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MethodSettingsList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MethodSettings>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MethodSettingsList";
    public const string KubeGroup = "apigateway.aws.m.upbound.io";
    public const string KubePluralName = "methodsettings";
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
    public IList<V1beta1MethodSettings> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderRestApiIdRefPolicy
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
/// <summary>Reference to a RestAPI in apigateway to populate restApiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderRestApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MethodSettingsSpecForProviderRestApiIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderRestApiIdSelectorPolicy
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
/// <summary>Selector for a RestAPI in apigateway to populate restApiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderRestApiIdSelector
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
    public V1beta1MethodSettingsSpecForProviderRestApiIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings block, see below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderSettings
{
    /// <summary>Whether the cached responses are encrypted.</summary>
    [JsonPropertyName("cacheDataEncrypted")]
    public bool? CacheDataEncrypted { get; set; }

    /// <summary>Time to live (TTL), in seconds, for cached responses. The higher the TTL, the longer the response will be cached.</summary>
    [JsonPropertyName("cacheTtlInSeconds")]
    public double? CacheTtlInSeconds { get; set; }

    /// <summary>Whether responses should be cached and returned for requests. A cache cluster must be enabled on the stage for responses to be cached.</summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>Whether data trace logging is enabled for this method, which effects the log entries pushed to Amazon CloudWatch Logs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Logging level for this method, which effects the log entries pushed to Amazon CloudWatch Logs. The available levels are OFF, ERROR, and INFO.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Whether Amazon CloudWatch metrics are enabled for this method.</summary>
    [JsonPropertyName("metricsEnabled")]
    public bool? MetricsEnabled { get; set; }

    /// <summary>Whether authorization is required for a cache invalidation request.</summary>
    [JsonPropertyName("requireAuthorizationForCacheControl")]
    public bool? RequireAuthorizationForCacheControl { get; set; }

    /// <summary>Throttling burst limit. Default: -1 (throttling disabled).</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit. Default: -1 (throttling disabled).</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }

    /// <summary>How to handle unauthorized requests for cache invalidation. The available values are FAIL_WITH_403, SUCCEED_WITH_RESPONSE_HEADER, SUCCEED_WITHOUT_RESPONSE_HEADER.</summary>
    [JsonPropertyName("unauthorizedCacheControlHeaderStrategy")]
    public string? UnauthorizedCacheControlHeaderStrategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderStageNameRefPolicy
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
/// <summary>Reference to a Stage in apigateway to populate stageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderStageNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MethodSettingsSpecForProviderStageNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderStageNameSelectorPolicy
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
/// <summary>Selector for a Stage in apigateway to populate stageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProviderStageNameSelector
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
    public V1beta1MethodSettingsSpecForProviderStageNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecForProvider
{
    /// <summary>Method path defined as {resource_path}/{http_method} for an individual method override, or */* for overriding all methods in the stage. Ensure to trim any leading forward slashes in the path (e.g., trimprefix(aws_api_gateway_resource.example.path, "/")).</summary>
    [JsonPropertyName("methodPath")]
    public string? MethodPath { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ID of the REST API</summary>
    [JsonPropertyName("restApiId")]
    public string? RestApiId { get; set; }

    /// <summary>Reference to a RestAPI in apigateway to populate restApiId.</summary>
    [JsonPropertyName("restApiIdRef")]
    public V1beta1MethodSettingsSpecForProviderRestApiIdRef? RestApiIdRef { get; set; }

    /// <summary>Selector for a RestAPI in apigateway to populate restApiId.</summary>
    [JsonPropertyName("restApiIdSelector")]
    public V1beta1MethodSettingsSpecForProviderRestApiIdSelector? RestApiIdSelector { get; set; }

    /// <summary>Settings block, see below.</summary>
    [JsonPropertyName("settings")]
    public V1beta1MethodSettingsSpecForProviderSettings? Settings { get; set; }

    /// <summary>Name of the stage</summary>
    [JsonPropertyName("stageName")]
    public string? StageName { get; set; }

    /// <summary>Reference to a Stage in apigateway to populate stageName.</summary>
    [JsonPropertyName("stageNameRef")]
    public V1beta1MethodSettingsSpecForProviderStageNameRef? StageNameRef { get; set; }

    /// <summary>Selector for a Stage in apigateway to populate stageName.</summary>
    [JsonPropertyName("stageNameSelector")]
    public V1beta1MethodSettingsSpecForProviderStageNameSelector? StageNameSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderRestApiIdRefPolicy
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
/// <summary>Reference to a RestAPI in apigateway to populate restApiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderRestApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MethodSettingsSpecInitProviderRestApiIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderRestApiIdSelectorPolicy
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
/// <summary>Selector for a RestAPI in apigateway to populate restApiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderRestApiIdSelector
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
    public V1beta1MethodSettingsSpecInitProviderRestApiIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings block, see below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderSettings
{
    /// <summary>Whether the cached responses are encrypted.</summary>
    [JsonPropertyName("cacheDataEncrypted")]
    public bool? CacheDataEncrypted { get; set; }

    /// <summary>Time to live (TTL), in seconds, for cached responses. The higher the TTL, the longer the response will be cached.</summary>
    [JsonPropertyName("cacheTtlInSeconds")]
    public double? CacheTtlInSeconds { get; set; }

    /// <summary>Whether responses should be cached and returned for requests. A cache cluster must be enabled on the stage for responses to be cached.</summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>Whether data trace logging is enabled for this method, which effects the log entries pushed to Amazon CloudWatch Logs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Logging level for this method, which effects the log entries pushed to Amazon CloudWatch Logs. The available levels are OFF, ERROR, and INFO.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Whether Amazon CloudWatch metrics are enabled for this method.</summary>
    [JsonPropertyName("metricsEnabled")]
    public bool? MetricsEnabled { get; set; }

    /// <summary>Whether authorization is required for a cache invalidation request.</summary>
    [JsonPropertyName("requireAuthorizationForCacheControl")]
    public bool? RequireAuthorizationForCacheControl { get; set; }

    /// <summary>Throttling burst limit. Default: -1 (throttling disabled).</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit. Default: -1 (throttling disabled).</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }

    /// <summary>How to handle unauthorized requests for cache invalidation. The available values are FAIL_WITH_403, SUCCEED_WITH_RESPONSE_HEADER, SUCCEED_WITHOUT_RESPONSE_HEADER.</summary>
    [JsonPropertyName("unauthorizedCacheControlHeaderStrategy")]
    public string? UnauthorizedCacheControlHeaderStrategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderStageNameRefPolicy
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
/// <summary>Reference to a Stage in apigateway to populate stageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderStageNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MethodSettingsSpecInitProviderStageNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderStageNameSelectorPolicy
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
/// <summary>Selector for a Stage in apigateway to populate stageName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProviderStageNameSelector
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
    public V1beta1MethodSettingsSpecInitProviderStageNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecInitProvider
{
    /// <summary>Method path defined as {resource_path}/{http_method} for an individual method override, or */* for overriding all methods in the stage. Ensure to trim any leading forward slashes in the path (e.g., trimprefix(aws_api_gateway_resource.example.path, "/")).</summary>
    [JsonPropertyName("methodPath")]
    public string? MethodPath { get; set; }

    /// <summary>ID of the REST API</summary>
    [JsonPropertyName("restApiId")]
    public string? RestApiId { get; set; }

    /// <summary>Reference to a RestAPI in apigateway to populate restApiId.</summary>
    [JsonPropertyName("restApiIdRef")]
    public V1beta1MethodSettingsSpecInitProviderRestApiIdRef? RestApiIdRef { get; set; }

    /// <summary>Selector for a RestAPI in apigateway to populate restApiId.</summary>
    [JsonPropertyName("restApiIdSelector")]
    public V1beta1MethodSettingsSpecInitProviderRestApiIdSelector? RestApiIdSelector { get; set; }

    /// <summary>Settings block, see below.</summary>
    [JsonPropertyName("settings")]
    public V1beta1MethodSettingsSpecInitProviderSettings? Settings { get; set; }

    /// <summary>Name of the stage</summary>
    [JsonPropertyName("stageName")]
    public string? StageName { get; set; }

    /// <summary>Reference to a Stage in apigateway to populate stageName.</summary>
    [JsonPropertyName("stageNameRef")]
    public V1beta1MethodSettingsSpecInitProviderStageNameRef? StageNameRef { get; set; }

    /// <summary>Selector for a Stage in apigateway to populate stageName.</summary>
    [JsonPropertyName("stageNameSelector")]
    public V1beta1MethodSettingsSpecInitProviderStageNameSelector? StageNameSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MethodSettingsSpec defines the desired state of MethodSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MethodSettingsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MethodSettingsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MethodSettingsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MethodSettingsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings block, see below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsStatusAtProviderSettings
{
    /// <summary>Whether the cached responses are encrypted.</summary>
    [JsonPropertyName("cacheDataEncrypted")]
    public bool? CacheDataEncrypted { get; set; }

    /// <summary>Time to live (TTL), in seconds, for cached responses. The higher the TTL, the longer the response will be cached.</summary>
    [JsonPropertyName("cacheTtlInSeconds")]
    public double? CacheTtlInSeconds { get; set; }

    /// <summary>Whether responses should be cached and returned for requests. A cache cluster must be enabled on the stage for responses to be cached.</summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>Whether data trace logging is enabled for this method, which effects the log entries pushed to Amazon CloudWatch Logs.</summary>
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    /// <summary>Logging level for this method, which effects the log entries pushed to Amazon CloudWatch Logs. The available levels are OFF, ERROR, and INFO.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    /// <summary>Whether Amazon CloudWatch metrics are enabled for this method.</summary>
    [JsonPropertyName("metricsEnabled")]
    public bool? MetricsEnabled { get; set; }

    /// <summary>Whether authorization is required for a cache invalidation request.</summary>
    [JsonPropertyName("requireAuthorizationForCacheControl")]
    public bool? RequireAuthorizationForCacheControl { get; set; }

    /// <summary>Throttling burst limit. Default: -1 (throttling disabled).</summary>
    [JsonPropertyName("throttlingBurstLimit")]
    public double? ThrottlingBurstLimit { get; set; }

    /// <summary>Throttling rate limit. Default: -1 (throttling disabled).</summary>
    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }

    /// <summary>How to handle unauthorized requests for cache invalidation. The available values are FAIL_WITH_403, SUCCEED_WITH_RESPONSE_HEADER, SUCCEED_WITHOUT_RESPONSE_HEADER.</summary>
    [JsonPropertyName("unauthorizedCacheControlHeaderStrategy")]
    public string? UnauthorizedCacheControlHeaderStrategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Method path defined as {resource_path}/{http_method} for an individual method override, or */* for overriding all methods in the stage. Ensure to trim any leading forward slashes in the path (e.g., trimprefix(aws_api_gateway_resource.example.path, "/")).</summary>
    [JsonPropertyName("methodPath")]
    public string? MethodPath { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ID of the REST API</summary>
    [JsonPropertyName("restApiId")]
    public string? RestApiId { get; set; }

    /// <summary>Settings block, see below.</summary>
    [JsonPropertyName("settings")]
    public V1beta1MethodSettingsStatusAtProviderSettings? Settings { get; set; }

    /// <summary>Name of the stage</summary>
    [JsonPropertyName("stageName")]
    public string? StageName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsStatusConditions
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
/// <summary>MethodSettingsStatus defines the observed state of MethodSettings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MethodSettingsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MethodSettingsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MethodSettingsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MethodSettings is the Schema for the MethodSettingss API. Manages API Gateway Stage Method Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MethodSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MethodSettingsSpec>, IStatus<V1beta1MethodSettingsStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MethodSettings";
    public const string KubeGroup = "apigateway.aws.m.upbound.io";
    public const string KubePluralName = "methodsettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MethodSettingsSpec defines the desired state of MethodSettings</summary>
    [JsonPropertyName("spec")]
    public V1beta1MethodSettingsSpec Spec { get; set; }

    /// <summary>MethodSettingsStatus defines the observed state of MethodSettings.</summary>
    [JsonPropertyName("status")]
    public V1beta1MethodSettingsStatus? Status { get; set; }
}
#nullable disable
