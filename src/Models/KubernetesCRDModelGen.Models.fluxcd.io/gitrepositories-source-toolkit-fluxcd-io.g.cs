using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.source.toolkit.fluxcd.io;
/// <summary>GitRepositoryRef specifies the GitRepository which Artifact contents must be included.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpecIncludeRepository
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>GitRepositoryInclude specifies a local reference to a GitRepository which Artifact (sub-)contents must be included, and where they should be placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpecInclude
{
    /// <summary>FromPath specifies the path to copy contents from, defaults to the root of the Artifact.</summary>
    [JsonPropertyName("fromPath")]
    public string? FromPath { get; set; }

    /// <summary>GitRepositoryRef specifies the GitRepository which Artifact contents must be included.</summary>
    [JsonPropertyName("repository")]
    public V1GitRepositorySpecIncludeRepository Repository { get; set; }

    /// <summary>ToPath specifies the path to copy contents to, defaults to the name of the GitRepositoryRef.</summary>
    [JsonPropertyName("toPath")]
    public string? ToPath { get; set; }
}

/// <summary>ProxySecretRef specifies the Secret containing the proxy configuration to use while communicating with the Git server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpecProxySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Reference specifies the Git reference to resolve and monitor for changes, defaults to the 'master' branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpecRef
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

/// <summary>SecretRef specifies the Secret containing authentication credentials for the GitRepository. For HTTPS repositories the Secret must contain 'username' and 'password' fields for basic auth or 'bearerToken' field for token auth. For SSH repositories the Secret must contain 'identity' and 'known_hosts' fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretRef specifies the Secret containing the public keys of trusted Git authors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpecVerifySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Verification specifies the configuration to verify the Git commit signature(s).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpecVerify
{
    /// <summary>Mode specifies which Git object(s) should be verified.  The variants "head" and "HEAD" both imply the same thing, i.e. verify the commit that the HEAD of the Git repository points to. The variant "head" solely exists to ensure backwards compatibility.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>SecretRef specifies the Secret containing the public keys of trusted Git authors.</summary>
    [JsonPropertyName("secretRef")]
    public V1GitRepositorySpecVerifySecretRef SecretRef { get; set; }
}

/// <summary>GitRepositorySpec specifies the required configuration to produce an Artifact for a Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositorySpec
{
    /// <summary>Ignore overrides the set of excluded patterns in the .sourceignore format (which is the same as .gitignore). If not provided, a default will be used, consult the documentation for your version to find out what those are.</summary>
    [JsonPropertyName("ignore")]
    public string? Ignore { get; set; }

    /// <summary>Include specifies a list of GitRepository resources which Artifacts should be included in the Artifact produced for this GitRepository.</summary>
    [JsonPropertyName("include")]
    public IList<V1GitRepositorySpecInclude>? Include { get; set; }

    /// <summary>Interval at which the GitRepository URL is checked for updates. This interval is approximate and may be subject to jitter to ensure efficient use of resources.</summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    /// <summary>Provider used for authentication, can be 'azure', 'github', 'generic'. When not specified, defaults to 'generic'.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>ProxySecretRef specifies the Secret containing the proxy configuration to use while communicating with the Git server.</summary>
    [JsonPropertyName("proxySecretRef")]
    public V1GitRepositorySpecProxySecretRef? ProxySecretRef { get; set; }

    /// <summary>RecurseSubmodules enables the initialization of all submodules within the GitRepository as cloned from the URL, using their default settings.</summary>
    [JsonPropertyName("recurseSubmodules")]
    public bool? RecurseSubmodules { get; set; }

    /// <summary>Reference specifies the Git reference to resolve and monitor for changes, defaults to the 'master' branch.</summary>
    [JsonPropertyName("ref")]
    public V1GitRepositorySpecRef? Ref { get; set; }

    /// <summary>SecretRef specifies the Secret containing authentication credentials for the GitRepository. For HTTPS repositories the Secret must contain 'username' and 'password' fields for basic auth or 'bearerToken' field for token auth. For SSH repositories the Secret must contain 'identity' and 'known_hosts' fields.</summary>
    [JsonPropertyName("secretRef")]
    public V1GitRepositorySpecSecretRef? SecretRef { get; set; }

    /// <summary>SparseCheckout specifies a list of directories to checkout when cloning the repository. If specified, only these directories are included in the Artifact produced for this GitRepository.</summary>
    [JsonPropertyName("sparseCheckout")]
    public IList<string>? SparseCheckout { get; set; }

    /// <summary>Suspend tells the controller to suspend the reconciliation of this GitRepository.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout for Git operations like cloning, defaults to 60s.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>URL specifies the Git repository URL, it can be an HTTP/S or SSH address.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>Verification specifies the configuration to verify the Git commit signature(s).</summary>
    [JsonPropertyName("verify")]
    public V1GitRepositorySpecVerify? Verify { get; set; }
}

