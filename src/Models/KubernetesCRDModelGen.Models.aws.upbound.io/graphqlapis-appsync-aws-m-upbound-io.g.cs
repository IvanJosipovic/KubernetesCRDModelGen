using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appsync.aws.m.upbound.io;
/// <summary>GraphQLAPI is the Schema for the GraphQLAPIs API. Provides an AppSync GraphQL API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GraphQLAPIList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GraphQLAPI>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GraphQLAPIList";
    public const string KubeGroup = "appsync.aws.m.upbound.io";
    public const string KubePluralName = "graphqlapis";
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
    public IList<V1beta1GraphQLAPI> Items { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProvider
{
    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig { get; set; }
}

/// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderEnhancedMetricsConfig
{
    /// <summary>How data source metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_DATA_SOURCE_METRICS, PER_DATA_SOURCE_METRICS</summary>
    [JsonPropertyName("dataSourceLevelMetricsBehavior")]
    public string? DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>How operation metrics will be emitted to CloudWatch. Valid values: ENABLED, DISABLED</summary>
    [JsonPropertyName("operationLevelMetricsConfig")]
    public string? OperationLevelMetricsConfig { get; set; }

    /// <summary>How resolver metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_RESOLVER_METRICS, PER_RESOLVER_METRICS</summary>
    [JsonPropertyName("resolverLevelMetricsBehavior")]
    public string? ResolverLevelMetricsBehavior { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelector
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
    public V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderLogConfig
{
    /// <summary>Amazon Resource Name of the service role that AWS AppSync will assume to publish to Amazon CloudWatch logs in your account.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArn")]
    public string? CloudwatchLogsRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnRef")]
    public V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnRef? CloudwatchLogsRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnSelector")]
    public V1beta1GraphQLAPISpecForProviderLogConfigCloudwatchLogsRoleArnSelector? CloudwatchLogsRoleArnSelector { get; set; }

    /// <summary>Set to TRUE to exclude sections that contain information such as headers, context, and evaluated mapping templates, regardless of logging  level. Valid values: true, false. Default value: false</summary>
    [JsonPropertyName("excludeVerboseContent")]
    public bool? ExcludeVerboseContent { get; set; }

    /// <summary>Field logging level. Valid values: ALL, ERROR, NONE.</summary>
    [JsonPropertyName("fieldLogLevel")]
    public string? FieldLogLevel { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelector
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
    public V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelector
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
    public V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Action that you want your GraphQL API to take when a request that uses Amazon Cognito User Pool authentication doesn't match the Amazon Cognito User Pool configuration. Valid: ALLOW and DENY</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1GraphQLAPISpecForProviderUserPoolConfigUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecForProvider
{
    /// <summary>One or more additional authentication providers for the GraphQL API. See additional_authentication_provider Block for details.</summary>
    [JsonPropertyName("additionalAuthenticationProvider")]
    public IList<V1beta1GraphQLAPISpecForProviderAdditionalAuthenticationProvider>? AdditionalAuthenticationProvider { get; set; }

    /// <summary>API type. Valid values are GRAPHQL or MERGED. A MERGED type requires merged_api_execution_role_arn to be set.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
    [JsonPropertyName("enhancedMetricsConfig")]
    public V1beta1GraphQLAPISpecForProviderEnhancedMetricsConfig? EnhancedMetricsConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to enable (ENABLED) or disable (DISABLED) introspection. If no value is provided, the introspection configuration will be set to ENABLED by default. This field will produce an error if the operation attempts to use the introspection feature while this field is disabled. For more information about introspection, see GraphQL introspection.</summary>
    [JsonPropertyName("introspectionConfig")]
    public string? IntrospectionConfig { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta1GraphQLAPISpecForProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1GraphQLAPISpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>ARN of the execution role when api_type is set to MERGED.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArn")]
    public string? MergedApiExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnRef")]
    public V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnRef? MergedApiExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnSelector")]
    public V1beta1GraphQLAPISpecForProviderMergedApiExecutionRoleArnSelector? MergedApiExecutionRoleArnSelector { get; set; }

    /// <summary>User-supplied name for the GraphQL API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta1GraphQLAPISpecForProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>The maximum depth a query can have in a single request. Depth refers to the amount of nested levels allowed in the body of query. The default value is 0 (or unspecified), which indicates there's no depth limit. If you set a limit, it can be between 1 and 75 nested levels. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("queryDepthLimit")]
    public double? QueryDepthLimit { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The maximum number of resolvers that can be invoked in a single request. The default value is 0 (or unspecified), which will set the limit to 10000. When specified, the limit value can be between 1 and 10000. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("resolverCountLimit")]
    public double? ResolverCountLimit { get; set; }

    /// <summary>Schema definition, in GraphQL schema language format.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta1GraphQLAPISpecForProviderUserPoolConfig? UserPoolConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to public (GLOBAL) or private (PRIVATE). If no value is provided, the visibility will be set to GLOBAL by default. This value cannot be changed once the API has been created.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether tracing with X-ray is enabled. Defaults to false.</summary>
    [JsonPropertyName("xrayEnabled")]
    public bool? XrayEnabled { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProvider
{
    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig { get; set; }
}

/// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderEnhancedMetricsConfig
{
    /// <summary>How data source metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_DATA_SOURCE_METRICS, PER_DATA_SOURCE_METRICS</summary>
    [JsonPropertyName("dataSourceLevelMetricsBehavior")]
    public string? DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>How operation metrics will be emitted to CloudWatch. Valid values: ENABLED, DISABLED</summary>
    [JsonPropertyName("operationLevelMetricsConfig")]
    public string? OperationLevelMetricsConfig { get; set; }

    /// <summary>How resolver metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_RESOLVER_METRICS, PER_RESOLVER_METRICS</summary>
    [JsonPropertyName("resolverLevelMetricsBehavior")]
    public string? ResolverLevelMetricsBehavior { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelector
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
    public V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderLogConfig
{
    /// <summary>Amazon Resource Name of the service role that AWS AppSync will assume to publish to Amazon CloudWatch logs in your account.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArn")]
    public string? CloudwatchLogsRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnRef")]
    public V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnRef? CloudwatchLogsRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate cloudwatchLogsRoleArn.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArnSelector")]
    public V1beta1GraphQLAPISpecInitProviderLogConfigCloudwatchLogsRoleArnSelector? CloudwatchLogsRoleArnSelector { get; set; }

    /// <summary>Set to TRUE to exclude sections that contain information such as headers, context, and evaluated mapping templates, regardless of logging  level. Valid values: true, false. Default value: false</summary>
    [JsonPropertyName("excludeVerboseContent")]
    public bool? ExcludeVerboseContent { get; set; }

    /// <summary>Field logging level. Valid values: ALL, ERROR, NONE.</summary>
    [JsonPropertyName("fieldLogLevel")]
    public string? FieldLogLevel { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelector
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
    public V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelector
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
    public V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Action that you want your GraphQL API to take when a request that uses Amazon Cognito User Pool authentication doesn't match the Amazon Cognito User Pool configuration. Valid: ALLOW and DENY</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1GraphQLAPISpecInitProviderUserPoolConfigUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecInitProvider
{
    /// <summary>One or more additional authentication providers for the GraphQL API. See additional_authentication_provider Block for details.</summary>
    [JsonPropertyName("additionalAuthenticationProvider")]
    public IList<V1beta1GraphQLAPISpecInitProviderAdditionalAuthenticationProvider>? AdditionalAuthenticationProvider { get; set; }

    /// <summary>API type. Valid values are GRAPHQL or MERGED. A MERGED type requires merged_api_execution_role_arn to be set.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
    [JsonPropertyName("enhancedMetricsConfig")]
    public V1beta1GraphQLAPISpecInitProviderEnhancedMetricsConfig? EnhancedMetricsConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to enable (ENABLED) or disable (DISABLED) introspection. If no value is provided, the introspection configuration will be set to ENABLED by default. This field will produce an error if the operation attempts to use the introspection feature while this field is disabled. For more information about introspection, see GraphQL introspection.</summary>
    [JsonPropertyName("introspectionConfig")]
    public string? IntrospectionConfig { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta1GraphQLAPISpecInitProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1GraphQLAPISpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>ARN of the execution role when api_type is set to MERGED.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArn")]
    public string? MergedApiExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnRef")]
    public V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnRef? MergedApiExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate mergedApiExecutionRoleArn.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArnSelector")]
    public V1beta1GraphQLAPISpecInitProviderMergedApiExecutionRoleArnSelector? MergedApiExecutionRoleArnSelector { get; set; }

    /// <summary>User-supplied name for the GraphQL API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta1GraphQLAPISpecInitProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>The maximum depth a query can have in a single request. Depth refers to the amount of nested levels allowed in the body of query. The default value is 0 (or unspecified), which indicates there's no depth limit. If you set a limit, it can be between 1 and 75 nested levels. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("queryDepthLimit")]
    public double? QueryDepthLimit { get; set; }

    /// <summary>The maximum number of resolvers that can be invoked in a single request. The default value is 0 (or unspecified), which will set the limit to 10000. When specified, the limit value can be between 1 and 10000. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("resolverCountLimit")]
    public double? ResolverCountLimit { get; set; }

    /// <summary>Schema definition, in GraphQL schema language format.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta1GraphQLAPISpecInitProviderUserPoolConfig? UserPoolConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to public (GLOBAL) or private (PRIVATE). If no value is provided, the visibility will be set to GLOBAL by default. This value cannot be changed once the API has been created.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether tracing with X-ray is enabled. Defaults to false.</summary>
    [JsonPropertyName("xrayEnabled")]
    public bool? XrayEnabled { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpecProviderConfigRef
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
public partial class V1beta1GraphQLAPISpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>GraphQLAPISpec defines the desired state of GraphQLAPI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPISpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GraphQLAPISpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GraphQLAPISpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GraphQLAPISpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GraphQLAPISpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProvider
{
    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig { get; set; }
}

/// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderEnhancedMetricsConfig
{
    /// <summary>How data source metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_DATA_SOURCE_METRICS, PER_DATA_SOURCE_METRICS</summary>
    [JsonPropertyName("dataSourceLevelMetricsBehavior")]
    public string? DataSourceLevelMetricsBehavior { get; set; }

    /// <summary>How operation metrics will be emitted to CloudWatch. Valid values: ENABLED, DISABLED</summary>
    [JsonPropertyName("operationLevelMetricsConfig")]
    public string? OperationLevelMetricsConfig { get; set; }

    /// <summary>How resolver metrics will be emitted to CloudWatch. Valid values: FULL_REQUEST_RESOLVER_METRICS, PER_RESOLVER_METRICS</summary>
    [JsonPropertyName("resolverLevelMetricsBehavior")]
    public string? ResolverLevelMetricsBehavior { get; set; }
}

/// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderLambdaAuthorizerConfig
{
    /// <summary>Number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The Lambda function can override this by returning a ttlOverride key in its response. A value of 0 disables caching of responses. Minimum value of 0. Maximum value of 3600.</summary>
    [JsonPropertyName("authorizerResultTtlInSeconds")]
    public double? AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>ARN of the Lambda function to be called for authorization. Note: This Lambda function must have a resource-based policy assigned to it, to allow lambda:InvokeFunction from service principal appsync.amazonaws.com.</summary>
    [JsonPropertyName("authorizerUri")]
    public string? AuthorizerUri { get; set; }

    /// <summary>Regular expression for validation of tokens before the Lambda function is called.</summary>
    [JsonPropertyName("identityValidationExpression")]
    public string? IdentityValidationExpression { get; set; }
}

/// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderLogConfig
{
    /// <summary>Amazon Resource Name of the service role that AWS AppSync will assume to publish to Amazon CloudWatch logs in your account.</summary>
    [JsonPropertyName("cloudwatchLogsRoleArn")]
    public string? CloudwatchLogsRoleArn { get; set; }

    /// <summary>Set to TRUE to exclude sections that contain information such as headers, context, and evaluated mapping templates, regardless of logging  level. Valid values: true, false. Default value: false</summary>
    [JsonPropertyName("excludeVerboseContent")]
    public bool? ExcludeVerboseContent { get; set; }

    /// <summary>Field logging level. Valid values: ALL, ERROR, NONE.</summary>
    [JsonPropertyName("fieldLogLevel")]
    public string? FieldLogLevel { get; set; }
}

/// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderOpenidConnectConfig
{
    /// <summary>Number of milliseconds a token is valid after being authenticated.</summary>
    [JsonPropertyName("authTtl")]
    public double? AuthTtl { get; set; }

    /// <summary>Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Number of milliseconds a token is valid after being issued to a user.</summary>
    [JsonPropertyName("iatTtl")]
    public double? IatTtl { get; set; }

    /// <summary>Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }
}

/// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProviderUserPoolConfig
{
    /// <summary>Regular expression for validating the incoming Amazon Cognito User Pool app client ID.</summary>
    [JsonPropertyName("appIdClientRegex")]
    public string? AppIdClientRegex { get; set; }

    /// <summary>AWS region in which the user pool was created.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>Action that you want your GraphQL API to take when a request that uses Amazon Cognito User Pool authentication doesn't match the Amazon Cognito User Pool configuration. Valid: ALLOW and DENY</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>User pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusAtProvider
{
    /// <summary>One or more additional authentication providers for the GraphQL API. See additional_authentication_provider Block for details.</summary>
    [JsonPropertyName("additionalAuthenticationProvider")]
    public IList<V1beta1GraphQLAPIStatusAtProviderAdditionalAuthenticationProvider>? AdditionalAuthenticationProvider { get; set; }

    /// <summary>API type. Valid values are GRAPHQL or MERGED. A MERGED type requires merged_api_execution_role_arn to be set.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>ARN</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Authentication type. Valid values: API_KEY, AWS_IAM, AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, AWS_LAMBDA</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Enables and controls the enhanced metrics feature. See enhanced_metrics_config Block for details.</summary>
    [JsonPropertyName("enhancedMetricsConfig")]
    public V1beta1GraphQLAPIStatusAtProviderEnhancedMetricsConfig? EnhancedMetricsConfig { get; set; }

    /// <summary>API ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Sets the value of the GraphQL API to enable (ENABLED) or disable (DISABLED) introspection. If no value is provided, the introspection configuration will be set to ENABLED by default. This field will produce an error if the operation attempts to use the introspection feature while this field is disabled. For more information about introspection, see GraphQL introspection.</summary>
    [JsonPropertyName("introspectionConfig")]
    public string? IntrospectionConfig { get; set; }

    /// <summary>Nested argument containing Lambda authorizer configuration. See lambda_authorizer_config Block for details.</summary>
    [JsonPropertyName("lambdaAuthorizerConfig")]
    public V1beta1GraphQLAPIStatusAtProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig { get; set; }

    /// <summary>Nested argument containing logging configuration. See log_config Block for details.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1GraphQLAPIStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>ARN of the execution role when api_type is set to MERGED.</summary>
    [JsonPropertyName("mergedApiExecutionRoleArn")]
    public string? MergedApiExecutionRoleArn { get; set; }

    /// <summary>User-supplied name for the GraphQL API.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Nested argument containing OpenID Connect configuration. See openid_connect_config Block for details.</summary>
    [JsonPropertyName("openidConnectConfig")]
    public V1beta1GraphQLAPIStatusAtProviderOpenidConnectConfig? OpenidConnectConfig { get; set; }

    /// <summary>The maximum depth a query can have in a single request. Depth refers to the amount of nested levels allowed in the body of query. The default value is 0 (or unspecified), which indicates there's no depth limit. If you set a limit, it can be between 1 and 75 nested levels. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("queryDepthLimit")]
    public double? QueryDepthLimit { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The maximum number of resolvers that can be invoked in a single request. The default value is 0 (or unspecified), which will set the limit to 10000. When specified, the limit value can be between 1 and 10000. This field will produce a limit error if the operation falls out of bounds.</summary>
    [JsonPropertyName("resolverCountLimit")]
    public double? ResolverCountLimit { get; set; }

    /// <summary>Schema definition, in GraphQL schema language format.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Map of URIs associated with the API E.g., uris["GRAPHQL"] = https://ID.appsync-api.REGION.amazonaws.com/graphql</summary>
    [JsonPropertyName("uris")]
    public IDictionary<string, string>? Uris { get; set; }

    /// <summary>Amazon Cognito User Pool configuration. See user_pool_config Block for details.</summary>
    [JsonPropertyName("userPoolConfig")]
    public V1beta1GraphQLAPIStatusAtProviderUserPoolConfig? UserPoolConfig { get; set; }

    /// <summary>Sets the value of the GraphQL API to public (GLOBAL) or private (PRIVATE). If no value is provided, the visibility will be set to GLOBAL by default. This value cannot be changed once the API has been created.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>Whether tracing with X-ray is enabled. Defaults to false.</summary>
    [JsonPropertyName("xrayEnabled")]
    public bool? XrayEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatusConditions
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

/// <summary>GraphQLAPIStatus defines the observed state of GraphQLAPI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GraphQLAPIStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1GraphQLAPIStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GraphQLAPIStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GraphQLAPI is the Schema for the GraphQLAPIs API. Provides an AppSync GraphQL API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GraphQLAPI : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GraphQLAPISpec>, IStatus<V1beta1GraphQLAPIStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GraphQLAPI";
    public const string KubeGroup = "appsync.aws.m.upbound.io";
    public const string KubePluralName = "graphqlapis";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GraphQLAPISpec defines the desired state of GraphQLAPI</summary>
    [JsonPropertyName("spec")]
    public V1beta1GraphQLAPISpec Spec { get; set; }

    /// <summary>GraphQLAPIStatus defines the observed state of GraphQLAPI.</summary>
    [JsonPropertyName("status")]
    public V1beta1GraphQLAPIStatus? Status { get; set; }
}