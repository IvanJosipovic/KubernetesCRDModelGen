using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
public enum V1beta1APISpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1APISpecForProviderApiManagementNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1APISpecForProviderApiManagementNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1APISpecForProviderApiManagementNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderApiManagementNameRefPolicyResolutionEnum>))]
    public V1beta1APISpecForProviderApiManagementNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderApiManagementNameRefPolicyResolveEnum>))]
    public V1beta1APISpecForProviderApiManagementNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1APISpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APISpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

public enum V1beta1APISpecForProviderApiManagementNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1APISpecForProviderApiManagementNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1APISpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderApiManagementNameSelectorPolicyResolutionEnum>))]
    public V1beta1APISpecForProviderApiManagementNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderApiManagementNameSelectorPolicyResolveEnum>))]
    public V1beta1APISpecForProviderApiManagementNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1APISpecForProviderApiManagementNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APISpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1APISpecForProviderContact
{
    /// <summary>The email address of the contact person/organization.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The name of the contact person/organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the contact information.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1APISpecForProviderImportWsdlSelector
{
    /// <summary>The name of endpoint (port) to import from WSDL.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The name of service to import from WSDL.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1beta1APISpecForProviderImport
{
    /// <summary>The format of the content from which the API Definition should be imported. Possible values are: openapi, openapi+json, openapi+json-link, openapi-link, swagger-json, swagger-link-json, wadl-link-json, wadl-xml, wsdl and wsdl-link.</summary>
    [JsonPropertyName("contentFormat")]
    public string? ContentFormat { get; set; }

    /// <summary>The Content from which the API Definition should be imported. When a content_format of *-link-* is specified this must be a URL, otherwise this must be defined inline.</summary>
    [JsonPropertyName("contentValue")]
    public string? ContentValue { get; set; }

    /// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
    [JsonPropertyName("wsdlSelector")]
    public IList<V1beta1APISpecForProviderImportWsdlSelector>? WsdlSelector { get; set; }
}

public partial class V1beta1APISpecForProviderLicense
{
    /// <summary>The name of the license .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the license.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1APISpecForProviderOauth2Authorization
{
    /// <summary>OAuth authorization server identifier. The name of an OAuth2 Authorization Server.</summary>
    [JsonPropertyName("authorizationServerName")]
    public string? AuthorizationServerName { get; set; }

    /// <summary>Operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

public partial class V1beta1APISpecForProviderOpenidAuthentication
{
    /// <summary>How to send token to the server. A list of zero or more methods. Valid values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenID Connect provider identifier. The name of an OpenID Connect Provider.</summary>
    [JsonPropertyName("openidProviderName")]
    public string? OpenidProviderName { get; set; }
}

public enum V1beta1APISpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1APISpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1APISpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1APISpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1APISpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1APISpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APISpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1APISpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1APISpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1APISpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1APISpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1APISpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1APISpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APISpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1APISpecForProviderSubscriptionKeyParameterNames
{
    /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

public partial class V1beta1APISpecForProvider
{
    /// <summary>The Name of the API Management Service where this API should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta1APISpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta1APISpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>Type of API. Possible values are graphql, http, soap, and websocket. Defaults to http.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>A contact block as documented below.</summary>
    [JsonPropertyName("contact")]
    public IList<V1beta1APISpecForProviderContact>? Contact { get; set; }

    /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the API.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A import block as documented below.</summary>
    [JsonPropertyName("import")]
    public IList<V1beta1APISpecForProviderImport>? Import { get; set; }

    /// <summary>A license block as documented below.</summary>
    [JsonPropertyName("license")]
    public IList<V1beta1APISpecForProviderLicense>? License { get; set; }

    /// <summary>An oauth2_authorization block as documented below.</summary>
    [JsonPropertyName("oauth2Authorization")]
    public IList<V1beta1APISpecForProviderOauth2Authorization>? Oauth2Authorization { get; set; }

    /// <summary>An openid_authentication block as documented below.</summary>
    [JsonPropertyName("openidAuthentication")]
    public IList<V1beta1APISpecForProviderOpenidAuthentication>? OpenidAuthentication { get; set; }

    /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A list of protocols the operations in this API can be invoked. Possible values are http, https, ws, and wss.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The Name of the Resource Group where the API Management API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1APISpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1APISpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The Revision which used for this API. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary>The description of the API Revision of the API Management API.</summary>
    [JsonPropertyName("revisionDescription")]
    public string? RevisionDescription { get; set; }

    /// <summary>Absolute URL of the backend service implementing this API.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>Should this API expose a SOAP frontend, rather than a HTTP frontend? Defaults to false.</summary>
    [JsonPropertyName("soapPassThrough")]
    public bool? SoapPassThrough { get; set; }

    /// <summary>The API id of the source API, which could be in format azurerm_api_management_api.example.id or in format azurerm_api_management_api.example.id;rev=1</summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>A subscription_key_parameter_names block as documented below.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public IList<V1beta1APISpecForProviderSubscriptionKeyParameterNames>? SubscriptionKeyParameterNames { get; set; }

    /// <summary>Should this API require a subscription key? Defaults to true.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>Absolute URL of the Terms of Service for the API.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>The Version number of this API, if this API is versioned.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The description of the API Version of the API Management API.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>The ID of the Version Set which this API is associated with.</summary>
    [JsonPropertyName("versionSetId")]
    public string? VersionSetId { get; set; }
}

public partial class V1beta1APISpecInitProviderContact
{
    /// <summary>The email address of the contact person/organization.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The name of the contact person/organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the contact information.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1APISpecInitProviderImportWsdlSelector
{
    /// <summary>The name of endpoint (port) to import from WSDL.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The name of service to import from WSDL.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1beta1APISpecInitProviderImport
{
    /// <summary>The format of the content from which the API Definition should be imported. Possible values are: openapi, openapi+json, openapi+json-link, openapi-link, swagger-json, swagger-link-json, wadl-link-json, wadl-xml, wsdl and wsdl-link.</summary>
    [JsonPropertyName("contentFormat")]
    public string? ContentFormat { get; set; }

    /// <summary>The Content from which the API Definition should be imported. When a content_format of *-link-* is specified this must be a URL, otherwise this must be defined inline.</summary>
    [JsonPropertyName("contentValue")]
    public string? ContentValue { get; set; }

    /// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
    [JsonPropertyName("wsdlSelector")]
    public IList<V1beta1APISpecInitProviderImportWsdlSelector>? WsdlSelector { get; set; }
}

public partial class V1beta1APISpecInitProviderLicense
{
    /// <summary>The name of the license .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the license.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1APISpecInitProviderOauth2Authorization
{
    /// <summary>OAuth authorization server identifier. The name of an OAuth2 Authorization Server.</summary>
    [JsonPropertyName("authorizationServerName")]
    public string? AuthorizationServerName { get; set; }

    /// <summary>Operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

public partial class V1beta1APISpecInitProviderOpenidAuthentication
{
    /// <summary>How to send token to the server. A list of zero or more methods. Valid values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenID Connect provider identifier. The name of an OpenID Connect Provider.</summary>
    [JsonPropertyName("openidProviderName")]
    public string? OpenidProviderName { get; set; }
}

public partial class V1beta1APISpecInitProviderSubscriptionKeyParameterNames
{
    /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

public partial class V1beta1APISpecInitProvider
{
    /// <summary>Type of API. Possible values are graphql, http, soap, and websocket. Defaults to http.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>A contact block as documented below.</summary>
    [JsonPropertyName("contact")]
    public IList<V1beta1APISpecInitProviderContact>? Contact { get; set; }

    /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the API.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A import block as documented below.</summary>
    [JsonPropertyName("import")]
    public IList<V1beta1APISpecInitProviderImport>? Import { get; set; }

    /// <summary>A license block as documented below.</summary>
    [JsonPropertyName("license")]
    public IList<V1beta1APISpecInitProviderLicense>? License { get; set; }

    /// <summary>An oauth2_authorization block as documented below.</summary>
    [JsonPropertyName("oauth2Authorization")]
    public IList<V1beta1APISpecInitProviderOauth2Authorization>? Oauth2Authorization { get; set; }

    /// <summary>An openid_authentication block as documented below.</summary>
    [JsonPropertyName("openidAuthentication")]
    public IList<V1beta1APISpecInitProviderOpenidAuthentication>? OpenidAuthentication { get; set; }

    /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A list of protocols the operations in this API can be invoked. Possible values are http, https, ws, and wss.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The description of the API Revision of the API Management API.</summary>
    [JsonPropertyName("revisionDescription")]
    public string? RevisionDescription { get; set; }

    /// <summary>Absolute URL of the backend service implementing this API.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>Should this API expose a SOAP frontend, rather than a HTTP frontend? Defaults to false.</summary>
    [JsonPropertyName("soapPassThrough")]
    public bool? SoapPassThrough { get; set; }

    /// <summary>The API id of the source API, which could be in format azurerm_api_management_api.example.id or in format azurerm_api_management_api.example.id;rev=1</summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>A subscription_key_parameter_names block as documented below.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public IList<V1beta1APISpecInitProviderSubscriptionKeyParameterNames>? SubscriptionKeyParameterNames { get; set; }

    /// <summary>Should this API require a subscription key? Defaults to true.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>Absolute URL of the Terms of Service for the API.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>The Version number of this API, if this API is versioned.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The description of the API Version of the API Management API.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>The ID of the Version Set which this API is associated with.</summary>
    [JsonPropertyName("versionSetId")]
    public string? VersionSetId { get; set; }
}

public enum V1beta1APISpecManagementPoliciesEnum
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

public enum V1beta1APISpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1APISpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1APISpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1APISpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1APISpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1APISpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APISpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1APISpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1APISpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1APISpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1APISpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1APISpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1APISpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APISpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1APISpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1APISpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1APISpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1APISpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1APISpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1APISpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1APISpecDeletionPolicyEnum>))]
    public V1beta1APISpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1APISpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1APISpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1APISpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1APISpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1APISpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1APISpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1APIStatusAtProviderContact
{
    /// <summary>The email address of the contact person/organization.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The name of the contact person/organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the contact information.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1APIStatusAtProviderImportWsdlSelector
{
    /// <summary>The name of endpoint (port) to import from WSDL.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The name of service to import from WSDL.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1beta1APIStatusAtProviderImport
{
    /// <summary>The format of the content from which the API Definition should be imported. Possible values are: openapi, openapi+json, openapi+json-link, openapi-link, swagger-json, swagger-link-json, wadl-link-json, wadl-xml, wsdl and wsdl-link.</summary>
    [JsonPropertyName("contentFormat")]
    public string? ContentFormat { get; set; }

    /// <summary>The Content from which the API Definition should be imported. When a content_format of *-link-* is specified this must be a URL, otherwise this must be defined inline.</summary>
    [JsonPropertyName("contentValue")]
    public string? ContentValue { get; set; }

    /// <summary>A wsdl_selector block as defined below, which allows you to limit the import of a WSDL to only a subset of the document. This can only be specified when content_format is wsdl or wsdl-link.</summary>
    [JsonPropertyName("wsdlSelector")]
    public IList<V1beta1APIStatusAtProviderImportWsdlSelector>? WsdlSelector { get; set; }
}

public partial class V1beta1APIStatusAtProviderLicense
{
    /// <summary>The name of the license .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Absolute URL of the license.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1beta1APIStatusAtProviderOauth2Authorization
{
    /// <summary>OAuth authorization server identifier. The name of an OAuth2 Authorization Server.</summary>
    [JsonPropertyName("authorizationServerName")]
    public string? AuthorizationServerName { get; set; }

    /// <summary>Operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

public partial class V1beta1APIStatusAtProviderOpenidAuthentication
{
    /// <summary>How to send token to the server. A list of zero or more methods. Valid values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenID Connect provider identifier. The name of an OpenID Connect Provider.</summary>
    [JsonPropertyName("openidProviderName")]
    public string? OpenidProviderName { get; set; }
}

public partial class V1beta1APIStatusAtProviderSubscriptionKeyParameterNames
{
    /// <summary>The name of the HTTP Header which should be used for the Subscription Key.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>The name of the QueryString parameter which should be used for the Subscription Key.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

public partial class V1beta1APIStatusAtProvider
{
    /// <summary>The Name of the API Management Service where this API should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Type of API. Possible values are graphql, http, soap, and websocket. Defaults to http.</summary>
    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    /// <summary>A contact block as documented below.</summary>
    [JsonPropertyName("contact")]
    public IList<V1beta1APIStatusAtProviderContact>? Contact { get; set; }

    /// <summary>A description of the API Management API, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the API.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the API Management API.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A import block as documented below.</summary>
    [JsonPropertyName("import")]
    public IList<V1beta1APIStatusAtProviderImport>? Import { get; set; }

    /// <summary>Is this the current API Revision?</summary>
    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary>Is this API Revision online/accessible via the Gateway?</summary>
    [JsonPropertyName("isOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>A license block as documented below.</summary>
    [JsonPropertyName("license")]
    public IList<V1beta1APIStatusAtProviderLicense>? License { get; set; }

    /// <summary>An oauth2_authorization block as documented below.</summary>
    [JsonPropertyName("oauth2Authorization")]
    public IList<V1beta1APIStatusAtProviderOauth2Authorization>? Oauth2Authorization { get; set; }

    /// <summary>An openid_authentication block as documented below.</summary>
    [JsonPropertyName("openidAuthentication")]
    public IList<V1beta1APIStatusAtProviderOpenidAuthentication>? OpenidAuthentication { get; set; }

    /// <summary>The Path for this API Management API, which is a relative URL which uniquely identifies this API and all of its resource paths within the API Management Service.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A list of protocols the operations in this API can be invoked. Possible values are http, https, ws, and wss.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>The Name of the Resource Group where the API Management API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The Revision which used for this API. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The description of the API Revision of the API Management API.</summary>
    [JsonPropertyName("revisionDescription")]
    public string? RevisionDescription { get; set; }

    /// <summary>Absolute URL of the backend service implementing this API.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>Should this API expose a SOAP frontend, rather than a HTTP frontend? Defaults to false.</summary>
    [JsonPropertyName("soapPassThrough")]
    public bool? SoapPassThrough { get; set; }

    /// <summary>The API id of the source API, which could be in format azurerm_api_management_api.example.id or in format azurerm_api_management_api.example.id;rev=1</summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>A subscription_key_parameter_names block as documented below.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public IList<V1beta1APIStatusAtProviderSubscriptionKeyParameterNames>? SubscriptionKeyParameterNames { get; set; }

    /// <summary>Should this API require a subscription key? Defaults to true.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>Absolute URL of the Terms of Service for the API.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>The Version number of this API, if this API is versioned.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The description of the API Version of the API Management API.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>The ID of the Version Set which this API is associated with.</summary>
    [JsonPropertyName("versionSetId")]
    public string? VersionSetId { get; set; }
}

public partial class V1beta1APIStatusConditions
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

public partial class V1beta1APIStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1APIStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1APIStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1API : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1APISpec>, IStatus<V1beta1APIStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "API";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
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

    /// <summary>APISpec defines the desired state of API</summary>
    [JsonPropertyName("spec")]
    public V1beta1APISpec Spec { get; set; }

    /// <summary>APIStatus defines the observed state of API.</summary>
    [JsonPropertyName("status")]
    public V1beta1APIStatus? Status { get; set; }
}