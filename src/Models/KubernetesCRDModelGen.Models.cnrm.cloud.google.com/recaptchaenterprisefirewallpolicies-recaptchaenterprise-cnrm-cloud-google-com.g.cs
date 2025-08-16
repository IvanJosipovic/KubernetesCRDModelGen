using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recaptchaenterprise.cnrm.cloud.google.com;
/// <summary>ReCAPTCHAEnterpriseFirewallPolicy is the Schema for the ReCAPTCHAEnterpriseFirewallPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ReCAPTCHAEnterpriseFirewallPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ReCAPTCHAEnterpriseFirewallPolicyList";
    public const string KubeGroup = "recaptchaenterprise.cnrm.cloud.google.com";
    public const string KubePluralName = "recaptchaenterprisefirewallpolicies";
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
    public IList<V1alpha1ReCAPTCHAEnterpriseFirewallPolicy> Items { get; set; }
}

/// <summary>The user request did not match any policy and should be allowed access to the requested resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsAllow
{
}

/// <summary>This action denies access to a given page. The user gets an HTTP error code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsBlock
{
}

/// <summary>This action injects reCAPTCHA JavaScript code into the HTML page returned by the site backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsIncludeRecaptchaScript
{
}

/// <summary>This action redirects the request to a reCAPTCHA interstitial to attach a token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsRedirect
{
}

/// <summary>This action sets a custom header but allow the request to continue to the customer backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsSetHeader
{
    /// <summary>Optional. The header key to set in the request to the backend server.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Optional. The header value to set in the request to the backend server.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>This action transparently serves a different page to an offending user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsSubstitute
{
    /// <summary>Optional. The address to redirect to. The target is a relative path in the current host. Example: "/blog/404.html".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActions
{
    /// <summary>The user request did not match any policy and should be allowed access to the requested resource.</summary>
    [JsonPropertyName("allow")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsAllow? Allow { get; set; }

    /// <summary>This action denies access to a given page. The user gets an HTTP error code.</summary>
    [JsonPropertyName("block")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsBlock? Block { get; set; }

    /// <summary>This action injects reCAPTCHA JavaScript code into the HTML page returned by the site backend.</summary>
    [JsonPropertyName("includeRecaptchaScript")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsIncludeRecaptchaScript? IncludeRecaptchaScript { get; set; }

    /// <summary>This action redirects the request to a reCAPTCHA interstitial to attach a token.</summary>
    [JsonPropertyName("redirect")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsRedirect? Redirect { get; set; }

    /// <summary>This action sets a custom header but allow the request to continue to the customer backend.</summary>
    [JsonPropertyName("setHeader")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsSetHeader? SetHeader { get; set; }

    /// <summary>This action transparently serves a different page to an offending user.</summary>
    [JsonPropertyName("substitute")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActionsSubstitute? Substitute { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ReCAPTCHAEnterpriseFirewallPolicySpec defines the desired state of ReCAPTCHAEnterpriseFirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpec
{
    /// <summary>Optional. The actions that the caller should take regarding user access. There should be at most one terminal action. A terminal action is any action that forces a response, such as `AllowAction`, `BlockAction` or `SubstituteAction`. Zero or more non-terminal actions such as `SetHeader` might be specified. A single policy can contain up to 16 actions.</summary>
    [JsonPropertyName("actions")]
    public IList<V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecActions>? Actions { get; set; }

    /// <summary>Optional. A CEL (Common Expression Language) conditional expression that specifies if this policy applies to an incoming user request. If this condition evaluates to true and the requested path matched the path pattern, the associated actions should be executed by the caller. The condition string is checked for CEL syntax correctness on creation. For more information, see the [CEL spec](https://github.com/google/cel-spec) and its [language definition](https://github.com/google/cel-spec/blob/master/doc/langdef.md). A condition has a max length of 500 characters.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Optional. A description of what this policy aims to achieve, for convenience purposes. The description can at most include 256 UTF-8 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The path for which this policy applies, specified as a glob pattern. For more information on glob, see the [manual page](https://man7.org/linux/man-pages/man7/glob.7.html). A path has a max length of 200 characters.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The ReCAPTCHAEnterpriseFirewallPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicyStatusConditions
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

/// <summary>ReCAPTCHAEnterpriseFirewallPolicyStatus defines the config connector machine state of ReCAPTCHAEnterpriseFirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ReCAPTCHAEnterpriseFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ReCAPTCHAEnterpriseFirewallPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ReCAPTCHAEnterpriseFirewallPolicy is the Schema for the ReCAPTCHAEnterpriseFirewallPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ReCAPTCHAEnterpriseFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpec>, IStatus<V1alpha1ReCAPTCHAEnterpriseFirewallPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ReCAPTCHAEnterpriseFirewallPolicy";
    public const string KubeGroup = "recaptchaenterprise.cnrm.cloud.google.com";
    public const string KubePluralName = "recaptchaenterprisefirewallpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReCAPTCHAEnterpriseFirewallPolicySpec defines the desired state of ReCAPTCHAEnterpriseFirewallPolicy</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicySpec Spec { get; set; }

    /// <summary>ReCAPTCHAEnterpriseFirewallPolicyStatus defines the config connector machine state of ReCAPTCHAEnterpriseFirewallPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1ReCAPTCHAEnterpriseFirewallPolicyStatus? Status { get; set; }
}