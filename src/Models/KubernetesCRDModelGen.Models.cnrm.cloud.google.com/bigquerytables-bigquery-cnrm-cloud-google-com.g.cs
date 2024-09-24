using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecDatasetRef
{
    /// <summary>Allowed value: The `name` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecEncryptionConfigurationKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecEncryptionConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1BigQueryTableSpecEncryptionConfigurationKmsKeyRef KmsKeyRef { get; set; }

    /// <summary>The self link or full name of the kms key version used to encrypt this table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>Additional options if source_format is set to "AVRO".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationAvroOptions
{
    /// <summary>If sourceFormat is set to "AVRO", indicates whether to interpret logical types as the corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example, INTEGER).</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool UseAvroLogicalTypes { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "CSV".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationCsvOptions
{
    /// <summary>Indicates if BigQuery should accept rows that are missing trailing optional columns.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator for fields in a CSV file.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("quote")]
    public string Quote { get; set; }

    /// <summary>The number of rows at the top of a CSV file that BigQuery will skip when reading the data.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public int? SkipLeadingRows { get; set; }
}

/// <summary>Additional options if source_format is set to "GOOGLE_SHEETS".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationGoogleSheetsOptions
{
    /// <summary>Range of a sheet to query from. Only used when non-empty. At least one of range or skip_leading_rows must be set. Typical format: "sheet_name!top_left_cell_id:bottom_right_cell_id" For example: "sheet1!A1:B20".</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public int? SkipLeadingRows { get; set; }
}

/// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationHivePartitioningOptions
{
    /// <summary>When set, what mode of hive partitioning to use when reading data.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>When hive partition detection is requested, a common for all source uris must be required. The prefix must end immediately before the partition key encoding begins.</summary>
    [JsonPropertyName("sourceUriPrefix")]
    public string? SourceUriPrefix { get; set; }
}

/// <summary>Additional properties to set if sourceFormat is set to JSON.".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfigurationJsonOptions
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Additional properties to set if sourceFormat is set to PARQUET.".</summary>
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

/// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecExternalDataConfiguration
{
    /// <summary>Let BigQuery try to autodetect the schema and format of the table.</summary>
    [JsonPropertyName("autodetect")]
    public bool Autodetect { get; set; }

    /// <summary>Additional options if source_format is set to "AVRO".</summary>
    [JsonPropertyName("avroOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationAvroOptions? AvroOptions { get; set; }

    /// <summary>The compression type of the data source. Valid values are "NONE" or "GZIP".</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connectionId can have the form "{{project}}.{{location}}.{{connection_id}}" or "projects/{{project}}/locations/{{location}}/connections/{{connection_id}}".</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Additional properties to set if source_format is set to "CSV".</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationCsvOptions? CsvOptions { get; set; }

    /// <summary>Specifies how source URIs are interpreted for constructing the file set to load.  By default source URIs are expanded against the underlying storage.  Other options include specifying manifest files. Only applicable to object storage systems.</summary>
    [JsonPropertyName("fileSetSpecType")]
    public string? FileSetSpecType { get; set; }

    /// <summary>Additional options if source_format is set to "GOOGLE_SHEETS".</summary>
    [JsonPropertyName("googleSheetsOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationGoogleSheetsOptions? GoogleSheetsOptions { get; set; }

    /// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification.</summary>
    [JsonPropertyName("hivePartitioningOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationHivePartitioningOptions? HivePartitioningOptions { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>Additional properties to set if sourceFormat is set to JSON.".</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationJsonOptions? JsonOptions { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when reading data.</summary>
    [JsonPropertyName("maxBadRecords")]
    public int? MaxBadRecords { get; set; }

    /// <summary>Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source.</summary>
    [JsonPropertyName("metadataCacheMode")]
    public string? MetadataCacheMode { get; set; }

    /// <summary>Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If ObjectMetadata is set, sourceFormat should be omitted.</summary>
    [JsonPropertyName("objectMetadata")]
    public string? ObjectMetadata { get; set; }

    /// <summary>Additional properties to set if sourceFormat is set to PARQUET.".</summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta1BigQueryTableSpecExternalDataConfigurationParquetOptions? ParquetOptions { get; set; }

    /// <summary>When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.</summary>
    [JsonPropertyName("referenceFileSchemaUri")]
    public string? ReferenceFileSchemaUri { get; set; }

    /// <summary>Immutable. A JSON schema for the external table. Schema is required for CSV and JSON formats and is disallowed for Google Cloud Bigtable, Cloud Datastore backups, and Avro formats when using external tables.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary> Please see sourceFormat under ExternalDataConfiguration in Bigquery's public API documentation (https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#externaldataconfiguration) for supported formats. To use "GOOGLE_SHEETS" the scopes must include "googleapis.com/auth/drive.readonly".</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>A list of the fully-qualified URIs that point to your data in Google Cloud.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string> SourceUris { get; set; }
}

/// <summary>If specified, configures this table as a materialized view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecMaterializedView
{
    /// <summary>Immutable. Allow non incremental materialized view definition. The default value is false.</summary>
    [JsonPropertyName("allowNonIncrementalDefinition")]
    public bool? AllowNonIncrementalDefinition { get; set; }

    /// <summary>Specifies if BigQuery should automatically refresh materialized view when the base table is updated. The default is true.</summary>
    [JsonPropertyName("enableRefresh")]
    public bool? EnableRefresh { get; set; }

    /// <summary>Immutable. A query whose result is persisted.</summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary>Specifies maximum frequency at which this materialized view will be refreshed. The default is 1800000.</summary>
    [JsonPropertyName("refreshIntervalMs")]
    public int? RefreshIntervalMs { get; set; }
}

/// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecRangePartitioningRange
{
    /// <summary>End of the range partitioning, exclusive.</summary>
    [JsonPropertyName("end")]
    public int End { get; set; }

    /// <summary>The width of each range within the partition.</summary>
    [JsonPropertyName("interval")]
    public int Interval { get; set; }

    /// <summary>Start of the range partitioning, inclusive.</summary>
    [JsonPropertyName("start")]
    public int Start { get; set; }
}

/// <summary>If specified, configures range-based partitioning for this table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecRangePartitioning
{
    /// <summary>Immutable. The field used to determine how to create a range-based partition.</summary>
    [JsonPropertyName("field")]
    public string Field { get; set; }

    /// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public V1beta1BigQueryTableSpecRangePartitioningRange Range { get; set; }
}

/// <summary>The pair of the foreign key column and primary key column.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsForeignKeysColumnReferences
{
    /// <summary>The column in the primary key that are referenced by the referencingColumn.</summary>
    [JsonPropertyName("referencedColumn")]
    public string ReferencedColumn { get; set; }

    /// <summary>The column that composes the foreign key.</summary>
    [JsonPropertyName("referencingColumn")]
    public string ReferencingColumn { get; set; }
}

/// <summary>The table that holds the primary key and is referenced by this foreign key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsForeignKeysReferencedTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string ProjectId { get; set; }

    /// <summary>The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters. Certain operations allow suffixing of the table ID with a partition decorator, such as sample_table$20190123.</summary>
    [JsonPropertyName("tableId")]
    public string TableId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsForeignKeys
{
    /// <summary>The pair of the foreign key column and primary key column.</summary>
    [JsonPropertyName("columnReferences")]
    public V1beta1BigQueryTableSpecTableConstraintsForeignKeysColumnReferences ColumnReferences { get; set; }

    /// <summary>Set only if the foreign key constraint is named.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The table that holds the primary key and is referenced by this foreign key.</summary>
    [JsonPropertyName("referencedTable")]
    public V1beta1BigQueryTableSpecTableConstraintsForeignKeysReferencedTable ReferencedTable { get; set; }
}

/// <summary>Represents a primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTableConstraintsPrimaryKey
{
    /// <summary>The columns that are composed of the primary key constraint.</summary>
    [JsonPropertyName("columns")]
    public IList<string> Columns { get; set; }
}

/// <summary>Defines the primary key and foreign keys.</summary>
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

/// <summary>If specified, configures time-based partitioning for this table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition.</summary>
    [JsonPropertyName("expirationMs")]
    public int? ExpirationMs { get; set; }

    /// <summary>Immutable. The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>DEPRECATED. This field is deprecated; please use the top level field with the same name instead. If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>If specified, configures this table as a view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpecView
{
    /// <summary>A query that BigQuery executes when the view is referenced.</summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL for this view. The default value is true. If set to false, the view will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableSpec
{
    /// <summary>Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.</summary>
    [JsonPropertyName("clustering")]
    public IList<string>? Clustering { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1BigQueryTableSpecDatasetRef DatasetRef { get; set; }

    /// <summary>The field description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1BigQueryTableSpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.</summary>
    [JsonPropertyName("expirationTime")]
    public int? ExpirationTime { get; set; }

    /// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.</summary>
    [JsonPropertyName("externalDataConfiguration")]
    public V1beta1BigQueryTableSpecExternalDataConfiguration? ExternalDataConfiguration { get; set; }

    /// <summary>A descriptive name for the table.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>If specified, configures this table as a materialized view.</summary>
    [JsonPropertyName("materializedView")]
    public V1beta1BigQueryTableSpecMaterializedView? MaterializedView { get; set; }

    /// <summary>The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of sql IntervalValue type.</summary>
    [JsonPropertyName("maxStaleness")]
    public string? MaxStaleness { get; set; }

    /// <summary>If specified, configures range-based partitioning for this table.</summary>
    [JsonPropertyName("rangePartitioning")]
    public V1beta1BigQueryTableSpecRangePartitioning? RangePartitioning { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>Immutable. Optional. The tableId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A JSON schema for the table.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Defines the primary key and foreign keys.</summary>
    [JsonPropertyName("tableConstraints")]
    public V1beta1BigQueryTableSpecTableConstraints? TableConstraints { get; set; }

    /// <summary>If specified, configures time-based partitioning for this table.</summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta1BigQueryTableSpecTimePartitioning? TimePartitioning { get; set; }

    /// <summary>If specified, configures this table as a view.</summary>
    [JsonPropertyName("view")]
    public V1beta1BigQueryTableSpecView? View { get; set; }
}

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryTableStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigQueryTableStatusConditions>? Conditions { get; set; }

    /// <summary>The time when this table was created, in milliseconds since the epoch.</summary>
    [JsonPropertyName("creationTime")]
    public int? CreationTime { get; set; }

    /// <summary>A hash of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The time when this table was last modified, in milliseconds since the epoch.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public int? LastModifiedTime { get; set; }

    /// <summary>The geographic location where the table resides. This value is inherited from the dataset.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The geographic location where the table resides. This value is inherited from the dataset.</summary>
    [JsonPropertyName("numBytes")]
    public int? NumBytes { get; set; }

    /// <summary>The number of bytes in the table that are considered "long-term storage".</summary>
    [JsonPropertyName("numLongTermBytes")]
    public int? NumLongTermBytes { get; set; }

    /// <summary>The number of rows of data in this table, excluding any data in the streaming buffer.</summary>
    [JsonPropertyName("numRows")]
    public int? NumRows { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
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

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1BigQueryTableSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1BigQueryTableStatus? Status { get; set; }
}