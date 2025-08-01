using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for cookie_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies>? Cookies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig
{
    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for header_behavior are none and whitelist.</summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary>Object contains a list of header names. See Items for more information.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders>? Headers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
{
    /// <summary>Whether URL query strings in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for query_string_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings>? QueryStrings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOrigin
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public IList<V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig>? CookiesConfig { get; set; }

    /// <summary>Flag determines whether the Accept-Encoding HTTP header is included in the cache key and in requests that CloudFront sends to the origin.</summary>
    [JsonPropertyName("enableAcceptEncodingBrotli")]
    public bool? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>Whether the Accept-Encoding HTTP header is included in the cache key and in requests sent to the origin by CloudFront.</summary>
    [JsonPropertyName("enableAcceptEncodingGzip")]
    public bool? EnableAcceptEncodingGzip { get; set; }

    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public IList<V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig>? HeadersConfig { get; set; }

    /// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public IList<V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig>? QueryStringsConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecForProvider
{
    /// <summary>Description for the cache policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Amount of time, in seconds, that objects are allowed to remain in the CloudFront cache before CloudFront sends a new request to the origin server to check if the object has been updated.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Maximum amount of time, in seconds, that objects stay in the CloudFront cache before CloudFront sends another request to the origin to see if the object has been updated.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time, in seconds, that objects should remain in the CloudFront cache before a new request is sent to the origin to check for updates.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique name used to identify the cache policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
    [JsonPropertyName("parametersInCacheKeyAndForwardedToOrigin")]
    public IList<V1beta1CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOrigin>? ParametersInCacheKeyAndForwardedToOrigin { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for cookie_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies>? Cookies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig
{
    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for header_behavior are none and whitelist.</summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary>Object contains a list of header names. See Items for more information.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders>? Headers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
{
    /// <summary>Whether URL query strings in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for query_string_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings>? QueryStrings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOrigin
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public IList<V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig>? CookiesConfig { get; set; }

    /// <summary>Flag determines whether the Accept-Encoding HTTP header is included in the cache key and in requests that CloudFront sends to the origin.</summary>
    [JsonPropertyName("enableAcceptEncodingBrotli")]
    public bool? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>Whether the Accept-Encoding HTTP header is included in the cache key and in requests sent to the origin by CloudFront.</summary>
    [JsonPropertyName("enableAcceptEncodingGzip")]
    public bool? EnableAcceptEncodingGzip { get; set; }

    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public IList<V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig>? HeadersConfig { get; set; }

    /// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public IList<V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig>? QueryStringsConfig { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecInitProvider
{
    /// <summary>Description for the cache policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Amount of time, in seconds, that objects are allowed to remain in the CloudFront cache before CloudFront sends a new request to the origin server to check if the object has been updated.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Maximum amount of time, in seconds, that objects stay in the CloudFront cache before CloudFront sends another request to the origin to see if the object has been updated.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time, in seconds, that objects should remain in the CloudFront cache before a new request is sent to the origin to check for updates.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique name used to identify the cache policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
    [JsonPropertyName("parametersInCacheKeyAndForwardedToOrigin")]
    public IList<V1beta1CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOrigin>? ParametersInCacheKeyAndForwardedToOrigin { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecProviderConfigRefPolicy
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
public partial class V1beta1CachePolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CachePolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CachePolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1CachePolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CachePolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CachePolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CachePolicySpec defines the desired state of CachePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CachePolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CachePolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CachePolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CachePolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CachePolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for cookie_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
    [JsonPropertyName("cookies")]
    public IList<V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies>? Cookies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig
{
    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for header_behavior are none and whitelist.</summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary>Object contains a list of header names. See Items for more information.</summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders>? Headers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
{
    /// <summary>Whether URL query strings in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for query_string_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings>? QueryStrings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOrigin
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public IList<V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig>? CookiesConfig { get; set; }

    /// <summary>Flag determines whether the Accept-Encoding HTTP header is included in the cache key and in requests that CloudFront sends to the origin.</summary>
    [JsonPropertyName("enableAcceptEncodingBrotli")]
    public bool? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>Whether the Accept-Encoding HTTP header is included in the cache key and in requests sent to the origin by CloudFront.</summary>
    [JsonPropertyName("enableAcceptEncodingGzip")]
    public bool? EnableAcceptEncodingGzip { get; set; }

    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public IList<V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig>? HeadersConfig { get; set; }

    /// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public IList<V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig>? QueryStringsConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusAtProvider
{
    /// <summary>The cache policy ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description for the cache policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Amount of time, in seconds, that objects are allowed to remain in the CloudFront cache before CloudFront sends a new request to the origin server to check if the object has been updated.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Current version of the cache policy.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Identifier for the cache policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Maximum amount of time, in seconds, that objects stay in the CloudFront cache before CloudFront sends another request to the origin to see if the object has been updated.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time, in seconds, that objects should remain in the CloudFront cache before a new request is sent to the origin to check for updates.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique name used to identify the cache policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
    [JsonPropertyName("parametersInCacheKeyAndForwardedToOrigin")]
    public IList<V1beta1CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOrigin>? ParametersInCacheKeyAndForwardedToOrigin { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatusConditions
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

/// <summary>CachePolicyStatus defines the observed state of CachePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CachePolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CachePolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CachePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CachePolicy is the Schema for the CachePolicys API. Use the</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CachePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CachePolicySpec>, IStatus<V1beta1CachePolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CachePolicy";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "cachepolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CachePolicySpec defines the desired state of CachePolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1CachePolicySpec Spec { get; set; }

    /// <summary>CachePolicyStatus defines the observed state of CachePolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1CachePolicyStatus? Status { get; set; }
}

/// <summary>CachePolicy is the Schema for the CachePolicys API. Use the</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CachePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CachePolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CachePolicyList";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "cachepolicies";
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
    public IList<V1beta1CachePolicy> Items { get; set; }
}