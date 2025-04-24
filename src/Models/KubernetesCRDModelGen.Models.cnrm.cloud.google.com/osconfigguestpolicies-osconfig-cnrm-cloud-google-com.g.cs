using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.osconfig.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicyMetadata
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecAssignmentGroupLabels
{
    /// <summary>Google Compute Engine instance labels that must be present for an instance to be included in this assignment group.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecAssignmentInstances
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeInstance` resource.</summary>
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
public partial class OSConfigGuestPolicySpecAssignmentOsTypes
{
    /// <summary>Targets VM instances with OS Inventory enabled and having the following OS architecture.</summary>
    [JsonPropertyName("osArchitecture")]
    public string? OsArchitecture { get; set; }

    /// <summary>Targets VM instances with OS Inventory enabled and having the following OS short name, for example "debian" or "windows".</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>Targets VM instances with OS Inventory enabled and having the following following OS version.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>Specifies the VMs that are assigned this policy. This allows you to target sets or groups of VMs by different parameters such as labels, names, OS, or zones. Empty assignments will target ALL VMs underneath this policy. Conflict Management Policies that exist higher up in the resource hierarchy (closer to the Org) will override those lower down if there is a conflict. At the same level in the resource hierarchy (ie. within a project), the service will prevent the creation of multiple policies that conflict with each other. If there are multiple policies that specify the same config (eg. package, software recipe, repository, etc.), the service will ensure that no VM could potentially receive instructions from both policies. To create multiple policies that specify different versions of a package or different configs for different Operating Systems, each policy must be mutually exclusive in their targeting according to labels, OS, or other criteria. Different configs are identified for conflicts in different ways. Packages are identified by their name and the package manager(s) they target. Package repositories are identified by their unique id where applicable. Some package managers don't have a unique identifier for repositories and where that's the case, no uniqueness is validated by the service. Note that if OS Inventory is disabled, a VM will not be assigned a policy that targets by OS because the service will see this VM's OS as unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecAssignment
{
    /// <summary>Targets instances matching at least one of these label sets. This allows an assignment to target disparate groups, for example "env=prod or env=staging".</summary>
    [JsonPropertyName("groupLabels")]
    public IList<OSConfigGuestPolicySpecAssignmentGroupLabels>? GroupLabels { get; set; }

    /// <summary>Targets VM instances whose name starts with one of these prefixes. Like labels, this is another way to group VM instances when targeting configs, for example prefix="prod-". Only supported for project-level policies.</summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instances")]
    public IList<OSConfigGuestPolicySpecAssignmentInstances>? Instances { get; set; }

    /// <summary>Targets VM instances matching at least one of the following OS types. VM instances must match all supplied criteria for a given OsType to be included.</summary>
    [JsonPropertyName("osTypes")]
    public IList<OSConfigGuestPolicySpecAssignmentOsTypes>? OsTypes { get; set; }

    /// <summary>Targets instances in any of these zones. Leave empty to target instances in any zone. Zonal targeting is uncommon and is supported to facilitate the management of changes by zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>An Apt Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecPackageRepositoriesApt
{
    /// <summary>Type of archive files in this repository. The default behavior is DEB. Possible values: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC</summary>
    [JsonPropertyName("archiveType")]
    public string? ArchiveType { get; set; }

    /// <summary>Required. List of components for this repository. Must contain at least one item.</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Required. Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string Distribution { get; set; }

    /// <summary>URI of the key file for this repository. The agent maintains a keyring at `/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg` containing all the keys in any applied guest policy.</summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>Required. URI for this repository.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>A Goo Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecPackageRepositoriesGoo
{
    /// <summary>Required. The name of the repository.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Required. The url of the repository.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>A Yum Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecPackageRepositoriesYum
{
    /// <summary>Required. The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>Required. A one word, unique name for this repository. This is the `repo id` in the Yum config file and also the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when checking for guest policy conflicts.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
}

/// <summary>A Zypper Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecPackageRepositoriesZypper
{
    /// <summary>Required. The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>Required. A one word, unique name for this repository. This is the `repo id` in the zypper config file and also the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when checking for guest policy conflicts.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecPackageRepositories
{
    /// <summary>An Apt Repository.</summary>
    [JsonPropertyName("apt")]
    public OSConfigGuestPolicySpecPackageRepositoriesApt? Apt { get; set; }

    /// <summary>A Goo Repository.</summary>
    [JsonPropertyName("goo")]
    public OSConfigGuestPolicySpecPackageRepositoriesGoo? Goo { get; set; }

    /// <summary>A Yum Repository.</summary>
    [JsonPropertyName("yum")]
    public OSConfigGuestPolicySpecPackageRepositoriesYum? Yum { get; set; }

    /// <summary>A Zypper Repository.</summary>
    [JsonPropertyName("zypper")]
    public OSConfigGuestPolicySpecPackageRepositoriesZypper? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecPackages
{
    /// <summary>The desired_state the agent should maintain for this package. The default is to ensure the package is installed. Possible values: DESIRED_STATE_UNSPECIFIED, INSTALLED, REMOVED</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Type of package manager that can be used to install this package. If a system does not have the package manager, the package is not installed or removed no error message is returned. By default, or if you specify `ANY`, the agent attempts to install and remove this package using the default package manager. This is useful when creating a policy that applies to different types of systems. The default behavior is ANY. Possible values: MANAGER_UNSPECIFIED, ANY, APT, YUM, ZYPPER, GOO</summary>
    [JsonPropertyName("manager")]
    public string? Manager { get; set; }

    /// <summary>Required. The name of the package. A package is uniquely identified for conflict validation by checking the package name and the manager(s) that the package targets.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesArtifactsGcsBucketRef
{
    /// <summary>Bucket of the Google Cloud Storage object. Given an example URL: `https://storage.googleapis.com/my-bucket/foo/bar#1234567` this value would be `my-bucket`.  Allowed value: The Google Cloud resource name of a `StorageBucket` resource (format: `{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A Google Cloud Storage artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesArtifactsGcs
{
    /// <summary></summary>
    [JsonPropertyName("bucketRef")]
    public OSConfigGuestPolicySpecRecipesArtifactsGcsBucketRef? BucketRef { get; set; }

    /// <summary>Must be provided if allow_insecure is false. Generation number of the Google Cloud Storage object. `https://storage.googleapis.com/my-bucket/foo/bar#1234567` this value would be `1234567`.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Name of the Google Cloud Storage object. As specified [here] (https://cloud.google.com/storage/docs/naming#objectnames) Given an example URL: `https://storage.googleapis.com/my-bucket/foo/bar#1234567` this value would be `foo/bar`.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesArtifactsRemote
{
    /// <summary>Must be provided if `allow_insecure` is `false`. SHA256 checksum in hex format, to compare to the checksum of the artifact. If the checksum is not empty and it doesn't match the artifact then the recipe installation fails before running any of the steps.</summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format: {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesArtifacts
{
    /// <summary>Defaults to false. When false, recipes are subject to validations based on the artifact type: Remote: A checksum must be specified, and only protocols with transport-layer security are permitted. GCS: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Google Cloud Storage artifact.</summary>
    [JsonPropertyName("gcs")]
    public OSConfigGuestPolicySpecRecipesArtifactsGcs? Gcs { get; set; }

    /// <summary>Required. Id of the artifact, which the installation and update steps of this recipe can reference. Artifacts in a recipe cannot have the same id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A generic remote artifact.</summary>
    [JsonPropertyName("remote")]
    public OSConfigGuestPolicySpecRecipesArtifactsRemote? Remote { get; set; }
}

/// <summary>Extracts an archive into the specified directory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallStepsArchiveExtraction
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Directory to extract archive to. Defaults to `/` on Linux or `C:` on Windows.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Required. The type of the archive to extract. Possible values: TYPE_UNSPECIFIED, VALIDATION, DESIRED_STATE_CHECK, DESIRED_STATE_ENFORCEMENT, DESIRED_STATE_CHECK_POST_ENFORCEMENT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Installs a deb file via dpkg.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallStepsDpkgInstallation
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }
}

/// <summary>Copies a file onto the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallStepsFileCopy
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Required. The absolute path on the instance to put the file.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether to allow this step to overwrite existing files. If this is false and the file already exists the file is not overwritten and the step is considered a success. Defaults to false.</summary>
    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    /// <summary>Consists of three octal digits which represent, in order, the permissions of the owner, group, and other users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write bit, and the one bit corresponds to the execute permission. Default behavior is 755. Below are some examples of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write: 6 read only: 4</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
}

