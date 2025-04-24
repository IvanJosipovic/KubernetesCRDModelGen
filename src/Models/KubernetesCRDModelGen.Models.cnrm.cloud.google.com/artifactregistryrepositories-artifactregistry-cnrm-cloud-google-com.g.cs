using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.artifactregistry.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositoryMetadata
{
}

/// <summary>Policy condition for matching versions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecCleanupPoliciesCondition
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

/// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public int? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecCleanupPolicies
{
    /// <summary>Policy action. Possible values: ["DELETE", "KEEP"].</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Policy condition for matching versions.</summary>
    [JsonPropertyName("condition")]
    public ArtifactRegistryRepositorySpecCleanupPoliciesCondition? Condition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action.</summary>
    [JsonPropertyName("mostRecentVersions")]
    public ArtifactRegistryRepositorySpecCleanupPoliciesMostRecentVersions? MostRecentVersions { get; set; }
}

/// <summary>Docker repository config contains repository level configuration for the repositories of docker type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary>The customer managed encryption key that’s used to encrypt the contents of the Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecKmsKeyRef
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

/// <summary>MavenRepositoryConfig is maven related repository details. Provides additional configuration details for repositories of the maven format type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecMavenConfig
{
    /// <summary>Immutable. The repository with this flag will allow publishing the same snapshot versions.</summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>Immutable. Version policy defines the versions that the registry will accept. Default value: "VERSION_POLICY_UNSPECIFIED" Possible values: ["VERSION_POLICY_UNSPECIFIED", "RELEASE", "SNAPSHOT"].</summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary>Immutable. Specific settings for a Docker remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecRemoteRepositoryConfigDockerRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "DOCKER_HUB" Possible values: ["DOCKER_HUB"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Immutable. Specific settings for a Maven remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecRemoteRepositoryConfigMavenRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "MAVEN_CENTRAL" Possible values: ["MAVEN_CENTRAL"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Immutable. Specific settings for an Npm remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecRemoteRepositoryConfigNpmRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "NPMJS" Possible values: ["NPMJS"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Immutable. Specific settings for a Python remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecRemoteRepositoryConfigPythonRepository
{
    /// <summary>Immutable. Address of the remote repository. Default value: "PYPI" Possible values: ["PYPI"].</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Immutable. Configuration specific for a Remote Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecRemoteRepositoryConfig
{
    /// <summary>Immutable. The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Specific settings for a Docker remote repository.</summary>
    [JsonPropertyName("dockerRepository")]
    public ArtifactRegistryRepositorySpecRemoteRepositoryConfigDockerRepository? DockerRepository { get; set; }

    /// <summary>Immutable. Specific settings for a Maven remote repository.</summary>
    [JsonPropertyName("mavenRepository")]
    public ArtifactRegistryRepositorySpecRemoteRepositoryConfigMavenRepository? MavenRepository { get; set; }

    /// <summary>Immutable. Specific settings for an Npm remote repository.</summary>
    [JsonPropertyName("npmRepository")]
    public ArtifactRegistryRepositorySpecRemoteRepositoryConfigNpmRepository? NpmRepository { get; set; }

    /// <summary>Immutable. Specific settings for a Python remote repository.</summary>
    [JsonPropertyName("pythonRepository")]
    public ArtifactRegistryRepositorySpecRemoteRepositoryConfigPythonRepository? PythonRepository { get; set; }
}

/// <summary>A reference to the repository resource, for example: "projects/p1/locations/us-central1/repositories/repo1".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPoliciesRepositoryRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>A reference to the repository resource, for example: "projects/p1/locations/us-central1/repositories/repo1".</summary>
    [JsonPropertyName("repositoryRef")]
    public ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPoliciesRepositoryRef? RepositoryRef { get; set; }
}

/// <summary>Configuration specific for a Virtual Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpecVirtualRepositoryConfig
{
    /// <summary>Policies that configure the upstream artifacts distributed by the Virtual Repository. Upstream policies cannot be set on a standard repository.</summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositorySpec
{
    /// <summary>Cleanup policies for this repository. Cleanup policies indicate when certain package versions can be automatically deleted. Map keys are policy IDs supplied by users during policy creation. They must unique within a repository and be under 128 characters in length.</summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<ArtifactRegistryRepositorySpecCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>If true, the cleanup pipeline is prevented from deleting versions in this repository.</summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker repository config contains repository level configuration for the repositories of docker type.</summary>
    [JsonPropertyName("dockerConfig")]
    public ArtifactRegistryRepositorySpecDockerConfig? DockerConfig { get; set; }

    /// <summary>Immutable. The format of packages that are stored in the repository. Supported formats can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats). You can only create alpha formats if you are a member of the [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).</summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }

    /// <summary>The customer managed encryption key that’s used to encrypt the contents of the Repository.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public ArtifactRegistryRepositorySpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Immutable. The name of the location this repository is located in.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>MavenRepositoryConfig is maven related repository details. Provides additional configuration details for repositories of the maven format type.</summary>
    [JsonPropertyName("mavenConfig")]
    public ArtifactRegistryRepositorySpecMavenConfig? MavenConfig { get; set; }

    /// <summary>Immutable. The mode configures the repository to serve artifacts from different sources. Default value: "STANDARD_REPOSITORY" Possible values: ["STANDARD_REPOSITORY", "VIRTUAL_REPOSITORY", "REMOTE_REPOSITORY"].</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Immutable. Configuration specific for a Remote Repository.</summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public ArtifactRegistryRepositorySpecRemoteRepositoryConfig? RemoteRepositoryConfig { get; set; }

    /// <summary>Immutable. Optional. The repositoryId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Configuration specific for a Virtual Repository.</summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public ArtifactRegistryRepositorySpecVirtualRepositoryConfig? VirtualRepositoryConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepositoryStatusConditions
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
public partial class ArtifactRegistryRepositoryStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<ArtifactRegistryRepositoryStatusConditions>? Conditions { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtifactRegistryRepository
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public ArtifactRegistryRepositoryMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public ArtifactRegistryRepositorySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public ArtifactRegistryRepositoryStatus? Status { get; set; }
}