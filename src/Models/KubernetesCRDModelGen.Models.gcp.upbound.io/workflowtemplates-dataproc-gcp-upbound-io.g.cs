using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.gcp.upbound.io;
public enum V1beta1WorkflowTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsHadoopJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsHadoopJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsHadoopJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsHiveJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsHiveJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsHiveJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPigJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPigJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPigJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPigJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPigJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPrestoJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPrestoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPrestoJob
{
    /// <summary>Presto client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPrestoJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPrestoJobQueryList>? QueryList { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPysparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsPysparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPysparkJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. A job may be reported as thrashing if driver exits with non-zero code 4 times within 10 minute window. Maximum value is 10.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. Maximum value is 240</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsSparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsSparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsSparkJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsSparkRJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsSparkRJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsSparkRJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
    [JsonPropertyName("mainRFileUri")]
    public string? MainRFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsSparkSqlJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsSparkSqlJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobsSparkSqlJob
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsSparkSqlJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsSparkSqlJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderJobs
{
    /// <summary>Job is a Hadoop job.</summary>
    [JsonPropertyName("hadoopJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsHadoopJob>? HadoopJob { get; set; }

    /// <summary>Job is a Hive job.</summary>
    [JsonPropertyName("hiveJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsHiveJob>? HiveJob { get; set; }

    /// <summary>The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: {0,63} No more than 32 labels can be associated with a given job.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Job is a Pig job.</summary>
    [JsonPropertyName("pigJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPigJob>? PigJob { get; set; }

    /// <summary>The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.</summary>
    [JsonPropertyName("prerequisiteStepIds")]
    public IList<string>? PrerequisiteStepIds { get; set; }

    /// <summary>Job is a Presto job.</summary>
    [JsonPropertyName("prestoJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPrestoJob>? PrestoJob { get; set; }

    /// <summary>Job is a PySpark job.</summary>
    [JsonPropertyName("pysparkJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsPysparkJob>? PysparkJob { get; set; }

    /// <summary>Job scheduling configuration.</summary>
    [JsonPropertyName("scheduling")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsScheduling>? Scheduling { get; set; }

    /// <summary>Job is a Spark job.</summary>
    [JsonPropertyName("sparkJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsSparkJob>? SparkJob { get; set; }

    /// <summary>Job is a SparkR job.</summary>
    [JsonPropertyName("sparkRJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsSparkRJob>? SparkRJob { get; set; }

    /// <summary>Job is a SparkSql job.</summary>
    [JsonPropertyName("sparkSqlJob")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobsSparkSqlJob>? SparkSqlJob { get; set; }

    /// <summary>Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job goog-dataproc-workflow-step-id label, and in field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.</summary>
    [JsonPropertyName("stepId")]
    public string? StepId { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderParametersValidationRegex
{
    /// <summary>Required. RE2 regular expressions used to validate the parameter's value. The value must match the regex in its entirety (substring matches are not sufficient).</summary>
    [JsonPropertyName("regexes")]
    public IList<string>? Regexes { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderParametersValidationValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderParametersValidation
{
    /// <summary>Validation based on regular expressions.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1WorkflowTemplateSpecForProviderParametersValidationRegex>? Regex { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<V1beta1WorkflowTemplateSpecForProviderParametersValidationValues>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderParameters
{
    /// <summary>Brief description of the parameter. Must not exceed 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter's list of field paths. A field path is similar in syntax to a .sparkJob.args</summary>
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    /// <summary>Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Validation rules to be applied to this parameter's value.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1WorkflowTemplateSpecForProviderParametersValidation>? Validation { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementClusterSelector
{
    /// <summary>Required. The cluster labels. Cluster must have all labels to match.</summary>
    [JsonPropertyName("clusterLabels")]
    public IDictionary<string, string>? ClusterLabels { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ Note that the policy must be in the same project and Dataproc region.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("gcePdKmsKeyName")]
    public string? GcePdKmsKeyName { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEndpointConfig
{
    /// <summary>If true, enable http access to specific ports on the cluster from external sources. Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>Required. The URI of a sole-tenant /zones/us-central1-a/nodeGroups/node-group-1*node-group-1`</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have Integrity Monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfig
{
    /// <summary>If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The Compute Engine metadata entries to add to all instances (see (https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata)).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither network_uri nor subnetwork_uri is specified, the "default" network of the project is used, if it exists. Cannot be a "Custom Subnet Network" (see /regions/global/default*default`</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity>? NodeGroupAffinity { get; set; }

    /// <summary>The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary>The (https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects//regions/us-east1/subnetworks/sub0 * sub0</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The Compute Engine tags to add to all instances (see (https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigInitializationActions
{
    /// <summary>Required. Cloud Storage URI of executable file.</summary>
    [JsonPropertyName("executableFile")]
    public string? ExecutableFile { get; set; }

    /// <summary>Amount of time executable has to complete. Default is 10 minutes (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTtl")]
    public string? AutoDeleteTtl { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json).</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPassword")]
    public string? CrossRealmTrustSharedPassword { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKey")]
    public string? KdcDbKey { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPassword")]
    public string? KeyPassword { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePassword")]
    public string? KeystorePassword { get; set; }

    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPassword")]
    public string? RootPrincipalPassword { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststore")]
    public string? Truststore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePassword")]
    public string? TruststorePassword { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfig
{
    /// <summary>Kerberos related configuration.</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig>? KerberosConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSoftwareConfig
{
    /// <summary>The version of software inside the cluster. It must be one of the supported Dataproc Versions, such as "1.2" (including a subminor version, such as "1.2.29"), or the "preview" version. If unspecified, it defaults to the latest Debian version.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of components to activate on the cluster.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfig
{
    /// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Port/endpoint configuration for this cluster</summary>
    [JsonPropertyName("endpointConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEndpointConfig>? EndpointConfig { get; set; }

    /// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfig>? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. By default, executables are run on master and all worker nodes. You can test a node's role metadata to run an executable on a master or worker node, as shown below using curl (you can also use wget): ROLE=$(curl -H Metadata-Flavor:Google http://metadata/computeMetadata/v1/instance/attributes/dataproc-role) if ; then ... master specific actions ... else ... worker specific actions ... fi</summary>
    [JsonPropertyName("initializationActions")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigInitializationActions>? InitializationActions { get; set; }

    /// <summary>Lifecycle setting for the cluster.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigLifecycleConfig>? LifecycleConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("masterConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfig>? MasterConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfig>? SecondaryWorkerConfig { get; set; }

    /// <summary>Security settings for the cluster.</summary>
    [JsonPropertyName("securityConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfig>? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)).</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("workerConfig")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfig>? WorkerConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacementManagedCluster
{
    /// <summary>Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix. The name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter. Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Required. The cluster configuration.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedClusterConfig>? Config { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProviderPlacement
{
    /// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
    [JsonPropertyName("clusterSelector")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementClusterSelector>? ClusterSelector { get; set; }

    /// <summary>A cluster that is managed by the workflow.</summary>
    [JsonPropertyName("managedCluster")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacementManagedCluster>? ManagedCluster { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecForProvider
{
    /// <summary>(Beta only) Optional. Timeout duration for the DAG of jobs. You can use "s", "m", "h", and "d" suffixes for second, minute, hour, and day duration values, respectively. The timeout duration must be from 10 minutes ("10m") to 24 hours ("24h" or "1d"). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a (/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.</summary>
    [JsonPropertyName("dagTimeout")]
    public string? DagTimeout { get; set; }

    /// <summary>Required. The Directed Acyclic Graph of Jobs to submit.</summary>
    [JsonPropertyName("jobs")]
    public IList<V1beta1WorkflowTemplateSpecForProviderJobs>? Jobs { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Template parameters whose values are substituted into the template. Values for parameters must be provided when the template is instantiated.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1WorkflowTemplateSpecForProviderParameters>? Parameters { get; set; }

    /// <summary>Required. WorkflowTemplate scheduling information.</summary>
    [JsonPropertyName("placement")]
    public IList<V1beta1WorkflowTemplateSpecForProviderPlacement>? Placement { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Used to perform a consistent read-modify-write. This field should be left blank for a CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the current server version. A typical update template flow would fetch the current template with a GetWorkflowTemplate request, which will return the current template with the version field filled in with the current server version. The user updates other fields in the template, then returns it as part of the UpdateWorkflowTemplate request.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsHadoopJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsHadoopJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsHadoopJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsHiveJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsHiveJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsHiveJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPigJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPigJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPigJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPigJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPigJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPrestoJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPrestoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPrestoJob
{
    /// <summary>Presto client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPrestoJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPrestoJobQueryList>? QueryList { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPysparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsPysparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPysparkJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. A job may be reported as thrashing if driver exits with non-zero code 4 times within 10 minute window. Maximum value is 10.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. Maximum value is 240</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsSparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsSparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsSparkJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsSparkRJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsSparkRJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsSparkRJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
    [JsonPropertyName("mainRFileUri")]
    public string? MainRFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsSparkSqlJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsSparkSqlJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobsSparkSqlJob
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsSparkSqlJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsSparkSqlJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderJobs
{
    /// <summary>Job is a Hadoop job.</summary>
    [JsonPropertyName("hadoopJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsHadoopJob>? HadoopJob { get; set; }

    /// <summary>Job is a Hive job.</summary>
    [JsonPropertyName("hiveJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsHiveJob>? HiveJob { get; set; }

    /// <summary>The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: {0,63} No more than 32 labels can be associated with a given job.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Job is a Pig job.</summary>
    [JsonPropertyName("pigJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPigJob>? PigJob { get; set; }

    /// <summary>The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.</summary>
    [JsonPropertyName("prerequisiteStepIds")]
    public IList<string>? PrerequisiteStepIds { get; set; }

    /// <summary>Job is a Presto job.</summary>
    [JsonPropertyName("prestoJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPrestoJob>? PrestoJob { get; set; }

    /// <summary>Job is a PySpark job.</summary>
    [JsonPropertyName("pysparkJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsPysparkJob>? PysparkJob { get; set; }

    /// <summary>Job scheduling configuration.</summary>
    [JsonPropertyName("scheduling")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsScheduling>? Scheduling { get; set; }

    /// <summary>Job is a Spark job.</summary>
    [JsonPropertyName("sparkJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsSparkJob>? SparkJob { get; set; }

    /// <summary>Job is a SparkR job.</summary>
    [JsonPropertyName("sparkRJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsSparkRJob>? SparkRJob { get; set; }

    /// <summary>Job is a SparkSql job.</summary>
    [JsonPropertyName("sparkSqlJob")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobsSparkSqlJob>? SparkSqlJob { get; set; }

    /// <summary>Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job goog-dataproc-workflow-step-id label, and in field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.</summary>
    [JsonPropertyName("stepId")]
    public string? StepId { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderParametersValidationRegex
{
    /// <summary>Required. RE2 regular expressions used to validate the parameter's value. The value must match the regex in its entirety (substring matches are not sufficient).</summary>
    [JsonPropertyName("regexes")]
    public IList<string>? Regexes { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderParametersValidationValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderParametersValidation
{
    /// <summary>Validation based on regular expressions.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderParametersValidationRegex>? Regex { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderParametersValidationValues>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderParameters
{
    /// <summary>Brief description of the parameter. Must not exceed 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter's list of field paths. A field path is similar in syntax to a .sparkJob.args</summary>
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    /// <summary>Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Validation rules to be applied to this parameter's value.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderParametersValidation>? Validation { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementClusterSelector
{
    /// <summary>Required. The cluster labels. Cluster must have all labels to match.</summary>
    [JsonPropertyName("clusterLabels")]
    public IDictionary<string, string>? ClusterLabels { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ Note that the policy must be in the same project and Dataproc region.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("gcePdKmsKeyName")]
    public string? GcePdKmsKeyName { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEndpointConfig
{
    /// <summary>If true, enable http access to specific ports on the cluster from external sources. Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>Required. The URI of a sole-tenant /zones/us-central1-a/nodeGroups/node-group-1*node-group-1`</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have Integrity Monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfig
{
    /// <summary>If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The Compute Engine metadata entries to add to all instances (see (https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata)).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither network_uri nor subnetwork_uri is specified, the "default" network of the project is used, if it exists. Cannot be a "Custom Subnet Network" (see /regions/global/default*default`</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity>? NodeGroupAffinity { get; set; }

    /// <summary>The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary>The (https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects//regions/us-east1/subnetworks/sub0 * sub0</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The Compute Engine tags to add to all instances (see (https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigInitializationActions
{
    /// <summary>Required. Cloud Storage URI of executable file.</summary>
    [JsonPropertyName("executableFile")]
    public string? ExecutableFile { get; set; }

    /// <summary>Amount of time executable has to complete. Default is 10 minutes (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTtl")]
    public string? AutoDeleteTtl { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json).</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPassword")]
    public string? CrossRealmTrustSharedPassword { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKey")]
    public string? KdcDbKey { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPassword")]
    public string? KeyPassword { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePassword")]
    public string? KeystorePassword { get; set; }

    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPassword")]
    public string? RootPrincipalPassword { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststore")]
    public string? Truststore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePassword")]
    public string? TruststorePassword { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfig
{
    /// <summary>Kerberos related configuration.</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig>? KerberosConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSoftwareConfig
{
    /// <summary>The version of software inside the cluster. It must be one of the supported Dataproc Versions, such as "1.2" (including a subminor version, such as "1.2.29"), or the "preview" version. If unspecified, it defaults to the latest Debian version.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of components to activate on the cluster.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfig
{
    /// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Port/endpoint configuration for this cluster</summary>
    [JsonPropertyName("endpointConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEndpointConfig>? EndpointConfig { get; set; }

    /// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfig>? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. By default, executables are run on master and all worker nodes. You can test a node's role metadata to run an executable on a master or worker node, as shown below using curl (you can also use wget): ROLE=$(curl -H Metadata-Flavor:Google http://metadata/computeMetadata/v1/instance/attributes/dataproc-role) if ; then ... master specific actions ... else ... worker specific actions ... fi</summary>
    [JsonPropertyName("initializationActions")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigInitializationActions>? InitializationActions { get; set; }

    /// <summary>Lifecycle setting for the cluster.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigLifecycleConfig>? LifecycleConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("masterConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfig>? MasterConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfig>? SecondaryWorkerConfig { get; set; }

    /// <summary>Security settings for the cluster.</summary>
    [JsonPropertyName("securityConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfig>? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)).</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("workerConfig")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfig>? WorkerConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacementManagedCluster
{
    /// <summary>Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix. The name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter. Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Required. The cluster configuration.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedClusterConfig>? Config { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateSpecInitProviderPlacement
{
    /// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
    [JsonPropertyName("clusterSelector")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementClusterSelector>? ClusterSelector { get; set; }

    /// <summary>A cluster that is managed by the workflow.</summary>
    [JsonPropertyName("managedCluster")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacementManagedCluster>? ManagedCluster { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1WorkflowTemplateSpecInitProvider
{
    /// <summary>(Beta only) Optional. Timeout duration for the DAG of jobs. You can use "s", "m", "h", and "d" suffixes for second, minute, hour, and day duration values, respectively. The timeout duration must be from 10 minutes ("10m") to 24 hours ("24h" or "1d"). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a (/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.</summary>
    [JsonPropertyName("dagTimeout")]
    public string? DagTimeout { get; set; }

    /// <summary>Required. The Directed Acyclic Graph of Jobs to submit.</summary>
    [JsonPropertyName("jobs")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderJobs>? Jobs { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Template parameters whose values are substituted into the template. Values for parameters must be provided when the template is instantiated.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderParameters>? Parameters { get; set; }

    /// <summary>Required. WorkflowTemplate scheduling information.</summary>
    [JsonPropertyName("placement")]
    public IList<V1beta1WorkflowTemplateSpecInitProviderPlacement>? Placement { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Used to perform a consistent read-modify-write. This field should be left blank for a CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the current server version. A typical update template flow would fetch the current template with a GetWorkflowTemplate request, which will return the current template with the version field filled in with the current server version. The user updates other fields in the template, then returns it as part of the UpdateWorkflowTemplate request.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

public enum V1beta1WorkflowTemplateSpecManagementPoliciesEnum
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

public enum V1beta1WorkflowTemplateSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkflowTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WorkflowTemplateSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkflowTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkflowTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkflowTemplateSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WorkflowTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1WorkflowTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1WorkflowTemplateSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1WorkflowTemplateSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WorkflowTemplateSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WorkflowTemplateSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1WorkflowTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>WorkflowTemplateSpec defines the desired state of WorkflowTemplate</summary>
public partial class V1beta1WorkflowTemplateSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkflowTemplateSpecDeletionPolicyEnum>))]
    public V1beta1WorkflowTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkflowTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkflowTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkflowTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkflowTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WorkflowTemplateSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkflowTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsHadoopJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsHadoopJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsHadoopJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsHiveJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsHiveJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsHiveJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPigJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPigJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPigJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPigJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPigJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPrestoJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPrestoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPrestoJob
{
    /// <summary>Presto client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPrestoJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPrestoJobQueryList>? QueryList { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPysparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsPysparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPysparkJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. A job may be reported as thrashing if driver exits with non-zero code 4 times within 10 minute window. Maximum value is 10.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. Maximum value is 240</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsSparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsSparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsSparkJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>The name of the driver's main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsSparkRJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsSparkRJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsSparkRJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
    [JsonPropertyName("mainRFileUri")]
    public string? MainRFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsSparkSqlJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include "root" package name to configure rootLogger. Examples: 'com.google = FATAL', 'root = INFO', 'org.apache = DEBUG'</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsSparkSqlJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: "hiveJob": { "queryList": { "queries": } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobsSparkSqlJob
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsSparkSqlJobLoggingConfig>? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsSparkSqlJobQueryList>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name="value";).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderJobs
{
    /// <summary>Job is a Hadoop job.</summary>
    [JsonPropertyName("hadoopJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsHadoopJob>? HadoopJob { get; set; }

    /// <summary>Job is a Hive job.</summary>
    [JsonPropertyName("hiveJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsHiveJob>? HiveJob { get; set; }

    /// <summary>The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: {0,63} No more than 32 labels can be associated with a given job.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Job is a Pig job.</summary>
    [JsonPropertyName("pigJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPigJob>? PigJob { get; set; }

    /// <summary>The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.</summary>
    [JsonPropertyName("prerequisiteStepIds")]
    public IList<string>? PrerequisiteStepIds { get; set; }

    /// <summary>Job is a Presto job.</summary>
    [JsonPropertyName("prestoJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPrestoJob>? PrestoJob { get; set; }

    /// <summary>Job is a PySpark job.</summary>
    [JsonPropertyName("pysparkJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsPysparkJob>? PysparkJob { get; set; }

    /// <summary>Job scheduling configuration.</summary>
    [JsonPropertyName("scheduling")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsScheduling>? Scheduling { get; set; }

    /// <summary>Job is a Spark job.</summary>
    [JsonPropertyName("sparkJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsSparkJob>? SparkJob { get; set; }

    /// <summary>Job is a SparkR job.</summary>
    [JsonPropertyName("sparkRJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsSparkRJob>? SparkRJob { get; set; }

    /// <summary>Job is a SparkSql job.</summary>
    [JsonPropertyName("sparkSqlJob")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobsSparkSqlJob>? SparkSqlJob { get; set; }

    /// <summary>Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job goog-dataproc-workflow-step-id label, and in field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.</summary>
    [JsonPropertyName("stepId")]
    public string? StepId { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderParametersValidationRegex
{
    /// <summary>Required. RE2 regular expressions used to validate the parameter's value. The value must match the regex in its entirety (substring matches are not sufficient).</summary>
    [JsonPropertyName("regexes")]
    public IList<string>? Regexes { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderParametersValidationValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderParametersValidation
{
    /// <summary>Validation based on regular expressions.</summary>
    [JsonPropertyName("regex")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderParametersValidationRegex>? Regex { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderParametersValidationValues>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderParameters
{
    /// <summary>Brief description of the parameter. Must not exceed 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter's list of field paths. A field path is similar in syntax to a .sparkJob.args</summary>
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    /// <summary>Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Validation rules to be applied to this parameter's value.</summary>
    [JsonPropertyName("validation")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderParametersValidation>? Validation { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementClusterSelector
{
    /// <summary>Required. The cluster labels. Cluster must have all labels to match.</summary>
    [JsonPropertyName("clusterLabels")]
    public IDictionary<string, string>? ClusterLabels { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ Note that the policy must be in the same project and Dataproc region.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("gcePdKmsKeyName")]
    public string? GcePdKmsKeyName { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEndpointConfig
{
    /// <summary>If true, enable http access to specific ports on the cluster from external sources. Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }

    /// <summary>Output only. The map of port descriptions to URLs. Will only be populated if enable_http_port_access is true.</summary>
    [JsonPropertyName("httpPorts")]
    public IDictionary<string, string>? HttpPorts { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>Required. The URI of a sole-tenant /zones/us-central1-a/nodeGroups/node-group-1*node-group-1`</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have Integrity Monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfig
{
    /// <summary>If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The Compute Engine metadata entries to add to all instances (see (https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata)).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither network_uri nor subnetwork_uri is specified, the "default" network of the project is used, if it exists. Cannot be a "Custom Subnet Network" (see /regions/global/default*default`</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity>? NodeGroupAffinity { get; set; }

    /// <summary>The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary>The (https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects//regions/us-east1/subnetworks/sub0 * sub0</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The Compute Engine tags to add to all instances (see (https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the "global" region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigInitializationActions
{
    /// <summary>Required. Cloud Storage URI of executable file.</summary>
    [JsonPropertyName("executableFile")]
    public string? ExecutableFile { get; set; }

    /// <summary>Amount of time executable has to complete. Default is 10 minutes (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("autoDeleteTtl")]
    public string? AutoDeleteTtl { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json).</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }

    /// <summary>Output only. The time when cluster became idle (most recent job finished) and became eligible for deletion due to idleness (see JSON representation of (https://developers.google.com/protocol-buffers/docs/proto3#json)).</summary>
    [JsonPropertyName("idleStartTime")]
    public string? IdleStartTime { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigManagedGroupConfig
{
    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Output only. The list of instance names. Dataproc derives the names from cluster_name, num_instances, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigManagedGroupConfig>? ManagedGroupConfig { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigManagedGroupConfig
{
    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Output only. The list of instance names. Dataproc derives the names from cluster_name, num_instances, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigManagedGroupConfig>? ManagedGroupConfig { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPassword")]
    public string? CrossRealmTrustSharedPassword { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKey")]
    public string? KdcDbKey { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPassword")]
    public string? KeyPassword { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePassword")]
    public string? KeystorePassword { get; set; }

    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPassword")]
    public string? RootPrincipalPassword { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststore")]
    public string? Truststore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePassword")]
    public string? TruststorePassword { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfig
{
    /// <summary>Kerberos related configuration.</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig>? KerberosConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSoftwareConfig
{
    /// <summary>The version of software inside the cluster. It must be one of the supported Dataproc Versions, such as "1.2" (including a subminor version, such as "1.2.29"), or the "preview" version. If unspecified, it defaults to the latest Debian version.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of components to activate on the cluster.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is "pd-standard"). Valid values: "pd-ssd" (Persistent Disk Solid State Drive) or "pd-standard" (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigManagedGroupConfig
{
    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigDiskConfig>? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Output only. The list of instance names. Dataproc derives the names from cluster_name, num_instances, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigManagedGroupConfig>? ManagedGroupConfig { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See (https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfig
{
    /// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Port/endpoint configuration for this cluster</summary>
    [JsonPropertyName("endpointConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEndpointConfig>? EndpointConfig { get; set; }

    /// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfig>? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. By default, executables are run on master and all worker nodes. You can test a node's role metadata to run an executable on a master or worker node, as shown below using curl (you can also use wget): ROLE=$(curl -H Metadata-Flavor:Google http://metadata/computeMetadata/v1/instance/attributes/dataproc-role) if ; then ... master specific actions ... else ... worker specific actions ... fi</summary>
    [JsonPropertyName("initializationActions")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigInitializationActions>? InitializationActions { get; set; }

    /// <summary>Lifecycle setting for the cluster.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigLifecycleConfig>? LifecycleConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("masterConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfig>? MasterConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfig>? SecondaryWorkerConfig { get; set; }

    /// <summary>Security settings for the cluster.</summary>
    [JsonPropertyName("securityConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfig>? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)).</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("workerConfig")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfig>? WorkerConfig { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacementManagedCluster
{
    /// <summary>Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix. The name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter. Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Required. The cluster configuration.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedClusterConfig>? Config { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProviderPlacement
{
    /// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
    [JsonPropertyName("clusterSelector")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementClusterSelector>? ClusterSelector { get; set; }

    /// <summary>A cluster that is managed by the workflow.</summary>
    [JsonPropertyName("managedCluster")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacementManagedCluster>? ManagedCluster { get; set; }
}

/// <summary></summary>
public partial class V1beta1WorkflowTemplateStatusAtProvider
{
    /// <summary>Output only. The time template was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>(Beta only) Optional. Timeout duration for the DAG of jobs. You can use "s", "m", "h", and "d" suffixes for second, minute, hour, and day duration values, respectively. The timeout duration must be from 10 minutes ("10m") to 24 hours ("24h" or "1d"). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a (/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.</summary>
    [JsonPropertyName("dagTimeout")]
    public string? DagTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/workflowTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Required. The Directed Acyclic Graph of Jobs to submit.</summary>
    [JsonPropertyName("jobs")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderJobs>? Jobs { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Template parameters whose values are substituted into the template. Values for parameters must be provided when the template is instantiated.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderParameters>? Parameters { get; set; }

    /// <summary>Required. WorkflowTemplate scheduling information.</summary>
    [JsonPropertyName("placement")]
    public IList<V1beta1WorkflowTemplateStatusAtProviderPlacement>? Placement { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Output only. The time template was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Used to perform a consistent read-modify-write. This field should be left blank for a CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the current server version. A typical update template flow would fetch the current template with a GetWorkflowTemplate request, which will return the current template with the version field filled in with the current server version. The user updates other fields in the template, then returns it as part of the UpdateWorkflowTemplate request.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1WorkflowTemplateStatusConditions
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

/// <summary>WorkflowTemplateStatus defines the observed state of WorkflowTemplate.</summary>
public partial class V1beta1WorkflowTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkflowTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkflowTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>WorkflowTemplate is the Schema for the WorkflowTemplates API. A Workflow Template is a reusable workflow configuration.</summary>
public partial class V1beta1WorkflowTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkflowTemplateSpec>, IStatus<V1beta1WorkflowTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkflowTemplate";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "workflowtemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkflowTemplateSpec defines the desired state of WorkflowTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkflowTemplateSpec Spec { get; set; }

    /// <summary>WorkflowTemplateStatus defines the observed state of WorkflowTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkflowTemplateStatus? Status { get; set; }
}