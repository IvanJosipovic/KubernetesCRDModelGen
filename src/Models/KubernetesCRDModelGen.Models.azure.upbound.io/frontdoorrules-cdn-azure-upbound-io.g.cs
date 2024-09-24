using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecDeletionPolicyEnum
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
public partial class V1beta1FrontdoorRuleSpecForProviderActionsRequestHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderActionsResponseHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideAction
{
    /// <summary>HonorOrigin the Front Door will always honor origin response header directive. If the origin directive is missing, Front Door will cache contents anywhere from 1 to 3 days. OverrideAlways the TTL value returned from your Front Door Origin is overwritten with the value specified in the action. This behavior will only be applied if the response is cacheable. OverrideIfOriginMissing if no TTL value gets returned from your Front Door Origin, the rule sets the TTL to the value specified in the action. This behavior will only be applied if the response is cacheable. Disabled the Front Door will not cache the response contents, irrespective of Front Door Origin response directives. Possible values include HonorOrigin, OverrideAlways, OverrideIfOriginMissing or Disabled.</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>When Cache behavior is set to Override or SetIfMissing, this field specifies the cache duration to use. The maximum duration is 366 days specified in the d.HH:MM:SS format(e.g. 365.23:59:59). If the desired maximum cache duration is less than 1 day then the maximum cache duration should be specified in the HH:MM:SS format(e.g. 23:59:59).</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>The Front Door Origin Group resource ID that the request should be routed to. This overrides the configuration specified in the Front Door Endpoint route.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>Should the Front Door dynamically compress the content? Possible values include true or false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The forwarding protocol the request will be redirected as. This overrides the configuration specified in the route to be associated with. Possible values include MatchRequest, HttpOnly or HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>IncludeSpecifiedQueryStrings query strings specified in the query_string_parameters field get included when the cache key gets generated. UseQueryString cache every unique URL, each unique URL will have its own cache key. IgnoreSpecifiedQueryStrings query strings specified in the query_string_parameters field get excluded when the cache key gets generated. IgnoreQueryString query strings aren't considered when the cache key gets generated. Possible values include IgnoreQueryString, UseQueryString, IgnoreSpecifiedQueryStrings or IncludeSpecifiedQueryStrings.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>A list of query string parameter names.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IList<string>? QueryStringParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderActionsUrlRedirectAction
{
    /// <summary>The fragment to use in the redirect. The value must be a string between 0 and 1024 characters in length, leave blank to preserve the incoming fragment. Defaults to "".</summary>
    [JsonPropertyName("destinationFragment")]
    public string? DestinationFragment { get; set; }

    /// <summary>The host name you want the request to be redirected to. The value must be a string between 0 and 2048 characters in length, leave blank to preserve the incoming host.</summary>
    [JsonPropertyName("destinationHostname")]
    public string? DestinationHostname { get; set; }

    /// <summary>The path to use in the redirect. The value must be a string and include the leading /, leave blank to preserve the incoming path. Defaults to "".</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>The query string used in the redirect URL. The value must be in the &lt;key&gt;=&lt;value&gt; or &lt;key&gt;={action_server_variable} format and must not include the leading ?, leave blank to preserve the incoming query string. Maximum allowed length for this field is 2048 characters. Defaults to "".</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>The protocol the request will be redirected as. Possible values include MatchRequest, Http or Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>The response type to return to the requestor. Possible values include Moved, Found , TemporaryRedirect or PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderActionsUrlRewriteAction
{
    /// <summary>The destination path to use in the rewrite. The destination path overwrites the source pattern.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Append the remaining path after the source pattern to the new destination path? Possible values true or false. Defaults to false.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>The source pattern in the URL path to replace. This uses prefix-based matching. For example, to match all URL paths use a forward slash "/" as the source pattern value.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderActions
{
    /// <summary>A request_header_action block as defined below.</summary>
    [JsonPropertyName("requestHeaderAction")]
    public IList<V1beta1FrontdoorRuleSpecForProviderActionsRequestHeaderAction>? RequestHeaderAction { get; set; }

    /// <summary>A response_header_action block as defined below.</summary>
    [JsonPropertyName("responseHeaderAction")]
    public IList<V1beta1FrontdoorRuleSpecForProviderActionsResponseHeaderAction>? ResponseHeaderAction { get; set; }

    /// <summary>A route_configuration_override_action block as defined below.</summary>
    [JsonPropertyName("routeConfigurationOverrideAction")]
    public IList<V1beta1FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideAction>? RouteConfigurationOverrideAction { get; set; }

    /// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1FrontdoorRuleSpecForProviderActionsUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1FrontdoorRuleSpecForProviderActionsUrlRewriteAction>? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsClientPortCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsCookiesCondition
{
    /// <summary>A string value representing the name of the cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsHostNameCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsHttpVersionCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsIsDeviceCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsPostArgsCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A string value representing the name of the POST argument.</summary>
    [JsonPropertyName("postArgsName")]
    public string? PostArgsName { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsQueryStringCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsRemoteAddressCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsRequestBodyCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsRequestHeaderCondition
{
    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsRequestMethodCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsRequestSchemeCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsRequestUriCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsServerPortCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsSocketAddressCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsSslProtocolCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsUrlFileExtensionCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsUrlFilenameCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditionsUrlPathCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProviderConditions
{
    /// <summary>A client_port_condition block as defined below.</summary>
    [JsonPropertyName("clientPortCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsClientPortCondition>? ClientPortCondition { get; set; }

    /// <summary>A cookies_condition block as defined below.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A host_name_condition block as defined below.</summary>
    [JsonPropertyName("hostNameCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsHostNameCondition>? HostNameCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A is_device_condition block as defined below.</summary>
    [JsonPropertyName("isDeviceCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsIsDeviceCondition>? IsDeviceCondition { get; set; }

    /// <summary>A post_args_condition block as defined below.</summary>
    [JsonPropertyName("postArgsCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsPostArgsCondition>? PostArgsCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A server_port_condition block as defined below.</summary>
    [JsonPropertyName("serverPortCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsServerPortCondition>? ServerPortCondition { get; set; }

    /// <summary>A socket_address_condition block as defined below.</summary>
    [JsonPropertyName("socketAddressCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsSocketAddressCondition>? SocketAddressCondition { get; set; }

    /// <summary>A ssl_protocol_condition block as defined below.</summary>
    [JsonPropertyName("sslProtocolCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsSslProtocolCondition>? SslProtocolCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_filename_condition block as defined below.</summary>
    [JsonPropertyName("urlFilenameCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsUrlFilenameCondition>? UrlFilenameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditionsUrlPathCondition>? UrlPathCondition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecForProvider
{
    /// <summary>An actions block as defined below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1FrontdoorRuleSpecForProviderActions>? Actions { get; set; }

    /// <summary>If this rule is a match should the rules engine continue processing the remaining rules or stop? Possible values are Continue and Stop. Defaults to Continue.</summary>
    [JsonPropertyName("behaviorOnMatch")]
    public string? BehaviorOnMatch { get; set; }

    /// <summary>The resource ID of the Front Door Rule Set for this Front Door Rule. Changing this forces a new Front Door Rule to be created.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetId")]
    public string? CdnFrontdoorRuleSetId { get; set; }

    /// <summary>Reference to a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdRef")]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRef? CdnFrontdoorRuleSetIdRef { get; set; }

    /// <summary>Selector for a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdSelector")]
    public V1beta1FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelector? CdnFrontdoorRuleSetIdSelector { get; set; }

    /// <summary>A conditions block as defined below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorRuleSpecForProviderConditions>? Conditions { get; set; }

    /// <summary>The order in which the rules will be applied for the Front Door Endpoint. The order value should be sequential and begin at 1(e.g. 1, 2, 3...). A Front Door Rule with a lesser order value will be applied before a rule with a greater order value.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsRequestHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsResponseHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideAction
{
    /// <summary>HonorOrigin the Front Door will always honor origin response header directive. If the origin directive is missing, Front Door will cache contents anywhere from 1 to 3 days. OverrideAlways the TTL value returned from your Front Door Origin is overwritten with the value specified in the action. This behavior will only be applied if the response is cacheable. OverrideIfOriginMissing if no TTL value gets returned from your Front Door Origin, the rule sets the TTL to the value specified in the action. This behavior will only be applied if the response is cacheable. Disabled the Front Door will not cache the response contents, irrespective of Front Door Origin response directives. Possible values include HonorOrigin, OverrideAlways, OverrideIfOriginMissing or Disabled.</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>When Cache behavior is set to Override or SetIfMissing, this field specifies the cache duration to use. The maximum duration is 366 days specified in the d.HH:MM:SS format(e.g. 365.23:59:59). If the desired maximum cache duration is less than 1 day then the maximum cache duration should be specified in the HH:MM:SS format(e.g. 23:59:59).</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>The Front Door Origin Group resource ID that the request should be routed to. This overrides the configuration specified in the Front Door Endpoint route.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>Should the Front Door dynamically compress the content? Possible values include true or false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The forwarding protocol the request will be redirected as. This overrides the configuration specified in the route to be associated with. Possible values include MatchRequest, HttpOnly or HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>IncludeSpecifiedQueryStrings query strings specified in the query_string_parameters field get included when the cache key gets generated. UseQueryString cache every unique URL, each unique URL will have its own cache key. IgnoreSpecifiedQueryStrings query strings specified in the query_string_parameters field get excluded when the cache key gets generated. IgnoreQueryString query strings aren't considered when the cache key gets generated. Possible values include IgnoreQueryString, UseQueryString, IgnoreSpecifiedQueryStrings or IncludeSpecifiedQueryStrings.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>A list of query string parameter names.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IList<string>? QueryStringParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsUrlRedirectAction
{
    /// <summary>The fragment to use in the redirect. The value must be a string between 0 and 1024 characters in length, leave blank to preserve the incoming fragment. Defaults to "".</summary>
    [JsonPropertyName("destinationFragment")]
    public string? DestinationFragment { get; set; }

    /// <summary>The host name you want the request to be redirected to. The value must be a string between 0 and 2048 characters in length, leave blank to preserve the incoming host.</summary>
    [JsonPropertyName("destinationHostname")]
    public string? DestinationHostname { get; set; }

    /// <summary>The path to use in the redirect. The value must be a string and include the leading /, leave blank to preserve the incoming path. Defaults to "".</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>The query string used in the redirect URL. The value must be in the &lt;key&gt;=&lt;value&gt; or &lt;key&gt;={action_server_variable} format and must not include the leading ?, leave blank to preserve the incoming query string. Maximum allowed length for this field is 2048 characters. Defaults to "".</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>The protocol the request will be redirected as. Possible values include MatchRequest, Http or Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>The response type to return to the requestor. Possible values include Moved, Found , TemporaryRedirect or PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActionsUrlRewriteAction
{
    /// <summary>The destination path to use in the rewrite. The destination path overwrites the source pattern.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Append the remaining path after the source pattern to the new destination path? Possible values true or false. Defaults to false.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>The source pattern in the URL path to replace. This uses prefix-based matching. For example, to match all URL paths use a forward slash "/" as the source pattern value.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderActions
{
    /// <summary>A request_header_action block as defined below.</summary>
    [JsonPropertyName("requestHeaderAction")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderActionsRequestHeaderAction>? RequestHeaderAction { get; set; }

    /// <summary>A response_header_action block as defined below.</summary>
    [JsonPropertyName("responseHeaderAction")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderActionsResponseHeaderAction>? ResponseHeaderAction { get; set; }

    /// <summary>A route_configuration_override_action block as defined below.</summary>
    [JsonPropertyName("routeConfigurationOverrideAction")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideAction>? RouteConfigurationOverrideAction { get; set; }

    /// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderActionsUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderActionsUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsClientPortCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsCookiesCondition
{
    /// <summary>A string value representing the name of the cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsHostNameCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsHttpVersionCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsIsDeviceCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsPostArgsCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A string value representing the name of the POST argument.</summary>
    [JsonPropertyName("postArgsName")]
    public string? PostArgsName { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsQueryStringCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsRemoteAddressCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsRequestBodyCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsRequestHeaderCondition
{
    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsRequestMethodCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsRequestSchemeCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsRequestUriCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsServerPortCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsSocketAddressCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsSslProtocolCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsUrlFileExtensionCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsUrlFilenameCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditionsUrlPathCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProviderConditions
{
    /// <summary>A client_port_condition block as defined below.</summary>
    [JsonPropertyName("clientPortCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsClientPortCondition>? ClientPortCondition { get; set; }

    /// <summary>A cookies_condition block as defined below.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A host_name_condition block as defined below.</summary>
    [JsonPropertyName("hostNameCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsHostNameCondition>? HostNameCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A is_device_condition block as defined below.</summary>
    [JsonPropertyName("isDeviceCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsIsDeviceCondition>? IsDeviceCondition { get; set; }

    /// <summary>A post_args_condition block as defined below.</summary>
    [JsonPropertyName("postArgsCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsPostArgsCondition>? PostArgsCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A server_port_condition block as defined below.</summary>
    [JsonPropertyName("serverPortCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsServerPortCondition>? ServerPortCondition { get; set; }

    /// <summary>A socket_address_condition block as defined below.</summary>
    [JsonPropertyName("socketAddressCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsSocketAddressCondition>? SocketAddressCondition { get; set; }

    /// <summary>A ssl_protocol_condition block as defined below.</summary>
    [JsonPropertyName("sslProtocolCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsSslProtocolCondition>? SslProtocolCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_filename_condition block as defined below.</summary>
    [JsonPropertyName("urlFilenameCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsUrlFilenameCondition>? UrlFilenameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditionsUrlPathCondition>? UrlPathCondition { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecInitProvider
{
    /// <summary>An actions block as defined below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderActions>? Actions { get; set; }

    /// <summary>If this rule is a match should the rules engine continue processing the remaining rules or stop? Possible values are Continue and Stop. Defaults to Continue.</summary>
    [JsonPropertyName("behaviorOnMatch")]
    public string? BehaviorOnMatch { get; set; }

    /// <summary>A conditions block as defined below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorRuleSpecInitProviderConditions>? Conditions { get; set; }

    /// <summary>The order in which the rules will be applied for the Front Door Endpoint. The order value should be sequential and begin at 1(e.g. 1, 2, 3...). A Front Door Rule with a lesser order value will be applied before a rule with a greater order value.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecManagementPoliciesEnum
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
public enum V1beta1FrontdoorRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FrontdoorRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FrontdoorRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FrontdoorRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FrontdoorRuleSpec defines the desired state of FrontdoorRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorRuleSpecDeletionPolicyEnum>))]
    public V1beta1FrontdoorRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FrontdoorRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FrontdoorRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderActionsRequestHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderActionsResponseHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderActionsRouteConfigurationOverrideAction
{
    /// <summary>HonorOrigin the Front Door will always honor origin response header directive. If the origin directive is missing, Front Door will cache contents anywhere from 1 to 3 days. OverrideAlways the TTL value returned from your Front Door Origin is overwritten with the value specified in the action. This behavior will only be applied if the response is cacheable. OverrideIfOriginMissing if no TTL value gets returned from your Front Door Origin, the rule sets the TTL to the value specified in the action. This behavior will only be applied if the response is cacheable. Disabled the Front Door will not cache the response contents, irrespective of Front Door Origin response directives. Possible values include HonorOrigin, OverrideAlways, OverrideIfOriginMissing or Disabled.</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>When Cache behavior is set to Override or SetIfMissing, this field specifies the cache duration to use. The maximum duration is 366 days specified in the d.HH:MM:SS format(e.g. 365.23:59:59). If the desired maximum cache duration is less than 1 day then the maximum cache duration should be specified in the HH:MM:SS format(e.g. 23:59:59).</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>The Front Door Origin Group resource ID that the request should be routed to. This overrides the configuration specified in the Front Door Endpoint route.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Should the Front Door dynamically compress the content? Possible values include true or false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The forwarding protocol the request will be redirected as. This overrides the configuration specified in the route to be associated with. Possible values include MatchRequest, HttpOnly or HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>IncludeSpecifiedQueryStrings query strings specified in the query_string_parameters field get included when the cache key gets generated. UseQueryString cache every unique URL, each unique URL will have its own cache key. IgnoreSpecifiedQueryStrings query strings specified in the query_string_parameters field get excluded when the cache key gets generated. IgnoreQueryString query strings aren't considered when the cache key gets generated. Possible values include IgnoreQueryString, UseQueryString, IgnoreSpecifiedQueryStrings or IncludeSpecifiedQueryStrings.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>A list of query string parameter names.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IList<string>? QueryStringParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderActionsUrlRedirectAction
{
    /// <summary>The fragment to use in the redirect. The value must be a string between 0 and 1024 characters in length, leave blank to preserve the incoming fragment. Defaults to "".</summary>
    [JsonPropertyName("destinationFragment")]
    public string? DestinationFragment { get; set; }

    /// <summary>The host name you want the request to be redirected to. The value must be a string between 0 and 2048 characters in length, leave blank to preserve the incoming host.</summary>
    [JsonPropertyName("destinationHostname")]
    public string? DestinationHostname { get; set; }

    /// <summary>The path to use in the redirect. The value must be a string and include the leading /, leave blank to preserve the incoming path. Defaults to "".</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>The query string used in the redirect URL. The value must be in the &lt;key&gt;=&lt;value&gt; or &lt;key&gt;={action_server_variable} format and must not include the leading ?, leave blank to preserve the incoming query string. Maximum allowed length for this field is 2048 characters. Defaults to "".</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>The protocol the request will be redirected as. Possible values include MatchRequest, Http or Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>The response type to return to the requestor. Possible values include Moved, Found , TemporaryRedirect or PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderActionsUrlRewriteAction
{
    /// <summary>The destination path to use in the rewrite. The destination path overwrites the source pattern.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Append the remaining path after the source pattern to the new destination path? Possible values true or false. Defaults to false.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>The source pattern in the URL path to replace. This uses prefix-based matching. For example, to match all URL paths use a forward slash "/" as the source pattern value.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderActions
{
    /// <summary>A request_header_action block as defined below.</summary>
    [JsonPropertyName("requestHeaderAction")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderActionsRequestHeaderAction>? RequestHeaderAction { get; set; }

    /// <summary>A response_header_action block as defined below.</summary>
    [JsonPropertyName("responseHeaderAction")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderActionsResponseHeaderAction>? ResponseHeaderAction { get; set; }

    /// <summary>A route_configuration_override_action block as defined below.</summary>
    [JsonPropertyName("routeConfigurationOverrideAction")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderActionsRouteConfigurationOverrideAction>? RouteConfigurationOverrideAction { get; set; }

    /// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderActionsUrlRedirectAction>? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderActionsUrlRewriteAction>? UrlRewriteAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsClientPortCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsCookiesCondition
{
    /// <summary>A string value representing the name of the cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsHostNameCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsHttpVersionCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsIsDeviceCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsPostArgsCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A string value representing the name of the POST argument.</summary>
    [JsonPropertyName("postArgsName")]
    public string? PostArgsName { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsQueryStringCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsRemoteAddressCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsRequestBodyCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsRequestHeaderCondition
{
    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsRequestMethodCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsRequestSchemeCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsRequestUriCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsServerPortCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsSocketAddressCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsSslProtocolCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsUrlFileExtensionCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsUrlFilenameCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditionsUrlPathCondition
{
    /// <summary>One or more string or integer values(e.g. "1") representing the value of the request path to match. Don't include the leading slash (/). If multiple values are specified, they're evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual or RegEx. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProviderConditions
{
    /// <summary>A client_port_condition block as defined below.</summary>
    [JsonPropertyName("clientPortCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsClientPortCondition>? ClientPortCondition { get; set; }

    /// <summary>A cookies_condition block as defined below.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A host_name_condition block as defined below.</summary>
    [JsonPropertyName("hostNameCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsHostNameCondition>? HostNameCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A is_device_condition block as defined below.</summary>
    [JsonPropertyName("isDeviceCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsIsDeviceCondition>? IsDeviceCondition { get; set; }

    /// <summary>A post_args_condition block as defined below.</summary>
    [JsonPropertyName("postArgsCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsPostArgsCondition>? PostArgsCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A server_port_condition block as defined below.</summary>
    [JsonPropertyName("serverPortCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsServerPortCondition>? ServerPortCondition { get; set; }

    /// <summary>A socket_address_condition block as defined below.</summary>
    [JsonPropertyName("socketAddressCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsSocketAddressCondition>? SocketAddressCondition { get; set; }

    /// <summary>A ssl_protocol_condition block as defined below.</summary>
    [JsonPropertyName("sslProtocolCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsSslProtocolCondition>? SslProtocolCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_filename_condition block as defined below.</summary>
    [JsonPropertyName("urlFilenameCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsUrlFilenameCondition>? UrlFilenameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditionsUrlPathCondition>? UrlPathCondition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusAtProvider
{
    /// <summary>An actions block as defined below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderActions>? Actions { get; set; }

    /// <summary>If this rule is a match should the rules engine continue processing the remaining rules or stop? Possible values are Continue and Stop. Defaults to Continue.</summary>
    [JsonPropertyName("behaviorOnMatch")]
    public string? BehaviorOnMatch { get; set; }

    /// <summary>The resource ID of the Front Door Rule Set for this Front Door Rule. Changing this forces a new Front Door Rule to be created.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetId")]
    public string? CdnFrontdoorRuleSetId { get; set; }

    /// <summary>The name of the Front Door Rule Set containing this Front Door Rule.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetName")]
    public string? CdnFrontdoorRuleSetName { get; set; }

    /// <summary>A conditions block as defined below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorRuleStatusAtProviderConditions>? Conditions { get; set; }

    /// <summary>The ID of the Front Door Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The order in which the rules will be applied for the Front Door Endpoint. The order value should be sequential and begin at 1(e.g. 1, 2, 3...). A Front Door Rule with a lesser order value will be applied before a rule with a greater order value.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatusConditions
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

/// <summary>FrontdoorRuleStatus defines the observed state of FrontdoorRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontdoorRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorRule is the Schema for the FrontdoorRules API. Manages a Front Door (standard/premium) Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorRuleSpec>, IStatus<V1beta1FrontdoorRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorRule";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorRuleSpec defines the desired state of FrontdoorRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontdoorRuleSpec Spec { get; set; }

    /// <summary>FrontdoorRuleStatus defines the observed state of FrontdoorRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontdoorRuleStatus? Status { get; set; }
}