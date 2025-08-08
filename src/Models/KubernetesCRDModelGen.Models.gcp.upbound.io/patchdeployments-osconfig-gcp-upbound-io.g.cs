using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.osconfig.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderInstanceFilterGroupLabels
{
    /// <summary>Compute Engine instance labels that must be present for a VM instance to be targeted by this filter</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in compute to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderInstanceFilter
{
    /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM instances. Structure is documented below.</summary>
    [JsonPropertyName("groupLabels")]
    public IList<V1beta1PatchDeploymentSpecForProviderInstanceFilterGroupLabels>? GroupLabels { get; set; }

    /// <summary>Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group VMs when targeting configs, for example prefix="prod-".</summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>Targets any of the VM instances specified. Instances are specified by their URI in the form zones/{{zone}}/instances/{{instance_name}}, projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}, or https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta1PatchDeploymentSpecForProviderInstanceFilterInstancesSelector? InstancesSelector { get; set; }

    /// <summary>Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderOneTimeSchedule
{
    /// <summary>The desired patch job execution time. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("executeTime")]
    public string? ExecuteTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigApt
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead. Possible values are: DIST, UPGRADE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigGoo
{
    /// <summary>goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPostStep
{
    /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepLinuxExecStepConfig>? LinuxExecStepConfig { get; set; }

    /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPostStepWindowsExecStepConfig>? WindowsExecStepConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigPreStep
{
    /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepLinuxExecStepConfig>? LinuxExecStepConfig { get; set; }

    /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPreStepWindowsExecStepConfig>? WindowsExecStepConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigWindowsUpdate
{
    /// <summary>Only apply updates of these windows update classifications. If empty, all updates are applied. Each value may be one of: CRITICAL, SECURITY, DEFINITION, DRIVER, FEATURE_PACK, SERVICE_PACK, TOOL, UPDATE_ROLLUP, UPDATE.</summary>
    [JsonPropertyName("classifications")]
    public IList<string>? Classifications { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper patch patch:' command. This field must not be used with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigYum
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Will cause patch to run yum update-minimal instead.</summary>
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; set; }

    /// <summary>Adds the --security flag to yum update. Not supported on all platforms.</summary>
    [JsonPropertyName("security")]
    public bool? Security { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfigZypper
{
    /// <summary>Install only patches with these categories. Common categories include security, recommended, and feature.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper patch patch:' command. This field must not be used with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }

    /// <summary>Install only patches with these severities. Common severities include critical, important, moderate, and low.</summary>
    [JsonPropertyName("severities")]
    public IList<string>? Severities { get; set; }

    /// <summary>Adds the --with-optional flag to zypper patch.</summary>
    [JsonPropertyName("withOptional")]
    public bool? WithOptional { get; set; }

    /// <summary>Adds the --with-update flag, to zypper patch.</summary>
    [JsonPropertyName("withUpdate")]
    public bool? WithUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderPatchConfig
{
    /// <summary>Apt update settings. Use this setting to override the default apt patch rules. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigApt>? Apt { get; set; }

    /// <summary>goo update settings. Use this setting to override the default goo patch rules. Structure is documented below.</summary>
    [JsonPropertyName("goo")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigGoo>? Goo { get; set; }

    /// <summary>Allows the patch job to run on Managed instance groups (MIGs).</summary>
    [JsonPropertyName("migInstancesAllowed")]
    public bool? MigInstancesAllowed { get; set; }

    /// <summary>The ExecStep to run after the patch update. Structure is documented below.</summary>
    [JsonPropertyName("postStep")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPostStep>? PostStep { get; set; }

    /// <summary>The ExecStep to run before the patch update. Structure is documented below.</summary>
    [JsonPropertyName("preStep")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigPreStep>? PreStep { get; set; }

    /// <summary>Post-patch reboot settings. Possible values are: DEFAULT, ALWAYS, NEVER.</summary>
    [JsonPropertyName("rebootConfig")]
    public string? RebootConfig { get; set; }

    /// <summary>Windows update settings. Use this setting to override the default Windows patch rules. Structure is documented below.</summary>
    [JsonPropertyName("windowsUpdate")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigWindowsUpdate>? WindowsUpdate { get; set; }

    /// <summary>Yum update settings. Use this setting to override the default yum patch rules. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigYum>? Yum { get; set; }

    /// <summary>zypper update settings. Use this setting to override the default zypper patch rules. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfigZypper>? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRecurringScheduleMonthlyWeekDayOfMonth
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York". Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Represents the number of days before or after the given week day of month that the patch deployment is scheduled for.</summary>
    [JsonPropertyName("dayOffset")]
    public double? DayOffset { get; set; }

    /// <summary>Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.</summary>
    [JsonPropertyName("weekOrdinal")]
    public double? WeekOrdinal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRecurringScheduleMonthly
{
    /// <summary>One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month. Months without the target day will be skipped. For example, a schedule to run "every month on the 31st" will not run in February, April, June, etc.</summary>
    [JsonPropertyName("monthDay")]
    public double? MonthDay { get; set; }

    /// <summary>Week day in a month. Structure is documented below.</summary>
    [JsonPropertyName("weekDayOfMonth")]
    public IList<V1beta1PatchDeploymentSpecForProviderRecurringScheduleMonthlyWeekDayOfMonth>? WeekDayOfMonth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRecurringScheduleTimeOfDay
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRecurringScheduleTimeZone
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IANA Time Zone Database version number, e.g. "2019a".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRecurringScheduleWeekly
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York". Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRecurringSchedule
{
    /// <summary>The end time at which a recurring patch deployment schedule is no longer active. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Schedule with monthly executions. Structure is documented below.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1PatchDeploymentSpecForProviderRecurringScheduleMonthly>? Monthly { get; set; }

    /// <summary>The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Time of the day to run a recurring deployment. Structure is documented below.</summary>
    [JsonPropertyName("timeOfDay")]
    public IList<V1beta1PatchDeploymentSpecForProviderRecurringScheduleTimeOfDay>? TimeOfDay { get; set; }

    /// <summary>Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are determined by the chosen time zone. Structure is documented below.</summary>
    [JsonPropertyName("timeZone")]
    public IList<V1beta1PatchDeploymentSpecForProviderRecurringScheduleTimeZone>? TimeZone { get; set; }

    /// <summary>Schedule with weekly executions. Structure is documented below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1PatchDeploymentSpecForProviderRecurringScheduleWeekly>? Weekly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProviderRollout
{
    /// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up. During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps. A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget. For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone. For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops. Structure is documented below.</summary>
    [JsonPropertyName("disruptionBudget")]
    public IList<V1beta1PatchDeploymentSpecForProviderRolloutDisruptionBudget>? DisruptionBudget { get; set; }

    /// <summary>Mode of the patch rollout. Possible values are: ZONE_BY_ZONE, CONCURRENT_ZONES.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecForProvider
{
    /// <summary>Description of the patch deployment. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Duration of the patch. After the duration ends, the patch times out. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s"</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>VM instances to patch. Structure is documented below.</summary>
    [JsonPropertyName("instanceFilter")]
    public IList<V1beta1PatchDeploymentSpecForProviderInstanceFilter>? InstanceFilter { get; set; }

    /// <summary>Schedule a one-time execution. Structure is documented below.</summary>
    [JsonPropertyName("oneTimeSchedule")]
    public IList<V1beta1PatchDeploymentSpecForProviderOneTimeSchedule>? OneTimeSchedule { get; set; }

    /// <summary>Patch configuration that is applied. Structure is documented below.</summary>
    [JsonPropertyName("patchConfig")]
    public IList<V1beta1PatchDeploymentSpecForProviderPatchConfig>? PatchConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Schedule recurring executions. Structure is documented below.</summary>
    [JsonPropertyName("recurringSchedule")]
    public IList<V1beta1PatchDeploymentSpecForProviderRecurringSchedule>? RecurringSchedule { get; set; }

    /// <summary>Rollout strategy of the patch job. Structure is documented below.</summary>
    [JsonPropertyName("rollout")]
    public IList<V1beta1PatchDeploymentSpecForProviderRollout>? Rollout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderInstanceFilterGroupLabels
{
    /// <summary>Compute Engine instance labels that must be present for a VM instance to be targeted by this filter</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in compute to populate instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderInstanceFilter
{
    /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM instances. Structure is documented below.</summary>
    [JsonPropertyName("groupLabels")]
    public IList<V1beta1PatchDeploymentSpecInitProviderInstanceFilterGroupLabels>? GroupLabels { get; set; }

    /// <summary>Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group VMs when targeting configs, for example prefix="prod-".</summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>Targets any of the VM instances specified. Instances are specified by their URI in the form zones/{{zone}}/instances/{{instance_name}}, projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}, or https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>References to Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesRefs")]
    public IList<V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesRefs>? InstancesRefs { get; set; }

    /// <summary>Selector for a list of Instance in compute to populate instances.</summary>
    [JsonPropertyName("instancesSelector")]
    public V1beta1PatchDeploymentSpecInitProviderInstanceFilterInstancesSelector? InstancesSelector { get; set; }

    /// <summary>Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderOneTimeSchedule
{
    /// <summary>The desired patch job execution time. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("executeTime")]
    public string? ExecuteTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigApt
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead. Possible values are: DIST, UPGRADE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigGoo
{
    /// <summary>goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStep
{
    /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepLinuxExecStepConfig>? LinuxExecStepConfig { get; set; }

    /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStepWindowsExecStepConfig>? WindowsExecStepConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStep
{
    /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepLinuxExecStepConfig>? LinuxExecStepConfig { get; set; }

    /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStepWindowsExecStepConfig>? WindowsExecStepConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigWindowsUpdate
{
    /// <summary>Only apply updates of these windows update classifications. If empty, all updates are applied. Each value may be one of: CRITICAL, SECURITY, DEFINITION, DRIVER, FEATURE_PACK, SERVICE_PACK, TOOL, UPDATE_ROLLUP, UPDATE.</summary>
    [JsonPropertyName("classifications")]
    public IList<string>? Classifications { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper patch patch:' command. This field must not be used with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigYum
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Will cause patch to run yum update-minimal instead.</summary>
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; set; }

    /// <summary>Adds the --security flag to yum update. Not supported on all platforms.</summary>
    [JsonPropertyName("security")]
    public bool? Security { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfigZypper
{
    /// <summary>Install only patches with these categories. Common categories include security, recommended, and feature.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper patch patch:' command. This field must not be used with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }

    /// <summary>Install only patches with these severities. Common severities include critical, important, moderate, and low.</summary>
    [JsonPropertyName("severities")]
    public IList<string>? Severities { get; set; }

    /// <summary>Adds the --with-optional flag to zypper patch.</summary>
    [JsonPropertyName("withOptional")]
    public bool? WithOptional { get; set; }

    /// <summary>Adds the --with-update flag, to zypper patch.</summary>
    [JsonPropertyName("withUpdate")]
    public bool? WithUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderPatchConfig
{
    /// <summary>Apt update settings. Use this setting to override the default apt patch rules. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigApt>? Apt { get; set; }

    /// <summary>goo update settings. Use this setting to override the default goo patch rules. Structure is documented below.</summary>
    [JsonPropertyName("goo")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigGoo>? Goo { get; set; }

    /// <summary>Allows the patch job to run on Managed instance groups (MIGs).</summary>
    [JsonPropertyName("migInstancesAllowed")]
    public bool? MigInstancesAllowed { get; set; }

    /// <summary>The ExecStep to run after the patch update. Structure is documented below.</summary>
    [JsonPropertyName("postStep")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPostStep>? PostStep { get; set; }

    /// <summary>The ExecStep to run before the patch update. Structure is documented below.</summary>
    [JsonPropertyName("preStep")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigPreStep>? PreStep { get; set; }

    /// <summary>Post-patch reboot settings. Possible values are: DEFAULT, ALWAYS, NEVER.</summary>
    [JsonPropertyName("rebootConfig")]
    public string? RebootConfig { get; set; }

    /// <summary>Windows update settings. Use this setting to override the default Windows patch rules. Structure is documented below.</summary>
    [JsonPropertyName("windowsUpdate")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigWindowsUpdate>? WindowsUpdate { get; set; }

    /// <summary>Yum update settings. Use this setting to override the default yum patch rules. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigYum>? Yum { get; set; }

    /// <summary>zypper update settings. Use this setting to override the default zypper patch rules. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfigZypper>? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRecurringScheduleMonthlyWeekDayOfMonth
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York". Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Represents the number of days before or after the given week day of month that the patch deployment is scheduled for.</summary>
    [JsonPropertyName("dayOffset")]
    public double? DayOffset { get; set; }

    /// <summary>Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.</summary>
    [JsonPropertyName("weekOrdinal")]
    public double? WeekOrdinal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRecurringScheduleMonthly
{
    /// <summary>One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month. Months without the target day will be skipped. For example, a schedule to run "every month on the 31st" will not run in February, April, June, etc.</summary>
    [JsonPropertyName("monthDay")]
    public double? MonthDay { get; set; }

    /// <summary>Week day in a month. Structure is documented below.</summary>
    [JsonPropertyName("weekDayOfMonth")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRecurringScheduleMonthlyWeekDayOfMonth>? WeekDayOfMonth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRecurringScheduleTimeOfDay
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRecurringScheduleTimeZone
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IANA Time Zone Database version number, e.g. "2019a".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRecurringScheduleWeekly
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York". Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRecurringSchedule
{
    /// <summary>The end time at which a recurring patch deployment schedule is no longer active. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Schedule with monthly executions. Structure is documented below.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRecurringScheduleMonthly>? Monthly { get; set; }

    /// <summary>The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Time of the day to run a recurring deployment. Structure is documented below.</summary>
    [JsonPropertyName("timeOfDay")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRecurringScheduleTimeOfDay>? TimeOfDay { get; set; }

    /// <summary>Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are determined by the chosen time zone. Structure is documented below.</summary>
    [JsonPropertyName("timeZone")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRecurringScheduleTimeZone>? TimeZone { get; set; }

    /// <summary>Schedule with weekly executions. Structure is documented below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRecurringScheduleWeekly>? Weekly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProviderRollout
{
    /// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up. During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps. A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget. For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone. For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops. Structure is documented below.</summary>
    [JsonPropertyName("disruptionBudget")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRolloutDisruptionBudget>? DisruptionBudget { get; set; }

    /// <summary>Mode of the patch rollout. Possible values are: ZONE_BY_ZONE, CONCURRENT_ZONES.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecInitProvider
{
    /// <summary>Description of the patch deployment. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Duration of the patch. After the duration ends, the patch times out. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s"</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>VM instances to patch. Structure is documented below.</summary>
    [JsonPropertyName("instanceFilter")]
    public IList<V1beta1PatchDeploymentSpecInitProviderInstanceFilter>? InstanceFilter { get; set; }

    /// <summary>Schedule a one-time execution. Structure is documented below.</summary>
    [JsonPropertyName("oneTimeSchedule")]
    public IList<V1beta1PatchDeploymentSpecInitProviderOneTimeSchedule>? OneTimeSchedule { get; set; }

    /// <summary>Patch configuration that is applied. Structure is documented below.</summary>
    [JsonPropertyName("patchConfig")]
    public IList<V1beta1PatchDeploymentSpecInitProviderPatchConfig>? PatchConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Schedule recurring executions. Structure is documented below.</summary>
    [JsonPropertyName("recurringSchedule")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRecurringSchedule>? RecurringSchedule { get; set; }

    /// <summary>Rollout strategy of the patch job. Structure is documented below.</summary>
    [JsonPropertyName("rollout")]
    public IList<V1beta1PatchDeploymentSpecInitProviderRollout>? Rollout { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PatchDeploymentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PatchDeploymentSpec defines the desired state of PatchDeployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PatchDeploymentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PatchDeploymentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PatchDeploymentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PatchDeploymentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderInstanceFilterGroupLabels
{
    /// <summary>Compute Engine instance labels that must be present for a VM instance to be targeted by this filter</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderInstanceFilter
{
    /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM instances. Structure is documented below.</summary>
    [JsonPropertyName("groupLabels")]
    public IList<V1beta1PatchDeploymentStatusAtProviderInstanceFilterGroupLabels>? GroupLabels { get; set; }

    /// <summary>Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group VMs when targeting configs, for example prefix="prod-".</summary>
    [JsonPropertyName("instanceNamePrefixes")]
    public IList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>Targets any of the VM instances specified. Instances are specified by their URI in the form zones/{{zone}}/instances/{{instance_name}}, projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}, or https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}</summary>
    [JsonPropertyName("instances")]
    public IList<string>? Instances { get; set; }

    /// <summary>Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderOneTimeSchedule
{
    /// <summary>The desired patch job execution time. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("executeTime")]
    public string? ExecuteTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigApt
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead. Possible values are: DIST, UPGRADE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigGoo
{
    /// <summary>goo update settings. Use this setting to override the default goo patch rules.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStep
{
    /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepLinuxExecStepConfig>? LinuxExecStepConfig { get; set; }

    /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStepWindowsExecStepConfig>? WindowsExecStepConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfigGcsObject
{
    /// <summary>Bucket of the Cloud Storage object.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.</summary>
    [JsonPropertyName("generationNumber")]
    public string? GenerationNumber { get; set; }

    /// <summary>Name of the Cloud Storage object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfig
{
    /// <summary>Defaults to [0]. A list of possible return values that the execution can return to indicate a success.</summary>
    [JsonPropertyName("allowedSuccessCodes")]
    public IList<double>? AllowedSuccessCodes { get; set; }

    /// <summary>A Cloud Storage object containing the executable. Structure is documented below.</summary>
    [JsonPropertyName("gcsObject")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfigGcsObject>? GcsObject { get; set; }

    /// <summary>The script interpreter to use to run the script. If no interpreter is specified the script will be executed directly, which will likely only succeed for scripts with shebang lines. Possible values are: SHELL, POWERSHELL.</summary>
    [JsonPropertyName("interpreter")]
    public string? Interpreter { get; set; }

    /// <summary>An absolute path to the executable on the VM.</summary>
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStep
{
    /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("linuxExecStepConfig")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepLinuxExecStepConfig>? LinuxExecStepConfig { get; set; }

    /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob. Structure is documented below.</summary>
    [JsonPropertyName("windowsExecStepConfig")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStepWindowsExecStepConfig>? WindowsExecStepConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigWindowsUpdate
{
    /// <summary>Only apply updates of these windows update classifications. If empty, all updates are applied. Each value may be one of: CRITICAL, SECURITY, DEFINITION, DRIVER, FEATURE_PACK, SERVICE_PACK, TOOL, UPDATE_ROLLUP, UPDATE.</summary>
    [JsonPropertyName("classifications")]
    public IList<string>? Classifications { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper patch patch:' command. This field must not be used with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigYum
{
    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field cannot be specified with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePackages")]
    public IList<string>? ExclusivePackages { get; set; }

    /// <summary>Will cause patch to run yum update-minimal instead.</summary>
    [JsonPropertyName("minimal")]
    public bool? Minimal { get; set; }

    /// <summary>Adds the --security flag to yum update. Not supported on all platforms.</summary>
    [JsonPropertyName("security")]
    public bool? Security { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfigZypper
{
    /// <summary>Install only patches with these categories. Common categories include security, recommended, and feature.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>List of packages to exclude from update.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper patch patch:' command. This field must not be used with any other patch configuration fields.</summary>
    [JsonPropertyName("exclusivePatches")]
    public IList<string>? ExclusivePatches { get; set; }

    /// <summary>Install only patches with these severities. Common severities include critical, important, moderate, and low.</summary>
    [JsonPropertyName("severities")]
    public IList<string>? Severities { get; set; }

    /// <summary>Adds the --with-optional flag to zypper patch.</summary>
    [JsonPropertyName("withOptional")]
    public bool? WithOptional { get; set; }

    /// <summary>Adds the --with-update flag, to zypper patch.</summary>
    [JsonPropertyName("withUpdate")]
    public bool? WithUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderPatchConfig
{
    /// <summary>Apt update settings. Use this setting to override the default apt patch rules. Structure is documented below.</summary>
    [JsonPropertyName("apt")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigApt>? Apt { get; set; }

    /// <summary>goo update settings. Use this setting to override the default goo patch rules. Structure is documented below.</summary>
    [JsonPropertyName("goo")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigGoo>? Goo { get; set; }

    /// <summary>Allows the patch job to run on Managed instance groups (MIGs).</summary>
    [JsonPropertyName("migInstancesAllowed")]
    public bool? MigInstancesAllowed { get; set; }

    /// <summary>The ExecStep to run after the patch update. Structure is documented below.</summary>
    [JsonPropertyName("postStep")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPostStep>? PostStep { get; set; }

    /// <summary>The ExecStep to run before the patch update. Structure is documented below.</summary>
    [JsonPropertyName("preStep")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigPreStep>? PreStep { get; set; }

    /// <summary>Post-patch reboot settings. Possible values are: DEFAULT, ALWAYS, NEVER.</summary>
    [JsonPropertyName("rebootConfig")]
    public string? RebootConfig { get; set; }

    /// <summary>Windows update settings. Use this setting to override the default Windows patch rules. Structure is documented below.</summary>
    [JsonPropertyName("windowsUpdate")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigWindowsUpdate>? WindowsUpdate { get; set; }

    /// <summary>Yum update settings. Use this setting to override the default yum patch rules. Structure is documented below.</summary>
    [JsonPropertyName("yum")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigYum>? Yum { get; set; }

    /// <summary>zypper update settings. Use this setting to override the default zypper patch rules. Structure is documented below.</summary>
    [JsonPropertyName("zypper")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfigZypper>? Zypper { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRecurringScheduleMonthlyWeekDayOfMonth
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York". Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Represents the number of days before or after the given week day of month that the patch deployment is scheduled for.</summary>
    [JsonPropertyName("dayOffset")]
    public double? DayOffset { get; set; }

    /// <summary>Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.</summary>
    [JsonPropertyName("weekOrdinal")]
    public double? WeekOrdinal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRecurringScheduleMonthly
{
    /// <summary>One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month. Months without the target day will be skipped. For example, a schedule to run "every month on the 31st" will not run in February, April, June, etc.</summary>
    [JsonPropertyName("monthDay")]
    public double? MonthDay { get; set; }

    /// <summary>Week day in a month. Structure is documented below.</summary>
    [JsonPropertyName("weekDayOfMonth")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRecurringScheduleMonthlyWeekDayOfMonth>? WeekDayOfMonth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRecurringScheduleTimeOfDay
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRecurringScheduleTimeZone
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IANA Time Zone Database version number, e.g. "2019a".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRecurringScheduleWeekly
{
    /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York". Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRecurringSchedule
{
    /// <summary>The end time at which a recurring patch deployment schedule is no longer active. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>(Output) The time the last patch job ran successfully. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastExecuteTime")]
    public string? LastExecuteTime { get; set; }

    /// <summary>Schedule with monthly executions. Structure is documented below.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRecurringScheduleMonthly>? Monthly { get; set; }

    /// <summary>(Output) The time the next patch job is scheduled to run. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("nextExecuteTime")]
    public string? NextExecuteTime { get; set; }

    /// <summary>The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Time of the day to run a recurring deployment. Structure is documented below.</summary>
    [JsonPropertyName("timeOfDay")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRecurringScheduleTimeOfDay>? TimeOfDay { get; set; }

    /// <summary>Defines the time zone that timeOfDay is relative to. The rules for daylight saving time are determined by the chosen time zone. Structure is documented below.</summary>
    [JsonPropertyName("timeZone")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRecurringScheduleTimeZone>? TimeZone { get; set; }

    /// <summary>Schedule with weekly executions. Structure is documented below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRecurringScheduleWeekly>? Weekly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRolloutDisruptionBudget
{
    /// <summary>Specifies a fixed value.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies the relative value defined as a percentage, which will be multiplied by a reference value.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProviderRollout
{
    /// <summary>The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs calculated from multiplying the percentage by the total number of VMs in a zone is rounded up. During patching, a VM is considered disrupted from the time the agent is notified to begin until patching has completed. This disruption time includes the time to complete reboot and any post-patch steps. A VM contributes to the disruption budget if its patching operation fails either when applying the patches, running pre or post patch steps, or if it fails to respond with a success notification before timing out. VMs that are not running or do not have an active agent do not count toward this disruption budget. For zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because continuing to the next zone requires completion of the patch process in the previous zone. For example, if the disruption budget has a fixed value of 10, and 8 VMs fail to patch in the current zone, the patch job continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully, patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch job stops. Structure is documented below.</summary>
    [JsonPropertyName("disruptionBudget")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRolloutDisruptionBudget>? DisruptionBudget { get; set; }

    /// <summary>Mode of the patch rollout. Possible values are: ZONE_BY_ZONE, CONCURRENT_ZONES.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusAtProvider
{
    /// <summary>Time the patch deployment was created. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Description of the patch deployment. Length of the description is limited to 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Duration of the patch. After the duration ends, the patch times out. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s"</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>VM instances to patch. Structure is documented below.</summary>
    [JsonPropertyName("instanceFilter")]
    public IList<V1beta1PatchDeploymentStatusAtProviderInstanceFilter>? InstanceFilter { get; set; }

    /// <summary>The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastExecuteTime")]
    public string? LastExecuteTime { get; set; }

    /// <summary>Unique name for the patch deployment resource in a project. The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Schedule a one-time execution. Structure is documented below.</summary>
    [JsonPropertyName("oneTimeSchedule")]
    public IList<V1beta1PatchDeploymentStatusAtProviderOneTimeSchedule>? OneTimeSchedule { get; set; }

    /// <summary>Patch configuration that is applied. Structure is documented below.</summary>
    [JsonPropertyName("patchConfig")]
    public IList<V1beta1PatchDeploymentStatusAtProviderPatchConfig>? PatchConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Schedule recurring executions. Structure is documented below.</summary>
    [JsonPropertyName("recurringSchedule")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRecurringSchedule>? RecurringSchedule { get; set; }

    /// <summary>Rollout strategy of the patch job. Structure is documented below.</summary>
    [JsonPropertyName("rollout")]
    public IList<V1beta1PatchDeploymentStatusAtProviderRollout>? Rollout { get; set; }

    /// <summary>Time the patch deployment was last updated. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatusConditions
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

/// <summary>PatchDeploymentStatus defines the observed state of PatchDeployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PatchDeploymentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PatchDeploymentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PatchDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PatchDeployment is the Schema for the PatchDeployments API. Patch deployments are configurations that individual patch jobs use to complete a patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PatchDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PatchDeploymentSpec>, IStatus<V1beta1PatchDeploymentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PatchDeployment";
    public const string KubeGroup = "osconfig.gcp.upbound.io";
    public const string KubePluralName = "patchdeployments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PatchDeploymentSpec defines the desired state of PatchDeployment</summary>
    [JsonPropertyName("spec")]
    public V1beta1PatchDeploymentSpec Spec { get; set; }

    /// <summary>PatchDeploymentStatus defines the observed state of PatchDeployment.</summary>
    [JsonPropertyName("status")]
    public V1beta1PatchDeploymentStatus? Status { get; set; }
}

/// <summary>PatchDeployment is the Schema for the PatchDeployments API. Patch deployments are configurations that individual patch jobs use to complete a patch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PatchDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PatchDeployment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PatchDeploymentList";
    public const string KubeGroup = "osconfig.gcp.upbound.io";
    public const string KubePluralName = "patchdeployments";
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
    public IList<V1beta1PatchDeployment> Items { get; set; }
}