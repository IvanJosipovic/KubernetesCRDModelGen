using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>Storage version of v1api20230501.Route Generator information: - Generated from: /cdn/resource-manager/Microsoft.Cdn/stable/2023-05-01/afdx.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501storageRouteList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501storageRoute>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "RouteList";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "routes";
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
    public IList<V1api20230501storageRoute> Items { get; set; }
}

/// <summary>Storage version of v1api20230501.CompressionSettings settings for compression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecCacheConfigurationCompressionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }
}

/// <summary>Storage version of v1api20230501.AfdRouteCacheConfiguration Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecCacheConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.CompressionSettings settings for compression.</summary>
    [JsonPropertyName("compressionSettings")]
    public V1api20230501storageRouteSpecCacheConfigurationCompressionSettings? CompressionSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecCustomDomainsReference
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

/// <summary>Storage version of v1api20230501.ActivatedResourceReference Reference to another resource along with its state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecCustomDomains
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageRouteSpecCustomDomainsReference? Reference { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230501storageRouteSpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20230501.RouteOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501storageRouteSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501storageRouteSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecOriginGroupReference
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
public partial class V1api20230501storageRouteSpecOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageRouteSpecOriginGroupReference? Reference { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/AfdEndpoint resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpecRuleSetsReference
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
public partial class V1api20230501storageRouteSpecRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageRouteSpecRuleSetsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20230501.Route_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20230501.AfdRouteCacheConfiguration Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501storageRouteSpecCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customDomains")]
    public IList<V1api20230501storageRouteSpecCustomDomains>? CustomDomains { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsRedirect")]
    public string? HttpsRedirect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public string? LinkToDefaultDomain { get; set; }

    /// <summary>Storage version of v1api20230501.RouteOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501storageRouteSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501storageRouteSpecOriginGroup? OriginGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/AfdEndpoint resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230501storageRouteSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSets")]
    public IList<V1api20230501storageRouteSpecRuleSets>? RuleSets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }
}

/// <summary>Storage version of v1api20230501.CompressionSettings_STATUS settings for compression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatusCacheConfigurationCompressionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }
}

/// <summary>Storage version of v1api20230501.AfdRouteCacheConfiguration_STATUS Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatusCacheConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.CompressionSettings_STATUS settings for compression.</summary>
    [JsonPropertyName("compressionSettings")]
    public V1api20230501storageRouteStatusCacheConfigurationCompressionSettings? CompressionSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatusConditions
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

/// <summary>Storage version of v1api20230501.ActivatedResourceReference_STATUS_Profiles_AfdEndpoints_Route_SubResourceEmbedded Reference to another resource along with its state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatusCustomDomains
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatusOriginGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatusRuleSets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatusSystemData
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

/// <summary>Storage version of v1api20230501.Route_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501storageRouteStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.AfdRouteCacheConfiguration_STATUS Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object.</summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501storageRouteStatusCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501storageRouteStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customDomains")]
    public IList<V1api20230501storageRouteStatusCustomDomains>? CustomDomains { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsRedirect")]
    public string? HttpsRedirect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public string? LinkToDefaultDomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501storageRouteStatusOriginGroup? OriginGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ruleSets")]
    public IList<V1api20230501storageRouteStatusRuleSets>? RuleSets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }

    /// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501storageRouteStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230501.Route Generator information: - Generated from: /cdn/resource-manager/Microsoft.Cdn/stable/2023-05-01/afdx.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501storageRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501storageRouteSpec>, IStatus<V1api20230501storageRouteStatus>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "Route";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "routes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230501.Route_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230501storageRouteSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230501.Route_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230501storageRouteStatus? Status { get; set; }
}