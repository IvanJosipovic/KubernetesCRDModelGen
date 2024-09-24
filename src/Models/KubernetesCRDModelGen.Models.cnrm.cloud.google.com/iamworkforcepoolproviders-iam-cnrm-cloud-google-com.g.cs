using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
public partial class V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValuePlainTextValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValuePlainTextValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValuePlainTextValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValuePlainText
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValuePlainTextValueFrom? ValueFrom { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValue
{
    /// <summary>Input only. The plain text of the client secret value.</summary>
    [JsonPropertyName("plainText")]
    public V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValuePlainText? PlainText { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecOidcClientSecret
{
    /// <summary>The value of the client secret.</summary>
    [JsonPropertyName("value")]
    public V1beta1IAMWorkforcePoolProviderSpecOidcClientSecretValue? Value { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecOidcWebSsoConfig
{
    /// <summary>Additional scopes to request for in the OIDC authentication request on top of scopes requested by default. By default, the `openid`, `profile` and `email` scopes that are supported by the identity provider are requested. Each additional scope may be at most 256 characters. A maximum of 10 additional scopes may be configured.</summary>
    [JsonPropertyName("additionalScopes")]
    public IList<string>? AdditionalScopes { get; set; }

    /// <summary>Required. The behavior for how OIDC Claims are included in the `assertion` object used for attribute mapping and attribute condition. Possible values: ASSERTION_CLAIMS_BEHAVIOR_UNSPECIFIED, MERGE_USER_INFO_OVER_ID_TOKEN_CLAIMS, ONLY_ID_TOKEN_CLAIMS</summary>
    [JsonPropertyName("assertionClaimsBehavior")]
    public string AssertionClaimsBehavior { get; set; }

    /// <summary>Required. The Response Type to request for in the OIDC Authorization Request for web sign-in. The `CODE` Response Type is recommended to avoid the Implicit Flow, for security reasons. Possible values: RESPONSE_TYPE_UNSPECIFIED, CODE, ID_TOKEN</summary>
    [JsonPropertyName("responseType")]
    public string ResponseType { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecOidc
{
    /// <summary>Required. The client ID. Must match the audience claim of the JWT issued by the identity provider.</summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }

    /// <summary>The optional client secret. Required to enable Authorization Code flow for web sign-in.</summary>
    [JsonPropertyName("clientSecret")]
    public V1beta1IAMWorkforcePoolProviderSpecOidcClientSecret? ClientSecret { get; set; }

    /// <summary>Required. The OIDC issuer URI. Must be a valid URI using the 'https' scheme.</summary>
    [JsonPropertyName("issuerUri")]
    public string IssuerUri { get; set; }

    /// <summary>OIDC JWKs in JSON String format. For details on definition of a JWK, see https:tools.ietf.org/html/rfc7517. If not set, then we use the `jwks_uri` from the discovery document fetched from the .well-known path for the `issuer_uri`. Currently, RSA and EC asymmetric keys are supported. The JWK must use following format and include only the following fields: ```{"keys": [{"kty": "RSA/EC", "alg": "<algorithm>", "use": "sig", "kid": "<key-id>", "n": "", "e": "", "x": "", "y": "", "crv": ""}]}```</summary>
    [JsonPropertyName("jwksJson")]
    public string? JwksJson { get; set; }

    /// <summary>Required. Configuration for web single sign-on for the OIDC provider. Here, web sign-in refers to console sign-in and gcloud sign-in through the browser.</summary>
    [JsonPropertyName("webSsoConfig")]
    public V1beta1IAMWorkforcePoolProviderSpecOidcWebSsoConfig WebSsoConfig { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecSaml
{
    /// <summary>Required. SAML Identity provider configuration metadata xml doc. The xml document should comply with [SAML 2.0 specification](https://docs.oasis-open.org/security/saml/v2.0/saml-metadata-2.0-os.pdf). The max size of the acceptable xml document will be bounded to 128k characters. The metadata xml document should satisfy the following constraints: 1) Must contain an Identity Provider Entity ID. 2) Must contain at least one non-expired signing key certificate. 3) For each signing key: a) Valid from should be no more than 7 days from now. b) Valid to should be no more than 10 years in the future. 4) Up to 3 IdP signing keys are allowed in the metadata xml. When updating the provider's metadata xml, at least one non-expired signing key must overlap with the existing metadata. This requirement is skipped if there are no non-expired signing keys present in the existing metadata.</summary>
    [JsonPropertyName("idpMetadataXml")]
    public string IdpMetadataXml { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpecWorkforcePoolRef
{
    /// <summary>The workforce_pool for the resource  Allowed value: The Google Cloud resource name of an `IAMWorkforcePool` resource (format: `locations/{{location}}/workforcePools/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderSpec
{
    /// <summary>A [Common Expression Language](https://opensource.google/projects/cel) expression, in plain text, to restrict what otherwise valid authentication credentials issued by the provider should not be accepted. The expression must output a boolean representing whether to allow the federation. The following keywords may be referenced in the expressions: * `assertion`: JSON representing the authentication credential issued by the provider. * `google`: The Google attributes mapped from the assertion in the `attribute_mappings`. `google.profile_photo` and `google.display_name` are not supported. * `attribute`: The custom attributes mapped from the assertion in the `attribute_mappings`. The maximum length of the attribute condition expression is 4096 characters. If unspecified, all valid authentication credentials will be accepted. The following example shows how to only allow credentials with a mapped `google.groups` value of `admins`: ``` "'admins' in google.groups" ```</summary>
    [JsonPropertyName("attributeCondition")]
    public string? AttributeCondition { get; set; }

    /// <summary>Required. Maps attributes from the authentication credentials issued by an external identity provider to Google Cloud attributes, such as `subject` and `segment`. Each key must be a string specifying the Google Cloud IAM attribute to map to. The following keys are supported: * `google.subject`: The principal IAM is authenticating. You can reference this value in IAM bindings. This is also the subject that appears in Cloud Logging logs. This is a required field and the mapped subject cannot exceed 127 bytes. * `google.groups`: Groups the authenticating user belongs to. You can grant groups access to resources using an IAM `principalSet` binding; access applies to all members of the group. * `google.display_name`: The name of the authenticated user. This is an optional field and the mapped display name cannot exceed 100 bytes. If not set, `google.subject` will be displayed instead. This attribute cannot be referenced in IAM bindings. * `google.profile_photo`: The URL that specifies the authenticated user's thumbnail photo. This is an optional field. When set, the image will be visible as the user's profile picture. If not set, a generic user icon will be displayed instead. This attribute cannot be referenced in IAM bindings. You can also provide custom attributes by specifying `attribute.{custom_attribute}`, where {custom_attribute} is the name of the custom attribute to be mapped. You can define a maximum of 50 custom attributes. The maximum length of a mapped attribute key is 100 characters, and the key may only contain the characters [a-z0-9_]. You can reference these attributes in IAM policies to define fine-grained access for a workforce pool to Google Cloud resources. For example:</summary>
    [JsonPropertyName("attributeMapping")]
    public IDictionary<string, string> AttributeMapping { get; set; }

    /// <summary>A user-specified description of the provider. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the provider is disabled. You cannot use a disabled provider to exchange tokens. However, existing tokens still grant access.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A user-specified display name for the provider. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>An OpenId Connect 1.0 identity provider configuration.</summary>
    [JsonPropertyName("oidc")]
    public V1beta1IAMWorkforcePoolProviderSpecOidc? Oidc { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A SAML identity provider configuration.</summary>
    [JsonPropertyName("saml")]
    public V1beta1IAMWorkforcePoolProviderSpecSaml? Saml { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("workforcePoolRef")]
    public V1beta1IAMWorkforcePoolProviderSpecWorkforcePoolRef WorkforcePoolRef { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderStatusOidcClientSecretValue
{
    /// <summary>Output only. A thumbprint to represent the current client secret value.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderStatusOidcClientSecret
{
    /// <summary></summary>
    [JsonPropertyName("value")]
    public V1beta1IAMWorkforcePoolProviderStatusOidcClientSecretValue? Value { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderStatusOidc
{
    /// <summary></summary>
    [JsonPropertyName("clientSecret")]
    public V1beta1IAMWorkforcePoolProviderStatusOidcClientSecret? ClientSecret { get; set; }
}

public partial class V1beta1IAMWorkforcePoolProviderStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMWorkforcePoolProviderStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oidc")]
    public V1beta1IAMWorkforcePoolProviderStatusOidc? Oidc { get; set; }

    /// <summary>Output only. The state of the provider. Possible values: STATE_UNSPECIFIED, ACTIVE, DELETED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMWorkforcePoolProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMWorkforcePoolProviderSpec>, IStatus<V1beta1IAMWorkforcePoolProviderStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMWorkforcePoolProvider";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamworkforcepoolproviders";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1IAMWorkforcePoolProviderSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1IAMWorkforcePoolProviderStatus? Status { get; set; }
}