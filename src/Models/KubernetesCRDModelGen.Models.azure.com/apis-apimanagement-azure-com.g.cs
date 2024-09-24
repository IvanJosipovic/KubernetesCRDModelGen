using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.com;
/// <summary>Reference: Identifier for existing API Version Set. Omit this value to create a new Version Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecApiVersionSetReference
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

/// <summary>Storage version of v1api20220801.ApiVersionSetContractDetails An API Version Set contains the common configuration for a set of API Versions relating</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecApiVersionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Identifier for existing API Version Set. Omit this value to create a new Version Set.</summary>
    [JsonPropertyName("reference")]
    public V1api20220801storageApiSpecApiVersionSetReference? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionHeaderName")]
    public string? VersionHeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionQueryName")]
    public string? VersionQueryName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versioningScheme")]
    public string? VersioningScheme { get; set; }
}

/// <summary>Storage version of v1api20220801.OAuth2AuthenticationSettingsContract API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecAuthenticationSettingsOAuth2
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Storage version of v1api20220801.OAuth2AuthenticationSettingsContract API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecAuthenticationSettingsOAuth2AuthenticationSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Storage version of v1api20220801.OpenIdAuthenticationSettingsContract API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecAuthenticationSettingsOpenid
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>Storage version of v1api20220801.OpenIdAuthenticationSettingsContract API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecAuthenticationSettingsOpenidAuthenticationSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>Storage version of v1api20220801.AuthenticationSettingsContract API Authentication Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecAuthenticationSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.OAuth2AuthenticationSettingsContract API OAuth2 Authentication settings details.</summary>
    [JsonPropertyName("oAuth2")]
    public V1api20220801storageApiSpecAuthenticationSettingsOAuth2? OAuth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oAuth2AuthenticationSettings")]
    public IList<V1api20220801storageApiSpecAuthenticationSettingsOAuth2AuthenticationSettings>? OAuth2AuthenticationSettings { get; set; }

    /// <summary>Storage version of v1api20220801.OpenIdAuthenticationSettingsContract API OAuth2 Authentication settings details.</summary>
    [JsonPropertyName("openid")]
    public V1api20220801storageApiSpecAuthenticationSettingsOpenid? Openid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openidAuthenticationSettings")]
    public IList<V1api20220801storageApiSpecAuthenticationSettingsOpenidAuthenticationSettings>? OpenidAuthenticationSettings { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiContactInformation API contact information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecContact
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiLicenseInformation API license information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecLicense
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a apimanagement.azure.com/Service resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SourceApiReference: API identifier of the source API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecSourceApiReference
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

/// <summary>Storage version of v1api20220801.SubscriptionKeyParameterNamesContract Subscription key parameter names details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecSubscriptionKeyParameterNames
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiCreateOrUpdateProperties_WsdlSelector</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpecWsdlSelector
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("wsdlEndpointName")]
    public string? WsdlEndpointName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("wsdlServiceName")]
    public string? WsdlServiceName { get; set; }
}

