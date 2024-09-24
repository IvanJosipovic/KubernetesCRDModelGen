using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidp.aws.upbound.io;
public enum V1beta1UserPoolClientSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderAnalyticsConfiguration
{
    /// <summary>Application ARN for an Amazon Pinpoint application. Conflicts with external_id and role_arn.</summary>
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }

    /// <summary>Application ID for an Amazon Pinpoint application.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>Reference to a App in pinpoint to populate applicationId.</summary>
    [JsonPropertyName("applicationIdRef")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdRef? ApplicationIdRef { get; set; }

    /// <summary>Selector for a App in pinpoint to populate applicationId.</summary>
    [JsonPropertyName("applicationIdSelector")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationApplicationIdSelector? ApplicationIdSelector { get; set; }

    /// <summary>ID for the Analytics Configuration. Conflicts with application_arn.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of an IAM role that authorizes Amazon Cognito to publish events to Amazon Pinpoint analytics. Conflicts with application_arn.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1UserPoolClientSpecForProviderAnalyticsConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>If set to true, Amazon Cognito will include user data in the events it publishes to Amazon Pinpoint analytics.</summary>
    [JsonPropertyName("userDataShared")]
    public bool? UserDataShared { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderTokenValidityUnits
{
    /// <summary>Time unit in for the value in access_token_validity, defaults to hours.</summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    /// <summary>Time unit in for the value in id_token_validity, defaults to hours.</summary>
    [JsonPropertyName("idToken")]
    public string? IdToken { get; set; }

    /// <summary>Time unit in for the value in refresh_token_validity, defaults to days.</summary>
    [JsonPropertyName("refreshToken")]
    public string? RefreshToken { get; set; }
}

public enum V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProviderUserPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolClientSpecForProvider
{
    /// <summary>Time limit, between 5 minutes and 1 day, after which the access token is no longer valid and cannot be used. By default, the unit is hours. The unit can be overridden by a value in token_validity_units.access_token.</summary>
    [JsonPropertyName("accessTokenValidity")]
    public double? AccessTokenValidity { get; set; }

    /// <summary>List of allowed OAuth flows (code, implicit, client_credentials).</summary>
    [JsonPropertyName("allowedOauthFlows")]
    public IList<string>? AllowedOauthFlows { get; set; }

    /// <summary>Whether the client is allowed to follow the OAuth protocol when interacting with Cognito user pools.</summary>
    [JsonPropertyName("allowedOauthFlowsUserPoolClient")]
    public bool? AllowedOauthFlowsUserPoolClient { get; set; }

    /// <summary>List of allowed OAuth scopes (phone, email, openid, profile, and aws.cognito.signin.user.admin).</summary>
    [JsonPropertyName("allowedOauthScopes")]
    public IList<string>? AllowedOauthScopes { get; set; }

    /// <summary>Configuration block for Amazon Pinpoint analytics for collecting metrics for this user pool. Detailed below.</summary>
    [JsonPropertyName("analyticsConfiguration")]
    public IList<V1beta1UserPoolClientSpecForProviderAnalyticsConfiguration>? AnalyticsConfiguration { get; set; }

    /// <summary>Amazon Cognito creates a session token for each API request in an authentication flow. AuthSessionValidity is the duration, in minutes, of that session token. Your user pool native user must respond to each authentication challenge before the session expires. Valid values between 3 and 15. Default value is 3.</summary>
    [JsonPropertyName("authSessionValidity")]
    public double? AuthSessionValidity { get; set; }

    /// <summary>List of allowed callback URLs for the identity providers.</summary>
    [JsonPropertyName("callbackUrls")]
    public IList<string>? CallbackUrls { get; set; }

    /// <summary>Default redirect URI. Must be in the list of callback URLs.</summary>
    [JsonPropertyName("defaultRedirectUri")]
    public string? DefaultRedirectUri { get; set; }

    /// <summary>Activates the propagation of additional user context data.</summary>
    [JsonPropertyName("enablePropagateAdditionalUserContextData")]
    public bool? EnablePropagateAdditionalUserContextData { get; set; }

    /// <summary>Enables or disables token revocation.</summary>
    [JsonPropertyName("enableTokenRevocation")]
    public bool? EnableTokenRevocation { get; set; }

    /// <summary>List of authentication flows (ADMIN_NO_SRP_AUTH, CUSTOM_AUTH_FLOW_ONLY, USER_PASSWORD_AUTH, ALLOW_ADMIN_USER_PASSWORD_AUTH, ALLOW_CUSTOM_AUTH, ALLOW_USER_PASSWORD_AUTH, ALLOW_USER_SRP_AUTH, ALLOW_REFRESH_TOKEN_AUTH).</summary>
    [JsonPropertyName("explicitAuthFlows")]
    public IList<string>? ExplicitAuthFlows { get; set; }

    /// <summary>Should an application secret be generated.</summary>
    [JsonPropertyName("generateSecret")]
    public bool? GenerateSecret { get; set; }

    /// <summary>Time limit, between 5 minutes and 1 day, after which the ID token is no longer valid and cannot be used. By default, the unit is hours. The unit can be overridden by a value in token_validity_units.id_token.</summary>
    [JsonPropertyName("idTokenValidity")]
    public double? IdTokenValidity { get; set; }

    /// <summary>List of allowed logout URLs for the identity providers.</summary>
    [JsonPropertyName("logoutUrls")]
    public IList<string>? LogoutUrls { get; set; }

    /// <summary>Name of the application client.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Choose which errors and responses are returned by Cognito APIs during authentication, account confirmation, and password recovery when the user does not exist in the user pool. When set to ENABLED and the user does not exist, authentication returns an error indicating either the username or password was incorrect, and account confirmation and password recovery return a response indicating a code was sent to a simulated destination. When set to LEGACY, those APIs will return a UserNotFoundException exception if the user does not exist in the user pool.</summary>
    [JsonPropertyName("preventUserExistenceErrors")]
    public string? PreventUserExistenceErrors { get; set; }

    /// <summary>List of user pool attributes the application client can read from.</summary>
    [JsonPropertyName("readAttributes")]
    public IList<string>? ReadAttributes { get; set; }

    /// <summary>Time limit, between 60 minutes and 10 years, after which the refresh token is no longer valid and cannot be used. By default, the unit is days. The unit can be overridden by a value in token_validity_units.refresh_token.</summary>
    [JsonPropertyName("refreshTokenValidity")]
    public double? RefreshTokenValidity { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>List of provider names for the identity providers that are supported on this client. Uses the provider_name attribute of aws_cognito_identity_provider resource(s), or the equivalent string(s).</summary>
    [JsonPropertyName("supportedIdentityProviders")]
    public IList<string>? SupportedIdentityProviders { get; set; }

    /// <summary>Configuration block for units in which the validity times are represented in. Detailed below.</summary>
    [JsonPropertyName("tokenValidityUnits")]
    public IList<V1beta1UserPoolClientSpecForProviderTokenValidityUnits>? TokenValidityUnits { get; set; }

    /// <summary>User pool the client belongs to.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1UserPoolClientSpecForProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }

    /// <summary>List of user pool attributes the application client can write to.</summary>
    [JsonPropertyName("writeAttributes")]
    public IList<string>? WriteAttributes { get; set; }
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderAnalyticsConfiguration
{
    /// <summary>Application ARN for an Amazon Pinpoint application. Conflicts with external_id and role_arn.</summary>
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }

    /// <summary>Application ID for an Amazon Pinpoint application.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>Reference to a App in pinpoint to populate applicationId.</summary>
    [JsonPropertyName("applicationIdRef")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdRef? ApplicationIdRef { get; set; }

    /// <summary>Selector for a App in pinpoint to populate applicationId.</summary>
    [JsonPropertyName("applicationIdSelector")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationApplicationIdSelector? ApplicationIdSelector { get; set; }

    /// <summary>ID for the Analytics Configuration. Conflicts with application_arn.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of an IAM role that authorizes Amazon Cognito to publish events to Amazon Pinpoint analytics. Conflicts with application_arn.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1UserPoolClientSpecInitProviderAnalyticsConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>If set to true, Amazon Cognito will include user data in the events it publishes to Amazon Pinpoint analytics.</summary>
    [JsonPropertyName("userDataShared")]
    public bool? UserDataShared { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderTokenValidityUnits
{
    /// <summary>Time unit in for the value in access_token_validity, defaults to hours.</summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    /// <summary>Time unit in for the value in id_token_validity, defaults to hours.</summary>
    [JsonPropertyName("idToken")]
    public string? IdToken { get; set; }

    /// <summary>Time unit in for the value in refresh_token_validity, defaults to days.</summary>
    [JsonPropertyName("refreshToken")]
    public string? RefreshToken { get; set; }
}

public enum V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProviderUserPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolClientSpecInitProvider
{
    /// <summary>Time limit, between 5 minutes and 1 day, after which the access token is no longer valid and cannot be used. By default, the unit is hours. The unit can be overridden by a value in token_validity_units.access_token.</summary>
    [JsonPropertyName("accessTokenValidity")]
    public double? AccessTokenValidity { get; set; }

    /// <summary>List of allowed OAuth flows (code, implicit, client_credentials).</summary>
    [JsonPropertyName("allowedOauthFlows")]
    public IList<string>? AllowedOauthFlows { get; set; }

    /// <summary>Whether the client is allowed to follow the OAuth protocol when interacting with Cognito user pools.</summary>
    [JsonPropertyName("allowedOauthFlowsUserPoolClient")]
    public bool? AllowedOauthFlowsUserPoolClient { get; set; }

    /// <summary>List of allowed OAuth scopes (phone, email, openid, profile, and aws.cognito.signin.user.admin).</summary>
    [JsonPropertyName("allowedOauthScopes")]
    public IList<string>? AllowedOauthScopes { get; set; }

    /// <summary>Configuration block for Amazon Pinpoint analytics for collecting metrics for this user pool. Detailed below.</summary>
    [JsonPropertyName("analyticsConfiguration")]
    public IList<V1beta1UserPoolClientSpecInitProviderAnalyticsConfiguration>? AnalyticsConfiguration { get; set; }

    /// <summary>Amazon Cognito creates a session token for each API request in an authentication flow. AuthSessionValidity is the duration, in minutes, of that session token. Your user pool native user must respond to each authentication challenge before the session expires. Valid values between 3 and 15. Default value is 3.</summary>
    [JsonPropertyName("authSessionValidity")]
    public double? AuthSessionValidity { get; set; }

    /// <summary>List of allowed callback URLs for the identity providers.</summary>
    [JsonPropertyName("callbackUrls")]
    public IList<string>? CallbackUrls { get; set; }

    /// <summary>Default redirect URI. Must be in the list of callback URLs.</summary>
    [JsonPropertyName("defaultRedirectUri")]
    public string? DefaultRedirectUri { get; set; }

    /// <summary>Activates the propagation of additional user context data.</summary>
    [JsonPropertyName("enablePropagateAdditionalUserContextData")]
    public bool? EnablePropagateAdditionalUserContextData { get; set; }

    /// <summary>Enables or disables token revocation.</summary>
    [JsonPropertyName("enableTokenRevocation")]
    public bool? EnableTokenRevocation { get; set; }

    /// <summary>List of authentication flows (ADMIN_NO_SRP_AUTH, CUSTOM_AUTH_FLOW_ONLY, USER_PASSWORD_AUTH, ALLOW_ADMIN_USER_PASSWORD_AUTH, ALLOW_CUSTOM_AUTH, ALLOW_USER_PASSWORD_AUTH, ALLOW_USER_SRP_AUTH, ALLOW_REFRESH_TOKEN_AUTH).</summary>
    [JsonPropertyName("explicitAuthFlows")]
    public IList<string>? ExplicitAuthFlows { get; set; }

    /// <summary>Should an application secret be generated.</summary>
    [JsonPropertyName("generateSecret")]
    public bool? GenerateSecret { get; set; }

    /// <summary>Time limit, between 5 minutes and 1 day, after which the ID token is no longer valid and cannot be used. By default, the unit is hours. The unit can be overridden by a value in token_validity_units.id_token.</summary>
    [JsonPropertyName("idTokenValidity")]
    public double? IdTokenValidity { get; set; }

    /// <summary>List of allowed logout URLs for the identity providers.</summary>
    [JsonPropertyName("logoutUrls")]
    public IList<string>? LogoutUrls { get; set; }

    /// <summary>Name of the application client.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Choose which errors and responses are returned by Cognito APIs during authentication, account confirmation, and password recovery when the user does not exist in the user pool. When set to ENABLED and the user does not exist, authentication returns an error indicating either the username or password was incorrect, and account confirmation and password recovery return a response indicating a code was sent to a simulated destination. When set to LEGACY, those APIs will return a UserNotFoundException exception if the user does not exist in the user pool.</summary>
    [JsonPropertyName("preventUserExistenceErrors")]
    public string? PreventUserExistenceErrors { get; set; }

    /// <summary>List of user pool attributes the application client can read from.</summary>
    [JsonPropertyName("readAttributes")]
    public IList<string>? ReadAttributes { get; set; }

    /// <summary>Time limit, between 60 minutes and 10 years, after which the refresh token is no longer valid and cannot be used. By default, the unit is days. The unit can be overridden by a value in token_validity_units.refresh_token.</summary>
    [JsonPropertyName("refreshTokenValidity")]
    public double? RefreshTokenValidity { get; set; }

    /// <summary>List of provider names for the identity providers that are supported on this client. Uses the provider_name attribute of aws_cognito_identity_provider resource(s), or the equivalent string(s).</summary>
    [JsonPropertyName("supportedIdentityProviders")]
    public IList<string>? SupportedIdentityProviders { get; set; }

    /// <summary>Configuration block for units in which the validity times are represented in. Detailed below.</summary>
    [JsonPropertyName("tokenValidityUnits")]
    public IList<V1beta1UserPoolClientSpecInitProviderTokenValidityUnits>? TokenValidityUnits { get; set; }

    /// <summary>User pool the client belongs to.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1UserPoolClientSpecInitProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }

    /// <summary>List of user pool attributes the application client can write to.</summary>
    [JsonPropertyName("writeAttributes")]
    public IList<string>? WriteAttributes { get; set; }
}

public enum V1beta1UserPoolClientSpecManagementPoliciesEnum
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

public enum V1beta1UserPoolClientSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolClientSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1UserPoolClientSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1UserPoolClientSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1UserPoolClientSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1UserPoolClientSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1UserPoolClientSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolClientSpecDeletionPolicyEnum>))]
    public V1beta1UserPoolClientSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UserPoolClientSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UserPoolClientSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1UserPoolClientSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserPoolClientSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1UserPoolClientSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserPoolClientSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1UserPoolClientStatusAtProviderAnalyticsConfiguration
{
    /// <summary>Application ARN for an Amazon Pinpoint application. Conflicts with external_id and role_arn.</summary>
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }

    /// <summary>Application ID for an Amazon Pinpoint application.</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>ID for the Analytics Configuration. Conflicts with application_arn.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of an IAM role that authorizes Amazon Cognito to publish events to Amazon Pinpoint analytics. Conflicts with application_arn.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>If set to true, Amazon Cognito will include user data in the events it publishes to Amazon Pinpoint analytics.</summary>
    [JsonPropertyName("userDataShared")]
    public bool? UserDataShared { get; set; }
}

public partial class V1beta1UserPoolClientStatusAtProviderTokenValidityUnits
{
    /// <summary>Time unit in for the value in access_token_validity, defaults to hours.</summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    /// <summary>Time unit in for the value in id_token_validity, defaults to hours.</summary>
    [JsonPropertyName("idToken")]
    public string? IdToken { get; set; }

    /// <summary>Time unit in for the value in refresh_token_validity, defaults to days.</summary>
    [JsonPropertyName("refreshToken")]
    public string? RefreshToken { get; set; }
}

public partial class V1beta1UserPoolClientStatusAtProvider
{
    /// <summary>Time limit, between 5 minutes and 1 day, after which the access token is no longer valid and cannot be used. By default, the unit is hours. The unit can be overridden by a value in token_validity_units.access_token.</summary>
    [JsonPropertyName("accessTokenValidity")]
    public double? AccessTokenValidity { get; set; }

    /// <summary>List of allowed OAuth flows (code, implicit, client_credentials).</summary>
    [JsonPropertyName("allowedOauthFlows")]
    public IList<string>? AllowedOauthFlows { get; set; }

    /// <summary>Whether the client is allowed to follow the OAuth protocol when interacting with Cognito user pools.</summary>
    [JsonPropertyName("allowedOauthFlowsUserPoolClient")]
    public bool? AllowedOauthFlowsUserPoolClient { get; set; }

    /// <summary>List of allowed OAuth scopes (phone, email, openid, profile, and aws.cognito.signin.user.admin).</summary>
    [JsonPropertyName("allowedOauthScopes")]
    public IList<string>? AllowedOauthScopes { get; set; }

    /// <summary>Configuration block for Amazon Pinpoint analytics for collecting metrics for this user pool. Detailed below.</summary>
    [JsonPropertyName("analyticsConfiguration")]
    public IList<V1beta1UserPoolClientStatusAtProviderAnalyticsConfiguration>? AnalyticsConfiguration { get; set; }

    /// <summary>Amazon Cognito creates a session token for each API request in an authentication flow. AuthSessionValidity is the duration, in minutes, of that session token. Your user pool native user must respond to each authentication challenge before the session expires. Valid values between 3 and 15. Default value is 3.</summary>
    [JsonPropertyName("authSessionValidity")]
    public double? AuthSessionValidity { get; set; }

    /// <summary>List of allowed callback URLs for the identity providers.</summary>
    [JsonPropertyName("callbackUrls")]
    public IList<string>? CallbackUrls { get; set; }

    /// <summary>Default redirect URI. Must be in the list of callback URLs.</summary>
    [JsonPropertyName("defaultRedirectUri")]
    public string? DefaultRedirectUri { get; set; }

    /// <summary>Activates the propagation of additional user context data.</summary>
    [JsonPropertyName("enablePropagateAdditionalUserContextData")]
    public bool? EnablePropagateAdditionalUserContextData { get; set; }

    /// <summary>Enables or disables token revocation.</summary>
    [JsonPropertyName("enableTokenRevocation")]
    public bool? EnableTokenRevocation { get; set; }

    /// <summary>List of authentication flows (ADMIN_NO_SRP_AUTH, CUSTOM_AUTH_FLOW_ONLY, USER_PASSWORD_AUTH, ALLOW_ADMIN_USER_PASSWORD_AUTH, ALLOW_CUSTOM_AUTH, ALLOW_USER_PASSWORD_AUTH, ALLOW_USER_SRP_AUTH, ALLOW_REFRESH_TOKEN_AUTH).</summary>
    [JsonPropertyName("explicitAuthFlows")]
    public IList<string>? ExplicitAuthFlows { get; set; }

    /// <summary>Should an application secret be generated.</summary>
    [JsonPropertyName("generateSecret")]
    public bool? GenerateSecret { get; set; }

    /// <summary>ID of the user pool client.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Time limit, between 5 minutes and 1 day, after which the ID token is no longer valid and cannot be used. By default, the unit is hours. The unit can be overridden by a value in token_validity_units.id_token.</summary>
    [JsonPropertyName("idTokenValidity")]
    public double? IdTokenValidity { get; set; }

    /// <summary>List of allowed logout URLs for the identity providers.</summary>
    [JsonPropertyName("logoutUrls")]
    public IList<string>? LogoutUrls { get; set; }

    /// <summary>Name of the application client.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Choose which errors and responses are returned by Cognito APIs during authentication, account confirmation, and password recovery when the user does not exist in the user pool. When set to ENABLED and the user does not exist, authentication returns an error indicating either the username or password was incorrect, and account confirmation and password recovery return a response indicating a code was sent to a simulated destination. When set to LEGACY, those APIs will return a UserNotFoundException exception if the user does not exist in the user pool.</summary>
    [JsonPropertyName("preventUserExistenceErrors")]
    public string? PreventUserExistenceErrors { get; set; }

    /// <summary>List of user pool attributes the application client can read from.</summary>
    [JsonPropertyName("readAttributes")]
    public IList<string>? ReadAttributes { get; set; }

    /// <summary>Time limit, between 60 minutes and 10 years, after which the refresh token is no longer valid and cannot be used. By default, the unit is days. The unit can be overridden by a value in token_validity_units.refresh_token.</summary>
    [JsonPropertyName("refreshTokenValidity")]
    public double? RefreshTokenValidity { get; set; }

    /// <summary>List of provider names for the identity providers that are supported on this client. Uses the provider_name attribute of aws_cognito_identity_provider resource(s), or the equivalent string(s).</summary>
    [JsonPropertyName("supportedIdentityProviders")]
    public IList<string>? SupportedIdentityProviders { get; set; }

    /// <summary>Configuration block for units in which the validity times are represented in. Detailed below.</summary>
    [JsonPropertyName("tokenValidityUnits")]
    public IList<V1beta1UserPoolClientStatusAtProviderTokenValidityUnits>? TokenValidityUnits { get; set; }

    /// <summary>User pool the client belongs to.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>List of user pool attributes the application client can write to.</summary>
    [JsonPropertyName("writeAttributes")]
    public IList<string>? WriteAttributes { get; set; }
}

public partial class V1beta1UserPoolClientStatusConditions
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

public partial class V1beta1UserPoolClientStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UserPoolClientStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserPoolClientStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserPoolClient : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserPoolClientSpec>, IStatus<V1beta1UserPoolClientStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserPoolClient";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "userpoolclients";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserPoolClientSpec defines the desired state of UserPoolClient</summary>
    [JsonPropertyName("spec")]
    public V1beta1UserPoolClientSpec Spec { get; set; }

    /// <summary>UserPoolClientStatus defines the observed state of UserPoolClient.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserPoolClientStatus? Status { get; set; }
}