using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.aws.m.upbound.io;
/// <summary>Cross-origin resource sharing (CORS) configuration. Applicable for HTTP APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APISpecForProviderCorsConfiguration
{
    /// <summary>Whether credentials are included in the CORS request.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Set of allowed HTTP headers.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Set of allowed HTTP methods.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Set of allowed origins.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>Set of exposed HTTP headers.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Number of seconds that the browser should cache preflight request results.</summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APISpecForProvider
{
    /// <summary>An API key selection expression. Valid values: $context.authorizer.usageIdentifierKey, $request.header.x-api-key. Defaults to $request.header.x-api-key. Applicable for WebSocket APIs.</summary>
    [JsonPropertyName("apiKeySelectionExpression")]
    public string? ApiKeySelectionExpression { get; set; }

    /// <summary>An OpenAPI specification that defines the set of routes and integrations to create as part of the HTTP APIs. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Cross-origin resource sharing (CORS) configuration. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("corsConfiguration")]
    public V1beta1APISpecForProviderCorsConfiguration? CorsConfiguration { get; set; }

    /// <summary>Part of quick create. Specifies any credentials required for the integration. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("credentialsArn")]
    public string? CredentialsArn { get; set; }

    /// <summary>Description of the API. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether clients can invoke the API by using the default execute-api endpoint. By default, clients can invoke the API with the default {api_id}.execute-api.{region}.amazonaws.com endpoint. To require that clients use a custom domain name to invoke the API, disable the default endpoint.</summary>
    [JsonPropertyName("disableExecuteApiEndpoint")]
    public bool? DisableExecuteApiEndpoint { get; set; }

    /// <summary>Whether warnings should return an error while API Gateway is creating or updating the resource using an OpenAPI specification. Defaults to false. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("failOnWarnings")]
    public bool? FailOnWarnings { get; set; }

    /// <summary>The IP address types that can invoke the API. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke your API, or use dualstack to allow both IPv4 and IPv6 addresses to invoke your API. Defaults to ipv4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Name of the API. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>API protocol. Valid values: HTTP, WEBSOCKET.</summary>
    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Part of quick create. Specifies any route key. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("routeKey")]
    public string? RouteKey { get; set; }

    /// <summary>The route selection expression for the API. Defaults to $request.method $request.path.</summary>
    [JsonPropertyName("routeSelectionExpression")]
    public string? RouteSelectionExpression { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Part of quick create. Quick create produces an API with an integration, a default catch-all route, and a default stage which is configured to automatically deploy changes. For HTTP integrations, specify a fully qualified URL. For Lambda integrations, specify a function ARN. The type of the integration will be HTTP_PROXY or AWS_PROXY, respectively. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Version identifier for the API. Must be between 1 and 64 characters in length.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Cross-origin resource sharing (CORS) configuration. Applicable for HTTP APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APISpecInitProviderCorsConfiguration
{
    /// <summary>Whether credentials are included in the CORS request.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Set of allowed HTTP headers.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Set of allowed HTTP methods.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Set of allowed origins.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>Set of exposed HTTP headers.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Number of seconds that the browser should cache preflight request results.</summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APISpecInitProvider
{
    /// <summary>An API key selection expression. Valid values: $context.authorizer.usageIdentifierKey, $request.header.x-api-key. Defaults to $request.header.x-api-key. Applicable for WebSocket APIs.</summary>
    [JsonPropertyName("apiKeySelectionExpression")]
    public string? ApiKeySelectionExpression { get; set; }

    /// <summary>An OpenAPI specification that defines the set of routes and integrations to create as part of the HTTP APIs. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Cross-origin resource sharing (CORS) configuration. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("corsConfiguration")]
    public V1beta1APISpecInitProviderCorsConfiguration? CorsConfiguration { get; set; }

    /// <summary>Part of quick create. Specifies any credentials required for the integration. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("credentialsArn")]
    public string? CredentialsArn { get; set; }

    /// <summary>Description of the API. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether clients can invoke the API by using the default execute-api endpoint. By default, clients can invoke the API with the default {api_id}.execute-api.{region}.amazonaws.com endpoint. To require that clients use a custom domain name to invoke the API, disable the default endpoint.</summary>
    [JsonPropertyName("disableExecuteApiEndpoint")]
    public bool? DisableExecuteApiEndpoint { get; set; }

    /// <summary>Whether warnings should return an error while API Gateway is creating or updating the resource using an OpenAPI specification. Defaults to false. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("failOnWarnings")]
    public bool? FailOnWarnings { get; set; }

    /// <summary>The IP address types that can invoke the API. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke your API, or use dualstack to allow both IPv4 and IPv6 addresses to invoke your API. Defaults to ipv4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Name of the API. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>API protocol. Valid values: HTTP, WEBSOCKET.</summary>
    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }

    /// <summary>Part of quick create. Specifies any route key. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("routeKey")]
    public string? RouteKey { get; set; }

    /// <summary>The route selection expression for the API. Defaults to $request.method $request.path.</summary>
    [JsonPropertyName("routeSelectionExpression")]
    public string? RouteSelectionExpression { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Part of quick create. Quick create produces an API with an integration, a default catch-all route, and a default stage which is configured to automatically deploy changes. For HTTP integrations, specify a fully qualified URL. For Lambda integrations, specify a function ARN. The type of the integration will be HTTP_PROXY or AWS_PROXY, respectively. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Version identifier for the API. Must be between 1 and 64 characters in length.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APISpecProviderConfigRef
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
public partial class V1beta1APISpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>APISpec defines the desired state of API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APISpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1APISpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1APISpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1APISpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1APISpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Cross-origin resource sharing (CORS) configuration. Applicable for HTTP APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIStatusAtProviderCorsConfiguration
{
    /// <summary>Whether credentials are included in the CORS request.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Set of allowed HTTP headers.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Set of allowed HTTP methods.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>Set of allowed origins.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>Set of exposed HTTP headers.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Number of seconds that the browser should cache preflight request results.</summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIStatusAtProvider
{
    /// <summary>URI of the API, of the form https://{api-id}.execute-api.{region}.amazonaws.com for HTTP APIs and wss://{api-id}.execute-api.{region}.amazonaws.com for WebSocket APIs.</summary>
    [JsonPropertyName("apiEndpoint")]
    public string? ApiEndpoint { get; set; }

    /// <summary>An API key selection expression. Valid values: $context.authorizer.usageIdentifierKey, $request.header.x-api-key. Defaults to $request.header.x-api-key. Applicable for WebSocket APIs.</summary>
    [JsonPropertyName("apiKeySelectionExpression")]
    public string? ApiKeySelectionExpression { get; set; }

    /// <summary>ARN of the API.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>An OpenAPI specification that defines the set of routes and integrations to create as part of the HTTP APIs. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Cross-origin resource sharing (CORS) configuration. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("corsConfiguration")]
    public V1beta1APIStatusAtProviderCorsConfiguration? CorsConfiguration { get; set; }

    /// <summary>Part of quick create. Specifies any credentials required for the integration. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("credentialsArn")]
    public string? CredentialsArn { get; set; }

    /// <summary>Description of the API. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether clients can invoke the API by using the default execute-api endpoint. By default, clients can invoke the API with the default {api_id}.execute-api.{region}.amazonaws.com endpoint. To require that clients use a custom domain name to invoke the API, disable the default endpoint.</summary>
    [JsonPropertyName("disableExecuteApiEndpoint")]
    public bool? DisableExecuteApiEndpoint { get; set; }

    /// <summary>ARN prefix to be used in an aws_lambda_permission's source_arn attribute or in an aws_iam_policy to authorize access to the @connections API. See the Amazon API Gateway Developer Guide for details.</summary>
    [JsonPropertyName("executionArn")]
    public string? ExecutionArn { get; set; }

    /// <summary>Whether warnings should return an error while API Gateway is creating or updating the resource using an OpenAPI specification. Defaults to false. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("failOnWarnings")]
    public bool? FailOnWarnings { get; set; }

    /// <summary>API identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IP address types that can invoke the API. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke your API, or use dualstack to allow both IPv4 and IPv6 addresses to invoke your API. Defaults to ipv4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Name of the API. Must be less than or equal to 128 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>API protocol. Valid values: HTTP, WEBSOCKET.</summary>
    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Part of quick create. Specifies any route key. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("routeKey")]
    public string? RouteKey { get; set; }

    /// <summary>The route selection expression for the API. Defaults to $request.method $request.path.</summary>
    [JsonPropertyName("routeSelectionExpression")]
    public string? RouteSelectionExpression { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Part of quick create. Quick create produces an API with an integration, a default catch-all route, and a default stage which is configured to automatically deploy changes. For HTTP integrations, specify a fully qualified URL. For Lambda integrations, specify a function ARN. The type of the integration will be HTTP_PROXY or AWS_PROXY, respectively. Applicable for HTTP APIs.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Version identifier for the API. Must be between 1 and 64 characters in length.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIStatusConditions
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

/// <summary>APIStatus defines the observed state of API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1APIStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1APIStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>API is the Schema for the APIs API. Manages an Amazon API Gateway Version 2 API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1API : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1APISpec>, IStatus<V1beta1APIStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "API";
    public const string KubeGroup = "apigatewayv2.aws.m.upbound.io";
    public const string KubePluralName = "apis";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APISpec defines the desired state of API</summary>
    [JsonPropertyName("spec")]
    public V1beta1APISpec Spec { get; set; }

    /// <summary>APIStatus defines the observed state of API.</summary>
    [JsonPropertyName("status")]
    public V1beta1APIStatus? Status { get; set; }
}

/// <summary>API is the Schema for the APIs API. Manages an Amazon API Gateway Version 2 API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1APIList : IKubernetesObject<V1ListMeta>, IItems<V1beta1API>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "APIList";
    public const string KubeGroup = "apigatewayv2.aws.m.upbound.io";
    public const string KubePluralName = "apis";
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
    public IList<V1beta1API> Items { get; set; }
}