using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.crossplane.io;
#nullable enable
/// <summary>Job is the Schema for the Jobs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1JobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Job>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "jobs";
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
    public IList<V1alpha1Job> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderContinuous
{
    /// <summary>Indicate whether this continuous job is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderDeployment
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderEnvironmentSpec
{
    /// <summary>client version used by the environment.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVersion")]
    public string? EnvironmentVersion { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("jarDependencies")]
    public IList<string>? JarDependencies { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderEnvironment
{
    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>block describing the Environment. Consists of following attributes:</summary>
    [JsonPropertyName("spec")]
    public IList<V1alpha1JobSpecForProviderEnvironmentSpec>? Spec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderGitSourceGitSnapshot
{
    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("usedCommit")]
    public string? UsedCommit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderGitSourceJobSource
{
    /// <summary></summary>
    [JsonPropertyName("dirtyState")]
    public string? DirtyState { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("importFromGitBranch")]
    public string? ImportFromGitBranch { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("jobConfigPath")]
    public string? JobConfigPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderGitSource
{
    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitSnapshot")]
    public IList<V1alpha1JobSpecForProviderGitSourceGitSnapshot>? GitSnapshot { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("jobSource")]
    public IList<V1alpha1JobSpecForProviderGitSourceJobSource>? JobSource { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with branch and commit.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobSpecForProviderHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobClusterNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("ApplyPolicyDefaultValuesAllowList")]
    public IList<string>? ApplyPolicyDefaultValuesAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderJobCluster
{
    /// <summary>Identifier that can be referenced in task block, so that cluster is shared between tasks</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecForProviderJobClusterNewCluster>? NewCluster { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecForProviderLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecForProviderLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecForProviderLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecForProviderNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecForProviderNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecForProviderNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecForProviderNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecForProviderNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecForProviderNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecForProviderNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecForProviderNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecForProviderNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecForProviderNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecForProviderNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecForProviderNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecForProviderNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecForProviderNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecForProviderNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecForProviderNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecForProviderNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecForProviderNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderNotificationSettings
{
    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderParameter
{
    /// <summary>Default value of the parameter.</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderQueue
{
    /// <summary>If true, enable queueing for the job.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderRunAs
{
    /// <summary>The application ID of an active service principal. Setting this field requires the servicePrincipal/user role.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderRunJobTask
{
    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted and a schedule is provided, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>A Cron expression using Quartz syntax that describes the schedule for a job. This field is required.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>A Java timezone ID. The schedule for a job will be resolved with respect to this timezone. See Java TimeZone for details. This field is required.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskDashboardTaskSubscriptionSubscribers
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskDashboardTaskSubscription
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>When true, the subscription will not send emails.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>The list of subscribers to send the snapshot of the dashboard to.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1alpha1JobSpecForProviderTaskDashboardTaskSubscriptionSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskDashboardTask
{
    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Represents a subscription configuration for scheduled dashboard snapshots.</summary>
    [JsonPropertyName("subscription")]
    public IList<V1alpha1JobSpecForProviderTaskDashboardTaskSubscription>? Subscription { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskDbtCloudTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtCloudJobId")]
    public double? DbtCloudJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskDbtPlatformTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtPlatformJobId")]
    public string? DbtPlatformJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are "true" or "false".</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskDashboardTaskSubscriptionSubscribers
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskDashboardTaskSubscription
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>When true, the subscription will not send emails.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>The list of subscribers to send the snapshot of the dashboard to.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskDashboardTaskSubscriptionSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskDashboardTask
{
    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Represents a subscription configuration for scheduled dashboard snapshots.</summary>
    [JsonPropertyName("subscription")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskDashboardTaskSubscription>? Subscription { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskDbtCloudTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtCloudJobId")]
    public double? DbtCloudJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskDbtPlatformTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtPlatformJobId")]
    public string? DbtPlatformJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are "true" or "false".</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskGenAiComputeTaskCompute
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("gpuNodePoolId")]
    public string? GpuNodePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuType")]
    public string? GpuType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numGpus")]
    public double? NumGpus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskGenAiComputeTask
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public string? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compute")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskGenAiComputeTaskCompute>? Compute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dlRuntimeImage")]
    public string? DlRuntimeImage { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("mlflowExperimentName")]
    public string? MlflowExperimentName { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("trainingScriptPath")]
    public string? TrainingScriptPath { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("yamlParameters")]
    public string? YamlParameters { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("yamlParametersFilePath")]
    public string? YamlParametersFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskPowerBiTaskPowerBiModel
{
    /// <summary>How the published Power BI model authenticates to Databricks</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>The name of the Power BI model</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Whether to overwrite existing Power BI models. Default is false</summary>
    [JsonPropertyName("overwriteExisting")]
    public bool? OverwriteExisting { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>The name of the Power BI workspace of the model</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskPowerBiTaskTables
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskPowerBiTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>The semantic model to update. Block consists of following fields:</summary>
    [JsonPropertyName("powerBiModel")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskPowerBiTaskPowerBiModel>? PowerBiModel { get; set; }

    /// <summary>Whether the model should be refreshed after the update. Default is false</summary>
    [JsonPropertyName("refreshAfterUpdate")]
    public bool? RefreshAfterUpdate { get; set; }

    /// <summary>(Array) The tables to be exported to Power BI. Block consists of following fields:</summary>
    [JsonPropertyName("tables")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskPowerBiTaskTables>? Tables { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pipelineParams")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskRunJobTaskPipelineParams>? PipelineParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboard
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlert>? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboard>? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskFile>? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTaskQuery>? Query { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTaskTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskCleanRoomsNotebookTask>? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskConditionTask>? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dashboardTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskDashboardTask>? DashboardTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtCloudTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskDbtCloudTask>? DbtCloudTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtPlatformTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskDbtPlatformTask>? DbtPlatformTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskDbtTask>? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskEmailNotifications>? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("genAiComputeTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskGenAiComputeTask>? GenAiComputeTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskHealth>? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("powerBiTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskPowerBiTask>? PowerBiTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskRunJobTask>? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskSqlTask>? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTaskWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskForEachTask
{
    /// <summary>Controls the number of active iteration task runs. Default is 20, maximum allowed is 100.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>(String) Array for task to iterate on. This can be a JSON string or a reference to an array parameter.</summary>
    [JsonPropertyName("inputs")]
    public string? Inputs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTaskTask>? Task { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskGenAiComputeTaskCompute
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("gpuNodePoolId")]
    public string? GpuNodePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuType")]
    public string? GpuType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numGpus")]
    public double? NumGpus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskGenAiComputeTask
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public string? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compute")]
    public IList<V1alpha1JobSpecForProviderTaskGenAiComputeTaskCompute>? Compute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dlRuntimeImage")]
    public string? DlRuntimeImage { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("mlflowExperimentName")]
    public string? MlflowExperimentName { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("trainingScriptPath")]
    public string? TrainingScriptPath { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("yamlParameters")]
    public string? YamlParameters { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("yamlParametersFilePath")]
    public string? YamlParametersFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobSpecForProviderTaskHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecForProviderTaskLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecForProviderTaskLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecForProviderTaskLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecForProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("ApplyPolicyDefaultValuesAllowList")]
    public IList<string>? ApplyPolicyDefaultValuesAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecForProviderTaskNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskPowerBiTaskPowerBiModel
{
    /// <summary>How the published Power BI model authenticates to Databricks</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>The name of the Power BI model</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Whether to overwrite existing Power BI models. Default is false</summary>
    [JsonPropertyName("overwriteExisting")]
    public bool? OverwriteExisting { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>The name of the Power BI workspace of the model</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskPowerBiTaskTables
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskPowerBiTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>The semantic model to update. Block consists of following fields:</summary>
    [JsonPropertyName("powerBiModel")]
    public IList<V1alpha1JobSpecForProviderTaskPowerBiTaskPowerBiModel>? PowerBiModel { get; set; }

    /// <summary>Whether the model should be refreshed after the update. Default is false</summary>
    [JsonPropertyName("refreshAfterUpdate")]
    public bool? RefreshAfterUpdate { get; set; }

    /// <summary>(Array) The tables to be exported to Power BI. Block consists of following fields:</summary>
    [JsonPropertyName("tables")]
    public IList<V1alpha1JobSpecForProviderTaskPowerBiTaskTables>? Tables { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pipelineParams")]
    public IList<V1alpha1JobSpecForProviderTaskRunJobTaskPipelineParams>? PipelineParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSqlTaskAlertSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecForProviderTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSqlTaskDashboardSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSqlTaskDashboard
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecForProviderTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public IList<V1alpha1JobSpecForProviderTaskSqlTaskAlert>? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public IList<V1alpha1JobSpecForProviderTaskSqlTaskDashboard>? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecForProviderTaskSqlTaskFile>? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1JobSpecForProviderTaskSqlTaskQuery>? Query { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobSpecForProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobSpecForProviderTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobSpecForProviderTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobSpecForProviderTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobSpecForProviderTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public IList<V1alpha1JobSpecForProviderTaskCleanRoomsNotebookTask>? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public IList<V1alpha1JobSpecForProviderTaskConditionTask>? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dashboardTask")]
    public IList<V1alpha1JobSpecForProviderTaskDashboardTask>? DashboardTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtCloudTask")]
    public IList<V1alpha1JobSpecForProviderTaskDbtCloudTask>? DbtCloudTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtPlatformTask")]
    public IList<V1alpha1JobSpecForProviderTaskDbtPlatformTask>? DbtPlatformTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobSpecForProviderTaskDbtTask>? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1JobSpecForProviderTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobSpecForProviderTaskEmailNotifications>? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("forEachTask")]
    public IList<V1alpha1JobSpecForProviderTaskForEachTask>? ForEachTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("genAiComputeTask")]
    public IList<V1alpha1JobSpecForProviderTaskGenAiComputeTask>? GenAiComputeTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobSpecForProviderTaskHealth>? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecForProviderTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecForProviderTaskNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobSpecForProviderTaskNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobSpecForProviderTaskNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobSpecForProviderTaskPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("powerBiTask")]
    public IList<V1alpha1JobSpecForProviderTaskPowerBiTask>? PowerBiTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobSpecForProviderTaskPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobSpecForProviderTaskRunJobTask>? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobSpecForProviderTaskSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobSpecForProviderTaskSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobSpecForProviderTaskSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public IList<V1alpha1JobSpecForProviderTaskSqlTask>? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobSpecForProviderTaskWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTriggerFileArrival
{
    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTriggerPeriodic
{
    /// <summary>Specifies the interval at which the job should run. This value is required.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Options are {"DAYS", "HOURS", "WEEKS"}.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTriggerTable
{
    /// <summary></summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTriggerTableUpdate
{
    /// <summary></summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderTrigger
{
    /// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
    [JsonPropertyName("fileArrival")]
    public IList<V1alpha1JobSpecForProviderTriggerFileArrival>? FileArrival { get; set; }

    /// <summary>Indicate whether this trigger is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
    [JsonPropertyName("periodic")]
    public IList<V1alpha1JobSpecForProviderTriggerPeriodic>? Periodic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("table")]
    public IList<V1alpha1JobSpecForProviderTriggerTable>? Table { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableUpdate")]
    public IList<V1alpha1JobSpecForProviderTriggerTableUpdate>? TableUpdate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProviderWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobSpecForProviderWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobSpecForProviderWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobSpecForProviderWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobSpecForProviderWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobSpecForProviderWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecForProvider
{
    /// <summary>(Bool) Whenever the job is always running, like a Spark Streaming application, on every update restart the current active run or start it again, if nothing it is not running. False by default. Any job runs are started with parameters specified in spark_jar_task or spark_submit_task or spark_python_task or notebook_task blocks.</summary>
    [JsonPropertyName("alwaysRunning")]
    public bool? AlwaysRunning { get; set; }

    /// <summary>The ID of the user-specified budget policy to use for this job. If not specified, a default budget policy may be applied when creating or modifying the job.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
    [JsonPropertyName("continuous")]
    public IList<V1alpha1JobSpecForProviderContinuous>? Continuous { get; set; }

    /// <summary>(Bool) If true, the Databricks provider will stop and start the job as needed to ensure that the active run for the job reflects the deployed configuration. For continuous jobs, the provider respects the pause_status by stopping the current active run. This flag cannot be set for non-continuous jobs.</summary>
    [JsonPropertyName("controlRunState")]
    public bool? ControlRunState { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobSpecForProviderDbtTask>? DbtTask { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deployment")]
    public IList<V1alpha1JobSpecForProviderDeployment>? Deployment { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If "UI_LOCKED", the user interface for the job will be locked. If "EDITABLE" (the default), the user interface will be editable.</summary>
    [JsonPropertyName("editMode")]
    public string? EditMode { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobSpecForProviderEmailNotifications>? EmailNotifications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environment")]
    public IList<V1alpha1JobSpecForProviderEnvironment>? Environment { get; set; }

    /// <summary>Identifier of the interactive cluster to run job on.  Note: running tasks on interactive clusters may lead to increased costs!</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
    [JsonPropertyName("gitSource")]
    public IList<V1alpha1JobSpecForProviderGitSource>? GitSource { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobSpecForProviderHealth>? Health { get; set; }

    /// <summary>A list of job databricks_cluster specifications that can be shared and reused by tasks of this job. Libraries cannot be declared in a shared job cluster. You must declare dependent libraries in task settings. Multi-task syntax</summary>
    [JsonPropertyName("jobCluster")]
    public IList<V1alpha1JobSpecForProviderJobCluster>? JobCluster { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecForProviderLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum allowed number of concurrent runs of the job. Defaults to 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecForProviderNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobSpecForProviderNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobSpecForProviderNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>Specifices job parameter for the job. See parameter Configuration Block</summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1JobSpecForProviderParameter>? Parameter { get; set; }

    /// <summary>The performance mode on a serverless job. The performance target determines the level of compute performance or cost-efficiency for the run.  Supported values are:</summary>
    [JsonPropertyName("performanceTarget")]
    public string? PerformanceTarget { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobSpecForProviderPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobSpecForProviderPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>The queue status for the job. See queue Configuration Block below.</summary>
    [JsonPropertyName("queue")]
    public IList<V1alpha1JobSpecForProviderQueue>? Queue { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
    [JsonPropertyName("runAs")]
    public IList<V1alpha1JobSpecForProviderRunAs>? RunAs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobSpecForProviderRunJobTask>? RunJobTask { get; set; }

    /// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1JobSpecForProviderSchedule>? Schedule { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobSpecForProviderSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobSpecForProviderSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobSpecForProviderSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1alpha1JobSpecForProviderTask>? Task { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1alpha1JobSpecForProviderTrigger>? Trigger { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobSpecForProviderWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderContinuous
{
    /// <summary>Indicate whether this continuous job is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderDeployment
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderEnvironmentSpec
{
    /// <summary>client version used by the environment.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVersion")]
    public string? EnvironmentVersion { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("jarDependencies")]
    public IList<string>? JarDependencies { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderEnvironment
{
    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>block describing the Environment. Consists of following attributes:</summary>
    [JsonPropertyName("spec")]
    public IList<V1alpha1JobSpecInitProviderEnvironmentSpec>? Spec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderGitSourceGitSnapshot
{
    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("usedCommit")]
    public string? UsedCommit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderGitSourceJobSource
{
    /// <summary></summary>
    [JsonPropertyName("dirtyState")]
    public string? DirtyState { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("importFromGitBranch")]
    public string? ImportFromGitBranch { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("jobConfigPath")]
    public string? JobConfigPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderGitSource
{
    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitSnapshot")]
    public IList<V1alpha1JobSpecInitProviderGitSourceGitSnapshot>? GitSnapshot { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("jobSource")]
    public IList<V1alpha1JobSpecInitProviderGitSourceJobSource>? JobSource { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with branch and commit.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobSpecInitProviderHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobClusterNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("ApplyPolicyDefaultValuesAllowList")]
    public IList<string>? ApplyPolicyDefaultValuesAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderJobCluster
{
    /// <summary>Identifier that can be referenced in task block, so that cluster is shared between tasks</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecInitProviderJobClusterNewCluster>? NewCluster { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecInitProviderLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecInitProviderLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecInitProviderLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecInitProviderNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecInitProviderNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecInitProviderNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecInitProviderNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecInitProviderNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecInitProviderNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecInitProviderNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecInitProviderNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecInitProviderNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecInitProviderNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecInitProviderNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecInitProviderNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecInitProviderNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecInitProviderNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecInitProviderNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecInitProviderNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecInitProviderNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecInitProviderNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderNotificationSettings
{
    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderParameter
{
    /// <summary>Default value of the parameter.</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderQueue
{
    /// <summary>If true, enable queueing for the job.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderRunAs
{
    /// <summary>The application ID of an active service principal. Setting this field requires the servicePrincipal/user role.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderRunJobTask
{
    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted and a schedule is provided, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>A Cron expression using Quartz syntax that describes the schedule for a job. This field is required.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>A Java timezone ID. The schedule for a job will be resolved with respect to this timezone. See Java TimeZone for details. This field is required.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskDashboardTaskSubscriptionSubscribers
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskDashboardTaskSubscription
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>When true, the subscription will not send emails.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>The list of subscribers to send the snapshot of the dashboard to.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1alpha1JobSpecInitProviderTaskDashboardTaskSubscriptionSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskDashboardTask
{
    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Represents a subscription configuration for scheduled dashboard snapshots.</summary>
    [JsonPropertyName("subscription")]
    public IList<V1alpha1JobSpecInitProviderTaskDashboardTaskSubscription>? Subscription { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskDbtCloudTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtCloudJobId")]
    public double? DbtCloudJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskDbtPlatformTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtPlatformJobId")]
    public string? DbtPlatformJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are "true" or "false".</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskDashboardTaskSubscriptionSubscribers
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskDashboardTaskSubscription
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>When true, the subscription will not send emails.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>The list of subscribers to send the snapshot of the dashboard to.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskDashboardTaskSubscriptionSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskDashboardTask
{
    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Represents a subscription configuration for scheduled dashboard snapshots.</summary>
    [JsonPropertyName("subscription")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskDashboardTaskSubscription>? Subscription { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskDbtCloudTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtCloudJobId")]
    public double? DbtCloudJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskDbtPlatformTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtPlatformJobId")]
    public string? DbtPlatformJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are "true" or "false".</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskGenAiComputeTaskCompute
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("gpuNodePoolId")]
    public string? GpuNodePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuType")]
    public string? GpuType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numGpus")]
    public double? NumGpus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskGenAiComputeTask
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public string? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compute")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskGenAiComputeTaskCompute>? Compute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dlRuntimeImage")]
    public string? DlRuntimeImage { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("mlflowExperimentName")]
    public string? MlflowExperimentName { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("trainingScriptPath")]
    public string? TrainingScriptPath { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("yamlParameters")]
    public string? YamlParameters { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("yamlParametersFilePath")]
    public string? YamlParametersFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskPowerBiTaskPowerBiModel
{
    /// <summary>How the published Power BI model authenticates to Databricks</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>The name of the Power BI model</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Whether to overwrite existing Power BI models. Default is false</summary>
    [JsonPropertyName("overwriteExisting")]
    public bool? OverwriteExisting { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>The name of the Power BI workspace of the model</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskPowerBiTaskTables
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskPowerBiTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>The semantic model to update. Block consists of following fields:</summary>
    [JsonPropertyName("powerBiModel")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskPowerBiTaskPowerBiModel>? PowerBiModel { get; set; }

    /// <summary>Whether the model should be refreshed after the update. Default is false</summary>
    [JsonPropertyName("refreshAfterUpdate")]
    public bool? RefreshAfterUpdate { get; set; }

    /// <summary>(Array) The tables to be exported to Power BI. Block consists of following fields:</summary>
    [JsonPropertyName("tables")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskPowerBiTaskTables>? Tables { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pipelineParams")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskRunJobTaskPipelineParams>? PipelineParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboard
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlert>? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboard>? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskFile>? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTaskQuery>? Query { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTaskTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskCleanRoomsNotebookTask>? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskConditionTask>? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dashboardTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskDashboardTask>? DashboardTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtCloudTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskDbtCloudTask>? DbtCloudTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtPlatformTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskDbtPlatformTask>? DbtPlatformTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskDbtTask>? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskEmailNotifications>? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("genAiComputeTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskGenAiComputeTask>? GenAiComputeTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskHealth>? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("powerBiTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskPowerBiTask>? PowerBiTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskRunJobTask>? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskSqlTask>? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTaskWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskForEachTask
{
    /// <summary>Controls the number of active iteration task runs. Default is 20, maximum allowed is 100.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>(String) Array for task to iterate on. This can be a JSON string or a reference to an array parameter.</summary>
    [JsonPropertyName("inputs")]
    public string? Inputs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTaskTask>? Task { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskGenAiComputeTaskCompute
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("gpuNodePoolId")]
    public string? GpuNodePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuType")]
    public string? GpuType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numGpus")]
    public double? NumGpus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskGenAiComputeTask
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public string? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compute")]
    public IList<V1alpha1JobSpecInitProviderTaskGenAiComputeTaskCompute>? Compute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dlRuntimeImage")]
    public string? DlRuntimeImage { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("mlflowExperimentName")]
    public string? MlflowExperimentName { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("trainingScriptPath")]
    public string? TrainingScriptPath { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("yamlParameters")]
    public string? YamlParameters { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("yamlParametersFilePath")]
    public string? YamlParametersFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobSpecInitProviderTaskHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecInitProviderTaskLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecInitProviderTaskLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecInitProviderTaskLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1JobSpecInitProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("ApplyPolicyDefaultValuesAllowList")]
    public IList<string>? ApplyPolicyDefaultValuesAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobSpecInitProviderTaskNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskPowerBiTaskPowerBiModel
{
    /// <summary>How the published Power BI model authenticates to Databricks</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>The name of the Power BI model</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Whether to overwrite existing Power BI models. Default is false</summary>
    [JsonPropertyName("overwriteExisting")]
    public bool? OverwriteExisting { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>The name of the Power BI workspace of the model</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskPowerBiTaskTables
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskPowerBiTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>The semantic model to update. Block consists of following fields:</summary>
    [JsonPropertyName("powerBiModel")]
    public IList<V1alpha1JobSpecInitProviderTaskPowerBiTaskPowerBiModel>? PowerBiModel { get; set; }

    /// <summary>Whether the model should be refreshed after the update. Default is false</summary>
    [JsonPropertyName("refreshAfterUpdate")]
    public bool? RefreshAfterUpdate { get; set; }

    /// <summary>(Array) The tables to be exported to Power BI. Block consists of following fields:</summary>
    [JsonPropertyName("tables")]
    public IList<V1alpha1JobSpecInitProviderTaskPowerBiTaskTables>? Tables { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pipelineParams")]
    public IList<V1alpha1JobSpecInitProviderTaskRunJobTaskPipelineParams>? PipelineParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSqlTaskAlertSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecInitProviderTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSqlTaskDashboardSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSqlTaskDashboard
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobSpecInitProviderTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public IList<V1alpha1JobSpecInitProviderTaskSqlTaskAlert>? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public IList<V1alpha1JobSpecInitProviderTaskSqlTaskDashboard>? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobSpecInitProviderTaskSqlTaskFile>? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1JobSpecInitProviderTaskSqlTaskQuery>? Query { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobSpecInitProviderTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public IList<V1alpha1JobSpecInitProviderTaskCleanRoomsNotebookTask>? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public IList<V1alpha1JobSpecInitProviderTaskConditionTask>? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dashboardTask")]
    public IList<V1alpha1JobSpecInitProviderTaskDashboardTask>? DashboardTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtCloudTask")]
    public IList<V1alpha1JobSpecInitProviderTaskDbtCloudTask>? DbtCloudTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtPlatformTask")]
    public IList<V1alpha1JobSpecInitProviderTaskDbtPlatformTask>? DbtPlatformTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobSpecInitProviderTaskDbtTask>? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1JobSpecInitProviderTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobSpecInitProviderTaskEmailNotifications>? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("forEachTask")]
    public IList<V1alpha1JobSpecInitProviderTaskForEachTask>? ForEachTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("genAiComputeTask")]
    public IList<V1alpha1JobSpecInitProviderTaskGenAiComputeTask>? GenAiComputeTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobSpecInitProviderTaskHealth>? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecInitProviderTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecInitProviderTaskNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobSpecInitProviderTaskNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobSpecInitProviderTaskNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobSpecInitProviderTaskPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("powerBiTask")]
    public IList<V1alpha1JobSpecInitProviderTaskPowerBiTask>? PowerBiTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobSpecInitProviderTaskPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobSpecInitProviderTaskRunJobTask>? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobSpecInitProviderTaskSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobSpecInitProviderTaskSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobSpecInitProviderTaskSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public IList<V1alpha1JobSpecInitProviderTaskSqlTask>? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobSpecInitProviderTaskWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTriggerFileArrival
{
    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTriggerPeriodic
{
    /// <summary>Specifies the interval at which the job should run. This value is required.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Options are {"DAYS", "HOURS", "WEEKS"}.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTriggerTable
{
    /// <summary></summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTriggerTableUpdate
{
    /// <summary></summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderTrigger
{
    /// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
    [JsonPropertyName("fileArrival")]
    public IList<V1alpha1JobSpecInitProviderTriggerFileArrival>? FileArrival { get; set; }

    /// <summary>Indicate whether this trigger is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
    [JsonPropertyName("periodic")]
    public IList<V1alpha1JobSpecInitProviderTriggerPeriodic>? Periodic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("table")]
    public IList<V1alpha1JobSpecInitProviderTriggerTable>? Table { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableUpdate")]
    public IList<V1alpha1JobSpecInitProviderTriggerTableUpdate>? TableUpdate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProviderWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobSpecInitProviderWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobSpecInitProviderWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobSpecInitProviderWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobSpecInitProviderWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobSpecInitProviderWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecInitProvider
{
    /// <summary>(Bool) Whenever the job is always running, like a Spark Streaming application, on every update restart the current active run or start it again, if nothing it is not running. False by default. Any job runs are started with parameters specified in spark_jar_task or spark_submit_task or spark_python_task or notebook_task blocks.</summary>
    [JsonPropertyName("alwaysRunning")]
    public bool? AlwaysRunning { get; set; }

    /// <summary>The ID of the user-specified budget policy to use for this job. If not specified, a default budget policy may be applied when creating or modifying the job.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
    [JsonPropertyName("continuous")]
    public IList<V1alpha1JobSpecInitProviderContinuous>? Continuous { get; set; }

    /// <summary>(Bool) If true, the Databricks provider will stop and start the job as needed to ensure that the active run for the job reflects the deployed configuration. For continuous jobs, the provider respects the pause_status by stopping the current active run. This flag cannot be set for non-continuous jobs.</summary>
    [JsonPropertyName("controlRunState")]
    public bool? ControlRunState { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobSpecInitProviderDbtTask>? DbtTask { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deployment")]
    public IList<V1alpha1JobSpecInitProviderDeployment>? Deployment { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If "UI_LOCKED", the user interface for the job will be locked. If "EDITABLE" (the default), the user interface will be editable.</summary>
    [JsonPropertyName("editMode")]
    public string? EditMode { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobSpecInitProviderEmailNotifications>? EmailNotifications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environment")]
    public IList<V1alpha1JobSpecInitProviderEnvironment>? Environment { get; set; }

    /// <summary>Identifier of the interactive cluster to run job on.  Note: running tasks on interactive clusters may lead to increased costs!</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
    [JsonPropertyName("gitSource")]
    public IList<V1alpha1JobSpecInitProviderGitSource>? GitSource { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobSpecInitProviderHealth>? Health { get; set; }

    /// <summary>A list of job databricks_cluster specifications that can be shared and reused by tasks of this job. Libraries cannot be declared in a shared job cluster. You must declare dependent libraries in task settings. Multi-task syntax</summary>
    [JsonPropertyName("jobCluster")]
    public IList<V1alpha1JobSpecInitProviderJobCluster>? JobCluster { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobSpecInitProviderLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum allowed number of concurrent runs of the job. Defaults to 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobSpecInitProviderNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobSpecInitProviderNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobSpecInitProviderNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>Specifices job parameter for the job. See parameter Configuration Block</summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1JobSpecInitProviderParameter>? Parameter { get; set; }

    /// <summary>The performance mode on a serverless job. The performance target determines the level of compute performance or cost-efficiency for the run.  Supported values are:</summary>
    [JsonPropertyName("performanceTarget")]
    public string? PerformanceTarget { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobSpecInitProviderPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobSpecInitProviderPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>The queue status for the job. See queue Configuration Block below.</summary>
    [JsonPropertyName("queue")]
    public IList<V1alpha1JobSpecInitProviderQueue>? Queue { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
    [JsonPropertyName("runAs")]
    public IList<V1alpha1JobSpecInitProviderRunAs>? RunAs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobSpecInitProviderRunJobTask>? RunJobTask { get; set; }

    /// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1JobSpecInitProviderSchedule>? Schedule { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobSpecInitProviderSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobSpecInitProviderSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobSpecInitProviderSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1alpha1JobSpecInitProviderTask>? Task { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1alpha1JobSpecInitProviderTrigger>? Trigger { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobSpecInitProviderWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1JobSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1JobSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecPublishConnectionDetailsToMetadata
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
#nullable disable

#nullable enable
/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1JobSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1JobSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1JobSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1JobSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderContinuous
{
    /// <summary>Indicate whether this continuous job is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderDeployment
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderEnvironmentSpec
{
    /// <summary>client version used by the environment.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environmentVersion")]
    public string? EnvironmentVersion { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("jarDependencies")]
    public IList<string>? JarDependencies { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderEnvironment
{
    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>block describing the Environment. Consists of following attributes:</summary>
    [JsonPropertyName("spec")]
    public IList<V1alpha1JobStatusAtProviderEnvironmentSpec>? Spec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderGitSourceGitSnapshot
{
    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("usedCommit")]
    public string? UsedCommit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderGitSourceJobSource
{
    /// <summary></summary>
    [JsonPropertyName("dirtyState")]
    public string? DirtyState { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("importFromGitBranch")]
    public string? ImportFromGitBranch { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("jobConfigPath")]
    public string? JobConfigPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderGitSource
{
    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitSnapshot")]
    public IList<V1alpha1JobStatusAtProviderGitSourceGitSnapshot>? GitSnapshot { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("jobSource")]
    public IList<V1alpha1JobStatusAtProviderGitSourceJobSource>? JobSource { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with branch and commit.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobStatusAtProviderHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobClusterNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("ApplyPolicyDefaultValuesAllowList")]
    public IList<string>? ApplyPolicyDefaultValuesAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderJobCluster
{
    /// <summary>Identifier that can be referenced in task block, so that cluster is shared between tasks</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobStatusAtProviderJobClusterNewCluster>? NewCluster { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobStatusAtProviderLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobStatusAtProviderLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobStatusAtProviderLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobStatusAtProviderNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobStatusAtProviderNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobStatusAtProviderNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobStatusAtProviderNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobStatusAtProviderNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobStatusAtProviderNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobStatusAtProviderNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobStatusAtProviderNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobStatusAtProviderNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobStatusAtProviderNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobStatusAtProviderNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobStatusAtProviderNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobStatusAtProviderNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobStatusAtProviderNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobStatusAtProviderNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobStatusAtProviderNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobStatusAtProviderNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderNotificationSettings
{
    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderParameter
{
    /// <summary>Default value of the parameter.</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderQueue
{
    /// <summary>If true, enable queueing for the job.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderRunAs
{
    /// <summary>The application ID of an active service principal. Setting this field requires the servicePrincipal/user role.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderRunJobTask
{
    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted and a schedule is provided, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>A Cron expression using Quartz syntax that describes the schedule for a job. This field is required.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>A Java timezone ID. The schedule for a job will be resolved with respect to this timezone. See Java TimeZone for details. This field is required.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskDashboardTaskSubscriptionSubscribers
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskDashboardTaskSubscription
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>When true, the subscription will not send emails.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>The list of subscribers to send the snapshot of the dashboard to.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1alpha1JobStatusAtProviderTaskDashboardTaskSubscriptionSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskDashboardTask
{
    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Represents a subscription configuration for scheduled dashboard snapshots.</summary>
    [JsonPropertyName("subscription")]
    public IList<V1alpha1JobStatusAtProviderTaskDashboardTaskSubscription>? Subscription { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskDbtCloudTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtCloudJobId")]
    public double? DbtCloudJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskDbtPlatformTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtPlatformJobId")]
    public string? DbtPlatformJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are "true" or "false".</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskDashboardTaskSubscriptionSubscribers
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskDashboardTaskSubscription
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>When true, the subscription will not send emails.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>The list of subscribers to send the snapshot of the dashboard to.</summary>
    [JsonPropertyName("subscribers")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskDashboardTaskSubscriptionSubscribers>? Subscribers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskDashboardTask
{
    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Represents a subscription configuration for scheduled dashboard snapshots.</summary>
    [JsonPropertyName("subscription")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskDashboardTaskSubscription>? Subscription { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskDbtCloudTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtCloudJobId")]
    public double? DbtCloudJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskDbtPlatformTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("dbtPlatformJobId")]
    public string? DbtPlatformJobId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository's root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are "true" or "false".</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskEmailNotifications
{
    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskGenAiComputeTaskCompute
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("gpuNodePoolId")]
    public string? GpuNodePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuType")]
    public string? GpuType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numGpus")]
    public double? NumGpus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskGenAiComputeTask
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public string? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compute")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskGenAiComputeTaskCompute>? Compute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dlRuntimeImage")]
    public string? DlRuntimeImage { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("mlflowExperimentName")]
    public string? MlflowExperimentName { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("trainingScriptPath")]
    public string? TrainingScriptPath { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("yamlParameters")]
    public string? YamlParameters { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("yamlParametersFilePath")]
    public string? YamlParametersFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskPowerBiTaskPowerBiModel
{
    /// <summary>How the published Power BI model authenticates to Databricks</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>The name of the Power BI model</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Whether to overwrite existing Power BI models. Default is false</summary>
    [JsonPropertyName("overwriteExisting")]
    public bool? OverwriteExisting { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>The name of the Power BI workspace of the model</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskPowerBiTaskTables
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskPowerBiTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>The semantic model to update. Block consists of following fields:</summary>
    [JsonPropertyName("powerBiModel")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskPowerBiTaskPowerBiModel>? PowerBiModel { get; set; }

    /// <summary>Whether the model should be refreshed after the update. Default is false</summary>
    [JsonPropertyName("refreshAfterUpdate")]
    public bool? RefreshAfterUpdate { get; set; }

    /// <summary>(Array) The tables to be exported to Power BI. Block consists of following fields:</summary>
    [JsonPropertyName("tables")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskPowerBiTaskTables>? Tables { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pipelineParams")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskRunJobTaskPipelineParams>? PipelineParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboard
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlert>? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboard>? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskFile>? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTaskQuery>? Query { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTaskTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskCleanRoomsNotebookTask>? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskConditionTask>? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dashboardTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskDashboardTask>? DashboardTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtCloudTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskDbtCloudTask>? DbtCloudTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtPlatformTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskDbtPlatformTask>? DbtPlatformTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskDbtTask>? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskEmailNotifications>? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("genAiComputeTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskGenAiComputeTask>? GenAiComputeTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskHealth>? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("powerBiTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskPowerBiTask>? PowerBiTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskRunJobTask>? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskSqlTask>? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTaskWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskForEachTask
{
    /// <summary>Controls the number of active iteration task runs. Default is 20, maximum allowed is 100.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>(String) Array for task to iterate on. This can be a JSON string or a reference to an array parameter.</summary>
    [JsonPropertyName("inputs")]
    public string? Inputs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTaskTask>? Task { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskGenAiComputeTaskCompute
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("gpuNodePoolId")]
    public string? GpuNodePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuType")]
    public string? GpuType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numGpus")]
    public double? NumGpus { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskGenAiComputeTask
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public string? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compute")]
    public IList<V1alpha1JobStatusAtProviderTaskGenAiComputeTaskCompute>? Compute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dlRuntimeImage")]
    public string? DlRuntimeImage { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("mlflowExperimentName")]
    public string? MlflowExperimentName { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("trainingScriptPath")]
    public string? TrainingScriptPath { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("yamlParameters")]
    public string? YamlParameters { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("yamlParametersFilePath")]
    public string? YamlParametersFilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskHealthRules
{
    /// <summary>string specifying the metric to check, like RUN_DURATION_SECONDS, STREAMING_BACKLOG_FILES, etc. - check the Jobs REST API documentation for the full list of supported metrics.</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1JobStatusAtProviderTaskHealthRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobStatusAtProviderTaskLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobStatusAtProviderTaskLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobStatusAtProviderTaskLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterAutoscale
{
    /// <summary></summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterAwsAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterAzureAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConfDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConfS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConfVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConfVolumes>? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    /// <summary></summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterDockerImage
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterGcpAttributes
{
    /// <summary></summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsAbfss
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsDbfs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsFile
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsGcs
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsS3
{
    /// <summary></summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsVolumes
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsWorkspace
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScriptsWorkspace>? Workspace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterWorkloadTypeClients
{
    /// <summary></summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewClusterWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterWorkloadTypeClients>? Clients { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNewCluster
{
    /// <summary></summary>
    [JsonPropertyName("ApplyPolicyDefaultValuesAllowList")]
    public IList<string>? ApplyPolicyDefaultValuesAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterAutoscale>? Autoscale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterDockerImage>? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterGcpAttributes>? GcpAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn't supported</summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1JobStatusAtProviderTaskNewClusterWorkloadType>? WorkloadType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job's base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don't send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don't send alert for skipped runs. (It's recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline's unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskPowerBiTaskPowerBiModel
{
    /// <summary>How the published Power BI model authenticates to Databricks</summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>The name of the Power BI model</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Whether to overwrite existing Power BI models. Default is false</summary>
    [JsonPropertyName("overwriteExisting")]
    public bool? OverwriteExisting { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>The name of the Power BI workspace of the model</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskPowerBiTaskTables
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Power BI storage mode of the table</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskPowerBiTask
{
    /// <summary>The resource name of the UC connection to authenticate from Databricks to Power BI</summary>
    [JsonPropertyName("connectionResourceName")]
    public string? ConnectionResourceName { get; set; }

    /// <summary>The semantic model to update. Block consists of following fields:</summary>
    [JsonPropertyName("powerBiModel")]
    public IList<V1alpha1JobStatusAtProviderTaskPowerBiTaskPowerBiModel>? PowerBiModel { get; set; }

    /// <summary>Whether the model should be refreshed after the update. Default is false</summary>
    [JsonPropertyName("refreshAfterUpdate")]
    public bool? RefreshAfterUpdate { get; set; }

    /// <summary>(Array) The tables to be exported to Power BI. Block consists of following fields:</summary>
    [JsonPropertyName("tables")]
    public IList<V1alpha1JobStatusAtProviderTaskPowerBiTaskTables>? Tables { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with "dbt".</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pipelineParams")]
    public IList<V1alpha1JobStatusAtProviderTaskRunJobTaskPipelineParams>? PipelineParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSparkJarTask
{
    /// <summary></summary>
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSqlTaskAlertSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobStatusAtProviderTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSqlTaskDashboardSubscriptions
{
    /// <summary>A snapshot of the dashboard will be sent to the destination when the destination_id field is present.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>A snapshot of the dashboard will be sent to the user's email when the user_name field is present.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSqlTaskDashboard
{
    /// <summary>Allows users to specify a custom subject line on the email sent to subscribers.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>The identifier of the dashboard to refresh</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination's identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1alpha1JobStatusAtProviderTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public IList<V1alpha1JobStatusAtProviderTaskSqlTaskAlert>? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public IList<V1alpha1JobStatusAtProviderTaskSqlTaskDashboard>? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1JobStatusAtProviderTaskSqlTaskFile>? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public IList<V1alpha1JobStatusAtProviderTaskSqlTaskQuery>? Query { get; set; }

    /// <summary>The warehouse id to execute the dashboard with for the schedule. If not specified, will use the default warehouse of dashboard</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobStatusAtProviderTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public IList<V1alpha1JobStatusAtProviderTaskCleanRoomsNotebookTask>? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public IList<V1alpha1JobStatusAtProviderTaskConditionTask>? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dashboardTask")]
    public IList<V1alpha1JobStatusAtProviderTaskDashboardTask>? DashboardTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtCloudTask")]
    public IList<V1alpha1JobStatusAtProviderTaskDbtCloudTask>? DbtCloudTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtPlatformTask")]
    public IList<V1alpha1JobStatusAtProviderTaskDbtPlatformTask>? DbtPlatformTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobStatusAtProviderTaskDbtTask>? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1alpha1JobStatusAtProviderTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobStatusAtProviderTaskEmailNotifications>? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("forEachTask")]
    public IList<V1alpha1JobStatusAtProviderTaskForEachTask>? ForEachTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("genAiComputeTask")]
    public IList<V1alpha1JobStatusAtProviderTaskGenAiComputeTask>? GenAiComputeTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobStatusAtProviderTaskHealth>? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobStatusAtProviderTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobStatusAtProviderTaskNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobStatusAtProviderTaskNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobStatusAtProviderTaskNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobStatusAtProviderTaskPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("powerBiTask")]
    public IList<V1alpha1JobStatusAtProviderTaskPowerBiTask>? PowerBiTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobStatusAtProviderTaskPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobStatusAtProviderTaskRunJobTask>? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobStatusAtProviderTaskSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobStatusAtProviderTaskSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobStatusAtProviderTaskSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public IList<V1alpha1JobStatusAtProviderTaskSqlTask>? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobStatusAtProviderTaskWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTriggerFileArrival
{
    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTriggerPeriodic
{
    /// <summary>Specifies the interval at which the job should run. This value is required.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Options are {"DAYS", "HOURS", "WEEKS"}.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTriggerTable
{
    /// <summary></summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTriggerTableUpdate
{
    /// <summary></summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderTrigger
{
    /// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
    [JsonPropertyName("fileArrival")]
    public IList<V1alpha1JobStatusAtProviderTriggerFileArrival>? FileArrival { get; set; }

    /// <summary>Indicate whether this trigger is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
    [JsonPropertyName("periodic")]
    public IList<V1alpha1JobStatusAtProviderTriggerPeriodic>? Periodic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("table")]
    public IList<V1alpha1JobStatusAtProviderTriggerTable>? Table { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tableUpdate")]
    public IList<V1alpha1JobStatusAtProviderTriggerTableUpdate>? TableUpdate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProviderWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1alpha1JobStatusAtProviderWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1alpha1JobStatusAtProviderWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1alpha1JobStatusAtProviderWebhookNotificationsOnStart>? OnStart { get; set; }

    /// <summary>(List) list of notification IDs to call when any streaming backlog thresholds are exceeded for any stream.</summary>
    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1alpha1JobStatusAtProviderWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1alpha1JobStatusAtProviderWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusAtProvider
{
    /// <summary>(Bool) Whenever the job is always running, like a Spark Streaming application, on every update restart the current active run or start it again, if nothing it is not running. False by default. Any job runs are started with parameters specified in spark_jar_task or spark_submit_task or spark_python_task or notebook_task blocks.</summary>
    [JsonPropertyName("alwaysRunning")]
    public bool? AlwaysRunning { get; set; }

    /// <summary>The ID of the user-specified budget policy to use for this job. If not specified, a default budget policy may be applied when creating or modifying the job.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
    [JsonPropertyName("continuous")]
    public IList<V1alpha1JobStatusAtProviderContinuous>? Continuous { get; set; }

    /// <summary>(Bool) If true, the Databricks provider will stop and start the job as needed to ensure that the active run for the job reflects the deployed configuration. For continuous jobs, the provider respects the pause_status by stopping the current active run. This flag cannot be set for non-continuous jobs.</summary>
    [JsonPropertyName("controlRunState")]
    public bool? ControlRunState { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public IList<V1alpha1JobStatusAtProviderDbtTask>? DbtTask { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deployment")]
    public IList<V1alpha1JobStatusAtProviderDeployment>? Deployment { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If "UI_LOCKED", the user interface for the job will be locked. If "EDITABLE" (the default), the user interface will be editable.</summary>
    [JsonPropertyName("editMode")]
    public string? EditMode { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public IList<V1alpha1JobStatusAtProviderEmailNotifications>? EmailNotifications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("environment")]
    public IList<V1alpha1JobStatusAtProviderEnvironment>? Environment { get; set; }

    /// <summary>Identifier of the interactive cluster to run job on.  Note: running tasks on interactive clusters may lead to increased costs!</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
    [JsonPropertyName("gitSource")]
    public IList<V1alpha1JobStatusAtProviderGitSource>? GitSource { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1JobStatusAtProviderHealth>? Health { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of job databricks_cluster specifications that can be shared and reused by tasks of this job. Libraries cannot be declared in a shared job cluster. You must declare dependent libraries in task settings. Multi-task syntax</summary>
    [JsonPropertyName("jobCluster")]
    public IList<V1alpha1JobStatusAtProviderJobCluster>? JobCluster { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1JobStatusAtProviderLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum allowed number of concurrent runs of the job. Defaults to 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public IList<V1alpha1JobStatusAtProviderNewCluster>? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public IList<V1alpha1JobStatusAtProviderNotebookTask>? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public IList<V1alpha1JobStatusAtProviderNotificationSettings>? NotificationSettings { get; set; }

    /// <summary>Specifices job parameter for the job. See parameter Configuration Block</summary>
    [JsonPropertyName("parameter")]
    public IList<V1alpha1JobStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>The performance mode on a serverless job. The performance target determines the level of compute performance or cost-efficiency for the run.  Supported values are:</summary>
    [JsonPropertyName("performanceTarget")]
    public string? PerformanceTarget { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public IList<V1alpha1JobStatusAtProviderPipelineTask>? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public IList<V1alpha1JobStatusAtProviderPythonWheelTask>? PythonWheelTask { get; set; }

    /// <summary>The queue status for the job. See queue Configuration Block below.</summary>
    [JsonPropertyName("queue")]
    public IList<V1alpha1JobStatusAtProviderQueue>? Queue { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
    [JsonPropertyName("runAs")]
    public IList<V1alpha1JobStatusAtProviderRunAs>? RunAs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public IList<V1alpha1JobStatusAtProviderRunJobTask>? RunJobTask { get; set; }

    /// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1alpha1JobStatusAtProviderSchedule>? Schedule { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public IList<V1alpha1JobStatusAtProviderSparkJarTask>? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public IList<V1alpha1JobStatusAtProviderSparkPythonTask>? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public IList<V1alpha1JobStatusAtProviderSparkSubmitTask>? SparkSubmitTask { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1alpha1JobStatusAtProviderTask>? Task { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1alpha1JobStatusAtProviderTrigger>? Trigger { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public IList<V1alpha1JobStatusAtProviderWebhookNotifications>? WebhookNotifications { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatusConditions
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
#nullable disable

#nullable enable
/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1JobStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1JobStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Job is the Schema for the Jobs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1JobSpec>, IStatus<V1alpha1JobStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Job";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "jobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public V1alpha1JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1alpha1JobStatus? Status { get; set; }
}
#nullable disable
