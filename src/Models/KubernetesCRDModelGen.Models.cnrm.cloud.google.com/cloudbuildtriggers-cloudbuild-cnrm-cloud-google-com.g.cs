using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudbuild.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerMetadata
{
}

/// <summary>Configuration for manual approval to start a build invocation of this BuildTrigger. Builds created by this trigger will require approval before they execute. Any user with a Cloud Build Approver role for the project can approve a build.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecApprovalConfig
{
    /// <summary>Whether or not approval is needed. If this is set on a build, it will become pending when run, and will need to be explicitly approved to start.</summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }
}

/// <summary>Only `external` field is supported to configure the reference.  The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBitbucketServerTriggerConfigBitbucketServerConfigResourceRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildBitbucketServerConfig` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Filter to match changes in pull requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBitbucketServerTriggerConfigPullRequest
{
    /// <summary>Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax.</summary>
    [JsonPropertyName("branch")]
    public string Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment /gcbrun. Possible values: ["COMMENTS_DISABLED", "COMMENTS_ENABLED", "COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY"].</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>If true, branches that do NOT match the git_ref will trigger a build.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>Filter to match changes in refs like branches, tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBitbucketServerTriggerConfigPush
{
    /// <summary>Regex of branches to match.  Specify only one of branch or tag.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>When true, only trigger a build if the revision regex does NOT match the gitRef regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match.  Specify only one of branch or tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBitbucketServerTriggerConfig
{
    /// <summary>Only `external` field is supported to configure the reference.  The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfigResourceRef")]
    public CloudBuildTriggerSpecBitbucketServerTriggerConfigBitbucketServerConfigResourceRef BitbucketServerConfigResourceRef { get; set; }

    /// <summary>Key of the project that the repo is in. For example: The key for https://mybitbucket.server/projects/TEST/repos/test-repo is "TEST".</summary>
    [JsonPropertyName("projectKey")]
    public string ProjectKey { get; set; }

    /// <summary>Filter to match changes in pull requests.</summary>
    [JsonPropertyName("pullRequest")]
    public CloudBuildTriggerSpecBitbucketServerTriggerConfigPullRequest? PullRequest { get; set; }

    /// <summary>Filter to match changes in refs like branches, tags.</summary>
    [JsonPropertyName("push")]
    public CloudBuildTriggerSpecBitbucketServerTriggerConfigPush? Push { get; set; }

    /// <summary>Slug of the repository. A repository slug is a URL-friendly version of a repository name, automatically generated by Bitbucket for use in the URL. For example, if the repository name is 'test repo', in the URL it would become 'test-repo' as in https://mybitbucket.server/projects/TEST/repos/test-repo.</summary>
    [JsonPropertyName("repoSlug")]
    public string RepoSlug { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildArtifactsObjectsTiming
{
    /// <summary>End of time span.  A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Start of time span.  A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.  Files in the workspace matching specified paths globs will be uploaded to the Cloud Storage location using the builder service account's credentials.  The location and generation of the uploaded objects will be stored in the Build resource's results field.  If any objects fail to be pushed, the build is marked FAILURE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildArtifactsObjects
{
    /// <summary>Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/".  Files in the workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Path globs used to match files in the build's workspace.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>Output only. Stores timing information for pushing all artifact objects.</summary>
    [JsonPropertyName("timing")]
    public IList<CloudBuildTriggerSpecBuildArtifactsObjectsTiming>? Timing { get; set; }
}

/// <summary>Artifacts produced by the build that should be uploaded upon successful completion of all build steps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildArtifacts
{
    /// <summary>A list of images to be pushed upon the successful completion of all build steps.  The images will be pushed using the builder service account's credentials.  The digests of the pushed images will be stored in the Build resource's results field.  If any of the images fail to be pushed, the build is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps.  Files in the workspace matching specified paths globs will be uploaded to the Cloud Storage location using the builder service account's credentials.  The location and generation of the uploaded objects will be stored in the Build resource's results field.  If any objects fail to be pushed, the build is marked FAILURE.</summary>
    [JsonPropertyName("objects")]
    public CloudBuildTriggerSpecBuildArtifactsObjects? Objects { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildAvailableSecretsSecretManagerVersionRef
{
    /// <summary>Allowed value: The `name` field of a `SecretManagerSecretVersion` resource.</summary>
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
public partial class CloudBuildTriggerSpecBuildAvailableSecretsSecretManager
{
    /// <summary>Environment variable name to associate with the secret. Secret environment variables must be unique across all of a build's secrets, and must be used by at least one build step.</summary>
    [JsonPropertyName("env")]
    public string Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionRef")]
    public CloudBuildTriggerSpecBuildAvailableSecretsSecretManagerVersionRef VersionRef { get; set; }
}

/// <summary>Secrets and secret environment variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildAvailableSecrets
{
    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager.</summary>
    [JsonPropertyName("secretManager")]
    public IList<CloudBuildTriggerSpecBuildAvailableSecretsSecretManager> SecretManager { get; set; }
}

/// <summary>Google Cloud Storage bucket where logs should be written. Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildLogsBucketRef
{
    /// <summary>Allowed value: The `url` field of a `StorageBucket` resource.</summary>
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
public partial class CloudBuildTriggerSpecBuildOptionsVolumes
{
    /// <summary>Name of the volume to mount.  Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path at which to mount the volume.  Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Special options for this build.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildOptions
{
    /// <summary>Requested disk size for the VM that runs the build. Note that this is NOT "disk free"; some of the space will be used by the operating system and build utilities. Also note that this is the minimum disk size that will be allocated for the build -- the build may run with a larger disk than requested. At present, the maximum disk size is 1000GB; builds that request more than the maximum are rejected with an error.</summary>
    [JsonPropertyName("diskSizeGb")]
    public int? DiskSizeGb { get; set; }

    /// <summary>Option to specify whether or not to apply bash style string operations to the substitutions.  NOTE this is always enabled for triggered builds and cannot be overridden in the build configuration file.</summary>
    [JsonPropertyName("dynamicSubstitutions")]
    public bool? DynamicSubstitutions { get; set; }

    /// <summary>A list of global environment variable definitions that will exist for all build steps in this build. If a variable is defined in both globally and in a build step, the variable will use the build step value.  The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Option to define build log streaming behavior to Google Cloud Storage. Possible values: ["STREAM_DEFAULT", "STREAM_ON", "STREAM_OFF"].</summary>
    [JsonPropertyName("logStreamingOption")]
    public string? LogStreamingOption { get; set; }

    /// <summary>Option to specify the logging mode, which determines if and where build logs are stored. Possible values: ["LOGGING_UNSPECIFIED", "LEGACY", "GCS_ONLY", "STACKDRIVER_ONLY", "CLOUD_LOGGING_ONLY", "NONE"].</summary>
    [JsonPropertyName("logging")]
    public string? Logging { get; set; }

    /// <summary>Compute Engine machine type on which to run the build.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Requested verifiability options. Possible values: ["NOT_VERIFIED", "VERIFIED"].</summary>
    [JsonPropertyName("requestedVerifyOption")]
    public string? RequestedVerifyOption { get; set; }

    /// <summary>A list of global environment variables, which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's Secret. These variables will be available to all build steps in this build.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Requested hash for SourceProvenance. Possible values: ["NONE", "SHA256", "MD5"].</summary>
    [JsonPropertyName("sourceProvenanceHash")]
    public IList<string>? SourceProvenanceHash { get; set; }

    /// <summary>Option to specify behavior when there is an error in the substitution checks.  NOTE this is always set to ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file. Possible values: ["MUST_MATCH", "ALLOW_LOOSE"].</summary>
    [JsonPropertyName("substitutionOption")]
    public string? SubstitutionOption { get; set; }

    /// <summary>Global list of volumes to mount for ALL build steps  Each volume is created as an empty volume prior to starting the build process. Upon completion of the build, volumes and their contents are discarded. Global volume names and paths cannot conflict with the volumes defined a build step.  Using a global volume in a build with only one step is not valid as it is indicative of a build request with an incorrect configuration.</summary>
    [JsonPropertyName("volumes")]
    public IList<CloudBuildTriggerSpecBuildOptionsVolumes>? Volumes { get; set; }

    /// <summary>Option to specify a WorkerPool for the build. Format projects/{project}/workerPools/{workerPool}  This field is experimental.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

/// <summary>KMS crypto key to use to decrypt these envs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildSecretKmsKeyRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildSecret
{
    /// <summary>KMS crypto key to use to decrypt these envs.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public CloudBuildTriggerSpecBuildSecretKmsKeyRef KmsKeyRef { get; set; }

    /// <summary>Map of environment variable name to its encrypted value. Secret environment variables must be unique across all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size. There can be at most 100 secret values across all of a build's secrets.</summary>
    [JsonPropertyName("secretEnv")]
    public IDictionary<string, string>? SecretEnv { get; set; }
}

/// <summary>The desired Cloud Source Repository. If omitted, "default" is assumed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildSourceRepoSourceRepoRef
{
    /// <summary>Allowed value: The `name` field of a `SourceRepoRepository` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Location of the source in a Google Cloud Source Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildSourceRepoSource
{
    /// <summary>Regex matching branches to build. Exactly one a of branch name, tag, or commit SHA must be provided. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one a of branch name, tag, or commit SHA must be provided.</summary>
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

    /// <summary>The desired Cloud Source Repository. If omitted, "default" is assumed.</summary>
    [JsonPropertyName("repoRef")]
    public CloudBuildTriggerSpecBuildSourceRepoSourceRepoRef RepoRef { get; set; }

    /// <summary>Substitutions to use in a triggered build. Should only be used with triggers.run.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Regex matching tags to build. Exactly one a of branch name, tag, or commit SHA must be provided. The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Google Cloud Storage bucket containing the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildSourceStorageSourceBucketRef
{
    /// <summary>Allowed value: The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Location of the source in an archive file in Google Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucketRef")]
    public CloudBuildTriggerSpecBuildSourceStorageSourceBucketRef BucketRef { get; set; }

    /// <summary>Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be used.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source. This object must be a gzipped archive file (.tar.gz) containing source to build.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>The location of the source files to build.  One of 'storageSource' or 'repoSource' must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildSource
{
    /// <summary>Location of the source in a Google Cloud Source Repository.</summary>
    [JsonPropertyName("repoSource")]
    public CloudBuildTriggerSpecBuildSourceRepoSource? RepoSource { get; set; }

    /// <summary>Location of the source in an archive file in Google Cloud Storage.</summary>
    [JsonPropertyName("storageSource")]
    public CloudBuildTriggerSpecBuildSourceStorageSource? StorageSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildStepVolumes
{
    /// <summary>Name of the volume to mount.  Volume names must be unique per build step and must be valid names for Docker volumes. Each named volume must be used by at least two build steps.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Path at which to mount the volume.  Paths must be absolute and cannot conflict with other volume paths on the same build step or with certain reserved volume paths.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuildStep
{
    /// <summary>Allow this build step to fail without failing the entire build if and only if the exit code is one of the specified codes.  If 'allowFailure' is also specified, this field will take precedence.</summary>
    [JsonPropertyName("allowExitCodes")]
    public IList<int>? AllowExitCodes { get; set; }

    /// <summary>Allow this build step to fail without failing the entire build. If false, the entire build will fail if this step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error information will be reported in the 'failureDetail' field.  'allowExitCodes' takes precedence over this field.</summary>
    [JsonPropertyName("allowFailure")]
    public bool? AllowFailure { get; set; }

    /// <summary>A list of arguments that will be presented to the step when it is started.  If the image used to run the step's container has an entrypoint, the args are used as arguments to that entrypoint. If the image does not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be used as arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Working directory to use when running this step's container.  If this value is a relative path, it is relative to the build's working directory. If this value is absolute, it may be outside the build's working directory, in which case the contents of the path may not be persisted across build step executions, unless a 'volume' for that path is specified.  If the build specifies a 'RepoSource' with 'dir' and a step with a 'dir', which specifies an absolute path, the 'RepoSource' 'dir' is ignored for the step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default entrypoint is used.</summary>
    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; }

    /// <summary>A list of environment variable definitions to be used when running a step.  The elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".</summary>
    [JsonPropertyName("env")]
    public IList<string>? Env { get; set; }

    /// <summary>Unique identifier for this build step, used in 'wait_for' to reference this build step as a dependency.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the container image that will run this particular build step.  If the image is available in the host's Docker daemon's cache, it will be run directly. If not, the host will attempt to pull the image first, using the builder service account's credentials if necessary.  The Docker daemon's cache will already have the latest versions of all of the officially supported build steps (see https://github.com/GoogleCloudPlatform/cloud-builders for images and examples). The Docker daemon will also have cached many of the layers for some popular images, like "ubuntu", "debian", but they will be refreshed at the time you attempt to use them.  If you built an image in a previous build step, it will be stored in the host's Docker daemon's cache and is available to use as the name for a later build step.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint or args.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These values must be specified in the build's 'Secret'.</summary>
    [JsonPropertyName("secretEnv")]
    public IList<string>? SecretEnv { get; set; }

    /// <summary>Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to continue to run until either it completes or the build itself times out.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Output only. Stores timing information for executing this build step.</summary>
    [JsonPropertyName("timing")]
    public string? Timing { get; set; }

    /// <summary>List of volumes to mount into the build step.  Each volume is created as an empty volume prior to execution of the build step. Upon completion of the build, volumes and their contents are discarded.  Using a named volume in only one step is not valid as it is indicative of a build request with an incorrect configuration.</summary>
    [JsonPropertyName("volumes")]
    public IList<CloudBuildTriggerSpecBuildStepVolumes>? Volumes { get; set; }

    /// <summary>The ID(s) of the step(s) that this build step depends on.  This build step will not start until all the build steps in 'wait_for' have completed successfully. If 'wait_for' is empty, this build step will start when all previous build steps in the 'Build.Steps' list have completed successfully.</summary>
    [JsonPropertyName("waitFor")]
    public IList<string>? WaitFor { get; set; }
}

/// <summary>Contents of the build template. Either a filename or build template must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecBuild
{
    /// <summary>Artifacts produced by the build that should be uploaded upon successful completion of all build steps.</summary>
    [JsonPropertyName("artifacts")]
    public CloudBuildTriggerSpecBuildArtifacts? Artifacts { get; set; }

    /// <summary>Secrets and secret environment variables.</summary>
    [JsonPropertyName("availableSecrets")]
    public CloudBuildTriggerSpecBuildAvailableSecrets? AvailableSecrets { get; set; }

    /// <summary>A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the Build resource's results field. If any of the images fail to be pushed, the build status is marked FAILURE.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>Google Cloud Storage bucket where logs should be written. Logs file names will be of the format ${logsBucket}/log-${build_id}.txt.</summary>
    [JsonPropertyName("logsBucketRef")]
    public CloudBuildTriggerSpecBuildLogsBucketRef? LogsBucketRef { get; set; }

    /// <summary>Special options for this build.</summary>
    [JsonPropertyName("options")]
    public CloudBuildTriggerSpecBuildOptions? Options { get; set; }

    /// <summary>TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be EXPIRED. The TTL starts ticking from createTime. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("queueTtl")]
    public string? QueueTtl { get; set; }

    /// <summary>Secrets to decrypt using Cloud Key Management Service.</summary>
    [JsonPropertyName("secret")]
    public IList<CloudBuildTriggerSpecBuildSecret>? Secret { get; set; }

    /// <summary>The location of the source files to build.  One of 'storageSource' or 'repoSource' must be provided.</summary>
    [JsonPropertyName("source")]
    public CloudBuildTriggerSpecBuildSource? Source { get; set; }

    /// <summary>The operations to be performed on the workspace.</summary>
    [JsonPropertyName("step")]
    public IList<CloudBuildTriggerSpecBuildStep> Step { get; set; }

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

/// <summary>Only `external` field is supported to configure the reference.  The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGitFileSourceBitbucketServerConfigRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildBitbucketServerConfig` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Only `external` field is supported to configure the reference.  The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGitFileSourceGithubEnterpriseConfigRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildGithubEnterpriseConfig` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Only `external` field is supported to configure the reference.  The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository. If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGitFileSourceRepositoryRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildV2Repository` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The file source describing the local or remote Build template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGitFileSource
{
    /// <summary>Only `external` field is supported to configure the reference.  The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfigRef")]
    public CloudBuildTriggerSpecGitFileSourceBitbucketServerConfigRef? BitbucketServerConfigRef { get; set; }

    /// <summary>Only `external` field is supported to configure the reference.  The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfigRef")]
    public CloudBuildTriggerSpecGitFileSourceGithubEnterpriseConfigRef? GithubEnterpriseConfigRef { get; set; }

    /// <summary>The path of the file, with the repo root as the root of the path.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values: ["UNKNOWN", "CLOUD_SOURCE_REPOSITORIES", "GITHUB", "BITBUCKET_SERVER"].</summary>
    [JsonPropertyName("repoType")]
    public string RepoType { get; set; }

    /// <summary>Only `external` field is supported to configure the reference.  The fully qualified resource name of the Repo API repository. The fully qualified resource name of the Repo API repository. If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("repositoryRef")]
    public CloudBuildTriggerSpecGitFileSourceRepositoryRef? RepositoryRef { get; set; }

    /// <summary>The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the filename (optional). This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions If unspecified, the revision from which the trigger invocation originated is assumed to be the revision from which to read the specified path.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The URI of the repo (optional). If unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to read the specified path.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Only `external` field is supported to configure the reference.  The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGithubEnterpriseConfigResourceNameRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildGithubEnterpriseConfig` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>filter to match changes in pull requests. Specify only one of 'pull_request' or 'push'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGithubPullRequest
{
    /// <summary>Regex of branches to match.</summary>
    [JsonPropertyName("branch")]
    public string Branch { get; set; }

    /// <summary>Whether to block builds on a "/gcbrun" comment from a repository owner or collaborator. Possible values: ["COMMENTS_DISABLED", "COMMENTS_ENABLED", "COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY"].</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>If true, branches that do NOT match the git_ref will trigger a build.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>filter to match changes in refs, like branches or tags. Specify only one of 'pull_request' or 'push'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGithubPush
{
    /// <summary>Regex of branches to match.  Specify only one of branch or tag.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>When true, only trigger a build if the revision regex does NOT match the git_ref regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match.  Specify only one of branch or tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Describes the configuration of a trigger that creates a build whenever a GitHub event is received.  One of 'trigger_template', 'github', 'pubsub_config' or 'webhook_config' must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecGithub
{
    /// <summary>Only `external` field is supported to configure the reference.  The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("enterpriseConfigResourceNameRef")]
    public CloudBuildTriggerSpecGithubEnterpriseConfigResourceNameRef? EnterpriseConfigResourceNameRef { get; set; }

    /// <summary>Name of the repository. For example: The name for https://github.com/googlecloudplatform/cloud-builders is "cloud-builders".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Owner of the repository. For example: The owner for https://github.com/googlecloudplatform/cloud-builders is "googlecloudplatform".</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>filter to match changes in pull requests. Specify only one of 'pull_request' or 'push'.</summary>
    [JsonPropertyName("pullRequest")]
    public CloudBuildTriggerSpecGithubPullRequest? PullRequest { get; set; }

    /// <summary>filter to match changes in refs, like branches or tags. Specify only one of 'pull_request' or 'push'.</summary>
    [JsonPropertyName("push")]
    public CloudBuildTriggerSpecGithubPush? Push { get; set; }
}

/// <summary>Service account that will make the push request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecPubsubConfigServiceAccountRef
{
    /// <summary>Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the topic from which this subscription is receiving messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecPubsubConfigTopicRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/topics/{{value}}`, where {{value}} is the `name` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PubsubConfig describes the configuration of a trigger that creates a build whenever a Pub/Sub message is published.  One of 'trigger_template', 'github', 'pubsub_config' 'webhook_config' or 'source_to_build' must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecPubsubConfig
{
    /// <summary>Service account that will make the push request.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public CloudBuildTriggerSpecPubsubConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Potential issues with the underlying Pub/Sub subscription configuration. Only populated on get requests.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Name of the subscription.</summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }

    /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
    [JsonPropertyName("topicRef")]
    public CloudBuildTriggerSpecPubsubConfigTopicRef TopicRef { get; set; }
}

/// <summary>Contains filter properties for matching Pull Requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecRepositoryEventConfigPullRequest
{
    /// <summary>Regex of branches to match.  The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Configure builds to run whether a repository owner or collaborator need to comment '/gcbrun'. Possible values: ["COMMENTS_DISABLED", "COMMENTS_ENABLED", "COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY"].</summary>
    [JsonPropertyName("commentControl")]
    public string? CommentControl { get; set; }

    /// <summary>If true, branches that do NOT match the git_ref will trigger a build.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }
}

/// <summary>Contains filter properties for matching git pushes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecRepositoryEventConfigPush
{
    /// <summary>Regex of branches to match.  The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>If true, only trigger a build if the revision regex does NOT match the git_ref regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Regex of tags to match.  The syntax of the regular expressions accepted is the syntax accepted by RE2 and described at https://github.com/google/re2/wiki/Syntax.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>The configuration of a trigger that creates a build whenever an event from Repo API is received.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecRepositoryEventConfig
{
    /// <summary>Contains filter properties for matching Pull Requests.</summary>
    [JsonPropertyName("pullRequest")]
    public CloudBuildTriggerSpecRepositoryEventConfigPullRequest? PullRequest { get; set; }

    /// <summary>Contains filter properties for matching git pushes.</summary>
    [JsonPropertyName("push")]
    public CloudBuildTriggerSpecRepositoryEventConfigPush? Push { get; set; }

    /// <summary>The resource name of the Repo API resource.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>The service account used for all user-controlled operations including triggers.patch, triggers.run, builds.create, and builds.cancel.  If no service account is set, then the standard Cloud Build service account ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.  When populating via the external field, the following format is supported: projects/{PROJECT_ID}/serviceAccounts/{SERVICE_ACCOUNT_EMAIL}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecServiceAccountRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/serviceAccounts/{{value}}`, where {{value}} is the `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Only `external` field is supported to configure the reference.  The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecSourceToBuildBitbucketServerConfigRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildBitbucketServerConfig` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Only `external` field is supported to configure the reference.  The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecSourceToBuildGithubEnterpriseConfigRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildGithubEnterpriseConfig` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Only `external` field is supported to configure the reference.  The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecSourceToBuildRepositoryRef
{
    /// <summary>Allowed value: The `name` field of a `CloudBuildV2Repository` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The repo and ref of the repository from which to build. This field is used only for those triggers that do not respond to SCM events. Triggers that respond to such events build source at whatever commit caused the event. This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.  One of 'trigger_template', 'github', 'pubsub_config' 'webhook_config' or 'source_to_build' must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecSourceToBuild
{
    /// <summary>Only `external` field is supported to configure the reference.  The full resource name of the bitbucket server config. Format: projects/{project}/locations/{location}/bitbucketServerConfigs/{id}.</summary>
    [JsonPropertyName("bitbucketServerConfigRef")]
    public CloudBuildTriggerSpecSourceToBuildBitbucketServerConfigRef? BitbucketServerConfigRef { get; set; }

    /// <summary>Only `external` field is supported to configure the reference.  The full resource name of the github enterprise config. Format: projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}.</summary>
    [JsonPropertyName("githubEnterpriseConfigRef")]
    public CloudBuildTriggerSpecSourceToBuildGithubEnterpriseConfigRef? GithubEnterpriseConfigRef { get; set; }

    /// <summary>The branch or tag to use. Must start with "refs/" (required).</summary>
    [JsonPropertyName("ref")]
    public string Ref { get; set; }

    /// <summary>The type of the repo, since it may not be explicit from the repo field (e.g from a URL). Values can be UNKNOWN, CLOUD_SOURCE_REPOSITORIES, GITHUB, BITBUCKET_SERVER Possible values: ["UNKNOWN", "CLOUD_SOURCE_REPOSITORIES", "GITHUB", "BITBUCKET_SERVER"].</summary>
    [JsonPropertyName("repoType")]
    public string RepoType { get; set; }

    /// <summary>Only `external` field is supported to configure the reference.  The qualified resource name of the Repo API repository. Either uri or repository can be specified and is required.</summary>
    [JsonPropertyName("repositoryRef")]
    public CloudBuildTriggerSpecSourceToBuildRepositoryRef? RepositoryRef { get; set; }

    /// <summary>The URI of the repo.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The Cloud Source Repository to build. If omitted, the repo with name "default" is assumed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecTriggerTemplateRepoRef
{
    /// <summary>Allowed value: The `name` field of a `SourceRepoRepository` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Template describing the types of source changes to trigger a build.  Branch and tag names in trigger templates are interpreted as regular expressions. Any branch or tag change that matches that regular expression will trigger a build.  One of 'trigger_template', 'github', 'pubsub_config', 'webhook_config' or 'source_to_build' must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecTriggerTemplate
{
    /// <summary>Name of the branch to build. Exactly one a of branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Explicit commit SHA to build. Exactly one of a branch name, tag, or commit SHA must be provided.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build.  This must be a relative path. If a step's dir is specified and is an absolute path, this value is ignored for that step's execution.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>The Cloud Source Repository to build. If omitted, the repo with name "default" is assumed.</summary>
    [JsonPropertyName("repoRef")]
    public CloudBuildTriggerSpecTriggerTemplateRepoRef? RepoRef { get; set; }

    /// <summary>Name of the tag to build. Exactly one of a branch name, tag, or commit SHA must be provided. This field is a regular expression.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>The secret required</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecWebhookConfigSecretRef
{
    /// <summary>Allowed value: The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>WebhookConfig describes the configuration of a trigger that creates a build whenever a webhook is sent to a trigger's webhook URL.  One of 'trigger_template', 'github', 'pubsub_config' 'webhook_config' or 'source_to_build' must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpecWebhookConfig
{
    /// <summary>The secret required</summary>
    [JsonPropertyName("secretRef")]
    public CloudBuildTriggerSpecWebhookConfigSecretRef SecretRef { get; set; }

    /// <summary>Potential issues with the underlying Pub/Sub subscription configuration. Only populated on get requests.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerSpec
{
    /// <summary>Configuration for manual approval to start a build invocation of this BuildTrigger. Builds created by this trigger will require approval before they execute. Any user with a Cloud Build Approver role for the project can approve a build.</summary>
    [JsonPropertyName("approvalConfig")]
    public CloudBuildTriggerSpecApprovalConfig? ApprovalConfig { get; set; }

    /// <summary>BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.</summary>
    [JsonPropertyName("bitbucketServerTriggerConfig")]
    public CloudBuildTriggerSpecBitbucketServerTriggerConfig? BitbucketServerTriggerConfig { get; set; }

    /// <summary>Contents of the build template. Either a filename or build template must be provided.</summary>
    [JsonPropertyName("build")]
    public CloudBuildTriggerSpecBuild? Build { get; set; }

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

    /// <summary>The file source describing the local or remote Build template.</summary>
    [JsonPropertyName("gitFileSource")]
    public CloudBuildTriggerSpecGitFileSource? GitFileSource { get; set; }

    /// <summary>Describes the configuration of a trigger that creates a build whenever a GitHub event is received.  One of 'trigger_template', 'github', 'pubsub_config' or 'webhook_config' must be provided.</summary>
    [JsonPropertyName("github")]
    public CloudBuildTriggerSpecGithub? Github { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for '**'.  If ignoredFiles and changed files are both empty, then they are not used to determine whether or not to trigger a build.  If ignoredFiles is not empty, then we ignore any files that match any of the ignored_file globs. If the change has no files that are outside of the ignoredFiles globs, then we do not trigger a build.</summary>
    [JsonPropertyName("ignoredFiles")]
    public IList<string>? IgnoredFiles { get; set; }

    /// <summary>Build logs will be sent back to GitHub as part of the checkrun result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or INCLUDE_BUILD_LOGS_WITH_STATUS Possible values: ["INCLUDE_BUILD_LOGS_UNSPECIFIED", "INCLUDE_BUILD_LOGS_WITH_STATUS"].</summary>
    [JsonPropertyName("includeBuildLogs")]
    public string? IncludeBuildLogs { get; set; }

    /// <summary>ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for '**'.  If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is empty, then as far as this filter is concerned, we should trigger the build.  If any of the files altered in the commit pass the ignoredFiles filter and includedFiles is not empty, then we make sure that at least one of those files matches a includedFiles glob. If not, then we do not trigger a build.</summary>
    [JsonPropertyName("includedFiles")]
    public IList<string>? IncludedFiles { get; set; }

    /// <summary>Immutable. The location of the Cloud Build trigger. If not specified, "global" is used. More info: cloud.google.com/build/docs/locations.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>PubsubConfig describes the configuration of a trigger that creates a build whenever a Pub/Sub message is published.  One of 'trigger_template', 'github', 'pubsub_config' 'webhook_config' or 'source_to_build' must be provided.</summary>
    [JsonPropertyName("pubsubConfig")]
    public CloudBuildTriggerSpecPubsubConfig? PubsubConfig { get; set; }

    /// <summary>The configuration of a trigger that creates a build whenever an event from Repo API is received.</summary>
    [JsonPropertyName("repositoryEventConfig")]
    public CloudBuildTriggerSpecRepositoryEventConfig? RepositoryEventConfig { get; set; }

    /// <summary>The service account used for all user-controlled operations including triggers.patch, triggers.run, builds.create, and builds.cancel.  If no service account is set, then the standard Cloud Build service account ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.  When populating via the external field, the following format is supported: projects/{PROJECT_ID}/serviceAccounts/{SERVICE_ACCOUNT_EMAIL}</summary>
    [JsonPropertyName("serviceAccountRef")]
    public CloudBuildTriggerSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>The repo and ref of the repository from which to build. This field is used only for those triggers that do not respond to SCM events. Triggers that respond to such events build source at whatever commit caused the event. This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.  One of 'trigger_template', 'github', 'pubsub_config' 'webhook_config' or 'source_to_build' must be provided.</summary>
    [JsonPropertyName("sourceToBuild")]
    public CloudBuildTriggerSpecSourceToBuild? SourceToBuild { get; set; }

    /// <summary>Substitutions data for Build resource.</summary>
    [JsonPropertyName("substitutions")]
    public IDictionary<string, string>? Substitutions { get; set; }

    /// <summary>Tags for annotation of a BuildTrigger.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>Template describing the types of source changes to trigger a build.  Branch and tag names in trigger templates are interpreted as regular expressions. Any branch or tag change that matches that regular expression will trigger a build.  One of 'trigger_template', 'github', 'pubsub_config', 'webhook_config' or 'source_to_build' must be provided.</summary>
    [JsonPropertyName("triggerTemplate")]
    public CloudBuildTriggerSpecTriggerTemplate? TriggerTemplate { get; set; }

    /// <summary>WebhookConfig describes the configuration of a trigger that creates a build whenever a webhook is sent to a trigger's webhook URL.  One of 'trigger_template', 'github', 'pubsub_config' 'webhook_config' or 'source_to_build' must be provided.</summary>
    [JsonPropertyName("webhookConfig")]
    public CloudBuildTriggerSpecWebhookConfig? WebhookConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTriggerStatusConditions
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
public partial class CloudBuildTriggerStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<CloudBuildTriggerStatusConditions>? Conditions { get; set; }

    /// <summary>Time when the trigger was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The unique identifier for the trigger.</summary>
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CloudBuildTrigger
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public CloudBuildTriggerMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public CloudBuildTriggerSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public CloudBuildTriggerStatus? Status { get; set; }
}