using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderCustomErrorResponse
{
    /// <summary>Minimum amount of time you want HTTP error codes to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated.</summary>
    [JsonPropertyName("errorCachingMinTtl")]
    public double? ErrorCachingMinTtl { get; set; }

    /// <summary>4xx or 5xx HTTP status code that you want to customize.</summary>
    [JsonPropertyName("errorCode")]
    public double? ErrorCode { get; set; }

    /// <summary>HTTP status code that you want CloudFront to return with the custom error page to the viewer.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Path of the custom error page (for example, /custom_404.html).</summary>
    [JsonPropertyName("responsePagePath")]
    public string? ResponsePagePath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderDefaultCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderDefaultCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1DistributionSpecForProviderDefaultCacheBehaviorForwardedValuesCookies>? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderDefaultCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderDefaultCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderDefaultCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public IList<V1beta1DistributionSpecForProviderDefaultCacheBehaviorForwardedValues>? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta1DistributionSpecForProviderDefaultCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta1DistributionSpecForProviderDefaultCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderLoggingConfig
{
    /// <summary>Amazon S3 bucket to store the access logs in, for example, myawslogbucket.s3.amazonaws.com.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether to include cookies in access logs (default: false).</summary>
    [JsonPropertyName("includeCookies")]
    public bool? IncludeCookies { get; set; }

    /// <summary>Prefix to the access log filenames for this distribution, for example, myprefix/.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1DistributionSpecForProviderOrderedCacheBehaviorForwardedValuesCookies>? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnRef")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef? FunctionArnRef { get; set; }

    /// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnSelector")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector? FunctionArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector? LambdaArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrderedCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public IList<V1beta1DistributionSpecForProviderOrderedCacheBehaviorForwardedValues>? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta1DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta1DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>Pattern (for example, images/*.jpg) that specifies which requests you want this cache behavior to apply to.</summary>
    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginCustomHeader
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginCustomOriginConfig
{
    /// <summary>HTTP port the custom origin listens on.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>HTTPS port the custom origin listens on.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>Origin protocol policy to apply to your origin. One of http-only, https-only, or match-viewer.</summary>
    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>List of SSL/TLS protocols that CloudFront can use when connecting to your origin over HTTPS. Valid values: SSLv3, TLSv1, TLSv1.1, TLSv1.2. For more information, see Minimum Origin SSL Protocol in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originSslProtocols")]
    public IList<string>? OriginSslProtocols { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginOriginShield
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>AWS Region for Origin Shield. To specify a region, use the region code, not the region name. For example, specify the US East (Ohio) region as us-east-2.</summary>
    [JsonPropertyName("originShieldRegion")]
    public string? OriginShieldRegion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginS3OriginConfig
{
    /// <summary>The CloudFront origin access identity to associate with the origin.</summary>
    [JsonPropertyName("originAccessIdentity")]
    public string? OriginAccessIdentity { get; set; }

    /// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentityRef")]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRef? OriginAccessIdentityRef { get; set; }

    /// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentitySelector")]
    public V1beta1DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelector? OriginAccessIdentitySelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOrigin
{
    /// <summary>Number of times that CloudFront attempts to connect to the origin. Must be between 1-3. Defaults to 3.</summary>
    [JsonPropertyName("connectionAttempts")]
    public double? ConnectionAttempts { get; set; }

    /// <summary>Number of seconds that CloudFront waits when trying to establish a connection to the origin. Must be between 1-10. Defaults to 10.</summary>
    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    /// <summary>One or more sub-resources with name and value parameters that specify header data that will be sent to the origin (multiples allowed).</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta1DistributionSpecForProviderOriginCustomHeader>? CustomHeader { get; set; }

    /// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
    [JsonPropertyName("customOriginConfig")]
    public IList<V1beta1DistributionSpecForProviderOriginCustomOriginConfig>? CustomOriginConfig { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Unique identifier of a CloudFront origin access control for this origin.</summary>
    [JsonPropertyName("originAccessControlId")]
    public string? OriginAccessControlId { get; set; }

    /// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdRef")]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdRef? OriginAccessControlIdRef { get; set; }

    /// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdSelector")]
    public V1beta1DistributionSpecForProviderOriginOriginAccessControlIdSelector? OriginAccessControlIdSelector { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }

    /// <summary>Optional element that causes CloudFront to request your content from a directory in your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originShield")]
    public IList<V1beta1DistributionSpecForProviderOriginOriginShield>? OriginShield { get; set; }

    /// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
    [JsonPropertyName("s3OriginConfig")]
    public IList<V1beta1DistributionSpecForProviderOriginS3OriginConfig>? S3OriginConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginGroupFailoverCriteria
{
    /// <summary>List of HTTP status codes for the origin group.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<double>? StatusCodes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginGroupMember
{
    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderOriginGroup
{
    /// <summary>The failover criteria for when to failover to the secondary origin.</summary>
    [JsonPropertyName("failoverCriteria")]
    public IList<V1beta1DistributionSpecForProviderOriginGroupFailoverCriteria>? FailoverCriteria { get; set; }

    /// <summary>Ordered member configuration blocks assigned to the origin group, where the first member is the primary origin. You must specify two members.</summary>
    [JsonPropertyName("member")]
    public IList<V1beta1DistributionSpecForProviderOriginGroupMember>? Member { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderRestrictionsGeoRestriction
{
    /// <summary>ISO 3166-1-alpha-2 codes for which you want CloudFront either to distribute your content (whitelist) or not distribute your content (blacklist). If the type is specified as none an empty array can be used.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Method that you want to use to restrict distribution of your content by country: none, whitelist, or blacklist.</summary>
    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderRestrictions
{
    /// <summary></summary>
    [JsonPropertyName("geoRestriction")]
    public IList<V1beta1DistributionSpecForProviderRestrictionsGeoRestriction>? GeoRestriction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProviderViewerCertificate
{
    /// <summary>ARN of the AWS Certificate Manager certificate that you wish to use with this distribution. Specify this, cloudfront_default_certificate, or iam_certificate_id.  The ACM certificate must be in  US-EAST-1.</summary>
    [JsonPropertyName("acmCertificateArn")]
    public string? AcmCertificateArn { get; set; }

    /// <summary>true if you want viewers to use HTTPS to request your objects and you're using the CloudFront domain name for your distribution. Specify this, acm_certificate_arn, or iam_certificate_id.</summary>
    [JsonPropertyName("cloudfrontDefaultCertificate")]
    public bool? CloudfrontDefaultCertificate { get; set; }

    /// <summary>IAM certificate identifier of the custom viewer certificate for this distribution if you are using a custom domain. Specify this, acm_certificate_arn, or cloudfront_default_certificate.</summary>
    [JsonPropertyName("iamCertificateId")]
    public string? IamCertificateId { get; set; }

    /// <summary>Minimum version of the SSL protocol that you want CloudFront to use for HTTPS connections. Can only be set if cloudfront_default_certificate = false. See all possible values in this table under "Security policy." Some examples include: TLSv1.2_2019 and TLSv1.2_2021. Default: TLSv1. NOTE: If you are using a custom certificate (specified with acm_certificate_arn or iam_certificate_id), and have specified sni-only in ssl_support_method, TLSv1 or later must be specified. If you have specified vip in ssl_support_method, only SSLv3 or TLSv1 can be specified. If you have specified cloudfront_default_certificate, TLSv1 must be specified.</summary>
    [JsonPropertyName("minimumProtocolVersion")]
    public string? MinimumProtocolVersion { get; set; }

    /// <summary>How you want CloudFront to serve HTTPS requests. One of vip, sni-only, or static-ip. Required if you specify acm_certificate_arn or iam_certificate_id. NOTE: vip causes CloudFront to use a dedicated IP address and may incur extra charges.</summary>
    [JsonPropertyName("sslSupportMethod")]
    public string? SslSupportMethod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecForProvider
{
    /// <summary>Extra CNAMEs (alternate domain names), if any, for this distribution.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>Any comments you want to include about the distribution.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Identifier of a continuous deployment policy. This argument should only be set on a production distribution. See the aws_cloudfront_continuous_deployment_policy resource for additional details.</summary>
    [JsonPropertyName("continuousDeploymentPolicyId")]
    public string? ContinuousDeploymentPolicyId { get; set; }

    /// <summary>One or more custom error response elements (multiples allowed).</summary>
    [JsonPropertyName("customErrorResponse")]
    public IList<V1beta1DistributionSpecForProviderCustomErrorResponse>? CustomErrorResponse { get; set; }

    /// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
    [JsonPropertyName("defaultCacheBehavior")]
    public IList<V1beta1DistributionSpecForProviderDefaultCacheBehavior>? DefaultCacheBehavior { get; set; }

    /// <summary>Object that you want CloudFront to return (for example, index.html) when an end user requests the root URL.</summary>
    [JsonPropertyName("defaultRootObject")]
    public string? DefaultRootObject { get; set; }

    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Maximum HTTP version to support on the distribution. Allowed values are http1.1, http2, http2and3 and http3. The default is http2.</summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }

    /// <summary>Whether the IPv6 is enabled for the distribution.</summary>
    [JsonPropertyName("isIpv6Enabled")]
    public bool? IsIpv6Enabled { get; set; }

    /// <summary>The logging configuration that controls how logs are written to your distribution (maximum one).</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1DistributionSpecForProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Ordered list of cache behaviors resource for this distribution. List from top to bottom in order of precedence. The topmost cache behavior will have precedence 0.</summary>
    [JsonPropertyName("orderedCacheBehavior")]
    public IList<V1beta1DistributionSpecForProviderOrderedCacheBehavior>? OrderedCacheBehavior { get; set; }

    /// <summary>One or more origins for this distribution (multiples allowed).</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta1DistributionSpecForProviderOrigin>? Origin { get; set; }

    /// <summary>One or more origin_group for this distribution (multiples allowed).</summary>
    [JsonPropertyName("originGroup")]
    public IList<V1beta1DistributionSpecForProviderOriginGroup>? OriginGroup { get; set; }

    /// <summary>Price class for this distribution. One of PriceClass_All, PriceClass_200, PriceClass_100.</summary>
    [JsonPropertyName("priceClass")]
    public string? PriceClass { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The restriction configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("restrictions")]
    public IList<V1beta1DistributionSpecForProviderRestrictions>? Restrictions { get; set; }

    /// <summary>If this is set, the distribution needs to be deleted manually afterwards. Default: false.</summary>
    [JsonPropertyName("retainOnDelete")]
    public bool? RetainOnDelete { get; set; }

    /// <summary>A Boolean that indicates whether this is a staging distribution. Defaults to false.</summary>
    [JsonPropertyName("staging")]
    public bool? Staging { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The SSL configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerCertificate")]
    public IList<V1beta1DistributionSpecForProviderViewerCertificate>? ViewerCertificate { get; set; }

    /// <summary>If enabled, the resource will wait for the distribution status to change from InProgress to Deployed. Setting this tofalse will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForDeployment")]
    public bool? WaitForDeployment { get; set; }

    /// <summary>Unique identifier that specifies the AWS WAF web ACL, if any, to associate with this distribution. To specify a web ACL created using the latest version of AWS WAF (WAFv2), use the ACL ARN, for example aws_wafv2_web_acl.example.arn. To specify a web ACL created using AWS WAF Classic, use the ACL ID, for example aws_waf_web_acl.example.id. The WAF Web ACL must exist in the WAF Global (CloudFront) region and the credentials configuring this argument must have waf:GetWebACL permissions assigned.</summary>
    [JsonPropertyName("webAclId")]
    public string? WebAclId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderCustomErrorResponse
{
    /// <summary>Minimum amount of time you want HTTP error codes to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated.</summary>
    [JsonPropertyName("errorCachingMinTtl")]
    public double? ErrorCachingMinTtl { get; set; }

    /// <summary>4xx or 5xx HTTP status code that you want to customize.</summary>
    [JsonPropertyName("errorCode")]
    public double? ErrorCode { get; set; }

    /// <summary>HTTP status code that you want CloudFront to return with the custom error page to the viewer.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Path of the custom error page (for example, /custom_404.html).</summary>
    [JsonPropertyName("responsePagePath")]
    public string? ResponsePagePath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderDefaultCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderDefaultCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1DistributionSpecInitProviderDefaultCacheBehaviorForwardedValuesCookies>? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderDefaultCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderDefaultCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderDefaultCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public IList<V1beta1DistributionSpecInitProviderDefaultCacheBehaviorForwardedValues>? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta1DistributionSpecInitProviderDefaultCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta1DistributionSpecInitProviderDefaultCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderLoggingConfig
{
    /// <summary>Amazon S3 bucket to store the access logs in, for example, myawslogbucket.s3.amazonaws.com.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether to include cookies in access logs (default: false).</summary>
    [JsonPropertyName("includeCookies")]
    public bool? IncludeCookies { get; set; }

    /// <summary>Prefix to the access log filenames for this distribution, for example, myprefix/.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorForwardedValuesCookies>? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnRef")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef? FunctionArnRef { get; set; }

    /// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnSelector")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector? FunctionArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector? LambdaArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrderedCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public IList<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorForwardedValues>? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta1DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>Pattern (for example, images/*.jpg) that specifies which requests you want this cache behavior to apply to.</summary>
    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginCustomHeader
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginCustomOriginConfig
{
    /// <summary>HTTP port the custom origin listens on.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>HTTPS port the custom origin listens on.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>Origin protocol policy to apply to your origin. One of http-only, https-only, or match-viewer.</summary>
    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>List of SSL/TLS protocols that CloudFront can use when connecting to your origin over HTTPS. Valid values: SSLv3, TLSv1, TLSv1.1, TLSv1.2. For more information, see Minimum Origin SSL Protocol in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originSslProtocols")]
    public IList<string>? OriginSslProtocols { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginOriginShield
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>AWS Region for Origin Shield. To specify a region, use the region code, not the region name. For example, specify the US East (Ohio) region as us-east-2.</summary>
    [JsonPropertyName("originShieldRegion")]
    public string? OriginShieldRegion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum>))]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum>))]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginS3OriginConfig
{
    /// <summary>The CloudFront origin access identity to associate with the origin.</summary>
    [JsonPropertyName("originAccessIdentity")]
    public string? OriginAccessIdentity { get; set; }

    /// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentityRef")]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRef? OriginAccessIdentityRef { get; set; }

    /// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentitySelector")]
    public V1beta1DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelector? OriginAccessIdentitySelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOrigin
{
    /// <summary>Number of times that CloudFront attempts to connect to the origin. Must be between 1-3. Defaults to 3.</summary>
    [JsonPropertyName("connectionAttempts")]
    public double? ConnectionAttempts { get; set; }

    /// <summary>Number of seconds that CloudFront waits when trying to establish a connection to the origin. Must be between 1-10. Defaults to 10.</summary>
    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    /// <summary>One or more sub-resources with name and value parameters that specify header data that will be sent to the origin (multiples allowed).</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta1DistributionSpecInitProviderOriginCustomHeader>? CustomHeader { get; set; }

    /// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
    [JsonPropertyName("customOriginConfig")]
    public IList<V1beta1DistributionSpecInitProviderOriginCustomOriginConfig>? CustomOriginConfig { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Unique identifier of a CloudFront origin access control for this origin.</summary>
    [JsonPropertyName("originAccessControlId")]
    public string? OriginAccessControlId { get; set; }

    /// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdRef")]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdRef? OriginAccessControlIdRef { get; set; }

    /// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdSelector")]
    public V1beta1DistributionSpecInitProviderOriginOriginAccessControlIdSelector? OriginAccessControlIdSelector { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }

    /// <summary>Optional element that causes CloudFront to request your content from a directory in your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originShield")]
    public IList<V1beta1DistributionSpecInitProviderOriginOriginShield>? OriginShield { get; set; }

    /// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
    [JsonPropertyName("s3OriginConfig")]
    public IList<V1beta1DistributionSpecInitProviderOriginS3OriginConfig>? S3OriginConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginGroupFailoverCriteria
{
    /// <summary>List of HTTP status codes for the origin group.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<double>? StatusCodes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginGroupMember
{
    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderOriginGroup
{
    /// <summary>The failover criteria for when to failover to the secondary origin.</summary>
    [JsonPropertyName("failoverCriteria")]
    public IList<V1beta1DistributionSpecInitProviderOriginGroupFailoverCriteria>? FailoverCriteria { get; set; }

    /// <summary>Ordered member configuration blocks assigned to the origin group, where the first member is the primary origin. You must specify two members.</summary>
    [JsonPropertyName("member")]
    public IList<V1beta1DistributionSpecInitProviderOriginGroupMember>? Member { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderRestrictionsGeoRestriction
{
    /// <summary>ISO 3166-1-alpha-2 codes for which you want CloudFront either to distribute your content (whitelist) or not distribute your content (blacklist). If the type is specified as none an empty array can be used.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Method that you want to use to restrict distribution of your content by country: none, whitelist, or blacklist.</summary>
    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderRestrictions
{
    /// <summary></summary>
    [JsonPropertyName("geoRestriction")]
    public IList<V1beta1DistributionSpecInitProviderRestrictionsGeoRestriction>? GeoRestriction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProviderViewerCertificate
{
    /// <summary>ARN of the AWS Certificate Manager certificate that you wish to use with this distribution. Specify this, cloudfront_default_certificate, or iam_certificate_id.  The ACM certificate must be in  US-EAST-1.</summary>
    [JsonPropertyName("acmCertificateArn")]
    public string? AcmCertificateArn { get; set; }

    /// <summary>true if you want viewers to use HTTPS to request your objects and you're using the CloudFront domain name for your distribution. Specify this, acm_certificate_arn, or iam_certificate_id.</summary>
    [JsonPropertyName("cloudfrontDefaultCertificate")]
    public bool? CloudfrontDefaultCertificate { get; set; }

    /// <summary>IAM certificate identifier of the custom viewer certificate for this distribution if you are using a custom domain. Specify this, acm_certificate_arn, or cloudfront_default_certificate.</summary>
    [JsonPropertyName("iamCertificateId")]
    public string? IamCertificateId { get; set; }

    /// <summary>Minimum version of the SSL protocol that you want CloudFront to use for HTTPS connections. Can only be set if cloudfront_default_certificate = false. See all possible values in this table under "Security policy." Some examples include: TLSv1.2_2019 and TLSv1.2_2021. Default: TLSv1. NOTE: If you are using a custom certificate (specified with acm_certificate_arn or iam_certificate_id), and have specified sni-only in ssl_support_method, TLSv1 or later must be specified. If you have specified vip in ssl_support_method, only SSLv3 or TLSv1 can be specified. If you have specified cloudfront_default_certificate, TLSv1 must be specified.</summary>
    [JsonPropertyName("minimumProtocolVersion")]
    public string? MinimumProtocolVersion { get; set; }

    /// <summary>How you want CloudFront to serve HTTPS requests. One of vip, sni-only, or static-ip. Required if you specify acm_certificate_arn or iam_certificate_id. NOTE: vip causes CloudFront to use a dedicated IP address and may incur extra charges.</summary>
    [JsonPropertyName("sslSupportMethod")]
    public string? SslSupportMethod { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecInitProvider
{
    /// <summary>Extra CNAMEs (alternate domain names), if any, for this distribution.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>Any comments you want to include about the distribution.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Identifier of a continuous deployment policy. This argument should only be set on a production distribution. See the aws_cloudfront_continuous_deployment_policy resource for additional details.</summary>
    [JsonPropertyName("continuousDeploymentPolicyId")]
    public string? ContinuousDeploymentPolicyId { get; set; }

    /// <summary>One or more custom error response elements (multiples allowed).</summary>
    [JsonPropertyName("customErrorResponse")]
    public IList<V1beta1DistributionSpecInitProviderCustomErrorResponse>? CustomErrorResponse { get; set; }

    /// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
    [JsonPropertyName("defaultCacheBehavior")]
    public IList<V1beta1DistributionSpecInitProviderDefaultCacheBehavior>? DefaultCacheBehavior { get; set; }

    /// <summary>Object that you want CloudFront to return (for example, index.html) when an end user requests the root URL.</summary>
    [JsonPropertyName("defaultRootObject")]
    public string? DefaultRootObject { get; set; }

    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Maximum HTTP version to support on the distribution. Allowed values are http1.1, http2, http2and3 and http3. The default is http2.</summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }

    /// <summary>Whether the IPv6 is enabled for the distribution.</summary>
    [JsonPropertyName("isIpv6Enabled")]
    public bool? IsIpv6Enabled { get; set; }

    /// <summary>The logging configuration that controls how logs are written to your distribution (maximum one).</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1DistributionSpecInitProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Ordered list of cache behaviors resource for this distribution. List from top to bottom in order of precedence. The topmost cache behavior will have precedence 0.</summary>
    [JsonPropertyName("orderedCacheBehavior")]
    public IList<V1beta1DistributionSpecInitProviderOrderedCacheBehavior>? OrderedCacheBehavior { get; set; }

    /// <summary>One or more origins for this distribution (multiples allowed).</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta1DistributionSpecInitProviderOrigin>? Origin { get; set; }

    /// <summary>One or more origin_group for this distribution (multiples allowed).</summary>
    [JsonPropertyName("originGroup")]
    public IList<V1beta1DistributionSpecInitProviderOriginGroup>? OriginGroup { get; set; }

    /// <summary>Price class for this distribution. One of PriceClass_All, PriceClass_200, PriceClass_100.</summary>
    [JsonPropertyName("priceClass")]
    public string? PriceClass { get; set; }

    /// <summary>The restriction configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("restrictions")]
    public IList<V1beta1DistributionSpecInitProviderRestrictions>? Restrictions { get; set; }

    /// <summary>If this is set, the distribution needs to be deleted manually afterwards. Default: false.</summary>
    [JsonPropertyName("retainOnDelete")]
    public bool? RetainOnDelete { get; set; }

    /// <summary>A Boolean that indicates whether this is a staging distribution. Defaults to false.</summary>
    [JsonPropertyName("staging")]
    public bool? Staging { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The SSL configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerCertificate")]
    public IList<V1beta1DistributionSpecInitProviderViewerCertificate>? ViewerCertificate { get; set; }

    /// <summary>If enabled, the resource will wait for the distribution status to change from InProgress to Deployed. Setting this tofalse will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForDeployment")]
    public bool? WaitForDeployment { get; set; }

    /// <summary>Unique identifier that specifies the AWS WAF web ACL, if any, to associate with this distribution. To specify a web ACL created using the latest version of AWS WAF (WAFv2), use the ACL ARN, for example aws_wafv2_web_acl.example.arn. To specify a web ACL created using AWS WAF Classic, use the ACL ID, for example aws_waf_web_acl.example.id. The WAF Web ACL must exist in the WAF Global (CloudFront) region and the credentials configuring this argument must have waf:GetWebACL permissions assigned.</summary>
    [JsonPropertyName("webAclId")]
    public string? WebAclId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DistributionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DistributionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DistributionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DistributionSpec defines the desired state of Distribution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DistributionSpecDeletionPolicyEnum>))]
    public V1beta1DistributionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DistributionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DistributionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DistributionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DistributionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DistributionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DistributionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderCustomErrorResponse
{
    /// <summary>Minimum amount of time you want HTTP error codes to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated.</summary>
    [JsonPropertyName("errorCachingMinTtl")]
    public double? ErrorCachingMinTtl { get; set; }

    /// <summary>4xx or 5xx HTTP status code that you want to customize.</summary>
    [JsonPropertyName("errorCode")]
    public double? ErrorCode { get; set; }

    /// <summary>HTTP status code that you want CloudFront to return with the custom error page to the viewer.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Path of the custom error page (for example, /custom_404.html).</summary>
    [JsonPropertyName("responsePagePath")]
    public string? ResponsePagePath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderDefaultCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderDefaultCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1DistributionStatusAtProviderDefaultCacheBehaviorForwardedValuesCookies>? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderDefaultCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderDefaultCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderDefaultCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public IList<V1beta1DistributionStatusAtProviderDefaultCacheBehaviorForwardedValues>? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta1DistributionStatusAtProviderDefaultCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta1DistributionStatusAtProviderDefaultCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderLoggingConfig
{
    /// <summary>Amazon S3 bucket to store the access logs in, for example, myawslogbucket.s3.amazonaws.com.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether to include cookies in access logs (default: false).</summary>
    [JsonPropertyName("includeCookies")]
    public bool? IncludeCookies { get; set; }

    /// <summary>Prefix to the access log filenames for this distribution, for example, myprefix/.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOrderedCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOrderedCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1DistributionStatusAtProviderOrderedCacheBehaviorForwardedValuesCookies>? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOrderedCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOrderedCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOrderedCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public IList<V1beta1DistributionStatusAtProviderOrderedCacheBehaviorForwardedValues>? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta1DistributionStatusAtProviderOrderedCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta1DistributionStatusAtProviderOrderedCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>Pattern (for example, images/*.jpg) that specifies which requests you want this cache behavior to apply to.</summary>
    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOriginCustomHeader
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOriginCustomOriginConfig
{
    /// <summary>HTTP port the custom origin listens on.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>HTTPS port the custom origin listens on.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>Origin protocol policy to apply to your origin. One of http-only, https-only, or match-viewer.</summary>
    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>List of SSL/TLS protocols that CloudFront can use when connecting to your origin over HTTPS. Valid values: SSLv3, TLSv1, TLSv1.1, TLSv1.2. For more information, see Minimum Origin SSL Protocol in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originSslProtocols")]
    public IList<string>? OriginSslProtocols { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOriginOriginShield
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>AWS Region for Origin Shield. To specify a region, use the region code, not the region name. For example, specify the US East (Ohio) region as us-east-2.</summary>
    [JsonPropertyName("originShieldRegion")]
    public string? OriginShieldRegion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOriginS3OriginConfig
{
    /// <summary>The CloudFront origin access identity to associate with the origin.</summary>
    [JsonPropertyName("originAccessIdentity")]
    public string? OriginAccessIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOrigin
{
    /// <summary>Number of times that CloudFront attempts to connect to the origin. Must be between 1-3. Defaults to 3.</summary>
    [JsonPropertyName("connectionAttempts")]
    public double? ConnectionAttempts { get; set; }

    /// <summary>Number of seconds that CloudFront waits when trying to establish a connection to the origin. Must be between 1-10. Defaults to 10.</summary>
    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    /// <summary>One or more sub-resources with name and value parameters that specify header data that will be sent to the origin (multiples allowed).</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta1DistributionStatusAtProviderOriginCustomHeader>? CustomHeader { get; set; }

    /// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
    [JsonPropertyName("customOriginConfig")]
    public IList<V1beta1DistributionStatusAtProviderOriginCustomOriginConfig>? CustomOriginConfig { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Unique identifier of a CloudFront origin access control for this origin.</summary>
    [JsonPropertyName("originAccessControlId")]
    public string? OriginAccessControlId { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }

    /// <summary>Optional element that causes CloudFront to request your content from a directory in your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originShield")]
    public IList<V1beta1DistributionStatusAtProviderOriginOriginShield>? OriginShield { get; set; }

    /// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
    [JsonPropertyName("s3OriginConfig")]
    public IList<V1beta1DistributionStatusAtProviderOriginS3OriginConfig>? S3OriginConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOriginGroupFailoverCriteria
{
    /// <summary>List of HTTP status codes for the origin group.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<double>? StatusCodes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOriginGroupMember
{
    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderOriginGroup
{
    /// <summary>The failover criteria for when to failover to the secondary origin.</summary>
    [JsonPropertyName("failoverCriteria")]
    public IList<V1beta1DistributionStatusAtProviderOriginGroupFailoverCriteria>? FailoverCriteria { get; set; }

    /// <summary>Ordered member configuration blocks assigned to the origin group, where the first member is the primary origin. You must specify two members.</summary>
    [JsonPropertyName("member")]
    public IList<V1beta1DistributionStatusAtProviderOriginGroupMember>? Member { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderRestrictionsGeoRestriction
{
    /// <summary>ISO 3166-1-alpha-2 codes for which you want CloudFront either to distribute your content (whitelist) or not distribute your content (blacklist). If the type is specified as none an empty array can be used.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Method that you want to use to restrict distribution of your content by country: none, whitelist, or blacklist.</summary>
    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderRestrictions
{
    /// <summary></summary>
    [JsonPropertyName("geoRestriction")]
    public IList<V1beta1DistributionStatusAtProviderRestrictionsGeoRestriction>? GeoRestriction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderTrustedKeyGroupsItems
{
    /// <summary>ID of the key group that contains the public keys.</summary>
    [JsonPropertyName("keyGroupId")]
    public string? KeyGroupId { get; set; }

    /// <summary>Set of CloudFront key pair IDs.</summary>
    [JsonPropertyName("keyPairIds")]
    public IList<string>? KeyPairIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderTrustedKeyGroups
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>List of nested attributes for each key group.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1DistributionStatusAtProviderTrustedKeyGroupsItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderTrustedSignersItems
{
    /// <summary>AWS account ID or self</summary>
    [JsonPropertyName("awsAccountNumber")]
    public string? AwsAccountNumber { get; set; }

    /// <summary>Set of CloudFront key pair IDs.</summary>
    [JsonPropertyName("keyPairIds")]
    public IList<string>? KeyPairIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderTrustedSigners
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>List of nested attributes for each key group.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1DistributionStatusAtProviderTrustedSignersItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProviderViewerCertificate
{
    /// <summary>ARN of the AWS Certificate Manager certificate that you wish to use with this distribution. Specify this, cloudfront_default_certificate, or iam_certificate_id.  The ACM certificate must be in  US-EAST-1.</summary>
    [JsonPropertyName("acmCertificateArn")]
    public string? AcmCertificateArn { get; set; }

    /// <summary>true if you want viewers to use HTTPS to request your objects and you're using the CloudFront domain name for your distribution. Specify this, acm_certificate_arn, or iam_certificate_id.</summary>
    [JsonPropertyName("cloudfrontDefaultCertificate")]
    public bool? CloudfrontDefaultCertificate { get; set; }

    /// <summary>IAM certificate identifier of the custom viewer certificate for this distribution if you are using a custom domain. Specify this, acm_certificate_arn, or cloudfront_default_certificate.</summary>
    [JsonPropertyName("iamCertificateId")]
    public string? IamCertificateId { get; set; }

    /// <summary>Minimum version of the SSL protocol that you want CloudFront to use for HTTPS connections. Can only be set if cloudfront_default_certificate = false. See all possible values in this table under "Security policy." Some examples include: TLSv1.2_2019 and TLSv1.2_2021. Default: TLSv1. NOTE: If you are using a custom certificate (specified with acm_certificate_arn or iam_certificate_id), and have specified sni-only in ssl_support_method, TLSv1 or later must be specified. If you have specified vip in ssl_support_method, only SSLv3 or TLSv1 can be specified. If you have specified cloudfront_default_certificate, TLSv1 must be specified.</summary>
    [JsonPropertyName("minimumProtocolVersion")]
    public string? MinimumProtocolVersion { get; set; }

    /// <summary>How you want CloudFront to serve HTTPS requests. One of vip, sni-only, or static-ip. Required if you specify acm_certificate_arn or iam_certificate_id. NOTE: vip causes CloudFront to use a dedicated IP address and may incur extra charges.</summary>
    [JsonPropertyName("sslSupportMethod")]
    public string? SslSupportMethod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusAtProvider
{
    /// <summary>Extra CNAMEs (alternate domain names), if any, for this distribution.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>ARN for the distribution. For example: arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5, where 123456789012 is your AWS account ID.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Internal value used by CloudFront to allow future updates to the distribution configuration.</summary>
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>Any comments you want to include about the distribution.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Identifier of a continuous deployment policy. This argument should only be set on a production distribution. See the aws_cloudfront_continuous_deployment_policy resource for additional details.</summary>
    [JsonPropertyName("continuousDeploymentPolicyId")]
    public string? ContinuousDeploymentPolicyId { get; set; }

    /// <summary>One or more custom error response elements (multiples allowed).</summary>
    [JsonPropertyName("customErrorResponse")]
    public IList<V1beta1DistributionStatusAtProviderCustomErrorResponse>? CustomErrorResponse { get; set; }

    /// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
    [JsonPropertyName("defaultCacheBehavior")]
    public IList<V1beta1DistributionStatusAtProviderDefaultCacheBehavior>? DefaultCacheBehavior { get; set; }

    /// <summary>Object that you want CloudFront to return (for example, index.html) when an end user requests the root URL.</summary>
    [JsonPropertyName("defaultRootObject")]
    public string? DefaultRootObject { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Current version of the distribution's information. For example: E2QWRUHAPOMQZL.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>CloudFront Route 53 zone ID that can be used to route an Alias Resource Record Set to. This attribute is simply an alias for the zone ID Z2FDTNDATAQYW2.</summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>Maximum HTTP version to support on the distribution. Allowed values are http1.1, http2, http2and3 and http3. The default is http2.</summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }

    /// <summary>Identifier for the distribution. For example: EDFDVBD632BHDS5.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Number of invalidation batches currently in progress.</summary>
    [JsonPropertyName("inProgressValidationBatches")]
    public double? InProgressValidationBatches { get; set; }

    /// <summary>Whether the IPv6 is enabled for the distribution.</summary>
    [JsonPropertyName("isIpv6Enabled")]
    public bool? IsIpv6Enabled { get; set; }

    /// <summary>Date and time the distribution was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>The logging configuration that controls how logs are written to your distribution (maximum one).</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1DistributionStatusAtProviderLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Ordered list of cache behaviors resource for this distribution. List from top to bottom in order of precedence. The topmost cache behavior will have precedence 0.</summary>
    [JsonPropertyName("orderedCacheBehavior")]
    public IList<V1beta1DistributionStatusAtProviderOrderedCacheBehavior>? OrderedCacheBehavior { get; set; }

    /// <summary>One or more origins for this distribution (multiples allowed).</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta1DistributionStatusAtProviderOrigin>? Origin { get; set; }

    /// <summary>One or more origin_group for this distribution (multiples allowed).</summary>
    [JsonPropertyName("originGroup")]
    public IList<V1beta1DistributionStatusAtProviderOriginGroup>? OriginGroup { get; set; }

    /// <summary>Price class for this distribution. One of PriceClass_All, PriceClass_200, PriceClass_100.</summary>
    [JsonPropertyName("priceClass")]
    public string? PriceClass { get; set; }

    /// <summary>The restriction configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("restrictions")]
    public IList<V1beta1DistributionStatusAtProviderRestrictions>? Restrictions { get; set; }

    /// <summary>If this is set, the distribution needs to be deleted manually afterwards. Default: false.</summary>
    [JsonPropertyName("retainOnDelete")]
    public bool? RetainOnDelete { get; set; }

    /// <summary>A Boolean that indicates whether this is a staging distribution. Defaults to false.</summary>
    [JsonPropertyName("staging")]
    public bool? Staging { get; set; }

    /// <summary>Current status of the distribution. Deployed if the distribution's information is fully propagated throughout the Amazon CloudFront system.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<V1beta1DistributionStatusAtProviderTrustedKeyGroups>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<V1beta1DistributionStatusAtProviderTrustedSigners>? TrustedSigners { get; set; }

    /// <summary>The SSL configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerCertificate")]
    public IList<V1beta1DistributionStatusAtProviderViewerCertificate>? ViewerCertificate { get; set; }

    /// <summary>If enabled, the resource will wait for the distribution status to change from InProgress to Deployed. Setting this tofalse will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForDeployment")]
    public bool? WaitForDeployment { get; set; }

    /// <summary>Unique identifier that specifies the AWS WAF web ACL, if any, to associate with this distribution. To specify a web ACL created using the latest version of AWS WAF (WAFv2), use the ACL ARN, for example aws_wafv2_web_acl.example.arn. To specify a web ACL created using AWS WAF Classic, use the ACL ID, for example aws_waf_web_acl.example.id. The WAF Web ACL must exist in the WAF Global (CloudFront) region and the credentials configuring this argument must have waf:GetWebACL permissions assigned.</summary>
    [JsonPropertyName("webAclId")]
    public string? WebAclId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatusConditions
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

/// <summary>DistributionStatus defines the observed state of Distribution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DistributionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DistributionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DistributionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Distribution is the Schema for the Distributions API. Provides a CloudFront web distribution resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Distribution : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DistributionSpec>, IStatus<V1beta1DistributionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Distribution";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "distributions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DistributionSpec defines the desired state of Distribution</summary>
    [JsonPropertyName("spec")]
    public V1beta1DistributionSpec Spec { get; set; }

    /// <summary>DistributionStatus defines the observed state of Distribution.</summary>
    [JsonPropertyName("status")]
    public V1beta1DistributionStatus? Status { get; set; }
}