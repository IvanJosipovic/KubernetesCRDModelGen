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
public partial class V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilterExclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilterInclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilterInventories
{
    /// <summary>Required. The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of `7`, specify the following value for this field `7.*` An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>Required. Filter to select VMs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilter
{
    /// <summary>Target all VMs in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>List of label sets used for VM exclusion. If the list has more than one label set, the VM is excluded if any of the label sets are applicable for the VM.</summary>
    [JsonPropertyName("exclusionLabels")]
    public IList<V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilterExclusionLabels>? ExclusionLabels { get; set; }

    /// <summary>List of label sets used for VM inclusion. If the list has more than one `LabelSet`, the VM is included if any of the label sets are applicable for the VM.</summary>
    [JsonPropertyName("inclusionLabels")]
    public IList<V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilterInclusionLabels>? InclusionLabels { get; set; }

    /// <summary>List of inventories to select VMs. A VM is selected if its inventory data matches at least one of the following inventories.</summary>
    [JsonPropertyName("inventories")]
    public IList<V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilterInventories>? Inventories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsInventoryFilters
{
    /// <summary>Required. The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of `7`, specify the following value for this field `7.*` An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>A Cloud Storage object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforceFileGcs
{
    /// <summary>Required. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Required. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>A generic remote file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforceFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>Required. URI from which to fetch the object. It should contain both the protocol and path following the format `{protocol}://{location}`.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>A remote or local file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforceFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforceFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforceFileRemote? Remote { get; set; }
}

/// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforce
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file.</summary>
    [JsonPropertyName("file")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforceFile? File { get; set; }

    /// <summary>Required. The script interpreter to use. Possible values: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL</summary>
    [JsonPropertyName("interpreter")]
    public string Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>A Cloud Storage object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidateFileGcs
{
    /// <summary>Required. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Required. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>A generic remote file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidateFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>Required. URI from which to fetch the object. It should contain both the protocol and path following the format `{protocol}://{location}`.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>A remote or local file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidateFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidateFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidateFileRemote? Remote { get; set; }
}

/// <summary>Required. What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidate
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file.</summary>
    [JsonPropertyName("file")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidateFile? File { get; set; }

    /// <summary>Required. The script interpreter to use. Possible values: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL</summary>
    [JsonPropertyName("interpreter")]
    public string Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>Exec resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExec
{
    /// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce.</summary>
    [JsonPropertyName("enforce")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecEnforce? Enforce { get; set; }

    /// <summary>Required. What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate.</summary>
    [JsonPropertyName("validate")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExecValidate Validate { get; set; }
}

/// <summary>A Cloud Storage object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFileFileGcs
{
    /// <summary>Required. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Required. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>A generic remote file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFileFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>Required. URI from which to fetch the object. It should contain both the protocol and path following the format `{protocol}://{location}`.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>A remote or local source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFileFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFileFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFileFileRemote? Remote { get; set; }
}

/// <summary>File resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFile
{
    /// <summary>A a file with this content. The size of the content is limited to 1024 characters.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>A remote or local source.</summary>
    [JsonPropertyName("file")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFileFile? File { get; set; }

    /// <summary>Required. The absolute path of the file within the VM.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Consists of three octal digits which represent, in order, the permissions of the owner, group, and other users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write bit, and the one bit corresponds to the execute permission. Default behavior is 755. Below are some examples of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write: 6 read only: 4</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }

    /// <summary>Required. Desired state of the file. Possible values: OS_POLICY_COMPLIANCE_STATE_UNSPECIFIED, COMPLIANT, NON_COMPLIANT, UNKNOWN, NO_OS_POLICIES_APPLICABLE</summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}

/// <summary>A package managed by Apt.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgApt
{
    /// <summary>Required. Package name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A Cloud Storage object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDebSourceGcs
{
    /// <summary>Required. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Required. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>A generic remote file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDebSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>Required. URI from which to fetch the object. It should contain both the protocol and path following the format `{protocol}://{location}`.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>Required. A deb package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDebSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDebSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDebSourceRemote? Remote { get; set; }
}

/// <summary>A deb package file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDeb
{
    /// <summary>Whether dependencies should also be installed. - install when false: `dpkg -i package` - install when true: `apt-get update &amp;&amp; apt-get -y install package.deb`</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>Required. A deb package.</summary>
    [JsonPropertyName("source")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDebSource Source { get; set; }
}

/// <summary>A package managed by GooGet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgGooget
{
    /// <summary>Required. Package name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A Cloud Storage object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs
{
    /// <summary>Required. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Required. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>A generic remote file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>Required. URI from which to fetch the object. It should contain both the protocol and path following the format `{protocol}://{location}`.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>Required. The MSI package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsiSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote? Remote { get; set; }
}

/// <summary>An MSI package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsi
{
    /// <summary>Additional properties to use during installation. This should be in the format of Property=Setting. Appended to the defaults of `ACTION=INSTALL REBOOT=ReallySuppress`.</summary>
    [JsonPropertyName("properties")]
    public IList<string>? Properties { get; set; }

    /// <summary>Required. The MSI package.</summary>
    [JsonPropertyName("source")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsiSource Source { get; set; }
}

/// <summary>A Cloud Storage object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs
{
    /// <summary>Required. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Required. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>A generic remote file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>Required. URI from which to fetch the object. It should contain both the protocol and path following the format `{protocol}://{location}`.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>Required. An rpm package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpmSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote? Remote { get; set; }
}

/// <summary>An rpm package file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpm
{
    /// <summary>Whether dependencies should also be installed. - install when false: `rpm --upgrade --replacepkgs package.rpm` - install when true: `yum -y install package.rpm` or `zypper -y install package.rpm`</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>Required. An rpm package.</summary>
    [JsonPropertyName("source")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpmSource Source { get; set; }
}

/// <summary>A package managed by YUM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgYum
{
    /// <summary>Required. Package name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A package managed by Zypper.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgZypper
{
    /// <summary>Required. Package name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Package resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkg
{
    /// <summary>A package managed by Apt.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgApt? Apt { get; set; }

    /// <summary>A deb package file.</summary>
    [JsonPropertyName("deb")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgDeb? Deb { get; set; }

    /// <summary>Required. The desired state the agent should maintain for this package. Possible values: DESIRED_STATE_UNSPECIFIED, INSTALLED, REMOVED</summary>
    [JsonPropertyName("desiredState")]
    public string DesiredState { get; set; }

    /// <summary>A package managed by GooGet.</summary>
    [JsonPropertyName("googet")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgGooget? Googet { get; set; }

    /// <summary>An MSI package.</summary>
    [JsonPropertyName("msi")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgMsi? Msi { get; set; }

    /// <summary>An rpm package file.</summary>
    [JsonPropertyName("rpm")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgRpm? Rpm { get; set; }

    /// <summary>A package managed by YUM.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgYum? Yum { get; set; }

    /// <summary>A package managed by Zypper.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkgZypper? Zypper { get; set; }
}

/// <summary>An Apt Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryApt
{
    /// <summary>Required. Type of archive files in this repository. Possible values: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC</summary>
    [JsonPropertyName("archiveType")]
    public string ArchiveType { get; set; }

    /// <summary>Required. List of components for this repository. Must contain at least one item.</summary>
    [JsonPropertyName("components")]
    public IList<string> Components { get; set; }

    /// <summary>Required. Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string Distribution { get; set; }

    /// <summary>URI of the key file for this repository. The agent maintains a keyring at `/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg`.</summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>Required. URI for this repository.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>A Goo Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryGoo
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
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryYum
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

    /// <summary>Required. A one word, unique name for this repository. This is the `repo id` in the yum config file and also the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when checking for resource conflicts.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
}

/// <summary>A Zypper Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryZypper
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

    /// <summary>Required. A one word, unique name for this repository. This is the `repo id` in the zypper config file and also the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
}

/// <summary>Package repository resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepository
{
    /// <summary>An Apt Repository.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryApt? Apt { get; set; }

    /// <summary>A Goo Repository.</summary>
    [JsonPropertyName("goo")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryGoo? Goo { get; set; }

    /// <summary>A Yum Repository.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryYum? Yum { get; set; }

    /// <summary>A Zypper Repository.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepositoryZypper? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResources
{
    /// <summary>Exec resource</summary>
    [JsonPropertyName("exec")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesExec? Exec { get; set; }

    /// <summary>File resource</summary>
    [JsonPropertyName("file")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesFile? File { get; set; }

    /// <summary>Required. The id of the resource with the following restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be unique within the OS policy.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Package resource</summary>
    [JsonPropertyName("pkg")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesPkg? Pkg { get; set; }

    /// <summary>Package repository resource</summary>
    [JsonPropertyName("repository")]
    public V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResourcesRepository? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroups
{
    /// <summary>List of inventory filters for the resource group. The resources in this resource group are applied to the target VM if it satisfies at least one of the following inventory filters. For example, to apply this resource group to VMs running either `RHEL` or `CentOS` operating systems, specify 2 items for the list with following values: inventory_filters[0].os_short_name='rhel' and inventory_filters[1].os_short_name='centos' If the list is empty, this resource group will be applied to the target VM unconditionally.</summary>
    [JsonPropertyName("inventoryFilters")]
    public IList<V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsInventoryFilters>? InventoryFilters { get; set; }

    /// <summary>Required. List of resources configured for this resource group. The resources are executed in the exact order specified here.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroupsResources> Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecOsPolicies
{
    /// <summary>This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to `true` if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.</summary>
    [JsonPropertyName("allowNoResourceGroupMatch")]
    public bool? AllowNoResourceGroupMatch { get; set; }

    /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The id of the OS policy with the following restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be unique within the assignment.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Required. Policy mode Possible values: MODE_UNSPECIFIED, VALIDATION, ENFORCEMENT</summary>
    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    /// <summary>Required. List of resource groups for the policy. For a particular VM, resource groups are evaluated in the order specified and the first resource group that is applicable is selected and the rest are ignored. If none of the resource groups are applicable for a VM, the VM is considered to be non-compliant w.r.t this policy. This behavior can be toggled by the flag `allow_no_resource_group_match`</summary>
    [JsonPropertyName("resourceGroups")]
    public IList<V1beta1OSConfigOSPolicyAssignmentSpecOsPoliciesResourceGroups> ResourceGroups { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The maximum number (or percentage) of VMs per zone to disrupt at any given moment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public long? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percent")]
    public long? Percent { get; set; }
}

/// <summary>Required. Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpecRollout
{
    /// <summary>Required. The maximum number (or percentage) of VMs per zone to disrupt at any given moment.</summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta1OSConfigOSPolicyAssignmentSpecRolloutDisruptionBudget DisruptionBudget { get; set; }

    /// <summary>Required. This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the `disruption_budget` at least until this duration of time has passed after configuration changes are applied.</summary>
    [JsonPropertyName("minWaitDuration")]
    public string MinWaitDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentSpec
{
    /// <summary>OS policy assignment description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Filter to select VMs.</summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta1OSConfigOSPolicyAssignmentSpecInstanceFilter InstanceFilter { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. List of OS policies to be applied to the VMs.</summary>
    [JsonPropertyName("osPolicies")]
    public IList<V1beta1OSConfigOSPolicyAssignmentSpecOsPolicies> OsPolicies { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1OSConfigOSPolicyAssignmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted.</summary>
    [JsonPropertyName("rollout")]
    public V1beta1OSConfigOSPolicyAssignmentSpecRollout Rollout { get; set; }

    /// <summary>Set to true to skip awaiting rollout during resource creation and update.</summary>
    [JsonPropertyName("skipAwaitRollout")]
    public bool? SkipAwaitRollout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OSConfigOSPolicyAssignmentStatusConditions
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
public partial class V1beta1OSConfigOSPolicyAssignmentStatus
{
    /// <summary>Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision. For a given OS policy assignment, there is only one revision with a value of `true` for this field.</summary>
    [JsonPropertyName("baseline")]
    public bool? Baseline { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OSConfigOSPolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. Indicates that this revision deletes the OS policy assignment.</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>The etag for this OS policy assignment. If this is provided on update, it must match the server's etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Indicates that reconciliation is in progress for the revision. This value is `true` when the `rollout_state` is one of: * IN_PROGRESS * CANCELLING</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The timestamp that the revision was created.</summary>
    [JsonPropertyName("revisionCreateTime")]
    public string? RevisionCreateTime { get; set; }

    /// <summary>Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment</summary>
    [JsonPropertyName("revisionId")]
    public string? RevisionId { get; set; }

    /// <summary>Output only. OS policy assignment rollout state Possible values: ROLLOUT_STATE_UNSPECIFIED, IN_PROGRESS, CANCELLING, CANCELLED, SUCCEEDED</summary>
    [JsonPropertyName("rolloutState")]
    public string? RolloutState { get; set; }

    /// <summary>Output only. Server generated unique id for the OS policy assignment resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OSConfigOSPolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OSConfigOSPolicyAssignmentSpec>, IStatus<V1beta1OSConfigOSPolicyAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OSConfigOSPolicyAssignment";
    public const string KubeGroup = "osconfig.cnrm.cloud.google.com";
    public const string KubePluralName = "osconfigospolicyassignments";
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
    public V1beta1OSConfigOSPolicyAssignmentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1OSConfigOSPolicyAssignmentStatus? Status { get; set; }
}