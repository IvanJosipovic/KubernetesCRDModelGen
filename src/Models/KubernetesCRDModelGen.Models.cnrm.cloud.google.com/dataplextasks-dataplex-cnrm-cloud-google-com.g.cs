using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataplex.cnrm.cloud.google.com;
#nullable enable
/// <summary>DataplexTask is the Schema for the DataplexTask API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexTaskList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataplexTask>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexTaskList";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplextasks";
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
    public IList<V1alpha1DataplexTask> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The Cloud KMS key to use for encryption, of the form: `projects/{project_number}/locations/{location_id}/keyRings/{key-ring-name}/cryptoKeys/{key-name}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecExecutionSpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Service account to use to execute a task. If not provided, the default Compute service account for the project is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecExecutionSpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Spec related to how a task is executed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecExecutionSpec
{
    /// <summary>Optional. The arguments to pass to the task. The args can use placeholders of the format ${placeholder} as part of key/value string. These will be interpolated before passing the args to the driver. Currently supported placeholders: - ${task_id} - ${job_time} To pass positional args, set the key as TASK_ARGS. The value should be a comma-separated string of all the positional arguments. To use a delimiter other than comma, refer to https://cloud.google.com/sdk/gcloud/reference/topic/escaping. In case of other keys being present in the args, then TASK_ARGS will be passed as the last argument.</summary>
    [JsonPropertyName("args")]
    public IDictionary<string, string>? Args { get; set; }

    /// <summary>Optional. The Cloud KMS key to use for encryption, of the form: `projects/{project_number}/locations/{location_id}/keyRings/{key-ring-name}/cryptoKeys/{key-name}`.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1DataplexTaskSpecExecutionSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Optional. The maximum duration after which the job execution is expired.</summary>
    [JsonPropertyName("maxJobExecutionLifetime")]
    public string? MaxJobExecutionLifetime { get; set; }

    /// <summary>Optional. The project in which jobs are run. By default, the project containing the Lake is used. If a project is provided, the [ExecutionSpec.service_account][google.cloud.dataplex.v1.Task.ExecutionSpec.service_account] must belong to this project.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Service account to use to execute a task. If not provided, the default Compute service account for the project is used.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1DataplexTaskSpecExecutionSpecServiceAccountRef ServiceAccountRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LakeRef defines the resource reference to DataplexLake, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecLakeRef
{
    /// <summary>A reference to an externally managed DataplexLake resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/lakes/{{lakeID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataplexLake resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataplexLake resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Compute resources needed for a Task when using Dataproc Serverless.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecNotebookInfrastructureSpecBatch
{
    /// <summary>Optional. Total number of job executors. Executor Count should be between 2 and 100. [Default=2]</summary>
    [JsonPropertyName("executorsCount")]
    public int? ExecutorsCount { get; set; }

    /// <summary>Optional. Max configurable executors. If max_executors_count &gt; executors_count, then auto-scaling is enabled. Max Executor Count should be between 2 and 1000. [Default=1000]</summary>
    [JsonPropertyName("maxExecutorsCount")]
    public int? MaxExecutorsCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Container Image Runtime Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecNotebookInfrastructureSpecContainerImage
{
    /// <summary>Optional. Container image to use.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Optional. A list of Java JARS to add to the classpath. Valid input includes Cloud Storage URIs to Jar binaries. For example, gs://bucket-name/my/path/to/file.jar</summary>
    [JsonPropertyName("javaJars")]
    public IList<string>? JavaJars { get; set; }

    /// <summary>Optional. Override to common configuration of open source components installed on the Dataproc cluster. The properties to set on daemon config files. Property keys are specified in `prefix:property` format, for example `core:hadoop.tmp.dir`. For more information, see [Cluster properties](https://cloud.google.com/dataproc/docs/concepts/cluster-properties).</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Optional. A list of python packages to be installed. Valid formats include Cloud Storage URI to a PIP installable library. For example, gs://bucket-name/my/path/to/lib.tar.gz</summary>
    [JsonPropertyName("pythonPackages")]
    public IList<string>? PythonPackages { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Vpc network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecNotebookInfrastructureSpecVpcNetwork
{
    /// <summary>Optional. The Cloud VPC network in which the job is run. By default, the Cloud VPC network named Default within the project is used.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Optional. List of network tags to apply to the job.</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>Optional. The Cloud VPC sub-network in which the job is run.</summary>
    [JsonPropertyName("subNetwork")]
    public string? SubNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Infrastructure specification for the execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecNotebookInfrastructureSpec
{
    /// <summary>Compute resources needed for a Task when using Dataproc Serverless.</summary>
    [JsonPropertyName("batch")]
    public V1alpha1DataplexTaskSpecNotebookInfrastructureSpecBatch? Batch { get; set; }

    /// <summary>Container Image Runtime Configuration.</summary>
    [JsonPropertyName("containerImage")]
    public V1alpha1DataplexTaskSpecNotebookInfrastructureSpecContainerImage? ContainerImage { get; set; }

    /// <summary>Vpc network.</summary>
    [JsonPropertyName("vpcNetwork")]
    public V1alpha1DataplexTaskSpecNotebookInfrastructureSpecVpcNetwork? VpcNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Config related to running scheduled Notebooks. Exactly one of spark or notebook must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecNotebook
{
    /// <summary>Optional. Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. Cloud Storage URIs of files to be placed in the working directory of each executor.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. Infrastructure specification for the execution.</summary>
    [JsonPropertyName("infrastructureSpec")]
    public V1alpha1DataplexTaskSpecNotebookInfrastructureSpec? InfrastructureSpec { get; set; }

    /// <summary>Required. Path to input notebook. This can be the Cloud Storage URI of the notebook file or the path to a Notebook Content. The execution args are accessible as environment variables (`TASK_key=value`).</summary>
    [JsonPropertyName("notebook")]
    public string Notebook { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Compute resources needed for a Task when using Dataproc Serverless.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecSparkInfrastructureSpecBatch
{
    /// <summary>Optional. Total number of job executors. Executor Count should be between 2 and 100. [Default=2]</summary>
    [JsonPropertyName("executorsCount")]
    public int? ExecutorsCount { get; set; }

    /// <summary>Optional. Max configurable executors. If max_executors_count &gt; executors_count, then auto-scaling is enabled. Max Executor Count should be between 2 and 1000. [Default=1000]</summary>
    [JsonPropertyName("maxExecutorsCount")]
    public int? MaxExecutorsCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Container Image Runtime Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecSparkInfrastructureSpecContainerImage
{
    /// <summary>Optional. Container image to use.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Optional. A list of Java JARS to add to the classpath. Valid input includes Cloud Storage URIs to Jar binaries. For example, gs://bucket-name/my/path/to/file.jar</summary>
    [JsonPropertyName("javaJars")]
    public IList<string>? JavaJars { get; set; }

    /// <summary>Optional. Override to common configuration of open source components installed on the Dataproc cluster. The properties to set on daemon config files. Property keys are specified in `prefix:property` format, for example `core:hadoop.tmp.dir`. For more information, see [Cluster properties](https://cloud.google.com/dataproc/docs/concepts/cluster-properties).</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Optional. A list of python packages to be installed. Valid formats include Cloud Storage URI to a PIP installable library. For example, gs://bucket-name/my/path/to/lib.tar.gz</summary>
    [JsonPropertyName("pythonPackages")]
    public IList<string>? PythonPackages { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Vpc network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecSparkInfrastructureSpecVpcNetwork
{
    /// <summary>Optional. The Cloud VPC network in which the job is run. By default, the Cloud VPC network named Default within the project is used.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Optional. List of network tags to apply to the job.</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>Optional. The Cloud VPC sub-network in which the job is run.</summary>
    [JsonPropertyName("subNetwork")]
    public string? SubNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Infrastructure specification for the execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecSparkInfrastructureSpec
{
    /// <summary>Compute resources needed for a Task when using Dataproc Serverless.</summary>
    [JsonPropertyName("batch")]
    public V1alpha1DataplexTaskSpecSparkInfrastructureSpecBatch? Batch { get; set; }

    /// <summary>Container Image Runtime Configuration.</summary>
    [JsonPropertyName("containerImage")]
    public V1alpha1DataplexTaskSpecSparkInfrastructureSpecContainerImage? ContainerImage { get; set; }

    /// <summary>Vpc network.</summary>
    [JsonPropertyName("vpcNetwork")]
    public V1alpha1DataplexTaskSpecSparkInfrastructureSpecVpcNetwork? VpcNetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Config related to running custom Spark tasks. Exactly one of spark or notebook must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecSpark
{
    /// <summary>Optional. Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. Cloud Storage URIs of files to be placed in the working directory of each executor.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. Infrastructure specification for the execution.</summary>
    [JsonPropertyName("infrastructureSpec")]
    public V1alpha1DataplexTaskSpecSparkInfrastructureSpec? InfrastructureSpec { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in `jar_file_uris`. The execution args are passed in as a sequence of named process arguments (`--key=value`).</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The Cloud Storage URI of the jar file that contains the main class. The execution args are passed in as a sequence of named process arguments (`--key=value`).</summary>
    [JsonPropertyName("mainJarFileURI")]
    public string? MainJarFileURI { get; set; }

    /// <summary>The Gcloud Storage URI of the main Python file to use as the driver. Must be a .py file. The execution args are passed in as a sequence of named process arguments (`--key=value`).</summary>
    [JsonPropertyName("pythonScriptFile")]
    public string? PythonScriptFile { get; set; }

    /// <summary>The query text. The execution args are used to declare a set of script variables (`set key="value";`).</summary>
    [JsonPropertyName("sqlScript")]
    public string? SqlScript { get; set; }

    /// <summary>A reference to a query file. This should be the Cloud Storage URI of the query file. The execution args are used to declare a set of script variables (`set key="value";`).</summary>
    [JsonPropertyName("sqlScriptFile")]
    public string? SqlScriptFile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Spec related to how often and when a task should be triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpecTriggerSpec
{
    /// <summary>Optional. Prevent the task from executing. This does not cancel already running tasks. It is intended to temporarily disable RECURRING tasks.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Optional. Number of retry attempts before aborting. Set to zero to never attempt to retry a failed task.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running tasks periodically. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: "CRON_TZ=${IANA_TIME_ZONE}" or "TZ=${IANA_TIME_ZONE}". The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, `CRON_TZ=America/New_York 1 * * * *`, or `TZ=America/New_York 1 * * * *`. This field is required for RECURRING tasks.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Optional. The first run of the task will be after this time. If not specified, the task will run shortly after being submitted if ON_DEMAND and based on the schedule if RECURRING.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Required. Immutable. Trigger type of the user-specified Task.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataplexTaskSpec defines the desired state of DataplexTask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskSpec
{
    /// <summary>Optional. Description of the task.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. User friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. Spec related to how a task is executed.</summary>
    [JsonPropertyName("executionSpec")]
    public V1alpha1DataplexTaskSpecExecutionSpec ExecutionSpec { get; set; }

    /// <summary>Optional. User-defined labels for the task.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>LakeRef defines the resource reference to DataplexLake, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("lakeRef")]
    public V1alpha1DataplexTaskSpecLakeRef? LakeRef { get; set; }

    /// <summary>Config related to running scheduled Notebooks. Exactly one of spark or notebook must be set.</summary>
    [JsonPropertyName("notebook")]
    public V1alpha1DataplexTaskSpecNotebook? Notebook { get; set; }

    /// <summary>The DataplexTask name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Config related to running custom Spark tasks. Exactly one of spark or notebook must be set.</summary>
    [JsonPropertyName("spark")]
    public V1alpha1DataplexTaskSpecSpark? Spark { get; set; }

    /// <summary>Required. Spec related to how often and when a task should be triggered.</summary>
    [JsonPropertyName("triggerSpec")]
    public V1alpha1DataplexTaskSpecTriggerSpec TriggerSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Output only. Spec related to how a task is executed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskStatusObservedStateExecutionStatusLatestJobExecutionSpec
{
    /// <summary>The arguments to pass to the task. The args can use placeholders of the format ${placeholder} as part of key/value string. These will be interpolated before passing the args to the driver. Currently supported placeholders: - ${task_id} - ${job_time} To pass positional args, set the key as TASK_ARGS. The value should be a comma-separated string of all the positional arguments. To use a delimiter other than comma, refer to https://cloud.google.com/sdk/gcloud/reference/topic/escaping. In case of other keys being present in the args, then TASK_ARGS will be passed as the last argument.</summary>
    [JsonPropertyName("args")]
    public IDictionary<string, string>? Args { get; set; }

    /// <summary>The Cloud KMS key to use for encryption, of the form: `projects/{project_number}/locations/{location_id}/keyRings/{key-ring-name}/cryptoKeys/{key-name}`.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>The maximum duration after which the job execution is expired.</summary>
    [JsonPropertyName("maxJobExecutionLifetime")]
    public string? MaxJobExecutionLifetime { get; set; }

    /// <summary>The project in which jobs are run. By default, the project containing the Lake is used. If a project is provided, the [ExecutionSpec.service_account][google.cloud.dataplex.v1.Task.ExecutionSpec.service_account] must belong to this project.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Service account to use to execute a task. If not provided, the default Compute service account for the project is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string ServiceAccount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. latest job execution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskStatusObservedStateExecutionStatusLatestJob
{
    /// <summary>Output only. The time when the job ended.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. Spec related to how a task is executed.</summary>
    [JsonPropertyName("executionSpec")]
    public V1alpha1DataplexTaskStatusObservedStateExecutionStatusLatestJobExecutionSpec? ExecutionSpec { get; set; }

    /// <summary>Output only. User-defined labels for the task.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Output only. Additional information about the current state.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Output only. The relative resource name of the job, of the form: `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}/jobs/{job_id}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The number of times the job has been retried (excluding the initial attempt).</summary>
    [JsonPropertyName("retryCount")]
    public int? RetryCount { get; set; }

    /// <summary>Output only. The underlying service running a job.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Output only. The full resource name for the job run under a particular service.</summary>
    [JsonPropertyName("serviceJob")]
    public string? ServiceJob { get; set; }

    /// <summary>Output only. The time when the job was started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. Execution state for the job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Job execution trigger.</summary>
    [JsonPropertyName("trigger")]
    public string? Trigger { get; set; }

    /// <summary>Output only. System generated globally unique ID for the job.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}
