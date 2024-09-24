using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
public enum V1beta1EndpointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleCookiesCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleDeviceCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleHttpVersionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRulePostArgCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleQueryStringCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleRemoteAddressCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleRequestBodyCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleRequestHeaderCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleRequestMethodCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleRequestSchemeCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleRequestUriCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleUrlFileExtensionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleUrlFileNameCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleUrlPathCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleCacheExpirationAction>? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleCacheKeyQueryStringAction>? CacheKeyQueryStringAction { get; set; }

    /// <summary>A cookies_condition block as defined above.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A device_condition block as defined below.</summary>
    [JsonPropertyName("deviceCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleDeviceCondition>? DeviceCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>The Name which should be used for this Delivery Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order used for this rule. The order values should be sequential and begin at 1.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>A post_arg_condition block as defined below.</summary>
    [JsonPropertyName("postArgCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRulePostArgCondition>? PostArgCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_file_name_condition block as defined below.</summary>
    [JsonPropertyName("urlFileNameCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleUrlFileNameCondition>? UrlFileNameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleUrlPathCondition>? UrlPathCondition { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRuleUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGeoFilter
{
    /// <summary>The Action of the Geo Filter. Possible values include Allow and Block.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A List of two letter country codes (e.g. US, GB) to be associated with this Geo Filter.</summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>The relative path applicable to geo filter.</summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGlobalDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGlobalDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGlobalDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGlobalDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGlobalDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGlobalDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderGlobalDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public IList<V1beta1EndpointSpecForProviderGlobalDeliveryRuleCacheExpirationAction>? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public IList<V1beta1EndpointSpecForProviderGlobalDeliveryRuleCacheKeyQueryStringAction>? CacheKeyQueryStringAction { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta1EndpointSpecForProviderGlobalDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta1EndpointSpecForProviderGlobalDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1EndpointSpecForProviderGlobalDeliveryRuleUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1EndpointSpecForProviderGlobalDeliveryRuleUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProviderOrigin
{
    /// <summary>A string that determines the hostname/IP address of the origin server. This string can be a domain name, Storage Account endpoint, Web App endpoint, IPv4 address or IPv6 address. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The HTTP port of the origin. Defaults to 80. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS port of the origin. Defaults to 443. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public enum V1beta1EndpointSpecForProviderProfileNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EndpointSpecForProviderProfileNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EndpointSpecForProviderProfileNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderProfileNameRefPolicyResolutionEnum>))]
    public V1beta1EndpointSpecForProviderProfileNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderProfileNameRefPolicyResolveEnum>))]
    public V1beta1EndpointSpecForProviderProfileNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Profile in cdn to populate profileName.</summary>
public partial class V1beta1EndpointSpecForProviderProfileNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderProfileNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EndpointSpecForProviderProfileNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EndpointSpecForProviderProfileNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EndpointSpecForProviderProfileNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderProfileNameSelectorPolicyResolutionEnum>))]
    public V1beta1EndpointSpecForProviderProfileNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderProfileNameSelectorPolicyResolveEnum>))]
    public V1beta1EndpointSpecForProviderProfileNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Profile in cdn to populate profileName.</summary>
public partial class V1beta1EndpointSpecForProviderProfileNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderProfileNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EndpointSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1EndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1EndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1EndpointSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1EndpointSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecForProvider
{
    /// <summary>An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Rules for the rules engine. An endpoint can contain up until 4 of those rules that consist of conditions and actions. A delivery_rule blocks as defined below.</summary>
    [JsonPropertyName("deliveryRule")]
    public IList<V1beta1EndpointSpecForProviderDeliveryRule>? DeliveryRule { get; set; }

    /// <summary>A set of Geo Filters for this CDN Endpoint. Each geo_filter block supports fields documented below.</summary>
    [JsonPropertyName("geoFilter")]
    public IList<V1beta1EndpointSpecForProviderGeoFilter>? GeoFilter { get; set; }

    /// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
    [JsonPropertyName("globalDeliveryRule")]
    public IList<V1beta1EndpointSpecForProviderGlobalDeliveryRule>? GlobalDeliveryRule { get; set; }

    /// <summary>Indicates whether compression is to be enabled.</summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>Specifies if http allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>Specifies if https allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>What types of optimization should this CDN Endpoint optimize for? Possible values include DynamicSiteAcceleration, GeneralMediaStreaming, GeneralWebDelivery, LargeFileDownload and VideoOnDemandMediaStreaming.</summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each origin block supports fields documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta1EndpointSpecForProviderOrigin>? Origin { get; set; }

    /// <summary>The host header CDN provider will send along with content requests to origins.</summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>The path used at for origin requests.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin_path.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>The CDN Profile to which to attach the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary>Reference to a Profile in cdn to populate profileName.</summary>
    [JsonPropertyName("profileNameRef")]
    public V1beta1EndpointSpecForProviderProfileNameRef? ProfileNameRef { get; set; }

