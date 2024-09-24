using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.artifact.gcp.upbound.io;
public enum V1beta1RegistryRepositorySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderCleanupPoliciesCondition
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

    /// <summary>Match versions by tag status. Default value is ANY. Possible values are: TAGGED, UNTAGGED, ANY.</summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public double? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderCleanupPolicies
{
    /// <summary>Policy action. Possible values are: DELETE, KEEP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Policy condition for matching versions. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1RegistryRepositorySpecForProviderCleanupPoliciesCondition>? Condition { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action. Structure is documented below.</summary>
    [JsonPropertyName("mostRecentVersions")]
    public IList<V1beta1RegistryRepositorySpecForProviderCleanupPoliciesMostRecentVersions>? MostRecentVersions { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderMavenConfig
{
    /// <summary>The repository with this flag will allow publishing the same snapshot versions.</summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>Version policy defines the versions that the registry will accept. Default value is VERSION_POLICY_UNSPECIFIED. Possible values are: VERSION_POLICY_UNSPECIFIED, RELEASE, SNAPSHOT.</summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepositoryPublicRepository
{
    /// <summary>A common public repository base for Yum. Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.</summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. "centos/8-stream/BaseOS/x86_64/os"</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepository
{
    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepositoryPublicRepository>? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

public enum V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy? Policy { get; set; }
}

public enum V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials
{
    /// <summary>The Secret Manager key version that holds the password to access the remote repository. Must be in the format of projects/{project}/secrets/{secret}/versions/{version}.</summary>
    [JsonPropertyName("passwordSecretVersion")]
    public string? PasswordSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionRef")]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef? PasswordSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionSelector")]
    public V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector? PasswordSecretVersionSelector { get; set; }

    /// <summary>The username to access the remote repository.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentials
{
    /// <summary>Use username and password to access the remote repository. Structure is documented below.</summary>
    [JsonPropertyName("usernamePasswordCredentials")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials>? UsernamePasswordCredentials { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepositoryPublicRepository
{
    /// <summary>A common public repository base for Yum. Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.</summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. "centos/8-stream/BaseOS/x86_64/os"</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepository
{
    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepositoryPublicRepository>? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfig
{
    /// <summary>Specific settings for an Apt remote repository. Structure is documented below.</summary>
    [JsonPropertyName("aptRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepository>? AptRepository { get; set; }

    /// <summary>The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, the remote repository upstream and upstream credentials will not be validated.</summary>
    [JsonPropertyName("disableUpstreamValidation")]
    public bool? DisableUpstreamValidation { get; set; }

    /// <summary>Specific settings for a Docker remote repository. Structure is documented below.</summary>
    [JsonPropertyName("dockerRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepository>? DockerRepository { get; set; }

    /// <summary>Specific settings for a Maven remote repository. Structure is documented below.</summary>
    [JsonPropertyName("mavenRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepository>? MavenRepository { get; set; }

    /// <summary>Specific settings for an Npm remote repository. Structure is documented below.</summary>
    [JsonPropertyName("npmRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepository>? NpmRepository { get; set; }

    /// <summary>Specific settings for a Python remote repository. Structure is documented below.</summary>
    [JsonPropertyName("pythonRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepository>? PythonRepository { get; set; }

    /// <summary>The credentials used to access the remote repository. Structure is documented below.</summary>
    [JsonPropertyName("upstreamCredentials")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentials>? UpstreamCredentials { get; set; }

    /// <summary>Specific settings for an Yum remote repository. Structure is documented below.</summary>
    [JsonPropertyName("yumRepository")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepository>? YumRepository { get; set; }
}

public enum V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy? Policy { get; set; }
}

public enum V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
public partial class V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A reference to the repository resource, for example: "projects/p1/locations/us-central1/repository/repo1".</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector? RepositorySelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfig
{
    /// <summary>Policies that configure the upstream artifacts distributed by the Virtual Repository. Upstream policies cannot be set on a standard repository. Structure is documented below.</summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecForProvider
{
    /// <summary>Cleanup policies for this repository. Cleanup policies indicate when certain package versions can be automatically deleted. Map keys are policy IDs supplied by users during policy creation. They must unique within a repository and be under 128 characters in length. Structure is documented below.</summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta1RegistryRepositorySpecForProviderCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>If true, the cleanup pipeline is prevented from deleting versions in this repository.</summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker repository config contains repository level configuration for the repositories of docker type. Structure is documented below.</summary>
    [JsonPropertyName("dockerConfig")]
    public IList<V1beta1RegistryRepositorySpecForProviderDockerConfig>? DockerConfig { get; set; }

    /// <summary>The format of packages that are stored in the repository. Supported formats can be found here. You can only create alpha formats if you are a member of the alpha user group.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The Cloud KMS resource name of the customer managed encryption key that’s used to encrypt the contents of the Repository. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. This value may not be changed after the Repository has been created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Labels with user-defined metadata. This field may contain up to 64 entries. Label keys and values may be no longer than 63 characters. Label keys must begin with a lowercase letter and may only contain lowercase letters, numeric characters, underscores, and dashes.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location this repository is located in.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MavenRepositoryConfig is maven related repository details. Provides additional configuration details for repositories of the maven format type. Structure is documented below.</summary>
    [JsonPropertyName("mavenConfig")]
    public IList<V1beta1RegistryRepositorySpecForProviderMavenConfig>? MavenConfig { get; set; }

    /// <summary>The mode configures the repository to serve artifacts from different sources. Default value is STANDARD_REPOSITORY. Possible values are: STANDARD_REPOSITORY, VIRTUAL_REPOSITORY, REMOTE_REPOSITORY.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration specific for a Remote Repository. Structure is documented below.</summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public IList<V1beta1RegistryRepositorySpecForProviderRemoteRepositoryConfig>? RemoteRepositoryConfig { get; set; }

    /// <summary>Configuration specific for a Virtual Repository. Structure is documented below.</summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public IList<V1beta1RegistryRepositorySpecForProviderVirtualRepositoryConfig>? VirtualRepositoryConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderCleanupPoliciesCondition
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

    /// <summary>Match versions by tag status. Default value is ANY. Possible values are: TAGGED, UNTAGGED, ANY.</summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public double? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderCleanupPolicies
{
    /// <summary>Policy action. Possible values are: DELETE, KEEP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Policy condition for matching versions. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1RegistryRepositorySpecInitProviderCleanupPoliciesCondition>? Condition { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action. Structure is documented below.</summary>
    [JsonPropertyName("mostRecentVersions")]
    public IList<V1beta1RegistryRepositorySpecInitProviderCleanupPoliciesMostRecentVersions>? MostRecentVersions { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderMavenConfig
{
    /// <summary>The repository with this flag will allow publishing the same snapshot versions.</summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>Version policy defines the versions that the registry will accept. Default value is VERSION_POLICY_UNSPECIFIED. Possible values are: VERSION_POLICY_UNSPECIFIED, RELEASE, SNAPSHOT.</summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepositoryPublicRepository
{
    /// <summary>A common public repository base for Yum. Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.</summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. "centos/8-stream/BaseOS/x86_64/os"</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepository
{
    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepositoryPublicRepository>? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

public enum V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy? Policy { get; set; }
}

public enum V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials
{
    /// <summary>The Secret Manager key version that holds the password to access the remote repository. Must be in the format of projects/{project}/secrets/{secret}/versions/{version}.</summary>
    [JsonPropertyName("passwordSecretVersion")]
    public string? PasswordSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionRef")]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef? PasswordSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionSelector")]
    public V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector? PasswordSecretVersionSelector { get; set; }

    /// <summary>The username to access the remote repository.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentials
{
    /// <summary>Use username and password to access the remote repository. Structure is documented below.</summary>
    [JsonPropertyName("usernamePasswordCredentials")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials>? UsernamePasswordCredentials { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepositoryPublicRepository
{
    /// <summary>A common public repository base for Yum. Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.</summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. "centos/8-stream/BaseOS/x86_64/os"</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepository
{
    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepositoryPublicRepository>? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfig
{
    /// <summary>Specific settings for an Apt remote repository. Structure is documented below.</summary>
    [JsonPropertyName("aptRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepository>? AptRepository { get; set; }

    /// <summary>The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, the remote repository upstream and upstream credentials will not be validated.</summary>
    [JsonPropertyName("disableUpstreamValidation")]
    public bool? DisableUpstreamValidation { get; set; }

    /// <summary>Specific settings for a Docker remote repository. Structure is documented below.</summary>
    [JsonPropertyName("dockerRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepository>? DockerRepository { get; set; }

    /// <summary>Specific settings for a Maven remote repository. Structure is documented below.</summary>
    [JsonPropertyName("mavenRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepository>? MavenRepository { get; set; }

    /// <summary>Specific settings for an Npm remote repository. Structure is documented below.</summary>
    [JsonPropertyName("npmRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepository>? NpmRepository { get; set; }

    /// <summary>Specific settings for a Python remote repository. Structure is documented below.</summary>
    [JsonPropertyName("pythonRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepository>? PythonRepository { get; set; }

    /// <summary>The credentials used to access the remote repository. Structure is documented below.</summary>
    [JsonPropertyName("upstreamCredentials")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentials>? UpstreamCredentials { get; set; }

    /// <summary>Specific settings for an Yum remote repository. Structure is documented below.</summary>
    [JsonPropertyName("yumRepository")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepository>? YumRepository { get; set; }
}

public enum V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy? Policy { get; set; }
}

public enum V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
public partial class V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A reference to the repository resource, for example: "projects/p1/locations/us-central1/repository/repo1".</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector? RepositorySelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfig
{
    /// <summary>Policies that configure the upstream artifacts distributed by the Virtual Repository. Upstream policies cannot be set on a standard repository. Structure is documented below.</summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1RegistryRepositorySpecInitProvider
{
    /// <summary>Cleanup policies for this repository. Cleanup policies indicate when certain package versions can be automatically deleted. Map keys are policy IDs supplied by users during policy creation. They must unique within a repository and be under 128 characters in length. Structure is documented below.</summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta1RegistryRepositorySpecInitProviderCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>If true, the cleanup pipeline is prevented from deleting versions in this repository.</summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker repository config contains repository level configuration for the repositories of docker type. Structure is documented below.</summary>
    [JsonPropertyName("dockerConfig")]
    public IList<V1beta1RegistryRepositorySpecInitProviderDockerConfig>? DockerConfig { get; set; }

    /// <summary>The format of packages that are stored in the repository. Supported formats can be found here. You can only create alpha formats if you are a member of the alpha user group.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The Cloud KMS resource name of the customer managed encryption key that’s used to encrypt the contents of the Repository. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. This value may not be changed after the Repository has been created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Labels with user-defined metadata. This field may contain up to 64 entries. Label keys and values may be no longer than 63 characters. Label keys must begin with a lowercase letter and may only contain lowercase letters, numeric characters, underscores, and dashes.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>MavenRepositoryConfig is maven related repository details. Provides additional configuration details for repositories of the maven format type. Structure is documented below.</summary>
    [JsonPropertyName("mavenConfig")]
    public IList<V1beta1RegistryRepositorySpecInitProviderMavenConfig>? MavenConfig { get; set; }

    /// <summary>The mode configures the repository to serve artifacts from different sources. Default value is STANDARD_REPOSITORY. Possible values are: STANDARD_REPOSITORY, VIRTUAL_REPOSITORY, REMOTE_REPOSITORY.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration specific for a Remote Repository. Structure is documented below.</summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public IList<V1beta1RegistryRepositorySpecInitProviderRemoteRepositoryConfig>? RemoteRepositoryConfig { get; set; }

    /// <summary>Configuration specific for a Virtual Repository. Structure is documented below.</summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public IList<V1beta1RegistryRepositorySpecInitProviderVirtualRepositoryConfig>? VirtualRepositoryConfig { get; set; }
}

public enum V1beta1RegistryRepositorySpecManagementPoliciesEnum
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

public enum V1beta1RegistryRepositorySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegistryRepositorySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1RegistryRepositorySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1RegistryRepositorySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RegistryRepositorySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RegistryRepositorySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RegistryRepositorySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1RegistryRepositorySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RegistryRepositorySpec defines the desired state of RegistryRepository</summary>
public partial class V1beta1RegistryRepositorySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegistryRepositorySpecDeletionPolicyEnum>))]
    public V1beta1RegistryRepositorySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegistryRepositorySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegistryRepositorySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegistryRepositorySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegistryRepositorySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RegistryRepositorySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegistryRepositorySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderCleanupPoliciesCondition
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

    /// <summary>Match versions by tag status. Default value is ANY. Possible values are: TAGGED, UNTAGGED, ANY.</summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public double? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderCleanupPolicies
{
    /// <summary>Policy action. Possible values are: DELETE, KEEP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Policy condition for matching versions. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderCleanupPoliciesCondition>? Condition { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action. Structure is documented below.</summary>
    [JsonPropertyName("mostRecentVersions")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderCleanupPoliciesMostRecentVersions>? MostRecentVersions { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderMavenConfig
{
    /// <summary>The repository with this flag will allow publishing the same snapshot versions.</summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>Version policy defines the versions that the registry will accept. Default value is VERSION_POLICY_UNSPECIFIED. Possible values are: VERSION_POLICY_UNSPECIFIED, RELEASE, SNAPSHOT.</summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepositoryPublicRepository
{
    /// <summary>A common public repository base for Yum. Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.</summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. "centos/8-stream/BaseOS/x86_64/os"</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepository
{
    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepositoryPublicRepository>? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. "https://registry-1.docker.io"</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepository
{
    /// <summary>Settings for a remote repository with a custom uri. Structure is documented below.</summary>
    [JsonPropertyName("customRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepositoryCustomRepository>? CustomRepository { get; set; }

    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials
{
    /// <summary>The Secret Manager key version that holds the password to access the remote repository. Must be in the format of projects/{project}/secrets/{secret}/versions/{version}.</summary>
    [JsonPropertyName("passwordSecretVersion")]
    public string? PasswordSecretVersion { get; set; }

    /// <summary>The username to access the remote repository.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentials
{
    /// <summary>Use username and password to access the remote repository. Structure is documented below.</summary>
    [JsonPropertyName("usernamePasswordCredentials")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials>? UsernamePasswordCredentials { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepositoryPublicRepository
{
    /// <summary>A common public repository base for Yum. Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.</summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. "centos/8-stream/BaseOS/x86_64/os"</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepository
{
    /// <summary>One of the publicly available Yum repositories supported by Artifact Registry. Structure is documented below.</summary>
    [JsonPropertyName("publicRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepositoryPublicRepository>? PublicRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfig
{
    /// <summary>Specific settings for an Apt remote repository. Structure is documented below.</summary>
    [JsonPropertyName("aptRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepository>? AptRepository { get; set; }

    /// <summary>The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, the remote repository upstream and upstream credentials will not be validated.</summary>
    [JsonPropertyName("disableUpstreamValidation")]
    public bool? DisableUpstreamValidation { get; set; }

    /// <summary>Specific settings for a Docker remote repository. Structure is documented below.</summary>
    [JsonPropertyName("dockerRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepository>? DockerRepository { get; set; }

    /// <summary>Specific settings for a Maven remote repository. Structure is documented below.</summary>
    [JsonPropertyName("mavenRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepository>? MavenRepository { get; set; }

    /// <summary>Specific settings for an Npm remote repository. Structure is documented below.</summary>
    [JsonPropertyName("npmRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepository>? NpmRepository { get; set; }

    /// <summary>Specific settings for a Python remote repository. Structure is documented below.</summary>
    [JsonPropertyName("pythonRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepository>? PythonRepository { get; set; }

    /// <summary>The credentials used to access the remote repository. Structure is documented below.</summary>
    [JsonPropertyName("upstreamCredentials")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentials>? UpstreamCredentials { get; set; }

    /// <summary>Specific settings for an Yum remote repository. Structure is documented below.</summary>
    [JsonPropertyName("yumRepository")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepository>? YumRepository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A reference to the repository resource, for example: "projects/p1/locations/us-central1/repository/repo1".</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProviderVirtualRepositoryConfig
{
    /// <summary>Policies that configure the upstream artifacts distributed by the Virtual Repository. Upstream policies cannot be set on a standard repository. Structure is documented below.</summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegistryRepositoryStatusAtProvider
{
    /// <summary>Cleanup policies for this repository. Cleanup policies indicate when certain package versions can be automatically deleted. Map keys are policy IDs supplied by users during policy creation. They must unique within a repository and be under 128 characters in length. Structure is documented below.</summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>If true, the cleanup pipeline is prevented from deleting versions in this repository.</summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The time when the repository was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker repository config contains repository level configuration for the repositories of docker type. Structure is documented below.</summary>
    [JsonPropertyName("dockerConfig")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderDockerConfig>? DockerConfig { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The format of packages that are stored in the repository. Supported formats can be found here. You can only create alpha formats if you are a member of the alpha user group.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/repositories/{{repository_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Cloud KMS resource name of the customer managed encryption key that’s used to encrypt the contents of the Repository. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. This value may not be changed after the Repository has been created.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Labels with user-defined metadata. This field may contain up to 64 entries. Label keys and values may be no longer than 63 characters. Label keys must begin with a lowercase letter and may only contain lowercase letters, numeric characters, underscores, and dashes.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location this repository is located in.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MavenRepositoryConfig is maven related repository details. Provides additional configuration details for repositories of the maven format type. Structure is documented below.</summary>
    [JsonPropertyName("mavenConfig")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderMavenConfig>? MavenConfig { get; set; }

    /// <summary>The mode configures the repository to serve artifacts from different sources. Default value is STANDARD_REPOSITORY. Possible values are: STANDARD_REPOSITORY, VIRTUAL_REPOSITORY, REMOTE_REPOSITORY.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the repository, for example: "repo1"</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration specific for a Remote Repository. Structure is documented below.</summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderRemoteRepositoryConfig>? RemoteRepositoryConfig { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The time when the repository was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Configuration specific for a Virtual Repository. Structure is documented below.</summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public IList<V1beta1RegistryRepositoryStatusAtProviderVirtualRepositoryConfig>? VirtualRepositoryConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1RegistryRepositoryStatusConditions
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

/// <summary>RegistryRepositoryStatus defines the observed state of RegistryRepository.</summary>
public partial class V1beta1RegistryRepositoryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegistryRepositoryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegistryRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>RegistryRepository is the Schema for the RegistryRepositorys API. A repository for storing artifacts</summary>
public partial class V1beta1RegistryRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegistryRepositorySpec>, IStatus<V1beta1RegistryRepositoryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegistryRepository";
    public const string KubeGroup = "artifact.gcp.upbound.io";
    public const string KubePluralName = "registryrepositories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegistryRepositorySpec defines the desired state of RegistryRepository</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegistryRepositorySpec Spec { get; set; }

    /// <summary>RegistryRepositoryStatus defines the observed state of RegistryRepository.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegistryRepositoryStatus? Status { get; set; }
}