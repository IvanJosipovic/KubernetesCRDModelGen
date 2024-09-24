using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
public enum V1beta1AuthorizationServerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicyResolutionEnum>))]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicyResolveEnum>))]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

public enum V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicyResolutionEnum>))]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicyResolveEnum>))]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderApiManagementNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The Client/App Secret registered with this Authorization Server.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The password associated with the Resource Owner.</summary>
public partial class V1beta1AuthorizationServerSpecForProviderResourceOwnerPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1AuthorizationServerSpecForProviderTokenBodyParameter
{
    /// <summary>The Name of the Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Value of the Parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1AuthorizationServerSpecForProvider
{
    /// <summary>The name of the API Management Service in which this Authorization Server should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta1AuthorizationServerSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>The OAUTH Authorization Endpoint.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The HTTP Verbs supported by the Authorization Endpoint. Possible values are DELETE, GET, HEAD, OPTIONS, PATCH, POST, PUT and TRACE.</summary>
    [JsonPropertyName("authorizationMethods")]
    public IList<string>? AuthorizationMethods { get; set; }

    /// <summary>The mechanism by which Access Tokens are passed to the API. Possible values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>The Authentication Methods supported by the Token endpoint of this Authorization Server.. Possible values are Basic and Body.</summary>
    [JsonPropertyName("clientAuthenticationMethod")]
    public IList<string>? ClientAuthenticationMethod { get; set; }

    /// <summary>The Client/App ID registered with this Authorization Server.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The URI of page where Client/App Registration is performed for this Authorization Server.</summary>
    [JsonPropertyName("clientRegistrationEndpoint")]
    public string? ClientRegistrationEndpoint { get; set; }

    /// <summary>The Client/App Secret registered with this Authorization Server.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1AuthorizationServerSpecForProviderClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.</summary>
    [JsonPropertyName("defaultScope")]
    public string? DefaultScope { get; set; }

    /// <summary>A description of the Authorization Server, which may contain HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The user-friendly name of this Authorization Server.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Form of Authorization Grants required when requesting an Access Token. Possible values are authorizationCode, clientCredentials, implicit and resourceOwnerPassword.</summary>
    [JsonPropertyName("grantTypes")]
    public IList<string>? GrantTypes { get; set; }

    /// <summary>The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1AuthorizationServerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The password associated with the Resource Owner.</summary>
    [JsonPropertyName("resourceOwnerPasswordSecretRef")]
    public V1beta1AuthorizationServerSpecForProviderResourceOwnerPasswordSecretRef? ResourceOwnerPasswordSecretRef { get; set; }

    /// <summary>The username associated with the Resource Owner.</summary>
    [JsonPropertyName("resourceOwnerUsername")]
    public string? ResourceOwnerUsername { get; set; }

    /// <summary>Does this Authorization Server support State? If this is set to true the client may use the state parameter to raise protocol security.</summary>
    [JsonPropertyName("supportState")]
    public bool? SupportState { get; set; }

    /// <summary>A token_body_parameter block as defined below.</summary>
    [JsonPropertyName("tokenBodyParameter")]
    public IList<V1beta1AuthorizationServerSpecForProviderTokenBodyParameter>? TokenBodyParameter { get; set; }

    /// <summary>The OAUTH Token Endpoint.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>The Client/App Secret registered with this Authorization Server.</summary>
public partial class V1beta1AuthorizationServerSpecInitProviderClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The password associated with the Resource Owner.</summary>
public partial class V1beta1AuthorizationServerSpecInitProviderResourceOwnerPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1AuthorizationServerSpecInitProviderTokenBodyParameter
{
    /// <summary>The Name of the Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Value of the Parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AuthorizationServerSpecInitProvider
{
    /// <summary>The OAUTH Authorization Endpoint.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The HTTP Verbs supported by the Authorization Endpoint. Possible values are DELETE, GET, HEAD, OPTIONS, PATCH, POST, PUT and TRACE.</summary>
    [JsonPropertyName("authorizationMethods")]
    public IList<string>? AuthorizationMethods { get; set; }

    /// <summary>The mechanism by which Access Tokens are passed to the API. Possible values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>The Authentication Methods supported by the Token endpoint of this Authorization Server.. Possible values are Basic and Body.</summary>
    [JsonPropertyName("clientAuthenticationMethod")]
    public IList<string>? ClientAuthenticationMethod { get; set; }

    /// <summary>The Client/App ID registered with this Authorization Server.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The URI of page where Client/App Registration is performed for this Authorization Server.</summary>
    [JsonPropertyName("clientRegistrationEndpoint")]
    public string? ClientRegistrationEndpoint { get; set; }

    /// <summary>The Client/App Secret registered with this Authorization Server.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1AuthorizationServerSpecInitProviderClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.</summary>
    [JsonPropertyName("defaultScope")]
    public string? DefaultScope { get; set; }

    /// <summary>A description of the Authorization Server, which may contain HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The user-friendly name of this Authorization Server.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Form of Authorization Grants required when requesting an Access Token. Possible values are authorizationCode, clientCredentials, implicit and resourceOwnerPassword.</summary>
    [JsonPropertyName("grantTypes")]
    public IList<string>? GrantTypes { get; set; }

    /// <summary>The password associated with the Resource Owner.</summary>
    [JsonPropertyName("resourceOwnerPasswordSecretRef")]
    public V1beta1AuthorizationServerSpecInitProviderResourceOwnerPasswordSecretRef? ResourceOwnerPasswordSecretRef { get; set; }

    /// <summary>The username associated with the Resource Owner.</summary>
    [JsonPropertyName("resourceOwnerUsername")]
    public string? ResourceOwnerUsername { get; set; }

    /// <summary>Does this Authorization Server support State? If this is set to true the client may use the state parameter to raise protocol security.</summary>
    [JsonPropertyName("supportState")]
    public bool? SupportState { get; set; }

    /// <summary>A token_body_parameter block as defined below.</summary>
    [JsonPropertyName("tokenBodyParameter")]
    public IList<V1beta1AuthorizationServerSpecInitProviderTokenBodyParameter>? TokenBodyParameter { get; set; }

    /// <summary>The OAUTH Token Endpoint.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

public enum V1beta1AuthorizationServerSpecManagementPoliciesEnum
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

public enum V1beta1AuthorizationServerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AuthorizationServerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AuthorizationServerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AuthorizationServerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AuthorizationServerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AuthorizationServerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizationServerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AuthorizationServerSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AuthorizationServerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AuthorizationServerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AuthorizationServerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AuthorizationServerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AuthorizationServerSpec defines the desired state of AuthorizationServer</summary>
public partial class V1beta1AuthorizationServerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AuthorizationServerSpecDeletionPolicyEnum>))]
    public V1beta1AuthorizationServerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AuthorizationServerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AuthorizationServerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AuthorizationServerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AuthorizationServerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AuthorizationServerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AuthorizationServerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AuthorizationServerStatusAtProviderTokenBodyParameter
{
    /// <summary>The Name of the Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Value of the Parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1AuthorizationServerStatusAtProvider
{
    /// <summary>The name of the API Management Service in which this Authorization Server should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>The OAUTH Authorization Endpoint.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The HTTP Verbs supported by the Authorization Endpoint. Possible values are DELETE, GET, HEAD, OPTIONS, PATCH, POST, PUT and TRACE.</summary>
    [JsonPropertyName("authorizationMethods")]
    public IList<string>? AuthorizationMethods { get; set; }

    /// <summary>The mechanism by which Access Tokens are passed to the API. Possible values are authorizationHeader and query.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>The Authentication Methods supported by the Token endpoint of this Authorization Server.. Possible values are Basic and Body.</summary>
    [JsonPropertyName("clientAuthenticationMethod")]
    public IList<string>? ClientAuthenticationMethod { get; set; }

    /// <summary>The Client/App ID registered with this Authorization Server.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The URI of page where Client/App Registration is performed for this Authorization Server.</summary>
    [JsonPropertyName("clientRegistrationEndpoint")]
    public string? ClientRegistrationEndpoint { get; set; }

    /// <summary>The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.</summary>
    [JsonPropertyName("defaultScope")]
    public string? DefaultScope { get; set; }

    /// <summary>A description of the Authorization Server, which may contain HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The user-friendly name of this Authorization Server.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Form of Authorization Grants required when requesting an Access Token. Possible values are authorizationCode, clientCredentials, implicit and resourceOwnerPassword.</summary>
    [JsonPropertyName("grantTypes")]
    public IList<string>? GrantTypes { get; set; }

    /// <summary>The ID of the API Management Authorization Server.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The username associated with the Resource Owner.</summary>
    [JsonPropertyName("resourceOwnerUsername")]
    public string? ResourceOwnerUsername { get; set; }

    /// <summary>Does this Authorization Server support State? If this is set to true the client may use the state parameter to raise protocol security.</summary>
    [JsonPropertyName("supportState")]
    public bool? SupportState { get; set; }

    /// <summary>A token_body_parameter block as defined below.</summary>
    [JsonPropertyName("tokenBodyParameter")]
    public IList<V1beta1AuthorizationServerStatusAtProviderTokenBodyParameter>? TokenBodyParameter { get; set; }

    /// <summary>The OAUTH Token Endpoint.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AuthorizationServerStatusConditions
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

/// <summary>AuthorizationServerStatus defines the observed state of AuthorizationServer.</summary>
public partial class V1beta1AuthorizationServerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AuthorizationServerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AuthorizationServerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>AuthorizationServer is the Schema for the AuthorizationServers API. Manages an Authorization Server within an API Management Service.</summary>
public partial class V1beta1AuthorizationServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AuthorizationServerSpec>, IStatus<V1beta1AuthorizationServerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AuthorizationServer";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "authorizationservers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AuthorizationServerSpec defines the desired state of AuthorizationServer</summary>
    [JsonPropertyName("spec")]
    public V1beta1AuthorizationServerSpec Spec { get; set; }

    /// <summary>AuthorizationServerStatus defines the observed state of AuthorizationServer.</summary>
    [JsonPropertyName("status")]
    public V1beta1AuthorizationServerStatus? Status { get; set; }
}