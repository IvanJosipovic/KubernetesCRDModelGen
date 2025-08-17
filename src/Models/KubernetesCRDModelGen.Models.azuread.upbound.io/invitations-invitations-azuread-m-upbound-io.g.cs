using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.invitations.azuread.m.upbound.io;
#nullable enable
/// <summary>Invitation is the Schema for the Invitations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InvitationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Invitation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InvitationList";
    public const string KubeGroup = "invitations.azuread.m.upbound.io";
    public const string KubePluralName = "invitations";
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
    public IList<V1beta1Invitation> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A message block as documented below, which configures the message being sent to the invited user. If this block is omitted, no message will be sent. Customize the message sent to the invited user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationSpecForProviderMessage
{
    /// <summary>Email addresses of additional recipients the invitation message should be sent to. Only 1 additional recipient is currently supported by Azure. Email addresses of additional recipients the invitation message should be sent to</summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>Customized message body you want to send if you don't want to send the default message. Cannot be specified with language. Customized message body you want to send if you don't want to send the default message</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>The language you want to send the default message in. The value specified must be in ISO 639 format. Defaults to en-US. Cannot be specified with body. The language you want to send the default message in</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationSpecForProvider
{
    /// <summary>A message block as documented below, which configures the message being sent to the invited user. If this block is omitted, no message will be sent. Customize the message sent to the invited user</summary>
    [JsonPropertyName("message")]
    public V1beta1InvitationSpecForProviderMessage? Message { get; set; }

    /// <summary>The URL that the user should be redirected to once the invitation is redeemed. The URL that the user should be redirected to once the invitation is redeemed</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>The display name of the user being invited. The display name of the user being invited</summary>
    [JsonPropertyName("userDisplayName")]
    public string? UserDisplayName { get; set; }

    /// <summary>The email address of the user being invited. The email address of the user being invited</summary>
    [JsonPropertyName("userEmailAddress")]
    public string? UserEmailAddress { get; set; }

    /// <summary>The user type of the user being invited. Must be one of Guest or Member. Only Global Administrators can invite users as members. Defaults to Guest. The user type of the user being invited</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A message block as documented below, which configures the message being sent to the invited user. If this block is omitted, no message will be sent. Customize the message sent to the invited user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationSpecInitProviderMessage
{
    /// <summary>Email addresses of additional recipients the invitation message should be sent to. Only 1 additional recipient is currently supported by Azure. Email addresses of additional recipients the invitation message should be sent to</summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>Customized message body you want to send if you don't want to send the default message. Cannot be specified with language. Customized message body you want to send if you don't want to send the default message</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>The language you want to send the default message in. The value specified must be in ISO 639 format. Defaults to en-US. Cannot be specified with body. The language you want to send the default message in</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationSpecInitProvider
{
    /// <summary>A message block as documented below, which configures the message being sent to the invited user. If this block is omitted, no message will be sent. Customize the message sent to the invited user</summary>
    [JsonPropertyName("message")]
    public V1beta1InvitationSpecInitProviderMessage? Message { get; set; }

    /// <summary>The URL that the user should be redirected to once the invitation is redeemed. The URL that the user should be redirected to once the invitation is redeemed</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>The display name of the user being invited. The display name of the user being invited</summary>
    [JsonPropertyName("userDisplayName")]
    public string? UserDisplayName { get; set; }

    /// <summary>The email address of the user being invited. The email address of the user being invited</summary>
    [JsonPropertyName("userEmailAddress")]
    public string? UserEmailAddress { get; set; }

    /// <summary>The user type of the user being invited. Must be one of Guest or Member. Only Global Administrators can invite users as members. Defaults to Guest. The user type of the user being invited</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InvitationSpec defines the desired state of Invitation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InvitationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InvitationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InvitationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InvitationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A message block as documented below, which configures the message being sent to the invited user. If this block is omitted, no message will be sent. Customize the message sent to the invited user</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationStatusAtProviderMessage
{
    /// <summary>Email addresses of additional recipients the invitation message should be sent to. Only 1 additional recipient is currently supported by Azure. Email addresses of additional recipients the invitation message should be sent to</summary>
    [JsonPropertyName("additionalRecipients")]
    public IList<string>? AdditionalRecipients { get; set; }

    /// <summary>Customized message body you want to send if you don't want to send the default message. Cannot be specified with language. Customized message body you want to send if you don't want to send the default message</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>The language you want to send the default message in. The value specified must be in ISO 639 format. Defaults to en-US. Cannot be specified with body. The language you want to send the default message in</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A message block as documented below, which configures the message being sent to the invited user. If this block is omitted, no message will be sent. Customize the message sent to the invited user</summary>
    [JsonPropertyName("message")]
    public V1beta1InvitationStatusAtProviderMessage? Message { get; set; }

    /// <summary>The URL the user can use to redeem their invitation. The URL the user can use to redeem their invitation</summary>
    [JsonPropertyName("redeemUrl")]
    public string? RedeemUrl { get; set; }

    /// <summary>The URL that the user should be redirected to once the invitation is redeemed. The URL that the user should be redirected to once the invitation is redeemed</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>The display name of the user being invited. The display name of the user being invited</summary>
    [JsonPropertyName("userDisplayName")]
    public string? UserDisplayName { get; set; }

    /// <summary>The email address of the user being invited. The email address of the user being invited</summary>
    [JsonPropertyName("userEmailAddress")]
    public string? UserEmailAddress { get; set; }

    /// <summary>Object ID of the invited user. Object ID of the invited user</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>The user type of the user being invited. Must be one of Guest or Member. Only Global Administrators can invite users as members. Defaults to Guest. The user type of the user being invited</summary>
    [JsonPropertyName("userType")]
    public string? UserType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationStatusConditions
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
#nullable disable

#nullable enable
/// <summary>InvitationStatus defines the observed state of Invitation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InvitationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InvitationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InvitationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Invitation is the Schema for the Invitations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Invitation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InvitationSpec>, IStatus<V1beta1InvitationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Invitation";
    public const string KubeGroup = "invitations.azuread.m.upbound.io";
    public const string KubePluralName = "invitations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InvitationSpec defines the desired state of Invitation</summary>
    [JsonPropertyName("spec")]
    public V1beta1InvitationSpec Spec { get; set; }

    /// <summary>InvitationStatus defines the observed state of Invitation.</summary>
    [JsonPropertyName("status")]
    public V1beta1InvitationStatus? Status { get; set; }
}
#nullable disable
