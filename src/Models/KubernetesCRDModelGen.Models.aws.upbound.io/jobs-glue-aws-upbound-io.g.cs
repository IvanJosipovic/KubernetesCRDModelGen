using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>Job is the Schema for the Jobs API. Provides an Glue Job resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Job>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "glue.aws.upbound.io";
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
    public IList<V1beta1Job> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderCommand
{
    /// <summary>The name you assign to this job. It must be unique in your account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Python version being used to execute a Python shell job. Allowed values are 2, 3 or 3.9. Version 3 refers to Python 3.11 when glue_version is set to 5.0.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>In Ray jobs, runtime is used to specify the versions of Ray, Python and additional libraries available in your environment. This field is not used in other job types. For supported runtime environment values, see Working with Ray jobs in the Glue Developer Guide.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Specifies the S3 path to a script that executes a job.</summary>
    [JsonPropertyName("scriptLocation")]
    public string? ScriptLocation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderConnectionsRefsPolicy
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
public partial class V1beta1JobSpecForProviderConnectionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderConnectionsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderConnectionsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Connection in glue to populate connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderConnectionsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderConnectionsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderExecutionProperty
{
    /// <summary>The maximum number of concurrent runs allowed for a job. The default is 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotificationProperty
{
    /// <summary>After a job run starts, the number of minutes to wait before sending a job run delay notification.</summary>
    [JsonPropertyName("notifyDelayAfter")]
    public double? NotifyDelayAfter { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The value of an authorization token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderSourceControlDetailsAuthTokenSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderSourceControlDetails
{
    /// <summary>The type of authentication, which can be an authentication token stored in Amazon Web Services Secrets Manager, or a personal access token. Valid values are: PERSONAL_ACCESS_TOKEN and AWS_SECRETS_MANAGER.</summary>
    [JsonPropertyName("authStrategy")]
    public string? AuthStrategy { get; set; }

    /// <summary>The value of an authorization token.</summary>
    [JsonPropertyName("authTokenSecretRef")]
    public V1beta1JobSpecForProviderSourceControlDetailsAuthTokenSecretRef? AuthTokenSecretRef { get; set; }

    /// <summary>A branch in the remote repository.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>A folder in the remote repository.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>The last commit ID for a commit in the remote repository.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>The owner of the remote repository that contains the job artifacts.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider for the remote repository. Valid values are: GITHUB, GITLAB, BITBUCKET, and AWS_CODE_COMMIT.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The name of the remote repository that contains the job artifacts.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProvider
{
    /// <summary>The command of the job. Defined below.</summary>
    [JsonPropertyName("command")]
    public IList<V1beta1JobSpecForProviderCommand>? Command { get; set; }

    /// <summary>The list of connections used for this job.</summary>
    [JsonPropertyName("connections")]
    public IList<string>? Connections { get; set; }

    /// <summary>References to Connection in glue to populate connections.</summary>
    [JsonPropertyName("connectionsRefs")]
    public IList<V1beta1JobSpecForProviderConnectionsRefs>? ConnectionsRefs { get; set; }

    /// <summary>Selector for a list of Connection in glue to populate connections.</summary>
    [JsonPropertyName("connectionsSelector")]
    public V1beta1JobSpecForProviderConnectionsSelector? ConnectionsSelector { get; set; }

    /// <summary>The map of default arguments for this job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes. For information about how to specify and consume your own Job arguments, see the Calling AWS Glue APIs in Python topic in the developer guide. For information about the key-value pairs that AWS Glue consumes to set up your job, see the Special Parameters Used by AWS Glue topic in the developer guide.</summary>
    [JsonPropertyName("defaultArguments")]
    public IDictionary<string, string>? DefaultArguments { get; set; }

    /// <summary>Description of the job.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Indicates whether the job is run with a standard or flexible execution class. The standard execution class is ideal for time-sensitive workloads that require fast job startup and dedicated resources. Valid value: FLEX, STANDARD.</summary>
    [JsonPropertyName("executionClass")]
    public string? ExecutionClass { get; set; }

    /// <summary>Execution property of the job. Defined below.</summary>
    [JsonPropertyName("executionProperty")]
    public IList<V1beta1JobSpecForProviderExecutionProperty>? ExecutionProperty { get; set; }

    /// <summary>The version of glue to use, for example "1.0". Ray jobs should set this to 4.0 or greater. For information about available versions, see the AWS Glue Release Notes.</summary>
    [JsonPropertyName("glueVersion")]
    public string? GlueVersion { get; set; }

    /// <summary>Describes how a job was created. Valid values are SCRIPT, NOTEBOOK and VISUAL.</summary>
    [JsonPropertyName("jobMode")]
    public string? JobMode { get; set; }

    /// <summary>Specifies whether job run queuing is enabled for the job runs for this job. A value of true means job run queuing is enabled for the job runs. If false or not populated, the job runs will not be considered for queueing.</summary>
    [JsonPropertyName("jobRunQueuingEnabled")]
    public bool? JobRunQueuingEnabled { get; set; }

    /// <summary>Specifies the day of the week and hour for the maintenance window for streaming jobs.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>The maximum number of AWS Glue data processing units (DPUs) that can be allocated when this job runs. Required when pythonshell is set, accept either 0.0625 or 1.0. Use number_of_workers and worker_type arguments instead with glue_version 2.0 and above.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>The maximum number of times to retry this job if it fails.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Non-overridable arguments for this job, specified as name-value pairs.</summary>
    [JsonPropertyName("nonOverridableArguments")]
    public IDictionary<string, string>? NonOverridableArguments { get; set; }

    /// <summary>Notification property of the job. Defined below.</summary>
    [JsonPropertyName("notificationProperty")]
    public IList<V1beta1JobSpecForProviderNotificationProperty>? NotificationProperty { get; set; }

    /// <summary>The number of workers of a defined workerType that are allocated when a job runs.</summary>
    [JsonPropertyName("numberOfWorkers")]
    public double? NumberOfWorkers { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ARN of the IAM role associated with this job.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1JobSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1JobSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The name of the Security Configuration to be associated with the job.</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The details for a source control configuration for a job, allowing synchronization of job artifacts to or from a remote repository. Defined below.</summary>
    [JsonPropertyName("sourceControlDetails")]
    public IList<V1beta1JobSpecForProviderSourceControlDetails>? SourceControlDetails { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The job timeout in minutes. The default is 2880 minutes (48 hours) for glueetl and pythonshell jobs, and null (unlimited) for gluestreaming jobs.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The type of predefined worker that is allocated when a job runs. Accepts a value of Standard, G.1X, G.2X, or G.025X for Spark jobs. Accepts the value Z.2X for Ray jobs.</summary>
    [JsonPropertyName("workerType")]
    public string? WorkerType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderCommand
{
    /// <summary>The name you assign to this job. It must be unique in your account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Python version being used to execute a Python shell job. Allowed values are 2, 3 or 3.9. Version 3 refers to Python 3.11 when glue_version is set to 5.0.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>In Ray jobs, runtime is used to specify the versions of Ray, Python and additional libraries available in your environment. This field is not used in other job types. For supported runtime environment values, see Working with Ray jobs in the Glue Developer Guide.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Specifies the S3 path to a script that executes a job.</summary>
    [JsonPropertyName("scriptLocation")]
    public string? ScriptLocation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderConnectionsRefsPolicy
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
public partial class V1beta1JobSpecInitProviderConnectionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderConnectionsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderConnectionsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Connection in glue to populate connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderConnectionsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderConnectionsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderExecutionProperty
{
    /// <summary>The maximum number of concurrent runs allowed for a job. The default is 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotificationProperty
{
    /// <summary>After a job run starts, the number of minutes to wait before sending a job run delay notification.</summary>
    [JsonPropertyName("notifyDelayAfter")]
    public double? NotifyDelayAfter { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The value of an authorization token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderSourceControlDetailsAuthTokenSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderSourceControlDetails
{
    /// <summary>The type of authentication, which can be an authentication token stored in Amazon Web Services Secrets Manager, or a personal access token. Valid values are: PERSONAL_ACCESS_TOKEN and AWS_SECRETS_MANAGER.</summary>
    [JsonPropertyName("authStrategy")]
    public string? AuthStrategy { get; set; }

    /// <summary>The value of an authorization token.</summary>
    [JsonPropertyName("authTokenSecretRef")]
    public V1beta1JobSpecInitProviderSourceControlDetailsAuthTokenSecretRef? AuthTokenSecretRef { get; set; }

    /// <summary>A branch in the remote repository.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>A folder in the remote repository.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>The last commit ID for a commit in the remote repository.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>The owner of the remote repository that contains the job artifacts.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider for the remote repository. Valid values are: GITHUB, GITLAB, BITBUCKET, and AWS_CODE_COMMIT.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The name of the remote repository that contains the job artifacts.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProvider
{
    /// <summary>The command of the job. Defined below.</summary>
    [JsonPropertyName("command")]
    public IList<V1beta1JobSpecInitProviderCommand>? Command { get; set; }

    /// <summary>The list of connections used for this job.</summary>
    [JsonPropertyName("connections")]
    public IList<string>? Connections { get; set; }

    /// <summary>References to Connection in glue to populate connections.</summary>
    [JsonPropertyName("connectionsRefs")]
    public IList<V1beta1JobSpecInitProviderConnectionsRefs>? ConnectionsRefs { get; set; }

    /// <summary>Selector for a list of Connection in glue to populate connections.</summary>
    [JsonPropertyName("connectionsSelector")]
    public V1beta1JobSpecInitProviderConnectionsSelector? ConnectionsSelector { get; set; }

    /// <summary>The map of default arguments for this job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes. For information about how to specify and consume your own Job arguments, see the Calling AWS Glue APIs in Python topic in the developer guide. For information about the key-value pairs that AWS Glue consumes to set up your job, see the Special Parameters Used by AWS Glue topic in the developer guide.</summary>
    [JsonPropertyName("defaultArguments")]
    public IDictionary<string, string>? DefaultArguments { get; set; }

    /// <summary>Description of the job.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Indicates whether the job is run with a standard or flexible execution class. The standard execution class is ideal for time-sensitive workloads that require fast job startup and dedicated resources. Valid value: FLEX, STANDARD.</summary>
    [JsonPropertyName("executionClass")]
    public string? ExecutionClass { get; set; }

    /// <summary>Execution property of the job. Defined below.</summary>
    [JsonPropertyName("executionProperty")]
    public IList<V1beta1JobSpecInitProviderExecutionProperty>? ExecutionProperty { get; set; }

    /// <summary>The version of glue to use, for example "1.0". Ray jobs should set this to 4.0 or greater. For information about available versions, see the AWS Glue Release Notes.</summary>
    [JsonPropertyName("glueVersion")]
    public string? GlueVersion { get; set; }

    /// <summary>Describes how a job was created. Valid values are SCRIPT, NOTEBOOK and VISUAL.</summary>
    [JsonPropertyName("jobMode")]
    public string? JobMode { get; set; }

    /// <summary>Specifies whether job run queuing is enabled for the job runs for this job. A value of true means job run queuing is enabled for the job runs. If false or not populated, the job runs will not be considered for queueing.</summary>
    [JsonPropertyName("jobRunQueuingEnabled")]
    public bool? JobRunQueuingEnabled { get; set; }

    /// <summary>Specifies the day of the week and hour for the maintenance window for streaming jobs.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>The maximum number of AWS Glue data processing units (DPUs) that can be allocated when this job runs. Required when pythonshell is set, accept either 0.0625 or 1.0. Use number_of_workers and worker_type arguments instead with glue_version 2.0 and above.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>The maximum number of times to retry this job if it fails.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Non-overridable arguments for this job, specified as name-value pairs.</summary>
    [JsonPropertyName("nonOverridableArguments")]
    public IDictionary<string, string>? NonOverridableArguments { get; set; }

    /// <summary>Notification property of the job. Defined below.</summary>
    [JsonPropertyName("notificationProperty")]
    public IList<V1beta1JobSpecInitProviderNotificationProperty>? NotificationProperty { get; set; }

    /// <summary>The number of workers of a defined workerType that are allocated when a job runs.</summary>
    [JsonPropertyName("numberOfWorkers")]
    public double? NumberOfWorkers { get; set; }

    /// <summary>The ARN of the IAM role associated with this job.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1JobSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1JobSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The name of the Security Configuration to be associated with the job.</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The details for a source control configuration for a job, allowing synchronization of job artifacts to or from a remote repository. Defined below.</summary>
    [JsonPropertyName("sourceControlDetails")]
    public IList<V1beta1JobSpecInitProviderSourceControlDetails>? SourceControlDetails { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The job timeout in minutes. The default is 2880 minutes (48 hours) for glueetl and pythonshell jobs, and null (unlimited) for gluestreaming jobs.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The type of predefined worker that is allocated when a job runs. Accepts a value of Standard, G.1X, G.2X, or G.025X for Spark jobs. Accepts the value Z.2X for Ray jobs.</summary>
    [JsonPropertyName("workerType")]
    public string? WorkerType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecProviderConfigRefPolicy
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
public partial class V1beta1JobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1JobSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderCommand
{
    /// <summary>The name you assign to this job. It must be unique in your account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Python version being used to execute a Python shell job. Allowed values are 2, 3 or 3.9. Version 3 refers to Python 3.11 when glue_version is set to 5.0.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>In Ray jobs, runtime is used to specify the versions of Ray, Python and additional libraries available in your environment. This field is not used in other job types. For supported runtime environment values, see Working with Ray jobs in the Glue Developer Guide.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Specifies the S3 path to a script that executes a job.</summary>
    [JsonPropertyName("scriptLocation")]
    public string? ScriptLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderExecutionProperty
{
    /// <summary>The maximum number of concurrent runs allowed for a job. The default is 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNotificationProperty
{
    /// <summary>After a job run starts, the number of minutes to wait before sending a job run delay notification.</summary>
    [JsonPropertyName("notifyDelayAfter")]
    public double? NotifyDelayAfter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderSourceControlDetails
{
    /// <summary>The type of authentication, which can be an authentication token stored in Amazon Web Services Secrets Manager, or a personal access token. Valid values are: PERSONAL_ACCESS_TOKEN and AWS_SECRETS_MANAGER.</summary>
    [JsonPropertyName("authStrategy")]
    public string? AuthStrategy { get; set; }

    /// <summary>A branch in the remote repository.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>A folder in the remote repository.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>The last commit ID for a commit in the remote repository.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>The owner of the remote repository that contains the job artifacts.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider for the remote repository. Valid values are: GITHUB, GITLAB, BITBUCKET, and AWS_CODE_COMMIT.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The name of the remote repository that contains the job artifacts.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of Glue Job</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The command of the job. Defined below.</summary>
    [JsonPropertyName("command")]
    public IList<V1beta1JobStatusAtProviderCommand>? Command { get; set; }

    /// <summary>The list of connections used for this job.</summary>
    [JsonPropertyName("connections")]
    public IList<string>? Connections { get; set; }

    /// <summary>The map of default arguments for this job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes. For information about how to specify and consume your own Job arguments, see the Calling AWS Glue APIs in Python topic in the developer guide. For information about the key-value pairs that AWS Glue consumes to set up your job, see the Special Parameters Used by AWS Glue topic in the developer guide.</summary>
    [JsonPropertyName("defaultArguments")]
    public IDictionary<string, string>? DefaultArguments { get; set; }

    /// <summary>Description of the job.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Indicates whether the job is run with a standard or flexible execution class. The standard execution class is ideal for time-sensitive workloads that require fast job startup and dedicated resources. Valid value: FLEX, STANDARD.</summary>
    [JsonPropertyName("executionClass")]
    public string? ExecutionClass { get; set; }

    /// <summary>Execution property of the job. Defined below.</summary>
    [JsonPropertyName("executionProperty")]
    public IList<V1beta1JobStatusAtProviderExecutionProperty>? ExecutionProperty { get; set; }

    /// <summary>The version of glue to use, for example "1.0". Ray jobs should set this to 4.0 or greater. For information about available versions, see the AWS Glue Release Notes.</summary>
    [JsonPropertyName("glueVersion")]
    public string? GlueVersion { get; set; }

    /// <summary>Job name</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Describes how a job was created. Valid values are SCRIPT, NOTEBOOK and VISUAL.</summary>
    [JsonPropertyName("jobMode")]
    public string? JobMode { get; set; }

    /// <summary>Specifies whether job run queuing is enabled for the job runs for this job. A value of true means job run queuing is enabled for the job runs. If false or not populated, the job runs will not be considered for queueing.</summary>
    [JsonPropertyName("jobRunQueuingEnabled")]
    public bool? JobRunQueuingEnabled { get; set; }

    /// <summary>Specifies the day of the week and hour for the maintenance window for streaming jobs.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>The maximum number of AWS Glue data processing units (DPUs) that can be allocated when this job runs. Required when pythonshell is set, accept either 0.0625 or 1.0. Use number_of_workers and worker_type arguments instead with glue_version 2.0 and above.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>The maximum number of times to retry this job if it fails.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Non-overridable arguments for this job, specified as name-value pairs.</summary>
    [JsonPropertyName("nonOverridableArguments")]
    public IDictionary<string, string>? NonOverridableArguments { get; set; }

    /// <summary>Notification property of the job. Defined below.</summary>
    [JsonPropertyName("notificationProperty")]
    public IList<V1beta1JobStatusAtProviderNotificationProperty>? NotificationProperty { get; set; }

    /// <summary>The number of workers of a defined workerType that are allocated when a job runs.</summary>
    [JsonPropertyName("numberOfWorkers")]
    public double? NumberOfWorkers { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM role associated with this job.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Security Configuration to be associated with the job.</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The details for a source control configuration for a job, allowing synchronization of job artifacts to or from a remote repository. Defined below.</summary>
    [JsonPropertyName("sourceControlDetails")]
    public IList<V1beta1JobStatusAtProviderSourceControlDetails>? SourceControlDetails { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The job timeout in minutes. The default is 2880 minutes (48 hours) for glueetl and pythonshell jobs, and null (unlimited) for gluestreaming jobs.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The type of predefined worker that is allocated when a job runs. Accepts a value of Standard, G.1X, G.2X, or G.025X for Spark jobs. Accepts the value Z.2X for Ray jobs.</summary>
    [JsonPropertyName("workerType")]
    public string? WorkerType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusConditions
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

/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1JobStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Job is the Schema for the Jobs API. Provides an Glue Job resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1JobSpec>, IStatus<V1beta1JobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Job";
    public const string KubeGroup = "glue.aws.upbound.io";
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
    public V1beta1JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta1JobStatus? Status { get; set; }
}