/// <summary>Executes an artifact or local file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallStepsFileExec
{
    /// <summary>Defaults to [0]. A list of possible return values that the program can return to indicate a success.</summary>
    [JsonPropertyName("allowedExitCodes")]
    public IList<long>? AllowedExitCodes { get; set; }

    /// <summary>Arguments to be passed to the provided executable.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>The absolute path of the file on the local filesystem.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>Installs an MSI file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallStepsMsiInstallation
{
    /// <summary>Return codes that indicate that the software installed or updated successfully. Behaviour defaults to [0]</summary>
    [JsonPropertyName("allowedExitCodes")]
    public IList<long>? AllowedExitCodes { get; set; }

    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>The flags to use when installing the MSI defaults to ["/i"] (i.e. the install flag).</summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }
}

/// <summary>Installs an rpm file via the rpm utility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallStepsRpmInstallation
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }
}

/// <summary>Runs commands in a shell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallStepsScriptRun
{
    /// <summary>Return codes that indicate that the software installed or updated successfully. Behaviour defaults to [0]</summary>
    [JsonPropertyName("allowedExitCodes")]
    public IList<long>? AllowedExitCodes { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script is executed directly, which likely only succeed for scripts with [shebang lines](https://en.wikipedia.org/wiki/Shebang_(Unix)). Possible values: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Required. The shell script to be executed.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesInstallSteps
{
    /// <summary>Extracts an archive into the specified directory.</summary>
    [JsonPropertyName("archiveExtraction")]
    public OSConfigGuestPolicySpecRecipesInstallStepsArchiveExtraction? ArchiveExtraction { get; set; }

    /// <summary>Installs a deb file via dpkg.</summary>
    [JsonPropertyName("dpkgInstallation")]
    public OSConfigGuestPolicySpecRecipesInstallStepsDpkgInstallation? DpkgInstallation { get; set; }

    /// <summary>Copies a file onto the instance.</summary>
    [JsonPropertyName("fileCopy")]
    public OSConfigGuestPolicySpecRecipesInstallStepsFileCopy? FileCopy { get; set; }

    /// <summary>Executes an artifact or local file.</summary>
    [JsonPropertyName("fileExec")]
    public OSConfigGuestPolicySpecRecipesInstallStepsFileExec? FileExec { get; set; }

    /// <summary>Installs an MSI file.</summary>
    [JsonPropertyName("msiInstallation")]
    public OSConfigGuestPolicySpecRecipesInstallStepsMsiInstallation? MsiInstallation { get; set; }

    /// <summary>Installs an rpm file via the rpm utility.</summary>
    [JsonPropertyName("rpmInstallation")]
    public OSConfigGuestPolicySpecRecipesInstallStepsRpmInstallation? RpmInstallation { get; set; }

    /// <summary>Runs commands in a shell.</summary>
    [JsonPropertyName("scriptRun")]
    public OSConfigGuestPolicySpecRecipesInstallStepsScriptRun? ScriptRun { get; set; }
}

/// <summary>Extracts an archive into the specified directory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateStepsArchiveExtraction
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Directory to extract archive to. Defaults to `/` on Linux or `C:` on Windows.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Required. The type of the archive to extract. Possible values: TYPE_UNSPECIFIED, VALIDATION, DESIRED_STATE_CHECK, DESIRED_STATE_ENFORCEMENT, DESIRED_STATE_CHECK_POST_ENFORCEMENT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Installs a deb file via dpkg.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateStepsDpkgInstallation
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }
}

/// <summary>Copies a file onto the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateStepsFileCopy
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>Required. The absolute path on the instance to put the file.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether to allow this step to overwrite existing files. If this is false and the file already exists the file is not overwritten and the step is considered a success. Defaults to false.</summary>
    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    /// <summary>Consists of three octal digits which represent, in order, the permissions of the owner, group, and other users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write bit, and the one bit corresponds to the execute permission. Default behavior is 755. Below are some examples of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write: 6 read only: 4</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
}

