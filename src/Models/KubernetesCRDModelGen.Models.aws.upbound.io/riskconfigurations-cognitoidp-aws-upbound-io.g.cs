using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidp.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsHighAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsLowAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsMediumAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActions
{
    /// <summary>Action to take for a high risk. See action block below.</summary>
    [JsonPropertyName("highAction")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsHighAction>? HighAction { get; set; }

    /// <summary>Action to take for a low risk. See action block below.</summary>
    [JsonPropertyName("lowAction")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsLowAction>? LowAction { get; set; }

    /// <summary>Action to take for a medium risk. See action block below.</summary>
    [JsonPropertyName("mediumAction")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsMediumAction>? MediumAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfiguration
{
    /// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
    [JsonPropertyName("blockEmail")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail>? BlockEmail { get; set; }

    /// <summary>The email address that is sending the email. The address must be either individually verified with Amazon Simple Email Service, or from a domain that has been verified with Amazon SES.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
    [JsonPropertyName("mfaEmail")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail>? MfaEmail { get; set; }

    /// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
    [JsonPropertyName("noActionEmail")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail>? NoActionEmail { get; set; }

    /// <summary>The destination to which the receiver of an email should reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the identity that is associated with the sending authorization policy. This identity permits Amazon Cognito to send for the email address specified in the From parameter.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfiguration
{
    /// <summary>Account takeover risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActions>? Actions { get; set; }

    /// <summary>The notify configuration used to construct email notifications. See details below.</summary>
    [JsonPropertyName("notifyConfiguration")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfiguration>? NotifyConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfigurationActions
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfiguration
{
    /// <summary>The compromised credentials risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfigurationActions>? Actions { get; set; }

    /// <summary>Perform the action for these events. The default is to perform all events if no event filter is specified. Valid values are SIGN_IN, PASSWORD_CHANGE, and SIGN_UP.</summary>
    [JsonPropertyName("eventFilter")]
    public IList<string>? EventFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderRiskExceptionConfiguration
{
    /// <summary>Overrides the risk decision to always block the pre-authentication requests. The IP range is in CIDR notation, a compact representation of an IP address and its routing prefix. Can contain a maximum of 200 items.</summary>
    [JsonPropertyName("blockedIpRangeList")]
    public IList<string>? BlockedIpRangeList { get; set; }

    /// <summary>Risk detection isn't performed on the IP addresses in this range list. The IP range is in CIDR notation. Can contain a maximum of 200 items.</summary>
    [JsonPropertyName("skippedIpRangeList")]
    public IList<string>? SkippedIpRangeList { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RiskConfigurationSpecForProviderUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProviderUserPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RiskConfigurationSpecForProviderUserPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecForProvider
{
    /// <summary>The account takeover risk configuration. See details below.</summary>
    [JsonPropertyName("accountTakeoverRiskConfiguration")]
    public IList<V1beta1RiskConfigurationSpecForProviderAccountTakeoverRiskConfiguration>? AccountTakeoverRiskConfiguration { get; set; }

    /// <summary>The app client ID. When the client ID is not provided, the same risk configuration is applied to all the clients in the User Pool.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The compromised credentials risk configuration. See details below.</summary>
    [JsonPropertyName("compromisedCredentialsRiskConfiguration")]
    public IList<V1beta1RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfiguration>? CompromisedCredentialsRiskConfiguration { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The configuration to override the risk decision. See details below.</summary>
    [JsonPropertyName("riskExceptionConfiguration")]
    public IList<V1beta1RiskConfigurationSpecForProviderRiskExceptionConfiguration>? RiskExceptionConfiguration { get; set; }

    /// <summary>The user pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1RiskConfigurationSpecForProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1RiskConfigurationSpecForProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsHighAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsLowAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsMediumAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActions
{
    /// <summary>Action to take for a high risk. See action block below.</summary>
    [JsonPropertyName("highAction")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsHighAction>? HighAction { get; set; }

    /// <summary>Action to take for a low risk. See action block below.</summary>
    [JsonPropertyName("lowAction")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsLowAction>? LowAction { get; set; }

    /// <summary>Action to take for a medium risk. See action block below.</summary>
    [JsonPropertyName("mediumAction")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsMediumAction>? MediumAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfiguration
{
    /// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
    [JsonPropertyName("blockEmail")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail>? BlockEmail { get; set; }

    /// <summary>The email address that is sending the email. The address must be either individually verified with Amazon Simple Email Service, or from a domain that has been verified with Amazon SES.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
    [JsonPropertyName("mfaEmail")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail>? MfaEmail { get; set; }

    /// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
    [JsonPropertyName("noActionEmail")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail>? NoActionEmail { get; set; }

    /// <summary>The destination to which the receiver of an email should reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the identity that is associated with the sending authorization policy. This identity permits Amazon Cognito to send for the email address specified in the From parameter.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfiguration
{
    /// <summary>Account takeover risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActions>? Actions { get; set; }

    /// <summary>The notify configuration used to construct email notifications. See details below.</summary>
    [JsonPropertyName("notifyConfiguration")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfiguration>? NotifyConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfigurationActions
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfiguration
{
    /// <summary>The compromised credentials risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfigurationActions>? Actions { get; set; }

    /// <summary>Perform the action for these events. The default is to perform all events if no event filter is specified. Valid values are SIGN_IN, PASSWORD_CHANGE, and SIGN_UP.</summary>
    [JsonPropertyName("eventFilter")]
    public IList<string>? EventFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderRiskExceptionConfiguration
{
    /// <summary>Overrides the risk decision to always block the pre-authentication requests. The IP range is in CIDR notation, a compact representation of an IP address and its routing prefix. Can contain a maximum of 200 items.</summary>
    [JsonPropertyName("blockedIpRangeList")]
    public IList<string>? BlockedIpRangeList { get; set; }

    /// <summary>Risk detection isn't performed on the IP addresses in this range list. The IP range is in CIDR notation. Can contain a maximum of 200 items.</summary>
    [JsonPropertyName("skippedIpRangeList")]
    public IList<string>? SkippedIpRangeList { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RiskConfigurationSpecInitProviderUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProviderUserPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecInitProvider
{
    /// <summary>The account takeover risk configuration. See details below.</summary>
    [JsonPropertyName("accountTakeoverRiskConfiguration")]
    public IList<V1beta1RiskConfigurationSpecInitProviderAccountTakeoverRiskConfiguration>? AccountTakeoverRiskConfiguration { get; set; }

    /// <summary>The app client ID. When the client ID is not provided, the same risk configuration is applied to all the clients in the User Pool.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The compromised credentials risk configuration. See details below.</summary>
    [JsonPropertyName("compromisedCredentialsRiskConfiguration")]
    public IList<V1beta1RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfiguration>? CompromisedCredentialsRiskConfiguration { get; set; }

    /// <summary>The configuration to override the risk decision. See details below.</summary>
    [JsonPropertyName("riskExceptionConfiguration")]
    public IList<V1beta1RiskConfigurationSpecInitProviderRiskExceptionConfiguration>? RiskExceptionConfiguration { get; set; }

    /// <summary>The user pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1RiskConfigurationSpecInitProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1RiskConfigurationSpecInitProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RiskConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RiskConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RiskConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RiskConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RiskConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RiskConfigurationSpec defines the desired state of RiskConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RiskConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RiskConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RiskConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RiskConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RiskConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsHighAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsLowAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsMediumAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActions
{
    /// <summary>Action to take for a high risk. See action block below.</summary>
    [JsonPropertyName("highAction")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsHighAction>? HighAction { get; set; }

    /// <summary>Action to take for a low risk. See action block below.</summary>
    [JsonPropertyName("lowAction")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsLowAction>? LowAction { get; set; }

    /// <summary>Action to take for a medium risk. See action block below.</summary>
    [JsonPropertyName("mediumAction")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsMediumAction>? MediumAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfiguration
{
    /// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
    [JsonPropertyName("blockEmail")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail>? BlockEmail { get; set; }

    /// <summary>The email address that is sending the email. The address must be either individually verified with Amazon Simple Email Service, or from a domain that has been verified with Amazon SES.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
    [JsonPropertyName("mfaEmail")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail>? MfaEmail { get; set; }

    /// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
    [JsonPropertyName("noActionEmail")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail>? NoActionEmail { get; set; }

    /// <summary>The destination to which the receiver of an email should reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the identity that is associated with the sending authorization policy. This identity permits Amazon Cognito to send for the email address specified in the From parameter.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfiguration
{
    /// <summary>Account takeover risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActions>? Actions { get; set; }

    /// <summary>The notify configuration used to construct email notifications. See details below.</summary>
    [JsonPropertyName("notifyConfiguration")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfiguration>? NotifyConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfigurationActions
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfiguration
{
    /// <summary>The compromised credentials risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public IList<V1beta1RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfigurationActions>? Actions { get; set; }

    /// <summary>Perform the action for these events. The default is to perform all events if no event filter is specified. Valid values are SIGN_IN, PASSWORD_CHANGE, and SIGN_UP.</summary>
    [JsonPropertyName("eventFilter")]
    public IList<string>? EventFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProviderRiskExceptionConfiguration
{
    /// <summary>Overrides the risk decision to always block the pre-authentication requests. The IP range is in CIDR notation, a compact representation of an IP address and its routing prefix. Can contain a maximum of 200 items.</summary>
    [JsonPropertyName("blockedIpRangeList")]
    public IList<string>? BlockedIpRangeList { get; set; }

    /// <summary>Risk detection isn't performed on the IP addresses in this range list. The IP range is in CIDR notation. Can contain a maximum of 200 items.</summary>
    [JsonPropertyName("skippedIpRangeList")]
    public IList<string>? SkippedIpRangeList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusAtProvider
{
    /// <summary>The account takeover risk configuration. See details below.</summary>
    [JsonPropertyName("accountTakeoverRiskConfiguration")]
    public IList<V1beta1RiskConfigurationStatusAtProviderAccountTakeoverRiskConfiguration>? AccountTakeoverRiskConfiguration { get; set; }

    /// <summary>The app client ID. When the client ID is not provided, the same risk configuration is applied to all the clients in the User Pool.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The compromised credentials risk configuration. See details below.</summary>
    [JsonPropertyName("compromisedCredentialsRiskConfiguration")]
    public IList<V1beta1RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfiguration>? CompromisedCredentialsRiskConfiguration { get; set; }

    /// <summary>The user pool ID or the user pool ID and Client Id separated by a : if the configuration is client specific.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The configuration to override the risk decision. See details below.</summary>
    [JsonPropertyName("riskExceptionConfiguration")]
    public IList<V1beta1RiskConfigurationStatusAtProviderRiskExceptionConfiguration>? RiskExceptionConfiguration { get; set; }

    /// <summary>The user pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatusConditions
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

/// <summary>RiskConfigurationStatus defines the observed state of RiskConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RiskConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RiskConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RiskConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RiskConfiguration is the Schema for the RiskConfigurations API. Provides a Cognito Risk Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RiskConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RiskConfigurationSpec>, IStatus<V1beta1RiskConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RiskConfiguration";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "riskconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RiskConfigurationSpec defines the desired state of RiskConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1RiskConfigurationSpec Spec { get; set; }

    /// <summary>RiskConfigurationStatus defines the observed state of RiskConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1RiskConfigurationStatus? Status { get; set; }
}

/// <summary>RiskConfiguration is the Schema for the RiskConfigurations API. Provides a Cognito Risk Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RiskConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RiskConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RiskConfigurationList";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "riskconfigurations";
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
    public IList<V1beta1RiskConfiguration> Items { get; set; }
}