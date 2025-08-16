using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.upbound.io;
/// <summary>ResponseHeadersPolicy is the Schema for the ResponseHeadersPolicys API. Provides a CloudFront response headers policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResponseHeadersPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ResponseHeadersPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResponseHeadersPolicyList";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "responseheaderspolicies";
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
    public IList<V1beta1ResponseHeadersPolicy> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowMethods
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowOrigins
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlExposeHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderCorsConfig
{
    /// <summary>A Boolean value that CloudFront uses as the value for the Access-Control-Allow-Credentials HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowHeaders>? AccessControlAllowHeaders { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowMethods>? AccessControlAllowMethods { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowOrigins")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowOrigins>? AccessControlAllowOrigins { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderCorsConfigAccessControlExposeHeaders>? AccessControlExposeHeaders { get; set; }

    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>A Boolean value that determines how CloudFront behaves for the HTTP response header.</summary>
    [JsonPropertyName("originOverride")]
    public bool? OriginOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderCustomHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>The value for the HTTP response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderCustomHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderCustomHeadersConfigItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderRemoveHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderRemoveHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderRemoveHeadersConfigItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentSecurityPolicy
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentTypeOptions
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigFrameOptions
{
    /// <summary>The value of the X-Frame-Options HTTP response header. Valid values: DENY | SAMEORIGIN</summary>
    [JsonPropertyName("frameOption")]
    public string? FrameOption { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigReferrerPolicy
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigStrictTransportSecurity
{
    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>Whether CloudFront includes the includeSubDomains directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("includeSubdomains")]
    public bool? IncludeSubdomains { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Whether CloudFront includes the preload directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigXssProtection
{
    /// <summary>Whether CloudFront includes the mode=block directive in the X-XSS-Protection header.</summary>
    [JsonPropertyName("modeBlock")]
    public bool? ModeBlock { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>A Boolean value that determines the value of the X-XSS-Protection HTTP response header. When this setting is true, the value of the X-XSS-Protection header is 1. When this setting is false, the value of the X-XSS-Protection header is 0.</summary>
    [JsonPropertyName("protection")]
    public bool? Protection { get; set; }

    /// <summary>A reporting URI, which CloudFront uses as the value of the report directive in the X-XSS-Protection header. You cannot specify a report_uri when mode_block is true.</summary>
    [JsonPropertyName("reportUri")]
    public string? ReportUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfig
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentSecurityPolicy>? ContentSecurityPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
    [JsonPropertyName("contentTypeOptions")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentTypeOptions>? ContentTypeOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
    [JsonPropertyName("frameOptions")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigFrameOptions>? FrameOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigReferrerPolicy>? ReferrerPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
    [JsonPropertyName("strictTransportSecurity")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigStrictTransportSecurity>? StrictTransportSecurity { get; set; }

    /// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
    [JsonPropertyName("xssProtection")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfigXssProtection>? XssProtection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProviderServerTimingHeadersConfig
{
    /// <summary>A Whether CloudFront adds the Server-Timing header to HTTP responses that it sends in response to requests that match a cache behavior that's associated with this response headers policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A number 0–100 (inclusive) that specifies the percentage of responses that you want CloudFront to add the Server-Timing header to. Valid range: Minimum value of 0.0. Maximum value of 100.0.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecForProvider
{
    /// <summary>A comment to describe the response headers policy. The comment cannot be longer than 128 characters.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
    [JsonPropertyName("corsConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderCorsConfig>? CorsConfig { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
    [JsonPropertyName("customHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderCustomHeadersConfig>? CustomHeadersConfig { get; set; }

    /// <summary>A unique name to identify the response headers policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
    [JsonPropertyName("removeHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderRemoveHeadersConfig>? RemoveHeadersConfig { get; set; }

    /// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
    [JsonPropertyName("securityHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderSecurityHeadersConfig>? SecurityHeadersConfig { get; set; }

    /// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
    [JsonPropertyName("serverTimingHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecForProviderServerTimingHeadersConfig>? ServerTimingHeadersConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowMethods
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowOrigins
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlExposeHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderCorsConfig
{
    /// <summary>A Boolean value that CloudFront uses as the value for the Access-Control-Allow-Credentials HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowHeaders>? AccessControlAllowHeaders { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowMethods>? AccessControlAllowMethods { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowOrigins")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowOrigins>? AccessControlAllowOrigins { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlExposeHeaders>? AccessControlExposeHeaders { get; set; }

    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>A Boolean value that determines how CloudFront behaves for the HTTP response header.</summary>
    [JsonPropertyName("originOverride")]
    public bool? OriginOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderCustomHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>The value for the HTTP response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderCustomHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderCustomHeadersConfigItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderRemoveHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderRemoveHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderRemoveHeadersConfigItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentSecurityPolicy
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentTypeOptions
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigFrameOptions
{
    /// <summary>The value of the X-Frame-Options HTTP response header. Valid values: DENY | SAMEORIGIN</summary>
    [JsonPropertyName("frameOption")]
    public string? FrameOption { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigReferrerPolicy
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigStrictTransportSecurity
{
    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>Whether CloudFront includes the includeSubDomains directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("includeSubdomains")]
    public bool? IncludeSubdomains { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Whether CloudFront includes the preload directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigXssProtection
{
    /// <summary>Whether CloudFront includes the mode=block directive in the X-XSS-Protection header.</summary>
    [JsonPropertyName("modeBlock")]
    public bool? ModeBlock { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>A Boolean value that determines the value of the X-XSS-Protection HTTP response header. When this setting is true, the value of the X-XSS-Protection header is 1. When this setting is false, the value of the X-XSS-Protection header is 0.</summary>
    [JsonPropertyName("protection")]
    public bool? Protection { get; set; }

    /// <summary>A reporting URI, which CloudFront uses as the value of the report directive in the X-XSS-Protection header. You cannot specify a report_uri when mode_block is true.</summary>
    [JsonPropertyName("reportUri")]
    public string? ReportUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfig
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentSecurityPolicy>? ContentSecurityPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
    [JsonPropertyName("contentTypeOptions")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentTypeOptions>? ContentTypeOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
    [JsonPropertyName("frameOptions")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigFrameOptions>? FrameOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigReferrerPolicy>? ReferrerPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
    [JsonPropertyName("strictTransportSecurity")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigStrictTransportSecurity>? StrictTransportSecurity { get; set; }

    /// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
    [JsonPropertyName("xssProtection")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigXssProtection>? XssProtection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProviderServerTimingHeadersConfig
{
    /// <summary>A Whether CloudFront adds the Server-Timing header to HTTP responses that it sends in response to requests that match a cache behavior that's associated with this response headers policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A number 0–100 (inclusive) that specifies the percentage of responses that you want CloudFront to add the Server-Timing header to. Valid range: Minimum value of 0.0. Maximum value of 100.0.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecInitProvider
{
    /// <summary>A comment to describe the response headers policy. The comment cannot be longer than 128 characters.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
    [JsonPropertyName("corsConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderCorsConfig>? CorsConfig { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
    [JsonPropertyName("customHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderCustomHeadersConfig>? CustomHeadersConfig { get; set; }

    /// <summary>A unique name to identify the response headers policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
    [JsonPropertyName("removeHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderRemoveHeadersConfig>? RemoveHeadersConfig { get; set; }

    /// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
    [JsonPropertyName("securityHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderSecurityHeadersConfig>? SecurityHeadersConfig { get; set; }

    /// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
    [JsonPropertyName("serverTimingHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicySpecInitProviderServerTimingHeadersConfig>? ServerTimingHeadersConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecProviderConfigRefPolicy
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
public partial class V1beta1ResponseHeadersPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResponseHeadersPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ResponseHeadersPolicySpec defines the desired state of ResponseHeadersPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ResponseHeadersPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ResponseHeadersPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResponseHeadersPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResponseHeadersPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowMethods
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowOrigins
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlExposeHeaders
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfig
{
    /// <summary>A Boolean value that CloudFront uses as the value for the Access-Control-Allow-Credentials HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowHeaders>? AccessControlAllowHeaders { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowMethods>? AccessControlAllowMethods { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowOrigins")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowOrigins>? AccessControlAllowOrigins { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlExposeHeaders>? AccessControlExposeHeaders { get; set; }

    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>A Boolean value that determines how CloudFront behaves for the HTTP response header.</summary>
    [JsonPropertyName("originOverride")]
    public bool? OriginOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderCustomHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>The value for the HTTP response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderCustomHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderCustomHeadersConfigItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfig
{
    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfigItems>? Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentSecurityPolicy
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentTypeOptions
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigFrameOptions
{
    /// <summary>The value of the X-Frame-Options HTTP response header. Valid values: DENY | SAMEORIGIN</summary>
    [JsonPropertyName("frameOption")]
    public string? FrameOption { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigReferrerPolicy
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigStrictTransportSecurity
{
    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>Whether CloudFront includes the includeSubDomains directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("includeSubdomains")]
    public bool? IncludeSubdomains { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Whether CloudFront includes the preload directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigXssProtection
{
    /// <summary>Whether CloudFront includes the mode=block directive in the X-XSS-Protection header.</summary>
    [JsonPropertyName("modeBlock")]
    public bool? ModeBlock { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>A Boolean value that determines the value of the X-XSS-Protection HTTP response header. When this setting is true, the value of the X-XSS-Protection header is 1. When this setting is false, the value of the X-XSS-Protection header is 0.</summary>
    [JsonPropertyName("protection")]
    public bool? Protection { get; set; }

    /// <summary>A reporting URI, which CloudFront uses as the value of the report directive in the X-XSS-Protection header. You cannot specify a report_uri when mode_block is true.</summary>
    [JsonPropertyName("reportUri")]
    public string? ReportUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfig
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentSecurityPolicy>? ContentSecurityPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
    [JsonPropertyName("contentTypeOptions")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentTypeOptions>? ContentTypeOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
    [JsonPropertyName("frameOptions")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigFrameOptions>? FrameOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigReferrerPolicy>? ReferrerPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
    [JsonPropertyName("strictTransportSecurity")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigStrictTransportSecurity>? StrictTransportSecurity { get; set; }

    /// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
    [JsonPropertyName("xssProtection")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigXssProtection>? XssProtection { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProviderServerTimingHeadersConfig
{
    /// <summary>A Whether CloudFront adds the Server-Timing header to HTTP responses that it sends in response to requests that match a cache behavior that's associated with this response headers policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A number 0–100 (inclusive) that specifies the percentage of responses that you want CloudFront to add the Server-Timing header to. Valid range: Minimum value of 0.0. Maximum value of 100.0.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusAtProvider
{
    /// <summary>The response headers policy ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A comment to describe the response headers policy. The comment cannot be longer than 128 characters.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
    [JsonPropertyName("corsConfig")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderCorsConfig>? CorsConfig { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
    [JsonPropertyName("customHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderCustomHeadersConfig>? CustomHeadersConfig { get; set; }

    /// <summary>The current version of the response headers policy.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The identifier for the response headers policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A unique name to identify the response headers policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
    [JsonPropertyName("removeHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfig>? RemoveHeadersConfig { get; set; }

    /// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
    [JsonPropertyName("securityHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfig>? SecurityHeadersConfig { get; set; }

    /// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
    [JsonPropertyName("serverTimingHeadersConfig")]
    public IList<V1beta1ResponseHeadersPolicyStatusAtProviderServerTimingHeadersConfig>? ServerTimingHeadersConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatusConditions
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

/// <summary>ResponseHeadersPolicyStatus defines the observed state of ResponseHeadersPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResponseHeadersPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ResponseHeadersPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResponseHeadersPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResponseHeadersPolicy is the Schema for the ResponseHeadersPolicys API. Provides a CloudFront response headers policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResponseHeadersPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResponseHeadersPolicySpec>, IStatus<V1beta1ResponseHeadersPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResponseHeadersPolicy";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "responseheaderspolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResponseHeadersPolicySpec defines the desired state of ResponseHeadersPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1ResponseHeadersPolicySpec Spec { get; set; }

    /// <summary>ResponseHeadersPolicyStatus defines the observed state of ResponseHeadersPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResponseHeadersPolicyStatus? Status { get; set; }
}