/// <summary>Storage version of v1api20220801.Service_Api_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiRevision")]
    public string? ApiRevision { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiRevisionDescription")]
    public string? ApiRevisionDescription { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiVersionDescription")]
    public string? ApiVersionDescription { get; set; }

    /// <summary>Storage version of v1api20220801.ApiVersionSetContractDetails An API Version Set contains the common configuration for a set of API Versions relating</summary>
    [JsonPropertyName("apiVersionSet")]
    public V1api20220801storageApiSpecApiVersionSet? ApiVersionSet { get; set; }

    /// <summary>ApiVersionSetReference: A resource identifier for the related ApiVersionSet.</summary>
    [JsonPropertyName("apiVersionSetReference")]
    public V1api20220801storageApiSpecApiVersionSetReference? ApiVersionSetReference { get; set; }

    /// <summary>Storage version of v1api20220801.AuthenticationSettingsContract API Authentication Settings.</summary>
    [JsonPropertyName("authenticationSettings")]
    public V1api20220801storageApiSpecAuthenticationSettings? AuthenticationSettings { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20220801.ApiContactInformation API contact information</summary>
    [JsonPropertyName("contact")]
    public V1api20220801storageApiSpecContact? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary>Storage version of v1api20220801.ApiLicenseInformation API license information</summary>
    [JsonPropertyName("license")]
    public V1api20220801storageApiSpecLicense? License { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a apimanagement.azure.com/Service resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220801storageApiSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>SourceApiReference: API identifier of the source API.</summary>
    [JsonPropertyName("sourceApiReference")]
    public V1api20220801storageApiSpecSourceApiReference? SourceApiReference { get; set; }

    /// <summary>Storage version of v1api20220801.SubscriptionKeyParameterNamesContract Subscription key parameter names details.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V1api20220801storageApiSpecSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("translateRequiredQueryParameters")]
    public string? TranslateRequiredQueryParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Storage version of v1api20220801.ApiCreateOrUpdateProperties_WsdlSelector</summary>
    [JsonPropertyName("wsdlSelector")]
    public V1api20220801storageApiSpecWsdlSelector? WsdlSelector { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiVersionSetContractDetails_STATUS An API Version Set contains the common configuration for a set of API Versions relating</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusApiVersionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionHeaderName")]
    public string? VersionHeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionQueryName")]
    public string? VersionQueryName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versioningScheme")]
    public string? VersioningScheme { get; set; }
}

/// <summary>Storage version of v1api20220801.OAuth2AuthenticationSettingsContract_STATUS API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusAuthenticationSettingsOAuth2
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Storage version of v1api20220801.OAuth2AuthenticationSettingsContract_STATUS API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusAuthenticationSettingsOAuth2AuthenticationSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Storage version of v1api20220801.OpenIdAuthenticationSettingsContract_STATUS API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusAuthenticationSettingsOpenid
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>Storage version of v1api20220801.OpenIdAuthenticationSettingsContract_STATUS API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusAuthenticationSettingsOpenidAuthenticationSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>Storage version of v1api20220801.AuthenticationSettingsContract_STATUS API Authentication Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusAuthenticationSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220801.OAuth2AuthenticationSettingsContract_STATUS API OAuth2 Authentication settings details.</summary>
    [JsonPropertyName("oAuth2")]
    public V1api20220801storageApiStatusAuthenticationSettingsOAuth2? OAuth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oAuth2AuthenticationSettings")]
    public IList<V1api20220801storageApiStatusAuthenticationSettingsOAuth2AuthenticationSettings>? OAuth2AuthenticationSettings { get; set; }

    /// <summary>Storage version of v1api20220801.OpenIdAuthenticationSettingsContract_STATUS API OAuth2 Authentication settings details.</summary>
    [JsonPropertyName("openid")]
    public V1api20220801storageApiStatusAuthenticationSettingsOpenid? Openid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("openidAuthenticationSettings")]
    public IList<V1api20220801storageApiStatusAuthenticationSettingsOpenidAuthenticationSettings>? OpenidAuthenticationSettings { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusConditions
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

/// <summary>Storage version of v1api20220801.ApiContactInformation_STATUS API contact information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusContact
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Storage version of v1api20220801.ApiLicenseInformation_STATUS API license information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusLicense
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Storage version of v1api20220801.SubscriptionKeyParameterNamesContract_STATUS Subscription key parameter names details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatusSubscriptionKeyParameterNames
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary>Storage version of v1api20220801.Service_Api_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220801storageApiStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiRevision")]
    public string? ApiRevision { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiRevisionDescription")]
    public string? ApiRevisionDescription { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiVersionDescription")]
    public string? ApiVersionDescription { get; set; }

    /// <summary>Storage version of v1api20220801.ApiVersionSetContractDetails_STATUS An API Version Set contains the common configuration for a set of API Versions relating</summary>
    [JsonPropertyName("apiVersionSet")]
    public V1api20220801storageApiStatusApiVersionSet? ApiVersionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiVersionSetId")]
    public string? ApiVersionSetId { get; set; }

    /// <summary>Storage version of v1api20220801.AuthenticationSettingsContract_STATUS API Authentication Settings.</summary>
    [JsonPropertyName("authenticationSettings")]
    public V1api20220801storageApiStatusAuthenticationSettings? AuthenticationSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220801storageApiStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20220801.ApiContactInformation_STATUS API contact information</summary>
    [JsonPropertyName("contact")]
    public V1api20220801storageApiStatusContact? Contact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>Storage version of v1api20220801.ApiLicenseInformation_STATUS API license information</summary>
    [JsonPropertyName("license")]
    public V1api20220801storageApiStatusLicense? License { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>Storage version of v1api20220801.SubscriptionKeyParameterNamesContract_STATUS Subscription key parameter names details.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V1api20220801storageApiStatusSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220801.Api Generator information: - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/apimapis.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220801storageApi : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220801storageApiSpec>, IStatus<V1api20220801storageApiStatus>
{
    public const string KubeApiVersion = "v1api20220801storage";
    public const string KubeKind = "Api";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apis";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220801.Service_Api_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220801storageApiSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220801.Service_Api_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220801storageApiStatus? Status { get; set; }
}