/// <summary>Artifact represents the last successful GitRepository reconciliation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositoryStatusArtifact
{
    /// <summary>Digest is the digest of the file in the form of '&lt;algorithm&gt;:&lt;checksum&gt;'.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>LastUpdateTime is the timestamp corresponding to the last update of the Artifact.</summary>
    [JsonPropertyName("lastUpdateTime")]
    public string LastUpdateTime { get; set; }

    /// <summary>Metadata holds upstream information such as OCI annotations.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Path is the relative file path of the Artifact. It can be used to locate the file in the root of the Artifact storage on the local file system of the controller managing the Source.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Revision is a human-readable identifier traceable in the origin source system. It can be a Git commit SHA, Git tag, a Helm chart version, etc.</summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary>Size is the number of bytes in the file.</summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>URL is the HTTP address of the Artifact as exposed by the controller managing the Source. It can be used to retrieve the Artifact for consumption, e.g. by another controller applying the Artifact contents.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositoryStatusConditions
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

/// <summary>Artifact represents the output of a Source reconciliation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositoryStatusIncludedArtifacts
{
    /// <summary>Digest is the digest of the file in the form of '&lt;algorithm&gt;:&lt;checksum&gt;'.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>LastUpdateTime is the timestamp corresponding to the last update of the Artifact.</summary>
    [JsonPropertyName("lastUpdateTime")]
    public string LastUpdateTime { get; set; }

    /// <summary>Metadata holds upstream information such as OCI annotations.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Path is the relative file path of the Artifact. It can be used to locate the file in the root of the Artifact storage on the local file system of the controller managing the Source.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Revision is a human-readable identifier traceable in the origin source system. It can be a Git commit SHA, Git tag, a Helm chart version, etc.</summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary>Size is the number of bytes in the file.</summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>URL is the HTTP address of the Artifact as exposed by the controller managing the Source. It can be used to retrieve the Artifact for consumption, e.g. by another controller applying the Artifact contents.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>GitRepositoryRef specifies the GitRepository which Artifact contents must be included.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositoryStatusObservedIncludeRepository
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>GitRepositoryInclude specifies a local reference to a GitRepository which Artifact (sub-)contents must be included, and where they should be placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositoryStatusObservedInclude
{
    /// <summary>FromPath specifies the path to copy contents from, defaults to the root of the Artifact.</summary>
    [JsonPropertyName("fromPath")]
    public string? FromPath { get; set; }

    /// <summary>GitRepositoryRef specifies the GitRepository which Artifact contents must be included.</summary>
    [JsonPropertyName("repository")]
    public V1GitRepositoryStatusObservedIncludeRepository Repository { get; set; }

    /// <summary>ToPath specifies the path to copy contents to, defaults to the name of the GitRepositoryRef.</summary>
    [JsonPropertyName("toPath")]
    public string? ToPath { get; set; }
}

/// <summary>GitRepositoryStatus records the observed state of a Git repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GitRepositoryStatus
{
    /// <summary>Artifact represents the last successful GitRepository reconciliation.</summary>
    [JsonPropertyName("artifact")]
    public V1GitRepositoryStatusArtifact? Artifact { get; set; }

    /// <summary>Conditions holds the conditions for the GitRepository.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1GitRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>IncludedArtifacts contains a list of the last successfully included Artifacts as instructed by GitRepositorySpec.Include.</summary>
    [JsonPropertyName("includedArtifacts")]
    public IList<V1GitRepositoryStatusIncludedArtifacts>? IncludedArtifacts { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last observed generation of the GitRepository object.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedIgnore is the observed exclusion patterns used for constructing the source artifact.</summary>
    [JsonPropertyName("observedIgnore")]
    public string? ObservedIgnore { get; set; }

    /// <summary>ObservedInclude is the observed list of GitRepository resources used to produce the current Artifact.</summary>
    [JsonPropertyName("observedInclude")]
    public IList<V1GitRepositoryStatusObservedInclude>? ObservedInclude { get; set; }

    /// <summary>ObservedRecurseSubmodules is the observed resource submodules configuration used to produce the current Artifact.</summary>
    [JsonPropertyName("observedRecurseSubmodules")]
    public bool? ObservedRecurseSubmodules { get; set; }

    /// <summary>ObservedSparseCheckout is the observed list of directories used to produce the current Artifact.</summary>
    [JsonPropertyName("observedSparseCheckout")]
    public IList<string>? ObservedSparseCheckout { get; set; }

    /// <summary>SourceVerificationMode is the last used verification mode indicating which Git object(s) have been verified.</summary>
    [JsonPropertyName("sourceVerificationMode")]
    public string? SourceVerificationMode { get; set; }
}

/// <summary>GitRepository is the Schema for the gitrepositories API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GitRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1GitRepositorySpec>, IStatus<V1GitRepositoryStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GitRepository";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "gitrepositories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GitRepositorySpec specifies the required configuration to produce an Artifact for a Git repository.</summary>
    [JsonPropertyName("spec")]
    public V1GitRepositorySpec? Spec { get; set; }

    /// <summary>GitRepositoryStatus records the observed state of a Git repository.</summary>
    [JsonPropertyName("status")]
    public V1GitRepositoryStatus? Status { get; set; }
}

/// <summary>GitRepository is the Schema for the gitrepositories API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GitRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1GitRepository>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GitRepositoryList";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "gitrepositories";
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
    public IList<V1GitRepository> Items { get; set; }
}