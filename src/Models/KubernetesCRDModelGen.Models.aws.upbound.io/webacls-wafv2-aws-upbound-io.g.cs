using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafv2.aws.upbound.io;
/// <summary>WebACL is the Schema for the WebACLs API. Creates a WAFv2 Web ACL resource. The 'rule' field is not supported due to Kubernetes CRD size limitations with deeply nested fields. Please use the 'ruleJson' field to define rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACLList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebACL>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACLList";
    public const string KubeGroup = "wafv2.aws.upbound.io";
    public const string KubePluralName = "webacls";
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
    public IList<V1beta1WebACL> Items { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon API Gateway REST APIs forward to AWS WAF for inspection. Applicable only when scope is set to CLOUDFRONT. See api_gateway below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderAssociationConfigRequestBodyApiGateway
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon App Runner services forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See app_runner_service below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderAssociationConfigRequestBodyAppRunnerService
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon CloudFront distributions forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cloudfront below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderAssociationConfigRequestBodyCloudfront
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon Cognito user pools forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cognito_user_pool below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderAssociationConfigRequestBodyCognitoUserPool
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected AWS Verfied Access instances forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See verified_access_instance below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderAssociationConfigRequestBodyVerifiedAccessInstance
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderAssociationConfigRequestBody
{
    /// <summary>Customizes the request body that your protected Amazon API Gateway REST APIs forward to AWS WAF for inspection. Applicable only when scope is set to CLOUDFRONT. See api_gateway below for details.</summary>
    [JsonPropertyName("apiGateway")]
    public V1beta1WebACLSpecForProviderAssociationConfigRequestBodyApiGateway? ApiGateway { get; set; }

    /// <summary>Customizes the request body that your protected Amazon App Runner services forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See app_runner_service below for details.</summary>
    [JsonPropertyName("appRunnerService")]
    public V1beta1WebACLSpecForProviderAssociationConfigRequestBodyAppRunnerService? AppRunnerService { get; set; }

    /// <summary>Customizes the request body that your protected Amazon CloudFront distributions forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cloudfront below for details.</summary>
    [JsonPropertyName("cloudfront")]
    public V1beta1WebACLSpecForProviderAssociationConfigRequestBodyCloudfront? Cloudfront { get; set; }

    /// <summary>Customizes the request body that your protected Amazon Cognito user pools forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cognito_user_pool below for details.</summary>
    [JsonPropertyName("cognitoUserPool")]
    public V1beta1WebACLSpecForProviderAssociationConfigRequestBodyCognitoUserPool? CognitoUserPool { get; set; }

    /// <summary>Customizes the request body that your protected AWS Verfied Access instances forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See verified_access_instance below for details.</summary>
    [JsonPropertyName("verifiedAccessInstance")]
    public V1beta1WebACLSpecForProviderAssociationConfigRequestBodyVerifiedAccessInstance? VerifiedAccessInstance { get; set; }
}

/// <summary>Specifies custom configurations for the associations between the web ACL and protected resources. See association_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderAssociationConfig
{
    /// <summary>Customizes the request body that your protected resource forward to AWS WAF for inspection. See request_body below for details.</summary>
    [JsonPropertyName("requestBody")]
    public IList<V1beta1WebACLSpecForProviderAssociationConfigRequestBody>? RequestBody { get; set; }
}

/// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderCaptchaConfigImmunityTimeProperty
{
    /// <summary>The amount of time, in seconds, that a CAPTCHA or challenge timestamp is considered valid by AWS WAF. The default setting is 300.</summary>
    [JsonPropertyName("immunityTime")]
    public double? ImmunityTime { get; set; }
}

/// <summary>Specifies how AWS WAF should handle CAPTCHA evaluations on the ACL level (used by AWS Bot Control). See captcha_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderCaptchaConfig
{
    /// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1beta1WebACLSpecForProviderCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderChallengeConfigImmunityTimeProperty
{
    /// <summary>The amount of time, in seconds, that a CAPTCHA or challenge timestamp is considered valid by AWS WAF. The default setting is 300.</summary>
    [JsonPropertyName("immunityTime")]
    public double? ImmunityTime { get; set; }
}

/// <summary>Specifies how AWS WAF should handle Challenge evaluations on the ACL level (used by AWS Bot Control). See challenge_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderChallengeConfig
{
    /// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1beta1WebACLSpecForProviderChallengeConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderCustomResponseBody
{
    /// <summary>Payload of the custom response.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of content in the payload that you are defining in the content argument. Valid values are TEXT_PLAIN, TEXT_HTML, or APPLICATION_JSON.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Unique key identifying the custom response body. This is referenced by the custom_response_body_key argument in the custom_response block.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Specifies the field type and optional keys to apply the protection behavior to. See field block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDataProtectionConfigDataProtectionField
{
    /// <summary>Array of strings to specify the keys to protect for the specified field type. If you don't specify any key, then all keys for the field type are protected.</summary>
    [JsonPropertyName("fieldKeys")]
    public IList<string>? FieldKeys { get; set; }

    /// <summary>Specifies the web request component type to protect. Valid Values are SINGLE_HEADER, SINGLE_COOKIE, SINGLE_QUERY_ARGUMENT, QUERY_STRING, BODY.</summary>
    [JsonPropertyName("fieldType")]
    public string? FieldType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDataProtectionConfigDataProtection
{
    /// <summary>Specifies how to protect the field. Valid values are SUBSTITUTION or HASH.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Boolean to specify whether to also exclude any rate-based rule details from the data protection you have enabled for a given field.</summary>
    [JsonPropertyName("excludeRateBasedDetails")]
    public bool? ExcludeRateBasedDetails { get; set; }

    /// <summary>Boolean to specify whether to also exclude any rule match details from the data protection you have enabled for a given field. AWS WAF logs these details for non-terminating matching rules and for the terminating matching rule.</summary>
    [JsonPropertyName("excludeRuleMatchDetails")]
    public bool? ExcludeRuleMatchDetails { get; set; }

    /// <summary>Specifies the field type and optional keys to apply the protection behavior to. See field block below for details.</summary>
    [JsonPropertyName("field")]
    public V1beta1WebACLSpecForProviderDataProtectionConfigDataProtectionField? Field { get; set; }
}

/// <summary>Specifies data protection to apply to the web request data for the web ACL. This is a web ACL level data protection option. See data_protection_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDataProtectionConfig
{
    /// <summary>A block for data protection configurations for specific web request field types. See data_protection block for details.</summary>
    [JsonPropertyName("dataProtection")]
    public IList<V1beta1WebACLSpecForProviderDataProtectionConfigDataProtection>? DataProtection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultActionAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the query header to inspect. This setting must be provided as lower case characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the custom header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Defines custom handling for the web request. See custom_request_handling below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultActionAllowCustomRequestHandling
{
    /// <summary>The insert_header blocks used to define HTTP headers added to the request. See insert_header below for details.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLSpecForProviderDefaultActionAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Specifies that AWS WAF should allow requests by default. See allow below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultActionAllow
{
    /// <summary>Defines custom handling for the web request. See custom_request_handling below for details.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLSpecForProviderDefaultActionAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultActionBlockCustomResponseResponseHeader
{
    /// <summary>Name of the query header to inspect. This setting must be provided as lower case characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the custom header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Defines a custom response for the web request. See custom_response below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultActionBlockCustomResponse
{
    /// <summary>References the response body that you want AWS WAF to return to the web request client. This must reference a key defined in a custom_response_body block of this resource.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>The HTTP status code to return to the client.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>The response_header blocks used to define the HTTP response headers added to the response. See response_header below for details.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLSpecForProviderDefaultActionBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Specifies that AWS WAF should block requests by default. See block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultActionBlock
{
    /// <summary>Defines a custom response for the web request. See custom_response below for details.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLSpecForProviderDefaultActionBlockCustomResponse? CustomResponse { get; set; }
}

/// <summary>Action to perform if none of the rules contained in the WebACL match. See default_action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultAction
{
    /// <summary>Specifies that AWS WAF should allow requests by default. See allow below for details.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLSpecForProviderDefaultActionAllow? Allow { get; set; }

    /// <summary>Specifies that AWS WAF should block requests by default. See block below for details.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLSpecForProviderDefaultActionBlock? Block { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See visibility_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderVisibilityConfig
{
    /// <summary>Whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.</summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can't contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.</summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProvider
{
    /// <summary>Specifies custom configurations for the associations between the web ACL and protected resources. See association_config below for details.</summary>
    [JsonPropertyName("associationConfig")]
    public V1beta1WebACLSpecForProviderAssociationConfig? AssociationConfig { get; set; }

    /// <summary>Specifies how AWS WAF should handle CAPTCHA evaluations on the ACL level (used by AWS Bot Control). See captcha_config below for details.</summary>
    [JsonPropertyName("captchaConfig")]
    public V1beta1WebACLSpecForProviderCaptchaConfig? CaptchaConfig { get; set; }

    /// <summary>Specifies how AWS WAF should handle Challenge evaluations on the ACL level (used by AWS Bot Control). See challenge_config below for details.</summary>
    [JsonPropertyName("challengeConfig")]
    public V1beta1WebACLSpecForProviderChallengeConfig? ChallengeConfig { get; set; }

    /// <summary>Defines custom response bodies that can be referenced by custom_response actions. See custom_response_body below for details.</summary>
    [JsonPropertyName("customResponseBody")]
    public IList<V1beta1WebACLSpecForProviderCustomResponseBody>? CustomResponseBody { get; set; }

    /// <summary>Specifies data protection to apply to the web request data for the web ACL. This is a web ACL level data protection option. See data_protection_config below for details.</summary>
    [JsonPropertyName("dataProtectionConfig")]
    public V1beta1WebACLSpecForProviderDataProtectionConfig? DataProtectionConfig { get; set; }

    /// <summary>Action to perform if none of the rules contained in the WebACL match. See default_action below for details.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLSpecForProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>Friendly description of the WebACL.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the WebACL. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A raw JSON string used to define the rules for allowing, blocking, or counting web requests. When this field is used, Crossplane cannot observe changes in the configuration through the AWS API; therefore, drift detection cannot be performed. Refer to the AWS documentation for the expected JSON structure: https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateWebACL.html</summary>
    [JsonPropertyName("ruleJson")]
    public string? RuleJson { get; set; }

    /// <summary>Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL. To work with CloudFront, you must also specify the region us-east-1 (N. Virginia) on the AWS provider.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the domains that AWS WAF should accept in a web request token. This enables the use of tokens across multiple protected websites. When AWS WAF provides a token, it uses the domain of the AWS resource that the web ACL is protecting. If you don't specify a list of token domains, AWS WAF accepts tokens only for the domain of the protected resource. With a token domain list, AWS WAF accepts the resource's host domain plus all domains in the token domain list, including their prefixed subdomains.</summary>
    [JsonPropertyName("tokenDomains")]
    public IList<string>? TokenDomains { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See visibility_config below for details.</summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1WebACLSpecForProviderVisibilityConfig? VisibilityConfig { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon API Gateway REST APIs forward to AWS WAF for inspection. Applicable only when scope is set to CLOUDFRONT. See api_gateway below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyApiGateway
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon App Runner services forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See app_runner_service below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyAppRunnerService
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon CloudFront distributions forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cloudfront below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyCloudfront
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon Cognito user pools forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cognito_user_pool below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyCognitoUserPool
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected AWS Verfied Access instances forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See verified_access_instance below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyVerifiedAccessInstance
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderAssociationConfigRequestBody
{
    /// <summary>Customizes the request body that your protected Amazon API Gateway REST APIs forward to AWS WAF for inspection. Applicable only when scope is set to CLOUDFRONT. See api_gateway below for details.</summary>
    [JsonPropertyName("apiGateway")]
    public V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyApiGateway? ApiGateway { get; set; }

    /// <summary>Customizes the request body that your protected Amazon App Runner services forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See app_runner_service below for details.</summary>
    [JsonPropertyName("appRunnerService")]
    public V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyAppRunnerService? AppRunnerService { get; set; }

    /// <summary>Customizes the request body that your protected Amazon CloudFront distributions forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cloudfront below for details.</summary>
    [JsonPropertyName("cloudfront")]
    public V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyCloudfront? Cloudfront { get; set; }

    /// <summary>Customizes the request body that your protected Amazon Cognito user pools forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cognito_user_pool below for details.</summary>
    [JsonPropertyName("cognitoUserPool")]
    public V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyCognitoUserPool? CognitoUserPool { get; set; }

    /// <summary>Customizes the request body that your protected AWS Verfied Access instances forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See verified_access_instance below for details.</summary>
    [JsonPropertyName("verifiedAccessInstance")]
    public V1beta1WebACLSpecInitProviderAssociationConfigRequestBodyVerifiedAccessInstance? VerifiedAccessInstance { get; set; }
}

/// <summary>Specifies custom configurations for the associations between the web ACL and protected resources. See association_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderAssociationConfig
{
    /// <summary>Customizes the request body that your protected resource forward to AWS WAF for inspection. See request_body below for details.</summary>
    [JsonPropertyName("requestBody")]
    public IList<V1beta1WebACLSpecInitProviderAssociationConfigRequestBody>? RequestBody { get; set; }
}

/// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderCaptchaConfigImmunityTimeProperty
{
    /// <summary>The amount of time, in seconds, that a CAPTCHA or challenge timestamp is considered valid by AWS WAF. The default setting is 300.</summary>
    [JsonPropertyName("immunityTime")]
    public double? ImmunityTime { get; set; }
}

/// <summary>Specifies how AWS WAF should handle CAPTCHA evaluations on the ACL level (used by AWS Bot Control). See captcha_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderCaptchaConfig
{
    /// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1beta1WebACLSpecInitProviderCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderChallengeConfigImmunityTimeProperty
{
    /// <summary>The amount of time, in seconds, that a CAPTCHA or challenge timestamp is considered valid by AWS WAF. The default setting is 300.</summary>
    [JsonPropertyName("immunityTime")]
    public double? ImmunityTime { get; set; }
}

/// <summary>Specifies how AWS WAF should handle Challenge evaluations on the ACL level (used by AWS Bot Control). See challenge_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderChallengeConfig
{
    /// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1beta1WebACLSpecInitProviderChallengeConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderCustomResponseBody
{
    /// <summary>Payload of the custom response.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of content in the payload that you are defining in the content argument. Valid values are TEXT_PLAIN, TEXT_HTML, or APPLICATION_JSON.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Unique key identifying the custom response body. This is referenced by the custom_response_body_key argument in the custom_response block.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Specifies the field type and optional keys to apply the protection behavior to. See field block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDataProtectionConfigDataProtectionField
{
    /// <summary>Array of strings to specify the keys to protect for the specified field type. If you don't specify any key, then all keys for the field type are protected.</summary>
    [JsonPropertyName("fieldKeys")]
    public IList<string>? FieldKeys { get; set; }

    /// <summary>Specifies the web request component type to protect. Valid Values are SINGLE_HEADER, SINGLE_COOKIE, SINGLE_QUERY_ARGUMENT, QUERY_STRING, BODY.</summary>
    [JsonPropertyName("fieldType")]
    public string? FieldType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDataProtectionConfigDataProtection
{
    /// <summary>Specifies how to protect the field. Valid values are SUBSTITUTION or HASH.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Boolean to specify whether to also exclude any rate-based rule details from the data protection you have enabled for a given field.</summary>
    [JsonPropertyName("excludeRateBasedDetails")]
    public bool? ExcludeRateBasedDetails { get; set; }

    /// <summary>Boolean to specify whether to also exclude any rule match details from the data protection you have enabled for a given field. AWS WAF logs these details for non-terminating matching rules and for the terminating matching rule.</summary>
    [JsonPropertyName("excludeRuleMatchDetails")]
    public bool? ExcludeRuleMatchDetails { get; set; }

    /// <summary>Specifies the field type and optional keys to apply the protection behavior to. See field block below for details.</summary>
    [JsonPropertyName("field")]
    public V1beta1WebACLSpecInitProviderDataProtectionConfigDataProtectionField? Field { get; set; }
}

/// <summary>Specifies data protection to apply to the web request data for the web ACL. This is a web ACL level data protection option. See data_protection_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDataProtectionConfig
{
    /// <summary>A block for data protection configurations for specific web request field types. See data_protection block for details.</summary>
    [JsonPropertyName("dataProtection")]
    public IList<V1beta1WebACLSpecInitProviderDataProtectionConfigDataProtection>? DataProtection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultActionAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the query header to inspect. This setting must be provided as lower case characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the custom header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Defines custom handling for the web request. See custom_request_handling below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultActionAllowCustomRequestHandling
{
    /// <summary>The insert_header blocks used to define HTTP headers added to the request. See insert_header below for details.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLSpecInitProviderDefaultActionAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Specifies that AWS WAF should allow requests by default. See allow below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultActionAllow
{
    /// <summary>Defines custom handling for the web request. See custom_request_handling below for details.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLSpecInitProviderDefaultActionAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultActionBlockCustomResponseResponseHeader
{
    /// <summary>Name of the query header to inspect. This setting must be provided as lower case characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the custom header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Defines a custom response for the web request. See custom_response below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultActionBlockCustomResponse
{
    /// <summary>References the response body that you want AWS WAF to return to the web request client. This must reference a key defined in a custom_response_body block of this resource.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>The HTTP status code to return to the client.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>The response_header blocks used to define the HTTP response headers added to the response. See response_header below for details.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLSpecInitProviderDefaultActionBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Specifies that AWS WAF should block requests by default. See block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultActionBlock
{
    /// <summary>Defines a custom response for the web request. See custom_response below for details.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLSpecInitProviderDefaultActionBlockCustomResponse? CustomResponse { get; set; }
}

/// <summary>Action to perform if none of the rules contained in the WebACL match. See default_action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultAction
{
    /// <summary>Specifies that AWS WAF should allow requests by default. See allow below for details.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLSpecInitProviderDefaultActionAllow? Allow { get; set; }

    /// <summary>Specifies that AWS WAF should block requests by default. See block below for details.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLSpecInitProviderDefaultActionBlock? Block { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See visibility_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderVisibilityConfig
{
    /// <summary>Whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.</summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can't contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.</summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProvider
{
    /// <summary>Specifies custom configurations for the associations between the web ACL and protected resources. See association_config below for details.</summary>
    [JsonPropertyName("associationConfig")]
    public V1beta1WebACLSpecInitProviderAssociationConfig? AssociationConfig { get; set; }

    /// <summary>Specifies how AWS WAF should handle CAPTCHA evaluations on the ACL level (used by AWS Bot Control). See captcha_config below for details.</summary>
    [JsonPropertyName("captchaConfig")]
    public V1beta1WebACLSpecInitProviderCaptchaConfig? CaptchaConfig { get; set; }

    /// <summary>Specifies how AWS WAF should handle Challenge evaluations on the ACL level (used by AWS Bot Control). See challenge_config below for details.</summary>
    [JsonPropertyName("challengeConfig")]
    public V1beta1WebACLSpecInitProviderChallengeConfig? ChallengeConfig { get; set; }

    /// <summary>Defines custom response bodies that can be referenced by custom_response actions. See custom_response_body below for details.</summary>
    [JsonPropertyName("customResponseBody")]
    public IList<V1beta1WebACLSpecInitProviderCustomResponseBody>? CustomResponseBody { get; set; }

    /// <summary>Specifies data protection to apply to the web request data for the web ACL. This is a web ACL level data protection option. See data_protection_config below for details.</summary>
    [JsonPropertyName("dataProtectionConfig")]
    public V1beta1WebACLSpecInitProviderDataProtectionConfig? DataProtectionConfig { get; set; }

    /// <summary>Action to perform if none of the rules contained in the WebACL match. See default_action below for details.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLSpecInitProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>Friendly description of the WebACL.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the WebACL. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A raw JSON string used to define the rules for allowing, blocking, or counting web requests. When this field is used, Crossplane cannot observe changes in the configuration through the AWS API; therefore, drift detection cannot be performed. Refer to the AWS documentation for the expected JSON structure: https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateWebACL.html</summary>
    [JsonPropertyName("ruleJson")]
    public string? RuleJson { get; set; }

    /// <summary>Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL. To work with CloudFront, you must also specify the region us-east-1 (N. Virginia) on the AWS provider.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the domains that AWS WAF should accept in a web request token. This enables the use of tokens across multiple protected websites. When AWS WAF provides a token, it uses the domain of the AWS resource that the web ACL is protecting. If you don't specify a list of token domains, AWS WAF accepts tokens only for the domain of the protected resource. With a token domain list, AWS WAF accepts the resource's host domain plus all domains in the token domain list, including their prefixed subdomains.</summary>
    [JsonPropertyName("tokenDomains")]
    public IList<string>? TokenDomains { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See visibility_config below for details.</summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1WebACLSpecInitProviderVisibilityConfig? VisibilityConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecProviderConfigRefPolicy
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
public partial class V1beta1WebACLSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>WebACLSpec defines the desired state of WebACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WebACLSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WebACLSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebACLSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebACLSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon API Gateway REST APIs forward to AWS WAF for inspection. Applicable only when scope is set to CLOUDFRONT. See api_gateway below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyApiGateway
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon App Runner services forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See app_runner_service below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyAppRunnerService
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon CloudFront distributions forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cloudfront below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyCloudfront
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected Amazon Cognito user pools forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cognito_user_pool below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyCognitoUserPool
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary>Customizes the request body that your protected AWS Verfied Access instances forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See verified_access_instance below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyVerifiedAccessInstance
{
    /// <summary>Specifies the maximum size of the web request body component that an associated AWS Verified Access instances should send to AWS WAF for inspection. This applies to statements in the web ACL that inspect the body or JSON body. Valid values are KB_16, KB_32, KB_48 and KB_64.</summary>
    [JsonPropertyName("defaultSizeInspectionLimit")]
    public string? DefaultSizeInspectionLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderAssociationConfigRequestBody
{
    /// <summary>Customizes the request body that your protected Amazon API Gateway REST APIs forward to AWS WAF for inspection. Applicable only when scope is set to CLOUDFRONT. See api_gateway below for details.</summary>
    [JsonPropertyName("apiGateway")]
    public V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyApiGateway? ApiGateway { get; set; }

    /// <summary>Customizes the request body that your protected Amazon App Runner services forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See app_runner_service below for details.</summary>
    [JsonPropertyName("appRunnerService")]
    public V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyAppRunnerService? AppRunnerService { get; set; }

    /// <summary>Customizes the request body that your protected Amazon CloudFront distributions forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cloudfront below for details.</summary>
    [JsonPropertyName("cloudfront")]
    public V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyCloudfront? Cloudfront { get; set; }

    /// <summary>Customizes the request body that your protected Amazon Cognito user pools forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See cognito_user_pool below for details.</summary>
    [JsonPropertyName("cognitoUserPool")]
    public V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyCognitoUserPool? CognitoUserPool { get; set; }

    /// <summary>Customizes the request body that your protected AWS Verfied Access instances forward to AWS WAF for inspection. Applicable only when scope is set to REGIONAL. See verified_access_instance below for details.</summary>
    [JsonPropertyName("verifiedAccessInstance")]
    public V1beta1WebACLStatusAtProviderAssociationConfigRequestBodyVerifiedAccessInstance? VerifiedAccessInstance { get; set; }
}

/// <summary>Specifies custom configurations for the associations between the web ACL and protected resources. See association_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderAssociationConfig
{
    /// <summary>Customizes the request body that your protected resource forward to AWS WAF for inspection. See request_body below for details.</summary>
    [JsonPropertyName("requestBody")]
    public IList<V1beta1WebACLStatusAtProviderAssociationConfigRequestBody>? RequestBody { get; set; }
}

/// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderCaptchaConfigImmunityTimeProperty
{
    /// <summary>The amount of time, in seconds, that a CAPTCHA or challenge timestamp is considered valid by AWS WAF. The default setting is 300.</summary>
    [JsonPropertyName("immunityTime")]
    public double? ImmunityTime { get; set; }
}

/// <summary>Specifies how AWS WAF should handle CAPTCHA evaluations on the ACL level (used by AWS Bot Control). See captcha_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderCaptchaConfig
{
    /// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1beta1WebACLStatusAtProviderCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderChallengeConfigImmunityTimeProperty
{
    /// <summary>The amount of time, in seconds, that a CAPTCHA or challenge timestamp is considered valid by AWS WAF. The default setting is 300.</summary>
    [JsonPropertyName("immunityTime")]
    public double? ImmunityTime { get; set; }
}

/// <summary>Specifies how AWS WAF should handle Challenge evaluations on the ACL level (used by AWS Bot Control). See challenge_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderChallengeConfig
{
    /// <summary>Defines custom immunity time. See immunity_time_property below for details.</summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1beta1WebACLStatusAtProviderChallengeConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderCustomResponseBody
{
    /// <summary>Payload of the custom response.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of content in the payload that you are defining in the content argument. Valid values are TEXT_PLAIN, TEXT_HTML, or APPLICATION_JSON.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Unique key identifying the custom response body. This is referenced by the custom_response_body_key argument in the custom_response block.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Specifies the field type and optional keys to apply the protection behavior to. See field block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDataProtectionConfigDataProtectionField
{
    /// <summary>Array of strings to specify the keys to protect for the specified field type. If you don't specify any key, then all keys for the field type are protected.</summary>
    [JsonPropertyName("fieldKeys")]
    public IList<string>? FieldKeys { get; set; }

    /// <summary>Specifies the web request component type to protect. Valid Values are SINGLE_HEADER, SINGLE_COOKIE, SINGLE_QUERY_ARGUMENT, QUERY_STRING, BODY.</summary>
    [JsonPropertyName("fieldType")]
    public string? FieldType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDataProtectionConfigDataProtection
{
    /// <summary>Specifies how to protect the field. Valid values are SUBSTITUTION or HASH.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Boolean to specify whether to also exclude any rate-based rule details from the data protection you have enabled for a given field.</summary>
    [JsonPropertyName("excludeRateBasedDetails")]
    public bool? ExcludeRateBasedDetails { get; set; }

    /// <summary>Boolean to specify whether to also exclude any rule match details from the data protection you have enabled for a given field. AWS WAF logs these details for non-terminating matching rules and for the terminating matching rule.</summary>
    [JsonPropertyName("excludeRuleMatchDetails")]
    public bool? ExcludeRuleMatchDetails { get; set; }

    /// <summary>Specifies the field type and optional keys to apply the protection behavior to. See field block below for details.</summary>
    [JsonPropertyName("field")]
    public V1beta1WebACLStatusAtProviderDataProtectionConfigDataProtectionField? Field { get; set; }
}

/// <summary>Specifies data protection to apply to the web request data for the web ACL. This is a web ACL level data protection option. See data_protection_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDataProtectionConfig
{
    /// <summary>A block for data protection configurations for specific web request field types. See data_protection block for details.</summary>
    [JsonPropertyName("dataProtection")]
    public IList<V1beta1WebACLStatusAtProviderDataProtectionConfigDataProtection>? DataProtection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultActionAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the query header to inspect. This setting must be provided as lower case characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the custom header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Defines custom handling for the web request. See custom_request_handling below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultActionAllowCustomRequestHandling
{
    /// <summary>The insert_header blocks used to define HTTP headers added to the request. See insert_header below for details.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLStatusAtProviderDefaultActionAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Specifies that AWS WAF should allow requests by default. See allow below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultActionAllow
{
    /// <summary>Defines custom handling for the web request. See custom_request_handling below for details.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLStatusAtProviderDefaultActionAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultActionBlockCustomResponseResponseHeader
{
    /// <summary>Name of the query header to inspect. This setting must be provided as lower case characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the custom header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Defines a custom response for the web request. See custom_response below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultActionBlockCustomResponse
{
    /// <summary>References the response body that you want AWS WAF to return to the web request client. This must reference a key defined in a custom_response_body block of this resource.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>The HTTP status code to return to the client.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>The response_header blocks used to define the HTTP response headers added to the response. See response_header below for details.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLStatusAtProviderDefaultActionBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Specifies that AWS WAF should block requests by default. See block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultActionBlock
{
    /// <summary>Defines a custom response for the web request. See custom_response below for details.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLStatusAtProviderDefaultActionBlockCustomResponse? CustomResponse { get; set; }
}

/// <summary>Action to perform if none of the rules contained in the WebACL match. See default_action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultAction
{
    /// <summary>Specifies that AWS WAF should allow requests by default. See allow below for details.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLStatusAtProviderDefaultActionAllow? Allow { get; set; }

    /// <summary>Specifies that AWS WAF should block requests by default. See block below for details.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLStatusAtProviderDefaultActionBlock? Block { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See visibility_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderVisibilityConfig
{
    /// <summary>Whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.</summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can't contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.</summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProvider
{
    /// <summary>The URL to use in SDK integrations with managed rule groups.</summary>
    [JsonPropertyName("applicationIntegrationUrl")]
    public string? ApplicationIntegrationUrl { get; set; }

    /// <summary>The ARN of the WAF WebACL.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies custom configurations for the associations between the web ACL and protected resources. See association_config below for details.</summary>
    [JsonPropertyName("associationConfig")]
    public V1beta1WebACLStatusAtProviderAssociationConfig? AssociationConfig { get; set; }

    /// <summary>Web ACL capacity units (WCUs) currently being used by this web ACL.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Specifies how AWS WAF should handle CAPTCHA evaluations on the ACL level (used by AWS Bot Control). See captcha_config below for details.</summary>
    [JsonPropertyName("captchaConfig")]
    public V1beta1WebACLStatusAtProviderCaptchaConfig? CaptchaConfig { get; set; }

    /// <summary>Specifies how AWS WAF should handle Challenge evaluations on the ACL level (used by AWS Bot Control). See challenge_config below for details.</summary>
    [JsonPropertyName("challengeConfig")]
    public V1beta1WebACLStatusAtProviderChallengeConfig? ChallengeConfig { get; set; }

    /// <summary>Defines custom response bodies that can be referenced by custom_response actions. See custom_response_body below for details.</summary>
    [JsonPropertyName("customResponseBody")]
    public IList<V1beta1WebACLStatusAtProviderCustomResponseBody>? CustomResponseBody { get; set; }

    /// <summary>Specifies data protection to apply to the web request data for the web ACL. This is a web ACL level data protection option. See data_protection_config below for details.</summary>
    [JsonPropertyName("dataProtectionConfig")]
    public V1beta1WebACLStatusAtProviderDataProtectionConfig? DataProtectionConfig { get; set; }

    /// <summary>Action to perform if none of the rules contained in the WebACL match. See default_action below for details.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLStatusAtProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>Friendly description of the WebACL.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the WAF WebACL.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lockToken")]
    public string? LockToken { get; set; }

    /// <summary>Friendly name of the WebACL. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A raw JSON string used to define the rules for allowing, blocking, or counting web requests. When this field is used, Crossplane cannot observe changes in the configuration through the AWS API; therefore, drift detection cannot be performed. Refer to the AWS documentation for the expected JSON structure: https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateWebACL.html</summary>
    [JsonPropertyName("ruleJson")]
    public string? RuleJson { get; set; }

    /// <summary>Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL. To work with CloudFront, you must also specify the region us-east-1 (N. Virginia) on the AWS provider.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Specifies the domains that AWS WAF should accept in a web request token. This enables the use of tokens across multiple protected websites. When AWS WAF provides a token, it uses the domain of the AWS resource that the web ACL is protecting. If you don't specify a list of token domains, AWS WAF accepts tokens only for the domain of the protected resource. With a token domain list, AWS WAF accepts the resource's host domain plus all domains in the token domain list, including their prefixed subdomains.</summary>
    [JsonPropertyName("tokenDomains")]
    public IList<string>? TokenDomains { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See visibility_config below for details.</summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1WebACLStatusAtProviderVisibilityConfig? VisibilityConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusConditions
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

/// <summary>WebACLStatus defines the observed state of WebACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WebACLStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebACLStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WebACL is the Schema for the WebACLs API. Creates a WAFv2 Web ACL resource. The 'rule' field is not supported due to Kubernetes CRD size limitations with deeply nested fields. Please use the 'ruleJson' field to define rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACL : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebACLSpec>, IStatus<V1beta1WebACLStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACL";
    public const string KubeGroup = "wafv2.aws.upbound.io";
    public const string KubePluralName = "webacls";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebACLSpec defines the desired state of WebACL</summary>
    [JsonPropertyName("spec")]
    public V1beta1WebACLSpec Spec { get; set; }

    /// <summary>WebACLStatus defines the observed state of WebACL.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebACLStatus? Status { get; set; }
}