using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidp.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecDeletionPolicyEnum
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
public partial class V1beta1UserPoolSpecForProviderAccountRecoverySettingRecoveryMechanism
{
    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Positive integer specifying priority of a method with 1 being the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderAccountRecoverySetting
{
    /// <summary>List of Account Recovery Options of the following structure:</summary>
    [JsonPropertyName("recoveryMechanism")]
    public IList<V1beta1UserPoolSpecForProviderAccountRecoverySettingRecoveryMechanism>? RecoveryMechanism { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderAdminCreateUserConfigInviteMessageTemplate
{
    /// <summary>Message template for email messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Subject line for email messages.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Message template for SMS messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderAdminCreateUserConfig
{
    /// <summary>Set to True if only the administrator is allowed to create user profiles. Set to False if users can sign themselves up via an app.</summary>
    [JsonPropertyName("allowAdminCreateUserOnly")]
    public bool? AllowAdminCreateUserOnly { get; set; }

    /// <summary>Invite message template structure. Detailed below.</summary>
    [JsonPropertyName("inviteMessageTemplate")]
    public IList<V1beta1UserPoolSpecForProviderAdminCreateUserConfigInviteMessageTemplate>? InviteMessageTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderDeviceConfiguration
{
    /// <summary>Whether a challenge is required on a new device. Only applicable to a new device.</summary>
    [JsonPropertyName("challengeRequiredOnNewDevice")]
    public bool? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>Whether a device is only remembered on user prompt. false equates to "Always" remember, true is "User Opt In," and not using a device_configuration block is "No."</summary>
    [JsonPropertyName("deviceOnlyRememberedOnUserPrompt")]
    public bool? DeviceOnlyRememberedOnUserPrompt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderEmailConfiguration
{
    /// <summary>Email configuration set name from SES.</summary>
    [JsonPropertyName("configurationSet")]
    public string? ConfigurationSet { get; set; }

    /// <summary>Email delivery method to use. COGNITO_DEFAULT for the default email functionality built into Cognito or DEVELOPER to use your Amazon SES configuration. Required to be DEVELOPER if from_email_address is set.</summary>
    [JsonPropertyName("emailSendingAccount")]
    public string? EmailSendingAccount { get; set; }

    /// <summary>Sender’s email address or sender’s display name with their email address (e.g., john@example.com, John Smith &lt;john@example.com&gt; or \"John Smith Ph.D.\" &lt;john@example.com&gt;). Escaped double quotes are required around display names that contain certain characters as specified in RFC 5322.</summary>
    [JsonPropertyName("fromEmailAddress")]
    public string? FromEmailAddress { get; set; }

    /// <summary>REPLY-TO email address.</summary>
    [JsonPropertyName("replyToEmailAddress")]
    public string? ReplyToEmailAddress { get; set; }

    /// <summary>ARN of the SES verified email identity to use. Required if email_sending_account is set to DEVELOPER.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send email notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the "request" attribute in the "event" information Amazon Cognito passes to your custom email Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the "request" attribute in the "event" information Amazon Cognito passes to your custom SMS Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationConfig
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the "version" attribute in the "event" information Amazon Cognito passes to your pre Token Generation Lambda function. The supported values are V1_0, V2_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderLambdaConfig
{
    /// <summary>ARN of the lambda creating an authentication challenge.</summary>
    [JsonPropertyName("createAuthChallenge")]
    public string? CreateAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRef? CreateAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelector? CreateAuthChallengeSelector { get; set; }

    /// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
    [JsonPropertyName("customEmailSender")]
    public IList<V1beta1UserPoolSpecForProviderLambdaConfigCustomEmailSender>? CustomEmailSender { get; set; }

    /// <summary>Custom Message AWS Lambda trigger.</summary>
    [JsonPropertyName("customMessage")]
    public string? CustomMessage { get; set; }

    /// <summary>Reference to a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageRef? CustomMessageRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigCustomMessageSelector? CustomMessageSelector { get; set; }

    /// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
    [JsonPropertyName("customSmsSender")]
    public IList<V1beta1UserPoolSpecForProviderLambdaConfigCustomSmsSender>? CustomSmsSender { get; set; }

    /// <summary>Defines the authentication challenge.</summary>
    [JsonPropertyName("defineAuthChallenge")]
    public string? DefineAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRef? DefineAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelector? DefineAuthChallengeSelector { get; set; }

    /// <summary>The Amazon Resource Name of Key Management Service Customer master keys. Amazon Cognito uses the key to encrypt codes and temporary passwords sent to CustomEmailSender and CustomSMSSender.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Post-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("postAuthentication")]
    public string? PostAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationRef? PostAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostAuthenticationSelector? PostAuthenticationSelector { get; set; }

    /// <summary>Post-confirmation AWS Lambda trigger.</summary>
    [JsonPropertyName("postConfirmation")]
    public string? PostConfirmation { get; set; }

    /// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationRef? PostConfirmationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPostConfirmationSelector? PostConfirmationSelector { get; set; }

    /// <summary>Pre-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("preAuthentication")]
    public string? PreAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationRef? PreAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreAuthenticationSelector? PreAuthenticationSelector { get; set; }

    /// <summary>Pre-registration AWS Lambda trigger.</summary>
    [JsonPropertyName("preSignUp")]
    public string? PreSignUp { get; set; }

    /// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpRef? PreSignUpRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreSignUpSelector? PreSignUpSelector { get; set; }

    /// <summary>Allow to customize identity token claims before token generation. Set this parameter for legacy purposes; for new instances of pre token generation triggers, set the lambda_arn of pre_token_generation_config.</summary>
    [JsonPropertyName("preTokenGeneration")]
    public string? PreTokenGeneration { get; set; }

    /// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
    [JsonPropertyName("preTokenGenerationConfig")]
    public IList<V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationConfig>? PreTokenGenerationConfig { get; set; }

    /// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationRef? PreTokenGenerationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelector? PreTokenGenerationSelector { get; set; }

    /// <summary>User migration Lambda config type.</summary>
    [JsonPropertyName("userMigration")]
    public string? UserMigration { get; set; }

    /// <summary>Reference to a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationRef? UserMigrationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigUserMigrationSelector? UserMigrationSelector { get; set; }

    /// <summary>Verifies the authentication challenge response.</summary>
    [JsonPropertyName("verifyAuthChallengeResponse")]
    public string? VerifyAuthChallengeResponse { get; set; }

    /// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseRef")]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRef? VerifyAuthChallengeResponseRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseSelector")]
    public V1beta1UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelector? VerifyAuthChallengeResponseSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderPasswordPolicy
{
    /// <summary>Minimum length of the password policy that you have set.</summary>
    [JsonPropertyName("minimumLength")]
    public double? MinimumLength { get; set; }

    /// <summary>Whether you have required users to use at least one lowercase letter in their password.</summary>
    [JsonPropertyName("requireLowercase")]
    public bool? RequireLowercase { get; set; }

    /// <summary>Whether you have required users to use at least one number in their password.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether you have required users to use at least one symbol in their password.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether you have required users to use at least one uppercase letter in their password.</summary>
    [JsonPropertyName("requireUppercase")]
    public bool? RequireUppercase { get; set; }

    /// <summary>In the password policy you have set, refers to the number of days a temporary password is valid. If the user does not sign-in during this time, their password will need to be reset by an administrator.</summary>
    [JsonPropertyName("temporaryPasswordValidityDays")]
    public double? TemporaryPasswordValidityDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderSchemaNumberAttributeConstraints
{
    /// <summary>Maximum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>Minimum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderSchemaStringAttributeConstraints
{
    /// <summary>Maximum length of an attribute value of the string type.</summary>
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    /// <summary>Minimum length of an attribute value of the string type.</summary>
    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderSchema
{
    /// <summary>Attribute data type. Must be one of Boolean, Number, String, DateTime.</summary>
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    /// <summary>Whether the attribute type is developer only.</summary>
    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    /// <summary>Whether the attribute can be changed once it has been created.</summary>
    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public IList<V1beta1UserPoolSpecForProviderSchemaNumberAttributeConstraints>? NumberAttributeConstraints { get; set; }

    /// <summary>Whether a user pool attribute is required. If the attribute is required and the user does not provide a value, registration or sign-in will fail.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public IList<V1beta1UserPoolSpecForProviderSchemaStringAttributeConstraints>? StringAttributeConstraints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderSmsConfiguration
{
    /// <summary>External ID used in IAM role trust relationships. For more information about using external IDs, see How to Use an External ID When Granting Access to Your AWS Resources to a Third Party.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of the Amazon SNS caller. This is usually the IAM role that you've given Cognito permission to assume.</summary>
    [JsonPropertyName("snsCallerArn")]
    public string? SnsCallerArn { get; set; }

    /// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnRef")]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnRef? SnsCallerArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnSelector")]
    public V1beta1UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelector? SnsCallerArnSelector { get; set; }

    /// <summary>The AWS Region to use with Amazon SNS integration. You can choose the same Region as your user pool, or a supported Legacy Amazon SNS alternate Region. Amazon Cognito resources in the Asia Pacific (Seoul) AWS Region must use your Amazon SNS configuration in the Asia Pacific (Tokyo) Region. For more information, see SMS message settings for Amazon Cognito user pools.</summary>
    [JsonPropertyName("snsRegion")]
    public string? SnsRegion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderSoftwareTokenMfaConfiguration
{
    /// <summary>Boolean whether to enable software token Multi-Factor (MFA) tokens, such as Time-based One-Time Password (TOTP). To disable software token MFA When sms_configuration is not present, the mfa_configuration argument must be set to OFF and the software_token_mfa_configuration configuration block must be fully removed.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderUserAttributeUpdateSettings
{
    /// <summary>A list of attributes requiring verification before update. If set, the provided value(s) must also be set in auto_verified_attributes. Valid values: email, phone_number.</summary>
    [JsonPropertyName("attributesRequireVerificationBeforeUpdate")]
    public IList<string>? AttributesRequireVerificationBeforeUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderUserPoolAddOns
{
    /// <summary>Mode for advanced security, must be one of OFF, AUDIT or ENFORCED.</summary>
    [JsonPropertyName("advancedSecurityMode")]
    public string? AdvancedSecurityMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderUsernameConfiguration
{
    /// <summary>Whether username case sensitivity will be applied for all users in the user pool through Cognito APIs.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProviderVerificationMessageTemplate
{
    /// <summary>Default email option. Must be either CONFIRM_WITH_CODE or CONFIRM_WITH_LINK. Defaults to CONFIRM_WITH_CODE.</summary>
    [JsonPropertyName("defaultEmailOption")]
    public string? DefaultEmailOption { get; set; }

    /// <summary>Email message template. Must contain the {####} placeholder. Conflicts with email_verification_message argument.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Email message template for sending a confirmation link to the user, it must contain the {##Click Here##} placeholder.</summary>
    [JsonPropertyName("emailMessageByLink")]
    public string? EmailMessageByLink { get; set; }

    /// <summary>Subject line for the email message template. Conflicts with email_verification_subject argument.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Subject line for the email message template for sending a confirmation link to the user.</summary>
    [JsonPropertyName("emailSubjectByLink")]
    public string? EmailSubjectByLink { get; set; }

    /// <summary>SMS message template. Must contain the {####} placeholder. Conflicts with sms_verification_message argument.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecForProvider
{
    /// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
    [JsonPropertyName("accountRecoverySetting")]
    public IList<V1beta1UserPoolSpecForProviderAccountRecoverySetting>? AccountRecoverySetting { get; set; }

    /// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
    [JsonPropertyName("adminCreateUserConfig")]
    public IList<V1beta1UserPoolSpecForProviderAdminCreateUserConfig>? AdminCreateUserConfig { get; set; }

    /// <summary>Attributes supported as an alias for this user pool. Valid values: phone_number, email, or preferred_username. Conflicts with username_attributes.</summary>
    [JsonPropertyName("aliasAttributes")]
    public IList<string>? AliasAttributes { get; set; }

    /// <summary>Attributes to be auto-verified. Valid values: email, phone_number.</summary>
    [JsonPropertyName("autoVerifiedAttributes")]
    public IList<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>When active, DeletionProtection prevents accidental deletion of your user pool. Before you can delete a user pool that you have protected against deletion, you must deactivate this feature. Valid values are ACTIVE and INACTIVE, Default value is INACTIVE.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>Configuration block for the user pool's device tracking. Detailed below.</summary>
    [JsonPropertyName("deviceConfiguration")]
    public IList<V1beta1UserPoolSpecForProviderDeviceConfiguration>? DeviceConfiguration { get; set; }

    /// <summary>Configuration block for configuring email. Detailed below.</summary>
    [JsonPropertyName("emailConfiguration")]
    public IList<V1beta1UserPoolSpecForProviderEmailConfiguration>? EmailConfiguration { get; set; }

    /// <summary>String representing the email verification message. Conflicts with verification_message_template configuration block email_message argument.</summary>
    [JsonPropertyName("emailVerificationMessage")]
    public string? EmailVerificationMessage { get; set; }

    /// <summary>String representing the email verification subject. Conflicts with verification_message_template configuration block email_subject argument.</summary>
    [JsonPropertyName("emailVerificationSubject")]
    public string? EmailVerificationSubject { get; set; }

    /// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1UserPoolSpecForProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Multi-Factor Authentication (MFA) configuration for the User Pool. Defaults of OFF. Valid values are OFF (MFA Tokens are not required), ON (MFA is required for all users to sign in; requires at least one of sms_configuration or software_token_mfa_configuration to be configured), or OPTIONAL (MFA Will be required only for individual users who have MFA Enabled; requires at least one of sms_configuration or software_token_mfa_configuration to be configured).</summary>
    [JsonPropertyName("mfaConfiguration")]
    public string? MfaConfiguration { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
    [JsonPropertyName("passwordPolicy")]
    public IList<V1beta1UserPoolSpecForProviderPasswordPolicy>? PasswordPolicy { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block for the schema attributes of a user pool. Detailed below. Schema attributes from the standard attribute set only need to be specified if they are different from the default configuration. Attributes can be added, but not modified or removed. Maximum of 50 attributes.</summary>
    [JsonPropertyName("schema")]
    public IList<V1beta1UserPoolSpecForProviderSchema>? Schema { get; set; }

    /// <summary>String representing the SMS authentication message. The Message must contain the {####} placeholder, which will be replaced with the code.</summary>
    [JsonPropertyName("smsAuthenticationMessage")]
    public string? SmsAuthenticationMessage { get; set; }

    /// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
    [JsonPropertyName("smsConfiguration")]
    public IList<V1beta1UserPoolSpecForProviderSmsConfiguration>? SmsConfiguration { get; set; }

    /// <summary>String representing the SMS verification message. Conflicts with verification_message_template configuration block sms_message argument.</summary>
    [JsonPropertyName("smsVerificationMessage")]
    public string? SmsVerificationMessage { get; set; }

    /// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Detailed below.</summary>
    [JsonPropertyName("softwareTokenMfaConfiguration")]
    public IList<V1beta1UserPoolSpecForProviderSoftwareTokenMfaConfiguration>? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
    [JsonPropertyName("userAttributeUpdateSettings")]
    public IList<V1beta1UserPoolSpecForProviderUserAttributeUpdateSettings>? UserAttributeUpdateSettings { get; set; }

    /// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
    [JsonPropertyName("userPoolAddOns")]
    public IList<V1beta1UserPoolSpecForProviderUserPoolAddOns>? UserPoolAddOns { get; set; }

    /// <summary>Whether email addresses or phone numbers can be specified as usernames when a user signs up. Conflicts with alias_attributes.</summary>
    [JsonPropertyName("usernameAttributes")]
    public IList<string>? UsernameAttributes { get; set; }

    /// <summary>Configuration block for username configuration. Detailed below.</summary>
    [JsonPropertyName("usernameConfiguration")]
    public IList<V1beta1UserPoolSpecForProviderUsernameConfiguration>? UsernameConfiguration { get; set; }

    /// <summary>Configuration block for verification message templates. Detailed below.</summary>
    [JsonPropertyName("verificationMessageTemplate")]
    public IList<V1beta1UserPoolSpecForProviderVerificationMessageTemplate>? VerificationMessageTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderAccountRecoverySettingRecoveryMechanism
{
    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Positive integer specifying priority of a method with 1 being the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderAccountRecoverySetting
{
    /// <summary>List of Account Recovery Options of the following structure:</summary>
    [JsonPropertyName("recoveryMechanism")]
    public IList<V1beta1UserPoolSpecInitProviderAccountRecoverySettingRecoveryMechanism>? RecoveryMechanism { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderAdminCreateUserConfigInviteMessageTemplate
{
    /// <summary>Message template for email messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Subject line for email messages.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Message template for SMS messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderAdminCreateUserConfig
{
    /// <summary>Set to True if only the administrator is allowed to create user profiles. Set to False if users can sign themselves up via an app.</summary>
    [JsonPropertyName("allowAdminCreateUserOnly")]
    public bool? AllowAdminCreateUserOnly { get; set; }

    /// <summary>Invite message template structure. Detailed below.</summary>
    [JsonPropertyName("inviteMessageTemplate")]
    public IList<V1beta1UserPoolSpecInitProviderAdminCreateUserConfigInviteMessageTemplate>? InviteMessageTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderDeviceConfiguration
{
    /// <summary>Whether a challenge is required on a new device. Only applicable to a new device.</summary>
    [JsonPropertyName("challengeRequiredOnNewDevice")]
    public bool? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>Whether a device is only remembered on user prompt. false equates to "Always" remember, true is "User Opt In," and not using a device_configuration block is "No."</summary>
    [JsonPropertyName("deviceOnlyRememberedOnUserPrompt")]
    public bool? DeviceOnlyRememberedOnUserPrompt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderEmailConfiguration
{
    /// <summary>Email configuration set name from SES.</summary>
    [JsonPropertyName("configurationSet")]
    public string? ConfigurationSet { get; set; }

    /// <summary>Email delivery method to use. COGNITO_DEFAULT for the default email functionality built into Cognito or DEVELOPER to use your Amazon SES configuration. Required to be DEVELOPER if from_email_address is set.</summary>
    [JsonPropertyName("emailSendingAccount")]
    public string? EmailSendingAccount { get; set; }

    /// <summary>Sender’s email address or sender’s display name with their email address (e.g., john@example.com, John Smith &lt;john@example.com&gt; or \"John Smith Ph.D.\" &lt;john@example.com&gt;). Escaped double quotes are required around display names that contain certain characters as specified in RFC 5322.</summary>
    [JsonPropertyName("fromEmailAddress")]
    public string? FromEmailAddress { get; set; }

    /// <summary>REPLY-TO email address.</summary>
    [JsonPropertyName("replyToEmailAddress")]
    public string? ReplyToEmailAddress { get; set; }

    /// <summary>ARN of the SES verified email identity to use. Required if email_sending_account is set to DEVELOPER.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send email notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the "request" attribute in the "event" information Amazon Cognito passes to your custom email Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the "request" attribute in the "event" information Amazon Cognito passes to your custom SMS Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationConfig
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the "version" attribute in the "event" information Amazon Cognito passes to your pre Token Generation Lambda function. The supported values are V1_0, V2_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderLambdaConfig
{
    /// <summary>ARN of the lambda creating an authentication challenge.</summary>
    [JsonPropertyName("createAuthChallenge")]
    public string? CreateAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRef? CreateAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelector? CreateAuthChallengeSelector { get; set; }

    /// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
    [JsonPropertyName("customEmailSender")]
    public IList<V1beta1UserPoolSpecInitProviderLambdaConfigCustomEmailSender>? CustomEmailSender { get; set; }

    /// <summary>Custom Message AWS Lambda trigger.</summary>
    [JsonPropertyName("customMessage")]
    public string? CustomMessage { get; set; }

    /// <summary>Reference to a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageRef? CustomMessageRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigCustomMessageSelector? CustomMessageSelector { get; set; }

    /// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
    [JsonPropertyName("customSmsSender")]
    public IList<V1beta1UserPoolSpecInitProviderLambdaConfigCustomSmsSender>? CustomSmsSender { get; set; }

    /// <summary>Defines the authentication challenge.</summary>
    [JsonPropertyName("defineAuthChallenge")]
    public string? DefineAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRef? DefineAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelector? DefineAuthChallengeSelector { get; set; }

    /// <summary>The Amazon Resource Name of Key Management Service Customer master keys. Amazon Cognito uses the key to encrypt codes and temporary passwords sent to CustomEmailSender and CustomSMSSender.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Post-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("postAuthentication")]
    public string? PostAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationRef? PostAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelector? PostAuthenticationSelector { get; set; }

    /// <summary>Post-confirmation AWS Lambda trigger.</summary>
    [JsonPropertyName("postConfirmation")]
    public string? PostConfirmation { get; set; }

    /// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationRef? PostConfirmationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPostConfirmationSelector? PostConfirmationSelector { get; set; }

    /// <summary>Pre-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("preAuthentication")]
    public string? PreAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationRef? PreAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelector? PreAuthenticationSelector { get; set; }

    /// <summary>Pre-registration AWS Lambda trigger.</summary>
    [JsonPropertyName("preSignUp")]
    public string? PreSignUp { get; set; }

    /// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpRef? PreSignUpRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreSignUpSelector? PreSignUpSelector { get; set; }

    /// <summary>Allow to customize identity token claims before token generation. Set this parameter for legacy purposes; for new instances of pre token generation triggers, set the lambda_arn of pre_token_generation_config.</summary>
    [JsonPropertyName("preTokenGeneration")]
    public string? PreTokenGeneration { get; set; }

    /// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
    [JsonPropertyName("preTokenGenerationConfig")]
    public IList<V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationConfig>? PreTokenGenerationConfig { get; set; }

    /// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRef? PreTokenGenerationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelector? PreTokenGenerationSelector { get; set; }

    /// <summary>User migration Lambda config type.</summary>
    [JsonPropertyName("userMigration")]
    public string? UserMigration { get; set; }

    /// <summary>Reference to a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationRef? UserMigrationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigUserMigrationSelector? UserMigrationSelector { get; set; }

    /// <summary>Verifies the authentication challenge response.</summary>
    [JsonPropertyName("verifyAuthChallengeResponse")]
    public string? VerifyAuthChallengeResponse { get; set; }

    /// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseRef")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRef? VerifyAuthChallengeResponseRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseSelector")]
    public V1beta1UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelector? VerifyAuthChallengeResponseSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderPasswordPolicy
{
    /// <summary>Minimum length of the password policy that you have set.</summary>
    [JsonPropertyName("minimumLength")]
    public double? MinimumLength { get; set; }

    /// <summary>Whether you have required users to use at least one lowercase letter in their password.</summary>
    [JsonPropertyName("requireLowercase")]
    public bool? RequireLowercase { get; set; }

    /// <summary>Whether you have required users to use at least one number in their password.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether you have required users to use at least one symbol in their password.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether you have required users to use at least one uppercase letter in their password.</summary>
    [JsonPropertyName("requireUppercase")]
    public bool? RequireUppercase { get; set; }

    /// <summary>In the password policy you have set, refers to the number of days a temporary password is valid. If the user does not sign-in during this time, their password will need to be reset by an administrator.</summary>
    [JsonPropertyName("temporaryPasswordValidityDays")]
    public double? TemporaryPasswordValidityDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderSchemaNumberAttributeConstraints
{
    /// <summary>Maximum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>Minimum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderSchemaStringAttributeConstraints
{
    /// <summary>Maximum length of an attribute value of the string type.</summary>
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    /// <summary>Minimum length of an attribute value of the string type.</summary>
    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderSchema
{
    /// <summary>Attribute data type. Must be one of Boolean, Number, String, DateTime.</summary>
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    /// <summary>Whether the attribute type is developer only.</summary>
    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    /// <summary>Whether the attribute can be changed once it has been created.</summary>
    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public IList<V1beta1UserPoolSpecInitProviderSchemaNumberAttributeConstraints>? NumberAttributeConstraints { get; set; }

    /// <summary>Whether a user pool attribute is required. If the attribute is required and the user does not provide a value, registration or sign-in will fail.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public IList<V1beta1UserPoolSpecInitProviderSchemaStringAttributeConstraints>? StringAttributeConstraints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderSmsConfiguration
{
    /// <summary>External ID used in IAM role trust relationships. For more information about using external IDs, see How to Use an External ID When Granting Access to Your AWS Resources to a Third Party.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of the Amazon SNS caller. This is usually the IAM role that you've given Cognito permission to assume.</summary>
    [JsonPropertyName("snsCallerArn")]
    public string? SnsCallerArn { get; set; }

    /// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnRef")]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRef? SnsCallerArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnSelector")]
    public V1beta1UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelector? SnsCallerArnSelector { get; set; }

    /// <summary>The AWS Region to use with Amazon SNS integration. You can choose the same Region as your user pool, or a supported Legacy Amazon SNS alternate Region. Amazon Cognito resources in the Asia Pacific (Seoul) AWS Region must use your Amazon SNS configuration in the Asia Pacific (Tokyo) Region. For more information, see SMS message settings for Amazon Cognito user pools.</summary>
    [JsonPropertyName("snsRegion")]
    public string? SnsRegion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderSoftwareTokenMfaConfiguration
{
    /// <summary>Boolean whether to enable software token Multi-Factor (MFA) tokens, such as Time-based One-Time Password (TOTP). To disable software token MFA When sms_configuration is not present, the mfa_configuration argument must be set to OFF and the software_token_mfa_configuration configuration block must be fully removed.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderUserAttributeUpdateSettings
{
    /// <summary>A list of attributes requiring verification before update. If set, the provided value(s) must also be set in auto_verified_attributes. Valid values: email, phone_number.</summary>
    [JsonPropertyName("attributesRequireVerificationBeforeUpdate")]
    public IList<string>? AttributesRequireVerificationBeforeUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderUserPoolAddOns
{
    /// <summary>Mode for advanced security, must be one of OFF, AUDIT or ENFORCED.</summary>
    [JsonPropertyName("advancedSecurityMode")]
    public string? AdvancedSecurityMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderUsernameConfiguration
{
    /// <summary>Whether username case sensitivity will be applied for all users in the user pool through Cognito APIs.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProviderVerificationMessageTemplate
{
    /// <summary>Default email option. Must be either CONFIRM_WITH_CODE or CONFIRM_WITH_LINK. Defaults to CONFIRM_WITH_CODE.</summary>
    [JsonPropertyName("defaultEmailOption")]
    public string? DefaultEmailOption { get; set; }

    /// <summary>Email message template. Must contain the {####} placeholder. Conflicts with email_verification_message argument.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Email message template for sending a confirmation link to the user, it must contain the {##Click Here##} placeholder.</summary>
    [JsonPropertyName("emailMessageByLink")]
    public string? EmailMessageByLink { get; set; }

    /// <summary>Subject line for the email message template. Conflicts with email_verification_subject argument.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Subject line for the email message template for sending a confirmation link to the user.</summary>
    [JsonPropertyName("emailSubjectByLink")]
    public string? EmailSubjectByLink { get; set; }

    /// <summary>SMS message template. Must contain the {####} placeholder. Conflicts with sms_verification_message argument.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecInitProvider
{
    /// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
    [JsonPropertyName("accountRecoverySetting")]
    public IList<V1beta1UserPoolSpecInitProviderAccountRecoverySetting>? AccountRecoverySetting { get; set; }

    /// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
    [JsonPropertyName("adminCreateUserConfig")]
    public IList<V1beta1UserPoolSpecInitProviderAdminCreateUserConfig>? AdminCreateUserConfig { get; set; }

    /// <summary>Attributes supported as an alias for this user pool. Valid values: phone_number, email, or preferred_username. Conflicts with username_attributes.</summary>
    [JsonPropertyName("aliasAttributes")]
    public IList<string>? AliasAttributes { get; set; }

    /// <summary>Attributes to be auto-verified. Valid values: email, phone_number.</summary>
    [JsonPropertyName("autoVerifiedAttributes")]
    public IList<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>When active, DeletionProtection prevents accidental deletion of your user pool. Before you can delete a user pool that you have protected against deletion, you must deactivate this feature. Valid values are ACTIVE and INACTIVE, Default value is INACTIVE.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>Configuration block for the user pool's device tracking. Detailed below.</summary>
    [JsonPropertyName("deviceConfiguration")]
    public IList<V1beta1UserPoolSpecInitProviderDeviceConfiguration>? DeviceConfiguration { get; set; }

    /// <summary>Configuration block for configuring email. Detailed below.</summary>
    [JsonPropertyName("emailConfiguration")]
    public IList<V1beta1UserPoolSpecInitProviderEmailConfiguration>? EmailConfiguration { get; set; }

    /// <summary>String representing the email verification message. Conflicts with verification_message_template configuration block email_message argument.</summary>
    [JsonPropertyName("emailVerificationMessage")]
    public string? EmailVerificationMessage { get; set; }

    /// <summary>String representing the email verification subject. Conflicts with verification_message_template configuration block email_subject argument.</summary>
    [JsonPropertyName("emailVerificationSubject")]
    public string? EmailVerificationSubject { get; set; }

    /// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1UserPoolSpecInitProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Multi-Factor Authentication (MFA) configuration for the User Pool. Defaults of OFF. Valid values are OFF (MFA Tokens are not required), ON (MFA is required for all users to sign in; requires at least one of sms_configuration or software_token_mfa_configuration to be configured), or OPTIONAL (MFA Will be required only for individual users who have MFA Enabled; requires at least one of sms_configuration or software_token_mfa_configuration to be configured).</summary>
    [JsonPropertyName("mfaConfiguration")]
    public string? MfaConfiguration { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
    [JsonPropertyName("passwordPolicy")]
    public IList<V1beta1UserPoolSpecInitProviderPasswordPolicy>? PasswordPolicy { get; set; }

    /// <summary>Configuration block for the schema attributes of a user pool. Detailed below. Schema attributes from the standard attribute set only need to be specified if they are different from the default configuration. Attributes can be added, but not modified or removed. Maximum of 50 attributes.</summary>
    [JsonPropertyName("schema")]
    public IList<V1beta1UserPoolSpecInitProviderSchema>? Schema { get; set; }

    /// <summary>String representing the SMS authentication message. The Message must contain the {####} placeholder, which will be replaced with the code.</summary>
    [JsonPropertyName("smsAuthenticationMessage")]
    public string? SmsAuthenticationMessage { get; set; }

    /// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
    [JsonPropertyName("smsConfiguration")]
    public IList<V1beta1UserPoolSpecInitProviderSmsConfiguration>? SmsConfiguration { get; set; }

    /// <summary>String representing the SMS verification message. Conflicts with verification_message_template configuration block sms_message argument.</summary>
    [JsonPropertyName("smsVerificationMessage")]
    public string? SmsVerificationMessage { get; set; }

    /// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Detailed below.</summary>
    [JsonPropertyName("softwareTokenMfaConfiguration")]
    public IList<V1beta1UserPoolSpecInitProviderSoftwareTokenMfaConfiguration>? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
    [JsonPropertyName("userAttributeUpdateSettings")]
    public IList<V1beta1UserPoolSpecInitProviderUserAttributeUpdateSettings>? UserAttributeUpdateSettings { get; set; }

    /// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
    [JsonPropertyName("userPoolAddOns")]
    public IList<V1beta1UserPoolSpecInitProviderUserPoolAddOns>? UserPoolAddOns { get; set; }

    /// <summary>Whether email addresses or phone numbers can be specified as usernames when a user signs up. Conflicts with alias_attributes.</summary>
    [JsonPropertyName("usernameAttributes")]
    public IList<string>? UsernameAttributes { get; set; }

    /// <summary>Configuration block for username configuration. Detailed below.</summary>
    [JsonPropertyName("usernameConfiguration")]
    public IList<V1beta1UserPoolSpecInitProviderUsernameConfiguration>? UsernameConfiguration { get; set; }

    /// <summary>Configuration block for verification message templates. Detailed below.</summary>
    [JsonPropertyName("verificationMessageTemplate")]
    public IList<V1beta1UserPoolSpecInitProviderVerificationMessageTemplate>? VerificationMessageTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecManagementPoliciesEnum
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
public enum V1beta1UserPoolSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1UserPoolSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1UserPoolSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1UserPoolSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>UserPoolSpec defines the desired state of UserPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolSpecDeletionPolicyEnum>))]
    public V1beta1UserPoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UserPoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UserPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1UserPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1UserPoolSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderAccountRecoverySettingRecoveryMechanism
{
    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Positive integer specifying priority of a method with 1 being the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderAccountRecoverySetting
{
    /// <summary>List of Account Recovery Options of the following structure:</summary>
    [JsonPropertyName("recoveryMechanism")]
    public IList<V1beta1UserPoolStatusAtProviderAccountRecoverySettingRecoveryMechanism>? RecoveryMechanism { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderAdminCreateUserConfigInviteMessageTemplate
{
    /// <summary>Message template for email messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Subject line for email messages.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Message template for SMS messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderAdminCreateUserConfig
{
    /// <summary>Set to True if only the administrator is allowed to create user profiles. Set to False if users can sign themselves up via an app.</summary>
    [JsonPropertyName("allowAdminCreateUserOnly")]
    public bool? AllowAdminCreateUserOnly { get; set; }

    /// <summary>Invite message template structure. Detailed below.</summary>
    [JsonPropertyName("inviteMessageTemplate")]
    public IList<V1beta1UserPoolStatusAtProviderAdminCreateUserConfigInviteMessageTemplate>? InviteMessageTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderDeviceConfiguration
{
    /// <summary>Whether a challenge is required on a new device. Only applicable to a new device.</summary>
    [JsonPropertyName("challengeRequiredOnNewDevice")]
    public bool? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>Whether a device is only remembered on user prompt. false equates to "Always" remember, true is "User Opt In," and not using a device_configuration block is "No."</summary>
    [JsonPropertyName("deviceOnlyRememberedOnUserPrompt")]
    public bool? DeviceOnlyRememberedOnUserPrompt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderEmailConfiguration
{
    /// <summary>Email configuration set name from SES.</summary>
    [JsonPropertyName("configurationSet")]
    public string? ConfigurationSet { get; set; }

    /// <summary>Email delivery method to use. COGNITO_DEFAULT for the default email functionality built into Cognito or DEVELOPER to use your Amazon SES configuration. Required to be DEVELOPER if from_email_address is set.</summary>
    [JsonPropertyName("emailSendingAccount")]
    public string? EmailSendingAccount { get; set; }

    /// <summary>Sender’s email address or sender’s display name with their email address (e.g., john@example.com, John Smith &lt;john@example.com&gt; or \"John Smith Ph.D.\" &lt;john@example.com&gt;). Escaped double quotes are required around display names that contain certain characters as specified in RFC 5322.</summary>
    [JsonPropertyName("fromEmailAddress")]
    public string? FromEmailAddress { get; set; }

    /// <summary>REPLY-TO email address.</summary>
    [JsonPropertyName("replyToEmailAddress")]
    public string? ReplyToEmailAddress { get; set; }

    /// <summary>ARN of the SES verified email identity to use. Required if email_sending_account is set to DEVELOPER.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderLambdaConfigCustomEmailSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send email notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the "request" attribute in the "event" information Amazon Cognito passes to your custom email Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderLambdaConfigCustomSmsSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the "request" attribute in the "event" information Amazon Cognito passes to your custom SMS Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderLambdaConfigPreTokenGenerationConfig
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the "version" attribute in the "event" information Amazon Cognito passes to your pre Token Generation Lambda function. The supported values are V1_0, V2_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderLambdaConfig
{
    /// <summary>ARN of the lambda creating an authentication challenge.</summary>
    [JsonPropertyName("createAuthChallenge")]
    public string? CreateAuthChallenge { get; set; }

    /// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
    [JsonPropertyName("customEmailSender")]
    public IList<V1beta1UserPoolStatusAtProviderLambdaConfigCustomEmailSender>? CustomEmailSender { get; set; }

    /// <summary>Custom Message AWS Lambda trigger.</summary>
    [JsonPropertyName("customMessage")]
    public string? CustomMessage { get; set; }

    /// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
    [JsonPropertyName("customSmsSender")]
    public IList<V1beta1UserPoolStatusAtProviderLambdaConfigCustomSmsSender>? CustomSmsSender { get; set; }

    /// <summary>Defines the authentication challenge.</summary>
    [JsonPropertyName("defineAuthChallenge")]
    public string? DefineAuthChallenge { get; set; }

    /// <summary>The Amazon Resource Name of Key Management Service Customer master keys. Amazon Cognito uses the key to encrypt codes and temporary passwords sent to CustomEmailSender and CustomSMSSender.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Post-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("postAuthentication")]
    public string? PostAuthentication { get; set; }

    /// <summary>Post-confirmation AWS Lambda trigger.</summary>
    [JsonPropertyName("postConfirmation")]
    public string? PostConfirmation { get; set; }

    /// <summary>Pre-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("preAuthentication")]
    public string? PreAuthentication { get; set; }

    /// <summary>Pre-registration AWS Lambda trigger.</summary>
    [JsonPropertyName("preSignUp")]
    public string? PreSignUp { get; set; }

    /// <summary>Allow to customize identity token claims before token generation. Set this parameter for legacy purposes; for new instances of pre token generation triggers, set the lambda_arn of pre_token_generation_config.</summary>
    [JsonPropertyName("preTokenGeneration")]
    public string? PreTokenGeneration { get; set; }

    /// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
    [JsonPropertyName("preTokenGenerationConfig")]
    public IList<V1beta1UserPoolStatusAtProviderLambdaConfigPreTokenGenerationConfig>? PreTokenGenerationConfig { get; set; }

    /// <summary>User migration Lambda config type.</summary>
    [JsonPropertyName("userMigration")]
    public string? UserMigration { get; set; }

    /// <summary>Verifies the authentication challenge response.</summary>
    [JsonPropertyName("verifyAuthChallengeResponse")]
    public string? VerifyAuthChallengeResponse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderPasswordPolicy
{
    /// <summary>Minimum length of the password policy that you have set.</summary>
    [JsonPropertyName("minimumLength")]
    public double? MinimumLength { get; set; }

    /// <summary>Whether you have required users to use at least one lowercase letter in their password.</summary>
    [JsonPropertyName("requireLowercase")]
    public bool? RequireLowercase { get; set; }

    /// <summary>Whether you have required users to use at least one number in their password.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether you have required users to use at least one symbol in their password.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether you have required users to use at least one uppercase letter in their password.</summary>
    [JsonPropertyName("requireUppercase")]
    public bool? RequireUppercase { get; set; }

    /// <summary>In the password policy you have set, refers to the number of days a temporary password is valid. If the user does not sign-in during this time, their password will need to be reset by an administrator.</summary>
    [JsonPropertyName("temporaryPasswordValidityDays")]
    public double? TemporaryPasswordValidityDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderSchemaNumberAttributeConstraints
{
    /// <summary>Maximum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>Minimum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderSchemaStringAttributeConstraints
{
    /// <summary>Maximum length of an attribute value of the string type.</summary>
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    /// <summary>Minimum length of an attribute value of the string type.</summary>
    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderSchema
{
    /// <summary>Attribute data type. Must be one of Boolean, Number, String, DateTime.</summary>
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    /// <summary>Whether the attribute type is developer only.</summary>
    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    /// <summary>Whether the attribute can be changed once it has been created.</summary>
    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public IList<V1beta1UserPoolStatusAtProviderSchemaNumberAttributeConstraints>? NumberAttributeConstraints { get; set; }

    /// <summary>Whether a user pool attribute is required. If the attribute is required and the user does not provide a value, registration or sign-in will fail.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public IList<V1beta1UserPoolStatusAtProviderSchemaStringAttributeConstraints>? StringAttributeConstraints { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderSmsConfiguration
{
    /// <summary>External ID used in IAM role trust relationships. For more information about using external IDs, see How to Use an External ID When Granting Access to Your AWS Resources to a Third Party.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of the Amazon SNS caller. This is usually the IAM role that you've given Cognito permission to assume.</summary>
    [JsonPropertyName("snsCallerArn")]
    public string? SnsCallerArn { get; set; }

    /// <summary>The AWS Region to use with Amazon SNS integration. You can choose the same Region as your user pool, or a supported Legacy Amazon SNS alternate Region. Amazon Cognito resources in the Asia Pacific (Seoul) AWS Region must use your Amazon SNS configuration in the Asia Pacific (Tokyo) Region. For more information, see SMS message settings for Amazon Cognito user pools.</summary>
    [JsonPropertyName("snsRegion")]
    public string? SnsRegion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderSoftwareTokenMfaConfiguration
{
    /// <summary>Boolean whether to enable software token Multi-Factor (MFA) tokens, such as Time-based One-Time Password (TOTP). To disable software token MFA When sms_configuration is not present, the mfa_configuration argument must be set to OFF and the software_token_mfa_configuration configuration block must be fully removed.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderUserAttributeUpdateSettings
{
    /// <summary>A list of attributes requiring verification before update. If set, the provided value(s) must also be set in auto_verified_attributes. Valid values: email, phone_number.</summary>
    [JsonPropertyName("attributesRequireVerificationBeforeUpdate")]
    public IList<string>? AttributesRequireVerificationBeforeUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderUserPoolAddOns
{
    /// <summary>Mode for advanced security, must be one of OFF, AUDIT or ENFORCED.</summary>
    [JsonPropertyName("advancedSecurityMode")]
    public string? AdvancedSecurityMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderUsernameConfiguration
{
    /// <summary>Whether username case sensitivity will be applied for all users in the user pool through Cognito APIs.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProviderVerificationMessageTemplate
{
    /// <summary>Default email option. Must be either CONFIRM_WITH_CODE or CONFIRM_WITH_LINK. Defaults to CONFIRM_WITH_CODE.</summary>
    [JsonPropertyName("defaultEmailOption")]
    public string? DefaultEmailOption { get; set; }

    /// <summary>Email message template. Must contain the {####} placeholder. Conflicts with email_verification_message argument.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Email message template for sending a confirmation link to the user, it must contain the {##Click Here##} placeholder.</summary>
    [JsonPropertyName("emailMessageByLink")]
    public string? EmailMessageByLink { get; set; }

    /// <summary>Subject line for the email message template. Conflicts with email_verification_subject argument.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Subject line for the email message template for sending a confirmation link to the user.</summary>
    [JsonPropertyName("emailSubjectByLink")]
    public string? EmailSubjectByLink { get; set; }

    /// <summary>SMS message template. Must contain the {####} placeholder. Conflicts with sms_verification_message argument.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusAtProvider
{
    /// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
    [JsonPropertyName("accountRecoverySetting")]
    public IList<V1beta1UserPoolStatusAtProviderAccountRecoverySetting>? AccountRecoverySetting { get; set; }

    /// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
    [JsonPropertyName("adminCreateUserConfig")]
    public IList<V1beta1UserPoolStatusAtProviderAdminCreateUserConfig>? AdminCreateUserConfig { get; set; }

    /// <summary>Attributes supported as an alias for this user pool. Valid values: phone_number, email, or preferred_username. Conflicts with username_attributes.</summary>
    [JsonPropertyName("aliasAttributes")]
    public IList<string>? AliasAttributes { get; set; }

    /// <summary>ARN of the user pool.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Attributes to be auto-verified. Valid values: email, phone_number.</summary>
    [JsonPropertyName("autoVerifiedAttributes")]
    public IList<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>Date the user pool was created.</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>A custom domain name that you provide to Amazon Cognito. This parameter applies only if you use a custom domain to host the sign-up and sign-in pages for your application. For example: auth.example.com.</summary>
    [JsonPropertyName("customDomain")]
    public string? CustomDomain { get; set; }

    /// <summary>When active, DeletionProtection prevents accidental deletion of your user pool. Before you can delete a user pool that you have protected against deletion, you must deactivate this feature. Valid values are ACTIVE and INACTIVE, Default value is INACTIVE.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>Configuration block for the user pool's device tracking. Detailed below.</summary>
    [JsonPropertyName("deviceConfiguration")]
    public IList<V1beta1UserPoolStatusAtProviderDeviceConfiguration>? DeviceConfiguration { get; set; }

    /// <summary>Holds the domain prefix if the user pool has a domain associated with it.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Configuration block for configuring email. Detailed below.</summary>
    [JsonPropertyName("emailConfiguration")]
    public IList<V1beta1UserPoolStatusAtProviderEmailConfiguration>? EmailConfiguration { get; set; }

    /// <summary>String representing the email verification message. Conflicts with verification_message_template configuration block email_message argument.</summary>
    [JsonPropertyName("emailVerificationMessage")]
    public string? EmailVerificationMessage { get; set; }

    /// <summary>String representing the email verification subject. Conflicts with verification_message_template configuration block email_subject argument.</summary>
    [JsonPropertyName("emailVerificationSubject")]
    public string? EmailVerificationSubject { get; set; }

    /// <summary>Endpoint name of the user pool. Example format: cognito-idp.REGION.amazonaws.com/xxxx_yyyyy</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>A number estimating the size of the user pool.</summary>
    [JsonPropertyName("estimatedNumberOfUsers")]
    public double? EstimatedNumberOfUsers { get; set; }

    /// <summary>ID of the user pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public IList<V1beta1UserPoolStatusAtProviderLambdaConfig>? LambdaConfig { get; set; }

    /// <summary>Date the user pool was last modified.</summary>
    [JsonPropertyName("lastModifiedDate")]
    public string? LastModifiedDate { get; set; }

    /// <summary>Multi-Factor Authentication (MFA) configuration for the User Pool. Defaults of OFF. Valid values are OFF (MFA Tokens are not required), ON (MFA is required for all users to sign in; requires at least one of sms_configuration or software_token_mfa_configuration to be configured), or OPTIONAL (MFA Will be required only for individual users who have MFA Enabled; requires at least one of sms_configuration or software_token_mfa_configuration to be configured).</summary>
    [JsonPropertyName("mfaConfiguration")]
    public string? MfaConfiguration { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
    [JsonPropertyName("passwordPolicy")]
    public IList<V1beta1UserPoolStatusAtProviderPasswordPolicy>? PasswordPolicy { get; set; }

    /// <summary>Configuration block for the schema attributes of a user pool. Detailed below. Schema attributes from the standard attribute set only need to be specified if they are different from the default configuration. Attributes can be added, but not modified or removed. Maximum of 50 attributes.</summary>
    [JsonPropertyName("schema")]
    public IList<V1beta1UserPoolStatusAtProviderSchema>? Schema { get; set; }

    /// <summary>String representing the SMS authentication message. The Message must contain the {####} placeholder, which will be replaced with the code.</summary>
    [JsonPropertyName("smsAuthenticationMessage")]
    public string? SmsAuthenticationMessage { get; set; }

    /// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
    [JsonPropertyName("smsConfiguration")]
    public IList<V1beta1UserPoolStatusAtProviderSmsConfiguration>? SmsConfiguration { get; set; }

    /// <summary>String representing the SMS verification message. Conflicts with verification_message_template configuration block sms_message argument.</summary>
    [JsonPropertyName("smsVerificationMessage")]
    public string? SmsVerificationMessage { get; set; }

    /// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Detailed below.</summary>
    [JsonPropertyName("softwareTokenMfaConfiguration")]
    public IList<V1beta1UserPoolStatusAtProviderSoftwareTokenMfaConfiguration>? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
    [JsonPropertyName("userAttributeUpdateSettings")]
    public IList<V1beta1UserPoolStatusAtProviderUserAttributeUpdateSettings>? UserAttributeUpdateSettings { get; set; }

    /// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
    [JsonPropertyName("userPoolAddOns")]
    public IList<V1beta1UserPoolStatusAtProviderUserPoolAddOns>? UserPoolAddOns { get; set; }

    /// <summary>Whether email addresses or phone numbers can be specified as usernames when a user signs up. Conflicts with alias_attributes.</summary>
    [JsonPropertyName("usernameAttributes")]
    public IList<string>? UsernameAttributes { get; set; }

    /// <summary>Configuration block for username configuration. Detailed below.</summary>
    [JsonPropertyName("usernameConfiguration")]
    public IList<V1beta1UserPoolStatusAtProviderUsernameConfiguration>? UsernameConfiguration { get; set; }

    /// <summary>Configuration block for verification message templates. Detailed below.</summary>
    [JsonPropertyName("verificationMessageTemplate")]
    public IList<V1beta1UserPoolStatusAtProviderVerificationMessageTemplate>? VerificationMessageTemplate { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatusConditions
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

/// <summary>UserPoolStatus defines the observed state of UserPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserPoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UserPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserPoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>UserPool is the Schema for the UserPools API. Provides a Cognito User Pool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserPoolSpec>, IStatus<V1beta1UserPoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserPool";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "userpools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserPoolSpec defines the desired state of UserPool</summary>
    [JsonPropertyName("spec")]
    public V1beta1UserPoolSpec Spec { get; set; }

    /// <summary>UserPoolStatus defines the observed state of UserPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserPoolStatus? Status { get; set; }
}