/// <summary>Executes an artifact or local file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateStepsFileExec
{
    /// <summary>Defaults to [0]. A list of possible return values that the program can return to indicate a success.</summary>
    [JsonPropertyName("allowedExitCodes")]
    public IList<long>? AllowedExitCodes { get; set; }

    /// <summary>Arguments to be passed to the provided executable.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>The absolute path of the file on the local filesystem.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>Installs an MSI file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateStepsMsiInstallation
{
    /// <summary>Return codes that indicate that the software installed or updated successfully. Behaviour defaults to [0]</summary>
    [JsonPropertyName("allowedExitCodes")]
    public IList<long>? AllowedExitCodes { get; set; }

    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }

    /// <summary>The flags to use when installing the MSI defaults to ["/i"] (i.e. the install flag).</summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }
}

/// <summary>Installs an rpm file via the rpm utility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateStepsRpmInstallation
{
    /// <summary>Required. The id of the relevant artifact in the recipe.</summary>
    [JsonPropertyName("artifactId")]
    public string? ArtifactId { get; set; }
}

/// <summary>Runs commands in a shell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateStepsScriptRun
{
    /// <summary>Return codes that indicate that the software installed or updated successfully. Behaviour defaults to [0]</summary>
    [JsonPropertyName("allowedExitCodes")]
    public IList<long>? AllowedExitCodes { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script is executed directly, which likely only succeed for scripts with [shebang lines](https://en.wikipedia.org/wiki/Shebang_(Unix)). Possible values: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Required. The shell script to be executed.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipesUpdateSteps
{
    /// <summary>Extracts an archive into the specified directory.</summary>
    [JsonPropertyName("archiveExtraction")]
    public OSConfigGuestPolicySpecRecipesUpdateStepsArchiveExtraction? ArchiveExtraction { get; set; }

    /// <summary>Installs a deb file via dpkg.</summary>
    [JsonPropertyName("dpkgInstallation")]
    public OSConfigGuestPolicySpecRecipesUpdateStepsDpkgInstallation? DpkgInstallation { get; set; }

    /// <summary>Copies a file onto the instance.</summary>
    [JsonPropertyName("fileCopy")]
    public OSConfigGuestPolicySpecRecipesUpdateStepsFileCopy? FileCopy { get; set; }

    /// <summary>Executes an artifact or local file.</summary>
    [JsonPropertyName("fileExec")]
    public OSConfigGuestPolicySpecRecipesUpdateStepsFileExec? FileExec { get; set; }

    /// <summary>Installs an MSI file.</summary>
    [JsonPropertyName("msiInstallation")]
    public OSConfigGuestPolicySpecRecipesUpdateStepsMsiInstallation? MsiInstallation { get; set; }

    /// <summary>Installs an rpm file via the rpm utility.</summary>
    [JsonPropertyName("rpmInstallation")]
    public OSConfigGuestPolicySpecRecipesUpdateStepsRpmInstallation? RpmInstallation { get; set; }

    /// <summary>Runs commands in a shell.</summary>
    [JsonPropertyName("scriptRun")]
    public OSConfigGuestPolicySpecRecipesUpdateStepsScriptRun? ScriptRun { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpecRecipes
{
    /// <summary>Resources available to be used in the steps in the recipe.</summary>
    [JsonPropertyName("artifacts")]
    public IList<OSConfigGuestPolicySpecRecipesArtifacts>? Artifacts { get; set; }

    /// <summary>Default is INSTALLED. The desired state the agent should maintain for this recipe. INSTALLED: The software recipe is installed on the instance but won't be updated to new versions. UPDATED: The software recipe is installed on the instance. The recipe is updated to a higher version, if a higher version of the recipe is assigned to this instance. REMOVE: Remove is unsupported for software recipes and attempts to create or update a recipe to the REMOVE state is rejected. Possible values: DESIRED_STATE_UNSPECIFIED, INSTALLED, REMOVED</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Actions to be taken for installing this recipe. On failure it stops executing steps and does not attempt another installation. Any steps taken (including partially completed steps) are not rolled back.</summary>
    [JsonPropertyName("installSteps")]
    public IList<OSConfigGuestPolicySpecRecipesInstallSteps>? InstallSteps { get; set; }

    /// <summary>Required. Unique identifier for the recipe. Only one recipe with a given name is installed on an instance. Names are also used to identify resources which helps to determine whether guest policies have conflicts. This means that requests to create multiple recipes with the same name and version are rejected since they could potentially have conflicting assignments.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Actions to be taken for updating this recipe. On failure it stops executing steps and does not attempt another update for this recipe. Any steps taken (including partially completed steps) are not rolled back.</summary>
    [JsonPropertyName("updateSteps")]
    public IList<OSConfigGuestPolicySpecRecipesUpdateSteps>? UpdateSteps { get; set; }

    /// <summary>The version of this software recipe. Version can be up to 4 period separated numbers (e.g. 12.34.56.78).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicySpec
{
    /// <summary>Specifies the VMs that are assigned this policy. This allows you to target sets or groups of VMs by different parameters such as labels, names, OS, or zones. Empty assignments will target ALL VMs underneath this policy. Conflict Management Policies that exist higher up in the resource hierarchy (closer to the Org) will override those lower down if there is a conflict. At the same level in the resource hierarchy (ie. within a project), the service will prevent the creation of multiple policies that conflict with each other. If there are multiple policies that specify the same config (eg. package, software recipe, repository, etc.), the service will ensure that no VM could potentially receive instructions from both policies. To create multiple policies that specify different versions of a package or different configs for different Operating Systems, each policy must be mutually exclusive in their targeting according to labels, OS, or other criteria. Different configs are identified for conflicts in different ways. Packages are identified by their name and the package manager(s) they target. Package repositories are identified by their unique id where applicable. Some package managers don't have a unique identifier for repositories and where that's the case, no uniqueness is validated by the service. Note that if OS Inventory is disabled, a VM will not be assigned a policy that targets by OS because the service will see this VM's OS as unknown.</summary>
    [JsonPropertyName("assignment")]
    public OSConfigGuestPolicySpecAssignment? Assignment { get; set; }

    /// <summary>Description of the GuestPolicy. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of package repository configurations assigned to the VM instance.</summary>
    [JsonPropertyName("packageRepositories")]
    public IList<OSConfigGuestPolicySpecPackageRepositories>? PackageRepositories { get; set; }

    /// <summary>List of package configurations assigned to the VM instance.</summary>
    [JsonPropertyName("packages")]
    public IList<OSConfigGuestPolicySpecPackages>? Packages { get; set; }

    /// <summary>Optional. A list of Recipes to install on the VM.</summary>
    [JsonPropertyName("recipes")]
    public IList<OSConfigGuestPolicySpecRecipes>? Recipes { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicyStatusConditions
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
public partial class OSConfigGuestPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<OSConfigGuestPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. Time this GuestPolicy was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The etag for this GuestPolicy. If this is provided on update, it must match the server's etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Last time this GuestPolicy was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class OSConfigGuestPolicy
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public OSConfigGuestPolicyMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public OSConfigGuestPolicySpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public OSConfigGuestPolicyStatus? Status { get; set; }
}