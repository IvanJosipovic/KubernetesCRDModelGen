using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datasync.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolveEnum>))]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum
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
public partial class V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderDestinationLocationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderDestinationLocationArnRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecForProviderDestinationLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderDestinationLocationArnRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecForProviderDestinationLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderDestinationLocationArnRefPolicyResolveEnum>))]
    public V1beta1TaskSpecForProviderDestinationLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderDestinationLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecForProviderDestinationLocationArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicyResolveEnum
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
public partial class V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicyResolutionEnum>))]
    public V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicyResolveEnum>))]
    public V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderDestinationLocationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecForProviderDestinationLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderExcludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by "|" (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderIncludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by "|" (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderOptions
{
    /// <summary>A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to BEST_EFFORT, the DataSync Task attempts to preserve the original (that is, the version before sync PREPARING phase) atime attribute on all source files. Valid values: BEST_EFFORT, NONE. Default: BEST_EFFORT.</summary>
    [JsonPropertyName("atime")]
    public string? Atime { get; set; }

    /// <summary>Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to 1048576. Value values: -1 or greater. Default: -1 (unlimited).</summary>
    [JsonPropertyName("bytesPerSecond")]
    public double? BytesPerSecond { get; set; }

    /// <summary>Group identifier of the file's owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    /// <summary>Determines the type of logs that DataSync publishes to a log stream in the Amazon CloudWatch log group that you provide. Valid values: OFF, BASIC, TRANSFER. Default: OFF.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>A file metadata that indicates the last time a file was modified (written to) before the sync PREPARING phase. Value values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("mtime")]
    public string? Mtime { get; set; }

    /// <summary>Specifies whether object tags are maintained when transferring between object storage systems. If you want your DataSync task to ignore object tags, specify the NONE value. Valid values: PRESERVE, NONE. Default value: PRESERVE.</summary>
    [JsonPropertyName("objectTags")]
    public string? ObjectTags { get; set; }

    /// <summary>Determines whether files at the destination should be overwritten or preserved when copying files. Valid values: ALWAYS, NEVER. Default: ALWAYS.</summary>
    [JsonPropertyName("overwriteMode")]
    public string? OverwriteMode { get; set; }

    /// <summary>Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("posixPermissions")]
    public string? PosixPermissions { get; set; }

    /// <summary>Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: PRESERVE, REMOVE. Default: PRESERVE.</summary>
    [JsonPropertyName("preserveDeletedFiles")]
    public string? PreserveDeletedFiles { get; set; }

    /// <summary>Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: NONE, PRESERVE. Default: NONE (ignore special devices).</summary>
    [JsonPropertyName("preserveDevices")]
    public string? PreserveDevices { get; set; }

    /// <summary>Determines which components of the SMB security descriptor are copied from source to destination objects. This value is only used for transfers between SMB and Amazon FSx for Windows File Server locations, or between two Amazon FSx for Windows File Server locations. Valid values: NONE, OWNER_DACL, OWNER_DACL_SACL. Default: OWNER_DACL.</summary>
    [JsonPropertyName("securityDescriptorCopyFlags")]
    public string? SecurityDescriptorCopyFlags { get; set; }

    /// <summary>Determines whether tasks should be queued before executing the tasks. Valid values: ENABLED, DISABLED. Default ENABLED.</summary>
    [JsonPropertyName("taskQueueing")]
    public string? TaskQueueing { get; set; }

    /// <summary>Determines whether DataSync transfers only the data and metadata that differ between the source and the destination location, or whether DataSync transfers all the content from the source, without comparing to the destination location. Valid values: CHANGED, ALL. Default: CHANGED</summary>
    [JsonPropertyName("transferMode")]
    public string? TransferMode { get; set; }

    /// <summary>User identifier of the file's owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: NONE, POINT_IN_TIME_CONSISTENT, ONLY_FILES_TRANSFERRED. Default: POINT_IN_TIME_CONSISTENT.</summary>
    [JsonPropertyName("verifyMode")]
    public string? VerifyMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderSchedule
{
    /// <summary>Specifies the schedule you want your task to use for repeated executions. For more information, see Schedule Expressions for Rules.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderSourceLocationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderSourceLocationArnRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecForProviderSourceLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderSourceLocationArnRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecForProviderSourceLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderSourceLocationArnRefPolicyResolveEnum>))]
    public V1beta1TaskSpecForProviderSourceLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderSourceLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecForProviderSourceLocationArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicyResolveEnum
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
public partial class V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicyResolutionEnum>))]
    public V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicyResolveEnum>))]
    public V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderSourceLocationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecForProviderSourceLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderTaskReportConfigReportOverrides
{
    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to delete in your destination location. This only applies if you configure your task to delete data in the destination that isn't in the source. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("deletedOverride")]
    public string? DeletedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to skip during your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("skippedOverride")]
    public string? SkippedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("transferredOverride")]
    public string? TransferredOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to verify at the end of your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("verifiedOverride")]
    public string? VerifiedOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderTaskReportConfigS3Destination
{
    /// <summary>Specifies the Amazon Resource Name (ARN) of the IAM policy that allows DataSync to upload a task report to your S3 bucket.</summary>
    [JsonPropertyName("bucketAccessRoleArn")]
    public string? BucketAccessRoleArn { get; set; }

    /// <summary>Specifies the ARN of the S3 bucket where DataSync uploads your report.</summary>
    [JsonPropertyName("s3BucketArn")]
    public string? S3BucketArn { get; set; }

    /// <summary>Specifies a bucket prefix for your report.</summary>
    [JsonPropertyName("subdirectory")]
    public string? Subdirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProviderTaskReportConfig
{
    /// <summary>Specifies the type of task report you'd like. Valid values: SUMMARY_ONLY and STANDARD.</summary>
    [JsonPropertyName("outputType")]
    public string? OutputType { get; set; }

    /// <summary>Specifies whether you want your task report to include only what went wrong with your transfer or a list of what succeeded and didn't. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("reportLevel")]
    public string? ReportLevel { get; set; }

    /// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
    [JsonPropertyName("reportOverrides")]
    public IList<V1beta1TaskSpecForProviderTaskReportConfigReportOverrides>? ReportOverrides { get; set; }

    /// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
    [JsonPropertyName("s3Destination")]
    public IList<V1beta1TaskSpecForProviderTaskReportConfigS3Destination>? S3Destination { get; set; }

    /// <summary>Specifies whether your task report includes the new version of each object transferred into an S3 bucket. This only applies if you enable versioning on your bucket. Keep in mind that setting this to INCLUDE can increase the duration of your task execution. Valid values: INCLUDE and NONE.</summary>
    [JsonPropertyName("s3ObjectVersioning")]
    public string? S3ObjectVersioning { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecForProvider
{
    /// <summary>Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta1TaskSpecForProviderCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Amazon Resource Name (ARN) of destination DataSync Location.</summary>
    [JsonPropertyName("destinationLocationArn")]
    public string? DestinationLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnRef")]
    public V1beta1TaskSpecForProviderDestinationLocationArnRef? DestinationLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnSelector")]
    public V1beta1TaskSpecForProviderDestinationLocationArnSelector? DestinationLocationArnSelector { get; set; }

    /// <summary>Filter rules that determines which files to exclude from a task.</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1TaskSpecForProviderExcludes>? Excludes { get; set; }

    /// <summary>Filter rules that determines which files to include in a task.</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1TaskSpecForProviderIncludes>? Includes { get; set; }

    /// <summary>Name of the DataSync Task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1TaskSpecForProviderOptions>? Options { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1TaskSpecForProviderSchedule>? Schedule { get; set; }

    /// <summary>Amazon Resource Name (ARN) of source DataSync Location.</summary>
    [JsonPropertyName("sourceLocationArn")]
    public string? SourceLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnRef")]
    public V1beta1TaskSpecForProviderSourceLocationArnRef? SourceLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnSelector")]
    public V1beta1TaskSpecForProviderSourceLocationArnSelector? SourceLocationArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
    [JsonPropertyName("taskReportConfig")]
    public IList<V1beta1TaskSpecForProviderTaskReportConfig>? TaskReportConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolveEnum>))]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum
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
public partial class V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicyResolveEnum>))]
    public V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderDestinationLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecInitProviderDestinationLocationArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolveEnum
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
public partial class V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolutionEnum>))]
    public V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolveEnum>))]
    public V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderDestinationLocationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecInitProviderDestinationLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderExcludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by "|" (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderIncludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by "|" (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderOptions
{
    /// <summary>A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to BEST_EFFORT, the DataSync Task attempts to preserve the original (that is, the version before sync PREPARING phase) atime attribute on all source files. Valid values: BEST_EFFORT, NONE. Default: BEST_EFFORT.</summary>
    [JsonPropertyName("atime")]
    public string? Atime { get; set; }

    /// <summary>Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to 1048576. Value values: -1 or greater. Default: -1 (unlimited).</summary>
    [JsonPropertyName("bytesPerSecond")]
    public double? BytesPerSecond { get; set; }

    /// <summary>Group identifier of the file's owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    /// <summary>Determines the type of logs that DataSync publishes to a log stream in the Amazon CloudWatch log group that you provide. Valid values: OFF, BASIC, TRANSFER. Default: OFF.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>A file metadata that indicates the last time a file was modified (written to) before the sync PREPARING phase. Value values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("mtime")]
    public string? Mtime { get; set; }

    /// <summary>Specifies whether object tags are maintained when transferring between object storage systems. If you want your DataSync task to ignore object tags, specify the NONE value. Valid values: PRESERVE, NONE. Default value: PRESERVE.</summary>
    [JsonPropertyName("objectTags")]
    public string? ObjectTags { get; set; }

    /// <summary>Determines whether files at the destination should be overwritten or preserved when copying files. Valid values: ALWAYS, NEVER. Default: ALWAYS.</summary>
    [JsonPropertyName("overwriteMode")]
    public string? OverwriteMode { get; set; }

    /// <summary>Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("posixPermissions")]
    public string? PosixPermissions { get; set; }

    /// <summary>Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: PRESERVE, REMOVE. Default: PRESERVE.</summary>
    [JsonPropertyName("preserveDeletedFiles")]
    public string? PreserveDeletedFiles { get; set; }

    /// <summary>Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: NONE, PRESERVE. Default: NONE (ignore special devices).</summary>
    [JsonPropertyName("preserveDevices")]
    public string? PreserveDevices { get; set; }

    /// <summary>Determines which components of the SMB security descriptor are copied from source to destination objects. This value is only used for transfers between SMB and Amazon FSx for Windows File Server locations, or between two Amazon FSx for Windows File Server locations. Valid values: NONE, OWNER_DACL, OWNER_DACL_SACL. Default: OWNER_DACL.</summary>
    [JsonPropertyName("securityDescriptorCopyFlags")]
    public string? SecurityDescriptorCopyFlags { get; set; }

    /// <summary>Determines whether tasks should be queued before executing the tasks. Valid values: ENABLED, DISABLED. Default ENABLED.</summary>
    [JsonPropertyName("taskQueueing")]
    public string? TaskQueueing { get; set; }

    /// <summary>Determines whether DataSync transfers only the data and metadata that differ between the source and the destination location, or whether DataSync transfers all the content from the source, without comparing to the destination location. Valid values: CHANGED, ALL. Default: CHANGED</summary>
    [JsonPropertyName("transferMode")]
    public string? TransferMode { get; set; }

    /// <summary>User identifier of the file's owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: NONE, POINT_IN_TIME_CONSISTENT, ONLY_FILES_TRANSFERRED. Default: POINT_IN_TIME_CONSISTENT.</summary>
    [JsonPropertyName("verifyMode")]
    public string? VerifyMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderSchedule
{
    /// <summary>Specifies the schedule you want your task to use for repeated executions. For more information, see Schedule Expressions for Rules.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderSourceLocationArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderSourceLocationArnRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecInitProviderSourceLocationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderSourceLocationArnRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecInitProviderSourceLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderSourceLocationArnRefPolicyResolveEnum>))]
    public V1beta1TaskSpecInitProviderSourceLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderSourceLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecInitProviderSourceLocationArnRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicyResolveEnum
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
public partial class V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicyResolutionEnum>))]
    public V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicyResolveEnum>))]
    public V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderSourceLocationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecInitProviderSourceLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderTaskReportConfigReportOverrides
{
    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to delete in your destination location. This only applies if you configure your task to delete data in the destination that isn't in the source. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("deletedOverride")]
    public string? DeletedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to skip during your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("skippedOverride")]
    public string? SkippedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("transferredOverride")]
    public string? TransferredOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to verify at the end of your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("verifiedOverride")]
    public string? VerifiedOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderTaskReportConfigS3Destination
{
    /// <summary>Specifies the Amazon Resource Name (ARN) of the IAM policy that allows DataSync to upload a task report to your S3 bucket.</summary>
    [JsonPropertyName("bucketAccessRoleArn")]
    public string? BucketAccessRoleArn { get; set; }

    /// <summary>Specifies the ARN of the S3 bucket where DataSync uploads your report.</summary>
    [JsonPropertyName("s3BucketArn")]
    public string? S3BucketArn { get; set; }

    /// <summary>Specifies a bucket prefix for your report.</summary>
    [JsonPropertyName("subdirectory")]
    public string? Subdirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProviderTaskReportConfig
{
    /// <summary>Specifies the type of task report you'd like. Valid values: SUMMARY_ONLY and STANDARD.</summary>
    [JsonPropertyName("outputType")]
    public string? OutputType { get; set; }

    /// <summary>Specifies whether you want your task report to include only what went wrong with your transfer or a list of what succeeded and didn't. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("reportLevel")]
    public string? ReportLevel { get; set; }

    /// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
    [JsonPropertyName("reportOverrides")]
    public IList<V1beta1TaskSpecInitProviderTaskReportConfigReportOverrides>? ReportOverrides { get; set; }

    /// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
    [JsonPropertyName("s3Destination")]
    public IList<V1beta1TaskSpecInitProviderTaskReportConfigS3Destination>? S3Destination { get; set; }

    /// <summary>Specifies whether your task report includes the new version of each object transferred into an S3 bucket. This only applies if you enable versioning on your bucket. Keep in mind that setting this to INCLUDE can increase the duration of your task execution. Valid values: INCLUDE and NONE.</summary>
    [JsonPropertyName("s3ObjectVersioning")]
    public string? S3ObjectVersioning { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecInitProvider
{
    /// <summary>Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta1TaskSpecInitProviderCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Amazon Resource Name (ARN) of destination DataSync Location.</summary>
    [JsonPropertyName("destinationLocationArn")]
    public string? DestinationLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnRef")]
    public V1beta1TaskSpecInitProviderDestinationLocationArnRef? DestinationLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate destinationLocationArn.</summary>
    [JsonPropertyName("destinationLocationArnSelector")]
    public V1beta1TaskSpecInitProviderDestinationLocationArnSelector? DestinationLocationArnSelector { get; set; }

    /// <summary>Filter rules that determines which files to exclude from a task.</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1TaskSpecInitProviderExcludes>? Excludes { get; set; }

    /// <summary>Filter rules that determines which files to include in a task.</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1TaskSpecInitProviderIncludes>? Includes { get; set; }

    /// <summary>Name of the DataSync Task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1TaskSpecInitProviderOptions>? Options { get; set; }

    /// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1TaskSpecInitProviderSchedule>? Schedule { get; set; }

    /// <summary>Amazon Resource Name (ARN) of source DataSync Location.</summary>
    [JsonPropertyName("sourceLocationArn")]
    public string? SourceLocationArn { get; set; }

    /// <summary>Reference to a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnRef")]
    public V1beta1TaskSpecInitProviderSourceLocationArnRef? SourceLocationArnRef { get; set; }

    /// <summary>Selector for a LocationS3 in datasync to populate sourceLocationArn.</summary>
    [JsonPropertyName("sourceLocationArnSelector")]
    public V1beta1TaskSpecInitProviderSourceLocationArnSelector? SourceLocationArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
    [JsonPropertyName("taskReportConfig")]
    public IList<V1beta1TaskSpecInitProviderTaskReportConfig>? TaskReportConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TaskSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TaskSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1TaskSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TaskSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TaskSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TaskSpec defines the desired state of Task</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TaskSpecDeletionPolicyEnum>))]
    public V1beta1TaskSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TaskSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TaskSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TaskSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TaskSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TaskSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TaskSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProviderExcludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by "|" (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProviderIncludes
{
    /// <summary>The type of filter rule to apply. Valid values: SIMPLE_PATTERN.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>A single filter string that consists of the patterns to exclude. The patterns are delimited by "|" (that is, a pipe), for example: /folder1|/folder2</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProviderOptions
{
    /// <summary>A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to BEST_EFFORT, the DataSync Task attempts to preserve the original (that is, the version before sync PREPARING phase) atime attribute on all source files. Valid values: BEST_EFFORT, NONE. Default: BEST_EFFORT.</summary>
    [JsonPropertyName("atime")]
    public string? Atime { get; set; }

    /// <summary>Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to 1048576. Value values: -1 or greater. Default: -1 (unlimited).</summary>
    [JsonPropertyName("bytesPerSecond")]
    public double? BytesPerSecond { get; set; }

    /// <summary>Group identifier of the file's owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    /// <summary>Determines the type of logs that DataSync publishes to a log stream in the Amazon CloudWatch log group that you provide. Valid values: OFF, BASIC, TRANSFER. Default: OFF.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>A file metadata that indicates the last time a file was modified (written to) before the sync PREPARING phase. Value values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("mtime")]
    public string? Mtime { get; set; }

    /// <summary>Specifies whether object tags are maintained when transferring between object storage systems. If you want your DataSync task to ignore object tags, specify the NONE value. Valid values: PRESERVE, NONE. Default value: PRESERVE.</summary>
    [JsonPropertyName("objectTags")]
    public string? ObjectTags { get; set; }

    /// <summary>Determines whether files at the destination should be overwritten or preserved when copying files. Valid values: ALWAYS, NEVER. Default: ALWAYS.</summary>
    [JsonPropertyName("overwriteMode")]
    public string? OverwriteMode { get; set; }

    /// <summary>Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: NONE, PRESERVE. Default: PRESERVE.</summary>
    [JsonPropertyName("posixPermissions")]
    public string? PosixPermissions { get; set; }

    /// <summary>Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: PRESERVE, REMOVE. Default: PRESERVE.</summary>
    [JsonPropertyName("preserveDeletedFiles")]
    public string? PreserveDeletedFiles { get; set; }

    /// <summary>Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: NONE, PRESERVE. Default: NONE (ignore special devices).</summary>
    [JsonPropertyName("preserveDevices")]
    public string? PreserveDevices { get; set; }

    /// <summary>Determines which components of the SMB security descriptor are copied from source to destination objects. This value is only used for transfers between SMB and Amazon FSx for Windows File Server locations, or between two Amazon FSx for Windows File Server locations. Valid values: NONE, OWNER_DACL, OWNER_DACL_SACL. Default: OWNER_DACL.</summary>
    [JsonPropertyName("securityDescriptorCopyFlags")]
    public string? SecurityDescriptorCopyFlags { get; set; }

    /// <summary>Determines whether tasks should be queued before executing the tasks. Valid values: ENABLED, DISABLED. Default ENABLED.</summary>
    [JsonPropertyName("taskQueueing")]
    public string? TaskQueueing { get; set; }

    /// <summary>Determines whether DataSync transfers only the data and metadata that differ between the source and the destination location, or whether DataSync transfers all the content from the source, without comparing to the destination location. Valid values: CHANGED, ALL. Default: CHANGED</summary>
    [JsonPropertyName("transferMode")]
    public string? TransferMode { get; set; }

    /// <summary>User identifier of the file's owners. Valid values: BOTH, INT_VALUE, NAME, NONE. Default: INT_VALUE (preserve integer value of the ID).</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: NONE, POINT_IN_TIME_CONSISTENT, ONLY_FILES_TRANSFERRED. Default: POINT_IN_TIME_CONSISTENT.</summary>
    [JsonPropertyName("verifyMode")]
    public string? VerifyMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProviderSchedule
{
    /// <summary>Specifies the schedule you want your task to use for repeated executions. For more information, see Schedule Expressions for Rules.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProviderTaskReportConfigReportOverrides
{
    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to delete in your destination location. This only applies if you configure your task to delete data in the destination that isn't in the source. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("deletedOverride")]
    public string? DeletedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to skip during your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("skippedOverride")]
    public string? SkippedOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("transferredOverride")]
    public string? TransferredOverride { get; set; }

    /// <summary>Specifies the level of reporting for the files, objects, and directories that DataSync attempted to verify at the end of your transfer. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("verifiedOverride")]
    public string? VerifiedOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProviderTaskReportConfigS3Destination
{
    /// <summary>Specifies the Amazon Resource Name (ARN) of the IAM policy that allows DataSync to upload a task report to your S3 bucket.</summary>
    [JsonPropertyName("bucketAccessRoleArn")]
    public string? BucketAccessRoleArn { get; set; }

    /// <summary>Specifies the ARN of the S3 bucket where DataSync uploads your report.</summary>
    [JsonPropertyName("s3BucketArn")]
    public string? S3BucketArn { get; set; }

    /// <summary>Specifies a bucket prefix for your report.</summary>
    [JsonPropertyName("subdirectory")]
    public string? Subdirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProviderTaskReportConfig
{
    /// <summary>Specifies the type of task report you'd like. Valid values: SUMMARY_ONLY and STANDARD.</summary>
    [JsonPropertyName("outputType")]
    public string? OutputType { get; set; }

    /// <summary>Specifies whether you want your task report to include only what went wrong with your transfer or a list of what succeeded and didn't. Valid values: ERRORS_ONLY and SUCCESSES_AND_ERRORS.</summary>
    [JsonPropertyName("reportLevel")]
    public string? ReportLevel { get; set; }

    /// <summary>Configuration block containing the configuration of the reporting level for aspects of your task report. See report_overrides below.</summary>
    [JsonPropertyName("reportOverrides")]
    public IList<V1beta1TaskStatusAtProviderTaskReportConfigReportOverrides>? ReportOverrides { get; set; }

    /// <summary>Configuration block containing the configuration for the Amazon S3 bucket where DataSync uploads your task report. See s3_destination below.</summary>
    [JsonPropertyName("s3Destination")]
    public IList<V1beta1TaskStatusAtProviderTaskReportConfigS3Destination>? S3Destination { get; set; }

    /// <summary>Specifies whether your task report includes the new version of each object transferred into an S3 bucket. This only applies if you enable versioning on your bucket. Keep in mind that setting this to INCLUDE can increase the duration of your task execution. Valid values: INCLUDE and NONE.</summary>
    [JsonPropertyName("s3ObjectVersioning")]
    public string? S3ObjectVersioning { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the DataSync Task.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of destination DataSync Location.</summary>
    [JsonPropertyName("destinationLocationArn")]
    public string? DestinationLocationArn { get; set; }

    /// <summary>Filter rules that determines which files to exclude from a task.</summary>
    [JsonPropertyName("excludes")]
    public IList<V1beta1TaskStatusAtProviderExcludes>? Excludes { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the DataSync Task.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Filter rules that determines which files to include in a task.</summary>
    [JsonPropertyName("includes")]
    public IList<V1beta1TaskStatusAtProviderIncludes>? Includes { get; set; }

    /// <summary>Name of the DataSync Task.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.</summary>
    [JsonPropertyName("options")]
    public IList<V1beta1TaskStatusAtProviderOptions>? Options { get; set; }

    /// <summary>Specifies a schedule used to periodically transfer files from a source to a destination location.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1TaskStatusAtProviderSchedule>? Schedule { get; set; }

    /// <summary>Amazon Resource Name (ARN) of source DataSync Location.</summary>
    [JsonPropertyName("sourceLocationArn")]
    public string? SourceLocationArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block containing the configuration of a DataSync Task Report. See task_report_config below.</summary>
    [JsonPropertyName("taskReportConfig")]
    public IList<V1beta1TaskStatusAtProviderTaskReportConfig>? TaskReportConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatusConditions
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

/// <summary>TaskStatus defines the observed state of Task.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TaskStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TaskStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TaskStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Task is the Schema for the Tasks API. Manages an AWS DataSync Task</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Task : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TaskSpec>, IStatus<V1beta1TaskStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Task";
    public const string KubeGroup = "datasync.aws.upbound.io";
    public const string KubePluralName = "tasks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TaskSpec defines the desired state of Task</summary>
    [JsonPropertyName("spec")]
    public V1beta1TaskSpec Spec { get; set; }

    /// <summary>TaskStatus defines the observed state of Task.</summary>
    [JsonPropertyName("status")]
    public V1beta1TaskStatus? Status { get; set; }
}