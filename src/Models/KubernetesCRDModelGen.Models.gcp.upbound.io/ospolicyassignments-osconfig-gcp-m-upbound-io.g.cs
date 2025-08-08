using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.osconfig.gcp.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderInstanceFilterExclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderInstanceFilterInclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderInstanceFilterInventories
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of 7, specify the following value for this field 7.* An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>Filter to select VMs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderInstanceFilter
{
    /// <summary>Target all VMs in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>List of label sets used for VM exclusion. If the list has more than one label set, the VM is excluded if any of the label sets are applicable for the VM. Structure is documented below.</summary>
    [JsonPropertyName("exclusionLabels")]
    public IList<V1beta1OsPolicyAssignmentSpecForProviderInstanceFilterExclusionLabels>? ExclusionLabels { get; set; }

    /// <summary>List of label sets used for VM inclusion. If the list has more than one LabelSet, the VM is included if any of the label sets are applicable for the VM. Structure is documented below.</summary>
    [JsonPropertyName("inclusionLabels")]
    public IList<V1beta1OsPolicyAssignmentSpecForProviderInstanceFilterInclusionLabels>? InclusionLabels { get; set; }

    /// <summary>List of inventories to select VMs. A VM is selected if its inventory data matches at least one of the following inventories. Structure is documented below.</summary>
    [JsonPropertyName("inventories")]
    public IList<V1beta1OsPolicyAssignmentSpecForProviderInstanceFilterInventories>? Inventories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsInventoryFilters
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of 7, specify the following value for this field 7.* An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote? Remote { get; set; }
}

/// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforce
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforceFile? File { get; set; }

    /// <summary>The script interpreter to use. Possible values are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote? Remote { get; set; }
}

