using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderArguments
{
    /// <summary>Defaults to FIXED_TYPE. Default value is FIXED_TYPE. Possible values are: FIXED_TYPE, ANY_TYPE.</summary>
    [JsonPropertyName("argumentKind")]
    public string? ArgumentKind { get; set; }

    /// <summary>A JSON schema for the data type. Required unless argumentKind = ANY_TYPE. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. If the API returns a different value for the same schema, e.g. it switched the order of values or replaced STRUCT field type with RECORD field type, we currently cannot suppress the recurring diff this causes. As a workaround, we recommend using the schema as returned by the API.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Specifies whether the argument is input or output. Can be set for procedures only. Possible values are: IN, OUT, INOUT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of this argument. Can be absent for function return argument.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderDatasetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecForProviderDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderDatasetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecForProviderDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderRemoteFunctionOptions
{
    /// <summary>Fully qualified name of the user-provided connection object which holds the authentication information to send requests to the remote service. Format: "projects/{projectId}/locations/{locationId}/connections/{connectionId}"</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>Reference to a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionRef")]
    public V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionRef? ConnectionRef { get; set; }

    /// <summary>Selector for a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionSelector")]
    public V1beta1RoutineSpecForProviderRemoteFunctionOptionsConnectionSelector? ConnectionSelector { get; set; }

    /// <summary>Endpoint of the user-provided remote service, e.g. https://us-east1-my_gcf_project.cloudfunctions.net/remote_add</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Max number of rows in each batch sent to the remote service. If absent or if 0, BigQuery dynamically decides the number of rows in a batch.</summary>
    [JsonPropertyName("maxBatchingRows")]
    public string? MaxBatchingRows { get; set; }

    /// <summary>User-defined context as a set of key/value pairs, which will be sent as function invocation context together with batched arguments in the requests to the remote service. The total number of bytes of keys and values must be less than 8KB. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("userDefinedContext")]
    public IDictionary<string, string>? UserDefinedContext { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderSparkOptionsConnectionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderSparkOptionsConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecForProviderSparkOptionsConnectionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderSparkOptionsConnectionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderSparkOptionsConnectionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecForProviderSparkOptionsConnectionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProviderSparkOptions
{
    /// <summary>Archive files to be extracted into the working directory of each executor. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>Fully qualified name of the user-provided Spark connection object. Format: "projects/{projectId}/locations/{locationId}/connections/{connectionId}"</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>Reference to a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionRef")]
    public V1beta1RoutineSpecForProviderSparkOptionsConnectionRef? ConnectionRef { get; set; }

    /// <summary>Selector for a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionSelector")]
    public V1beta1RoutineSpecForProviderSparkOptionsConnectionSelector? ConnectionSelector { get; set; }

    /// <summary>Custom container image for the runtime environment.</summary>
    [JsonPropertyName("containerImage")]
    public string? ContainerImage { get; set; }

    /// <summary>Files to be placed in the working directory of each executor. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>JARs to include on the driver and executor CLASSPATH. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("jarUris")]
    public IList<string>? JarUris { get; set; }

    /// <summary>The fully qualified name of a class in jarUris, for example, com.example.wordcount. Exactly one of mainClass and main_jar_uri field should be set for Java/Scala language type.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The main file/jar URI of the Spark application. Exactly one of the definitionBody field and the mainFileUri field must be set for Python. Exactly one of mainClass and mainFileUri field should be set for Java/Scala language type.</summary>
    [JsonPropertyName("mainFileUri")]
    public string? MainFileUri { get; set; }

    /// <summary>Configuration properties as a set of key/value pairs, which will be passed on to the Spark application. For more information, see Apache Spark and the procedure option list. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Python files to be placed on the PYTHONPATH for PySpark application. Supported file types: .py, .egg, and .zip. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("pyFileUris")]
    public IList<string>? PyFileUris { get; set; }

    /// <summary>Runtime version. If not specified, the default runtime version is used.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecForProvider
{
    /// <summary>Input/output argument of a function or a stored procedure. Structure is documented below.</summary>
    [JsonPropertyName("arguments")]
    public IList<V1beta1RoutineSpecForProviderArguments>? Arguments { get; set; }

    /// <summary>If set to DATA_MASKING, the function is validated and made available as a masking function. For more information, see https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask Possible values are: DATA_MASKING.</summary>
    [JsonPropertyName("dataGovernanceType")]
    public string? DataGovernanceType { get; set; }

    /// <summary>The ID of the dataset containing this routine</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1RoutineSpecForProviderDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1RoutineSpecForProviderDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>The body of the routine. For functions, this is the expression in the AS clause. If language=SQL, it is the substring inside (but excluding) the parentheses.</summary>
    [JsonPropertyName("definitionBody")]
    public string? DefinitionBody { get; set; }

    /// <summary>The description of the routine if defined.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The determinism level of the JavaScript UDF if defined. Possible values are: DETERMINISM_LEVEL_UNSPECIFIED, DETERMINISTIC, NOT_DETERMINISTIC.</summary>
    [JsonPropertyName("determinismLevel")]
    public string? DeterminismLevel { get; set; }

    /// <summary>Optional. If language = "JAVASCRIPT", this field stores the path of the imported JAVASCRIPT libraries.</summary>
    [JsonPropertyName("importedLibraries")]
    public IList<string>? ImportedLibraries { get; set; }

    /// <summary>The language of the routine. Possible values are: SQL, JAVASCRIPT, PYTHON, JAVA, SCALA.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Remote function specific options. Structure is documented below.</summary>
    [JsonPropertyName("remoteFunctionOptions")]
    public IList<V1beta1RoutineSpecForProviderRemoteFunctionOptions>? RemoteFunctionOptions { get; set; }

    /// <summary>Optional. Can be set only if routineType = "TABLE_VALUED_FUNCTION". If absent, the return table type is inferred from definitionBody at query time in each query that references this routine. If present, then the columns in the evaluated table result will be cast to match the column types specificed in return table type, at query time.</summary>
    [JsonPropertyName("returnTableType")]
    public string? ReturnTableType { get; set; }

    /// <summary>A JSON schema for the return type. Optional if language = "SQL"; required otherwise. If absent, the return type is inferred from definitionBody at query time in each query that references this routine. If present, then the evaluated result will be cast to the specified returned type at query time. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. If the API returns a different value for the same schema, e.g. it switche d the order of values or replaced STRUCT field type with RECORD field type, we currently cannot suppress the recurring diff this causes. As a workaround, we recommend using the schema as returned by the API.</summary>
    [JsonPropertyName("returnType")]
    public string? ReturnType { get; set; }

    /// <summary>The type of routine. Possible values are: SCALAR_FUNCTION, PROCEDURE, TABLE_VALUED_FUNCTION.</summary>
    [JsonPropertyName("routineType")]
    public string? RoutineType { get; set; }

    /// <summary>Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically determined from the routine's configuration. Possible values are: DEFINER, INVOKER.</summary>
    [JsonPropertyName("securityMode")]
    public string? SecurityMode { get; set; }

    /// <summary>Optional. If language is one of "PYTHON", "JAVA", "SCALA", this field stores the options for spark stored procedure. Structure is documented below.</summary>
    [JsonPropertyName("sparkOptions")]
    public IList<V1beta1RoutineSpecForProviderSparkOptions>? SparkOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderArguments
{
    /// <summary>Defaults to FIXED_TYPE. Default value is FIXED_TYPE. Possible values are: FIXED_TYPE, ANY_TYPE.</summary>
    [JsonPropertyName("argumentKind")]
    public string? ArgumentKind { get; set; }

    /// <summary>A JSON schema for the data type. Required unless argumentKind = ANY_TYPE. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. If the API returns a different value for the same schema, e.g. it switched the order of values or replaced STRUCT field type with RECORD field type, we currently cannot suppress the recurring diff this causes. As a workaround, we recommend using the schema as returned by the API.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Specifies whether the argument is input or output. Can be set for procedures only. Possible values are: IN, OUT, INOUT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of this argument. Can be absent for function return argument.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderRemoteFunctionOptions
{
    /// <summary>Fully qualified name of the user-provided connection object which holds the authentication information to send requests to the remote service. Format: "projects/{projectId}/locations/{locationId}/connections/{connectionId}"</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>Reference to a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionRef")]
    public V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionRef? ConnectionRef { get; set; }

    /// <summary>Selector for a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionSelector")]
    public V1beta1RoutineSpecInitProviderRemoteFunctionOptionsConnectionSelector? ConnectionSelector { get; set; }

    /// <summary>Endpoint of the user-provided remote service, e.g. https://us-east1-my_gcf_project.cloudfunctions.net/remote_add</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Max number of rows in each batch sent to the remote service. If absent or if 0, BigQuery dynamically decides the number of rows in a batch.</summary>
    [JsonPropertyName("maxBatchingRows")]
    public string? MaxBatchingRows { get; set; }

    /// <summary>User-defined context as a set of key/value pairs, which will be sent as function invocation context together with batched arguments in the requests to the remote service. The total number of bytes of keys and values must be less than 8KB. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("userDefinedContext")]
    public IDictionary<string, string>? UserDefinedContext { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderSparkOptionsConnectionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderSparkOptionsConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecInitProviderSparkOptionsConnectionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderSparkOptionsConnectionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in bigquery to populate connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderSparkOptionsConnectionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecInitProviderSparkOptionsConnectionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProviderSparkOptions
{
    /// <summary>Archive files to be extracted into the working directory of each executor. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>Fully qualified name of the user-provided Spark connection object. Format: "projects/{projectId}/locations/{locationId}/connections/{connectionId}"</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>Reference to a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionRef")]
    public V1beta1RoutineSpecInitProviderSparkOptionsConnectionRef? ConnectionRef { get; set; }

    /// <summary>Selector for a Connection in bigquery to populate connection.</summary>
    [JsonPropertyName("connectionSelector")]
    public V1beta1RoutineSpecInitProviderSparkOptionsConnectionSelector? ConnectionSelector { get; set; }

    /// <summary>Custom container image for the runtime environment.</summary>
    [JsonPropertyName("containerImage")]
    public string? ContainerImage { get; set; }

    /// <summary>Files to be placed in the working directory of each executor. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>JARs to include on the driver and executor CLASSPATH. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("jarUris")]
    public IList<string>? JarUris { get; set; }

    /// <summary>The fully qualified name of a class in jarUris, for example, com.example.wordcount. Exactly one of mainClass and main_jar_uri field should be set for Java/Scala language type.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The main file/jar URI of the Spark application. Exactly one of the definitionBody field and the mainFileUri field must be set for Python. Exactly one of mainClass and mainFileUri field should be set for Java/Scala language type.</summary>
    [JsonPropertyName("mainFileUri")]
    public string? MainFileUri { get; set; }

    /// <summary>Configuration properties as a set of key/value pairs, which will be passed on to the Spark application. For more information, see Apache Spark and the procedure option list. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Python files to be placed on the PYTHONPATH for PySpark application. Supported file types: .py, .egg, and .zip. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("pyFileUris")]
    public IList<string>? PyFileUris { get; set; }

    /// <summary>Runtime version. If not specified, the default runtime version is used.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecInitProvider
{
    /// <summary>Input/output argument of a function or a stored procedure. Structure is documented below.</summary>
    [JsonPropertyName("arguments")]
    public IList<V1beta1RoutineSpecInitProviderArguments>? Arguments { get; set; }

    /// <summary>If set to DATA_MASKING, the function is validated and made available as a masking function. For more information, see https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask Possible values are: DATA_MASKING.</summary>
    [JsonPropertyName("dataGovernanceType")]
    public string? DataGovernanceType { get; set; }

    /// <summary>The body of the routine. For functions, this is the expression in the AS clause. If language=SQL, it is the substring inside (but excluding) the parentheses.</summary>
    [JsonPropertyName("definitionBody")]
    public string? DefinitionBody { get; set; }

    /// <summary>The description of the routine if defined.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The determinism level of the JavaScript UDF if defined. Possible values are: DETERMINISM_LEVEL_UNSPECIFIED, DETERMINISTIC, NOT_DETERMINISTIC.</summary>
    [JsonPropertyName("determinismLevel")]
    public string? DeterminismLevel { get; set; }

    /// <summary>Optional. If language = "JAVASCRIPT", this field stores the path of the imported JAVASCRIPT libraries.</summary>
    [JsonPropertyName("importedLibraries")]
    public IList<string>? ImportedLibraries { get; set; }

    /// <summary>The language of the routine. Possible values are: SQL, JAVASCRIPT, PYTHON, JAVA, SCALA.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Remote function specific options. Structure is documented below.</summary>
    [JsonPropertyName("remoteFunctionOptions")]
    public IList<V1beta1RoutineSpecInitProviderRemoteFunctionOptions>? RemoteFunctionOptions { get; set; }

    /// <summary>Optional. Can be set only if routineType = "TABLE_VALUED_FUNCTION". If absent, the return table type is inferred from definitionBody at query time in each query that references this routine. If present, then the columns in the evaluated table result will be cast to match the column types specificed in return table type, at query time.</summary>
    [JsonPropertyName("returnTableType")]
    public string? ReturnTableType { get; set; }

    /// <summary>A JSON schema for the return type. Optional if language = "SQL"; required otherwise. If absent, the return type is inferred from definitionBody at query time in each query that references this routine. If present, then the evaluated result will be cast to the specified returned type at query time. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. If the API returns a different value for the same schema, e.g. it switche d the order of values or replaced STRUCT field type with RECORD field type, we currently cannot suppress the recurring diff this causes. As a workaround, we recommend using the schema as returned by the API.</summary>
    [JsonPropertyName("returnType")]
    public string? ReturnType { get; set; }

    /// <summary>The type of routine. Possible values are: SCALAR_FUNCTION, PROCEDURE, TABLE_VALUED_FUNCTION.</summary>
    [JsonPropertyName("routineType")]
    public string? RoutineType { get; set; }

    /// <summary>Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically determined from the routine's configuration. Possible values are: DEFINER, INVOKER.</summary>
    [JsonPropertyName("securityMode")]
    public string? SecurityMode { get; set; }

    /// <summary>Optional. If language is one of "PYTHON", "JAVA", "SCALA", this field stores the options for spark stored procedure. Structure is documented below.</summary>
    [JsonPropertyName("sparkOptions")]
    public IList<V1beta1RoutineSpecInitProviderSparkOptions>? SparkOptions { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecProviderConfigRefPolicy
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
public partial class V1beta1RoutineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RoutineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RoutineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RoutineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RoutineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RoutineSpec defines the desired state of Routine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RoutineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RoutineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RoutineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RoutineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RoutineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineStatusAtProviderArguments
{
    /// <summary>Defaults to FIXED_TYPE. Default value is FIXED_TYPE. Possible values are: FIXED_TYPE, ANY_TYPE.</summary>
    [JsonPropertyName("argumentKind")]
    public string? ArgumentKind { get; set; }

    /// <summary>A JSON schema for the data type. Required unless argumentKind = ANY_TYPE. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. If the API returns a different value for the same schema, e.g. it switched the order of values or replaced STRUCT field type with RECORD field type, we currently cannot suppress the recurring diff this causes. As a workaround, we recommend using the schema as returned by the API.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Specifies whether the argument is input or output. Can be set for procedures only. Possible values are: IN, OUT, INOUT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of this argument. Can be absent for function return argument.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineStatusAtProviderRemoteFunctionOptions
{
    /// <summary>Fully qualified name of the user-provided connection object which holds the authentication information to send requests to the remote service. Format: "projects/{projectId}/locations/{locationId}/connections/{connectionId}"</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>Endpoint of the user-provided remote service, e.g. https://us-east1-my_gcf_project.cloudfunctions.net/remote_add</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Max number of rows in each batch sent to the remote service. If absent or if 0, BigQuery dynamically decides the number of rows in a batch.</summary>
    [JsonPropertyName("maxBatchingRows")]
    public string? MaxBatchingRows { get; set; }

    /// <summary>User-defined context as a set of key/value pairs, which will be sent as function invocation context together with batched arguments in the requests to the remote service. The total number of bytes of keys and values must be less than 8KB. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("userDefinedContext")]
    public IDictionary<string, string>? UserDefinedContext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineStatusAtProviderSparkOptions
{
    /// <summary>Archive files to be extracted into the working directory of each executor. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>Fully qualified name of the user-provided Spark connection object. Format: "projects/{projectId}/locations/{locationId}/connections/{connectionId}"</summary>
    [JsonPropertyName("connection")]
    public string? Connection { get; set; }

    /// <summary>Custom container image for the runtime environment.</summary>
    [JsonPropertyName("containerImage")]
    public string? ContainerImage { get; set; }

    /// <summary>Files to be placed in the working directory of each executor. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>JARs to include on the driver and executor CLASSPATH. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("jarUris")]
    public IList<string>? JarUris { get; set; }

    /// <summary>The fully qualified name of a class in jarUris, for example, com.example.wordcount. Exactly one of mainClass and main_jar_uri field should be set for Java/Scala language type.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The main file/jar URI of the Spark application. Exactly one of the definitionBody field and the mainFileUri field must be set for Python. Exactly one of mainClass and mainFileUri field should be set for Java/Scala language type.</summary>
    [JsonPropertyName("mainFileUri")]
    public string? MainFileUri { get; set; }

    /// <summary>Configuration properties as a set of key/value pairs, which will be passed on to the Spark application. For more information, see Apache Spark and the procedure option list. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Python files to be placed on the PYTHONPATH for PySpark application. Supported file types: .py, .egg, and .zip. For more information about Apache Spark, see Apache Spark.</summary>
    [JsonPropertyName("pyFileUris")]
    public IList<string>? PyFileUris { get; set; }

    /// <summary>Runtime version. If not specified, the default runtime version is used.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineStatusAtProvider
{
    /// <summary>Input/output argument of a function or a stored procedure. Structure is documented below.</summary>
    [JsonPropertyName("arguments")]
    public IList<V1beta1RoutineStatusAtProviderArguments>? Arguments { get; set; }

    /// <summary>The time when this routine was created, in milliseconds since the epoch.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>If set to DATA_MASKING, the function is validated and made available as a masking function. For more information, see https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask Possible values are: DATA_MASKING.</summary>
    [JsonPropertyName("dataGovernanceType")]
    public string? DataGovernanceType { get; set; }

    /// <summary>The ID of the dataset containing this routine</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The body of the routine. For functions, this is the expression in the AS clause. If language=SQL, it is the substring inside (but excluding) the parentheses.</summary>
    [JsonPropertyName("definitionBody")]
    public string? DefinitionBody { get; set; }

    /// <summary>The description of the routine if defined.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The determinism level of the JavaScript UDF if defined. Possible values are: DETERMINISM_LEVEL_UNSPECIFIED, DETERMINISTIC, NOT_DETERMINISTIC.</summary>
    [JsonPropertyName("determinismLevel")]
    public string? DeterminismLevel { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/datasets/{{dataset_id}}/routines/{{routine_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. If language = "JAVASCRIPT", this field stores the path of the imported JAVASCRIPT libraries.</summary>
    [JsonPropertyName("importedLibraries")]
    public IList<string>? ImportedLibraries { get; set; }

    /// <summary>The language of the routine. Possible values are: SQL, JAVASCRIPT, PYTHON, JAVA, SCALA.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>The time when this routine was modified, in milliseconds since the epoch.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public double? LastModifiedTime { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Remote function specific options. Structure is documented below.</summary>
    [JsonPropertyName("remoteFunctionOptions")]
    public IList<V1beta1RoutineStatusAtProviderRemoteFunctionOptions>? RemoteFunctionOptions { get; set; }

    /// <summary>Optional. Can be set only if routineType = "TABLE_VALUED_FUNCTION". If absent, the return table type is inferred from definitionBody at query time in each query that references this routine. If present, then the columns in the evaluated table result will be cast to match the column types specificed in return table type, at query time.</summary>
    [JsonPropertyName("returnTableType")]
    public string? ReturnTableType { get; set; }

    /// <summary>A JSON schema for the return type. Optional if language = "SQL"; required otherwise. If absent, the return type is inferred from definitionBody at query time in each query that references this routine. If present, then the evaluated result will be cast to the specified returned type at query time. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. If the API returns a different value for the same schema, e.g. it switche d the order of values or replaced STRUCT field type with RECORD field type, we currently cannot suppress the recurring diff this causes. As a workaround, we recommend using the schema as returned by the API.</summary>
    [JsonPropertyName("returnType")]
    public string? ReturnType { get; set; }

    /// <summary>The type of routine. Possible values are: SCALAR_FUNCTION, PROCEDURE, TABLE_VALUED_FUNCTION.</summary>
    [JsonPropertyName("routineType")]
    public string? RoutineType { get; set; }

    /// <summary>Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically determined from the routine's configuration. Possible values are: DEFINER, INVOKER.</summary>
    [JsonPropertyName("securityMode")]
    public string? SecurityMode { get; set; }

    /// <summary>Optional. If language is one of "PYTHON", "JAVA", "SCALA", this field stores the options for spark stored procedure. Structure is documented below.</summary>
    [JsonPropertyName("sparkOptions")]
    public IList<V1beta1RoutineStatusAtProviderSparkOptions>? SparkOptions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineStatusConditions
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

/// <summary>RoutineStatus defines the observed state of Routine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RoutineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RoutineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RoutineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Routine is the Schema for the Routines API. A user-defined function or a stored procedure that belongs to a Dataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Routine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RoutineSpec>, IStatus<V1beta1RoutineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Routine";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "routines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RoutineSpec defines the desired state of Routine</summary>
    [JsonPropertyName("spec")]
    public V1beta1RoutineSpec Spec { get; set; }

    /// <summary>RoutineStatus defines the observed state of Routine.</summary>
    [JsonPropertyName("status")]
    public V1beta1RoutineStatus? Status { get; set; }
}

/// <summary>Routine is the Schema for the Routines API. A user-defined function or a stored procedure that belongs to a Dataset</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RoutineList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Routine>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RoutineList";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "routines";
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
    public IList<V1beta1Routine> Items { get; set; }
}