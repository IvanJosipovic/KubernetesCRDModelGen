using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudbuild.gcp.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecDeletionPolicyEnum
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
public partial class V1beta1TriggerSpecForProviderApprovalConfig
{
    /// <summary>Whether or not approval is needed. If this is set on a build, it will become pending when run, and will need to be explicitly approved to start.</summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBitbucketServerTriggerConfigPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBitbucketServerTriggerConfigPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBitbucketServerTriggerConfig
{
    /// <summary>The Bitbucket server config resource that this trigger config maps to.</summary>
    [JsonPropertyName("bitbucketServerConfigResource")]
    public string? BitbucketServerConfigResource { get; set; }

    /// <summary>Key of the project that the repo is in. For example: The key for https://mybitbucket.server/projects/TEST/repos/test-repo is "TEST".</summary>
    [JsonPropertyName("projectKey")]
    public string? ProjectKey { get; set; }

    /// <summary>Filter to match changes in pull requests. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerSpecForProviderBitbucketServerTriggerConfigPullRequest>? PullRequest { get; set; }

    /// <summary>Filter to match changes in refs like branches, tags. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerSpecForProviderBitbucketServerTriggerConfigPush>? Push { get; set; }

    /// <summary>Slug of the repository. A repository slug is a URL-friendly version of a repository name, automatically generated by Bitbucket for use in the URL. For example, if the repository name is 'test repo', in the URL it would become 'test-repo' as in https://mybitbucket.server/projects/TEST/repos/test-repo.</summary>
    [JsonPropertyName("repoSlug")]
    public string? RepoSlug { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildArtifactsMavenArtifacts
{
    /// <summary>Maven artifactId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Maven groupId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Maven version value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildArtifactsNpmPackages
{
    /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
    [JsonPropertyName("packagePath")]
    public string? PackagePath { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildArtifactsObjects
{
    /// <summary>Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/". Files in the workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Path globs used to match files in the build's workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildArtifactsPythonPackages
{
    /// <summary>Path globs used to match files in the build's workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildArtifacts
{
    /// <summary>A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the Build resource's results field. If any of the images fail to be pushed, the build status is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>A Maven artifact to upload to Artifact Registry upon successful completion of all build steps. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("mavenArtifacts")]
    public IList<V1beta1TriggerSpecForProviderBuildArtifactsMavenArtifacts>? MavenArtifacts { get; set; }

    /// <summary>Npm package to upload to Artifact Registry upon successful completion of all build steps. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("npmPackages")]
    public IList<V1beta1TriggerSpecForProviderBuildArtifactsNpmPackages>? NpmPackages { get; set; }

    /// <summary>A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in the workspace matching specified paths globs will be uploaded to the Cloud Storage location using the builder service account's credentials. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1TriggerSpecForProviderBuildArtifactsObjects>? Objects { get; set; }

    /// <summary>Python package to upload to Artifact Registry upon successful completion of all build steps. A package can encapsulate multiple objects to be uploaded to a single repository. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("pythonPackages")]
    public IList<V1beta1TriggerSpecForProviderBuildArtifactsPythonPackages>? PythonPackages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildAvailableSecretsSecretManager
{
    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public string? Env { get; set; }

    /// <summary>Resource name of the SecretVersion. In format: projects//secrets//versions/*</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildAvailableSecrets
{
    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretManager")]
    public IList<V1beta1TriggerSpecForProviderBuildAvailableSecretsSecretManager>? SecretManager { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildOptionsVolumes
{
    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildOptions
{
    /// <summary>Requested disk size for the VM that runs the build. Note that this is NOT "disk free"; some of the space will be used by the operating system and build utilities. Also note that this is the minimum disk size that will be allocated for the build -- the build may run with a larger disk than requested. At present, the maximum disk size is 1000GB; builds that request more than the maximum are rejected with an error.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Option to specify whether or not to apply bash style string operations to the substitutions. NOTE this is always enabled for triggered builds and cannot be overridden in the build configuration file.</summary>
    [JsonPropertyName("dynamicSubstitutions")]
    public bool? DynamicSubstitutions { get; set; }

    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Option to define build log streaming behavior to Google Cloud Storage. Possible values are: STREAM_DEFAULT, STREAM_ON, STREAM_OFF.</summary>
    [JsonPropertyName("logStreamingOption")]
    public string? LogStreamingOption { get; set; }

    /// <summary>Option to specify the logging mode, which determines if and where build logs are stored. Possible values are: LOGGING_UNSPECIFIED, LEGACY, GCS_ONLY, STACKDRIVER_ONLY, CLOUD_LOGGING_ONLY, NONE.</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Compute Engine machine type on which to run the build.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Requested verifiability options. Possible values are: NOT_VERIFIED, VERIFIED.</summary>
    [JsonPropertyName("requestedVerifyOption")]
    public string? RequestedVerifyOption { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Requested hash for SourceProvenance. Each value may be one of: NONE, SHA256, MD5.</summary>
    [JsonPropertyName("sourceProvenanceHash")]
    public IList<string>? SourceProvenanceHash { get; set; }

    /// <summary>Option to specify behavior when there is an error in the substitution checks. NOTE this is always set to ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file. Possible values are: MUST_MATCH, ALLOW_LOOSE.</summary>
    [JsonPropertyName("substitutionOption")]
    public string? SubstitutionOption { get; set; }

    /// <summary>List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named volume in only one step is not valid as it is indicative of a build request with an incorrect configuration. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1TriggerSpecForProviderBuildOptionsVolumes>? Volumes { get; set; }

    /// <summary>Option to specify a WorkerPool for the build. Format projects/{project}/workerPools/{workerPool} This field is experimental.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildSecret
{
    /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IDictionary<string, string>? SecretEnv { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildSourceRepoSource
{
    /// <summary>Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is assumed.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name "default" is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be used</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source. This object must be a gzipped archive file (.tar.gz) containing source to build.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildSource
{
    /// <summary>Location of the source in a Google Cloud Source Repository. Structure is documented below.</summary>
    [JsonPropertyName("repoSource")]
    public IList<V1beta1TriggerSpecForProviderBuildSourceRepoSource>? RepoSource { get; set; }

    /// <summary>Location of the source in an archive file in Google Cloud Storage. Structure is documented below.</summary>
    [JsonPropertyName("storageSource")]
    public IList<V1beta1TriggerSpecForProviderBuildSourceStorageSource>? StorageSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildStepVolumes
{
    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuildStep
{
    /// <summary>Allow this build step to fail without failing the entire build if and only if the exit code is one of the specified codes. If allowFailure is also specified, this field will take precedence.</summary>
    [JsonPropertyName("allowExitCodes")]
    public IList<double>? AllowExitCodes { get; set; }

    /// <summary>Allow this build step to fail without failing the entire build. If false, the entire build will fail if this step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error information will be reported in the failureDetail field. allowExitCodes takes precedence over this field.</summary>
    [JsonPropertyName("allowFailure")]
    public bool? AllowFailure { get; set; }

    /// <summary>A list of arguments that will be presented to the step when it is started. If the image used to run the step's container has an entrypoint, the args are used as arguments to that entrypoint. If the image does not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be used as arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default entrypoint is used</summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Unique identifier for this build step, used in wait_for to reference this build step as a dependency.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint or args.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to continue to run until either it completes or the build itself times out.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Output only. Stores timing information for executing this build step.</summary>
    [JsonPropertyName("timing")]
    public string? Timing { get; set; }

    /// <summary>List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named volume in only one step is not valid as it is indicative of a build request with an incorrect configuration. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1TriggerSpecForProviderBuildStepVolumes>? Volumes { get; set; }

    /// <summary>The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build steps in wait_for have completed successfully. If wait_for is empty, this build step will start when all previous build steps in the Build.Steps list have completed successfully.</summary>
    [JsonPropertyName("waitFor")]
    public IList<string>? WaitFor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderBuild
{
    /// <summary>Artifacts produced by the build that should be uploaded upon successful completion of all build steps. Structure is documented below.</summary>
    [JsonPropertyName("artifacts")]
    public IList<V1beta1TriggerSpecForProviderBuildArtifacts>? Artifacts { get; set; }

    /// <summary>Secrets and secret environment variables. Structure is documented below.</summary>
    [JsonPropertyName("availableSecrets")]
    public IList<V1beta1TriggerSpecForProviderBuildAvailableSecrets>? AvailableSecrets { get; set; }

    /// <summary>A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the Build resource's results field. If any of the images fail to be pushed, the build status is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>Google Cloud Storage bucket where logs should be written. Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.</summary>
    [JsonPropertyName("logsBucket")]
    public string? LogsBucket { get; set; }

    /// <summary>Special options for this build. Structure is documented below.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1TriggerSpecForProviderBuildOptions>? Options { get; set; }

    /// <summary>TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be EXPIRED. The TTL starts ticking from createTime. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("queueTtl")]
    public string? QueueTtl { get; set; }

    /// <summary>Secrets to decrypt using Cloud Key Management Service. Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1TriggerSpecForProviderBuildSecret>? Secret { get; set; }

    /// <summary>The location of the source files to build. One of storageSource or repoSource must be provided. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1TriggerSpecForProviderBuildSource>? Source { get; set; }

    /// <summary>The operations to be performed on the workspace. Structure is documented below.</summary>
    [JsonPropertyName("step")]
    public IList<V1beta1TriggerSpecForProviderBuildStep>? Step { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a Build. These are not docker tags.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Amount of time that this build should be allowed to run, to second granularity. If this amount of time elapses, work on the build will cease and the build status will be TIMEOUT. This timeout must be equal to or greater than the sum of the timeouts for build steps within the build. The expected format is the number of seconds followed by s. Default time is ten minutes (600s).</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderGitFileSource
{
    /// <summary>The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The path of the file, with the repo root as the root of the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.</summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository. If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the filename . This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions If unspecified, the revision from which the trigger invocation originated is assumed to be the revision from which to read the specified path.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The URI of the repo . If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderGithubPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderGithubPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderGithub
{
    /// <summary>The resource name of the github enterprise config that should be applied to this installation. For example: "projects/{$projectId}/locations/{$locationId}/githubEnterpriseConfigs/{$configId}"</summary>
    [JsonPropertyName("enterpriseConfigResourceName")]
    public string? EnterpriseConfigResourceName { get; set; }

    /// <summary>Name of the repository. For example: The name for https://github.com/googlecloudplatform/cloud-builders is "cloud-builders".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the repository. For example: The owner for https://github.com/googlecloudplatform/cloud-builders is "googlecloudplatform".</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>filter to match changes in pull requests. Specify only one of pull_request or push. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerSpecForProviderGithubPullRequest>? PullRequest { get; set; }

    /// <summary>filter to match changes in refs, like branches or tags. Specify only one of pull_request or push. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerSpecForProviderGithubPush>? Push { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderPubsubConfigTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolveEnum
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
public partial class V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderPubsubConfigTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderPubsubConfig
{
    /// <summary>Service account that will make the push request.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta1TriggerSpecForProviderPubsubConfigTopicSelector? TopicSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderRepositoryEventConfigPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderRepositoryEventConfigPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderRepositoryEventConfig
{
    /// <summary>Contains filter properties for matching Pull Requests. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerSpecForProviderRepositoryEventConfigPullRequest>? PullRequest { get; set; }

    /// <summary>Contains filter properties for matching git pushes. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerSpecForProviderRepositoryEventConfigPush>? Push { get; set; }

    /// <summary>The resource name of the Repo API resource.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderServiceAccountRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecForProviderServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderServiceAccountRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderServiceAccountRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderServiceAccountSelectorPolicyResolveEnum
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
public partial class V1beta1TriggerSpecForProviderServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderServiceAccountSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderServiceAccountSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderSourceToBuild
{
    /// <summary>The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The branch or tag to use. Must start with "refs/" .</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.</summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The URI of the repo.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderTriggerTemplate
{
    /// <summary>Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is assumed.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name "default" is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderWebhookConfigSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolveEnum
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
public partial class V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderWebhookConfigSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderWebhookConfig
{
    /// <summary>Resource name for the secret required as a URL parameter.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1TriggerSpecForProviderWebhookConfigSecretSelector? SecretSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProvider
{
    /// <summary>Configuration for manual approval to start a build invocation of this BuildTrigger. Builds created by this trigger will require approval before they execute. Any user with a Cloud Build Approver role for the project can approve a build. Structure is documented below.</summary>
    [JsonPropertyName("approvalConfig")]
    public IList<V1beta1TriggerSpecForProviderApprovalConfig>? ApprovalConfig { get; set; }

    /// <summary>BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received. Structure is documented below.</summary>
    [JsonPropertyName("bitbucketServerTriggerConfig")]
    public IList<V1beta1TriggerSpecForProviderBitbucketServerTriggerConfig>? BitbucketServerTriggerConfig { get; set; }

    /// <summary>Contents of the build template. Either a filename or build template must be provided. Structure is documented below.</summary>
    [JsonPropertyName("build")]
    public IList<V1beta1TriggerSpecForProviderBuild>? Build { get; set; }

    /// <summary>Human-readable description of the trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the trigger is disabled or not. If true, the trigger will never result in a build.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Path, from the source root, to a file whose contents is used for the template. Either a filename or build template must be provided. Set this only when using trigger_template or github. When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>A Common Expression Language string. Used only with Pub/Sub and Webhook.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The file source describing the local or remote Build template. Structure is documented below.</summary>
    [JsonPropertyName("gitFileSource")]
    public IList<V1beta1TriggerSpecForProviderGitFileSource>? GitFileSource { get; set; }

    /// <summary>Describes the configuration of a trigger that creates a build whenever a GitHub event is received. One of trigger_template, github, pubsub_config or webhook_config must be provided. Structure is documented below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1TriggerSpecForProviderGithub>? Github { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for **. If ignoredFiles and changed files are both empty, then they are not used to determine whether or not to trigger a build. If ignoredFiles is not empty, then we ignore any files that match any of the ignored_file globs. If the change has no files that are outside of the ignoredFiles globs, then we do not trigger a build.</summary>
    [JsonPropertyName("ignoredFiles")]
    public IList<string>? IgnoredFiles { get; set; }

    /// <summary>Build logs will be sent back to GitHub as part of the checkrun result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or INCLUDE_BUILD_LOGS_WITH_STATUS Possible values are: INCLUDE_BUILD_LOGS_UNSPECIFIED, INCLUDE_BUILD_LOGS_WITH_STATUS.</summary>
    [JsonPropertyName("includeBuildLogs")]
    public string? IncludeBuildLogs { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for **. If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is empty, then as far as this filter is concerned, we should trigger the build. If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is not empty, then we make sure that at least one of those files matches a includedFiles glob. If not, then we do not trigger a build.</summary>
    [JsonPropertyName("includedFiles")]
    public IList<string>? IncludedFiles { get; set; }

    /// <summary>The Cloud Build location for the trigger. If not specified, "global" is used.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the trigger. Must be unique within the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>PubsubConfig describes the configuration of a trigger that creates a build whenever a Pub/Sub message is published. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("pubsubConfig")]
    public IList<V1beta1TriggerSpecForProviderPubsubConfig>? PubsubConfig { get; set; }

    /// <summary>The configuration of a trigger that creates a build whenever an event from Repo API is received. Structure is documented below.</summary>
    [JsonPropertyName("repositoryEventConfig")]
    public IList<V1beta1TriggerSpecForProviderRepositoryEventConfig>? RepositoryEventConfig { get; set; }

    /// <summary>The service account used for all user-controlled operations including triggers.patch, triggers.run, builds.create, and builds.cancel. If no service account is set, then the standard Cloud Build service account ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead. Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1TriggerSpecForProviderServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1TriggerSpecForProviderServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>The repo and ref of the repository from which to build. This field is used only for those triggers that do not respond to SCM events. Triggers that respond to such events build source at whatever commit caused the event. This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("sourceToBuild")]
    public IList<V1beta1TriggerSpecForProviderSourceToBuild>? SourceToBuild { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a BuildTrigger</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Template describing the types of source changes to trigger a build. Branch and tag names in trigger templates are interpreted as regular expressions. Any branch or tag change that matches that regular expression will trigger a build. One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("triggerTemplate")]
    public IList<V1beta1TriggerSpecForProviderTriggerTemplate>? TriggerTemplate { get; set; }

    /// <summary>WebhookConfig describes the configuration of a trigger that creates a build whenever a webhook is sent to a trigger's webhook URL. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("webhookConfig")]
    public IList<V1beta1TriggerSpecForProviderWebhookConfig>? WebhookConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderApprovalConfig
{
    /// <summary>Whether or not approval is needed. If this is set on a build, it will become pending when run, and will need to be explicitly approved to start.</summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBitbucketServerTriggerConfigPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBitbucketServerTriggerConfigPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBitbucketServerTriggerConfig
{
    /// <summary>The Bitbucket server config resource that this trigger config maps to.</summary>
    [JsonPropertyName("bitbucketServerConfigResource")]
    public string? BitbucketServerConfigResource { get; set; }

    /// <summary>Key of the project that the repo is in. For example: The key for https://mybitbucket.server/projects/TEST/repos/test-repo is "TEST".</summary>
    [JsonPropertyName("projectKey")]
    public string? ProjectKey { get; set; }

    /// <summary>Filter to match changes in pull requests. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerSpecInitProviderBitbucketServerTriggerConfigPullRequest>? PullRequest { get; set; }

    /// <summary>Filter to match changes in refs like branches, tags. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerSpecInitProviderBitbucketServerTriggerConfigPush>? Push { get; set; }

    /// <summary>Slug of the repository. A repository slug is a URL-friendly version of a repository name, automatically generated by Bitbucket for use in the URL. For example, if the repository name is 'test repo', in the URL it would become 'test-repo' as in https://mybitbucket.server/projects/TEST/repos/test-repo.</summary>
    [JsonPropertyName("repoSlug")]
    public string? RepoSlug { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildArtifactsMavenArtifacts
{
    /// <summary>Maven artifactId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Maven groupId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Maven version value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildArtifactsNpmPackages
{
    /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
    [JsonPropertyName("packagePath")]
    public string? PackagePath { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildArtifactsObjects
{
    /// <summary>Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/". Files in the workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Path globs used to match files in the build's workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildArtifactsPythonPackages
{
    /// <summary>Path globs used to match files in the build's workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildArtifacts
{
    /// <summary>A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the Build resource's results field. If any of the images fail to be pushed, the build status is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>A Maven artifact to upload to Artifact Registry upon successful completion of all build steps. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("mavenArtifacts")]
    public IList<V1beta1TriggerSpecInitProviderBuildArtifactsMavenArtifacts>? MavenArtifacts { get; set; }

    /// <summary>Npm package to upload to Artifact Registry upon successful completion of all build steps. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("npmPackages")]
    public IList<V1beta1TriggerSpecInitProviderBuildArtifactsNpmPackages>? NpmPackages { get; set; }

    /// <summary>A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in the workspace matching specified paths globs will be uploaded to the Cloud Storage location using the builder service account's credentials. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1TriggerSpecInitProviderBuildArtifactsObjects>? Objects { get; set; }

    /// <summary>Python package to upload to Artifact Registry upon successful completion of all build steps. A package can encapsulate multiple objects to be uploaded to a single repository. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("pythonPackages")]
    public IList<V1beta1TriggerSpecInitProviderBuildArtifactsPythonPackages>? PythonPackages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildAvailableSecretsSecretManager
{
    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public string? Env { get; set; }

    /// <summary>Resource name of the SecretVersion. In format: projects//secrets//versions/*</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildAvailableSecrets
{
    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretManager")]
    public IList<V1beta1TriggerSpecInitProviderBuildAvailableSecretsSecretManager>? SecretManager { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildOptionsVolumes
{
    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildOptions
{
    /// <summary>Requested disk size for the VM that runs the build. Note that this is NOT "disk free"; some of the space will be used by the operating system and build utilities. Also note that this is the minimum disk size that will be allocated for the build -- the build may run with a larger disk than requested. At present, the maximum disk size is 1000GB; builds that request more than the maximum are rejected with an error.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Option to specify whether or not to apply bash style string operations to the substitutions. NOTE this is always enabled for triggered builds and cannot be overridden in the build configuration file.</summary>
    [JsonPropertyName("dynamicSubstitutions")]
    public bool? DynamicSubstitutions { get; set; }

    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Option to define build log streaming behavior to Google Cloud Storage. Possible values are: STREAM_DEFAULT, STREAM_ON, STREAM_OFF.</summary>
    [JsonPropertyName("logStreamingOption")]
    public string? LogStreamingOption { get; set; }

    /// <summary>Option to specify the logging mode, which determines if and where build logs are stored. Possible values are: LOGGING_UNSPECIFIED, LEGACY, GCS_ONLY, STACKDRIVER_ONLY, CLOUD_LOGGING_ONLY, NONE.</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Compute Engine machine type on which to run the build.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Requested verifiability options. Possible values are: NOT_VERIFIED, VERIFIED.</summary>
    [JsonPropertyName("requestedVerifyOption")]
    public string? RequestedVerifyOption { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Requested hash for SourceProvenance. Each value may be one of: NONE, SHA256, MD5.</summary>
    [JsonPropertyName("sourceProvenanceHash")]
    public IList<string>? SourceProvenanceHash { get; set; }

    /// <summary>Option to specify behavior when there is an error in the substitution checks. NOTE this is always set to ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file. Possible values are: MUST_MATCH, ALLOW_LOOSE.</summary>
    [JsonPropertyName("substitutionOption")]
    public string? SubstitutionOption { get; set; }

    /// <summary>List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named volume in only one step is not valid as it is indicative of a build request with an incorrect configuration. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1TriggerSpecInitProviderBuildOptionsVolumes>? Volumes { get; set; }

    /// <summary>Option to specify a WorkerPool for the build. Format projects/{project}/workerPools/{workerPool} This field is experimental.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildSecret
{
    /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IDictionary<string, string>? SecretEnv { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildSourceRepoSource
{
    /// <summary>Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is assumed.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name "default" is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be used</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source. This object must be a gzipped archive file (.tar.gz) containing source to build.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildSource
{
    /// <summary>Location of the source in a Google Cloud Source Repository. Structure is documented below.</summary>
    [JsonPropertyName("repoSource")]
    public IList<V1beta1TriggerSpecInitProviderBuildSourceRepoSource>? RepoSource { get; set; }

    /// <summary>Location of the source in an archive file in Google Cloud Storage. Structure is documented below.</summary>
    [JsonPropertyName("storageSource")]
    public IList<V1beta1TriggerSpecInitProviderBuildSourceStorageSource>? StorageSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildStepVolumes
{
    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuildStep
{
    /// <summary>Allow this build step to fail without failing the entire build if and only if the exit code is one of the specified codes. If allowFailure is also specified, this field will take precedence.</summary>
    [JsonPropertyName("allowExitCodes")]
    public IList<double>? AllowExitCodes { get; set; }

    /// <summary>Allow this build step to fail without failing the entire build. If false, the entire build will fail if this step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error information will be reported in the failureDetail field. allowExitCodes takes precedence over this field.</summary>
    [JsonPropertyName("allowFailure")]
    public bool? AllowFailure { get; set; }

    /// <summary>A list of arguments that will be presented to the step when it is started. If the image used to run the step's container has an entrypoint, the args are used as arguments to that entrypoint. If the image does not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be used as arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default entrypoint is used</summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Unique identifier for this build step, used in wait_for to reference this build step as a dependency.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint or args.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to continue to run until either it completes or the build itself times out.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Output only. Stores timing information for executing this build step.</summary>
    [JsonPropertyName("timing")]
    public string? Timing { get; set; }

    /// <summary>List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named volume in only one step is not valid as it is indicative of a build request with an incorrect configuration. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1TriggerSpecInitProviderBuildStepVolumes>? Volumes { get; set; }

    /// <summary>The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build steps in wait_for have completed successfully. If wait_for is empty, this build step will start when all previous build steps in the Build.Steps list have completed successfully.</summary>
    [JsonPropertyName("waitFor")]
    public IList<string>? WaitFor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderBuild
{
    /// <summary>Artifacts produced by the build that should be uploaded upon successful completion of all build steps. Structure is documented below.</summary>
    [JsonPropertyName("artifacts")]
    public IList<V1beta1TriggerSpecInitProviderBuildArtifacts>? Artifacts { get; set; }

    /// <summary>Secrets and secret environment variables. Structure is documented below.</summary>
    [JsonPropertyName("availableSecrets")]
    public IList<V1beta1TriggerSpecInitProviderBuildAvailableSecrets>? AvailableSecrets { get; set; }

    /// <summary>A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the Build resource's results field. If any of the images fail to be pushed, the build status is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>Google Cloud Storage bucket where logs should be written. Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.</summary>
    [JsonPropertyName("logsBucket")]
    public string? LogsBucket { get; set; }

    /// <summary>Special options for this build. Structure is documented below.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1TriggerSpecInitProviderBuildOptions>? Options { get; set; }

    /// <summary>TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be EXPIRED. The TTL starts ticking from createTime. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("queueTtl")]
    public string? QueueTtl { get; set; }

    /// <summary>Secrets to decrypt using Cloud Key Management Service. Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1TriggerSpecInitProviderBuildSecret>? Secret { get; set; }

    /// <summary>The location of the source files to build. One of storageSource or repoSource must be provided. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1TriggerSpecInitProviderBuildSource>? Source { get; set; }

    /// <summary>The operations to be performed on the workspace. Structure is documented below.</summary>
    [JsonPropertyName("step")]
    public IList<V1beta1TriggerSpecInitProviderBuildStep>? Step { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a Build. These are not docker tags.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Amount of time that this build should be allowed to run, to second granularity. If this amount of time elapses, work on the build will cease and the build status will be TIMEOUT. This timeout must be equal to or greater than the sum of the timeouts for build steps within the build. The expected format is the number of seconds followed by s. Default time is ten minutes (600s).</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderGitFileSource
{
    /// <summary>The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The path of the file, with the repo root as the root of the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.</summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository. If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the filename . This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions If unspecified, the revision from which the trigger invocation originated is assumed to be the revision from which to read the specified path.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The URI of the repo . If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderGithubPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderGithubPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderGithub
{
    /// <summary>The resource name of the github enterprise config that should be applied to this installation. For example: "projects/{$projectId}/locations/{$locationId}/githubEnterpriseConfigs/{$configId}"</summary>
    [JsonPropertyName("enterpriseConfigResourceName")]
    public string? EnterpriseConfigResourceName { get; set; }

    /// <summary>Name of the repository. For example: The name for https://github.com/googlecloudplatform/cloud-builders is "cloud-builders".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the repository. For example: The owner for https://github.com/googlecloudplatform/cloud-builders is "googlecloudplatform".</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>filter to match changes in pull requests. Specify only one of pull_request or push. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerSpecInitProviderGithubPullRequest>? PullRequest { get; set; }

    /// <summary>filter to match changes in refs, like branches or tags. Specify only one of pull_request or push. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerSpecInitProviderGithubPush>? Push { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderPubsubConfigTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolveEnum
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
public partial class V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderPubsubConfigTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderPubsubConfig
{
    /// <summary>Service account that will make the push request.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta1TriggerSpecInitProviderPubsubConfigTopicSelector? TopicSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderRepositoryEventConfigPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderRepositoryEventConfigPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderRepositoryEventConfig
{
    /// <summary>Contains filter properties for matching Pull Requests. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerSpecInitProviderRepositoryEventConfigPullRequest>? PullRequest { get; set; }

    /// <summary>Contains filter properties for matching git pushes. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerSpecInitProviderRepositoryEventConfigPush>? Push { get; set; }

    /// <summary>The resource name of the Repo API resource.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderServiceAccountRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecInitProviderServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderServiceAccountRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderServiceAccountRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicyResolveEnum
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
public partial class V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderSourceToBuild
{
    /// <summary>The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The branch or tag to use. Must start with "refs/" .</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.</summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The URI of the repo.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderTriggerTemplate
{
    /// <summary>Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is assumed.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name "default" is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderWebhookConfigSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolveEnum
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
public partial class V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolveEnum>))]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderWebhookConfigSecretSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderWebhookConfig
{
    /// <summary>Resource name for the secret required as a URL parameter.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta1TriggerSpecInitProviderWebhookConfigSecretSelector? SecretSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProvider
{
    /// <summary>Configuration for manual approval to start a build invocation of this BuildTrigger. Builds created by this trigger will require approval before they execute. Any user with a Cloud Build Approver role for the project can approve a build. Structure is documented below.</summary>
    [JsonPropertyName("approvalConfig")]
    public IList<V1beta1TriggerSpecInitProviderApprovalConfig>? ApprovalConfig { get; set; }

    /// <summary>BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received. Structure is documented below.</summary>
    [JsonPropertyName("bitbucketServerTriggerConfig")]
    public IList<V1beta1TriggerSpecInitProviderBitbucketServerTriggerConfig>? BitbucketServerTriggerConfig { get; set; }

    /// <summary>Contents of the build template. Either a filename or build template must be provided. Structure is documented below.</summary>
    [JsonPropertyName("build")]
    public IList<V1beta1TriggerSpecInitProviderBuild>? Build { get; set; }

    /// <summary>Human-readable description of the trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the trigger is disabled or not. If true, the trigger will never result in a build.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Path, from the source root, to a file whose contents is used for the template. Either a filename or build template must be provided. Set this only when using trigger_template or github. When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>A Common Expression Language string. Used only with Pub/Sub and Webhook.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The file source describing the local or remote Build template. Structure is documented below.</summary>
    [JsonPropertyName("gitFileSource")]
    public IList<V1beta1TriggerSpecInitProviderGitFileSource>? GitFileSource { get; set; }

    /// <summary>Describes the configuration of a trigger that creates a build whenever a GitHub event is received. One of trigger_template, github, pubsub_config or webhook_config must be provided. Structure is documented below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1TriggerSpecInitProviderGithub>? Github { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for **. If ignoredFiles and changed files are both empty, then they are not used to determine whether or not to trigger a build. If ignoredFiles is not empty, then we ignore any files that match any of the ignored_file globs. If the change has no files that are outside of the ignoredFiles globs, then we do not trigger a build.</summary>
    [JsonPropertyName("ignoredFiles")]
    public IList<string>? IgnoredFiles { get; set; }

    /// <summary>Build logs will be sent back to GitHub as part of the checkrun result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or INCLUDE_BUILD_LOGS_WITH_STATUS Possible values are: INCLUDE_BUILD_LOGS_UNSPECIFIED, INCLUDE_BUILD_LOGS_WITH_STATUS.</summary>
    [JsonPropertyName("includeBuildLogs")]
    public string? IncludeBuildLogs { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for **. If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is empty, then as far as this filter is concerned, we should trigger the build. If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is not empty, then we make sure that at least one of those files matches a includedFiles glob. If not, then we do not trigger a build.</summary>
    [JsonPropertyName("includedFiles")]
    public IList<string>? IncludedFiles { get; set; }

    /// <summary>The Cloud Build location for the trigger. If not specified, "global" is used.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the trigger. Must be unique within the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>PubsubConfig describes the configuration of a trigger that creates a build whenever a Pub/Sub message is published. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("pubsubConfig")]
    public IList<V1beta1TriggerSpecInitProviderPubsubConfig>? PubsubConfig { get; set; }

    /// <summary>The configuration of a trigger that creates a build whenever an event from Repo API is received. Structure is documented below.</summary>
    [JsonPropertyName("repositoryEventConfig")]
    public IList<V1beta1TriggerSpecInitProviderRepositoryEventConfig>? RepositoryEventConfig { get; set; }

    /// <summary>The service account used for all user-controlled operations including triggers.patch, triggers.run, builds.create, and builds.cancel. If no service account is set, then the standard Cloud Build service account ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead. Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1TriggerSpecInitProviderServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1TriggerSpecInitProviderServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>The repo and ref of the repository from which to build. This field is used only for those triggers that do not respond to SCM events. Triggers that respond to such events build source at whatever commit caused the event. This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("sourceToBuild")]
    public IList<V1beta1TriggerSpecInitProviderSourceToBuild>? SourceToBuild { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a BuildTrigger</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Template describing the types of source changes to trigger a build. Branch and tag names in trigger templates are interpreted as regular expressions. Any branch or tag change that matches that regular expression will trigger a build. One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("triggerTemplate")]
    public IList<V1beta1TriggerSpecInitProviderTriggerTemplate>? TriggerTemplate { get; set; }

    /// <summary>WebhookConfig describes the configuration of a trigger that creates a build whenever a webhook is sent to a trigger's webhook URL. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("webhookConfig")]
    public IList<V1beta1TriggerSpecInitProviderWebhookConfig>? WebhookConfig { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1TriggerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TriggerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TriggerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TriggerSpec defines the desired state of Trigger</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerSpecDeletionPolicyEnum>))]
    public V1beta1TriggerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TriggerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TriggerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TriggerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TriggerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TriggerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TriggerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderApprovalConfig
{
    /// <summary>Whether or not approval is needed. If this is set on a build, it will become pending when run, and will need to be explicitly approved to start.</summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBitbucketServerTriggerConfigPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBitbucketServerTriggerConfigPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBitbucketServerTriggerConfig
{
    /// <summary>The Bitbucket server config resource that this trigger config maps to.</summary>
    [JsonPropertyName("bitbucketServerConfigResource")]
    public string? BitbucketServerConfigResource { get; set; }

    /// <summary>Key of the project that the repo is in. For example: The key for https://mybitbucket.server/projects/TEST/repos/test-repo is "TEST".</summary>
    [JsonPropertyName("projectKey")]
    public string? ProjectKey { get; set; }

    /// <summary>Filter to match changes in pull requests. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerStatusAtProviderBitbucketServerTriggerConfigPullRequest>? PullRequest { get; set; }

    /// <summary>Filter to match changes in refs like branches, tags. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerStatusAtProviderBitbucketServerTriggerConfigPush>? Push { get; set; }

    /// <summary>Slug of the repository. A repository slug is a URL-friendly version of a repository name, automatically generated by Bitbucket for use in the URL. For example, if the repository name is 'test repo', in the URL it would become 'test-repo' as in https://mybitbucket.server/projects/TEST/repos/test-repo.</summary>
    [JsonPropertyName("repoSlug")]
    public string? RepoSlug { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildArtifactsMavenArtifacts
{
    /// <summary>Maven artifactId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Maven groupId value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Maven version value used when uploading the artifact to Artifact Registry.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildArtifactsNpmPackages
{
    /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
    [JsonPropertyName("packagePath")]
    public string? PackagePath { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildArtifactsObjectsTiming
{
    /// <summary>End of time span. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Start of time span. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildArtifactsObjects
{
    /// <summary>Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/". Files in the workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Path globs used to match files in the build's workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>Output only. Stores timing information for executing this build step.</summary>
    [JsonPropertyName("timing")]
    public IList<V1beta1TriggerStatusAtProviderBuildArtifactsObjectsTiming>? Timing { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildArtifactsPythonPackages
{
    /// <summary>Path globs used to match files in the build's workspace. For Python/ Twine, this is usually dist/*, and sometimes additionally an .asc file.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildArtifacts
{
    /// <summary>A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the Build resource's results field. If any of the images fail to be pushed, the build status is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>A Maven artifact to upload to Artifact Registry upon successful completion of all build steps. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("mavenArtifacts")]
    public IList<V1beta1TriggerStatusAtProviderBuildArtifactsMavenArtifacts>? MavenArtifacts { get; set; }

    /// <summary>Npm package to upload to Artifact Registry upon successful completion of all build steps. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("npmPackages")]
    public IList<V1beta1TriggerStatusAtProviderBuildArtifactsNpmPackages>? NpmPackages { get; set; }

    /// <summary>A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in the workspace matching specified paths globs will be uploaded to the Cloud Storage location using the builder service account's credentials. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1TriggerStatusAtProviderBuildArtifactsObjects>? Objects { get; set; }

    /// <summary>Python package to upload to Artifact Registry upon successful completion of all build steps. A package can encapsulate multiple objects to be uploaded to a single repository. The location and generation of the uploaded objects will be stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE. Structure is documented below.</summary>
    [JsonPropertyName("pythonPackages")]
    public IList<V1beta1TriggerStatusAtProviderBuildArtifactsPythonPackages>? PythonPackages { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildAvailableSecretsSecretManager
{
    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public string? Env { get; set; }

    /// <summary>Resource name of the SecretVersion. In format: projects//secrets//versions/*</summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildAvailableSecrets
{
    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager. Structure is documented below.</summary>
    [JsonPropertyName("secretManager")]
    public IList<V1beta1TriggerStatusAtProviderBuildAvailableSecretsSecretManager>? SecretManager { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildOptionsVolumes
{
    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildOptions
{
    /// <summary>Requested disk size for the VM that runs the build. Note that this is NOT "disk free"; some of the space will be used by the operating system and build utilities. Also note that this is the minimum disk size that will be allocated for the build -- the build may run with a larger disk than requested. At present, the maximum disk size is 1000GB; builds that request more than the maximum are rejected with an error.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Option to specify whether or not to apply bash style string operations to the substitutions. NOTE this is always enabled for triggered builds and cannot be overridden in the build configuration file.</summary>
    [JsonPropertyName("dynamicSubstitutions")]
    public bool? DynamicSubstitutions { get; set; }

    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Option to define build log streaming behavior to Google Cloud Storage. Possible values are: STREAM_DEFAULT, STREAM_ON, STREAM_OFF.</summary>
    [JsonPropertyName("logStreamingOption")]
    public string? LogStreamingOption { get; set; }

    /// <summary>Option to specify the logging mode, which determines if and where build logs are stored. Possible values are: LOGGING_UNSPECIFIED, LEGACY, GCS_ONLY, STACKDRIVER_ONLY, CLOUD_LOGGING_ONLY, NONE.</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Compute Engine machine type on which to run the build.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Requested verifiability options. Possible values are: NOT_VERIFIED, VERIFIED.</summary>
    [JsonPropertyName("requestedVerifyOption")]
    public string? RequestedVerifyOption { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Requested hash for SourceProvenance. Each value may be one of: NONE, SHA256, MD5.</summary>
    [JsonPropertyName("sourceProvenanceHash")]
    public IList<string>? SourceProvenanceHash { get; set; }

    /// <summary>Option to specify behavior when there is an error in the substitution checks. NOTE this is always set to ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file. Possible values are: MUST_MATCH, ALLOW_LOOSE.</summary>
    [JsonPropertyName("substitutionOption")]
    public string? SubstitutionOption { get; set; }

    /// <summary>List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named volume in only one step is not valid as it is indicative of a build request with an incorrect configuration. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1TriggerStatusAtProviderBuildOptionsVolumes>? Volumes { get; set; }

    /// <summary>Option to specify a WorkerPool for the build. Format projects/{project}/workerPools/{workerPool} This field is experimental.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildSecret
{
    /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IDictionary<string, string>? SecretEnv { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildSourceRepoSource
{
    /// <summary>Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is assumed.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name "default" is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be used</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source. This object must be a gzipped archive file (.tar.gz) containing source to build.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildSource
{
    /// <summary>Location of the source in a Google Cloud Source Repository. Structure is documented below.</summary>
    [JsonPropertyName("repoSource")]
    public IList<V1beta1TriggerStatusAtProviderBuildSourceRepoSource>? RepoSource { get; set; }

    /// <summary>Location of the source in an archive file in Google Cloud Storage. Structure is documented below.</summary>
    [JsonPropertyName("storageSource")]
    public IList<V1beta1TriggerStatusAtProviderBuildSourceStorageSource>? StorageSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildStepVolumes
{
    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuildStep
{
    /// <summary>Allow this build step to fail without failing the entire build if and only if the exit code is one of the specified codes. If allowFailure is also specified, this field will take precedence.</summary>
    [JsonPropertyName("allowExitCodes")]
    public IList<double>? AllowExitCodes { get; set; }

    /// <summary>Allow this build step to fail without failing the entire build. If false, the entire build will fail if this step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error information will be reported in the failureDetail field. allowExitCodes takes precedence over this field.</summary>
    [JsonPropertyName("allowFailure")]
    public bool? AllowFailure { get; set; }

    /// <summary>A list of arguments that will be presented to the step when it is started. If the image used to run the step's container has an entrypoint, the args are used as arguments to that entrypoint. If the image does not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be used as arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default entrypoint is used</summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>A list of environment variable definitions to be used when running a step. The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Unique identifier for this build step, used in wait_for to reference this build step as a dependency.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint or args.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to continue to run until either it completes or the build itself times out.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Output only. Stores timing information for executing this build step.</summary>
    [JsonPropertyName("timing")]
    public string? Timing { get; set; }

    /// <summary>List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named volume in only one step is not valid as it is indicative of a build request with an incorrect configuration. Structure is documented below.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1TriggerStatusAtProviderBuildStepVolumes>? Volumes { get; set; }

    /// <summary>The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build steps in wait_for have completed successfully. If wait_for is empty, this build step will start when all previous build steps in the Build.Steps list have completed successfully.</summary>
    [JsonPropertyName("waitFor")]
    public IList<string>? WaitFor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderBuild
{
    /// <summary>Artifacts produced by the build that should be uploaded upon successful completion of all build steps. Structure is documented below.</summary>
    [JsonPropertyName("artifacts")]
    public IList<V1beta1TriggerStatusAtProviderBuildArtifacts>? Artifacts { get; set; }

    /// <summary>Secrets and secret environment variables. Structure is documented below.</summary>
    [JsonPropertyName("availableSecrets")]
    public IList<V1beta1TriggerStatusAtProviderBuildAvailableSecrets>? AvailableSecrets { get; set; }

    /// <summary>A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the Build resource's results field. If any of the images fail to be pushed, the build status is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>Google Cloud Storage bucket where logs should be written. Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.</summary>
    [JsonPropertyName("logsBucket")]
    public string? LogsBucket { get; set; }

    /// <summary>Special options for this build. Structure is documented below.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1TriggerStatusAtProviderBuildOptions>? Options { get; set; }

    /// <summary>TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be EXPIRED. The TTL starts ticking from createTime. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("queueTtl")]
    public string? QueueTtl { get; set; }

    /// <summary>Secrets to decrypt using Cloud Key Management Service. Structure is documented below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1TriggerStatusAtProviderBuildSecret>? Secret { get; set; }

    /// <summary>The location of the source files to build. One of storageSource or repoSource must be provided. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1TriggerStatusAtProviderBuildSource>? Source { get; set; }

    /// <summary>The operations to be performed on the workspace. Structure is documented below.</summary>
    [JsonPropertyName("step")]
    public IList<V1beta1TriggerStatusAtProviderBuildStep>? Step { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a Build. These are not docker tags.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Amount of time that this build should be allowed to run, to second granularity. If this amount of time elapses, work on the build will cease and the build status will be TIMEOUT. This timeout must be equal to or greater than the sum of the timeouts for build steps within the build. The expected format is the number of seconds followed by s. Default time is ten minutes (600s).</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderGitFileSource
{
    /// <summary>The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The path of the file, with the repo root as the root of the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.</summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository. If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the filename . This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions If unspecified, the revision from which the trigger invocation originated is assumed to be the revision from which to read the specified path.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The URI of the repo . If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderGithubPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderGithubPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderGithub
{
    /// <summary>The resource name of the github enterprise config that should be applied to this installation. For example: "projects/{$projectId}/locations/{$locationId}/githubEnterpriseConfigs/{$configId}"</summary>
    [JsonPropertyName("enterpriseConfigResourceName")]
    public string? EnterpriseConfigResourceName { get; set; }

    /// <summary>Name of the repository. For example: The name for https://github.com/googlecloudplatform/cloud-builders is "cloud-builders".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the repository. For example: The owner for https://github.com/googlecloudplatform/cloud-builders is "googlecloudplatform".</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>filter to match changes in pull requests. Specify only one of pull_request or push. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerStatusAtProviderGithubPullRequest>? PullRequest { get; set; }

    /// <summary>filter to match changes in refs, like branches or tags. Specify only one of pull_request or push. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerStatusAtProviderGithubPush>? Push { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderPubsubConfig
{
    /// <summary>Service account that will make the push request.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>(Output) Potential issues with the underlying Pub/Sub subscription configuration. Only populated on get requests.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>(Output) Output only. Name of the subscription.</summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }

    /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderRepositoryEventConfigPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values are: COMMENTS_DISABLED, COMMENTS_ENABLED, COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY.</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderRepositoryEventConfigPush
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderRepositoryEventConfig
{
    /// <summary>Contains filter properties for matching Pull Requests. Structure is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1TriggerStatusAtProviderRepositoryEventConfigPullRequest>? PullRequest { get; set; }

    /// <summary>Contains filter properties for matching git pushes. Structure is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1TriggerStatusAtProviderRepositoryEventConfigPush>? Push { get; set; }

    /// <summary>The resource name of the Repo API resource.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderSourceToBuild
{
    /// <summary>The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfig")]
    public string? BitbucketServerConfig { get; set; }

    /// <summary>The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}. projects/{project}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public string? GithubEnterpriseConfig { get; set; }

    /// <summary>The branch or tag to use. Must start with "refs/" .</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values are: UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER.</summary>
    [JsonPropertyName("repoType")]
    public string? RepoType { get; set; }

    /// <summary>The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>The URI of the repo.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderTriggerTemplate
{
    /// <summary>Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is assumed.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository. If omitted, the name "default" is assumed.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderWebhookConfig
{
    /// <summary>Resource name for the secret required as a URL parameter.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>(Output) Potential issues with the underlying Pub/Sub subscription configuration. Only populated on get requests.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProvider
{
    /// <summary>Configuration for manual approval to start a build invocation of this BuildTrigger. Builds created by this trigger will require approval before they execute. Any user with a Cloud Build Approver role for the project can approve a build. Structure is documented below.</summary>
    [JsonPropertyName("approvalConfig")]
    public IList<V1beta1TriggerStatusAtProviderApprovalConfig>? ApprovalConfig { get; set; }

    /// <summary>BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received. Structure is documented below.</summary>
    [JsonPropertyName("bitbucketServerTriggerConfig")]
    public IList<V1beta1TriggerStatusAtProviderBitbucketServerTriggerConfig>? BitbucketServerTriggerConfig { get; set; }

    /// <summary>Contents of the build template. Either a filename or build template must be provided. Structure is documented below.</summary>
    [JsonPropertyName("build")]
    public IList<V1beta1TriggerStatusAtProviderBuild>? Build { get; set; }

    /// <summary>Time when the trigger was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Human-readable description of the trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether the trigger is disabled or not. If true, the trigger will never result in a build.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Path, from the source root, to a file whose contents is used for the template. Either a filename or build template must be provided. Set this only when using trigger_template or github. When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>A Common Expression Language string. Used only with Pub/Sub and Webhook.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The file source describing the local or remote Build template. Structure is documented below.</summary>
    [JsonPropertyName("gitFileSource")]
    public IList<V1beta1TriggerStatusAtProviderGitFileSource>? GitFileSource { get; set; }

    /// <summary>Describes the configuration of a trigger that creates a build whenever a GitHub event is received. One of trigger_template, github, pubsub_config or webhook_config must be provided. Structure is documented below.</summary>
    [JsonPropertyName("github")]
    public IList<V1beta1TriggerStatusAtProviderGithub>? Github { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/triggers/{{trigger_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for **. If ignoredFiles and changed files are both empty, then they are not used to determine whether or not to trigger a build. If ignoredFiles is not empty, then we ignore any files that match any of the ignored_file globs. If the change has no files that are outside of the ignoredFiles globs, then we do not trigger a build.</summary>
    [JsonPropertyName("ignoredFiles")]
    public IList<string>? IgnoredFiles { get; set; }

    /// <summary>Build logs will be sent back to GitHub as part of the checkrun result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or INCLUDE_BUILD_LOGS_WITH_STATUS Possible values are: INCLUDE_BUILD_LOGS_UNSPECIFIED, INCLUDE_BUILD_LOGS_WITH_STATUS.</summary>
    [JsonPropertyName("includeBuildLogs")]
    public string? IncludeBuildLogs { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for **. If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is empty, then as far as this filter is concerned, we should trigger the build. If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is not empty, then we make sure that at least one of those files matches a includedFiles glob. If not, then we do not trigger a build.</summary>
    [JsonPropertyName("includedFiles")]
    public IList<string>? IncludedFiles { get; set; }

    /// <summary>The Cloud Build location for the trigger. If not specified, "global" is used.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name of the trigger. Must be unique within the project.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>PubsubConfig describes the configuration of a trigger that creates a build whenever a Pub/Sub message is published. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("pubsubConfig")]
    public IList<V1beta1TriggerStatusAtProviderPubsubConfig>? PubsubConfig { get; set; }

    /// <summary>The configuration of a trigger that creates a build whenever an event from Repo API is received. Structure is documented below.</summary>
    [JsonPropertyName("repositoryEventConfig")]
    public IList<V1beta1TriggerStatusAtProviderRepositoryEventConfig>? RepositoryEventConfig { get; set; }

    /// <summary>The service account used for all user-controlled operations including triggers.patch, triggers.run, builds.create, and builds.cancel. If no service account is set, then the standard Cloud Build service account ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead. Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The repo and ref of the repository from which to build. This field is used only for those triggers that do not respond to SCM events. Triggers that respond to such events build source at whatever commit caused the event. This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("sourceToBuild")]
    public IList<V1beta1TriggerStatusAtProviderSourceToBuild>? SourceToBuild { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a BuildTrigger</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The unique identifier for the trigger.</summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }

    /// <summary>Template describing the types of source changes to trigger a build. Branch and tag names in trigger templates are interpreted as regular expressions. Any branch or tag change that matches that regular expression will trigger a build. One of trigger_template, github, pubsub_config, webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("triggerTemplate")]
    public IList<V1beta1TriggerStatusAtProviderTriggerTemplate>? TriggerTemplate { get; set; }

    /// <summary>WebhookConfig describes the configuration of a trigger that creates a build whenever a webhook is sent to a trigger's webhook URL. One of trigger_template, github, pubsub_config webhook_config or source_to_build must be provided. Structure is documented below.</summary>
    [JsonPropertyName("webhookConfig")]
    public IList<V1beta1TriggerStatusAtProviderWebhookConfig>? WebhookConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusConditions
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

/// <summary>TriggerStatus defines the observed state of Trigger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TriggerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Trigger is the Schema for the Triggers API. Configuration for an automated build in response to source repository changes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Trigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TriggerSpec>, IStatus<V1beta1TriggerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Trigger";
    public const string KubeGroup = "cloudbuild.gcp.upbound.io";
    public const string KubePluralName = "triggers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerSpec defines the desired state of Trigger</summary>
    [JsonPropertyName("spec")]
    public V1beta1TriggerSpec Spec { get; set; }

    /// <summary>TriggerStatus defines the observed state of Trigger.</summary>
    [JsonPropertyName("status")]
    public V1beta1TriggerStatus? Status { get; set; }
}