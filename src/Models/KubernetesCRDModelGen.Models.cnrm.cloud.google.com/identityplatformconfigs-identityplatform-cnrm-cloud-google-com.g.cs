using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IdentityPlatformConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IdentityPlatformConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IdentityPlatformConfigList";
    public const string KubeGroup = "identityplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "identityplatformconfigs";
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
    public IList<V1beta1IdentityPlatformConfig> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecBlockingFunctionsTriggersFunctionUriRef
{
    /// <summary>HTTP URI trigger for the Cloud Function.  Allowed value: The `httpsTrigger.url` field of a `CloudFunctionsFunction` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecBlockingFunctionsTriggers
{
    /// <summary></summary>
    [JsonPropertyName("functionUriRef")]
    public V1beta1IdentityPlatformConfigSpecBlockingFunctionsTriggersFunctionUriRef? FunctionUriRef { get; set; }

    /// <summary>When the trigger was changed.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Configuration related to blocking functions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecBlockingFunctions
{
    /// <summary>Map of Trigger to event type. Key should be one of the supported event types: "beforeCreate", "beforeSignIn"</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, V1beta1IdentityPlatformConfigSpecBlockingFunctionsTriggers>? Triggers { get; set; }
}

/// <summary>Configuration related to restricting a user's ability to affect their account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecClientPermissions
{
    /// <summary>When true, end users cannot delete their account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserDeletion")]
    public bool? DisabledUserDeletion { get; set; }

    /// <summary>When true, end users cannot sign up for a new account on the associated project through any of our API methods</summary>
    [JsonPropertyName("disabledUserSignup")]
    public bool? DisabledUserSignup { get; set; }
}

/// <summary>Options related to how clients making requests on behalf of a project should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecClient
{
    /// <summary>Configuration related to restricting a user's ability to affect their account.</summary>
    [JsonPropertyName("permissions")]
    public V1beta1IdentityPlatformConfigSpecClientPermissions? Permissions { get; set; }
}

/// <summary>Configuration for this project's multi-factor authentication, including whether it is active and what factors can be used for the second factor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecMfa
{
    /// <summary>Whether MultiFactor Authentication has been enabled for this project. Possible values: STATE_UNSPECIFIED, DISABLED, ENABLED, MANDATORY</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Configuration for logging requests made to this project to Stackdriver Logging</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecMonitoringRequestLogging
{
    /// <summary>Whether logging is enabled for this project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration related to monitoring project activity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecMonitoring
{
    /// <summary>Configuration for logging requests made to this project to Stackdriver Logging</summary>
    [JsonPropertyName("requestLogging")]
    public V1beta1IdentityPlatformConfigSpecMonitoringRequestLogging? RequestLogging { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecMultiTenantDefaultTenantLocationRef
{
    /// <summary>The default cloud parent org or folder that the tenant project should be created under. The parent resource name should be in the format of "&lt;type&gt;/&lt;number&gt;", such as "folders/123" or "organizations/456". If the value is not set, the tenant will be created under the same organization or folder as the agent project.  Allowed values: * The Google Cloud resource name of a `Folder` resource (format: `folders/{{name}}`). * The Google Cloud resource name of a Google Cloud Organization (format: `organizations/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent. Allowed values: Folder</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>[WARNING] Organization not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration related to multi-tenant functionality.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecMultiTenant
{
    /// <summary>Whether this project can have tenants or not.</summary>
    [JsonPropertyName("allowTenants")]
    public bool? AllowTenants { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultTenantLocationRef")]
    public V1beta1IdentityPlatformConfigSpecMultiTenantDefaultTenantLocationRef? DefaultTenantLocationRef { get; set; }
}

/// <summary>Email template for change email</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailChangeEmailTemplate
{
    /// <summary>Immutable. Email body</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Email body format Possible values: BODY_FORMAT_UNSPECIFIED, PLAIN_TEXT, HTML</summary>
    [JsonPropertyName("bodyFormat")]
    public string? BodyFormat { get; set; }

    /// <summary>Reply-to address</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Sender display name</summary>
    [JsonPropertyName("senderDisplayName")]
    public string? SenderDisplayName { get; set; }

    /// <summary>Local part of From address</summary>
    [JsonPropertyName("senderLocalPart")]
    public string? SenderLocalPart { get; set; }

    /// <summary>Subject of the email</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>Information of custom domain DNS verification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailDnsInfo
{
    /// <summary>Whether to use custom domain.</summary>
    [JsonPropertyName("useCustomDomain")]
    public bool? UseCustomDomain { get; set; }
}

/// <summary>Email template for reset password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailResetPasswordTemplate
{
    /// <summary>Email body</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Email body format Possible values: BODY_FORMAT_UNSPECIFIED, PLAIN_TEXT, HTML</summary>
    [JsonPropertyName("bodyFormat")]
    public string? BodyFormat { get; set; }

    /// <summary>Reply-to address</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Sender display name</summary>
    [JsonPropertyName("senderDisplayName")]
    public string? SenderDisplayName { get; set; }

    /// <summary>Local part of From address</summary>
    [JsonPropertyName("senderLocalPart")]
    public string? SenderLocalPart { get; set; }

    /// <summary>Subject of the email</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>Email template for reverting second factor addition emails</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailRevertSecondFactorAdditionTemplate
{
    /// <summary>Immutable. Email body</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Email body format Possible values: BODY_FORMAT_UNSPECIFIED, PLAIN_TEXT, HTML</summary>
    [JsonPropertyName("bodyFormat")]
    public string? BodyFormat { get; set; }

    /// <summary>Reply-to address</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Sender display name</summary>
    [JsonPropertyName("senderDisplayName")]
    public string? SenderDisplayName { get; set; }

    /// <summary>Local part of From address</summary>
    [JsonPropertyName("senderLocalPart")]
    public string? SenderLocalPart { get; set; }

    /// <summary>Subject of the email</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtpPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtpPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtpPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>SMTP relay password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtpPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtpPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>Use a custom SMTP relay</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtp
{
    /// <summary>SMTP relay host</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>SMTP relay password</summary>
    [JsonPropertyName("password")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtpPassword? Password { get; set; }

    /// <summary>SMTP relay port</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>SMTP security mode. Possible values: SECURITY_MODE_UNSPECIFIED, SSL, START_TLS</summary>
    [JsonPropertyName("securityMode")]
    public string? SecurityMode { get; set; }

    /// <summary>Sender email for the SMTP relay</summary>
    [JsonPropertyName("senderEmail")]
    public string? SenderEmail { get; set; }

    /// <summary>SMTP relay username</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Email template for verify email</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmailVerifyEmailTemplate
{
    /// <summary>Immutable. Email body</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Email body format Possible values: BODY_FORMAT_UNSPECIFIED, PLAIN_TEXT, HTML</summary>
    [JsonPropertyName("bodyFormat")]
    public string? BodyFormat { get; set; }

    /// <summary>Reply-to address</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Sender display name</summary>
    [JsonPropertyName("senderDisplayName")]
    public string? SenderDisplayName { get; set; }

    /// <summary>Local part of From address</summary>
    [JsonPropertyName("senderLocalPart")]
    public string? SenderLocalPart { get; set; }

    /// <summary>Subject of the email</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>Options for email sending.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendEmail
{
    /// <summary>action url in email template.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>Email template for change email</summary>
    [JsonPropertyName("changeEmailTemplate")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailChangeEmailTemplate? ChangeEmailTemplate { get; set; }

    /// <summary>Information of custom domain DNS verification.</summary>
    [JsonPropertyName("dnsInfo")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailDnsInfo? DnsInfo { get; set; }

    /// <summary>The method used for sending an email. Possible values: METHOD_UNSPECIFIED, DEFAULT, CUSTOM_SMTP</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Email template for reset password</summary>
    [JsonPropertyName("resetPasswordTemplate")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailResetPasswordTemplate? ResetPasswordTemplate { get; set; }

    /// <summary>Email template for reverting second factor addition emails</summary>
    [JsonPropertyName("revertSecondFactorAdditionTemplate")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailRevertSecondFactorAdditionTemplate? RevertSecondFactorAdditionTemplate { get; set; }

    /// <summary>Use a custom SMTP relay</summary>
    [JsonPropertyName("smtp")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailSmtp? Smtp { get; set; }

    /// <summary>Email template for verify email</summary>
    [JsonPropertyName("verifyEmailTemplate")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmailVerifyEmailTemplate? VerifyEmailTemplate { get; set; }
}

/// <summary>Options for SMS sending.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotificationSendSms
{
    /// <summary>Whether to use the accept_language header for SMS.</summary>
    [JsonPropertyName("useDeviceLocale")]
    public bool? UseDeviceLocale { get; set; }
}

/// <summary>Configuration related to sending notifications to users.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecNotification
{
    /// <summary>Default locale used for email and SMS in IETF BCP 47 format.</summary>
    [JsonPropertyName("defaultLocale")]
    public string? DefaultLocale { get; set; }

    /// <summary>Options for email sending.</summary>
    [JsonPropertyName("sendEmail")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendEmail? SendEmail { get; set; }

    /// <summary>Options for SMS sending.</summary>
    [JsonPropertyName("sendSms")]
    public V1beta1IdentityPlatformConfigSpecNotificationSendSms? SendSms { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecProjectRef
{
    /// <summary>The project of the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecQuotaSignUpQuotaConfig
{
    /// <summary>Corresponds to the 'refill_token_count' field in QuotaServer config</summary>
    [JsonPropertyName("quota")]
    public long? Quota { get; set; }

    /// <summary>How long this quota will be active for</summary>
    [JsonPropertyName("quotaDuration")]
    public string? QuotaDuration { get; set; }

    /// <summary>When this quota will take affect</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Configuration related to quotas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecQuota
{
    /// <summary>Quota for the Signup endpoint, if overwritten. Signup quota is measured in sign ups per project per hour per IP.</summary>
    [JsonPropertyName("signUpQuotaConfig")]
    public V1beta1IdentityPlatformConfigSpecQuotaSignUpQuotaConfig? SignUpQuotaConfig { get; set; }
}

/// <summary>Configuration options related to authenticating an anonymous user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecSignInAnonymous
{
    /// <summary>Whether anonymous user auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration options related to authenticating a user by their email address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecSignInEmail
{
    /// <summary>Whether email auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether a password is required for email auth or not. If true, both an email and password must be provided to sign in. If false, a user may sign in via either email/password or email link.</summary>
    [JsonPropertyName("passwordRequired")]
    public bool? PasswordRequired { get; set; }
}

/// <summary>Configuration options related to authenticated a user by their phone number.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecSignInPhoneNumber
{
    /// <summary>Whether phone number auth is enabled for the project or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A map of that can be used for phone auth testing.</summary>
    [JsonPropertyName("testPhoneNumbers")]
    public IDictionary<string, string>? TestPhoneNumbers { get; set; }
}

/// <summary>Configuration related to local sign in methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpecSignIn
{
    /// <summary>Whether to allow more than one account to have the same email.</summary>
    [JsonPropertyName("allowDuplicateEmails")]
    public bool? AllowDuplicateEmails { get; set; }

    /// <summary>Configuration options related to authenticating an anonymous user.</summary>
    [JsonPropertyName("anonymous")]
    public V1beta1IdentityPlatformConfigSpecSignInAnonymous? Anonymous { get; set; }

    /// <summary>Configuration options related to authenticating a user by their email address.</summary>
    [JsonPropertyName("email")]
    public V1beta1IdentityPlatformConfigSpecSignInEmail? Email { get; set; }

    /// <summary>Configuration options related to authenticated a user by their phone number.</summary>
    [JsonPropertyName("phoneNumber")]
    public V1beta1IdentityPlatformConfigSpecSignInPhoneNumber? PhoneNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigSpec
{
    /// <summary>List of domains authorized for OAuth redirects</summary>
    [JsonPropertyName("authorizedDomains")]
    public IList<string>? AuthorizedDomains { get; set; }

    /// <summary>Configuration related to blocking functions.</summary>
    [JsonPropertyName("blockingFunctions")]
    public V1beta1IdentityPlatformConfigSpecBlockingFunctions? BlockingFunctions { get; set; }

    /// <summary>Options related to how clients making requests on behalf of a project should be configured.</summary>
    [JsonPropertyName("client")]
    public V1beta1IdentityPlatformConfigSpecClient? Client { get; set; }

    /// <summary>Configuration for this project's multi-factor authentication, including whether it is active and what factors can be used for the second factor</summary>
    [JsonPropertyName("mfa")]
    public V1beta1IdentityPlatformConfigSpecMfa? Mfa { get; set; }

    /// <summary>Configuration related to monitoring project activity.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta1IdentityPlatformConfigSpecMonitoring? Monitoring { get; set; }

    /// <summary>Configuration related to multi-tenant functionality.</summary>
    [JsonPropertyName("multiTenant")]
    public V1beta1IdentityPlatformConfigSpecMultiTenant? MultiTenant { get; set; }

    /// <summary>Configuration related to sending notifications to users.</summary>
    [JsonPropertyName("notification")]
    public V1beta1IdentityPlatformConfigSpecNotification? Notification { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1IdentityPlatformConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>Configuration related to quotas.</summary>
    [JsonPropertyName("quota")]
    public V1beta1IdentityPlatformConfigSpecQuota? Quota { get; set; }

    /// <summary>Configuration related to local sign in methods.</summary>
    [JsonPropertyName("signIn")]
    public V1beta1IdentityPlatformConfigSpecSignIn? SignIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusClient
{
    /// <summary>Output only. API key that can be used when making requests for this project.</summary>
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    /// <summary>Output only. Firebase subdomain.</summary>
    [JsonPropertyName("firebaseSubdomain")]
    public string? FirebaseSubdomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendEmailChangeEmailTemplate
{
    /// <summary>Output only. Whether the body or subject of the email is customized.</summary>
    [JsonPropertyName("customized")]
    public bool? Customized { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendEmailDnsInfo
{
    /// <summary>Output only. The applied verified custom domain.</summary>
    [JsonPropertyName("customDomain")]
    public string? CustomDomain { get; set; }

    /// <summary>Output only. The current verification state of the custom domain. The custom domain will only be used once the domain verification is successful. Possible values: VERIFICATION_STATE_UNSPECIFIED, NOT_STARTED, IN_PROGRESS, FAILED, SUCCEEDED</summary>
    [JsonPropertyName("customDomainState")]
    public string? CustomDomainState { get; set; }

    /// <summary>Output only. The timestamp of initial request for the current domain verification.</summary>
    [JsonPropertyName("domainVerificationRequestTime")]
    public string? DomainVerificationRequestTime { get; set; }

    /// <summary>Output only. The custom domain that's to be verified.</summary>
    [JsonPropertyName("pendingCustomDomain")]
    public string? PendingCustomDomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendEmailResetPasswordTemplate
{
    /// <summary>Output only. Whether the body or subject of the email is customized.</summary>
    [JsonPropertyName("customized")]
    public bool? Customized { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendEmailRevertSecondFactorAdditionTemplate
{
    /// <summary>Output only. Whether the body or subject of the email is customized.</summary>
    [JsonPropertyName("customized")]
    public bool? Customized { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendEmailVerifyEmailTemplate
{
    /// <summary>Output only. Whether the body or subject of the email is customized.</summary>
    [JsonPropertyName("customized")]
    public bool? Customized { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendEmail
{
    /// <summary></summary>
    [JsonPropertyName("changeEmailTemplate")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendEmailChangeEmailTemplate? ChangeEmailTemplate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsInfo")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendEmailDnsInfo? DnsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resetPasswordTemplate")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendEmailResetPasswordTemplate? ResetPasswordTemplate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revertSecondFactorAdditionTemplate")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendEmailRevertSecondFactorAdditionTemplate? RevertSecondFactorAdditionTemplate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("verifyEmailTemplate")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendEmailVerifyEmailTemplate? VerifyEmailTemplate { get; set; }
}

/// <summary>Output only. The template to use when sending an SMS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendSmsSmsTemplate
{
    /// <summary>Output only. The SMS's content. Can contain the following placeholders which will be replaced with the appropriate values: %APP_NAME% - For Android or iOS apps, the app's display name. For web apps, the domain hosting the application. %LOGIN_CODE% - The OOB code being sent in the SMS.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotificationSendSms
{
    /// <summary>Output only. The template to use when sending an SMS.</summary>
    [JsonPropertyName("smsTemplate")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendSmsSmsTemplate? SmsTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusNotification
{
    /// <summary></summary>
    [JsonPropertyName("sendEmail")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendEmail? SendEmail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendSms")]
    public V1beta1IdentityPlatformConfigStatusNotificationSendSms? SendSms { get; set; }
}

/// <summary>Output only. Hash config information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusSignInEmailHashConfig
{
    /// <summary>Output only. Different password hash algorithms used in Identity Toolkit. Possible values: HASH_ALGORITHM_UNSPECIFIED, HMAC_SHA256, HMAC_SHA1, HMAC_MD5, SCRYPT, PBKDF_SHA1, MD5, HMAC_SHA512, SHA1, BCRYPT, PBKDF2_SHA256, SHA256, SHA512, STANDARD_SCRYPT</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Output only. Memory cost for hash calculation. Used by scrypt and other similar password derivation algorithms. See https://tools.ietf.org/html/rfc7914 for explanation of field.</summary>
    [JsonPropertyName("memoryCost")]
    public long? MemoryCost { get; set; }

    /// <summary>Output only. How many rounds for hash calculation. Used by scrypt and other similar password derivation algorithms.</summary>
    [JsonPropertyName("rounds")]
    public long? Rounds { get; set; }

    /// <summary>Output only. Non-printable character to be inserted between the salt and plain text password in base64.</summary>
    [JsonPropertyName("saltSeparator")]
    public string? SaltSeparator { get; set; }

    /// <summary>Output only. Signer key in base64.</summary>
    [JsonPropertyName("signerKey")]
    public string? SignerKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusSignInEmail
{
    /// <summary>Output only. Hash config information.</summary>
    [JsonPropertyName("hashConfig")]
    public V1beta1IdentityPlatformConfigStatusSignInEmailHashConfig? HashConfig { get; set; }
}

/// <summary>Output only. Hash config information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusSignInHashConfig
{
    /// <summary>Output only. Different password hash algorithms used in Identity Toolkit. Possible values: HASH_ALGORITHM_UNSPECIFIED, HMAC_SHA256, HMAC_SHA1, HMAC_MD5, SCRYPT, PBKDF_SHA1, MD5, HMAC_SHA512, SHA1, BCRYPT, PBKDF2_SHA256, SHA256, SHA512, STANDARD_SCRYPT</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Output only. Memory cost for hash calculation. Used by scrypt and other similar password derivation algorithms. See https://tools.ietf.org/html/rfc7914 for explanation of field.</summary>
    [JsonPropertyName("memoryCost")]
    public long? MemoryCost { get; set; }

    /// <summary>Output only. How many rounds for hash calculation. Used by scrypt and other similar password derivation algorithms.</summary>
    [JsonPropertyName("rounds")]
    public long? Rounds { get; set; }

    /// <summary>Output only. Non-printable character to be inserted between the salt and plain text password in base64.</summary>
    [JsonPropertyName("saltSeparator")]
    public string? SaltSeparator { get; set; }

    /// <summary>Output only. Signer key in base64.</summary>
    [JsonPropertyName("signerKey")]
    public string? SignerKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatusSignIn
{
    /// <summary></summary>
    [JsonPropertyName("email")]
    public V1beta1IdentityPlatformConfigStatusSignInEmail? Email { get; set; }

    /// <summary>Output only. Hash config information.</summary>
    [JsonPropertyName("hashConfig")]
    public V1beta1IdentityPlatformConfigStatusSignInHashConfig? HashConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IdentityPlatformConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("client")]
    public V1beta1IdentityPlatformConfigStatusClient? Client { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IdentityPlatformConfigStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notification")]
    public V1beta1IdentityPlatformConfigStatusNotification? Notification { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("signIn")]
    public V1beta1IdentityPlatformConfigStatusSignIn? SignIn { get; set; }

    /// <summary>Output only. The subtype of this config. Possible values: SUBTYPE_UNSPECIFIED, IDENTITY_PLATFORM, FIREBASE_AUTH</summary>
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IdentityPlatformConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IdentityPlatformConfigSpec>, IStatus<V1beta1IdentityPlatformConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IdentityPlatformConfig";
    public const string KubeGroup = "identityplatform.cnrm.cloud.google.com";
    public const string KubePluralName = "identityplatformconfigs";
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
    public V1beta1IdentityPlatformConfigSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1IdentityPlatformConfigStatus? Status { get; set; }
}