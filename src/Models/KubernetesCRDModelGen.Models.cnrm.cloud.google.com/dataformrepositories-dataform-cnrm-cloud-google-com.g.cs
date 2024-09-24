using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataform.cnrm.cloud.google.com;
/// <summary>The name of the Secret Manager secret version to use as an authentication token for Git operations. Must be in the format projects/* /secrets/* /versions/*.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecGitRemoteSettingsAuthenticationTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the Secret Manager secret version to use as a ssh private key for Git operations. Must be in the format projects/*/secrets/*/versions/* .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfigUserPrivateKeySecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Authentication fields for remote uris using SSH protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfig
{
    /// <summary>Content of a public SSH key to verify an identity of a remote Git host.</summary>
    [JsonPropertyName("hostPublicKey")]
    public string HostPublicKey { get; set; }

    /// <summary>The name of the Secret Manager secret version to use as a ssh private key for Git operations. Must be in the format projects/*/secrets/*/versions/* .</summary>
    [JsonPropertyName("userPrivateKeySecretVersionRef")]
    public V1beta1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfigUserPrivateKeySecretVersionRef UserPrivateKeySecretVersionRef { get; set; }
}

/// <summary>Optional. If set, configures this repository to be linked to a Git remote.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecGitRemoteSettings
{
    /// <summary>The name of the Secret Manager secret version to use as an authentication token for Git operations. Must be in the format projects/* /secrets/* /versions/*.</summary>
    [JsonPropertyName("authenticationTokenSecretVersionRef")]
    public V1beta1DataformRepositorySpecGitRemoteSettingsAuthenticationTokenSecretVersionRef? AuthenticationTokenSecretVersionRef { get; set; }

    /// <summary>The Git remote's default branch name.</summary>
    [JsonPropertyName("defaultBranch")]
    public string DefaultBranch { get; set; }

    /// <summary>Authentication fields for remote uris using SSH protocol.</summary>
    [JsonPropertyName("sshAuthenticationConfig")]
    public V1beta1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfig? SshAuthenticationConfig { get; set; }

    /// <summary>The Git remote's URL.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>Optional. The name of the Secret Manager secret version to be used to interpolate variables into the .npmrc file for package installation operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecNpmrcEnvironmentVariablesSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecProjectRef
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

/// <summary>Optional. The service account reference to run workflow invocations under.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. If set, fields of workspaceCompilationOverrides override the default compilation settings that are specified in dataform.json when creating workspace-scoped compilation results.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpecWorkspaceCompilationOverrides
{
    /// <summary>Optional. The default database (Google Cloud project ID).</summary>
    [JsonPropertyName("defaultDatabase")]
    public string? DefaultDatabase { get; set; }

    /// <summary>Optional. The suffix that should be appended to all schema (BigQuery dataset ID) names.</summary>
    [JsonPropertyName("schemaSuffix")]
    public string? SchemaSuffix { get; set; }

    /// <summary>Optional. The prefix that should be prepended to all table names.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositorySpec
{
    /// <summary>Optional. The repository's user-friendly name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. If set, configures this repository to be linked to a Git remote.</summary>
    [JsonPropertyName("gitRemoteSettings")]
    public V1beta1DataformRepositorySpecGitRemoteSettings? GitRemoteSettings { get; set; }

    /// <summary>Optional. The name of the Secret Manager secret version to be used to interpolate variables into the .npmrc file for package installation operations.</summary>
    [JsonPropertyName("npmrcEnvironmentVariablesSecretVersionRef")]
    public V1beta1DataformRepositorySpecNpmrcEnvironmentVariablesSecretVersionRef? NpmrcEnvironmentVariablesSecretVersionRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DataformRepositorySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. A reference to the region.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The service account reference to run workflow invocations under.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1DataformRepositorySpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. Input only. If set to true, the authenticated user will be granted the roles/dataform.admin role on the created repository.</summary>
    [JsonPropertyName("setAuthenticatedUserAdmin")]
    public bool? SetAuthenticatedUserAdmin { get; set; }

    /// <summary>Optional. If set, fields of workspaceCompilationOverrides override the default compilation settings that are specified in dataform.json when creating workspace-scoped compilation results.</summary>
    [JsonPropertyName("workspaceCompilationOverrides")]
    public V1beta1DataformRepositorySpecWorkspaceCompilationOverrides? WorkspaceCompilationOverrides { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositoryStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositoryStatusObservedState
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataformRepositoryStatus
{
    /// <summary>Conditions represent the latest available observations of the DataformRepository's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataformRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataformReposity resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1DataformRepositoryStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataformRepository is the Schema for the dataform API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataformRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataformRepositorySpec>, IStatus<V1beta1DataformRepositoryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataformRepository";
    public const string KubeGroup = "dataform.cnrm.cloud.google.com";
    public const string KubePluralName = "dataformrepositories";
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
    public V1beta1DataformRepositorySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1DataformRepositoryStatus? Status { get; set; }
}