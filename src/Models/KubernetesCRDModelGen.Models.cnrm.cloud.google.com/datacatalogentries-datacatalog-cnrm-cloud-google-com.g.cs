using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.cnrm.cloud.google.com;
#nullable enable
/// <summary>DataCatalogEntry is the Schema for the DataCatalogEntry API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogEntryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataCatalogEntry>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogEntryList";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogentries";
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
    public IList<V1alpha1DataCatalogEntry> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecBusinessContextContactsPeople
{
    /// <summary>Designation of the person, for example, Data Steward.</summary>
    [JsonPropertyName("designation")]
    public string? Designation { get; set; }

    /// <summary>Email of the person in the format of `john.doe@xyz`, `&lt;john.doe@xyz&gt;`, or `John Doe&lt;john.doe@xyz&gt;`.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Contact people for the entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecBusinessContextContacts
{
    /// <summary>The list of contact people for the entry.</summary>
    [JsonPropertyName("people")]
    public IList<V1alpha1DataCatalogEntrySpecBusinessContextContactsPeople>? People { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Entry overview fields for rich text descriptions of entries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecBusinessContextEntryOverview
{
    /// <summary>Entry overview with support for rich text.   The overview must only contain Unicode characters, and should be  formatted using HTML.  The maximum length is 10 MiB as this value holds HTML descriptions  including encoded images. The maximum length of the text without images  is 100 KiB.</summary>
    [JsonPropertyName("overview")]
    public string? Overview { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Business Context of the entry. Not supported for BigQuery datasets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecBusinessContext
{
    /// <summary>Contact people for the entry.</summary>
    [JsonPropertyName("contacts")]
    public V1alpha1DataCatalogEntrySpecBusinessContextContacts? Contacts { get; set; }

    /// <summary>Entry overview fields for rich text descriptions of entries.</summary>
    [JsonPropertyName("entryOverview")]
    public V1alpha1DataCatalogEntrySpecBusinessContextEntryOverview? EntryOverview { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to Cloud Bigtable system. Only settable when `integrated_system` is equal to `CLOUD_BIGTABLE`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecCloudBigtableSystemSpec
{
    /// <summary>Display name of the Instance. This is user specified and different from the resource name.</summary>
    [JsonPropertyName("instanceDisplayName")]
    public string? InstanceDisplayName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification for the BigQuery connection to a Cloud SQL instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecDataSourceConnectionSpecBigqueryConnectionSpecCloudSQL
{
    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud SQL instance ID in the format of `project:location:instance`.</summary>
    [JsonPropertyName("instanceID")]
    public string? InstanceID { get; set; }

    /// <summary>Type of the Cloud SQL database.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Fields specific to BigQuery connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecDataSourceConnectionSpecBigqueryConnectionSpec
{
    /// <summary>Specification for the BigQuery connection to a Cloud SQL instance.</summary>
    [JsonPropertyName("cloudSQL")]
    public V1alpha1DataCatalogEntrySpecDataSourceConnectionSpecBigqueryConnectionSpecCloudSQL? CloudSQL { get; set; }

    /// <summary>The type of the BigQuery connection.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>True if there are credentials attached to the BigQuery connection; false otherwise.</summary>
    [JsonPropertyName("hasCredential")]
    public bool? HasCredential { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a data source connection. Valid only for entries with the `DATA_SOURCE_CONNECTION` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecDataSourceConnectionSpec
{
    /// <summary>Output only. Fields specific to BigQuery connections.</summary>
    [JsonPropertyName("bigqueryConnectionSpec")]
    public V1alpha1DataCatalogEntrySpecDataSourceConnectionSpecBigqueryConnectionSpec? BigqueryConnectionSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Spec what aplies to tables that are actually views. Not set for "real" tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecDatabaseTableSpecDatabaseViewSpec
{
    /// <summary>Name of a singular table this view reflects one to one.</summary>
    [JsonPropertyName("baseTable")]
    public string? BaseTable { get; set; }

    /// <summary>SQL query used to generate this view.</summary>
    [JsonPropertyName("sqlQuery")]
    public string? SqlQuery { get; set; }

    /// <summary>Type of this view.</summary>
    [JsonPropertyName("viewType")]
    public string? ViewType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a table resource. Valid only for entries with the `TABLE` or `EXPLORE` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecDatabaseTableSpec
{
    /// <summary>Spec what aplies to tables that are actually views. Not set for "real" tables.</summary>
    [JsonPropertyName("databaseViewSpec")]
    public V1alpha1DataCatalogEntrySpecDatabaseTableSpecDatabaseViewSpec? DatabaseViewSpec { get; set; }

    /// <summary>Type of this table.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Vertex AI Dataset specific fields</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecDatasetSpecVertexDatasetSpec
{
    /// <summary>The number of DataItems in this Dataset. Only apply for non-structured Dataset.</summary>
    [JsonPropertyName("dataItemCount")]
    public long? DataItemCount { get; set; }

    /// <summary>Type of the dataset.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecDatasetSpec
{
    /// <summary>Vertex AI Dataset specific fields</summary>
    [JsonPropertyName("vertexDatasetSpec")]
    public V1alpha1DataCatalogEntrySpecDatasetSpecVertexDatasetSpec? VertexDatasetSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to the entry group that contains the entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecEntryGroupRef
{
    /// <summary>A reference to an externally managed DataCatalogEntryGroup resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/entrygroups/{{entrygroupID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataCatalogEntryGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataCatalogEntryGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FeatureonlineStore spec for Vertex AI Feature Store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFeatureOnlineStoreSpec
{
}
#nullable disable

#nullable enable
/// <summary>Schema in Avro JSON format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatAvro
{
    /// <summary>JSON source of the Avro schema.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Marks a CSV-encoded data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatCsv
{
}
#nullable disable

#nullable enable
/// <summary>Marks an ORC-encoded data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatOrc
{
}
#nullable disable

#nullable enable
/// <summary>Marks a Parquet-encoded data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatParquet
{
}
#nullable disable

#nullable enable
/// <summary>Schema in protocol buffer format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatProtobuf
{
    /// <summary>Protocol buffer source of the schema.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Schema in Thrift format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatThrift
{
    /// <summary>Thrift IDL source of the schema.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Format of the data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormat
{
    /// <summary>Schema in Avro JSON format.</summary>
    [JsonPropertyName("avro")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatAvro? Avro { get; set; }

    /// <summary>Marks a CSV-encoded data source.</summary>
    [JsonPropertyName("csv")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatCsv? Csv { get; set; }

    /// <summary>Marks an ORC-encoded data source.</summary>
    [JsonPropertyName("orc")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatOrc? Orc { get; set; }

    /// <summary>Marks a Parquet-encoded data source.</summary>
    [JsonPropertyName("parquet")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatParquet? Parquet { get; set; }

    /// <summary>Schema in protocol buffer format.</summary>
    [JsonPropertyName("protobuf")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatProtobuf? Protobuf { get; set; }

    /// <summary>Schema in Thrift format.</summary>
    [JsonPropertyName("thrift")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormatThrift? Thrift { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Common Dataplex fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpec
{
    /// <summary>Fully qualified resource name of an asset in Dataplex, to which the underlying data source (Cloud Storage bucket or BigQuery dataset) of the entity is attached.</summary>
    [JsonPropertyName("asset")]
    public string? Asset { get; set; }

    /// <summary>Compression format of the data, e.g., zip, gzip etc.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Format of the data.</summary>
    [JsonPropertyName("dataFormat")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpecDataFormat? DataFormat { get; set; }

    /// <summary>Project ID of the underlying Cloud Storage or BigQuery data. Note that this may not be the same project as the correspondingly Dataplex lake / zone / asset.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fields specific to a Dataplex fileset and present only in the Dataplex fileset entries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFileset
{
    /// <summary>Common Dataplex fields.</summary>
    [JsonPropertyName("dataplexSpec")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFilesetDataplexSpec? DataplexSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a fileset resource. Valid only for entries with the `FILESET` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecFilesetSpec
{
    /// <summary>Fields specific to a Dataplex fileset and present only in the Dataplex fileset entries.</summary>
    [JsonPropertyName("dataplexFileset")]
    public V1alpha1DataCatalogEntrySpecFilesetSpecDataplexFileset? DataplexFileset { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a Cloud Storage fileset. Valid only for entries with the `FILESET` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecGcsFilesetSpec
{
    /// <summary>Required. Patterns to identify a set of files in Google Cloud Storage.   For more information, see [Wildcard Names]  (https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames).   Note: Currently, bucket wildcards are not supported.   Examples of valid `file_patterns`:    * `gs://bucket_name/dir/*`: matches all files in `bucket_name/dir`                               directory   * `gs://bucket_name/dir/**`: matches all files in `bucket_name/dir`                                and all subdirectories   * `gs://bucket_name/file*`: matches files prefixed by `file` in                               `bucket_name`   * `gs://bucket_name/??.txt`: matches files with two characters followed by                                `.txt` in `bucket_name`   * `gs://bucket_name/[aeiou].txt`: matches files that contain a single                                     vowel character followed by `.txt` in                                     `bucket_name`   * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ...                                   or `m` followed by `.txt` in `bucket_name`   * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that match                               the `a/*/b` pattern, such as `a/c/b`, `a/d/b`   * `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt`   You can combine wildcards to match complex sets of files, for example:   `gs://bucket_name/[a-m]??.j*g`</summary>
    [JsonPropertyName("filePatterns")]
    public IList<string> FilePatterns { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to Looker sysstem. Only settable when `user_specified_system` is equal to `LOOKER`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecLookerSystemSpec
{
    /// <summary>Name of the parent Looker Instance. Empty if it does not exist.</summary>
    [JsonPropertyName("parentInstanceDisplayName")]
    public string? ParentInstanceDisplayName { get; set; }

    /// <summary>ID of the parent Looker Instance. Empty if it does not exist. Example value: `someinstance.looker.com`</summary>
    [JsonPropertyName("parentInstanceID")]
    public string? ParentInstanceID { get; set; }

    /// <summary>Name of the parent Model. Empty if it does not exist.</summary>
    [JsonPropertyName("parentModelDisplayName")]
    public string? ParentModelDisplayName { get; set; }

    /// <summary>ID of the parent Model. Empty if it does not exist.</summary>
    [JsonPropertyName("parentModelID")]
    public string? ParentModelID { get; set; }

    /// <summary>Name of the parent View. Empty if it does not exist.</summary>
    [JsonPropertyName("parentViewDisplayName")]
    public string? ParentViewDisplayName { get; set; }

    /// <summary>ID of the parent View. Empty if it does not exist.</summary>
    [JsonPropertyName("parentViewID")]
    public string? ParentViewID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Source of a Vertex model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecModelSpecVertexModelSpecVertexModelSourceInfo
{
    /// <summary>If this Model is copy of another Model. If true then [source_type][google.cloud.datacatalog.v1.VertexModelSourceInfo.source_type] pertains to the original.</summary>
    [JsonPropertyName("copy")]
    public bool? Copy { get; set; }

    /// <summary>Type of the model source.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification for vertex model resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecModelSpecVertexModelSpec
{
    /// <summary>URI of the Docker image to be used as the custom container for serving predictions.</summary>
    [JsonPropertyName("containerImageURI")]
    public string? ContainerImageURI { get; set; }

    /// <summary>User provided version aliases so that a model version can be referenced via alias</summary>
    [JsonPropertyName("versionAliases")]
    public IList<string>? VersionAliases { get; set; }

    /// <summary>The description of this version.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>The version ID of the model.</summary>
    [JsonPropertyName("versionID")]
    public string? VersionID { get; set; }

    /// <summary>Source of a Vertex model.</summary>
    [JsonPropertyName("vertexModelSourceInfo")]
    public V1alpha1DataCatalogEntrySpecModelSpecVertexModelSpecVertexModelSourceInfo? VertexModelSourceInfo { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Model specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecModelSpec
{
    /// <summary>Specification for vertex model resources.</summary>
    [JsonPropertyName("vertexModelSpec")]
    public V1alpha1DataCatalogEntrySpecModelSpecVertexModelSpec? VertexModelSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fields specific for BigQuery routines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecRoutineSpecBigqueryRoutineSpec
{
    /// <summary>Paths of the imported libraries.</summary>
    [JsonPropertyName("importedLibraries")]
    public IList<string>? ImportedLibraries { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecRoutineSpecRoutineArguments
{
    /// <summary>Specifies whether the argument is input or output.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of the argument. A return argument of a function might not have a name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the argument. The exact value depends on the source system and the language.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a user-defined function or procedure. Valid only for entries with the `ROUTINE` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecRoutineSpec
{
    /// <summary>Fields specific for BigQuery routines.</summary>
    [JsonPropertyName("bigqueryRoutineSpec")]
    public V1alpha1DataCatalogEntrySpecRoutineSpecBigqueryRoutineSpec? BigqueryRoutineSpec { get; set; }

    /// <summary>The body of the routine.</summary>
    [JsonPropertyName("definitionBody")]
    public string? DefinitionBody { get; set; }

    /// <summary>The language the routine is written in. The exact value depends on the  source system. For BigQuery routines, possible values are:   * `SQL`  * `JAVASCRIPT`</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Return type of the argument. The exact value depends on the source system and the language.</summary>
    [JsonPropertyName("returnType")]
    public string? ReturnType { get; set; }

    /// <summary>Arguments of the routine.</summary>
    [JsonPropertyName("routineArguments")]
    public IList<V1alpha1DataCatalogEntrySpecRoutineSpecRoutineArguments>? RoutineArguments { get; set; }

    /// <summary>The type of the routine.</summary>
    [JsonPropertyName("routineType")]
    public string? RoutineType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Looker specific column info of this column.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecSchemaColumnsLookerColumnSpec
{
    /// <summary>Looker specific column type of this column.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The subtype of the RANGE, if the type of this field is RANGE. If the type is RANGE, this field is required. Possible values for the field element type of a RANGE include: * DATE * DATETIME * TIMESTAMP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecSchemaColumnsRangeElementType
{
    /// <summary>Required. The type of a field element. See [ColumnSchema.type][google.cloud.datacatalog.v1.ColumnSchema.type].</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecSchemaColumns
{
    /// <summary>Required. Name of the column.   Must be a UTF-8 string without dots (.).  The maximum size is 64 bytes.</summary>
    [JsonPropertyName("column")]
    public string Column { get; set; }

    /// <summary>Optional. Default value for the column.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>Optional. Description of the column. Default value is an empty string.   The description must be a UTF-8 string with the maximum size of 2000  bytes.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Garbage collection policy for the column or column family. Applies to systems like Cloud Bigtable.</summary>
    [JsonPropertyName("gcRule")]
    public string? GcRule { get; set; }

    /// <summary>Optional. Most important inclusion of this column.</summary>
    [JsonPropertyName("highestIndexingType")]
    public string? HighestIndexingType { get; set; }

    /// <summary>Looker specific column info of this column.</summary>
    [JsonPropertyName("lookerColumnSpec")]
    public V1alpha1DataCatalogEntrySpecSchemaColumnsLookerColumnSpec? LookerColumnSpec { get; set; }

    /// <summary>Optional. A column's mode indicates whether values in this column are  required, nullable, or repeated.   Only `NULLABLE`, `REQUIRED`, and `REPEATED` values are supported.  Default mode is `NULLABLE`.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Optional. Ordinal position</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Optional. The subtype of the RANGE, if the type of this field is RANGE. If the type is RANGE, this field is required. Possible values for the field element type of a RANGE include: * DATE * DATETIME * TIMESTAMP</summary>
    [JsonPropertyName("rangeElementType")]
    public V1alpha1DataCatalogEntrySpecSchemaColumnsRangeElementType? RangeElementType { get; set; }

    /// <summary>Optional. Schema of sub-columns. A column can have zero or more sub-columns.</summary>
    [JsonPropertyName("subcolumns")]
    public JsonNode? Subcolumns { get; set; }

    /// <summary>Required. Type of the column.   Must be a UTF-8 string with the maximum size of 128 bytes.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Schema of the entry. An entry might not have any schema attached to it.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecSchema
{
    /// <summary>The unified GoogleSQL-like schema of columns.   The overall maximum number of columns and nested columns is 10,000.  The maximum nested depth is 15 levels.</summary>
    [JsonPropertyName("columns")]
    public IList<V1alpha1DataCatalogEntrySpecSchemaColumns>? Columns { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecServiceSpecCloudBigtableInstanceSpecCloudBigtableClusterSpecs
{
    /// <summary>Name of the cluster.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A link back to the parent resource, in this case Instance.</summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>Location of the cluster, typically a Cloud zone.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Type of the resource. For a cluster this would be "CLUSTER".</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to Instance entries of `CLOUD_BIGTABLE` system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecServiceSpecCloudBigtableInstanceSpec
{
    /// <summary>The list of clusters for the Instance.</summary>
    [JsonPropertyName("cloudBigtableClusterSpecs")]
    public IList<V1alpha1DataCatalogEntrySpecServiceSpecCloudBigtableInstanceSpecCloudBigtableClusterSpecs>? CloudBigtableClusterSpecs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a Service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecServiceSpec
{
    /// <summary>Specification that applies to Instance entries of `CLOUD_BIGTABLE` system.</summary>
    [JsonPropertyName("cloudBigtableInstanceSpec")]
    public V1alpha1DataCatalogEntrySpecServiceSpecCloudBigtableInstanceSpec? CloudBigtableInstanceSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Timestamps from the underlying resource, not from the Data Catalog  entry.   Output only when the entry has a system listed in the `IntegratedSystem`  enum. For entries with `user_specified_system`, this field is optional  and defaults to an empty timestamp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecSourceSystemTimestamps
{
    /// <summary>Creation timestamp of the resource within the given system.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Timestamp of the last modification of the resource or its metadata within  a given system.   Note: Depending on the source system, not every modification updates this  timestamp.  For example, BigQuery timestamps every metadata modification but not data  or permission changes.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a relational database system. Only settable when `user_specified_system` is equal to `SQL_DATABASE`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecSqlDatabaseSystemSpec
{
    /// <summary>Version of the database engine.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>Host of the SQL database enum InstanceHost { UNDEFINED = 0; SELF_HOSTED = 1; CLOUD_SQL = 2; AMAZON_RDS = 3; AZURE_SQL = 4; } Host of the enclousing database instance.</summary>
    [JsonPropertyName("instanceHost")]
    public string? InstanceHost { get; set; }

    /// <summary>SQL Database Engine. enum SqlEngine { UNDEFINED = 0; MY_SQL = 1; POSTGRE_SQL = 2; SQL_SERVER = 3; } Engine of the enclosing database instance.</summary>
    [JsonPropertyName("sqlEngine")]
    public string? SqlEngine { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Resource usage statistics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpecUsageSignal
{
    /// <summary>Favorite count in the source system.</summary>
    [JsonPropertyName("favoriteCount")]
    public long? FavoriteCount { get; set; }

    /// <summary>The end timestamp of the duration of usage statistics.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogEntrySpec defines the desired state of DataCatalogEntry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntrySpec
{
    /// <summary>Business Context of the entry. Not supported for BigQuery datasets</summary>
    [JsonPropertyName("businessContext")]
    public V1alpha1DataCatalogEntrySpecBusinessContext? BusinessContext { get; set; }

    /// <summary>Specification that applies to Cloud Bigtable system. Only settable when `integrated_system` is equal to `CLOUD_BIGTABLE`</summary>
    [JsonPropertyName("cloudBigtableSystemSpec")]
    public V1alpha1DataCatalogEntrySpecCloudBigtableSystemSpec? CloudBigtableSystemSpec { get; set; }

    /// <summary>Specification that applies to a data source connection. Valid only for entries with the `DATA_SOURCE_CONNECTION` type.</summary>
    [JsonPropertyName("dataSourceConnectionSpec")]
    public V1alpha1DataCatalogEntrySpecDataSourceConnectionSpec? DataSourceConnectionSpec { get; set; }

    /// <summary>Specification that applies to a table resource. Valid only for entries with the `TABLE` or `EXPLORE` type.</summary>
    [JsonPropertyName("databaseTableSpec")]
    public V1alpha1DataCatalogEntrySpecDatabaseTableSpec? DatabaseTableSpec { get; set; }

    /// <summary>Specification that applies to a dataset.</summary>
    [JsonPropertyName("datasetSpec")]
    public V1alpha1DataCatalogEntrySpecDatasetSpec? DatasetSpec { get; set; }

    /// <summary>Entry description that can consist of several sentences or paragraphs  that describe entry contents.   The description must not contain Unicode non-characters as well as C0  and C1 control codes except tabs (HT), new lines (LF), carriage returns  (CR), and page breaks (FF).  The maximum size is 2000 bytes when encoded in UTF-8.  Default value is an empty string.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name of an entry.   The maximum size is 500 bytes when encoded in UTF-8.  Default value is an empty string.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Reference to the entry group that contains the entry.</summary>
    [JsonPropertyName("entryGroupRef")]
    public V1alpha1DataCatalogEntrySpecEntryGroupRef EntryGroupRef { get; set; }

    /// <summary>FeatureonlineStore spec for Vertex AI Feature Store.</summary>
    [JsonPropertyName("featureOnlineStoreSpec")]
    public V1alpha1DataCatalogEntrySpecFeatureOnlineStoreSpec? FeatureOnlineStoreSpec { get; set; }

    /// <summary>Specification that applies to a fileset resource. Valid only for entries with the `FILESET` type.</summary>
    [JsonPropertyName("filesetSpec")]
    public V1alpha1DataCatalogEntrySpecFilesetSpec? FilesetSpec { get; set; }

    /// <summary>Specification that applies to a Cloud Storage fileset. Valid only for entries with the `FILESET` type.</summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1alpha1DataCatalogEntrySpecGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>Cloud labels attached to the entry.   In Data Catalog, you can create and modify labels attached only to custom  entries. Synced entries have unmodifiable labels that come from the source  system.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Specification that applies to Looker sysstem. Only settable when `user_specified_system` is equal to `LOOKER`</summary>
    [JsonPropertyName("lookerSystemSpec")]
    public V1alpha1DataCatalogEntrySpecLookerSystemSpec? LookerSystemSpec { get; set; }

    /// <summary>Model specification.</summary>
    [JsonPropertyName("modelSpec")]
    public V1alpha1DataCatalogEntrySpecModelSpec? ModelSpec { get; set; }

    /// <summary>The DataCatalogEntry name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Specification that applies to a user-defined function or procedure. Valid only for entries with the `ROUTINE` type.</summary>
    [JsonPropertyName("routineSpec")]
    public V1alpha1DataCatalogEntrySpecRoutineSpec? RoutineSpec { get; set; }

    /// <summary>Schema of the entry. An entry might not have any schema attached to it.</summary>
    [JsonPropertyName("schema")]
    public V1alpha1DataCatalogEntrySpecSchema? Schema { get; set; }

    /// <summary>Specification that applies to a Service resource.</summary>
    [JsonPropertyName("serviceSpec")]
    public V1alpha1DataCatalogEntrySpecServiceSpec? ServiceSpec { get; set; }

    /// <summary>Timestamps from the underlying resource, not from the Data Catalog  entry.   Output only when the entry has a system listed in the `IntegratedSystem`  enum. For entries with `user_specified_system`, this field is optional  and defaults to an empty timestamp.</summary>
    [JsonPropertyName("sourceSystemTimestamps")]
    public V1alpha1DataCatalogEntrySpecSourceSystemTimestamps? SourceSystemTimestamps { get; set; }

    /// <summary>Specification that applies to a relational database system. Only settable when `user_specified_system` is equal to `SQL_DATABASE`</summary>
    [JsonPropertyName("sqlDatabaseSystemSpec")]
    public V1alpha1DataCatalogEntrySpecSqlDatabaseSystemSpec? SqlDatabaseSystemSpec { get; set; }

    /// <summary>The type of the entry.   For details, see [`EntryType`](#entrytype).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Resource usage statistics.</summary>
    [JsonPropertyName("usageSignal")]
    public V1alpha1DataCatalogEntrySpecUsageSignal? UsageSignal { get; set; }

    /// <summary>Indicates the entry's source system that Data Catalog doesn't  automatically integrate with.   The `user_specified_system` string has the following limitations:   * Is case insensitive.  * Must begin with a letter or underscore.  * Can only contain letters, numbers, and underscores.  * Must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedSystem")]
    public string? UserSpecifiedSystem { get; set; }

    /// <summary>Custom entry type that doesn't match any of the values allowed for input  and listed in the `EntryType` enum.   When creating an entry, first check the type values in the enum.  If there are no appropriate types for the new entry,  provide a custom value, for example, `my_special_type`.   The `user_specified_type` string has the following limitations:   * Is case insensitive.  * Must begin with a letter or underscore.  * Can only contain letters, numbers, and underscores.  * Must be at least 1 character and at most 64 characters long.</summary>
    [JsonPropertyName("userSpecifiedType")]
    public string? UserSpecifiedType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusConditions
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
/// <summary>Output only. Specification for a group of BigQuery tables with  the `[prefix]YYYYMMDD` name pattern.   For more information, see [Introduction to partitioned tables]  (https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateBigqueryDateShardedSpec
{
    /// <summary>Output only. The Data Catalog resource name of the dataset entry the  current table belongs to. For example:   `projects/{PROJECT_ID}/locations/{LOCATION}/entrygroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}`.</summary>
    [JsonPropertyName("dataset")]
    public string? Dataset { get; set; }

    /// <summary>Output only. BigQuery resource name of the latest shard.</summary>
    [JsonPropertyName("latestShardResource")]
    public string? LatestShardResource { get; set; }

    /// <summary>Output only. Total number of shards.</summary>
    [JsonPropertyName("shardCount")]
    public long? ShardCount { get; set; }

    /// <summary>Output only. The table name prefix of the shards.   The name of any given shard is `[table_prefix]YYYYMMDD`.  For example, for the `MyTable20180101` shard, the  `table_prefix` is `MyTable`.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification of a BigQuery table. Populated only if the `table_source_type` is `BIGQUERY_TABLE`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateBigqueryTableSpecTableSpec
{
    /// <summary>Output only. If the table is date-sharded, that is, it matches the  `[prefix]YYYYMMDD` name pattern, this field is the Data Catalog resource  name of the date-sharded grouped entry. For example:   `projects/{PROJECT_ID}/locations/{LOCATION}/entrygroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}`.   Otherwise, `grouped_entry` is empty.</summary>
    [JsonPropertyName("groupedEntry")]
    public string? GroupedEntry { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Table view specification. Populated only if the `table_source_type` is `BIGQUERY_VIEW`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateBigqueryTableSpecViewSpec
{
    /// <summary>Output only. The query that defines the table view.</summary>
    [JsonPropertyName("viewQuery")]
    public string? ViewQuery { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Specification that applies to a BigQuery table. Valid only for entries with the `TABLE` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateBigqueryTableSpec
{
    /// <summary>Output only. The table source type.</summary>
    [JsonPropertyName("tableSourceType")]
    public string? TableSourceType { get; set; }

    /// <summary>Specification of a BigQuery table. Populated only if the `table_source_type` is `BIGQUERY_TABLE`.</summary>
    [JsonPropertyName("tableSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateBigqueryTableSpecTableSpec? TableSpec { get; set; }

    /// <summary>Table view specification. Populated only if the `table_source_type` is `BIGQUERY_VIEW`.</summary>
    [JsonPropertyName("viewSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateBigqueryTableSpecViewSpec? ViewSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Detailed properties of the underlying storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDataSourceStorageProperties
{
    /// <summary>Patterns to identify a set of files for this fileset.   Examples of a valid `file_pattern`:    * `gs://bucket_name/dir/*`: matches all files in the `bucket_name/dir`                               directory   * `gs://bucket_name/dir/**`: matches all files in the `bucket_name/dir`                                and all subdirectories recursively   * `gs://bucket_name/file*`: matches files prefixed by `file` in                               `bucket_name`   * `gs://bucket_name/??.txt`: matches files with two characters followed by                                `.txt` in `bucket_name`   * `gs://bucket_name/[aeiou].txt`: matches files that contain a single                                     vowel character followed by `.txt` in                                     `bucket_name`   * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ...                                   or `m` followed by `.txt` in `bucket_name`   * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that match                               the `a/*/b` pattern, such as `a/c/b`, `a/d/b`   * `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt`</summary>
    [JsonPropertyName("filePattern")]
    public IList<string>? FilePattern { get; set; }

    /// <summary>File type in MIME format, for example, `text/plain`.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Physical location of the entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDataSource
{
    /// <summary>Full name of a resource as defined by the service. For example:   `//bigquery.googleapis.com/projects/{PROJECT_ID}/locations/{LOCATION}/datasets/{DATASET_ID}/tables/{TABLE_ID}`</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Service that physically stores the data.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Output only. Data Catalog entry name, if applicable.</summary>
    [JsonPropertyName("sourceEntry")]
    public string? SourceEntry { get; set; }

    /// <summary>Detailed properties of the underlying storage.</summary>
    [JsonPropertyName("storageProperties")]
    public V1alpha1DataCatalogEntryStatusObservedStateDataSourceStorageProperties? StorageProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Schema in Avro JSON format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatAvro
{
    /// <summary>JSON source of the Avro schema.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Marks a CSV-encoded data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatCsv
{
}
#nullable disable

#nullable enable
/// <summary>Marks an ORC-encoded data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatOrc
{
}
#nullable disable

#nullable enable
/// <summary>Marks a Parquet-encoded data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatParquet
{
}
#nullable disable

#nullable enable
/// <summary>Schema in protocol buffer format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatProtobuf
{
    /// <summary>Protocol buffer source of the schema.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Schema in Thrift format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatThrift
{
    /// <summary>Thrift IDL source of the schema.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Format of the data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormat
{
    /// <summary>Schema in Avro JSON format.</summary>
    [JsonPropertyName("avro")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatAvro? Avro { get; set; }

    /// <summary>Marks a CSV-encoded data source.</summary>
    [JsonPropertyName("csv")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatCsv? Csv { get; set; }

    /// <summary>Marks an ORC-encoded data source.</summary>
    [JsonPropertyName("orc")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatOrc? Orc { get; set; }

    /// <summary>Marks a Parquet-encoded data source.</summary>
    [JsonPropertyName("parquet")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatParquet? Parquet { get; set; }

    /// <summary>Schema in protocol buffer format.</summary>
    [JsonPropertyName("protobuf")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatProtobuf? Protobuf { get; set; }

    /// <summary>Schema in Thrift format.</summary>
    [JsonPropertyName("thrift")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormatThrift? Thrift { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Common Dataplex fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpec
{
    /// <summary>Fully qualified resource name of an asset in Dataplex, to which the underlying data source (Cloud Storage bucket or BigQuery dataset) of the entity is attached.</summary>
    [JsonPropertyName("asset")]
    public string? Asset { get; set; }

    /// <summary>Compression format of the data, e.g., zip, gzip etc.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Format of the data.</summary>
    [JsonPropertyName("dataFormat")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpecDataFormat? DataFormat { get; set; }

    /// <summary>Project ID of the underlying Cloud Storage or BigQuery data. Note that this may not be the same project as the correspondingly Dataplex lake / zone / asset.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableExternalTables
{
    /// <summary>Name of the Data Catalog entry representing the external table.</summary>
    [JsonPropertyName("dataCatalogEntry")]
    public string? DataCatalogEntry { get; set; }

    /// <summary>Fully qualified name (FQN) of the external table.</summary>
    [JsonPropertyName("fullyQualifiedName")]
    public string? FullyQualifiedName { get; set; }

    /// <summary>Google Cloud resource name of the external table.</summary>
    [JsonPropertyName("googleCloudResource")]
    public string? GoogleCloudResource { get; set; }

    /// <summary>Service in which the external table is registered.</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Fields specific to a Dataplex table and present only in the Dataplex table entries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTable
{
    /// <summary>Common Dataplex fields.</summary>
    [JsonPropertyName("dataplexSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableDataplexSpec? DataplexSpec { get; set; }

    /// <summary>List of external tables registered by Dataplex in other systems based on  the same underlying data.   External tables allow to query this data in those systems.</summary>
    [JsonPropertyName("externalTables")]
    public IList<V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTableExternalTables>? ExternalTables { get; set; }

    /// <summary>Indicates if the table schema is managed by the user or not.</summary>
    [JsonPropertyName("userManaged")]
    public bool? UserManaged { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a table resource. Valid only for entries with the `TABLE` or `EXPLORE` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpec
{
    /// <summary>Output only. Fields specific to a Dataplex table and present only in the Dataplex table entries.</summary>
    [JsonPropertyName("dataplexTable")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpecDataplexTable? DataplexTable { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FeatureonlineStore spec for Vertex AI Feature Store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateFeatureOnlineStoreSpec
{
    /// <summary>Output only. Type of underelaying storage for the FeatureOnlineStore.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateGcsFilesetSpecSampleGCSFileSpecs
{
    /// <summary>Required. Full file path. Example: `gs://bucket_name/a/b.txt`.</summary>
    [JsonPropertyName("filePath")]
    public string FilePath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specification that applies to a Cloud Storage fileset. Valid only for entries with the `FILESET` type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateGcsFilesetSpec
{
    /// <summary>Output only. Sample files contained in this fileset, not all files contained in this fileset are represented here.</summary>
    [JsonPropertyName("sampleGCSFileSpecs")]
    public IList<V1alpha1DataCatalogEntryStatusObservedStateGcsFilesetSpecSampleGCSFileSpecs>? SampleGCSFileSpecs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. Additional information related to the entry. Private to the current user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStatePersonalDetails
{
    /// <summary>Set if the entry is starred; unset otherwise.</summary>
    [JsonPropertyName("starTime")]
    public string? StarTime { get; set; }

    /// <summary>True if the entry is starred by the user; false otherwise.</summary>
    [JsonPropertyName("starred")]
    public bool? Starred { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Resource usage statistics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedStateUsageSignal
{
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatusObservedState
{
    /// <summary>Output only. Specification for a group of BigQuery tables with  the `[prefix]YYYYMMDD` name pattern.   For more information, see [Introduction to partitioned tables]  (https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding).</summary>
    [JsonPropertyName("bigqueryDateShardedSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateBigqueryDateShardedSpec? BigqueryDateShardedSpec { get; set; }

    /// <summary>Output only. Specification that applies to a BigQuery table. Valid only for entries with the `TABLE` type.</summary>
    [JsonPropertyName("bigqueryTableSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateBigqueryTableSpec? BigqueryTableSpec { get; set; }

    /// <summary>Output only. Physical location of the entry.</summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1DataCatalogEntryStatusObservedStateDataSource? DataSource { get; set; }

    /// <summary>Specification that applies to a table resource. Valid only for entries with the `TABLE` or `EXPLORE` type.</summary>
    [JsonPropertyName("databaseTableSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateDatabaseTableSpec? DatabaseTableSpec { get; set; }

    /// <summary>FeatureonlineStore spec for Vertex AI Feature Store.</summary>
    [JsonPropertyName("featureOnlineStoreSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateFeatureOnlineStoreSpec? FeatureOnlineStoreSpec { get; set; }

    /// <summary>Specification that applies to a Cloud Storage fileset. Valid only for entries with the `FILESET` type.</summary>
    [JsonPropertyName("gcsFilesetSpec")]
    public V1alpha1DataCatalogEntryStatusObservedStateGcsFilesetSpec? GcsFilesetSpec { get; set; }

    /// <summary>Output only. Indicates the entry's source system that Data Catalog integrates with, such as BigQuery, Pub/Sub, or Dataproc Metastore.</summary>
    [JsonPropertyName("integratedSystem")]
    public string? IntegratedSystem { get; set; }

    /// <summary>The resource this metadata entry refers to.   For Google Cloud Platform resources, `linked_resource` is the  [Full Resource Name]  (https://cloud.google.com/apis/design/resource_names#full_resource_name).   Output only when the entry is one of the types in the `EntryType` enum.   For entries with a `user_specified_type`, this field is optional and  defaults to an empty string.   The resource string must contain only letters (a-z, A-Z), numbers (0-9),  underscores (_), periods (.), colons (:), slashes (/), dashes (-),  and hashes (#).  The maximum size is 200 bytes when encoded in UTF-8.</summary>
    [JsonPropertyName("linkedResource")]
    public string? LinkedResource { get; set; }

    /// <summary>Output only. Additional information related to the entry. Private to the current user.</summary>
    [JsonPropertyName("personalDetails")]
    public V1alpha1DataCatalogEntryStatusObservedStatePersonalDetails? PersonalDetails { get; set; }

    /// <summary>Resource usage statistics.</summary>
    [JsonPropertyName("usageSignal")]
    public V1alpha1DataCatalogEntryStatusObservedStateUsageSignal? UsageSignal { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogEntryStatus defines the config connector machine state of DataCatalogEntry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogEntryStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataCatalogEntryStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataCatalogEntry resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataCatalogEntryStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogEntry is the Schema for the DataCatalogEntry API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogEntry : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataCatalogEntrySpec>, IStatus<V1alpha1DataCatalogEntryStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogEntry";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogentries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataCatalogEntrySpec defines the desired state of DataCatalogEntry</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataCatalogEntrySpec Spec { get; set; }

    /// <summary>DataCatalogEntryStatus defines the config connector machine state of DataCatalogEntry</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataCatalogEntryStatus? Status { get; set; }
}
#nullable disable
