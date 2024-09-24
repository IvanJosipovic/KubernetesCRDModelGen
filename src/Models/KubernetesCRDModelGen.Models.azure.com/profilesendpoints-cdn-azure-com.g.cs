using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
public partial class V1api20210601storageProfilesEndpointSpecDefaultOriginGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDefaultOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601storageProfilesEndpointSpecDefaultOriginGroupReference? Reference { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheType")]
    public string? CacheType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpiration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.CacheExpirationActionParameters Defines the parameters for the cache expiration action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpirationParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.CacheKeyQueryStringActionParameters Defines the parameters for the cache-key query string action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryStringParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HeaderActionParameters Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeaderParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HeaderActionParameters Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeaderParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroupReference? Reference { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup? OriginGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.OriginGroupOverrideActionParameters Defines the parameters for the origin group override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverrideParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCompressionEnabled")]
    public string? IsCompressionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference? Reference { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Storage version of v1api20210601.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.CacheConfiguration Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>Storage version of v1api20210601.OriginGroupOverride Defines the parameters for the origin group override configuration.</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RouteConfigurationOverrideActionParameters Defines the parameters for the route configuration override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customFragment")]
    public string? CustomFragment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHostname")]
    public string? CustomHostname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customPath")]
    public string? CustomPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customQueryString")]
    public string? CustomQueryString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationProtocol")]
    public string? DestinationProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirect
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRedirectActionParameters Defines the parameters for the url redirect action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirectParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewrite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRewriteActionParameters Defines the parameters for the url rewrite action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewriteParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paramIndicator")]
    public string? ParamIndicator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paramName")]
    public string? ParamName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigning
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlSigningActionParameters Defines the parameters for the Url Signing action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigningParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleCacheExpirationAction</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleCacheKeyQueryStringAction</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestHeaderAction</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleResponseHeaderAction</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>Storage version of v1api20210601.OriginGroupOverrideAction</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRouteConfigurationOverrideAction</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRedirectAction</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRewriteAction</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>Storage version of v1api20210601.UrlSigningAction</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActionsUrlSigning? UrlSigning { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.ClientPortMatchConditionParameters Defines the parameters for ClientPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPortParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsCookies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.CookiesMatchConditionParameters Defines the parameters for Cookies match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsCookiesParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHostName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HostNameMatchConditionParameters Defines the parameters for HostName match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHostNameParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HttpVersionMatchConditionParameters Defines the parameters for HttpVersion match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersionParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDevice
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.IsDeviceMatchConditionParameters Defines the parameters for IsDevice match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDeviceParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.PostArgsMatchConditionParameters Defines the parameters for PostArgs match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgsParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.QueryStringMatchConditionParameters Defines the parameters for QueryString match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryStringParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RemoteAddressMatchConditionParameters Defines the parameters for RemoteAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddressParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBody
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestBodyMatchConditionParameters Defines the parameters for RequestBody match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBodyParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestHeaderMatchConditionParameters Defines the parameters for RequestHeader match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeaderParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethod
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestMethodMatchConditionParameters Defines the parameters for RequestMethod match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethodParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestScheme
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestSchemeMatchConditionParameters Defines the parameters for RequestScheme match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestSchemeParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUri
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestUriMatchConditionParameters Defines the parameters for RequestUri match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUriParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.ServerPortMatchConditionParameters Defines the parameters for ServerPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPortParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddr
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.SocketAddrMatchConditionParameters Defines the parameters for SocketAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddrParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocol
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.SslProtocolMatchConditionParameters Defines the parameters for SslProtocol match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocolParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtension
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlFileExtensionMatchConditionParameters Defines the parameters for UrlFileExtension match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtensionParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlFileNameMatchConditionParameters Defines the parameters for UrlFilename match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileNameParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPath
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlPathMatchConditionParameters Defines the parameters for UrlPath match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPathParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleClientPortCondition</summary>
    [JsonPropertyName("clientPort")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsClientPort? ClientPort { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleCookiesCondition</summary>
    [JsonPropertyName("cookies")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsCookies? Cookies { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleHostNameCondition</summary>
    [JsonPropertyName("hostName")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHostName? HostName { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleHttpVersionCondition</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleIsDeviceCondition</summary>
    [JsonPropertyName("isDevice")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsIsDevice? IsDevice { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRulePostArgsCondition</summary>
    [JsonPropertyName("postArgs")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsPostArgs? PostArgs { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleQueryStringCondition</summary>
    [JsonPropertyName("queryString")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsQueryString? QueryString { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRemoteAddressCondition</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestBodyCondition</summary>
    [JsonPropertyName("requestBody")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestBody? RequestBody { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestHeaderCondition</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestMethodCondition</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestSchemeCondition</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestUriCondition</summary>
    [JsonPropertyName("requestUri")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsRequestUri? RequestUri { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleServerPortCondition</summary>
    [JsonPropertyName("serverPort")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsServerPort? ServerPort { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleSocketAddrCondition</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleSslProtocolCondition</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleUrlFileExtensionCondition</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleUrlFileNameCondition</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleUrlPathCondition</summary>
    [JsonPropertyName("urlPath")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditionsUrlPath? UrlPath { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicyRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actions")]
    public IList<V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesActions>? Actions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601storageProfilesEndpointSpecDeliveryPolicyRulesConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecDeliveryPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20210601storageProfilesEndpointSpecDeliveryPolicyRules>? Rules { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecGeoFilters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginGroupsHealthProbeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeRequestType")]
    public string? ProbeRequestType { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginGroupsOriginsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginGroupsOrigins
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601storageProfilesEndpointSpecOriginGroupsOriginsReference? Reference { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("begin")]
    public int? Begin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public int? End { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpErrorRanges")]
    public IList<V1api20210601storageProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges>? HttpErrorRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("responseBasedDetectedErrorTypes")]
    public string? ResponseBasedDetectedErrorTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("responseBasedFailoverThresholdPercentage")]
    public int? ResponseBasedFailoverThresholdPercentage { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.HealthProbeParameters The JSON object that contains the properties to send health probes to origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20210601storageProfilesEndpointSpecOriginGroupsHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("origins")]
    public IList<V1api20210601storageProfilesEndpointSpecOriginGroupsOrigins>? Origins { get; set; }

    /// <summary>Storage version of v1api20210601.ResponseBasedOriginErrorDetectionParameters The JSON object that contains the properties to determine origin health using real requests/responses.</summary>
    [JsonPropertyName("responseBasedOriginErrorDetectionSettings")]
    public V1api20210601storageProfilesEndpointSpecOriginGroupsResponseBasedOriginErrorDetectionSettings? ResponseBasedOriginErrorDetectionSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginsPrivateLinkLocationReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOriginsPrivateLinkResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOrigins
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkAlias")]
    public string? PrivateLinkAlias { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkApprovalMessage")]
    public string? PrivateLinkApprovalMessage { get; set; }

    /// <summary>PrivateLinkLocationReference: The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated</summary>
    [JsonPropertyName("privateLinkLocationReference")]
    public V1api20210601storageProfilesEndpointSpecOriginsPrivateLinkLocationReference? PrivateLinkLocationReference { get; set; }

    /// <summary>PrivateLinkResourceReference: The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'</summary>
    [JsonPropertyName("privateLinkResourceReference")]
    public V1api20210601storageProfilesEndpointSpecOriginsPrivateLinkResourceReference? PrivateLinkResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecUrlSigningKeysKeySourceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecUrlSigningKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Storage version of v1api20210601.KeyVaultSigningKeyParameters Describes the parameters for using a user's KeyVault for URL Signing Key.</summary>
    [JsonPropertyName("keySourceParameters")]
    public V1api20210601storageProfilesEndpointSpecUrlSigningKeysKeySourceParameters? KeySourceParameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecWebApplicationFirewallPolicyLinkReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpecWebApplicationFirewallPolicyLink
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20210601storageProfilesEndpointSpecWebApplicationFirewallPolicyLinkReference? Reference { get; set; }
}

public partial class V1api20210601storageProfilesEndpointSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Storage version of v1api20210601.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("defaultOriginGroup")]
    public V1api20210601storageProfilesEndpointSpecDefaultOriginGroup? DefaultOriginGroup { get; set; }

    /// <summary>Storage version of v1api20210601.EndpointProperties_DeliveryPolicy</summary>
    [JsonPropertyName("deliveryPolicy")]
    public V1api20210601storageProfilesEndpointSpecDeliveryPolicy? DeliveryPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("geoFilters")]
    public IList<V1api20210601storageProfilesEndpointSpecGeoFilters>? GeoFilters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originGroups")]
    public IList<V1api20210601storageProfilesEndpointSpecOriginGroups>? OriginGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("origins")]
    public IList<V1api20210601storageProfilesEndpointSpecOrigins>? Origins { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/Profile resource</summary>
    [JsonPropertyName("owner")]
    public V1api20210601storageProfilesEndpointSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSigningKeys")]
    public IList<V1api20210601storageProfilesEndpointSpecUrlSigningKeys>? UrlSigningKeys { get; set; }

    /// <summary>Storage version of v1api20210601.EndpointProperties_WebApplicationFirewallPolicyLink</summary>
    [JsonPropertyName("webApplicationFirewallPolicyLink")]
    public V1api20210601storageProfilesEndpointSpecWebApplicationFirewallPolicyLink? WebApplicationFirewallPolicyLink { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusCustomDomains
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("validationData")]
    public string? ValidationData { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDefaultOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpirationParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheType")]
    public string? CacheType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpiration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.CacheExpirationActionParameters_STATUS Defines the parameters for the cache expiration action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpirationParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryStringParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.CacheKeyQueryStringActionParameters_STATUS Defines the parameters for the cache-key query string action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryStringParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeaderParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HeaderActionParameters_STATUS Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeaderParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeaderParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HeaderActionParameters_STATUS Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeaderParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParametersOriginGroup? OriginGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.OriginGroupOverrideActionParameters_STATUS Defines the parameters for the origin group override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverrideParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCompressionEnabled")]
    public string? IsCompressionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Storage version of v1api20210601.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.CacheConfiguration_STATUS Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>Storage version of v1api20210601.OriginGroupOverride_STATUS Defines the parameters for the origin group override configuration.</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RouteConfigurationOverrideActionParameters_STATUS Defines the parameters for the route configuration override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverrideParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirectParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customFragment")]
    public string? CustomFragment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customHostname")]
    public string? CustomHostname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customPath")]
    public string? CustomPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customQueryString")]
    public string? CustomQueryString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationProtocol")]
    public string? DestinationProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirect
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRedirectActionParameters_STATUS Defines the parameters for the url redirect action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirectParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewriteParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewrite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRewriteActionParameters_STATUS Defines the parameters for the url rewrite action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewriteParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paramIndicator")]
    public string? ParamIndicator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paramName")]
    public string? ParamName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigning
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlSigningActionParameters_STATUS Defines the parameters for the Url Signing action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigningParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleCacheExpirationAction_STATUS</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleCacheKeyQueryStringAction_STATUS</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestHeaderAction_STATUS</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleResponseHeaderAction_STATUS</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>Storage version of v1api20210601.OriginGroupOverrideAction_STATUS</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRouteConfigurationOverrideAction_STATUS</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRedirectAction_STATUS</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>Storage version of v1api20210601.UrlRewriteAction_STATUS</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>Storage version of v1api20210601.UrlSigningAction_STATUS</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActionsUrlSigning? UrlSigning { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPortParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.ClientPortMatchConditionParameters_STATUS Defines the parameters for ClientPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPortParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsCookiesParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsCookies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.CookiesMatchConditionParameters_STATUS Defines the parameters for Cookies match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsCookiesParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHostNameParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHostName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HostNameMatchConditionParameters_STATUS Defines the parameters for HostName match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHostNameParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersionParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.HttpVersionMatchConditionParameters_STATUS Defines the parameters for HttpVersion match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersionParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDeviceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDevice
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.IsDeviceMatchConditionParameters_STATUS Defines the parameters for IsDevice match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDeviceParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgsParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.PostArgsMatchConditionParameters_STATUS Defines the parameters for PostArgs match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgsParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryStringParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.QueryStringMatchConditionParameters_STATUS Defines the parameters for QueryString match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryStringParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddressParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RemoteAddressMatchConditionParameters_STATUS Defines the parameters for RemoteAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddressParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBodyParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBody
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestBodyMatchConditionParameters_STATUS Defines the parameters for RequestBody match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBodyParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeaderParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestHeaderMatchConditionParameters_STATUS Defines the parameters for RequestHeader match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeaderParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethodParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethod
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestMethodMatchConditionParameters_STATUS Defines the parameters for RequestMethod match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethodParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestSchemeParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestScheme
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestSchemeMatchConditionParameters_STATUS Defines the parameters for RequestScheme match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestSchemeParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUriParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUri
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.RequestUriMatchConditionParameters_STATUS Defines the parameters for RequestUri match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUriParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPortParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.ServerPortMatchConditionParameters_STATUS Defines the parameters for ServerPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPortParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddrParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddr
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.SocketAddrMatchConditionParameters_STATUS Defines the parameters for SocketAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddrParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocolParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocol
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.SslProtocolMatchConditionParameters_STATUS Defines the parameters for SslProtocol match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocolParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtensionParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtension
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlFileExtensionMatchConditionParameters_STATUS Defines the parameters for UrlFileExtension match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtensionParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileNameParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlFileNameMatchConditionParameters_STATUS Defines the parameters for UrlFilename match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileNameParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPathParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPath
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210601.UrlPathMatchConditionParameters_STATUS Defines the parameters for UrlPath match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPathParameters? Parameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleClientPortCondition_STATUS</summary>
    [JsonPropertyName("clientPort")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsClientPort? ClientPort { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleCookiesCondition_STATUS</summary>
    [JsonPropertyName("cookies")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsCookies? Cookies { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleHostNameCondition_STATUS</summary>
    [JsonPropertyName("hostName")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHostName? HostName { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleHttpVersionCondition_STATUS</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleIsDeviceCondition_STATUS</summary>
    [JsonPropertyName("isDevice")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsIsDevice? IsDevice { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRulePostArgsCondition_STATUS</summary>
    [JsonPropertyName("postArgs")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsPostArgs? PostArgs { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleQueryStringCondition_STATUS</summary>
    [JsonPropertyName("queryString")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsQueryString? QueryString { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRemoteAddressCondition_STATUS</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestBodyCondition_STATUS</summary>
    [JsonPropertyName("requestBody")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestBody? RequestBody { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestHeaderCondition_STATUS</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestMethodCondition_STATUS</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestSchemeCondition_STATUS</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleRequestUriCondition_STATUS</summary>
    [JsonPropertyName("requestUri")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsRequestUri? RequestUri { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleServerPortCondition_STATUS</summary>
    [JsonPropertyName("serverPort")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsServerPort? ServerPort { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleSocketAddrCondition_STATUS</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleSslProtocolCondition_STATUS</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleUrlFileExtensionCondition_STATUS</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleUrlFileNameCondition_STATUS</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>Storage version of v1api20210601.DeliveryRuleUrlPathCondition_STATUS</summary>
    [JsonPropertyName("urlPath")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditionsUrlPath? UrlPath { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicyRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actions")]
    public IList<V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesActions>? Actions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601storageProfilesEndpointStatusDeliveryPolicyRulesConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusDeliveryPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20210601storageProfilesEndpointStatusDeliveryPolicyRules>? Rules { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusGeoFilters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusOriginGroupsHealthProbeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probeRequestType")]
    public string? ProbeRequestType { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusOriginGroupsOrigins
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("begin")]
    public int? Begin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public int? End { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpErrorRanges")]
    public IList<V1api20210601storageProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettingsHttpErrorRanges>? HttpErrorRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("responseBasedDetectedErrorTypes")]
    public string? ResponseBasedDetectedErrorTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("responseBasedFailoverThresholdPercentage")]
    public int? ResponseBasedFailoverThresholdPercentage { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusOriginGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.HealthProbeParameters_STATUS The JSON object that contains the properties to send health probes to origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20210601storageProfilesEndpointStatusOriginGroupsHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("origins")]
    public IList<V1api20210601storageProfilesEndpointStatusOriginGroupsOrigins>? Origins { get; set; }

    /// <summary>Storage version of v1api20210601.ResponseBasedOriginErrorDetectionParameters_STATUS The JSON object that contains the properties to determine origin health using real requests/responses.</summary>
    [JsonPropertyName("responseBasedOriginErrorDetectionSettings")]
    public V1api20210601storageProfilesEndpointStatusOriginGroupsResponseBasedOriginErrorDetectionSettings? ResponseBasedOriginErrorDetectionSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusOrigins
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointStatus")]
    public string? PrivateEndpointStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkAlias")]
    public string? PrivateLinkAlias { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkApprovalMessage")]
    public string? PrivateLinkApprovalMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkLocation")]
    public string? PrivateLinkLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusUrlSigningKeysKeySourceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretVersion")]
    public string? SecretVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusUrlSigningKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Storage version of v1api20210601.KeyVaultSigningKeyParameters_STATUS Describes the parameters for using a user's KeyVault for URL Signing Key.</summary>
    [JsonPropertyName("keySourceParameters")]
    public V1api20210601storageProfilesEndpointStatusUrlSigningKeysKeySourceParameters? KeySourceParameters { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatusWebApplicationFirewallPolicyLink
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20210601storageProfilesEndpointStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601storageProfilesEndpointStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customDomains")]
    public IList<V1api20210601storageProfilesEndpointStatusCustomDomains>? CustomDomains { get; set; }

    /// <summary>Storage version of v1api20210601.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("defaultOriginGroup")]
    public V1api20210601storageProfilesEndpointStatusDefaultOriginGroup? DefaultOriginGroup { get; set; }

    /// <summary>Storage version of v1api20210601.EndpointProperties_DeliveryPolicy_STATUS</summary>
    [JsonPropertyName("deliveryPolicy")]
    public V1api20210601storageProfilesEndpointStatusDeliveryPolicy? DeliveryPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("geoFilters")]
    public IList<V1api20210601storageProfilesEndpointStatusGeoFilters>? GeoFilters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originGroups")]
    public IList<V1api20210601storageProfilesEndpointStatusOriginGroups>? OriginGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("origins")]
    public IList<V1api20210601storageProfilesEndpointStatusOrigins>? Origins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary>Storage version of v1api20210601.SystemData_STATUS Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20210601storageProfilesEndpointStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlSigningKeys")]
    public IList<V1api20210601storageProfilesEndpointStatusUrlSigningKeys>? UrlSigningKeys { get; set; }

    /// <summary>Storage version of v1api20210601.EndpointProperties_WebApplicationFirewallPolicyLink_STATUS</summary>
    [JsonPropertyName("webApplicationFirewallPolicyLink")]
    public V1api20210601storageProfilesEndpointStatusWebApplicationFirewallPolicyLink? WebApplicationFirewallPolicyLink { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageProfilesEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210601storageProfilesEndpointSpec>, IStatus<V1api20210601storageProfilesEndpointStatus>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "ProfilesEndpoint";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "profilesendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210601.Profiles_Endpoint_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210601storageProfilesEndpointSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210601.Profiles_Endpoint_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20210601storageProfilesEndpointStatus? Status { get; set; }
}