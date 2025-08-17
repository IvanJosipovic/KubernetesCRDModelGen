using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.artifactregistry.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ArtifactRegistryRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ArtifactRegistryRepository>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ArtifactRegistryRepositoryList";
    public const string KubeGroup = "artifactregistry.cnrm.cloud.google.com";
    public const string KubePluralName = "artifactregistryrepositories";
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
    public IList<V1beta1ArtifactRegistryRepository> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policy condition for matching versions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesCondition
{
    /// <summary>Match versions newer than a duration.</summary>
    [JsonPropertyName("newerThan")]
    public string? NewerThan { get; set; }

    /// <summary>Match versions older than a duration.</summary>
    [JsonPropertyName("olderThan")]
    public string? OlderThan { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }

    /// <summary>Match versions by tag prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("tagPrefixes")]
    public IList<string>? TagPrefixes { get; set; }

    /// <summary>Match versions by tag status. Default value: "ANY" Possible values: ["TAGGED", "UNTAGGED", "ANY"].</summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public int? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecCleanupPolicies
{
    /// <summary>Policy action. Possible values: ["DELETE", "KEEP"].</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Policy condition for matching versions.</summary>
    [JsonPropertyName("condition")]
    public V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesCondition? Condition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action.</summary>
    [JsonPropertyName("mostRecentVersions")]
    public V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesMostRecentVersions? MostRecentVersions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Docker repository config contains repository level configuration for the repositories of docker type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The customer managed encryption key that’s used to encrypt the contents of the Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MavenRepositoryConfig is maven related repository details. Provides additional configuration details for repositories of the maven format type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecMavenConfig
{
    /// <summary>Immutable. The repository with this flag will allow publishing the same snapshot versions.</summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>Immutable. Version policy defines the versions that the registry will accept. Default value: "VERSION_POLICY_UNSPECIFIED" Possible values: ["VERSION_POLICY_UNSPECIFIED", "RELEASE", "SNAPSHOT"].</summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Specific settings for a Docker remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigDockerRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "DOCKER_HUB" Possible values: ["DOCKER_HUB"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Specific settings for a Maven remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigMavenRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "MAVEN_CENTRAL" Possible values: ["MAVEN_CENTRAL"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Specific settings for an Npm remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigNpmRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "NPMJS" Possible values: ["NPMJS"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Specific settings for a Python remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigPythonRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "PYPI" Possible values: ["PYPI"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Configuration specific for a Remote Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfig
{
    /// <summary>Immutable. The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Specific settings for a Docker remote repository.</summary>
    [JsonPropertyName("dockerRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigDockerRepository? DockerRepository { get; set; }

    /// <summary>Immutable. Specific settings for a Maven remote repository.</summary>
    [JsonPropertyName("mavenRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigMavenRepository? MavenRepository { get; set; }

    /// <summary>Immutable. Specific settings for an Npm remote repository.</summary>
    [JsonPropertyName("npmRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigNpmRepository? NpmRepository { get; set; }

    /// <summary>Immutable. Specific settings for a Python remote repository.</summary>
    [JsonPropertyName("pythonRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigPythonRepository? PythonRepository { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A reference to the repository resource, for example: "projects/p1/locations/us-central1/repositories/repo1".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPoliciesRepositoryRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/locations/{{location}}/repositories/{{value}}`, where {{value}} is the `name` field of an `ArtifactRegistryRepository` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>A reference to the repository resource, for example: "projects/p1/locations/us-central1/repositories/repo1".</summary>
    [JsonPropertyName("repositoryRef")]
    public V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPoliciesRepositoryRef? RepositoryRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration specific for a Virtual Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfig
{
    /// <summary>Policies that configure the upstream artifacts distributed by the Virtual Repository. Upstream policies cannot be set on a standard repository.</summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpec
{
    /// <summary>Cleanup policies for this repository. Cleanup policies indicate when certain package versions can be automatically deleted. Map keys are policy IDs supplied by users during policy creation. They must unique within a repository and be under 128 characters in length.</summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta1ArtifactRegistryRepositorySpecCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>If true, the cleanup pipeline is prevented from deleting versions in this repository.</summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker repository config contains repository level configuration for the repositories of docker type.</summary>
    [JsonPropertyName("dockerConfig")]
    public V1beta1ArtifactRegistryRepositorySpecDockerConfig? DockerConfig { get; set; }

    /// <summary>Immutable. The format of packages that are stored in the repository. Supported formats can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats). You can only create alpha formats if you are a member of the [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).</summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }

    /// <summary>The customer managed encryption key that’s used to encrypt the contents of the Repository.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ArtifactRegistryRepositorySpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Immutable. The name of the location this repository is located in.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>MavenRepositoryConfig is maven related repository details. Provides additional configuration details for repositories of the maven format type.</summary>
    [JsonPropertyName("mavenConfig")]
    public V1beta1ArtifactRegistryRepositorySpecMavenConfig? MavenConfig { get; set; }

    /// <summary>Immutable. The mode configures the repository to serve artifacts from different sources. Default value: "STANDARD_REPOSITORY" Possible values: ["STANDARD_REPOSITORY", "VIRTUAL_REPOSITORY", "REMOTE_REPOSITORY"].</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Immutable. Configuration specific for a Remote Repository.</summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfig? RemoteRepositoryConfig { get; set; }

    /// <summary>Immutable. Optional. The repositoryId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Configuration specific for a Virtual Repository.</summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfig? VirtualRepositoryConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositoryStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositoryStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ArtifactRegistryRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the repository was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The name of the repository, for example: "repo1".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The time when the repository was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ArtifactRegistryRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ArtifactRegistryRepositorySpec>, IStatus<V1beta1ArtifactRegistryRepositoryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ArtifactRegistryRepository";
    public const string KubeGroup = "artifactregistry.cnrm.cloud.google.com";
    public const string KubePluralName = "artifactregistryrepositories";
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
    public V1beta1ArtifactRegistryRepositorySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ArtifactRegistryRepositoryStatus? Status { get; set; }
}
#nullable disable
