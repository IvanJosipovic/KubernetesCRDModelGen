using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.image.toolkit.fluxcd.io;
#nullable enable
/// <summary>ImageUpdateAutomation is the Schema for the imageupdateautomations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImageUpdateAutomationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ImageUpdateAutomation>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImageUpdateAutomationList";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imageupdateautomations";
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
    public IList<V1beta2ImageUpdateAutomation> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference gives a branch, tag or commit to clone from the Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGitCheckoutRef
{
    /// <summary>Branch to check out, defaults to 'master' if no other field is defined.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Commit SHA to check out, takes precedence over all reference fields.  This can be combined with Branch to shallow clone the branch, in which the commit is expected to exist.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Name of the reference to check out; takes precedence over Branch, Tag and SemVer.  It must be a valid Git reference: https://git-scm.com/docs/git-check-ref-format#_description Examples: "refs/heads/main", "refs/tags/v0.1.0", "refs/pull/420/head", "refs/merge-requests/1/head"</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SemVer tag expression to check out, takes precedence over Tag.</summary>
    [JsonPropertyName("semver")]
    public string? Semver { get; set; }

    /// <summary>Tag to check out, takes precedence over Branch.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Checkout gives the parameters for cloning the git repository, ready to make changes. If not present, the `spec.ref` field from the referenced `GitRepository` or its default will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGitCheckout
{
    /// <summary>Reference gives a branch, tag or commit to clone from the Git repository.</summary>
    [JsonPropertyName("ref")]
    public V1beta2ImageUpdateAutomationSpecGitCheckoutRef Ref { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Author gives the email and optionally the name to use as the author of commits.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGitCommitAuthor
{
    /// <summary>Email gives the email to provide when making a commit.</summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>Name gives the name to provide when making a commit.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretRef holds the name to a secret that contains a 'git.asc' key corresponding to the ASCII Armored file containing the GPG signing keypair as the value. It must be in the same namespace as the ImageUpdateAutomation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGitCommitSigningKeySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SigningKey provides the option to sign commits with a GPG key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGitCommitSigningKey
{
    /// <summary>SecretRef holds the name to a secret that contains a 'git.asc' key corresponding to the ASCII Armored file containing the GPG signing keypair as the value. It must be in the same namespace as the ImageUpdateAutomation.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2ImageUpdateAutomationSpecGitCommitSigningKeySecretRef SecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Commit specifies how to commit to the git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGitCommit
{
    /// <summary>Author gives the email and optionally the name to use as the author of commits.</summary>
    [JsonPropertyName("author")]
    public V1beta2ImageUpdateAutomationSpecGitCommitAuthor Author { get; set; }

    /// <summary>MessageTemplate provides a template for the commit message, into which will be interpolated the details of the change made.</summary>
    [JsonPropertyName("messageTemplate")]
    public string? MessageTemplate { get; set; }

    /// <summary>MessageTemplateValues provides additional values to be available to the templating rendering.</summary>
    [JsonPropertyName("messageTemplateValues")]
    public IDictionary<string, string>? MessageTemplateValues { get; set; }

    /// <summary>SigningKey provides the option to sign commits with a GPG key</summary>
    [JsonPropertyName("signingKey")]
    public V1beta2ImageUpdateAutomationSpecGitCommitSigningKey? SigningKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Push specifies how and where to push commits made by the automation. If missing, commits are pushed (back) to `.spec.checkout.branch` or its default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGitPush
{
    /// <summary>Branch specifies that commits should be pushed to the branch named. The branch is created using `.spec.checkout.branch` as the starting point, if it doesn't already exist.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Options specifies the push options that are sent to the Git server when performing a push operation. For details, see: https://git-scm.com/docs/git-push#Documentation/git-push.txt---push-optionltoptiongt</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>Refspec specifies the Git Refspec to use for a push operation. If both Branch and Refspec are provided, then the commit is pushed to the branch and also using the specified refspec. For more details about Git Refspecs, see: https://git-scm.com/book/en/v2/Git-Internals-The-Refspec</summary>
    [JsonPropertyName("refspec")]
    public string? Refspec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GitSpec contains all the git-specific definitions. This is technically optional, but in practice mandatory until there are other kinds of source allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecGit
{
    /// <summary>Checkout gives the parameters for cloning the git repository, ready to make changes. If not present, the `spec.ref` field from the referenced `GitRepository` or its default will be used.</summary>
    [JsonPropertyName("checkout")]
    public V1beta2ImageUpdateAutomationSpecGitCheckout? Checkout { get; set; }

    /// <summary>Commit specifies how to commit to the git repository.</summary>
    [JsonPropertyName("commit")]
    public V1beta2ImageUpdateAutomationSpecGitCommit Commit { get; set; }

    /// <summary>Push specifies how and where to push commits made by the automation. If missing, commits are pushed (back) to `.spec.checkout.branch` or its default.</summary>
    [JsonPropertyName("push")]
    public V1beta2ImageUpdateAutomationSpecGitPush? Push { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecPolicySelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PolicySelector allows to filter applied policies based on labels. By default includes all policies in namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecPolicySelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta2ImageUpdateAutomationSpecPolicySelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SourceRef refers to the resource giving access details to a git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecSourceRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent, defaults to the namespace of the Kubernetes resource object that contains the reference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Update gives the specification for how to update the files in the repository. This can be left empty, to use the default value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpecUpdate
{
    /// <summary>Path to the directory containing the manifests to be updated. Defaults to 'None', which translates to the root path of the GitRepositoryRef.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Strategy names the strategy to be used.</summary>
    [JsonPropertyName("strategy")]
    public string Strategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ImageUpdateAutomationSpec defines the desired state of ImageUpdateAutomation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationSpec
{
    /// <summary>GitSpec contains all the git-specific definitions. This is technically optional, but in practice mandatory until there are other kinds of source allowed.</summary>
    [JsonPropertyName("git")]
    public V1beta2ImageUpdateAutomationSpecGit? Git { get; set; }

    /// <summary>Interval gives an lower bound for how often the automation run should be attempted.</summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    /// <summary>PolicySelector allows to filter applied policies based on labels. By default includes all policies in namespace.</summary>
    [JsonPropertyName("policySelector")]
    public V1beta2ImageUpdateAutomationSpecPolicySelector? PolicySelector { get; set; }

    /// <summary>SourceRef refers to the resource giving access details to a git repository.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta2ImageUpdateAutomationSpecSourceRef SourceRef { get; set; }

    /// <summary>Suspend tells the controller to not run this automation, until it is unset (or set to false). Defaults to false.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Update gives the specification for how to update the files in the repository. This can be left empty, to use the default value.</summary>
    [JsonPropertyName("update")]
    public V1beta2ImageUpdateAutomationSpecUpdate? Update { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ImageRef represents an image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationStatusObservedPolicies
{
    /// <summary>Digest is the image's digest.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Name is the bare image's name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Tag is the image's tag.</summary>
    [JsonPropertyName("tag")]
    public string Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ImageUpdateAutomationStatus defines the observed state of ImageUpdateAutomation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageUpdateAutomationStatus
{
    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ImageUpdateAutomationStatusConditions>? Conditions { get; set; }

    /// <summary>LastAutomationRunTime records the last time the controller ran this automation through to completion (even if no updates were made).</summary>
    [JsonPropertyName("lastAutomationRunTime")]
    public string? LastAutomationRunTime { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>LastPushCommit records the SHA1 of the last commit made by the controller, for this automation object</summary>
    [JsonPropertyName("lastPushCommit")]
    public string? LastPushCommit { get; set; }

    /// <summary>LastPushTime records the time of the last pushed change.</summary>
    [JsonPropertyName("lastPushTime")]
    public string? LastPushTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedPolicies is the list of observed ImagePolicies that were considered by the ImageUpdateAutomation update process.</summary>
    [JsonPropertyName("observedPolicies")]
    public IDictionary<string, V1beta2ImageUpdateAutomationStatusObservedPolicies>? ObservedPolicies { get; set; }

    /// <summary>ObservedPolicies []ObservedPolicy `json:"observedPolicies,omitempty"` ObservedSourceRevision is the last observed source revision. This can be used to determine if the source has been updated since last observation.</summary>
    [JsonPropertyName("observedSourceRevision")]
    public string? ObservedSourceRevision { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ImageUpdateAutomation is the Schema for the imageupdateautomations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImageUpdateAutomation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ImageUpdateAutomationSpec>, IStatus<V1beta2ImageUpdateAutomationStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImageUpdateAutomation";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imageupdateautomations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageUpdateAutomationSpec defines the desired state of ImageUpdateAutomation</summary>
    [JsonPropertyName("spec")]
    public V1beta2ImageUpdateAutomationSpec? Spec { get; set; }

    /// <summary>ImageUpdateAutomationStatus defines the observed state of ImageUpdateAutomation</summary>
    [JsonPropertyName("status")]
    public V1beta2ImageUpdateAutomationStatus? Status { get; set; }
}
#nullable disable
