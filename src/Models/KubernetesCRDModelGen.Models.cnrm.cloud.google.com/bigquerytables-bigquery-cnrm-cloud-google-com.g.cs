using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.cnrm.cloud.google.com;
#nullable enable
/// <summary>BigQueryTable is the Schema for the BigQueryTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BigQueryTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigQueryTableList";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerytables";
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
    public IList<V1beta1BigQueryTable> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DatasetRef defines the resource reference to BigQueryDataset, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecDatasetRef
{
    /// <summary>A reference to an externally managed BigQueryDataset resource. Should be in the format "projects/&lt;projectID&gt;/datasets/&lt;datasetID&gt;".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigQueryDataset resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigQueryDataset resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecEncryptionConfigurationKmsKeyRef
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
/// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1BigQueryTableSpecEncryptionConfigurationKmsKeyRef KmsKeyRef { get; set; }

    /// <summary>DEPRECATED. // The table will be encrypted with the primary version of Cloud KMS encryption key. // The self link or full name of the kms key version used to encrypt this table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional properties to set if sourceFormat is set to AVRO.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationAvroOptions
{
    /// <summary>If sourceFormat is set to "AVRO", indicates whether to interpret logical types as the corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example, INTEGER).</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool UseAvroLogicalTypes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional properties to set if sourceFormat is set to CSV.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationCsvOptions
{
    /// <summary>Indicates if BigQuery should accept rows that are missing trailing optional columns. If true, BigQuery treats missing trailing columns as null values. If false, records with missing trailing columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8, ISO-8859-1, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE.  The default value is UTF-8. BigQuery decodes the data after the raw, binary data has been split using the values of the quote and fieldDelimiter properties.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator character for fields in a CSV file. The separator is interpreted as a single byte. For files encoded in ISO-8859-1, any single character can be used as a separator. For files encoded in UTF-8, characters represented in decimal range 1-127 (U+0001-U+007F) can be used without any modification. UTF-8 characters encoded with multiple bytes (i.e. U+0080 and above) will have only the first byte used for separating fields. The remaining bytes will be treated as a part of the field. BigQuery also supports the escape sequence "\t" (U+0009) to specify a tab separator. The default value is comma (",", U+002C).</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. The default value is a double-quote ("). If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true. To include the specific quote character within a quoted value, precede it with an additional matching quote character. For example, if you want to escape the default character  ' " ', use ' "" '.</summary>
    [JsonPropertyName("quote")]
    public string Quote { get; set; }

    /// <summary>The number of rows at the top of a CSV file that BigQuery will  skip when reading the data. The default value is 0. This property is  useful if you have header rows in the file that should be skipped.  When autodetect is on, the behavior is the following:   * skipLeadingRows unspecified - Autodetect tries to detect headers in the    first row. If they are not detected, the row is read as data. Otherwise    data is read starting from the second row.  * skipLeadingRows is 0 - Instructs autodetect that there are no headers and    data should be read starting from the first row.  * skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect    headers in row N. If headers are not detected, row N is just skipped.    Otherwise row N is used to extract column names for the detected schema.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public long? SkipLeadingRows { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional options if sourceFormat is set to GOOGLE_SHEETS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationGoogleSheetsOptions
{
    /// <summary>Range of a sheet to query from. Only used when non-empty. Typical format: sheet_name!top_left_cell_id:bottom_right_cell_id For example: sheet1!A1:B20</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The number of rows at the top of a sheet that BigQuery will skip when reading the data. The default value is 0. This property is useful if you have header rows that should be skipped. When autodetect is on, the behavior is the following: * skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected, the row is read as data. Otherwise data is read starting from the second row. * skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row. * skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to extract column names for the detected schema.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public long? SkipLeadingRows { get; set; }
}
#nullable disable

#nullable enable
/// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationHivePartitioningOptions
{
    /// <summary>When set, what mode of hive partitioning to use when reading  data.  The following modes are supported:   * AUTO: automatically infer partition key name(s) and type(s).   * STRINGS: automatically infer partition key name(s).  All types are  strings.   * CUSTOM: partition key schema is encoded in the source URI prefix.   Not all storage formats support hive partitioning. Requesting hive  partitioning on an unsupported format will lead to an error.  Currently supported formats are: JSON, CSV, ORC, Avro and Parquet.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If set to true, queries over this table require a partition  filter that can be used for partition elimination to be specified.   Note that this field should only be true when creating a permanent  external table or querying a temporary external table.   Hive-partitioned loads with require_partition_filter explicitly set to  true will fail.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>When hive partition detection is requested, a common prefix for  all source uris must be required.  The prefix must end immediately before  the partition key encoding begins. For example, consider files following  this data layout:   gs://bucket/path_to_table/dt=2019-06-01/country=USA/id=7/file.avro   gs://bucket/path_to_table/dt=2019-05-31/country=CA/id=3/file.avro   When hive partitioning is requested with either AUTO or STRINGS detection,  the common prefix can be either of gs://bucket/path_to_table or  gs://bucket/path_to_table/.   CUSTOM detection requires encoding the partitioning schema immediately  after the common prefix.  For CUSTOM, any of   * gs://bucket/path_to_table/{dt:DATE}/{country:STRING}/{id:INTEGER}   * gs://bucket/path_to_table/{dt:STRING}/{country:STRING}/{id:INTEGER}   * gs://bucket/path_to_table/{dt:DATE}/{country:STRING}/{id:STRING}   would all be valid source URI prefixes.</summary>
    [JsonPropertyName("sourceUriPrefix")]
    public string? SourceUriPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional properties to set if sourceFormat is set to JSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationJsonOptions
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE.  The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Additional properties to set if sourceFormat is set to PARQUET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationParquetOptions
{
    /// <summary>Indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>Indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfiguration
{
    /// <summary>Try to detect schema and format options automatically. Any option specified explicitly will be honored.</summary>
    [JsonPropertyName("autodetect")]
    public bool Autodetect { get; set; }

    /// <summary>Additional properties to set if sourceFormat is set to AVRO.</summary>
    [JsonPropertyName("avroOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationAvroOptions? AvroOptions { get; set; }

    /// <summary>The compression type of the data source. Possible values include GZIP and NONE. The default value is NONE. This setting is ignored for Google Cloud Bigtable, Google Cloud Datastore backups, Avro, ORC and Parquet formats. An empty string is an invalid value.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection_id can have the form `{project_id}.{location_id};{connection_id}` or `projects/{project_id}/locations/{location_id}/connections/{connection_id}`.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Additional properties to set if sourceFormat is set to CSV.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationCsvOptions? CsvOptions { get; set; }

    /// <summary>Specifies how source URIs are interpreted for constructing the file set to load.  By default source URIs are expanded against the underlying storage.  Other options include specifying manifest files. Only applicable to object storage systems.</summary>
    [JsonPropertyName("fileSetSpecType")]
    public string? FileSetSpecType { get; set; }

    /// <summary>Additional options if sourceFormat is set to GOOGLE_SHEETS.</summary>
    [JsonPropertyName("googleSheetsOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationGoogleSheetsOptions? GoogleSheetsOptions { get; set; }

    /// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification.</summary>
    [JsonPropertyName("hivePartitioningOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationHivePartitioningOptions? HivePartitioningOptions { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON: Named values that don't match any column names Google Cloud Bigtable: This setting is ignored. Google Cloud Datastore backups: This setting is ignored. Avro: This setting is ignored. ORC: This setting is ignored. Parquet: This setting is ignored.</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>Additional properties to set if sourceFormat is set to JSON.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationJsonOptions? JsonOptions { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when reading data. If the number of bad records exceeds this value, an invalid error is returned in the job result. The default value is 0, which requires that all records are valid. This setting is ignored for Google Cloud Bigtable, Google Cloud Datastore backups, Avro, ORC and Parquet formats.</summary>
    [JsonPropertyName("maxBadRecords")]
    public long? MaxBadRecords { get; set; }

    /// <summary>Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source.</summary>
    [JsonPropertyName("metadataCacheMode")]
    public string? MetadataCacheMode { get; set; }

    /// <summary>ObjectMetadata is used to create Object Tables. Object Tables  contain a listing of objects (with their metadata) found at the  source_uris. If ObjectMetadata is set, source_format should be omitted.   Currently SIMPLE is the only supported Object Metadata type.</summary>
    [JsonPropertyName("objectMetadata")]
    public string? ObjectMetadata { get; set; }

    /// <summary>Additional properties to set if sourceFormat is set to PARQUET.</summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationParquetOptions? ParquetOptions { get; set; }

    /// <summary>When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.</summary>
    [JsonPropertyName("referenceFileSchemaUri")]
    public string? ReferenceFileSchemaUri { get; set; }

    /// <summary>The schema for the data. Schema is required for CSV and JSON formats if autodetect is not on. Schema is disallowed for Google Cloud Bigtable, Cloud Datastore backups, Avro, ORC and Parquet formats.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Please see sourceFormat under ExternalDataConfiguration in Bigquery's public API documentation (https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#externaldataconfiguration) for supported formats. To use "GOOGLE_SHEETS" the scopes must include "googleapis.com/auth/drive.readonly".</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>A list of the fully-qualified URIs that point to	your data in Google Cloud.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string> SourceUris { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The materialized view definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecMaterializedView
{
    /// <summary>This option declares the intention to construct a materialized view that isn't refreshed incrementally.</summary>
    [JsonPropertyName("allowNonIncrementalDefinition")]
    public bool? AllowNonIncrementalDefinition { get; set; }

    /// <summary>Enable automatic refresh of the materialized view when the base table is updated. The default value is "true".</summary>
    [JsonPropertyName("enableRefresh")]
    public bool? EnableRefresh { get; set; }

    /// <summary>Required. A query whose results are persisted.</summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary>The maximum frequency at which this materialized view will be refreshed. The default value is "1800000" (30 minutes).</summary>
    [JsonPropertyName("refreshIntervalMs")]
    public long? RefreshIntervalMs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the ranges for range partitioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecRangePartitioningRange
{
    /// <summary>Required. The end of range partitioning, exclusive.</summary>
    [JsonPropertyName("end")]
    public long End { get; set; }

    /// <summary>Required. The width of each interval.</summary>
    [JsonPropertyName("interval")]
    public long Interval { get; set; }

    /// <summary>Immutable. The start of range partitioning, inclusive.</summary>
    [JsonPropertyName("start")]
    public long Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>If specified, configures range partitioning for this table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecRangePartitioning
{
    /// <summary>Required. The name of the column to partition the table on. It must be a top-level, INT64 column whose mode is NULLABLE or REQUIRED.</summary>
    [JsonPropertyName("field")]
    public string Field { get; set; }

    /// <summary>Defines the ranges for range partitioning.</summary>
    [JsonPropertyName("range")]
    public V1beta1BigQueryTableSpecRangePartitioningRange Range { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The columns that compose the foreign key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsForeignKeysColumnReferences
{
    /// <summary>Required. The column in the primary key that are referenced by the referencing_column.</summary>
    [JsonPropertyName("referencedColumn")]
    public string ReferencedColumn { get; set; }

    /// <summary>Required. The column that composes the foreign key.</summary>
    [JsonPropertyName("referencingColumn")]
    public string ReferencingColumn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The table that holds the primary key and is referenced by this foreign key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsForeignKeysReferencedTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string ProjectId { get; set; }

    /// <summary>The Id of the table. The Id can contain Unicode characters in category L (letter), M (mark), N (number), Pc (connector, including underscore), Pd (dash), and Zs (space). For more information, see [General Category](https://wikipedia.org/wiki/Unicode_character_property#General_Category). The maximum length is 1,024 characters.  Certain operations allow suffixing of the table Id with a partition decorator, such as `sample_table$20190123`.</summary>
    [JsonPropertyName("tableId")]
    public string TableId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsForeignKeys
{
    /// <summary>Required. The columns that compose the foreign key.</summary>
    [JsonPropertyName("columnReferences")]
    public V1beta1BigQueryTableSpecTableConstraintsForeignKeysColumnReferences ColumnReferences { get; set; }

    /// <summary>Optional. Set only if the foreign key constraint is named.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The table that holds the primary key and is referenced by this foreign key.</summary>
    [JsonPropertyName("referencedTable")]
    public V1beta1BigQueryTableSpecTableConstraintsForeignKeysReferencedTable ReferencedTable { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Represents a primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsPrimaryKey
{
    /// <summary>Required. The columns that are composed of the primary key constraint.</summary>
    [JsonPropertyName("columns")]
    public IList<string> Columns { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Tables Primary Key and Foreign Key information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraints
{
    /// <summary>Present only if the table has a foreign key. The foreign key is not enforced.</summary>
    [JsonPropertyName("foreignKeys")]
    public IList<V1beta1BigQueryTableSpecTableConstraintsForeignKeys>? ForeignKeys { get; set; }

    /// <summary>Represents a primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced.</summary>
    [JsonPropertyName("primaryKey")]
    public V1beta1BigQueryTableSpecTableConstraintsPrimaryKey? PrimaryKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>If specified, configures time-based partitioning for this table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public long? ExpirationMs { get; set; }

    /// <summary>Optional. Immutable. If not set, the table is partitioned by pseudo column '_PARTITIONTIME'; if set, the table is partitioned by this field. The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED. A wrapper is used here because an empty string is an invalid value.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>DEPRECATED. This field is deprecated; please use the top level field with the same name instead. If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>Required. The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The view definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecView
{
    /// <summary>Required. A query that BigQuery executes when the view is referenced.</summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL for this view.  The default value is true. If set to false, the view will use  BigQuery's GoogleSQL:  https://cloud.google.com/bigquery/sql-reference/   Queries and views that reference this view must use the same flag value.  A wrapper is used here because the default value is True.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigQueryTableSpec defines the desired state of BigQueryTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpec
{
    /// <summary>Clustering specification for the table. Must be specified with time-based partitioning, data in the table will be first partitioned and subsequently clustered.</summary>
    [JsonPropertyName("clustering")]
    public IList<string>? Clustering { get; set; }

    /// <summary>DatasetRef defines the resource reference to BigQueryDataset, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1BigQueryTableSpecDatasetRef DatasetRef { get; set; }

    /// <summary>A user-friendly description of this table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Custom encryption configuration (e.g., Cloud KMS keys).</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1BigQueryTableSpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.  The defaultTableExpirationMs property of the encapsulating dataset can be used to set a default expirationTime on newly created tables.</summary>
    [JsonPropertyName("expirationTime")]
    public long? ExpirationTime { get; set; }

    /// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.</summary>
    [JsonPropertyName("externalDataConfiguration")]
    public V1beta1BigQueryTableSpecExternalDataConfiguration? ExternalDataConfiguration { get; set; }

    /// <summary>A descriptive name for this table.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>When using `alpha.cnrm.cloud.google.com/reconciler:direct` annotion, use labels field to set the labels for this resource on GCP. Otherwise, use .metadata.labels. Please refer to https://github.com/GoogleCloudPlatform/k8s-config-connector/issues/4274 for context. The labels associated with this table. You can use these to organize and group your tables. Label keys and values can be no longer than 63 characters, can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. Label values are optional. Label keys must start with a letter and each label in the list must have a different key.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The materialized view definition.</summary>
    [JsonPropertyName("materializedView")]
    public V1beta1BigQueryTableSpecMaterializedView? MaterializedView { get; set; }

    /// <summary>The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of sql IntervalValue type.</summary>
    [JsonPropertyName("maxStaleness")]
    public string? MaxStaleness { get; set; }

    /// <summary>If specified, configures range partitioning for this table.</summary>
    [JsonPropertyName("rangePartitioning")]
    public V1beta1BigQueryTableSpecRangePartitioning? RangePartitioning { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The BigQueryTable name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Describes the schema of this table.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Tables Primary Key and Foreign Key information</summary>
    [JsonPropertyName("tableConstraints")]
    public V1beta1BigQueryTableSpecTableConstraints? TableConstraints { get; set; }

    /// <summary>If specified, configures time-based partitioning for this table.</summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta1BigQueryTableSpecTimePartitioning? TimePartitioning { get; set; }

    /// <summary>The view definition.</summary>
    [JsonPropertyName("view")]
    public V1beta1BigQueryTableSpecView? View { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableStatusConditions
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
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableStatusObservedState
{
}
#nullable disable

#nullable enable
/// <summary>BigQueryTableStatus defines the config connector machine state of BigQueryTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigQueryTableStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time when this table was created, in milliseconds since the epoch.</summary>
    [JsonPropertyName("creationTime")]
    public long? CreationTime { get; set; }

    /// <summary>Output only. A hash of this resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A unique specifier for the BigQueryTable resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>Output only. The time when this table was last modified, in milliseconds since the epoch.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public long? LastModifiedTime { get; set; }

    /// <summary>Output only. The geographic location where the table resides. This value is inherited from the dataset.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Output only. The size of this table in logical bytes, excluding any data in the streaming buffer.</summary>
    [JsonPropertyName("numBytes")]
    public long? NumBytes { get; set; }

    /// <summary>Output only. The number of logical bytes in the table that are considered "long-term storage".</summary>
    [JsonPropertyName("numLongTermBytes")]
    public long? NumLongTermBytes { get; set; }

    /// <summary>Output only. The number of rows of data in this table, excluding any data in the streaming buffer.</summary>
    [JsonPropertyName("numRows")]
    public long? NumRows { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1BigQueryTableStatusObservedState? ObservedState { get; set; }

    /// <summary>Output only. A URL that can be used to access this resource again.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Output only. Describes the table type. The following values are supported:   * `TABLE`: A normal BigQuery table.  * `VIEW`: A virtual table defined by a SQL query.  * `EXTERNAL`: A table that references data stored in an external storage    system, such as Google Cloud Storage.  * `MATERIALIZED_VIEW`: A precomputed view defined by a SQL query.  * `SNAPSHOT`: An immutable BigQuery table that preserves the contents of a    base table at a particular time. See additional information on    [table    snapshots](https://cloud.google.com/bigquery/docs/table-snapshots-intro).   The default value is `TABLE`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigQueryTable is the Schema for the BigQueryTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigQueryTableSpec>, IStatus<V1beta1BigQueryTableStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigQueryTable";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerytables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryTableSpec defines the desired state of BigQueryTable</summary>
    [JsonPropertyName("spec")]
    public V1beta1BigQueryTableSpec Spec { get; set; }

    /// <summary>BigQueryTableStatus defines the config connector machine state of BigQueryTable</summary>
    [JsonPropertyName("status")]
    public V1beta1BigQueryTableStatus? Status { get; set; }
}
#nullable disable
