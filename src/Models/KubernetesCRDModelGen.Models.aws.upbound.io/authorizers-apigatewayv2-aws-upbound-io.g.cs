using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.aws.upbound.io;
/// <summary>Authorizer is the Schema for the Authorizers API. Manages an Amazon API Gateway Version 2 authorizer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AuthorizerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Authorizer>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AuthorizerList";
    public const string KubeGroup = "apigatewayv2.aws.upbound.io";
    public const string KubePluralName = "authorizers";
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
    public IList<V1beta1Authorizer> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecForProviderApiIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderApiIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecForProviderApiIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderAuthorizerUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate authorizerUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderAuthorizerUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecForProviderAuthorizerUriRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderAuthorizerUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate authorizerUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderAuthorizerUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecForProviderAuthorizerUriSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProviderJwtConfiguration
{
    /// <summary>List of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least one entry in this list.</summary>
    [JsonPropertyName("audience")]
    public IList<string>? Audience { get; set; }

    /// <summary>Base domain of the identity provider that issues JSON Web Tokens, such as the endpoint attribute of the aws_cognito_user_pool resource.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecForProvider
{
    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1AuthorizerSpecForProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1AuthorizerSpecForProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>Required credentials as an IAM role for API Gateway to invoke the authorizer. Supported only for REQUEST authorizers.</summary>
    [JsonPropertyName("authorizerCredentialsArn")]
    public string? AuthorizerCredentialsArn { get; set; }

    /// <summary>Format of the payload sent to an HTTP API Lambda authorizer. Required for HTTP API Lambda authorizers. Valid values: 1.0, 2.0.</summary>
    [JsonPropertyName("authorizerPayloadFormatVersion")]
    public string? AuthorizerPayloadFormatVersion { get; set; }

    /// <summary>Time to live (TTL) for cached authorizer results, in seconds. If it equals 0, authorization caching is disabled. If it is greater than 0, API Gateway caches authorizer responses. The maximum value is 3600, or 1 hour. Defaults to 300. Supported only for HTTP API Lambda authorizers.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>Authorizer type. Valid values: JWT, REQUEST. Specify REQUEST for a Lambda function using incoming request parameters. For HTTP APIs, specify JWT to use JSON Web Tokens.</summary>
    [JsonPropertyName("authorizerType")]
    public string? AuthorizerType { get; set; }

    /// <summary>Authorizer's Uniform Resource Identifier (URI). For REQUEST authorizers this must be a well-formed Lambda function URI, such as the invoke_arn attribute of the aws_lambda_function resource. Supported only for REQUEST authorizers. Must be between 1 and 2048 characters in length.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Reference to a Function in lambda to populate authorizerUri.</summary>
    [JsonPropertyName("authorizerUriRef")]
    public V1beta1AuthorizerSpecForProviderAuthorizerUriRef? AuthorizerUriRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate authorizerUri.</summary>
    [JsonPropertyName("authorizerUriSelector")]
    public V1beta1AuthorizerSpecForProviderAuthorizerUriSelector? AuthorizerUriSelector { get; set; }

    /// <summary>Whether a Lambda authorizer returns a response in a simple format. If enabled, the Lambda authorizer can return a boolean value instead of an IAM policy. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("enableSimpleResponses")]
    public bool? EnableSimpleResponses { get; set; }

    /// <summary>Identity sources for which authorization is requested. For REQUEST authorizers the value is a list of one or more mapping expressions of the specified request parameters. For JWT authorizers the single entry specifies where to extract the JSON Web Token (JWT) from inbound requests.</summary>
    [JsonPropertyName("identitySources")]
    public IList<string>? IdentitySources { get; set; }

    /// <summary>Configuration of a JWT authorizer. Required for the JWT authorizer type. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("jwtConfiguration")]
    public IList<V1beta1AuthorizerSpecForProviderJwtConfiguration>? JwtConfiguration { get; set; }

    /// <summary>Name of the authorizer. Must be between 1 and 128 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderApiIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderApiIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecInitProviderApiIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderApiIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderApiIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecInitProviderApiIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderAuthorizerUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate authorizerUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderAuthorizerUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecInitProviderAuthorizerUriRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderAuthorizerUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate authorizerUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderAuthorizerUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecInitProviderAuthorizerUriSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProviderJwtConfiguration
{
    /// <summary>List of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least one entry in this list.</summary>
    [JsonPropertyName("audience")]
    public IList<string>? Audience { get; set; }

    /// <summary>Base domain of the identity provider that issues JSON Web Tokens, such as the endpoint attribute of the aws_cognito_user_pool resource.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecInitProvider
{
    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Reference to a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdRef")]
    public V1beta1AuthorizerSpecInitProviderApiIdRef? ApiIdRef { get; set; }

    /// <summary>Selector for a API in apigatewayv2 to populate apiId.</summary>
    [JsonPropertyName("apiIdSelector")]
    public V1beta1AuthorizerSpecInitProviderApiIdSelector? ApiIdSelector { get; set; }

    /// <summary>Required credentials as an IAM role for API Gateway to invoke the authorizer. Supported only for REQUEST authorizers.</summary>
    [JsonPropertyName("authorizerCredentialsArn")]
    public string? AuthorizerCredentialsArn { get; set; }

    /// <summary>Format of the payload sent to an HTTP API Lambda authorizer. Required for HTTP API Lambda authorizers. Valid values: 1.0, 2.0.</summary>
    [JsonPropertyName("authorizerPayloadFormatVersion")]
    public string? AuthorizerPayloadFormatVersion { get; set; }

    /// <summary>Time to live (TTL) for cached authorizer results, in seconds. If it equals 0, authorization caching is disabled. If it is greater than 0, API Gateway caches authorizer responses. The maximum value is 3600, or 1 hour. Defaults to 300. Supported only for HTTP API Lambda authorizers.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>Authorizer type. Valid values: JWT, REQUEST. Specify REQUEST for a Lambda function using incoming request parameters. For HTTP APIs, specify JWT to use JSON Web Tokens.</summary>
    [JsonPropertyName("authorizerType")]
    public string? AuthorizerType { get; set; }

    /// <summary>Authorizer's Uniform Resource Identifier (URI). For REQUEST authorizers this must be a well-formed Lambda function URI, such as the invoke_arn attribute of the aws_lambda_function resource. Supported only for REQUEST authorizers. Must be between 1 and 2048 characters in length.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Reference to a Function in lambda to populate authorizerUri.</summary>
    [JsonPropertyName("authorizerUriRef")]
    public V1beta1AuthorizerSpecInitProviderAuthorizerUriRef? AuthorizerUriRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate authorizerUri.</summary>
    [JsonPropertyName("authorizerUriSelector")]
    public V1beta1AuthorizerSpecInitProviderAuthorizerUriSelector? AuthorizerUriSelector { get; set; }

    /// <summary>Whether a Lambda authorizer returns a response in a simple format. If enabled, the Lambda authorizer can return a boolean value instead of an IAM policy. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("enableSimpleResponses")]
    public bool? EnableSimpleResponses { get; set; }

    /// <summary>Identity sources for which authorization is requested. For REQUEST authorizers the value is a list of one or more mapping expressions of the specified request parameters. For JWT authorizers the single entry specifies where to extract the JSON Web Token (JWT) from inbound requests.</summary>
    [JsonPropertyName("identitySources")]
    public IList<string>? IdentitySources { get; set; }

    /// <summary>Configuration of a JWT authorizer. Required for the JWT authorizer type. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("jwtConfiguration")]
    public IList<V1beta1AuthorizerSpecInitProviderJwtConfiguration>? JwtConfiguration { get; set; }

    /// <summary>Name of the authorizer. Must be between 1 and 128 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecProviderConfigRefPolicy
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
public partial class V1beta1AuthorizerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AuthorizerSpec defines the desired state of Authorizer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AuthorizerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AuthorizerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AuthorizerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AuthorizerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerStatusAtProviderJwtConfiguration
{
    /// <summary>List of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least one entry in this list.</summary>
    [JsonPropertyName("audience")]
    public IList<string>? Audience { get; set; }

    /// <summary>Base domain of the identity provider that issues JSON Web Tokens, such as the endpoint attribute of the aws_cognito_user_pool resource.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerStatusAtProvider
{
    /// <summary>API identifier.</summary>
    [JsonPropertyName("apiId")]
    public string? ApiId { get; set; }

    /// <summary>Required credentials as an IAM role for API Gateway to invoke the authorizer. Supported only for REQUEST authorizers.</summary>
    [JsonPropertyName("authorizerCredentialsArn")]
    public string? AuthorizerCredentialsArn { get; set; }

    /// <summary>Format of the payload sent to an HTTP API Lambda authorizer. Required for HTTP API Lambda authorizers. Valid values: 1.0, 2.0.</summary>
    [JsonPropertyName("authorizerPayloadFormatVersion")]
    public string? AuthorizerPayloadFormatVersion { get; set; }

    /// <summary>Time to live (TTL) for cached authorizer results, in seconds. If it equals 0, authorization caching is disabled. If it is greater than 0, API Gateway caches authorizer responses. The maximum value is 3600, or 1 hour. Defaults to 300. Supported only for HTTP API Lambda authorizers.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>Authorizer type. Valid values: JWT, REQUEST. Specify REQUEST for a Lambda function using incoming request parameters. For HTTP APIs, specify JWT to use JSON Web Tokens.</summary>
    [JsonPropertyName("authorizerType")]
    public string? AuthorizerType { get; set; }

    /// <summary>Authorizer's Uniform Resource Identifier (URI). For REQUEST authorizers this must be a well-formed Lambda function URI, such as the invoke_arn attribute of the aws_lambda_function resource. Supported only for REQUEST authorizers. Must be between 1 and 2048 characters in length.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Whether a Lambda authorizer returns a response in a simple format. If enabled, the Lambda authorizer can return a boolean value instead of an IAM policy. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("enableSimpleResponses")]
    public bool? EnableSimpleResponses { get; set; }

    /// <summary>Authorizer identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity sources for which authorization is requested. For REQUEST authorizers the value is a list of one or more mapping expressions of the specified request parameters. For JWT authorizers the single entry specifies where to extract the JSON Web Token (JWT) from inbound requests.</summary>
    [JsonPropertyName("identitySources")]
    public IList<string>? IdentitySources { get; set; }

    /// <summary>Configuration of a JWT authorizer. Required for the JWT authorizer type. Supported only for HTTP APIs.</summary>
    [JsonPropertyName("jwtConfiguration")]
    public IList<V1beta1AuthorizerStatusAtProviderJwtConfiguration>? JwtConfiguration { get; set; }

    /// <summary>Name of the authorizer. Must be between 1 and 128 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerStatusConditions
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

/// <summary>AuthorizerStatus defines the observed state of Authorizer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AuthorizerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AuthorizerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AuthorizerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Authorizer is the Schema for the Authorizers API. Manages an Amazon API Gateway Version 2 authorizer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Authorizer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AuthorizerSpec>, IStatus<V1beta1AuthorizerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Authorizer";
    public const string KubeGroup = "apigatewayv2.aws.upbound.io";
    public const string KubePluralName = "authorizers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AuthorizerSpec defines the desired state of Authorizer</summary>
    [JsonPropertyName("spec")]
    public V1beta1AuthorizerSpec Spec { get; set; }

    /// <summary>AuthorizerStatus defines the observed state of Authorizer.</summary>
    [JsonPropertyName("status")]
    public V1beta1AuthorizerStatus? Status { get; set; }
}