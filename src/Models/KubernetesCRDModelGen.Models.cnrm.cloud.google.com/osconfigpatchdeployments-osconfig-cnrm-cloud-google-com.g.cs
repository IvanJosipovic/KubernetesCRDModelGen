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
public partial class V1alpha1OSConfigPatchDeploymentSpecInstanceFilterGroupLabels
{
    /// <summary>Immutable. Compute Engine instance labels that must be present for a VM instance to be targeted by this filter.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string> Labels { get; set; }
}

/// <summary>Immutable. VM instances to patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecInstanceFilter
{
    /// <summary>Immutable. Target all VM instances in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>Immutable. Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM instances.</summary>
    [JsonPropertyName("groupLabels")]
    public IList<V1alpha1OSConfigPatchDeploymentSpecInstanceFilterGroupLabels>? GroupLabels { get; set; }

    /// <summary>Immutable. Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group VMs when targeting configs, for example prefix="prod-".</summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>Immutable. Targets any of the VM instances specified. Instances are specified by their URI in the 'form zones/{{zone}}/instances/{{instance_name}}', 'projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}', or 'https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}'.</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>Immutable. Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Immutable. Schedule a one-time execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecOneTimeSchedule
{
    /// <summary>Immutable. The desired patch job execution time. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("executeTime")]
    public string ExecuteTime { get; set; }
}

/// <summary>Immutable. Apt update settings. Use this setting to override the default apt patch rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigApt
{
    /// <summary>Immutable. List of packages to exclude from update. These packages will be excluded.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>Immutable. An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Immutable. By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead. Possible values: ["DIST", "UPGRADE"].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Immutable. goo update settings. Use this setting to override the default goo patch rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigGoo
{
    /// <summary>Immutable. goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepLinuxExecStepConfigGcsObject
{
    /// <summary>Immutable. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Immutable. Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string GenerationNumber { get; set; }

    /// <summary>Immutable. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>Immutable. The ExecStepConfig for all Linux VMs targeted by the PatchJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepLinuxExecStepConfig
{
    /// <summary>Immutable. Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<int>? AllowedSuccessCodes { get; set; }

    /// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
    [JsonPropertyName("gcsObject")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>Immutable. The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: ["SHELL", "POWERSHELL"].</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Immutable. An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepWindowsExecStepConfigGcsObject
{
    /// <summary>Immutable. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Immutable. Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string GenerationNumber { get; set; }

    /// <summary>Immutable. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>Immutable. The ExecStepConfig for all Windows VMs targeted by the PatchJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepWindowsExecStepConfig
{
    /// <summary>Immutable. Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<int>? AllowedSuccessCodes { get; set; }

    /// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
    [JsonPropertyName("gcsObject")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>Immutable. The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: ["SHELL", "POWERSHELL"].</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Immutable. An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>Immutable. The ExecStep to run after the patch update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStep
{
    /// <summary>Immutable. The ExecStepConfig for all Linux VMs targeted by the PatchJob.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>Immutable. The ExecStepConfig for all Windows VMs targeted by the PatchJob.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepLinuxExecStepConfigGcsObject
{
    /// <summary>Immutable. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Immutable. Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string GenerationNumber { get; set; }

    /// <summary>Immutable. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>Immutable. The ExecStepConfig for all Linux VMs targeted by the PatchJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepLinuxExecStepConfig
{
    /// <summary>Immutable. Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<int>? AllowedSuccessCodes { get; set; }

    /// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
    [JsonPropertyName("gcsObject")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepLinuxExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>Immutable. The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: ["SHELL", "POWERSHELL"].</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Immutable. An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepWindowsExecStepConfigGcsObject
{
    /// <summary>Immutable. Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>Immutable. Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string GenerationNumber { get; set; }

    /// <summary>Immutable. Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string Object { get; set; }
}

/// <summary>Immutable. The ExecStepConfig for all Windows VMs targeted by the PatchJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepWindowsExecStepConfig
{
    /// <summary>Immutable. Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<int>? AllowedSuccessCodes { get; set; }

    /// <summary>Immutable. A Cloud Storage object containing the executable.</summary>
    [JsonPropertyName("gcsObject")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepWindowsExecStepConfigGcsObject? GcsObject { get; set; }

    /// <summary>Immutable. The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: ["SHELL", "POWERSHELL"].</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>Immutable. An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary>Immutable. The ExecStep to run before the patch update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStep
{
    /// <summary>Immutable. The ExecStepConfig for all Linux VMs targeted by the PatchJob.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepLinuxExecStepConfig? LinuxExecStepConfig { get; set; }

    /// <summary>Immutable. The ExecStepConfig for all Windows VMs targeted by the PatchJob.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStepWindowsExecStepConfig? WindowsExecStepConfig { get; set; }
}

/// <summary>Immutable. Windows update settings. Use this setting to override the default Windows patch rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigWindowsUpdate
{
    /// <summary>Immutable. Only apply updates of these windows update classifications. If empty, all updates are applied. Possible values: ["CRITICAL", "SECURITY", "DEFINITION", "DRIVER", "FEATURE_PACK", "SERVICE_PACK", "TOOL", "UPDATE_ROLLUP", "UPDATE"].</summary>
    [JsonPropertyName("classifications")]
    public IList<string>? Classifications { get; set; }

    /// <summary>Immutable. List of KBs to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>Immutable. An exclusive list of kbs to be updated. These are the only patches that will be updated. This field must not be used with other patch configurations.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }
}

/// <summary>Immutable. Yum update settings. Use this setting to override the default yum patch rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigYum
{
    /// <summary>Immutable. List of packages to exclude from update. These packages will be excluded.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>Immutable. An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Immutable. Will cause patch to run yum update-minimal instead.</summary>
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; set; }

    /// <summary>Immutable. Adds the --security flag to yum update. Not supported on all platforms.</summary>
    [JsonPropertyName("security")]
    public bool? Security { get; set; }
}

/// <summary>Immutable. zypper update settings. Use this setting to override the default zypper patch rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfigZypper
{
    /// <summary>Immutable. Install only patches with these categories. Common categories include security, recommended, and feature.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>Immutable. List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>Immutable. An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper patch patch:' command. This field must not be used with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }

    /// <summary>Immutable. Install only patches with these severities. Common severities include critical, important, moderate, and low.</summary>
    [JsonPropertyName("severities")]
    public IList<string>? Severities { get; set; }

    /// <summary>Immutable. Adds the --with-optional flag to zypper patch.</summary>
    [JsonPropertyName("withOptional")]
    public bool? WithOptional { get; set; }

    /// <summary>Immutable. Adds the --with-update flag, to zypper patch.</summary>
    [JsonPropertyName("withUpdate")]
    public bool? WithUpdate { get; set; }
}

/// <summary>Immutable. Patch configuration that is applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecPatchConfig
{
    /// <summary>Immutable. Apt update settings. Use this setting to override the default apt patch rules.</summary>
    [JsonPropertyName("apt")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigApt? Apt { get; set; }

    /// <summary>Immutable. goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("goo")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigGoo? Goo { get; set; }

    /// <summary>Immutable. Allows the patch job to run on Managed instance groups (MIGs).</summary>
    [JsonPropertyName("migInstancesAllowed")]
    public bool? MigInstancesAllowed { get; set; }

    /// <summary>Immutable. The ExecStep to run after the patch update.</summary>
    [JsonPropertyName("postStep")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPostStep? PostStep { get; set; }

    /// <summary>Immutable. The ExecStep to run before the patch update.</summary>
    [JsonPropertyName("preStep")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigPreStep? PreStep { get; set; }

    /// <summary>Immutable. Post-patch reboot settings. Possible values: ["DEFAULT", "ALWAYS", "NEVER"].</summary>
    [JsonPropertyName("rebootConfig")]
    public string? RebootConfig { get; set; }

    /// <summary>Immutable. Windows update settings. Use this setting to override the default Windows patch rules.</summary>
    [JsonPropertyName("windowsUpdate")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigWindowsUpdate? WindowsUpdate { get; set; }

    /// <summary>Immutable. Yum update settings. Use this setting to override the default yum patch rules.</summary>
    [JsonPropertyName("yum")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigYum? Yum { get; set; }

    /// <summary>Immutable. zypper update settings. Use this setting to override the default zypper patch rules.</summary>
    [JsonPropertyName("zypper")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfigZypper? Zypper { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Week day in a month.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleMonthlyWeekDayOfMonth
{
    /// <summary>Immutable. A day of the week. Possible values: ["MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"].</summary>
    [JsonPropertyName("dayOfWeek")]
    public string DayOfWeek { get; set; }

    /// <summary>Immutable. Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.</summary>
    [JsonPropertyName("weekOrdinal")]
    public int WeekOrdinal { get; set; }
}

/// <summary>Immutable. Schedule with monthly executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleMonthly
{
    /// <summary>Immutable. One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month. Months without the target day will be skipped. For example, a schedule to run "every month on the 31st" will not run in February, April, June, etc.</summary>
    [JsonPropertyName("monthDay")]
    public int? MonthDay { get; set; }

    /// <summary>Immutable. Week day in a month.</summary>
    [JsonPropertyName("weekDayOfMonth")]
    public V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleMonthlyWeekDayOfMonth? WeekDayOfMonth { get; set; }
}

/// <summary>Immutable. Time of the day to run a recurring deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleTimeOfDay
{
    /// <summary>Immutable. Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Immutable. Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Immutable. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Immutable. Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}

/// <summary>Immutable. Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are determined by the chosen time zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleTimeZone
{
    /// <summary>Immutable. IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Immutable. IANA Time Zone Database version number, e.g. "2019a".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Immutable. Schedule with weekly executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleWeekly
{
    /// <summary>Immutable. IANA Time Zone Database time zone, e.g. "America/New_York". Possible values: ["MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"].</summary>
    [JsonPropertyName("dayOfWeek")]
    public string DayOfWeek { get; set; }
}

/// <summary>Immutable. Schedule recurring executions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRecurringSchedule
{
    /// <summary>Immutable. The end time at which a recurring patch deployment schedule is no longer active. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The time the last patch job ran successfully. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastExecuteTime")]
    public string? LastExecuteTime { get; set; }

    /// <summary>Immutable. Schedule with monthly executions.</summary>
    [JsonPropertyName("monthly")]
    public V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleMonthly? Monthly { get; set; }

    /// <summary>The time the next patch job is scheduled to run. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("nextExecuteTime")]
    public string? NextExecuteTime { get; set; }

    /// <summary>Immutable. The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Immutable. Time of the day to run a recurring deployment.</summary>
    [JsonPropertyName("timeOfDay")]
    public V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleTimeOfDay TimeOfDay { get; set; }

    /// <summary>Immutable. Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are determined by the chosen time zone.</summary>
    [JsonPropertyName("timeZone")]
    public V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleTimeZone TimeZone { get; set; }

    /// <summary>Immutable. Schedule with weekly executions.</summary>
    [JsonPropertyName("weekly")]
    public V1alpha1OSConfigPatchDeploymentSpecRecurringScheduleWeekly? Weekly { get; set; }
}

/// <summary>Immutable. The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up. During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps. A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget. For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone. For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRolloutDisruptionBudget
{
    /// <summary>Immutable. Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public int? Fixed { get; set; }

    /// <summary>Immutable. Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }
}

/// <summary>Immutable. Rollout strategy of the patch job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpecRollout
{
    /// <summary>Immutable. The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up. During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps. A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget. For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone. For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops.</summary>
    [JsonPropertyName("disruptionBudget")]
    public V1alpha1OSConfigPatchDeploymentSpecRolloutDisruptionBudget DisruptionBudget { get; set; }

    /// <summary>Immutable. Mode of the patch rollout. Possible values: ["ZONE_BY_ZONE", "CONCURRENT_ZONES"].</summary>
    [JsonPropertyName("mode")]
    public string Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentSpec
{
    /// <summary>Immutable. Description of the patch deployment. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Duration of the patch. After the duration ends, the patch times out. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Immutable. VM instances to patch.</summary>
    [JsonPropertyName("instanceFilter")]
    public V1alpha1OSConfigPatchDeploymentSpecInstanceFilter InstanceFilter { get; set; }

    /// <summary>Immutable. Schedule a one-time execution.</summary>
    [JsonPropertyName("oneTimeSchedule")]
    public V1alpha1OSConfigPatchDeploymentSpecOneTimeSchedule? OneTimeSchedule { get; set; }

    /// <summary>Immutable. Patch configuration that is applied.</summary>
    [JsonPropertyName("patchConfig")]
    public V1alpha1OSConfigPatchDeploymentSpecPatchConfig? PatchConfig { get; set; }

    /// <summary>Immutable. A name for the patch deployment in the project. When creating a name the following rules apply: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be unique within the project.</summary>
    [JsonPropertyName("patchDeploymentId")]
    public string PatchDeploymentId { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1OSConfigPatchDeploymentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Schedule recurring executions.</summary>
    [JsonPropertyName("recurringSchedule")]
    public V1alpha1OSConfigPatchDeploymentSpecRecurringSchedule? RecurringSchedule { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Rollout strategy of the patch job.</summary>
    [JsonPropertyName("rollout")]
    public V1alpha1OSConfigPatchDeploymentSpecRollout? Rollout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OSConfigPatchDeploymentStatusConditions
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
public partial class V1alpha1OSConfigPatchDeploymentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OSConfigPatchDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>Time the patch deployment was created. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastExecuteTime")]
    public string? LastExecuteTime { get; set; }

    /// <summary>Unique name for the patch deployment resource in a project. The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Time the patch deployment was last updated. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OSConfigPatchDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OSConfigPatchDeploymentSpec>, IStatus<V1alpha1OSConfigPatchDeploymentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OSConfigPatchDeployment";
    public const string KubeGroup = "osconfig.cnrm.cloud.google.com";
    public const string KubePluralName = "osconfigpatchdeployments";
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
    public V1alpha1OSConfigPatchDeploymentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1OSConfigPatchDeploymentStatus? Status { get; set; }
}