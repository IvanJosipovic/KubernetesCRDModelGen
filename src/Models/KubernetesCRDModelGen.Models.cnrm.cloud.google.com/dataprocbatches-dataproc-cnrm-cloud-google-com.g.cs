using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.cnrm.cloud.google.com;
/// <summary>DataprocBatch is the Schema for the DataprocBatch API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocBatchList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataprocBatch>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocBatchList";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocbatches";
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
    public IList<V1alpha1DataprocBatch> Items { get; set; }
}

/// <summary>Optional. The Cloud KMS key to use for encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfigKmsKeyRef
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

/// <summary>Optional. Service account that used to execute workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfigServiceAccountRef
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

/// <summary>Optional. A Cloud Storage bucket used to stage workload dependencies, config files, and store workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running, and then create and manage project-level, per-location staging and temporary buckets. **This field requires a Cloud Storage bucket name, not a `gs://...` URI to a Cloud Storage bucket.**</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfigStagingBucketRef
{
    /// <summary>The StorageBucket selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Execution configuration for a workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfig
{
    /// <summary>Optional. Applies to sessions only. The duration to keep the session alive while it's idling. Exceeding this threshold causes the session to terminate. This field cannot be set on a batch workload. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). Defaults to 1 hour if not set. If both `ttl` and `idle_ttl` are specified for an interactive session, the conditions are treated as `OR` conditions: the workload will be terminated when it has been idle for `idle_ttl` or when `ttl` has been exceeded, whichever occurs first.</summary>
    [JsonPropertyName("idleTTL")]
    public string? IdleTTL { get; set; }

    /// <summary>Optional. The Cloud KMS key to use for encryption.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Optional. Tags used for network traffic control.</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>Optional. Network URI to connect workload to.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Optional. Service account that used to execute workload.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. A Cloud Storage bucket used to stage workload dependencies, config files, and store workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running, and then create and manage project-level, per-location staging and temporary buckets. **This field requires a Cloud Storage bucket name, not a `gs://...` URI to a Cloud Storage bucket.**</summary>
    [JsonPropertyName("stagingBucketRef")]
    public V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfigStagingBucketRef? StagingBucketRef { get; set; }

    /// <summary>Optional. Subnetwork URI to connect workload to.</summary>
    [JsonPropertyName("subnetworkURI")]
    public string? SubnetworkURI { get; set; }

    /// <summary>Optional. The duration after which the workload will be terminated, specified as the JSON representation for [Duration](https://protobuf.dev/programming-guides/proto3/#json). When the workload exceeds this duration, it will be unconditionally terminated without waiting for ongoing work to finish. If `ttl` is not specified for a batch workload, the workload will be allowed to run until it exits naturally (or run forever without exiting). If `ttl` is not specified for an interactive session, it defaults to 24 hours. If `ttl` is not specified for a batch that uses 2.1+ runtime version, it defaults to 4 hours. Minimum value is 10 minutes; maximum value is 14 days. If both `ttl` and `idle_ttl` are specified (for an interactive session), the conditions are treated as `OR` conditions: the workload will be terminated when it has been idle for `idle_ttl` or when `ttl` has been exceeded, whichever occurs first.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>Optional. Resource name of an existing Dataproc Cluster to act as a Spark  History Server for the workload.   Example:   * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>A reference to an externally managed DataprocCluster resource. Should be in the format "projects/{{projectID}}/regions/{{region}}/clusters/{{clusterName}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataprocCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataprocCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The Spark History Server configuration for the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfig
{
    /// <summary>Optional. Resource name of an existing Dataproc Cluster to act as a Spark  History Server for the workload.   Example:   * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`</summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1alpha1DataprocBatchSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }
}

/// <summary>Optional. Peripherals configuration that workload has access to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfigPeripheralsConfig
{
    /// <summary>Optional. Resource name of an existing Dataproc Metastore service.   Example:   * `projects/[project_id]/locations/[region]/services/[service_id]`</summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }

    /// <summary>Optional. The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1alpha1DataprocBatchSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

/// <summary>Optional. Environment configuration for the batch execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecEnvironmentConfig
{
    /// <summary>Optional. Execution configuration for a workload.</summary>
    [JsonPropertyName("executionConfig")]
    public V1alpha1DataprocBatchSpecEnvironmentConfigExecutionConfig? ExecutionConfig { get; set; }

    /// <summary>Optional. Peripherals configuration that workload has access to.</summary>
    [JsonPropertyName("peripheralsConfig")]
    public V1alpha1DataprocBatchSpecEnvironmentConfigPeripheralsConfig? PeripheralsConfig { get; set; }
}

/// <summary>Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. PySpark batch config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecPysparkBatch
{
    /// <summary>Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: `.jar`, `.tar`, `.tar.gz`, `.tgz`, and `.zip`.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. The arguments to pass to the driver. Do not include arguments that can be set as batch properties, such as `--conf`, since a collision can occur that causes an incorrect batch submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS URIs of files to be placed in the working directory of each executor.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the Spark driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileURI")]
    public string? MainPythonFileURI { get; set; }

    /// <summary>Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: `.py`, `.egg`, and `.zip`.</summary>
    [JsonPropertyName("pythonFileURIs")]
    public IList<string>? PythonFileURIs { get; set; }
}

/// <summary>Optional. Autotuning configuration of the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecRuntimeConfigAutotuningConfig
{
    /// <summary>Optional. Scenarios for which tunings are applied.</summary>
    [JsonPropertyName("scenarios")]
    public IList<string>? Scenarios { get; set; }
}

/// <summary>Optional. Configuration for PyPi repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecRuntimeConfigRepositoryConfigPypiRepositoryConfig
{
    /// <summary>Optional. PyPi repository address</summary>
    [JsonPropertyName("pypiRepository")]
    public string? PypiRepository { get; set; }
}

/// <summary>Optional. Dependency repository configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecRuntimeConfigRepositoryConfig
{
    /// <summary>Optional. Configuration for PyPi repository.</summary>
    [JsonPropertyName("pypiRepositoryConfig")]
    public V1alpha1DataprocBatchSpecRuntimeConfigRepositoryConfigPypiRepositoryConfig? PypiRepositoryConfig { get; set; }
}

/// <summary>Optional. Runtime configuration for the batch execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecRuntimeConfig
{
    /// <summary>Optional. Autotuning configuration of the workload.</summary>
    [JsonPropertyName("autotuningConfig")]
    public V1alpha1DataprocBatchSpecRuntimeConfigAutotuningConfig? AutotuningConfig { get; set; }

    /// <summary>Optional. Cohort identifier. Identifies families of the workloads having the same shape, e.g. daily ETL jobs.</summary>
    [JsonPropertyName("cohort")]
    public string? Cohort { get; set; }

    /// <summary>Optional. Optional custom container image for the job runtime environment. If not specified, a default container image will be used.</summary>
    [JsonPropertyName("containerImage")]
    public string? ContainerImage { get; set; }

    /// <summary>Optional. A mapping of property names to values, which are used to configure workload execution.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Optional. Dependency repository configuration.</summary>
    [JsonPropertyName("repositoryConfig")]
    public V1alpha1DataprocBatchSpecRuntimeConfigRepositoryConfig? RepositoryConfig { get; set; }

    /// <summary>Optional. Version of the batch runtime.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Optional. Spark batch config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecSparkBatch
{
    /// <summary>Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: `.jar`, `.tar`, `.tar.gz`, `.tgz`, and `.zip`.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. The arguments to pass to the driver. Do not include arguments that can be set as batch properties, such as `--conf`, since a collision can occur that causes an incorrect batch submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS URIs of files to be placed in the working directory of each executor.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. The name of the driver main class. The jar file that contains the class must be in the classpath or specified in `jar_file_uris`.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>Optional. The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileURI")]
    public string? MainJarFileURI { get; set; }
}

/// <summary>Optional. SparkR batch config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecSparkRBatch
{
    /// <summary>Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: `.jar`, `.tar`, `.tar.gz`, `.tgz`, and `.zip`.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. The arguments to pass to the Spark driver. Do not include arguments that can be set as batch properties, such as `--conf`, since a collision can occur that causes an incorrect batch submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS URIs of files to be placed in the working directory of each executor.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a `.R` or `.r` file.</summary>
    [JsonPropertyName("mainRFileURI")]
    public string? MainRFileURI { get; set; }
}

/// <summary>Optional. SparkSql batch config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpecSparkSQLBatch
{
    /// <summary>Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Required. The HCFS URI of the script that contains Spark SQL queries to execute.</summary>
    [JsonPropertyName("queryFileURI")]
    public string? QueryFileURI { get; set; }

    /// <summary>Optional. Mapping of query variable names to values (equivalent to the Spark SQL command: `SET name="value";`).</summary>
    [JsonPropertyName("queryVariables")]
    public IDictionary<string, string>? QueryVariables { get; set; }
}

/// <summary>DataprocBatchSpec defines the desired state of DataprocBatch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchSpec
{
    /// <summary>Optional. Environment configuration for the batch execution.</summary>
    [JsonPropertyName("environmentConfig")]
    public V1alpha1DataprocBatchSpecEnvironmentConfig? EnvironmentConfig { get; set; }

    /// <summary>Optional. The labels to associate with this batch. Label **keys** must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be empty, but, if present, must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a batch.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DataprocBatchSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Optional. PySpark batch config.</summary>
    [JsonPropertyName("pysparkBatch")]
    public V1alpha1DataprocBatchSpecPysparkBatch? PysparkBatch { get; set; }

    /// <summary>The DataprocBatch name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Runtime configuration for the batch execution.</summary>
    [JsonPropertyName("runtimeConfig")]
    public V1alpha1DataprocBatchSpecRuntimeConfig? RuntimeConfig { get; set; }

    /// <summary>Optional. Spark batch config.</summary>
    [JsonPropertyName("sparkBatch")]
    public V1alpha1DataprocBatchSpecSparkBatch? SparkBatch { get; set; }

    /// <summary>Optional. SparkR batch config.</summary>
    [JsonPropertyName("sparkRBatch")]
    public V1alpha1DataprocBatchSpecSparkRBatch? SparkRBatch { get; set; }

    /// <summary>Optional. SparkSql batch config.</summary>
    [JsonPropertyName("sparkSQLBatch")]
    public V1alpha1DataprocBatchSpecSparkSQLBatch? SparkSQLBatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchStatusConditions
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

/// <summary>Output only. Approximate workload resource usage, calculated when  the workload completes (see [Dataproc Serverless pricing]  (https://cloud.google.com/dataproc-serverless/pricing)).   **Note:** This metric calculation may change in the future, for  example, to capture cumulative workload resource  consumption during workload execution (see the  [Dataproc Serverless release notes]  (https://cloud.google.com/dataproc-serverless/docs/release-notes)  for announcements, changes, fixes  and other Dataproc developments).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchStatusObservedStateRuntimeInfoApproximateUsage
{
    /// <summary>Optional. Accelerator type being used, if any</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Optional. Accelerator usage in (`milliAccelerator` x `seconds`) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliAcceleratorSeconds")]
    public long? MilliAcceleratorSeconds { get; set; }

    /// <summary>Optional. DCU (Dataproc Compute Units) usage in (`milliDCU` x `seconds`) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliDcuSeconds")]
    public long? MilliDcuSeconds { get; set; }

    /// <summary>Optional. Shuffle storage usage in (`GB` x `seconds`) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("shuffleStorageGBSeconds")]
    public long? ShuffleStorageGBSeconds { get; set; }
}

/// <summary>Output only. Snapshot of current workload resource usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchStatusObservedStateRuntimeInfoCurrentUsage
{
    /// <summary>Optional. Accelerator type being used, if any</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Optional. Milli (one-thousandth) accelerator. (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing))</summary>
    [JsonPropertyName("milliAccelerator")]
    public long? MilliAccelerator { get; set; }

    /// <summary>Optional. Milli (one-thousandth) Dataproc Compute Units (DCUs) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliDcu")]
    public long? MilliDcu { get; set; }

    /// <summary>Optional. Milli (one-thousandth) Dataproc Compute Units (DCUs) charged at premium tier (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliDcuPremium")]
    public long? MilliDcuPremium { get; set; }

    /// <summary>Optional. Shuffle Storage in gigabytes (GB). (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing))</summary>
    [JsonPropertyName("shuffleStorageGB")]
    public long? ShuffleStorageGB { get; set; }

    /// <summary>Optional. Shuffle Storage in gigabytes (GB) charged at premium tier. (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing))</summary>
    [JsonPropertyName("shuffleStorageGBPremium")]
    public long? ShuffleStorageGBPremium { get; set; }

    /// <summary>Optional. The timestamp of the usage snapshot.</summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }
}

/// <summary>Output only. Runtime information about batch execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchStatusObservedStateRuntimeInfo
{
    /// <summary>Output only. Approximate workload resource usage, calculated when  the workload completes (see [Dataproc Serverless pricing]  (https://cloud.google.com/dataproc-serverless/pricing)).   **Note:** This metric calculation may change in the future, for  example, to capture cumulative workload resource  consumption during workload execution (see the  [Dataproc Serverless release notes]  (https://cloud.google.com/dataproc-serverless/docs/release-notes)  for announcements, changes, fixes  and other Dataproc developments).</summary>
    [JsonPropertyName("approximateUsage")]
    public V1alpha1DataprocBatchStatusObservedStateRuntimeInfoApproximateUsage? ApproximateUsage { get; set; }

    /// <summary>Output only. Snapshot of current workload resource usage.</summary>
    [JsonPropertyName("currentUsage")]
    public V1alpha1DataprocBatchStatusObservedStateRuntimeInfoCurrentUsage? CurrentUsage { get; set; }

    /// <summary>Output only. A URI pointing to the location of the diagnostics tarball.</summary>
    [JsonPropertyName("diagnosticOutputURI")]
    public string? DiagnosticOutputURI { get; set; }

    /// <summary>Output only. Map of remote access endpoints (such as web interfaces and APIs) to their URIs.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }

    /// <summary>Output only. A URI pointing to the location of the stdout and stderr of the workload.</summary>
    [JsonPropertyName("outputURI")]
    public string? OutputURI { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchStatusObservedStateStateHistory
{
    /// <summary>Output only. The state of the batch at this point in history.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Details about the state at this point in history.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>Output only. The time when the batch entered the historical state.</summary>
    [JsonPropertyName("stateStartTime")]
    public string? StateStartTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchStatusObservedState
{
    /// <summary>Output only. The time when the batch was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The email address of the user who created the batch.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Output only. The resource name of the operation associated with this batch.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>Output only. Runtime information about batch execution.</summary>
    [JsonPropertyName("runtimeInfo")]
    public V1alpha1DataprocBatchStatusObservedStateRuntimeInfo? RuntimeInfo { get; set; }

    /// <summary>Output only. The state of the batch.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Historical state information for the batch.</summary>
    [JsonPropertyName("stateHistory")]
    public IList<V1alpha1DataprocBatchStatusObservedStateStateHistory>? StateHistory { get; set; }

    /// <summary>Output only. Batch state details, such as a failure description if the state is `FAILED`.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>Output only. The time when the batch entered a current state.</summary>
    [JsonPropertyName("stateTime")]
    public string? StateTime { get; set; }

    /// <summary>Output only. A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>DataprocBatchStatus defines the config connector machine state of DataprocBatch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocBatchStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataprocBatchStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataprocBatch resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataprocBatchStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataprocBatch is the Schema for the DataprocBatch API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocBatch : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataprocBatchSpec>, IStatus<V1alpha1DataprocBatchStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocBatch";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocbatches";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataprocBatchSpec defines the desired state of DataprocBatch</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataprocBatchSpec Spec { get; set; }

    /// <summary>DataprocBatchStatus defines the config connector machine state of DataprocBatch</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataprocBatchStatus? Status { get; set; }
}