/// <summary>What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidate
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidateFile? File { get; set; }

    /// <summary>The script interpreter to use. Possible values are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>Exec resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExec
{
    /// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce. Structure is documented below.</summary>
    [JsonPropertyName("enforce")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecEnforce? Enforce { get; set; }

    /// <summary>What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate. Structure is documented below.</summary>
    [JsonPropertyName("validate")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExecValidate? Validate { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFileRemote? Remote { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFile
{
    /// <summary>A a file with this content. The size of the content is limited to 1024 characters.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFileFile? File { get; set; }

    /// <summary>The absolute path of the file within the VM.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Desired state of the file. Possible values are: DESIRED_STATE_UNSPECIFIED, PRESENT, ABSENT, CONTENTS_MATCH.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>An Apt Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgApt
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote? Remote { get; set; }
}

/// <summary>A deb package file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDeb
{
    /// <summary>Whether dependencies should also be installed. - install when false: rpm --upgrade --replacepkgs package.rpm - install when true: yum -y install package.rpm or zypper -y install package.rpm</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDebSource? Source { get; set; }
}

/// <summary>A package managed by GooGet. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgGooget
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote? Remote { get; set; }
}

/// <summary>An MSI package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsi
{
    /// <summary>Additional properties to use during installation. This should be in the format of Property=Setting. Appended to the defaults of ACTION=INSTALL REBOOT=ReallySuppress.</summary>
    [JsonPropertyName("properties")]
    public IList<string>? Properties { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsiSource? Source { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote? Remote { get; set; }
}

/// <summary>An rpm package file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpm
{
    /// <summary>Whether dependencies should also be installed. - install when false: rpm --upgrade --replacepkgs package.rpm - install when true: yum -y install package.rpm or zypper -y install package.rpm</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpmSource? Source { get; set; }
}

/// <summary>A Yum Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgYum
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Zypper Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgZypper
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Package resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkg
{
    /// <summary>An Apt Repository. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgApt? Apt { get; set; }

    /// <summary>A deb package file. Structure is documented below.</summary>
    [JsonPropertyName("deb")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgDeb? Deb { get; set; }

    /// <summary>The desired state the agent should maintain for this package. Possible values are: DESIRED_STATE_UNSPECIFIED, INSTALLED, REMOVED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>A package managed by GooGet. Structure is documented below.</summary>
    [JsonPropertyName("googet")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgGooget? Googet { get; set; }

    /// <summary>An MSI package. Structure is documented below.</summary>
    [JsonPropertyName("msi")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgMsi? Msi { get; set; }

    /// <summary>An rpm package file. Structure is documented below.</summary>
    [JsonPropertyName("rpm")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgRpm? Rpm { get; set; }

    /// <summary>A Yum Repository. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgYum? Yum { get; set; }

    /// <summary>A Zypper Repository. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkgZypper? Zypper { get; set; }
}

/// <summary>An Apt Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryApt
{
    /// <summary>Type of archive files in this repository. Possible values are: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC.</summary>
    [JsonPropertyName("archiveType")]
    public string? ArchiveType { get; set; }

    /// <summary>List of components for this repository. Must contain at least one item.</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>URI of the key file for this repository. The agent maintains a keyring at /etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg.</summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A Goo Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryGoo
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The url of the repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Yum Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryYum
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Zypper Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryZypper
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Package repository resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepository
{
    /// <summary>An Apt Repository. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryApt? Apt { get; set; }

    /// <summary>A Goo Repository. Structure is documented below.</summary>
    [JsonPropertyName("goo")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryGoo? Goo { get; set; }

    /// <summary>A Yum Repository. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryYum? Yum { get; set; }

    /// <summary>A Zypper Repository. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepositoryZypper? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResources
{
    /// <summary>Exec resource Structure is documented below.</summary>
    [JsonPropertyName("exec")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesExec? Exec { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesFile? File { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Package resource Structure is documented below.</summary>
    [JsonPropertyName("pkg")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesPkg? Pkg { get; set; }

    /// <summary>Package repository resource Structure is documented below.</summary>
    [JsonPropertyName("repository")]
    public V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResourcesRepository? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroups
{
    /// <summary>List of inventory filters for the resource group. The resources in this resource group are applied to the target VM if it satisfies at least one of the following inventory filters. For example, to apply this resource group to VMs running either RHEL or CentOS operating systems, specify 2 items for the list with following values: inventory_filters[0].os_short_name='rhel' and inventory_filters[1].os_short_name='centos' If the list is empty, this resource group will be applied to the target VM unconditionally. Structure is documented below.</summary>
    [JsonPropertyName("inventoryFilters")]
    public IList<V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsInventoryFilters>? InventoryFilters { get; set; }

    /// <summary>List of resources configured for this resource group. The resources are executed in the exact order specified here. Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroupsResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderOsPolicies
{
    /// <summary>This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to true if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.</summary>
    [JsonPropertyName("allowNoResourceGroupMatch")]
    public bool? AllowNoResourceGroupMatch { get; set; }

    /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The id of the OS policy with the following restrictions:</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy mode Possible values are: MODE_UNSPECIFIED, VALIDATION, ENFORCEMENT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>List of resource groups for the policy. For a particular VM, resource groups are evaluated in the order specified and the first resource group that is applicable is selected and the rest are ignored. If none of the resource groups are applicable for a VM, the VM is considered to be non-compliant w.r.t this policy. This behavior can be toggled by the flag allow_no_resource_group_match Structure is documented below.</summary>
    [JsonPropertyName("resourceGroups")]
    public IList<V1beta1OsPolicyAssignmentSpecForProviderOsPoliciesResourceGroups>? ResourceGroups { get; set; }
}

/// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProviderRollout
{
    /// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. Structure is documented below.</summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta1OsPolicyAssignmentSpecForProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the disruption_budget at least until this duration of time has passed after configuration changes are applied.</summary>
    [JsonPropertyName("minWaitDuration")]
    public string? MinWaitDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecForProvider
{
    /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Filter to select VMs. Structure is documented below.</summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta1OsPolicyAssignmentSpecForProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>List of OS policies to be applied to the VMs. Structure is documented below.</summary>
    [JsonPropertyName("osPolicies")]
    public IList<V1beta1OsPolicyAssignmentSpecForProviderOsPolicies>? OsPolicies { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted. Structure is documented below.</summary>
    [JsonPropertyName("rollout")]
    public V1beta1OsPolicyAssignmentSpecForProviderRollout? Rollout { get; set; }

    /// <summary>Set to true to skip awaiting rollout during resource creation and update.</summary>
    [JsonPropertyName("skipAwaitRollout")]
    public bool? SkipAwaitRollout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilterExclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilterInclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilterInventories
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of 7, specify the following value for this field 7.* An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>Filter to select VMs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilter
{
    /// <summary>Target all VMs in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>List of label sets used for VM exclusion. If the list has more than one label set, the VM is excluded if any of the label sets are applicable for the VM. Structure is documented below.</summary>
    [JsonPropertyName("exclusionLabels")]
    public IList<V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilterExclusionLabels>? ExclusionLabels { get; set; }

    /// <summary>List of label sets used for VM inclusion. If the list has more than one LabelSet, the VM is included if any of the label sets are applicable for the VM. Structure is documented below.</summary>
    [JsonPropertyName("inclusionLabels")]
    public IList<V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilterInclusionLabels>? InclusionLabels { get; set; }

    /// <summary>List of inventories to select VMs. A VM is selected if its inventory data matches at least one of the following inventories. Structure is documented below.</summary>
    [JsonPropertyName("inventories")]
    public IList<V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilterInventories>? Inventories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsInventoryFilters
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of 7, specify the following value for this field 7.* An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote? Remote { get; set; }
}

/// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforce
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforceFile? File { get; set; }

    /// <summary>The script interpreter to use. Possible values are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote? Remote { get; set; }
}

/// <summary>What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidate
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidateFile? File { get; set; }

    /// <summary>The script interpreter to use. Possible values are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>Exec resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExec
{
    /// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce. Structure is documented below.</summary>
    [JsonPropertyName("enforce")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecEnforce? Enforce { get; set; }

    /// <summary>What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate. Structure is documented below.</summary>
    [JsonPropertyName("validate")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExecValidate? Validate { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFileRemote? Remote { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFile
{
    /// <summary>A a file with this content. The size of the content is limited to 1024 characters.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFileFile? File { get; set; }

    /// <summary>The absolute path of the file within the VM.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Desired state of the file. Possible values are: DESIRED_STATE_UNSPECIFIED, PRESENT, ABSENT, CONTENTS_MATCH.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>An Apt Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgApt
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote? Remote { get; set; }
}

/// <summary>A deb package file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDeb
{
    /// <summary>Whether dependencies should also be installed. - install when false: rpm --upgrade --replacepkgs package.rpm - install when true: yum -y install package.rpm or zypper -y install package.rpm</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDebSource? Source { get; set; }
}

/// <summary>A package managed by GooGet. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgGooget
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote? Remote { get; set; }
}

/// <summary>An MSI package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsi
{
    /// <summary>Additional properties to use during installation. This should be in the format of Property=Setting. Appended to the defaults of ACTION=INSTALL REBOOT=ReallySuppress.</summary>
    [JsonPropertyName("properties")]
    public IList<string>? Properties { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsiSource? Source { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote? Remote { get; set; }
}

/// <summary>An rpm package file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpm
{
    /// <summary>Whether dependencies should also be installed. - install when false: rpm --upgrade --replacepkgs package.rpm - install when true: yum -y install package.rpm or zypper -y install package.rpm</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpmSource? Source { get; set; }
}

/// <summary>A Yum Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgYum
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Zypper Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgZypper
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Package resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkg
{
    /// <summary>An Apt Repository. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgApt? Apt { get; set; }

    /// <summary>A deb package file. Structure is documented below.</summary>
    [JsonPropertyName("deb")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgDeb? Deb { get; set; }

    /// <summary>The desired state the agent should maintain for this package. Possible values are: DESIRED_STATE_UNSPECIFIED, INSTALLED, REMOVED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>A package managed by GooGet. Structure is documented below.</summary>
    [JsonPropertyName("googet")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgGooget? Googet { get; set; }

    /// <summary>An MSI package. Structure is documented below.</summary>
    [JsonPropertyName("msi")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgMsi? Msi { get; set; }

    /// <summary>An rpm package file. Structure is documented below.</summary>
    [JsonPropertyName("rpm")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgRpm? Rpm { get; set; }

    /// <summary>A Yum Repository. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgYum? Yum { get; set; }

    /// <summary>A Zypper Repository. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkgZypper? Zypper { get; set; }
}

/// <summary>An Apt Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryApt
{
    /// <summary>Type of archive files in this repository. Possible values are: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC.</summary>
    [JsonPropertyName("archiveType")]
    public string? ArchiveType { get; set; }

    /// <summary>List of components for this repository. Must contain at least one item.</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>URI of the key file for this repository. The agent maintains a keyring at /etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg.</summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A Goo Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryGoo
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The url of the repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Yum Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryYum
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Zypper Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryZypper
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Package repository resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepository
{
    /// <summary>An Apt Repository. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryApt? Apt { get; set; }

    /// <summary>A Goo Repository. Structure is documented below.</summary>
    [JsonPropertyName("goo")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryGoo? Goo { get; set; }

    /// <summary>A Yum Repository. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryYum? Yum { get; set; }

    /// <summary>A Zypper Repository. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepositoryZypper? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResources
{
    /// <summary>Exec resource Structure is documented below.</summary>
    [JsonPropertyName("exec")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesExec? Exec { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesFile? File { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Package resource Structure is documented below.</summary>
    [JsonPropertyName("pkg")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesPkg? Pkg { get; set; }

    /// <summary>Package repository resource Structure is documented below.</summary>
    [JsonPropertyName("repository")]
    public V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResourcesRepository? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroups
{
    /// <summary>List of inventory filters for the resource group. The resources in this resource group are applied to the target VM if it satisfies at least one of the following inventory filters. For example, to apply this resource group to VMs running either RHEL or CentOS operating systems, specify 2 items for the list with following values: inventory_filters[0].os_short_name='rhel' and inventory_filters[1].os_short_name='centos' If the list is empty, this resource group will be applied to the target VM unconditionally. Structure is documented below.</summary>
    [JsonPropertyName("inventoryFilters")]
    public IList<V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsInventoryFilters>? InventoryFilters { get; set; }

    /// <summary>List of resources configured for this resource group. The resources are executed in the exact order specified here. Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroupsResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderOsPolicies
{
    /// <summary>This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to true if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.</summary>
    [JsonPropertyName("allowNoResourceGroupMatch")]
    public bool? AllowNoResourceGroupMatch { get; set; }

    /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The id of the OS policy with the following restrictions:</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy mode Possible values are: MODE_UNSPECIFIED, VALIDATION, ENFORCEMENT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>List of resource groups for the policy. For a particular VM, resource groups are evaluated in the order specified and the first resource group that is applicable is selected and the rest are ignored. If none of the resource groups are applicable for a VM, the VM is considered to be non-compliant w.r.t this policy. This behavior can be toggled by the flag allow_no_resource_group_match Structure is documented below.</summary>
    [JsonPropertyName("resourceGroups")]
    public IList<V1beta1OsPolicyAssignmentSpecInitProviderOsPoliciesResourceGroups>? ResourceGroups { get; set; }
}

/// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProviderRollout
{
    /// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. Structure is documented below.</summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta1OsPolicyAssignmentSpecInitProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the disruption_budget at least until this duration of time has passed after configuration changes are applied.</summary>
    [JsonPropertyName("minWaitDuration")]
    public string? MinWaitDuration { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecInitProvider
{
    /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Filter to select VMs. Structure is documented below.</summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta1OsPolicyAssignmentSpecInitProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>List of OS policies to be applied to the VMs. Structure is documented below.</summary>
    [JsonPropertyName("osPolicies")]
    public IList<V1beta1OsPolicyAssignmentSpecInitProviderOsPolicies>? OsPolicies { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted. Structure is documented below.</summary>
    [JsonPropertyName("rollout")]
    public V1beta1OsPolicyAssignmentSpecInitProviderRollout? Rollout { get; set; }

    /// <summary>Set to true to skip awaiting rollout during resource creation and update.</summary>
    [JsonPropertyName("skipAwaitRollout")]
    public bool? SkipAwaitRollout { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>OsPolicyAssignmentSpec defines the desired state of OsPolicyAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OsPolicyAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OsPolicyAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OsPolicyAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OsPolicyAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilterExclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilterInclusionLabels
{
    /// <summary>Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilterInventories
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of 7, specify the following value for this field 7.* An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>Filter to select VMs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilter
{
    /// <summary>Target all VMs in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>List of label sets used for VM exclusion. If the list has more than one label set, the VM is excluded if any of the label sets are applicable for the VM. Structure is documented below.</summary>
    [JsonPropertyName("exclusionLabels")]
    public IList<V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilterExclusionLabels>? ExclusionLabels { get; set; }

    /// <summary>List of label sets used for VM inclusion. If the list has more than one LabelSet, the VM is included if any of the label sets are applicable for the VM. Structure is documented below.</summary>
    [JsonPropertyName("inclusionLabels")]
    public IList<V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilterInclusionLabels>? InclusionLabels { get; set; }

    /// <summary>List of inventories to select VMs. A VM is selected if its inventory data matches at least one of the following inventories. Structure is documented below.</summary>
    [JsonPropertyName("inventories")]
    public IList<V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilterInventories>? Inventories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsInventoryFilters
{
    /// <summary>The OS short name</summary>
    [JsonPropertyName("osShortName")]
    public string? OsShortName { get; set; }

    /// <summary>The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of 7, specify the following value for this field 7.* An empty string matches all OS versions.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFileRemote? Remote { get; set; }
}

/// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforce
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforceFile? File { get; set; }

    /// <summary>The script interpreter to use. Possible values are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFileRemote? Remote { get; set; }
}

/// <summary>What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidate
{
    /// <summary>Optional arguments to pass to the source during execution.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidateFile? File { get; set; }

    /// <summary>The script interpreter to use. Possible values are: INTERPRETER_UNSPECIFIED, NONE, SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.</summary>
    [JsonPropertyName("outputFilePath")]
    public string? OutputFilePath { get; set; }

    /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }
}

/// <summary>Exec resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExec
{
    /// <summary>What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any other exit code indicates a failure running enforce. Structure is documented below.</summary>
    [JsonPropertyName("enforce")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecEnforce? Enforce { get; set; }

    /// <summary>What to run to validate this resource is in the desired state. An exit code of 100 indicates "in desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a failure running validate. Structure is documented below.</summary>
    [JsonPropertyName("validate")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExecValidate? Validate { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFile
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFileRemote? Remote { get; set; }
}

/// <summary>A remote or local file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFile
{
    /// <summary>A a file with this content. The size of the content is limited to 1024 characters.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFileFile? File { get; set; }

    /// <summary>The absolute path of the file within the VM.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>(Output) Consists of three octal digits which represent, in order, the permissions of the owner, group, and other users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write bit, and the one bit corresponds to the execute permission. Default behavior is 755. Below are some examples of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write: 6 read only: 4</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }

    /// <summary>Desired state of the file. Possible values are: DESIRED_STATE_UNSPECIFIED, PRESENT, ABSENT, CONTENTS_MATCH.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>An Apt Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgApt
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSourceRemote? Remote { get; set; }
}

/// <summary>A deb package file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDeb
{
    /// <summary>Whether dependencies should also be installed. - install when false: rpm --upgrade --replacepkgs package.rpm - install when true: yum -y install package.rpm or zypper -y install package.rpm</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDebSource? Source { get; set; }
}

/// <summary>A package managed by GooGet. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgGooget
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSourceRemote? Remote { get; set; }
}

/// <summary>An MSI package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsi
{
    /// <summary>Additional properties to use during installation. This should be in the format of Property=Setting. Appended to the defaults of ACTION=INSTALL REBOOT=ReallySuppress.</summary>
    [JsonPropertyName("properties")]
    public IList<string>? Properties { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsiSource? Source { get; set; }
}

/// <summary>A Cloud Storage object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>A generic remote file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote
{
    /// <summary>SHA256 checksum of the remote file.</summary>
    [JsonPropertyName("sha256Checksum")]
    public string? Sha256Checksum { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>An rpm package. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSource
{
    /// <summary>Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.</summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>A Cloud Storage object. Structure is documented below.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceGcs? Gcs { get; set; }

    /// <summary>A local path within the VM to use.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>A generic remote file. Structure is documented below.</summary>
    [JsonPropertyName("remote")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSourceRemote? Remote { get; set; }
}

/// <summary>An rpm package file. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpm
{
    /// <summary>Whether dependencies should also be installed. - install when false: rpm --upgrade --replacepkgs package.rpm - install when true: yum -y install package.rpm or zypper -y install package.rpm</summary>
    [JsonPropertyName("pullDeps")]
    public bool? PullDeps { get; set; }

    /// <summary>An rpm package. Structure is documented below.</summary>
    [JsonPropertyName("source")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpmSource? Source { get; set; }
}

/// <summary>A Yum Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgYum
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A Zypper Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgZypper
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Package resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkg
{
    /// <summary>An Apt Repository. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgApt? Apt { get; set; }

    /// <summary>A deb package file. Structure is documented below.</summary>
    [JsonPropertyName("deb")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgDeb? Deb { get; set; }

    /// <summary>The desired state the agent should maintain for this package. Possible values are: DESIRED_STATE_UNSPECIFIED, INSTALLED, REMOVED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>A package managed by GooGet. Structure is documented below.</summary>
    [JsonPropertyName("googet")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgGooget? Googet { get; set; }

    /// <summary>An MSI package. Structure is documented below.</summary>
    [JsonPropertyName("msi")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgMsi? Msi { get; set; }

    /// <summary>An rpm package file. Structure is documented below.</summary>
    [JsonPropertyName("rpm")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgRpm? Rpm { get; set; }

    /// <summary>A Yum Repository. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgYum? Yum { get; set; }

    /// <summary>A Zypper Repository. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkgZypper? Zypper { get; set; }
}

/// <summary>An Apt Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryApt
{
    /// <summary>Type of archive files in this repository. Possible values are: ARCHIVE_TYPE_UNSPECIFIED, DEB, DEB_SRC.</summary>
    [JsonPropertyName("archiveType")]
    public string? ArchiveType { get; set; }

    /// <summary>List of components for this repository. Must contain at least one item.</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Distribution of this repository.</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

    /// <summary>URI of the key file for this repository. The agent maintains a keyring at /etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg.</summary>
    [JsonPropertyName("gpgKey")]
    public string? GpgKey { get; set; }

    /// <summary>URI from which to fetch the object. It should contain both the protocol and path following the format {protocol}://{location}.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>A Goo Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryGoo
{
    /// <summary>Package name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The url of the repository.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Yum Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryYum
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Zypper Repository. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryZypper
{
    /// <summary>The location of the repository directory.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>The display name of the repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>URIs of GPG keys.</summary>
    [JsonPropertyName("gpgKeys")]
    public IList<string>? GpgKeys { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Package repository resource Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepository
{
    /// <summary>An Apt Repository. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryApt? Apt { get; set; }

    /// <summary>A Goo Repository. Structure is documented below.</summary>
    [JsonPropertyName("goo")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryGoo? Goo { get; set; }

    /// <summary>A Yum Repository. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryYum? Yum { get; set; }

    /// <summary>A Zypper Repository. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepositoryZypper? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResources
{
    /// <summary>Exec resource Structure is documented below.</summary>
    [JsonPropertyName("exec")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesExec? Exec { get; set; }

    /// <summary>A remote or local file. Structure is documented below.</summary>
    [JsonPropertyName("file")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesFile? File { get; set; }

    /// <summary>A one word, unique name for this repository. This is the repo id in the zypper config file and also the display_name if display_name is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Package resource Structure is documented below.</summary>
    [JsonPropertyName("pkg")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesPkg? Pkg { get; set; }

    /// <summary>Package repository resource Structure is documented below.</summary>
    [JsonPropertyName("repository")]
    public V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResourcesRepository? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroups
{
    /// <summary>List of inventory filters for the resource group. The resources in this resource group are applied to the target VM if it satisfies at least one of the following inventory filters. For example, to apply this resource group to VMs running either RHEL or CentOS operating systems, specify 2 items for the list with following values: inventory_filters[0].os_short_name='rhel' and inventory_filters[1].os_short_name='centos' If the list is empty, this resource group will be applied to the target VM unconditionally. Structure is documented below.</summary>
    [JsonPropertyName("inventoryFilters")]
    public IList<V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsInventoryFilters>? InventoryFilters { get; set; }

    /// <summary>List of resources configured for this resource group. The resources are executed in the exact order specified here. Structure is documented below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroupsResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderOsPolicies
{
    /// <summary>This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to true if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.</summary>
    [JsonPropertyName("allowNoResourceGroupMatch")]
    public bool? AllowNoResourceGroupMatch { get; set; }

    /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The id of the OS policy with the following restrictions:</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy mode Possible values are: MODE_UNSPECIFIED, VALIDATION, ENFORCEMENT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>List of resource groups for the policy. For a particular VM, resource groups are evaluated in the order specified and the first resource group that is applicable is selected and the rest are ignored. If none of the resource groups are applicable for a VM, the VM is considered to be non-compliant w.r.t this policy. This behavior can be toggled by the flag allow_no_resource_group_match Structure is documented below.</summary>
    [JsonPropertyName("resourceGroups")]
    public IList<V1beta1OsPolicyAssignmentStatusAtProviderOsPoliciesResourceGroups>? ResourceGroups { get; set; }
}

/// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProviderRollout
{
    /// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. Structure is documented below.</summary>
    [JsonPropertyName("disruptionBudget")]
    public V1beta1OsPolicyAssignmentStatusAtProviderRolloutDisruptionBudget? DisruptionBudget { get; set; }

    /// <summary>This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the disruption_budget at least until this duration of time has passed after configuration changes are applied.</summary>
    [JsonPropertyName("minWaitDuration")]
    public string? MinWaitDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusAtProvider
{
    /// <summary>Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision. For a given OS policy assignment, there is only one revision with a value of true for this field.</summary>
    [JsonPropertyName("baseline")]
    public bool? Baseline { get; set; }

    /// <summary>Output only. Indicates that this revision deletes the OS policy assignment.</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The etag for this OS policy assignment. If this is provided on update, it must match the server's etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/osPolicyAssignments/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Filter to select VMs. Structure is documented below.</summary>
    [JsonPropertyName("instanceFilter")]
    public V1beta1OsPolicyAssignmentStatusAtProviderInstanceFilter? InstanceFilter { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>List of OS policies to be applied to the VMs. Structure is documented below.</summary>
    [JsonPropertyName("osPolicies")]
    public IList<V1beta1OsPolicyAssignmentStatusAtProviderOsPolicies>? OsPolicies { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Output only. Indicates that reconciliation is in progress for the revision. This value is true when the rollout_state is one of:</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The timestamp that the revision was created.</summary>
    [JsonPropertyName("revisionCreateTime")]
    public string? RevisionCreateTime { get; set; }

    /// <summary>Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment</summary>
    [JsonPropertyName("revisionId")]
    public string? RevisionId { get; set; }

    /// <summary>Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted. Structure is documented below.</summary>
    [JsonPropertyName("rollout")]
    public V1beta1OsPolicyAssignmentStatusAtProviderRollout? Rollout { get; set; }

    /// <summary>Output only. OS policy assignment rollout state</summary>
    [JsonPropertyName("rolloutState")]
    public string? RolloutState { get; set; }

    /// <summary>Set to true to skip awaiting rollout during resource creation and update.</summary>
    [JsonPropertyName("skipAwaitRollout")]
    public bool? SkipAwaitRollout { get; set; }

    /// <summary>Output only. Server generated unique id for the OS policy assignment resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatusConditions
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

/// <summary>OsPolicyAssignmentStatus defines the observed state of OsPolicyAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OsPolicyAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OsPolicyAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OsPolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OsPolicyAssignment is the Schema for the OsPolicyAssignments API. OS policy assignment is an API resource that is used to apply a set of OS policies to a dynamically targeted group of Compute Engine VM instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OsPolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OsPolicyAssignmentSpec>, IStatus<V1beta1OsPolicyAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OsPolicyAssignment";
    public const string KubeGroup = "osconfig.gcp.m.upbound.io";
    public const string KubePluralName = "ospolicyassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OsPolicyAssignmentSpec defines the desired state of OsPolicyAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1OsPolicyAssignmentSpec Spec { get; set; }

    /// <summary>OsPolicyAssignmentStatus defines the observed state of OsPolicyAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1OsPolicyAssignmentStatus? Status { get; set; }
}

/// <summary>OsPolicyAssignment is the Schema for the OsPolicyAssignments API. OS policy assignment is an API resource that is used to apply a set of OS policies to a dynamically targeted group of Compute Engine VM instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OsPolicyAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OsPolicyAssignment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OsPolicyAssignmentList";
    public const string KubeGroup = "osconfig.gcp.m.upbound.io";
    public const string KubePluralName = "ospolicyassignments";
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
    public IList<V1beta1OsPolicyAssignment> Items { get; set; }
}