#nullable disable

#nullable enable
/// <summary> Status of the task execution (e.g. Jobs).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskStatusObservedStateExecutionStatus
{
    /// <summary>Output only. latest job execution</summary>
    [JsonPropertyName("latestJob")]
    public V1alpha1DataplexTaskStatusObservedStateExecutionStatusLatestJob? LatestJob { get; set; }

    /// <summary>Output only. Last update time of the status.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskStatusObservedState
{
    /// <summary>Output only. The time when the task was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary> Status of the task execution (e.g. Jobs).</summary>
    [JsonPropertyName("executionStatus")]
    public V1alpha1DataplexTaskStatusObservedStateExecutionStatus? ExecutionStatus { get; set; }

    /// <summary>Output only. Current state of the task.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the task was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataplexTaskStatus defines the config connector machine state of DataplexTask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataplexTaskStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataplexTaskStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataplexTask resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataplexTaskStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataplexTask is the Schema for the DataplexTask API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataplexTask : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataplexTaskSpec>, IStatus<V1alpha1DataplexTaskStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataplexTask";
    public const string KubeGroup = "dataplex.cnrm.cloud.google.com";
    public const string KubePluralName = "dataplextasks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataplexTaskSpec defines the desired state of DataplexTask</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataplexTaskSpec Spec { get; set; }

    /// <summary>DataplexTaskStatus defines the config connector machine state of DataplexTask</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataplexTaskStatus? Status { get; set; }
}
#nullable disable
