using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>Storage version of v1api20230501.CacheExpirationActionParameters Defines the parameters for the cache expiration action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsCacheExpirationParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleCacheExpirationAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsCacheExpiration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.CacheExpirationActionParameters Defines the parameters for the cache expiration action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsCacheExpirationParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.CacheKeyQueryStringActionParameters Defines the parameters for the cache-key query string action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsCacheKeyQueryStringParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleCacheKeyQueryStringAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsCacheKeyQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.CacheKeyQueryStringActionParameters Defines the parameters for the cache-key query string action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsCacheKeyQueryStringParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HeaderActionParameters Defines the parameters for the request header action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsModifyRequestHeaderParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsModifyRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HeaderActionParameters Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsModifyRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HeaderActionParameters Defines the parameters for the request header action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsModifyResponseHeaderParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleResponseHeaderAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsModifyResponseHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HeaderActionParameters Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsModifyResponseHeaderParameters? Parameters { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsOriginGroupOverrideParametersOriginGroupReference
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

/// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageRuleSpecActionsOriginGroupOverrideParametersOriginGroupReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20230501.OriginGroupOverrideActionParameters Defines the parameters for the origin group override action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsOriginGroupOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501storageRuleSpecActionsOriginGroupOverrideParametersOriginGroup? OriginGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>Storage version of v1api20230501.OriginGroupOverrideAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.OriginGroupOverrideActionParameters Defines the parameters for the origin group override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsOriginGroupOverrideParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.CacheConfiguration Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersCacheConfiguration
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

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference
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

/// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroupReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20230501.OriginGroupOverride Defines the parameters for the origin group override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

/// <summary>Storage version of v1api20230501.RouteConfigurationOverrideActionParameters Defines the parameters for the route configuration override action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.CacheConfiguration Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>Storage version of v1api20230501.OriginGroupOverride Defines the parameters for the origin group override configuration.</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>Storage version of v1api20230501.DeliveryRuleRouteConfigurationOverrideAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsRouteConfigurationOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RouteConfigurationOverrideActionParameters Defines the parameters for the route configuration override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsRouteConfigurationOverrideParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlRedirectActionParameters Defines the parameters for the url redirect action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsUrlRedirectParameters
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

/// <summary>Storage version of v1api20230501.UrlRedirectAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsUrlRedirect
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRedirectActionParameters Defines the parameters for the url redirect action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsUrlRedirectParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlRewriteActionParameters Defines the parameters for the url rewrite action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsUrlRewriteParameters
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

/// <summary>Storage version of v1api20230501.UrlRewriteAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsUrlRewrite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRewriteActionParameters Defines the parameters for the url rewrite action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsUrlRewriteParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlSigningParamIdentifier Defines how to identify a parameter for a specific purpose e.g. expires</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsUrlSigningParametersParameterNameOverride
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

/// <summary>Storage version of v1api20230501.UrlSigningActionParameters Defines the parameters for the Url Signing action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsUrlSigningParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20230501storageRuleSpecActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlSigningAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActionsUrlSigning
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlSigningActionParameters Defines the parameters for the Url Signing action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecActionsUrlSigningParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.DeliveryRuleAction An action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecActions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleCacheExpirationAction</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20230501storageRuleSpecActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleCacheKeyQueryStringAction</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20230501storageRuleSpecActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderAction</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20230501storageRuleSpecActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleResponseHeaderAction</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20230501storageRuleSpecActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>Storage version of v1api20230501.OriginGroupOverrideAction</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501storageRuleSpecActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRouteConfigurationOverrideAction</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20230501storageRuleSpecActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRedirectAction</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20230501storageRuleSpecActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRewriteAction</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20230501storageRuleSpecActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>Storage version of v1api20230501.UrlSigningAction</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20230501storageRuleSpecActionsUrlSigning? UrlSigning { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20230501.RuleOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501storageRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501storageRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/RuleSet resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230501.ClientPortMatchConditionParameters Defines the parameters for ClientPort match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsClientPortParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleClientPortCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsClientPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.ClientPortMatchConditionParameters Defines the parameters for ClientPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsClientPortParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.CookiesMatchConditionParameters Defines the parameters for Cookies match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsCookiesParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleCookiesCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsCookies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.CookiesMatchConditionParameters Defines the parameters for Cookies match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsCookiesParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HostNameMatchConditionParameters Defines the parameters for HostName match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsHostNameParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleHostNameCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsHostName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HostNameMatchConditionParameters Defines the parameters for HostName match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsHostNameParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HttpVersionMatchConditionParameters Defines the parameters for HttpVersion match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsHttpVersionParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleHttpVersionCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsHttpVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HttpVersionMatchConditionParameters Defines the parameters for HttpVersion match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsHttpVersionParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.IsDeviceMatchConditionParameters Defines the parameters for IsDevice match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsIsDeviceParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleIsDeviceCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsIsDevice
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.IsDeviceMatchConditionParameters Defines the parameters for IsDevice match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsIsDeviceParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.PostArgsMatchConditionParameters Defines the parameters for PostArgs match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsPostArgsParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRulePostArgsCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsPostArgs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.PostArgsMatchConditionParameters Defines the parameters for PostArgs match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsPostArgsParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.QueryStringMatchConditionParameters Defines the parameters for QueryString match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsQueryStringParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleQueryStringCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.QueryStringMatchConditionParameters Defines the parameters for QueryString match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsQueryStringParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RemoteAddressMatchConditionParameters Defines the parameters for RemoteAddress match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRemoteAddressParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRemoteAddressCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRemoteAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RemoteAddressMatchConditionParameters Defines the parameters for RemoteAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsRemoteAddressParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestBodyMatchConditionParameters Defines the parameters for RequestBody match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestBodyParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestBodyCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestBody
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestBodyMatchConditionParameters Defines the parameters for RequestBody match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsRequestBodyParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestHeaderMatchConditionParameters Defines the parameters for RequestHeader match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestHeaderParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestHeaderMatchConditionParameters Defines the parameters for RequestHeader match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestMethodMatchConditionParameters Defines the parameters for RequestMethod match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestMethodParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestMethodCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestMethod
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestMethodMatchConditionParameters Defines the parameters for RequestMethod match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsRequestMethodParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestSchemeMatchConditionParameters Defines the parameters for RequestScheme match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestSchemeParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestSchemeCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestScheme
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestSchemeMatchConditionParameters Defines the parameters for RequestScheme match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsRequestSchemeParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestUriMatchConditionParameters Defines the parameters for RequestUri match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestUriParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestUriCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsRequestUri
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestUriMatchConditionParameters Defines the parameters for RequestUri match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsRequestUriParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.ServerPortMatchConditionParameters Defines the parameters for ServerPort match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsServerPortParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleServerPortCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsServerPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.ServerPortMatchConditionParameters Defines the parameters for ServerPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsServerPortParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.SocketAddrMatchConditionParameters Defines the parameters for SocketAddress match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsSocketAddrParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleSocketAddrCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsSocketAddr
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.SocketAddrMatchConditionParameters Defines the parameters for SocketAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsSocketAddrParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.SslProtocolMatchConditionParameters Defines the parameters for SslProtocol match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsSslProtocolParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleSslProtocolCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsSslProtocol
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.SslProtocolMatchConditionParameters Defines the parameters for SslProtocol match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsSslProtocolParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlFileExtensionMatchConditionParameters Defines the parameters for UrlFileExtension match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsUrlFileExtensionParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileExtensionCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsUrlFileExtension
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlFileExtensionMatchConditionParameters Defines the parameters for UrlFileExtension match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsUrlFileExtensionParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlFileNameMatchConditionParameters Defines the parameters for UrlFilename match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsUrlFileNameParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileNameCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsUrlFileName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlFileNameMatchConditionParameters Defines the parameters for UrlFilename match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsUrlFileNameParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlPathMatchConditionParameters Defines the parameters for UrlPath match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsUrlPathParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleUrlPathCondition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditionsUrlPath
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlPathMatchConditionParameters Defines the parameters for UrlPath match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleSpecRuleconditionsUrlPathParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.DeliveryRuleCondition A condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpecRuleconditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleClientPortCondition</summary>
    [JsonPropertyName("clientPort")]
    public V1api20230501storageRuleSpecRuleconditionsClientPort? ClientPort { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleCookiesCondition</summary>
    [JsonPropertyName("cookies")]
    public V1api20230501storageRuleSpecRuleconditionsCookies? Cookies { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleHostNameCondition</summary>
    [JsonPropertyName("hostName")]
    public V1api20230501storageRuleSpecRuleconditionsHostName? HostName { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleHttpVersionCondition</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20230501storageRuleSpecRuleconditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleIsDeviceCondition</summary>
    [JsonPropertyName("isDevice")]
    public V1api20230501storageRuleSpecRuleconditionsIsDevice? IsDevice { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRulePostArgsCondition</summary>
    [JsonPropertyName("postArgs")]
    public V1api20230501storageRuleSpecRuleconditionsPostArgs? PostArgs { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleQueryStringCondition</summary>
    [JsonPropertyName("queryString")]
    public V1api20230501storageRuleSpecRuleconditionsQueryString? QueryString { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRemoteAddressCondition</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20230501storageRuleSpecRuleconditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestBodyCondition</summary>
    [JsonPropertyName("requestBody")]
    public V1api20230501storageRuleSpecRuleconditionsRequestBody? RequestBody { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderCondition</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20230501storageRuleSpecRuleconditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestMethodCondition</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20230501storageRuleSpecRuleconditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestSchemeCondition</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20230501storageRuleSpecRuleconditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestUriCondition</summary>
    [JsonPropertyName("requestUri")]
    public V1api20230501storageRuleSpecRuleconditionsRequestUri? RequestUri { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleServerPortCondition</summary>
    [JsonPropertyName("serverPort")]
    public V1api20230501storageRuleSpecRuleconditionsServerPort? ServerPort { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleSocketAddrCondition</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20230501storageRuleSpecRuleconditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleSslProtocolCondition</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20230501storageRuleSpecRuleconditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileExtensionCondition</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20230501storageRuleSpecRuleconditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileNameCondition</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20230501storageRuleSpecRuleconditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleUrlPathCondition</summary>
    [JsonPropertyName("urlPath")]
    public V1api20230501storageRuleSpecRuleconditionsUrlPath? UrlPath { get; set; }
}

/// <summary>Storage version of v1api20230501.Rule_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actions")]
    public IList<V1api20230501storageRuleSpecActions>? Actions { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchProcessingBehavior")]
    public string? MatchProcessingBehavior { get; set; }

    /// <summary>Storage version of v1api20230501.RuleOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501storageRuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/RuleSet resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230501storageRuleSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleconditions")]
    public IList<V1api20230501storageRuleSpecRuleconditions>? Ruleconditions { get; set; }
}

/// <summary>Storage version of v1api20230501.CacheExpirationActionParameters_STATUS Defines the parameters for the cache expiration action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsCacheExpirationParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleCacheExpirationAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsCacheExpiration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.CacheExpirationActionParameters_STATUS Defines the parameters for the cache expiration action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsCacheExpirationParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.CacheKeyQueryStringActionParameters_STATUS Defines the parameters for the cache-key query string action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsCacheKeyQueryStringParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleCacheKeyQueryStringAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsCacheKeyQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.CacheKeyQueryStringActionParameters_STATUS Defines the parameters for the cache-key query string action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsCacheKeyQueryStringParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HeaderActionParameters_STATUS Defines the parameters for the request header action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsModifyRequestHeaderParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsModifyRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HeaderActionParameters_STATUS Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsModifyRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HeaderActionParameters_STATUS Defines the parameters for the request header action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsModifyResponseHeaderParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleResponseHeaderAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsModifyResponseHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HeaderActionParameters_STATUS Defines the parameters for the request header action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsModifyResponseHeaderParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsOriginGroupOverrideParametersOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.OriginGroupOverrideActionParameters_STATUS Defines the parameters for the origin group override action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsOriginGroupOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501storageRuleStatusActionsOriginGroupOverrideParametersOriginGroup? OriginGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>Storage version of v1api20230501.OriginGroupOverrideAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.OriginGroupOverrideActionParameters_STATUS Defines the parameters for the origin group override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsOriginGroupOverrideParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.CacheConfiguration_STATUS Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParametersCacheConfiguration
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

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.OriginGroupOverride_STATUS Defines the parameters for the origin group override configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverrideOriginGroup? OriginGroup { get; set; }
}

/// <summary>Storage version of v1api20230501.RouteConfigurationOverrideActionParameters_STATUS Defines the parameters for the route configuration override action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.CacheConfiguration_STATUS Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParametersCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>Storage version of v1api20230501.OriginGroupOverride_STATUS Defines the parameters for the origin group override configuration.</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParametersOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>Storage version of v1api20230501.DeliveryRuleRouteConfigurationOverrideAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsRouteConfigurationOverride
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RouteConfigurationOverrideActionParameters_STATUS Defines the parameters for the route configuration override action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsRouteConfigurationOverrideParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlRedirectActionParameters_STATUS Defines the parameters for the url redirect action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsUrlRedirectParameters
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

/// <summary>Storage version of v1api20230501.UrlRedirectAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsUrlRedirect
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRedirectActionParameters_STATUS Defines the parameters for the url redirect action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsUrlRedirectParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlRewriteActionParameters_STATUS Defines the parameters for the url rewrite action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsUrlRewriteParameters
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

/// <summary>Storage version of v1api20230501.UrlRewriteAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsUrlRewrite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRewriteActionParameters_STATUS Defines the parameters for the url rewrite action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsUrlRewriteParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlSigningParamIdentifier_STATUS Defines how to identify a parameter for a specific purpose e.g. expires</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsUrlSigningParametersParameterNameOverride
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

/// <summary>Storage version of v1api20230501.UrlSigningActionParameters_STATUS Defines the parameters for the Url Signing action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsUrlSigningParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameterNameOverride")]
    public IList<V1api20230501storageRuleStatusActionsUrlSigningParametersParameterNameOverride>? ParameterNameOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlSigningAction_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActionsUrlSigning
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlSigningActionParameters_STATUS Defines the parameters for the Url Signing action.</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusActionsUrlSigningParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.DeliveryRuleAction_STATUS An action for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusActions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleCacheExpirationAction_STATUS</summary>
    [JsonPropertyName("cacheExpiration")]
    public V1api20230501storageRuleStatusActionsCacheExpiration? CacheExpiration { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleCacheKeyQueryStringAction_STATUS</summary>
    [JsonPropertyName("cacheKeyQueryString")]
    public V1api20230501storageRuleStatusActionsCacheKeyQueryString? CacheKeyQueryString { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderAction_STATUS</summary>
    [JsonPropertyName("modifyRequestHeader")]
    public V1api20230501storageRuleStatusActionsModifyRequestHeader? ModifyRequestHeader { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleResponseHeaderAction_STATUS</summary>
    [JsonPropertyName("modifyResponseHeader")]
    public V1api20230501storageRuleStatusActionsModifyResponseHeader? ModifyResponseHeader { get; set; }

    /// <summary>Storage version of v1api20230501.OriginGroupOverrideAction_STATUS</summary>
    [JsonPropertyName("originGroupOverride")]
    public V1api20230501storageRuleStatusActionsOriginGroupOverride? OriginGroupOverride { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRouteConfigurationOverrideAction_STATUS</summary>
    [JsonPropertyName("routeConfigurationOverride")]
    public V1api20230501storageRuleStatusActionsRouteConfigurationOverride? RouteConfigurationOverride { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRedirectAction_STATUS</summary>
    [JsonPropertyName("urlRedirect")]
    public V1api20230501storageRuleStatusActionsUrlRedirect? UrlRedirect { get; set; }

    /// <summary>Storage version of v1api20230501.UrlRewriteAction_STATUS</summary>
    [JsonPropertyName("urlRewrite")]
    public V1api20230501storageRuleStatusActionsUrlRewrite? UrlRewrite { get; set; }

    /// <summary>Storage version of v1api20230501.UrlSigningAction_STATUS</summary>
    [JsonPropertyName("urlSigning")]
    public V1api20230501storageRuleStatusActionsUrlSigning? UrlSigning { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusConditions
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

/// <summary>Storage version of v1api20230501.ClientPortMatchConditionParameters_STATUS Defines the parameters for ClientPort match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsClientPortParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleClientPortCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsClientPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.ClientPortMatchConditionParameters_STATUS Defines the parameters for ClientPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsClientPortParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.CookiesMatchConditionParameters_STATUS Defines the parameters for Cookies match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsCookiesParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleCookiesCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsCookies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.CookiesMatchConditionParameters_STATUS Defines the parameters for Cookies match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsCookiesParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HostNameMatchConditionParameters_STATUS Defines the parameters for HostName match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsHostNameParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleHostNameCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsHostName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HostNameMatchConditionParameters_STATUS Defines the parameters for HostName match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsHostNameParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.HttpVersionMatchConditionParameters_STATUS Defines the parameters for HttpVersion match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsHttpVersionParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleHttpVersionCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsHttpVersion
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.HttpVersionMatchConditionParameters_STATUS Defines the parameters for HttpVersion match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsHttpVersionParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.IsDeviceMatchConditionParameters_STATUS Defines the parameters for IsDevice match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsIsDeviceParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleIsDeviceCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsIsDevice
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.IsDeviceMatchConditionParameters_STATUS Defines the parameters for IsDevice match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsIsDeviceParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.PostArgsMatchConditionParameters_STATUS Defines the parameters for PostArgs match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsPostArgsParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRulePostArgsCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsPostArgs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.PostArgsMatchConditionParameters_STATUS Defines the parameters for PostArgs match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsPostArgsParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.QueryStringMatchConditionParameters_STATUS Defines the parameters for QueryString match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsQueryStringParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleQueryStringCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsQueryString
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.QueryStringMatchConditionParameters_STATUS Defines the parameters for QueryString match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsQueryStringParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RemoteAddressMatchConditionParameters_STATUS Defines the parameters for RemoteAddress match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRemoteAddressParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRemoteAddressCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRemoteAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RemoteAddressMatchConditionParameters_STATUS Defines the parameters for RemoteAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsRemoteAddressParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestBodyMatchConditionParameters_STATUS Defines the parameters for RequestBody match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestBodyParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestBodyCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestBody
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestBodyMatchConditionParameters_STATUS Defines the parameters for RequestBody match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsRequestBodyParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestHeaderMatchConditionParameters_STATUS Defines the parameters for RequestHeader match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestHeaderParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestHeader
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestHeaderMatchConditionParameters_STATUS Defines the parameters for RequestHeader match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsRequestHeaderParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestMethodMatchConditionParameters_STATUS Defines the parameters for RequestMethod match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestMethodParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestMethodCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestMethod
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestMethodMatchConditionParameters_STATUS Defines the parameters for RequestMethod match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsRequestMethodParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestSchemeMatchConditionParameters_STATUS Defines the parameters for RequestScheme match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestSchemeParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestSchemeCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestScheme
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestSchemeMatchConditionParameters_STATUS Defines the parameters for RequestScheme match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsRequestSchemeParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.RequestUriMatchConditionParameters_STATUS Defines the parameters for RequestUri match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestUriParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleRequestUriCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsRequestUri
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.RequestUriMatchConditionParameters_STATUS Defines the parameters for RequestUri match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsRequestUriParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.ServerPortMatchConditionParameters_STATUS Defines the parameters for ServerPort match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsServerPortParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleServerPortCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsServerPort
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.ServerPortMatchConditionParameters_STATUS Defines the parameters for ServerPort match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsServerPortParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.SocketAddrMatchConditionParameters_STATUS Defines the parameters for SocketAddress match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsSocketAddrParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleSocketAddrCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsSocketAddr
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.SocketAddrMatchConditionParameters_STATUS Defines the parameters for SocketAddress match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsSocketAddrParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.SslProtocolMatchConditionParameters_STATUS Defines the parameters for SslProtocol match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsSslProtocolParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleSslProtocolCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsSslProtocol
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.SslProtocolMatchConditionParameters_STATUS Defines the parameters for SslProtocol match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsSslProtocolParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlFileExtensionMatchConditionParameters_STATUS Defines the parameters for UrlFileExtension match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsUrlFileExtensionParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileExtensionCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsUrlFileExtension
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlFileExtensionMatchConditionParameters_STATUS Defines the parameters for UrlFileExtension match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsUrlFileExtensionParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlFileNameMatchConditionParameters_STATUS Defines the parameters for UrlFilename match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsUrlFileNameParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileNameCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsUrlFileName
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlFileNameMatchConditionParameters_STATUS Defines the parameters for UrlFilename match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsUrlFileNameParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.UrlPathMatchConditionParameters_STATUS Defines the parameters for UrlPath match conditions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsUrlPathParameters
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

/// <summary>Storage version of v1api20230501.DeliveryRuleUrlPathCondition_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditionsUrlPath
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.UrlPathMatchConditionParameters_STATUS Defines the parameters for UrlPath match conditions</summary>
    [JsonPropertyName("parameters")]
    public V1api20230501storageRuleStatusRuleconditionsUrlPathParameters? Parameters { get; set; }
}

/// <summary>Storage version of v1api20230501.DeliveryRuleCondition_STATUS A condition for the delivery rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusRuleconditions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleClientPortCondition_STATUS</summary>
    [JsonPropertyName("clientPort")]
    public V1api20230501storageRuleStatusRuleconditionsClientPort? ClientPort { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleCookiesCondition_STATUS</summary>
    [JsonPropertyName("cookies")]
    public V1api20230501storageRuleStatusRuleconditionsCookies? Cookies { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleHostNameCondition_STATUS</summary>
    [JsonPropertyName("hostName")]
    public V1api20230501storageRuleStatusRuleconditionsHostName? HostName { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleHttpVersionCondition_STATUS</summary>
    [JsonPropertyName("httpVersion")]
    public V1api20230501storageRuleStatusRuleconditionsHttpVersion? HttpVersion { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleIsDeviceCondition_STATUS</summary>
    [JsonPropertyName("isDevice")]
    public V1api20230501storageRuleStatusRuleconditionsIsDevice? IsDevice { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRulePostArgsCondition_STATUS</summary>
    [JsonPropertyName("postArgs")]
    public V1api20230501storageRuleStatusRuleconditionsPostArgs? PostArgs { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleQueryStringCondition_STATUS</summary>
    [JsonPropertyName("queryString")]
    public V1api20230501storageRuleStatusRuleconditionsQueryString? QueryString { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRemoteAddressCondition_STATUS</summary>
    [JsonPropertyName("remoteAddress")]
    public V1api20230501storageRuleStatusRuleconditionsRemoteAddress? RemoteAddress { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestBodyCondition_STATUS</summary>
    [JsonPropertyName("requestBody")]
    public V1api20230501storageRuleStatusRuleconditionsRequestBody? RequestBody { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestHeaderCondition_STATUS</summary>
    [JsonPropertyName("requestHeader")]
    public V1api20230501storageRuleStatusRuleconditionsRequestHeader? RequestHeader { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestMethodCondition_STATUS</summary>
    [JsonPropertyName("requestMethod")]
    public V1api20230501storageRuleStatusRuleconditionsRequestMethod? RequestMethod { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestSchemeCondition_STATUS</summary>
    [JsonPropertyName("requestScheme")]
    public V1api20230501storageRuleStatusRuleconditionsRequestScheme? RequestScheme { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleRequestUriCondition_STATUS</summary>
    [JsonPropertyName("requestUri")]
    public V1api20230501storageRuleStatusRuleconditionsRequestUri? RequestUri { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleServerPortCondition_STATUS</summary>
    [JsonPropertyName("serverPort")]
    public V1api20230501storageRuleStatusRuleconditionsServerPort? ServerPort { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleSocketAddrCondition_STATUS</summary>
    [JsonPropertyName("socketAddr")]
    public V1api20230501storageRuleStatusRuleconditionsSocketAddr? SocketAddr { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleSslProtocolCondition_STATUS</summary>
    [JsonPropertyName("sslProtocol")]
    public V1api20230501storageRuleStatusRuleconditionsSslProtocol? SslProtocol { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileExtensionCondition_STATUS</summary>
    [JsonPropertyName("urlFileExtension")]
    public V1api20230501storageRuleStatusRuleconditionsUrlFileExtension? UrlFileExtension { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleUrlFileNameCondition_STATUS</summary>
    [JsonPropertyName("urlFileName")]
    public V1api20230501storageRuleStatusRuleconditionsUrlFileName? UrlFileName { get; set; }

    /// <summary>Storage version of v1api20230501.DeliveryRuleUrlPathCondition_STATUS</summary>
    [JsonPropertyName("urlPath")]
    public V1api20230501storageRuleStatusRuleconditionsUrlPath? UrlPath { get; set; }
}

/// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatusSystemData
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

/// <summary>Storage version of v1api20230501.Rule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRuleStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actions")]
    public IList<V1api20230501storageRuleStatusActions>? Actions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501storageRuleStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchProcessingBehavior")]
    public string? MatchProcessingBehavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSetName")]
    public string? RuleSetName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleconditions")]
    public IList<V1api20230501storageRuleStatusRuleconditions>? Ruleconditions { get; set; }

    /// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501storageRuleStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230501.Rule Generator information: - Generated from: /cdn/resource-manager/Microsoft.Cdn/stable/2023-05-01/afdx.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/ruleSets/{ruleSetName}/rules/{ruleName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501storageRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501storageRuleSpec>, IStatus<V1api20230501storageRuleStatus>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "Rule";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "rules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230501.Rule_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230501storageRuleSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230501.Rule_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230501storageRuleStatus? Status { get; set; }
}