    /// <summary>Selector for a Profile in cdn to populate profileName.</summary>
    [JsonPropertyName("profileNameSelector")]
    public V1beta1EndpointSpecForProviderProfileNameSelector? ProfileNameSelector { get; set; }

    /// <summary>Sets query string caching behavior. Allowed values are IgnoreQueryString, BypassCaching and UseQueryString. NotSet value can be used for Premium Verizon CDN profile. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("querystringCachingBehaviour")]
    public string? QuerystringCachingBehaviour { get; set; }

    /// <summary>The name of the resource group in which to create the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1EndpointSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1EndpointSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleCookiesCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleDeviceCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleHttpVersionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRulePostArgCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleQueryStringCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleRemoteAddressCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleRequestBodyCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleRequestHeaderCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleRequestMethodCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleRequestSchemeCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleRequestUriCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleUrlFileExtensionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleUrlFileNameCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleUrlPathCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleCacheExpirationAction>? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleCacheKeyQueryStringAction>? CacheKeyQueryStringAction { get; set; }

    /// <summary>A cookies_condition block as defined above.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A device_condition block as defined below.</summary>
    [JsonPropertyName("deviceCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleDeviceCondition>? DeviceCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>The Name which should be used for this Delivery Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order used for this rule. The order values should be sequential and begin at 1.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>A post_arg_condition block as defined below.</summary>
    [JsonPropertyName("postArgCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRulePostArgCondition>? PostArgCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_file_name_condition block as defined below.</summary>
    [JsonPropertyName("urlFileNameCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleUrlFileNameCondition>? UrlFileNameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleUrlPathCondition>? UrlPathCondition { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRuleUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGeoFilter
{
    /// <summary>The Action of the Geo Filter. Possible values include Allow and Block.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A List of two letter country codes (e.g. US, GB) to be associated with this Geo Filter.</summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>The relative path applicable to geo filter.</summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGlobalDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGlobalDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGlobalDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGlobalDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGlobalDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGlobalDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderGlobalDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public IList<V1beta1EndpointSpecInitProviderGlobalDeliveryRuleCacheExpirationAction>? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public IList<V1beta1EndpointSpecInitProviderGlobalDeliveryRuleCacheKeyQueryStringAction>? CacheKeyQueryStringAction { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta1EndpointSpecInitProviderGlobalDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta1EndpointSpecInitProviderGlobalDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1EndpointSpecInitProviderGlobalDeliveryRuleUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1EndpointSpecInitProviderGlobalDeliveryRuleUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointSpecInitProviderOrigin
{
    /// <summary>A string that determines the hostname/IP address of the origin server. This string can be a domain name, Storage Account endpoint, Web App endpoint, IPv4 address or IPv6 address. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The HTTP port of the origin. Defaults to 80. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS port of the origin. Defaults to 443. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1EndpointSpecInitProvider
{
    /// <summary>An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Rules for the rules engine. An endpoint can contain up until 4 of those rules that consist of conditions and actions. A delivery_rule blocks as defined below.</summary>
    [JsonPropertyName("deliveryRule")]
    public IList<V1beta1EndpointSpecInitProviderDeliveryRule>? DeliveryRule { get; set; }

    /// <summary>A set of Geo Filters for this CDN Endpoint. Each geo_filter block supports fields documented below.</summary>
    [JsonPropertyName("geoFilter")]
    public IList<V1beta1EndpointSpecInitProviderGeoFilter>? GeoFilter { get; set; }

    /// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
    [JsonPropertyName("globalDeliveryRule")]
    public IList<V1beta1EndpointSpecInitProviderGlobalDeliveryRule>? GlobalDeliveryRule { get; set; }

    /// <summary>Indicates whether compression is to be enabled.</summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>Specifies if http allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>Specifies if https allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>What types of optimization should this CDN Endpoint optimize for? Possible values include DynamicSiteAcceleration, GeneralMediaStreaming, GeneralWebDelivery, LargeFileDownload and VideoOnDemandMediaStreaming.</summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each origin block supports fields documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta1EndpointSpecInitProviderOrigin>? Origin { get; set; }

    /// <summary>The host header CDN provider will send along with content requests to origins.</summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>The path used at for origin requests.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin_path.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>Sets query string caching behavior. Allowed values are IgnoreQueryString, BypassCaching and UseQueryString. NotSet value can be used for Premium Verizon CDN profile. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("querystringCachingBehaviour")]
    public string? QuerystringCachingBehaviour { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1EndpointSpecManagementPoliciesEnum
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

public enum V1beta1EndpointSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EndpointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EndpointSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1EndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1EndpointSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1EndpointSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1EndpointSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EndpointSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EndpointSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1EndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EndpointSpec defines the desired state of Endpoint</summary>
public partial class V1beta1EndpointSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecDeletionPolicyEnum>))]
    public V1beta1EndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EndpointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EndpointSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleCookiesCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleDeviceCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleHttpVersionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRulePostArgCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleQueryStringCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleRemoteAddressCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleRequestBodyCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleRequestHeaderCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleRequestMethodCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleRequestSchemeCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleRequestUriCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleUrlFileExtensionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleUrlFileNameCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleUrlPathCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleCacheExpirationAction>? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleCacheKeyQueryStringAction>? CacheKeyQueryStringAction { get; set; }

    /// <summary>A cookies_condition block as defined above.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A device_condition block as defined below.</summary>
    [JsonPropertyName("deviceCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleDeviceCondition>? DeviceCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>The Name which should be used for this Delivery Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order used for this rule. The order values should be sequential and begin at 1.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>A post_arg_condition block as defined below.</summary>
    [JsonPropertyName("postArgCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRulePostArgCondition>? PostArgCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_file_name_condition block as defined below.</summary>
    [JsonPropertyName("urlFileNameCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleUrlFileNameCondition>? UrlFileNameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleUrlPathCondition>? UrlPathCondition { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRuleUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGeoFilter
{
    /// <summary>The Action of the Geo Filter. Possible values include Allow and Block.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A List of two letter country codes (e.g. US, GB) to be associated with this Geo Filter.</summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>The relative path applicable to geo filter.</summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGlobalDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGlobalDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGlobalDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGlobalDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGlobalDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGlobalDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can't be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderGlobalDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public IList<V1beta1EndpointStatusAtProviderGlobalDeliveryRuleCacheExpirationAction>? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public IList<V1beta1EndpointStatusAtProviderGlobalDeliveryRuleCacheKeyQueryStringAction>? CacheKeyQueryStringAction { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta1EndpointStatusAtProviderGlobalDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta1EndpointStatusAtProviderGlobalDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1EndpointStatusAtProviderGlobalDeliveryRuleUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1EndpointStatusAtProviderGlobalDeliveryRuleUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProviderOrigin
{
    /// <summary>A string that determines the hostname/IP address of the origin server. This string can be a domain name, Storage Account endpoint, Web App endpoint, IPv4 address or IPv6 address. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The HTTP port of the origin. Defaults to 80. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS port of the origin. Defaults to 443. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1beta1EndpointStatusAtProvider
{
    /// <summary>An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Rules for the rules engine. An endpoint can contain up until 4 of those rules that consist of conditions and actions. A delivery_rule blocks as defined below.</summary>
    [JsonPropertyName("deliveryRule")]
    public IList<V1beta1EndpointStatusAtProviderDeliveryRule>? DeliveryRule { get; set; }

    /// <summary>The Fully Qualified Domain Name of the CDN Endpoint.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>A set of Geo Filters for this CDN Endpoint. Each geo_filter block supports fields documented below.</summary>
    [JsonPropertyName("geoFilter")]
    public IList<V1beta1EndpointStatusAtProviderGeoFilter>? GeoFilter { get; set; }

    /// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
    [JsonPropertyName("globalDeliveryRule")]
    public IList<V1beta1EndpointStatusAtProviderGlobalDeliveryRule>? GlobalDeliveryRule { get; set; }

    /// <summary>The ID of the CDN Endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indicates whether compression is to be enabled.</summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>Specifies if http allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>Specifies if https allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>What types of optimization should this CDN Endpoint optimize for? Possible values include DynamicSiteAcceleration, GeneralMediaStreaming, GeneralWebDelivery, LargeFileDownload and VideoOnDemandMediaStreaming.</summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each origin block supports fields documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta1EndpointStatusAtProviderOrigin>? Origin { get; set; }

    /// <summary>The host header CDN provider will send along with content requests to origins.</summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>The path used at for origin requests.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin_path.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>The CDN Profile to which to attach the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary>Sets query string caching behavior. Allowed values are IgnoreQueryString, BypassCaching and UseQueryString. NotSet value can be used for Premium Verizon CDN profile. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("querystringCachingBehaviour")]
    public string? QuerystringCachingBehaviour { get; set; }

    /// <summary>The name of the resource group in which to create the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1EndpointStatusConditions
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

/// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
public partial class V1beta1EndpointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Endpoint is the Schema for the Endpoints API. Manages a CDN Endpoint.</summary>
public partial class V1beta1Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EndpointSpec>, IStatus<V1beta1EndpointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointSpec defines the desired state of Endpoint</summary>
    [JsonPropertyName("spec")]
    public V1beta1EndpointSpec Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1EndpointStatus? Status { get; set; }
}