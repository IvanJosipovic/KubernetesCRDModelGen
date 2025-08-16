using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.cnrm.cloud.google.com;
/// <summary>DataprocJob is the Schema for the DataprocJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataprocJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocJobList";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocjobs";
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
    public IList<V1alpha1DataprocJob> Items { get; set; }
}

/// <summary>Optional. Driver scheduling configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecDriverSchedulingConfig
{
    /// <summary>Required. The amount of memory in MB the driver is requesting.</summary>
    [JsonPropertyName("memoryMb")]
    public int? MemoryMb { get; set; }

    /// <summary>Required. The number of vCPUs the driver is requesting.</summary>
    [JsonPropertyName("vcores")]
    public int? Vcores { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecFlinkJobLoggingConfig
{
}

/// <summary>Optional. Job is a Flink job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecFlinkJob
{
    /// <summary>Optional. The arguments to pass to the driver. Do not include arguments, such as `--conf`, that can be set as job properties, since a collision might occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Flink driver and tasks.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecFlinkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in [jarFileUris][google.cloud.dataproc.v1.FlinkJob.jar_file_uris].</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileURI")]
    public string? MainJarFileURI { get; set; }

    /// <summary>Optional. A mapping of property names to values, used to configure Flink. Properties that conflict with values set by the Dataproc API might be overwritten. Can include properties set in `/etc/flink/conf/flink-defaults.conf` and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Optional. HCFS URI of the savepoint, which contains the last saved progress for starting the current job.</summary>
    [JsonPropertyName("savepointURI")]
    public string? SavepointURI { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecHadoopJobLoggingConfig
{
}

/// <summary>Optional. Job is a Hadoop job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecHadoopJob
{
    /// <summary>Optional. HCFS URIs of archives to be extracted in the working directory of Hadoop drivers and tasks. Supported file types: .jar, .tar, .tar.gz, .tgz, or .zip.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. The arguments to pass to the driver. Do not include arguments, such as `-libjars` or `-Dfoo=bar`, that can be set as job properties, since a collision might occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied to the working directory of Hadoop drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. Jar file URIs to add to the CLASSPATHs of the Hadoop driver and tasks.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecHadoopJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file containing the class must be in the default CLASSPATH or specified in `jar_file_uris`.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file containing the main class. Examples: 'gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar' 'hdfs:/tmp/test-samples/custom-wordcount.jar' 'file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar'</summary>
    [JsonPropertyName("mainJarFileURI")]
    public string? MainJarFileURI { get; set; }

    /// <summary>Optional. A mapping of property names to values, used to configure Hadoop. Properties that conflict with values set by the Dataproc API might be overwritten. Can include properties set in `/etc/hadoop/conf/*-site` and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecHiveJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression  with a semicolon. Multiple queries can be specified in one  string by separating each with a semicolon. Here is an example of a  Dataproc API snippet that uses a QueryList to specify a HiveJob:       "hiveJob": {        "queryList": {          "queries": [            "query1",            "query2",            "query3;query4",          ]        }      }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Optional. Job is a Hive job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecHiveJob
{
    /// <summary>Optional. Whether to continue executing queries if a query fails. The default value is `false`. Setting to `true` can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>Optional. HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Dataproc API might be overwritten. Can include properties set in `/etc/hadoop/conf/*-site.xml`, /etc/hive/conf/hive-site.xml, and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains Hive queries.</summary>
    [JsonPropertyName("queryFileURI")]
    public string? QueryFileURI { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1alpha1DataprocJobSpecHiveJobQueryList? QueryList { get; set; }

    /// <summary>Optional. Mapping of query variable names to values (equivalent to the Hive command: `SET name="value";`).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecParentProjectRef
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

/// <summary>Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecParent
{
    /// <summary>Required.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DataprocJobSpecParentProjectRef? ProjectRef { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPigJobLoggingConfig
{
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPigJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression  with a semicolon. Multiple queries can be specified in one  string by separating each with a semicolon. Here is an example of a  Dataproc API snippet that uses a QueryList to specify a HiveJob:       "hiveJob": {        "queryList": {          "queries": [            "query1",            "query2",            "query3;query4",          ]        }      }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Optional. Job is a Pig job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPigJob
{
    /// <summary>Optional. Whether to continue executing queries if a query fails. The default value is `false`. Setting to `true` can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>Optional. HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecPigJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Optional. A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Dataproc API might be overwritten. Can include properties set in `/etc/hadoop/conf/*-site.xml`, /etc/pig/conf/pig.properties, and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains the Pig queries.</summary>
    [JsonPropertyName("queryFileURI")]
    public string? QueryFileURI { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1alpha1DataprocJobSpecPigJobQueryList? QueryList { get; set; }

    /// <summary>Optional. Mapping of query variable names to values (equivalent to the Pig command: `name=[value]`).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>Required. Job information, including how, when, and where to run the job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPlacement
{
    /// <summary>Optional. Cluster labels to identify a cluster where the job will be submitted.</summary>
    [JsonPropertyName("clusterLabels")]
    public IDictionary<string, string>? ClusterLabels { get; set; }

    /// <summary>Required. The name of the cluster where the job will be submitted.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPrestoJobLoggingConfig
{
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPrestoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression  with a semicolon. Multiple queries can be specified in one  string by separating each with a semicolon. Here is an example of a  Dataproc API snippet that uses a QueryList to specify a HiveJob:       "hiveJob": {        "queryList": {          "queries": [            "query1",            "query2",            "query3;query4",          ]        }      }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Optional. Job is a Presto job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPrestoJob
{
    /// <summary>Optional. Presto client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Optional. Whether to continue executing queries if a query fails. The default value is `false`. Setting to `true` can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecPrestoJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Optional. The format in which query output will be displayed. See the Presto documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Optional. A mapping of property names to values. Used to set Presto [session properties](https://prestodb.io/docs/current/sql/set-session.html) Equivalent to using the --session flag in the Presto CLI</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileURI")]
    public string? QueryFileURI { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1alpha1DataprocJobSpecPrestoJobQueryList? QueryList { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPysparkJobLoggingConfig
{
}

/// <summary>Optional. Job is a PySpark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecPysparkJob
{
    /// <summary>Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. The arguments to pass to the driver.  Do not include arguments, such as `--conf`, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecPysparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileURI")]
    public string? MainPythonFileURI { get; set; }

    /// <summary>Optional. A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Dataproc API might be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileURIs")]
    public IList<string>? PythonFileURIs { get; set; }
}

/// <summary>Optional. The fully qualified reference to the job, which can be used to obtain the equivalent REST path of the job resource. If this property is not specified when a job is created, the server generates a &lt;code&gt;job_id&lt;/code&gt;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecReference
{
    /// <summary>Optional. The job ID, which must be unique within the project.   The ID must contain only letters (a-z, A-Z), numbers (0-9),  underscores (_), or hyphens (-). The maximum length is 100 characters.   If not specified by the caller, the job ID will be provided by the server.</summary>
    [JsonPropertyName("jobID")]
    public string? JobID { get; set; }

    /// <summary>Optional. The ID of the Google Cloud Platform project that the job belongs to. If specified, must match the request project ID.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}

/// <summary>Optional. Job scheduling configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecScheduling
{
    /// <summary>Optional. Maximum number of times per hour a driver can be restarted as  a result of driver exiting with non-zero code before job is  reported failed.   A job might be reported as thrashing if the driver exits with a non-zero  code four times within a 10-minute window.   Maximum value is 10.   **Note:** This restartable job option is not supported in Dataproc  [workflow templates]  (https://cloud.google.com/dataproc/docs/concepts/workflows/using-workflows#adding_jobs_to_a_template).</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public int? MaxFailuresPerHour { get; set; }

    /// <summary>Optional. Maximum total number of times a driver can be restarted as a  result of the driver exiting with a non-zero code. After the maximum number  is reached, the job will be reported as failed.   Maximum value is 240.   **Note:** Currently, this restartable job option is  not supported in Dataproc  [workflow  templates](https://cloud.google.com/dataproc/docs/concepts/workflows/using-workflows#adding_jobs_to_a_template).</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public int? MaxFailuresTotal { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecSparkJobLoggingConfig
{
}

/// <summary>Optional. Job is a Spark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecSparkJob
{
    /// <summary>Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. The arguments to pass to the driver. Do not include arguments, such as `--conf`, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecSparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in SparkJob.jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileURI")]
    public string? MainJarFileURI { get; set; }

    /// <summary>Optional. A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Dataproc API might be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecSparkRJobLoggingConfig
{
}

/// <summary>Optional. Job is a SparkR job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecSparkRJob
{
    /// <summary>Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveURIs")]
    public IList<string>? ArchiveURIs { get; set; }

    /// <summary>Optional. The arguments to pass to the driver.  Do not include arguments, such as `--conf`, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileURIs")]
    public IList<string>? FileURIs { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecSparkRJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
    [JsonPropertyName("mainRFileURI")]
    public string? MainRFileURI { get; set; }

    /// <summary>Optional. A mapping of property names to values, used to configure SparkR. Properties that conflict with values set by the Dataproc API might be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecSparkSQLJobLoggingConfig
{
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecSparkSQLJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression  with a semicolon. Multiple queries can be specified in one  string by separating each with a semicolon. Here is an example of a  Dataproc API snippet that uses a QueryList to specify a HiveJob:       "hiveJob": {        "queryList": {          "queries": [            "query1",            "query2",            "query3;query4",          ]        }      }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Optional. Job is a SparkSql job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecSparkSQLJob
{
    /// <summary>Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileURIs")]
    public IList<string>? JarFileURIs { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecSparkSQLJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Optional. A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API might be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileURI")]
    public string? QueryFileURI { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1alpha1DataprocJobSpecSparkSQLJobQueryList? QueryList { get; set; }

    /// <summary>Optional. Mapping of query variable names to values (equivalent to the Spark SQL command: SET `name="value";`).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>Optional. The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecTrinoJobLoggingConfig
{
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecTrinoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression  with a semicolon. Multiple queries can be specified in one  string by separating each with a semicolon. Here is an example of a  Dataproc API snippet that uses a QueryList to specify a HiveJob:       "hiveJob": {        "queryList": {          "queries": [            "query1",            "query2",            "query3;query4",          ]        }      }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Optional. Job is a Trino job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpecTrinoJob
{
    /// <summary>Optional. Trino client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Optional. Whether to continue executing queries if a query fails. The default value is `false`. Setting to `true` can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>Optional. The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1DataprocJobSpecTrinoJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Optional. The format in which query output will be displayed. See the Trino documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Optional. A mapping of property names to values. Used to set Trino [session properties](https://trino.io/docs/current/sql/set-session.html) Equivalent to using the --session flag in the Trino CLI</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileURI")]
    public string? QueryFileURI { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1alpha1DataprocJobSpecTrinoJobQueryList? QueryList { get; set; }
}

/// <summary>DataprocJobSpec defines the desired state of DataprocJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobSpec
{
    /// <summary>Optional. Driver scheduling configuration.</summary>
    [JsonPropertyName("driverSchedulingConfig")]
    public V1alpha1DataprocJobSpecDriverSchedulingConfig? DriverSchedulingConfig { get; set; }

    /// <summary>Optional. Job is a Flink job.</summary>
    [JsonPropertyName("flinkJob")]
    public V1alpha1DataprocJobSpecFlinkJob? FlinkJob { get; set; }

    /// <summary>Optional. Job is a Hadoop job.</summary>
    [JsonPropertyName("hadoopJob")]
    public V1alpha1DataprocJobSpecHadoopJob? HadoopJob { get; set; }

    /// <summary>Optional. Job is a Hive job.</summary>
    [JsonPropertyName("hiveJob")]
    public V1alpha1DataprocJobSpecHiveJob? HiveJob { get; set; }

    /// <summary>Optional. The labels to associate with this job. Label **keys** must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** can be empty, but, if present, must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a job.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required.</summary>
    [JsonPropertyName("parent")]
    public V1alpha1DataprocJobSpecParent? Parent { get; set; }

    /// <summary>Optional. Job is a Pig job.</summary>
    [JsonPropertyName("pigJob")]
    public V1alpha1DataprocJobSpecPigJob? PigJob { get; set; }

    /// <summary>Required. Job information, including how, when, and where to run the job.</summary>
    [JsonPropertyName("placement")]
    public V1alpha1DataprocJobSpecPlacement? Placement { get; set; }

    /// <summary>Optional. Job is a Presto job.</summary>
    [JsonPropertyName("prestoJob")]
    public V1alpha1DataprocJobSpecPrestoJob? PrestoJob { get; set; }

    /// <summary>Optional. Job is a PySpark job.</summary>
    [JsonPropertyName("pysparkJob")]
    public V1alpha1DataprocJobSpecPysparkJob? PysparkJob { get; set; }

    /// <summary>Optional. The fully qualified reference to the job, which can be used to obtain the equivalent REST path of the job resource. If this property is not specified when a job is created, the server generates a &lt;code&gt;job_id&lt;/code&gt;.</summary>
    [JsonPropertyName("reference")]
    public V1alpha1DataprocJobSpecReference? Reference { get; set; }

    /// <summary>The DataprocJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Job scheduling configuration.</summary>
    [JsonPropertyName("scheduling")]
    public V1alpha1DataprocJobSpecScheduling? Scheduling { get; set; }

    /// <summary>Optional. Job is a Spark job.</summary>
    [JsonPropertyName("sparkJob")]
    public V1alpha1DataprocJobSpecSparkJob? SparkJob { get; set; }

    /// <summary>Optional. Job is a SparkR job.</summary>
    [JsonPropertyName("sparkRJob")]
    public V1alpha1DataprocJobSpecSparkRJob? SparkRJob { get; set; }

    /// <summary>Optional. Job is a SparkSql job.</summary>
    [JsonPropertyName("sparkSQLJob")]
    public V1alpha1DataprocJobSpecSparkSQLJob? SparkSQLJob { get; set; }

    /// <summary>Optional. Job is a Trino job.</summary>
    [JsonPropertyName("trinoJob")]
    public V1alpha1DataprocJobSpecTrinoJob? TrinoJob { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobStatusConditions
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

/// <summary>Required. Job information, including how, when, and where to run the job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobStatusObservedStatePlacement
{
    /// <summary>Output only. A cluster UUID generated by the Dataproc service when the job is submitted.</summary>
    [JsonPropertyName("clusterUuid")]
    public string? ClusterUuid { get; set; }
}

/// <summary>Output only. The job status. Additional application-specific status information might be contained in the &lt;code&gt;type_job&lt;/code&gt; and &lt;code&gt;yarn_applications&lt;/code&gt; fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobStatusObservedStateStatus
{
    /// <summary>Optional. Output only. Job state details, such as an error description if the state is `ERROR`.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Output only. A state message specifying the overall job state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when this state was entered.</summary>
    [JsonPropertyName("stateStartTime")]
    public string? StateStartTime { get; set; }

    /// <summary>Output only. Additional state information, which includes status reported by the agent.</summary>
    [JsonPropertyName("substate")]
    public string? Substate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobStatusObservedStateStatusHistory
{
    /// <summary>Optional. Output only. Job state details, such as an error description if the state is `ERROR`.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Output only. A state message specifying the overall job state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when this state was entered.</summary>
    [JsonPropertyName("stateStartTime")]
    public string? StateStartTime { get; set; }

    /// <summary>Output only. Additional state information, which includes status reported by the agent.</summary>
    [JsonPropertyName("substate")]
    public string? Substate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobStatusObservedStateYarnApplications
{
    /// <summary>Required. The application name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The numerical progress of the application, from 1 to 100.</summary>
    [JsonPropertyName("progress")]
    public double? Progress { get; set; }

    /// <summary>Required. The application state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Optional. The HTTP URL of the ApplicationMaster, HistoryServer, or TimelineServer that provides application-specific information. The URL uses the internal hostname, and requires a proxy server for resolution and, possibly, access.</summary>
    [JsonPropertyName("trackingURL")]
    public string? TrackingURL { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobStatusObservedState
{
    /// <summary>Output only. Indicates whether the job is completed. If the value is `false`, the job is still in progress. If `true`, the job is completed, and `status.state` field will indicate if it was successful, failed, or cancelled.</summary>
    [JsonPropertyName("done")]
    public bool? Done { get; set; }

    /// <summary>Output only. If present, the location of miscellaneous control files which can be used as part of job setup and handling. If not present, control files might be placed in the same location as `driver_output_uri`.</summary>
    [JsonPropertyName("driverControlFilesURI")]
    public string? DriverControlFilesURI { get; set; }

    /// <summary>Output only. A URI pointing to the location of the stdout of the job's driver program.</summary>
    [JsonPropertyName("driverOutputResourceURI")]
    public string? DriverOutputResourceURI { get; set; }

    /// <summary>Output only. A UUID that uniquely identifies a job within the project over time. This is in contrast to a user-settable reference.job_id that might be reused over time.</summary>
    [JsonPropertyName("jobUUid")]
    public string? JobUUid { get; set; }

    /// <summary>Required. Job information, including how, when, and where to run the job.</summary>
    [JsonPropertyName("placement")]
    public V1alpha1DataprocJobStatusObservedStatePlacement? Placement { get; set; }

    /// <summary>Output only. The job status. Additional application-specific status information might be contained in the &lt;code&gt;type_job&lt;/code&gt; and &lt;code&gt;yarn_applications&lt;/code&gt; fields.</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataprocJobStatusObservedStateStatus? Status { get; set; }

    /// <summary>Output only. The previous job status.</summary>
    [JsonPropertyName("statusHistory")]
    public IList<V1alpha1DataprocJobStatusObservedStateStatusHistory>? StatusHistory { get; set; }

    /// <summary>Output only. The collection of YARN applications spun up by this job.   **Beta** Feature: This report is available for testing purposes only. It  might be changed before final release.</summary>
    [JsonPropertyName("yarnApplications")]
    public IList<V1alpha1DataprocJobStatusObservedStateYarnApplications>? YarnApplications { get; set; }
}

/// <summary>DataprocJobStatus defines the config connector machine state of DataprocJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataprocJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataprocJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataprocJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataprocJob is the Schema for the DataprocJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataprocJobSpec>, IStatus<V1alpha1DataprocJobStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocJob";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocjobs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataprocJobSpec defines the desired state of DataprocJob</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataprocJobSpec Spec { get; set; }

    /// <summary>DataprocJobStatus defines the config connector machine state of DataprocJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataprocJobStatus? Status { get; set; }
}