using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.m.upbound.io;
/// <summary>Specifies the configuration of a BigLake managed table. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderBiglakeConfiguration
{
    /// <summary>The connection specifying the credentials to be used to read and write to external storage, such as Cloud Storage. The connection_id can have the form "&lt;project_id&gt;.&lt;location_id&gt;.&lt;connection_id&gt;" or projects/&lt;project_id&gt;/locations/&lt;location_id&gt;/connections/&lt;connection_id&gt;".</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The file format the table data is stored in.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>The fully qualified location prefix of the external folder where table data is stored. The '*' wildcard character is not allowed. The URI should be in the format "gs://bucket/path_to_table/"</summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }

    /// <summary>The table format the metadata only snapshots are stored in.</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderDatasetIdRefPolicy
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
public partial class V1beta1TableSpecForProviderDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecForProviderDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderDatasetIdSelectorPolicy
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
public partial class V1beta1TableSpecForProviderDatasetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecForProviderDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderEncryptionConfiguration
{
    /// <summary>The self link or full name of a key which should be used to encrypt this table.  Note that the default bigquery service account will need to have encrypt/decrypt permissions on this key - you may want to see the google_bigquery_default_service_account datasource and the google_kms_crypto_key_iam_binding resource.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>Serializer and deserializer information. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalCatalogTableOptionsStorageDescriptorSerdeInfo
{
    /// <summary>Name of the SerDe. The maximum length is 256 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value pairs that define the initialization parameters for the serialization library. Maximum size 10 Kib.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies a fully-qualified class name of the serialization library that is responsible for the translation of data between table representation and the underlying low-level input and output format structures. The maximum length is 256 characters.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary>A storage descriptor containing information about the physical storage of this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalCatalogTableOptionsStorageDescriptor
{
    /// <summary>Specifies the fully qualified class name of the InputFormat (e.g. "org.apache.hadoop.hive.ql.io.orc.OrcInputFormat"). The maximum length is 128 characters.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>The physical location of the table (e.g. 'gs://spark-dataproc-data/pangea-data/case_sensitive/' or 'gs://spark-dataproc-data/pangea-data/*'). The maximum length is 2056 bytes.</summary>
    [JsonPropertyName("locationUri")]
    public string? LocationUri { get; set; }

    /// <summary>Specifies the fully qualified class name of the OutputFormat (e.g. "org.apache.hadoop.hive.ql.io.orc.OrcOutputFormat"). The maximum length is 128 characters.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Serializer and deserializer information. Structure is documented below.</summary>
    [JsonPropertyName("serdeInfo")]
    public V1beta1TableSpecForProviderExternalCatalogTableOptionsStorageDescriptorSerdeInfo? SerdeInfo { get; set; }
}

/// <summary>Options defining open source compatible table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalCatalogTableOptions
{
    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection is needed to read the open source table from BigQuery Engine. The connection_id can have the form &lt;project_id&gt;.&lt;location_id&gt;.&lt;connection_id&gt; or projects/&lt;project_id&gt;/locations/&lt;location_id&gt;/connections/&lt;connection_id&gt;.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A map of key value pairs defining the parameters and properties of the open source table. Corresponds with hive meta store table parameters. Maximum size of 4Mib.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A storage descriptor containing information about the physical storage of this table. Structure is documented below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1beta1TableSpecForProviderExternalCatalogTableOptionsStorageDescriptor? StorageDescriptor { get; set; }
}

/// <summary>Additional options if source_format is set to "AVRO".  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationAvroOptions
{
    /// <summary>If is set to true, indicates whether to interpret logical types as the corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example, INTEGER).</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationBigtableOptionsColumnFamilyColumn
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>If the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as the column field name and is used as field name in queries.</summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>If this is set only the latest version of value are exposed for all columns in this column family. This can be overridden for a specific column by listing that column in 'columns' and specifying a different setting for that column.</summary>
    [JsonPropertyName("onlyReadLatest")]
    public bool? OnlyReadLatest { get; set; }

    /// <summary>Qualifier of the column. Columns in the parent column family that has this exact qualifier are exposed as . field. If the qualifier is valid UTF-8 string, it can be specified in the qualifierString field. Otherwise, a base-64 encoded value must be set to qualifierEncoded. The column field name is the same as the column qualifier. However, if the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as fieldName.</summary>
    [JsonPropertyName("qualifierEncoded")]
    public string? QualifierEncoded { get; set; }

    /// <summary>Qualifier string.</summary>
    [JsonPropertyName("qualifierString")]
    public string? QualifierString { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationBigtableOptionsColumnFamily
{
    /// <summary>A List of columns that should be exposed as individual fields as opposed to a list of (column name, value) pairs. All columns whose qualifier matches a qualifier in this list can be accessed as Other columns can be accessed as a list through column field.  Structure is documented below.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1TableSpecForProviderExternalDataConfigurationBigtableOptionsColumnFamilyColumn>? Column { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Identifier of the column family.</summary>
    [JsonPropertyName("familyId")]
    public string? FamilyId { get; set; }

    /// <summary>If this is set only the latest version of value are exposed for all columns in this column family. This can be overridden for a specific column by listing that column in 'columns' and specifying a different setting for that column.</summary>
    [JsonPropertyName("onlyReadLatest")]
    public bool? OnlyReadLatest { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "BIGTABLE". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationBigtableOptions
{
    /// <summary>A list of column families to expose in the table schema along with their types. This list restricts the column families that can be referenced in queries and specifies their value types. You can use this list to do type conversions - see the 'type' field for more details. If you leave this list empty, all column families are present in the table schema and their values are read as BYTES. During a query only the column families referenced in that query are read from Bigtable.  Structure is documented below.</summary>
    [JsonPropertyName("columnFamily")]
    public IList<V1beta1TableSpecForProviderExternalDataConfigurationBigtableOptionsColumnFamily>? ColumnFamily { get; set; }

    /// <summary>If field is true, then the column families that are not specified in columnFamilies list are not exposed in the table schema. Otherwise, they are read with BYTES type values. The default value is false.</summary>
    [JsonPropertyName("ignoreUnspecifiedColumnFamilies")]
    public bool? IgnoreUnspecifiedColumnFamilies { get; set; }

    /// <summary>If field is true, then each column family will be read as a single JSON column. Otherwise they are read as a repeated cell structure containing timestamp/value tuples. The default value is false.</summary>
    [JsonPropertyName("outputColumnFamiliesAsJson")]
    public bool? OutputColumnFamiliesAsJson { get; set; }

    /// <summary>If field is true, then the rowkey column families will be read and converted to string. Otherwise they are read with BYTES type values and users need to manually cast them with CAST if necessary. The default value is false.</summary>
    [JsonPropertyName("readRowkeyAsString")]
    public bool? ReadRowkeyAsString { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "CSV". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationCsvOptions
{
    /// <summary>Indicates if BigQuery should accept rows that are missing trailing optional columns.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator for fields in a CSV file.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>The value that is used to quote data sections in a CSV file. If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allow_quoted_newlines property to true.</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }
}

/// <summary>Additional options if source_format is set to "GOOGLE_SHEETS". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationGoogleSheetsOptions
{
    /// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }
}

/// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationHivePartitioningOptions
{
    /// <summary>When set, what mode of hive partitioning to use when reading data. The following modes are supported.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified. require_partition_filter is deprecated and will be removed in a future major release. Use the top level field with the same name instead.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>When hive partition detection is requested, a common for all source uris must be required. The prefix must end immediately before the partition key encoding begins. For example, consider files following this data layout. gs://bucket/path_to_table/dt=2019-06-01/country=USA/id=7/file.avro gs://bucket/path_to_table/dt=2019-05-31/country=CA/id=3/file.avro When hive partitioning is requested with either AUTO or STRINGS detection, the common prefix can be either of gs://bucket/path_to_table or gs://bucket/path_to_table/. Note that when mode is set to CUSTOM, you must encode the partition key schema within the source_uri_prefix by setting source_uri_prefix to gs://bucket/path_to_table/{key1:TYPE1}/{key2:TYPE2}/{key3:TYPE3}.</summary>
    [JsonPropertyName("sourceUriPrefix")]
    public string? SourceUriPrefix { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "JSON". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationJsonOptions
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "PARQUET". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfigurationParquetOptions
{
    /// <summary>Indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>Indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

/// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderExternalDataConfiguration
{
    /// <summary>Let BigQuery try to autodetect the schema and format of the table.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>Additional options if source_format is set to "AVRO".  Structure is documented below.</summary>
    [JsonPropertyName("avroOptions")]
    public V1beta1TableSpecForProviderExternalDataConfigurationAvroOptions? AvroOptions { get; set; }

    /// <summary>Additional properties to set if source_format is set to "BIGTABLE". Structure is documented below.</summary>
    [JsonPropertyName("bigtableOptions")]
    public V1beta1TableSpecForProviderExternalDataConfigurationBigtableOptions? BigtableOptions { get; set; }

    /// <summary>The compression type of the data source. Valid values are "NONE" or "GZIP".</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection_id can have the form {{project}}.{{location}}.{{connection_id}} or projects/{{project}}/locations/{{location}}/connections/{{connection_id}}.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Additional properties to set if source_format is set to "CSV". Structure is documented below.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta1TableSpecForProviderExternalDataConfigurationCsvOptions? CsvOptions { get; set; }

    /// <summary>Specifies how source URIs are interpreted for constructing the file set to load. By default source URIs are expanded against the underlying storage. Other options include specifying manifest files. Only applicable to object storage systems. Docs</summary>
    [JsonPropertyName("fileSetSpecType")]
    public string? FileSetSpecType { get; set; }

    /// <summary>Additional options if source_format is set to "GOOGLE_SHEETS". Structure is documented below.</summary>
    [JsonPropertyName("googleSheetsOptions")]
    public V1beta1TableSpecForProviderExternalDataConfigurationGoogleSheetsOptions? GoogleSheetsOptions { get; set; }

    /// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification. Structure is documented below.</summary>
    [JsonPropertyName("hivePartitioningOptions")]
    public V1beta1TableSpecForProviderExternalDataConfigurationHivePartitioningOptions? HivePartitioningOptions { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>Used to indicate that a JSON variant, rather than normal JSON, is being used as the sourceFormat. This should only be used in combination with the JSON source format. Valid values are: GEOJSON.</summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>Additional properties to set if source_format is set to "JSON". Structure is documented below.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta1TableSpecForProviderExternalDataConfigurationJsonOptions? JsonOptions { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when reading data.</summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source. Valid values are AUTOMATIC and MANUAL.</summary>
    [JsonPropertyName("metadataCacheMode")]
    public string? MetadataCacheMode { get; set; }

    /// <summary>Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If object_metadata is set, source_format should be omitted.</summary>
    [JsonPropertyName("objectMetadata")]
    public string? ObjectMetadata { get; set; }

    /// <summary>Additional properties to set if source_format is set to "PARQUET". Structure is documented below.</summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta1TableSpecForProviderExternalDataConfigurationParquetOptions? ParquetOptions { get; set; }

    /// <summary>When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.</summary>
    [JsonPropertyName("referenceFileSchemaUri")]
    public string? ReferenceFileSchemaUri { get; set; }

    /// <summary>A JSON schema for the external table. Schema is required for CSV and JSON formats if autodetect is not on. Schema is disallowed for Google Cloud Bigtable, Cloud Datastore backups, Avro, Iceberg, ORC and Parquet formats. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. Furthermore drift for this field cannot not be detected because BigQuery only uses this schema to compute the effective schema for the table, therefore any changes on the configured value will force the table to be recreated. This schema is effectively only applied when creating a table from an external datasource, after creation the computed schema will be stored in google_bigquery_table.schema</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The data format. Please see sourceFormat under ExternalDataConfiguration in Bigquery's public API documentation for supported formats. To use "GOOGLE_SHEETS" the scopes must include "https://www.googleapis.com/auth/drive.readonly".</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>A list of the fully-qualified URIs that point to your data in Google Cloud.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }
}

/// <summary>If specified, configures this table as a materialized view. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderMaterializedView
{
    /// <summary>Allow non incremental materialized view definition. The default value is false.</summary>
    [JsonPropertyName("allowNonIncrementalDefinition")]
    public bool? AllowNonIncrementalDefinition { get; set; }

    /// <summary>Specifies whether to use BigQuery's automatic refresh for this materialized view when the base table is updated. The default value is true.</summary>
    [JsonPropertyName("enableRefresh")]
    public bool? EnableRefresh { get; set; }

    /// <summary>A query whose result is persisted.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The maximum frequency at which this materialized view will be refreshed. The default value is 1800000</summary>
    [JsonPropertyName("refreshIntervalMs")]
    public double? RefreshIntervalMs { get; set; }
}

/// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderRangePartitioningRange
{
    /// <summary>End of the range partitioning, exclusive.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>The width of each range within the partition.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Start of the range partitioning, inclusive.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>If specified, configures range-based partitioning for this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderRangePartitioning
{
    /// <summary>The field used to determine how to create a range-based partition.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public V1beta1TableSpecForProviderRangePartitioningRange? Range { get; set; }
}

/// <summary>Specifies metadata of the foreign data type definition in field schema. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderSchemaForeignTypeInfo
{
    /// <summary>Specifies the system which defines the foreign data type.</summary>
    [JsonPropertyName("typeSystem")]
    public string? TypeSystem { get; set; }
}

/// <summary>The pair of the foreign key column and primary key column. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTableConstraintsForeignKeysColumnReferences
{
    /// <summary>The column in the primary key that are referenced by the referencingColumn</summary>
    [JsonPropertyName("referencedColumn")]
    public string? ReferencedColumn { get; set; }

    /// <summary>The column that composes the foreign key.</summary>
    [JsonPropertyName("referencingColumn")]
    public string? ReferencingColumn { get; set; }
}

/// <summary>The table that holds the primary key and is referenced by this foreign key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTableConstraintsForeignKeysReferencedTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>A unique ID for the resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTableConstraintsForeignKeys
{
    /// <summary>The pair of the foreign key column and primary key column. Structure is documented below.</summary>
    [JsonPropertyName("columnReferences")]
    public V1beta1TableSpecForProviderTableConstraintsForeignKeysColumnReferences? ColumnReferences { get; set; }

    /// <summary>Name of the SerDe. The maximum length is 256 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The table that holds the primary key and is referenced by this foreign key. Structure is documented below.</summary>
    [JsonPropertyName("referencedTable")]
    public V1beta1TableSpecForProviderTableConstraintsForeignKeysReferencedTable? ReferencedTable { get; set; }
}

/// <summary>Represents the primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTableConstraintsPrimaryKey
{
    /// <summary>The columns that are composed of the primary key constraint.</summary>
    [JsonPropertyName("columns")]
    public IList<string>? Columns { get; set; }
}

/// <summary>Defines the primary key and foreign keys. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTableConstraints
{
    /// <summary>Present only if the table has a foreign key. The foreign key is not enforced. Structure is documented below.</summary>
    [JsonPropertyName("foreignKeys")]
    public IList<V1beta1TableSpecForProviderTableConstraintsForeignKeys>? ForeignKeys { get; set; }

    /// <summary>Represents the primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced. Structure is documented below.</summary>
    [JsonPropertyName("primaryKey")]
    public V1beta1TableSpecForProviderTableConstraintsPrimaryKey? PrimaryKey { get; set; }
}

/// <summary>Replication info of a table created using "AS REPLICA" DDL like: CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTableReplicationInfo
{
    /// <summary>The interval at which the source materialized view is polled for updates. The default is 300000.</summary>
    [JsonPropertyName("replicationIntervalMs")]
    public double? ReplicationIntervalMs { get; set; }

    /// <summary>The ID of the source dataset.</summary>
    [JsonPropertyName("sourceDatasetId")]
    public string? SourceDatasetId { get; set; }

    /// <summary>The ID of the source project.</summary>
    [JsonPropertyName("sourceProjectId")]
    public string? SourceProjectId { get; set; }

    /// <summary>The ID of the source materialized view.</summary>
    [JsonPropertyName("sourceTableId")]
    public string? SourceTableId { get; set; }
}

/// <summary>If specified, configures time-based partitioning for this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition.</summary>
    [JsonPropertyName("expirationMs")]
    public double? ExpirationMs { get; set; }

    /// <summary>The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified. require_partition_filter is deprecated and will be removed in a future major release. Use the top level field with the same name instead.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderView
{
    /// <summary>A query that BigQuery executes when the view is referenced.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL for this view. The default value is true. If set to false, the view will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProvider
{
    /// <summary>Specifies the configuration of a BigLake managed table. Structure is documented below</summary>
    [JsonPropertyName("biglakeConfiguration")]
    public V1beta1TableSpecForProviderBiglakeConfiguration? BiglakeConfiguration { get; set; }

    /// <summary>Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.</summary>
    [JsonPropertyName("clustering")]
    public IList<string>? Clustering { get; set; }

    /// <summary>The dataset ID to create the table in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1TableSpecForProviderDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1TableSpecForProviderDatasetIdSelector? DatasetIdSelector { get; set; }

    /// <summary>When the field is set to false, deleting the table is allowed..</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The field description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.  Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1TableSpecForProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.</summary>
    [JsonPropertyName("expirationTime")]
    public double? ExpirationTime { get; set; }

    /// <summary>Options defining open source compatible table. Structure is documented below.</summary>
    [JsonPropertyName("externalCatalogTableOptions")]
    public V1beta1TableSpecForProviderExternalCatalogTableOptions? ExternalCatalogTableOptions { get; set; }

    /// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table. Structure is documented below.</summary>
    [JsonPropertyName("externalDataConfiguration")]
    public V1beta1TableSpecForProviderExternalDataConfiguration? ExternalDataConfiguration { get; set; }

    /// <summary>A descriptive name for the table.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>A list of fields which should be ignored for each column in schema. NOTE: Right now only dataPolicies field is supported. We might support others in the future.</summary>
    [JsonPropertyName("ignoreSchemaChanges")]
    public IList<string>? IgnoreSchemaChanges { get; set; }

    /// <summary>A mapping of labels to assign to the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>If specified, configures this table as a materialized view. Structure is documented below.</summary>
    [JsonPropertyName("materializedView")]
    public V1beta1TableSpecForProviderMaterializedView? MaterializedView { get; set; }

    /// <summary>The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of SQL IntervalValue type.</summary>
    [JsonPropertyName("maxStaleness")]
    public string? MaxStaleness { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If specified, configures range-based partitioning for this table. Structure is documented below.</summary>
    [JsonPropertyName("rangePartitioning")]
    public V1beta1TableSpecForProviderRangePartitioning? RangePartitioning { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example "123456789012/environment" where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example "Production". See Tag definitions for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }

    /// <summary>A JSON schema for the table.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Specifies metadata of the foreign data type definition in field schema. Structure is documented below.</summary>
    [JsonPropertyName("schemaForeignTypeInfo")]
    public V1beta1TableSpecForProviderSchemaForeignTypeInfo? SchemaForeignTypeInfo { get; set; }

    /// <summary>Defines the primary key and foreign keys. Structure is documented below.</summary>
    [JsonPropertyName("tableConstraints")]
    public V1beta1TableSpecForProviderTableConstraints? TableConstraints { get; set; }

    /// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
    [JsonPropertyName("tableMetadataView")]
    public string? TableMetadataView { get; set; }

    /// <summary>Replication info of a table created using "AS REPLICA" DDL like: CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv. Structure is documented below.</summary>
    [JsonPropertyName("tableReplicationInfo")]
    public V1beta1TableSpecForProviderTableReplicationInfo? TableReplicationInfo { get; set; }

    /// <summary>If specified, configures time-based partitioning for this table. Structure is documented below.</summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta1TableSpecForProviderTimePartitioning? TimePartitioning { get; set; }

    /// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public V1beta1TableSpecForProviderView? View { get; set; }
}

/// <summary>Specifies the configuration of a BigLake managed table. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderBiglakeConfiguration
{
    /// <summary>The connection specifying the credentials to be used to read and write to external storage, such as Cloud Storage. The connection_id can have the form "&lt;project_id&gt;.&lt;location_id&gt;.&lt;connection_id&gt;" or projects/&lt;project_id&gt;/locations/&lt;location_id&gt;/connections/&lt;connection_id&gt;".</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The file format the table data is stored in.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>The fully qualified location prefix of the external folder where table data is stored. The '*' wildcard character is not allowed. The URI should be in the format "gs://bucket/path_to_table/"</summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }

    /// <summary>The table format the metadata only snapshots are stored in.</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderEncryptionConfiguration
{
    /// <summary>The self link or full name of a key which should be used to encrypt this table.  Note that the default bigquery service account will need to have encrypt/decrypt permissions on this key - you may want to see the google_bigquery_default_service_account datasource and the google_kms_crypto_key_iam_binding resource.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>Serializer and deserializer information. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalCatalogTableOptionsStorageDescriptorSerdeInfo
{
    /// <summary>Name of the SerDe. The maximum length is 256 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value pairs that define the initialization parameters for the serialization library. Maximum size 10 Kib.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies a fully-qualified class name of the serialization library that is responsible for the translation of data between table representation and the underlying low-level input and output format structures. The maximum length is 256 characters.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary>A storage descriptor containing information about the physical storage of this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalCatalogTableOptionsStorageDescriptor
{
    /// <summary>Specifies the fully qualified class name of the InputFormat (e.g. "org.apache.hadoop.hive.ql.io.orc.OrcInputFormat"). The maximum length is 128 characters.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>The physical location of the table (e.g. 'gs://spark-dataproc-data/pangea-data/case_sensitive/' or 'gs://spark-dataproc-data/pangea-data/*'). The maximum length is 2056 bytes.</summary>
    [JsonPropertyName("locationUri")]
    public string? LocationUri { get; set; }

    /// <summary>Specifies the fully qualified class name of the OutputFormat (e.g. "org.apache.hadoop.hive.ql.io.orc.OrcOutputFormat"). The maximum length is 128 characters.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Serializer and deserializer information. Structure is documented below.</summary>
    [JsonPropertyName("serdeInfo")]
    public V1beta1TableSpecInitProviderExternalCatalogTableOptionsStorageDescriptorSerdeInfo? SerdeInfo { get; set; }
}

/// <summary>Options defining open source compatible table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalCatalogTableOptions
{
    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection is needed to read the open source table from BigQuery Engine. The connection_id can have the form &lt;project_id&gt;.&lt;location_id&gt;.&lt;connection_id&gt; or projects/&lt;project_id&gt;/locations/&lt;location_id&gt;/connections/&lt;connection_id&gt;.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A map of key value pairs defining the parameters and properties of the open source table. Corresponds with hive meta store table parameters. Maximum size of 4Mib.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A storage descriptor containing information about the physical storage of this table. Structure is documented below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1beta1TableSpecInitProviderExternalCatalogTableOptionsStorageDescriptor? StorageDescriptor { get; set; }
}

/// <summary>Additional options if source_format is set to "AVRO".  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationAvroOptions
{
    /// <summary>If is set to true, indicates whether to interpret logical types as the corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example, INTEGER).</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationBigtableOptionsColumnFamilyColumn
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>If the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as the column field name and is used as field name in queries.</summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>If this is set only the latest version of value are exposed for all columns in this column family. This can be overridden for a specific column by listing that column in 'columns' and specifying a different setting for that column.</summary>
    [JsonPropertyName("onlyReadLatest")]
    public bool? OnlyReadLatest { get; set; }

    /// <summary>Qualifier of the column. Columns in the parent column family that has this exact qualifier are exposed as . field. If the qualifier is valid UTF-8 string, it can be specified in the qualifierString field. Otherwise, a base-64 encoded value must be set to qualifierEncoded. The column field name is the same as the column qualifier. However, if the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as fieldName.</summary>
    [JsonPropertyName("qualifierEncoded")]
    public string? QualifierEncoded { get; set; }

    /// <summary>Qualifier string.</summary>
    [JsonPropertyName("qualifierString")]
    public string? QualifierString { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationBigtableOptionsColumnFamily
{
    /// <summary>A List of columns that should be exposed as individual fields as opposed to a list of (column name, value) pairs. All columns whose qualifier matches a qualifier in this list can be accessed as Other columns can be accessed as a list through column field.  Structure is documented below.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1TableSpecInitProviderExternalDataConfigurationBigtableOptionsColumnFamilyColumn>? Column { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Identifier of the column family.</summary>
    [JsonPropertyName("familyId")]
    public string? FamilyId { get; set; }

    /// <summary>If this is set only the latest version of value are exposed for all columns in this column family. This can be overridden for a specific column by listing that column in 'columns' and specifying a different setting for that column.</summary>
    [JsonPropertyName("onlyReadLatest")]
    public bool? OnlyReadLatest { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "BIGTABLE". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationBigtableOptions
{
    /// <summary>A list of column families to expose in the table schema along with their types. This list restricts the column families that can be referenced in queries and specifies their value types. You can use this list to do type conversions - see the 'type' field for more details. If you leave this list empty, all column families are present in the table schema and their values are read as BYTES. During a query only the column families referenced in that query are read from Bigtable.  Structure is documented below.</summary>
    [JsonPropertyName("columnFamily")]
    public IList<V1beta1TableSpecInitProviderExternalDataConfigurationBigtableOptionsColumnFamily>? ColumnFamily { get; set; }

    /// <summary>If field is true, then the column families that are not specified in columnFamilies list are not exposed in the table schema. Otherwise, they are read with BYTES type values. The default value is false.</summary>
    [JsonPropertyName("ignoreUnspecifiedColumnFamilies")]
    public bool? IgnoreUnspecifiedColumnFamilies { get; set; }

    /// <summary>If field is true, then each column family will be read as a single JSON column. Otherwise they are read as a repeated cell structure containing timestamp/value tuples. The default value is false.</summary>
    [JsonPropertyName("outputColumnFamiliesAsJson")]
    public bool? OutputColumnFamiliesAsJson { get; set; }

    /// <summary>If field is true, then the rowkey column families will be read and converted to string. Otherwise they are read with BYTES type values and users need to manually cast them with CAST if necessary. The default value is false.</summary>
    [JsonPropertyName("readRowkeyAsString")]
    public bool? ReadRowkeyAsString { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "CSV". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationCsvOptions
{
    /// <summary>Indicates if BigQuery should accept rows that are missing trailing optional columns.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator for fields in a CSV file.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>The value that is used to quote data sections in a CSV file. If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allow_quoted_newlines property to true.</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }
}

/// <summary>Additional options if source_format is set to "GOOGLE_SHEETS". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationGoogleSheetsOptions
{
    /// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }
}

/// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationHivePartitioningOptions
{
    /// <summary>When set, what mode of hive partitioning to use when reading data. The following modes are supported.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified. require_partition_filter is deprecated and will be removed in a future major release. Use the top level field with the same name instead.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>When hive partition detection is requested, a common for all source uris must be required. The prefix must end immediately before the partition key encoding begins. For example, consider files following this data layout. gs://bucket/path_to_table/dt=2019-06-01/country=USA/id=7/file.avro gs://bucket/path_to_table/dt=2019-05-31/country=CA/id=3/file.avro When hive partitioning is requested with either AUTO or STRINGS detection, the common prefix can be either of gs://bucket/path_to_table or gs://bucket/path_to_table/. Note that when mode is set to CUSTOM, you must encode the partition key schema within the source_uri_prefix by setting source_uri_prefix to gs://bucket/path_to_table/{key1:TYPE1}/{key2:TYPE2}/{key3:TYPE3}.</summary>
    [JsonPropertyName("sourceUriPrefix")]
    public string? SourceUriPrefix { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "JSON". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationJsonOptions
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "PARQUET". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfigurationParquetOptions
{
    /// <summary>Indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>Indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

/// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderExternalDataConfiguration
{
    /// <summary>Let BigQuery try to autodetect the schema and format of the table.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>Additional options if source_format is set to "AVRO".  Structure is documented below.</summary>
    [JsonPropertyName("avroOptions")]
    public V1beta1TableSpecInitProviderExternalDataConfigurationAvroOptions? AvroOptions { get; set; }

    /// <summary>Additional properties to set if source_format is set to "BIGTABLE". Structure is documented below.</summary>
    [JsonPropertyName("bigtableOptions")]
    public V1beta1TableSpecInitProviderExternalDataConfigurationBigtableOptions? BigtableOptions { get; set; }

    /// <summary>The compression type of the data source. Valid values are "NONE" or "GZIP".</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection_id can have the form {{project}}.{{location}}.{{connection_id}} or projects/{{project}}/locations/{{location}}/connections/{{connection_id}}.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Additional properties to set if source_format is set to "CSV". Structure is documented below.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta1TableSpecInitProviderExternalDataConfigurationCsvOptions? CsvOptions { get; set; }

    /// <summary>Specifies how source URIs are interpreted for constructing the file set to load. By default source URIs are expanded against the underlying storage. Other options include specifying manifest files. Only applicable to object storage systems. Docs</summary>
    [JsonPropertyName("fileSetSpecType")]
    public string? FileSetSpecType { get; set; }

    /// <summary>Additional options if source_format is set to "GOOGLE_SHEETS". Structure is documented below.</summary>
    [JsonPropertyName("googleSheetsOptions")]
    public V1beta1TableSpecInitProviderExternalDataConfigurationGoogleSheetsOptions? GoogleSheetsOptions { get; set; }

    /// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification. Structure is documented below.</summary>
    [JsonPropertyName("hivePartitioningOptions")]
    public V1beta1TableSpecInitProviderExternalDataConfigurationHivePartitioningOptions? HivePartitioningOptions { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>Used to indicate that a JSON variant, rather than normal JSON, is being used as the sourceFormat. This should only be used in combination with the JSON source format. Valid values are: GEOJSON.</summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>Additional properties to set if source_format is set to "JSON". Structure is documented below.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta1TableSpecInitProviderExternalDataConfigurationJsonOptions? JsonOptions { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when reading data.</summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source. Valid values are AUTOMATIC and MANUAL.</summary>
    [JsonPropertyName("metadataCacheMode")]
    public string? MetadataCacheMode { get; set; }

    /// <summary>Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If object_metadata is set, source_format should be omitted.</summary>
    [JsonPropertyName("objectMetadata")]
    public string? ObjectMetadata { get; set; }

    /// <summary>Additional properties to set if source_format is set to "PARQUET". Structure is documented below.</summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta1TableSpecInitProviderExternalDataConfigurationParquetOptions? ParquetOptions { get; set; }

    /// <summary>When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.</summary>
    [JsonPropertyName("referenceFileSchemaUri")]
    public string? ReferenceFileSchemaUri { get; set; }

    /// <summary>A JSON schema for the external table. Schema is required for CSV and JSON formats if autodetect is not on. Schema is disallowed for Google Cloud Bigtable, Cloud Datastore backups, Avro, Iceberg, ORC and Parquet formats. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. Furthermore drift for this field cannot not be detected because BigQuery only uses this schema to compute the effective schema for the table, therefore any changes on the configured value will force the table to be recreated. This schema is effectively only applied when creating a table from an external datasource, after creation the computed schema will be stored in google_bigquery_table.schema</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The data format. Please see sourceFormat under ExternalDataConfiguration in Bigquery's public API documentation for supported formats. To use "GOOGLE_SHEETS" the scopes must include "https://www.googleapis.com/auth/drive.readonly".</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>A list of the fully-qualified URIs that point to your data in Google Cloud.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }
}

/// <summary>If specified, configures this table as a materialized view. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderMaterializedView
{
    /// <summary>Allow non incremental materialized view definition. The default value is false.</summary>
    [JsonPropertyName("allowNonIncrementalDefinition")]
    public bool? AllowNonIncrementalDefinition { get; set; }

    /// <summary>Specifies whether to use BigQuery's automatic refresh for this materialized view when the base table is updated. The default value is true.</summary>
    [JsonPropertyName("enableRefresh")]
    public bool? EnableRefresh { get; set; }

    /// <summary>A query whose result is persisted.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The maximum frequency at which this materialized view will be refreshed. The default value is 1800000</summary>
    [JsonPropertyName("refreshIntervalMs")]
    public double? RefreshIntervalMs { get; set; }
}

/// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderRangePartitioningRange
{
    /// <summary>End of the range partitioning, exclusive.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>The width of each range within the partition.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Start of the range partitioning, inclusive.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>If specified, configures range-based partitioning for this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderRangePartitioning
{
    /// <summary>The field used to determine how to create a range-based partition.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public V1beta1TableSpecInitProviderRangePartitioningRange? Range { get; set; }
}

/// <summary>Specifies metadata of the foreign data type definition in field schema. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderSchemaForeignTypeInfo
{
    /// <summary>Specifies the system which defines the foreign data type.</summary>
    [JsonPropertyName("typeSystem")]
    public string? TypeSystem { get; set; }
}

/// <summary>The pair of the foreign key column and primary key column. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTableConstraintsForeignKeysColumnReferences
{
    /// <summary>The column in the primary key that are referenced by the referencingColumn</summary>
    [JsonPropertyName("referencedColumn")]
    public string? ReferencedColumn { get; set; }

    /// <summary>The column that composes the foreign key.</summary>
    [JsonPropertyName("referencingColumn")]
    public string? ReferencingColumn { get; set; }
}

/// <summary>The table that holds the primary key and is referenced by this foreign key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTableConstraintsForeignKeysReferencedTable
{
    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>A unique ID for the resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTableConstraintsForeignKeys
{
    /// <summary>The pair of the foreign key column and primary key column. Structure is documented below.</summary>
    [JsonPropertyName("columnReferences")]
    public V1beta1TableSpecInitProviderTableConstraintsForeignKeysColumnReferences? ColumnReferences { get; set; }

    /// <summary>Name of the SerDe. The maximum length is 256 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The table that holds the primary key and is referenced by this foreign key. Structure is documented below.</summary>
    [JsonPropertyName("referencedTable")]
    public V1beta1TableSpecInitProviderTableConstraintsForeignKeysReferencedTable? ReferencedTable { get; set; }
}

/// <summary>Represents the primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTableConstraintsPrimaryKey
{
    /// <summary>The columns that are composed of the primary key constraint.</summary>
    [JsonPropertyName("columns")]
    public IList<string>? Columns { get; set; }
}

/// <summary>Defines the primary key and foreign keys. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTableConstraints
{
    /// <summary>Present only if the table has a foreign key. The foreign key is not enforced. Structure is documented below.</summary>
    [JsonPropertyName("foreignKeys")]
    public IList<V1beta1TableSpecInitProviderTableConstraintsForeignKeys>? ForeignKeys { get; set; }

    /// <summary>Represents the primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced. Structure is documented below.</summary>
    [JsonPropertyName("primaryKey")]
    public V1beta1TableSpecInitProviderTableConstraintsPrimaryKey? PrimaryKey { get; set; }
}

/// <summary>Replication info of a table created using "AS REPLICA" DDL like: CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTableReplicationInfo
{
    /// <summary>The interval at which the source materialized view is polled for updates. The default is 300000.</summary>
    [JsonPropertyName("replicationIntervalMs")]
    public double? ReplicationIntervalMs { get; set; }

    /// <summary>The ID of the source dataset.</summary>
    [JsonPropertyName("sourceDatasetId")]
    public string? SourceDatasetId { get; set; }

    /// <summary>The ID of the source project.</summary>
    [JsonPropertyName("sourceProjectId")]
    public string? SourceProjectId { get; set; }

    /// <summary>The ID of the source materialized view.</summary>
    [JsonPropertyName("sourceTableId")]
    public string? SourceTableId { get; set; }
}

/// <summary>If specified, configures time-based partitioning for this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition.</summary>
    [JsonPropertyName("expirationMs")]
    public double? ExpirationMs { get; set; }

    /// <summary>The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified. require_partition_filter is deprecated and will be removed in a future major release. Use the top level field with the same name instead.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderView
{
    /// <summary>A query that BigQuery executes when the view is referenced.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL for this view. The default value is true. If set to false, the view will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProvider
{
    /// <summary>Specifies the configuration of a BigLake managed table. Structure is documented below</summary>
    [JsonPropertyName("biglakeConfiguration")]
    public V1beta1TableSpecInitProviderBiglakeConfiguration? BiglakeConfiguration { get; set; }

    /// <summary>Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.</summary>
    [JsonPropertyName("clustering")]
    public IList<string>? Clustering { get; set; }

    /// <summary>When the field is set to false, deleting the table is allowed..</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The field description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.  Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1TableSpecInitProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.</summary>
    [JsonPropertyName("expirationTime")]
    public double? ExpirationTime { get; set; }

    /// <summary>Options defining open source compatible table. Structure is documented below.</summary>
    [JsonPropertyName("externalCatalogTableOptions")]
    public V1beta1TableSpecInitProviderExternalCatalogTableOptions? ExternalCatalogTableOptions { get; set; }

    /// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table. Structure is documented below.</summary>
    [JsonPropertyName("externalDataConfiguration")]
    public V1beta1TableSpecInitProviderExternalDataConfiguration? ExternalDataConfiguration { get; set; }

    /// <summary>A descriptive name for the table.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>A list of fields which should be ignored for each column in schema. NOTE: Right now only dataPolicies field is supported. We might support others in the future.</summary>
    [JsonPropertyName("ignoreSchemaChanges")]
    public IList<string>? IgnoreSchemaChanges { get; set; }

    /// <summary>A mapping of labels to assign to the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>If specified, configures this table as a materialized view. Structure is documented below.</summary>
    [JsonPropertyName("materializedView")]
    public V1beta1TableSpecInitProviderMaterializedView? MaterializedView { get; set; }

    /// <summary>The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of SQL IntervalValue type.</summary>
    [JsonPropertyName("maxStaleness")]
    public string? MaxStaleness { get; set; }

    /// <summary>If specified, configures range-based partitioning for this table. Structure is documented below.</summary>
    [JsonPropertyName("rangePartitioning")]
    public V1beta1TableSpecInitProviderRangePartitioning? RangePartitioning { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example "123456789012/environment" where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example "Production". See Tag definitions for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }

    /// <summary>A JSON schema for the table.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Specifies metadata of the foreign data type definition in field schema. Structure is documented below.</summary>
    [JsonPropertyName("schemaForeignTypeInfo")]
    public V1beta1TableSpecInitProviderSchemaForeignTypeInfo? SchemaForeignTypeInfo { get; set; }

    /// <summary>Defines the primary key and foreign keys. Structure is documented below.</summary>
    [JsonPropertyName("tableConstraints")]
    public V1beta1TableSpecInitProviderTableConstraints? TableConstraints { get; set; }

    /// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
    [JsonPropertyName("tableMetadataView")]
    public string? TableMetadataView { get; set; }

    /// <summary>Replication info of a table created using "AS REPLICA" DDL like: CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv. Structure is documented below.</summary>
    [JsonPropertyName("tableReplicationInfo")]
    public V1beta1TableSpecInitProviderTableReplicationInfo? TableReplicationInfo { get; set; }

    /// <summary>If specified, configures time-based partitioning for this table. Structure is documented below.</summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta1TableSpecInitProviderTimePartitioning? TimePartitioning { get; set; }

    /// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public V1beta1TableSpecInitProviderView? View { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>TableSpec defines the desired state of Table</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies the configuration of a BigLake managed table. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderBiglakeConfiguration
{
    /// <summary>The connection specifying the credentials to be used to read and write to external storage, such as Cloud Storage. The connection_id can have the form "&lt;project_id&gt;.&lt;location_id&gt;.&lt;connection_id&gt;" or projects/&lt;project_id&gt;/locations/&lt;location_id&gt;/connections/&lt;connection_id&gt;".</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The file format the table data is stored in.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>The fully qualified location prefix of the external folder where table data is stored. The '*' wildcard character is not allowed. The URI should be in the format "gs://bucket/path_to_table/"</summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }

    /// <summary>The table format the metadata only snapshots are stored in.</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderEncryptionConfiguration
{
    /// <summary>The self link or full name of a key which should be used to encrypt this table.  Note that the default bigquery service account will need to have encrypt/decrypt permissions on this key - you may want to see the google_bigquery_default_service_account datasource and the google_kms_crypto_key_iam_binding resource.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The self link or full name of the kms key version used to encrypt this table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>Serializer and deserializer information. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalCatalogTableOptionsStorageDescriptorSerdeInfo
{
    /// <summary>Name of the SerDe. The maximum length is 256 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value pairs that define the initialization parameters for the serialization library. Maximum size 10 Kib.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Specifies a fully-qualified class name of the serialization library that is responsible for the translation of data between table representation and the underlying low-level input and output format structures. The maximum length is 256 characters.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary>A storage descriptor containing information about the physical storage of this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalCatalogTableOptionsStorageDescriptor
{
    /// <summary>Specifies the fully qualified class name of the InputFormat (e.g. "org.apache.hadoop.hive.ql.io.orc.OrcInputFormat"). The maximum length is 128 characters.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>The physical location of the table (e.g. 'gs://spark-dataproc-data/pangea-data/case_sensitive/' or 'gs://spark-dataproc-data/pangea-data/*'). The maximum length is 2056 bytes.</summary>
    [JsonPropertyName("locationUri")]
    public string? LocationUri { get; set; }

    /// <summary>Specifies the fully qualified class name of the OutputFormat (e.g. "org.apache.hadoop.hive.ql.io.orc.OrcOutputFormat"). The maximum length is 128 characters.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Serializer and deserializer information. Structure is documented below.</summary>
    [JsonPropertyName("serdeInfo")]
    public V1beta1TableStatusAtProviderExternalCatalogTableOptionsStorageDescriptorSerdeInfo? SerdeInfo { get; set; }
}

/// <summary>Options defining open source compatible table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalCatalogTableOptions
{
    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection is needed to read the open source table from BigQuery Engine. The connection_id can have the form &lt;project_id&gt;.&lt;location_id&gt;.&lt;connection_id&gt; or projects/&lt;project_id&gt;/locations/&lt;location_id&gt;/connections/&lt;connection_id&gt;.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A map of key value pairs defining the parameters and properties of the open source table. Corresponds with hive meta store table parameters. Maximum size of 4Mib.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A storage descriptor containing information about the physical storage of this table. Structure is documented below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1beta1TableStatusAtProviderExternalCatalogTableOptionsStorageDescriptor? StorageDescriptor { get; set; }
}

/// <summary>Additional options if source_format is set to "AVRO".  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationAvroOptions
{
    /// <summary>If is set to true, indicates whether to interpret logical types as the corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example, INTEGER).</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationBigtableOptionsColumnFamilyColumn
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>If the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as the column field name and is used as field name in queries.</summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>If this is set only the latest version of value are exposed for all columns in this column family. This can be overridden for a specific column by listing that column in 'columns' and specifying a different setting for that column.</summary>
    [JsonPropertyName("onlyReadLatest")]
    public bool? OnlyReadLatest { get; set; }

    /// <summary>Qualifier of the column. Columns in the parent column family that has this exact qualifier are exposed as . field. If the qualifier is valid UTF-8 string, it can be specified in the qualifierString field. Otherwise, a base-64 encoded value must be set to qualifierEncoded. The column field name is the same as the column qualifier. However, if the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as fieldName.</summary>
    [JsonPropertyName("qualifierEncoded")]
    public string? QualifierEncoded { get; set; }

    /// <summary>Qualifier string.</summary>
    [JsonPropertyName("qualifierString")]
    public string? QualifierString { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationBigtableOptionsColumnFamily
{
    /// <summary>A List of columns that should be exposed as individual fields as opposed to a list of (column name, value) pairs. All columns whose qualifier matches a qualifier in this list can be accessed as Other columns can be accessed as a list through column field.  Structure is documented below.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1TableStatusAtProviderExternalDataConfigurationBigtableOptionsColumnFamilyColumn>? Column { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Identifier of the column family.</summary>
    [JsonPropertyName("familyId")]
    public string? FamilyId { get; set; }

    /// <summary>If this is set only the latest version of value are exposed for all columns in this column family. This can be overridden for a specific column by listing that column in 'columns' and specifying a different setting for that column.</summary>
    [JsonPropertyName("onlyReadLatest")]
    public bool? OnlyReadLatest { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "BIGTABLE". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationBigtableOptions
{
    /// <summary>A list of column families to expose in the table schema along with their types. This list restricts the column families that can be referenced in queries and specifies their value types. You can use this list to do type conversions - see the 'type' field for more details. If you leave this list empty, all column families are present in the table schema and their values are read as BYTES. During a query only the column families referenced in that query are read from Bigtable.  Structure is documented below.</summary>
    [JsonPropertyName("columnFamily")]
    public IList<V1beta1TableStatusAtProviderExternalDataConfigurationBigtableOptionsColumnFamily>? ColumnFamily { get; set; }

    /// <summary>If field is true, then the column families that are not specified in columnFamilies list are not exposed in the table schema. Otherwise, they are read with BYTES type values. The default value is false.</summary>
    [JsonPropertyName("ignoreUnspecifiedColumnFamilies")]
    public bool? IgnoreUnspecifiedColumnFamilies { get; set; }

    /// <summary>If field is true, then each column family will be read as a single JSON column. Otherwise they are read as a repeated cell structure containing timestamp/value tuples. The default value is false.</summary>
    [JsonPropertyName("outputColumnFamiliesAsJson")]
    public bool? OutputColumnFamiliesAsJson { get; set; }

    /// <summary>If field is true, then the rowkey column families will be read and converted to string. Otherwise they are read with BYTES type values and users need to manually cast them with CAST if necessary. The default value is false.</summary>
    [JsonPropertyName("readRowkeyAsString")]
    public bool? ReadRowkeyAsString { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "CSV". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationCsvOptions
{
    /// <summary>Indicates if BigQuery should accept rows that are missing trailing optional columns.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The separator for fields in a CSV file.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>The value that is used to quote data sections in a CSV file. If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allow_quoted_newlines property to true.</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }
}

/// <summary>Additional options if source_format is set to "GOOGLE_SHEETS". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationGoogleSheetsOptions
{
    /// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public double? SkipLeadingRows { get; set; }
}

/// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationHivePartitioningOptions
{
    /// <summary>When set, what mode of hive partitioning to use when reading data. The following modes are supported.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified. require_partition_filter is deprecated and will be removed in a future major release. Use the top level field with the same name instead.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>When hive partition detection is requested, a common for all source uris must be required. The prefix must end immediately before the partition key encoding begins. For example, consider files following this data layout. gs://bucket/path_to_table/dt=2019-06-01/country=USA/id=7/file.avro gs://bucket/path_to_table/dt=2019-05-31/country=CA/id=3/file.avro When hive partitioning is requested with either AUTO or STRINGS detection, the common prefix can be either of gs://bucket/path_to_table or gs://bucket/path_to_table/. Note that when mode is set to CUSTOM, you must encode the partition key schema within the source_uri_prefix by setting source_uri_prefix to gs://bucket/path_to_table/{key1:TYPE1}/{key2:TYPE2}/{key3:TYPE3}.</summary>
    [JsonPropertyName("sourceUriPrefix")]
    public string? SourceUriPrefix { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "JSON". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationJsonOptions
{
    /// <summary>The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }
}

/// <summary>Additional properties to set if source_format is set to "PARQUET". Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfigurationParquetOptions
{
    /// <summary>Indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>Indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

/// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderExternalDataConfiguration
{
    /// <summary>Let BigQuery try to autodetect the schema and format of the table.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>Additional options if source_format is set to "AVRO".  Structure is documented below.</summary>
    [JsonPropertyName("avroOptions")]
    public V1beta1TableStatusAtProviderExternalDataConfigurationAvroOptions? AvroOptions { get; set; }

    /// <summary>Additional properties to set if source_format is set to "BIGTABLE". Structure is documented below.</summary>
    [JsonPropertyName("bigtableOptions")]
    public V1beta1TableStatusAtProviderExternalDataConfigurationBigtableOptions? BigtableOptions { get; set; }

    /// <summary>The compression type of the data source. Valid values are "NONE" or "GZIP".</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection_id can have the form {{project}}.{{location}}.{{connection_id}} or projects/{{project}}/locations/{{location}}/connections/{{connection_id}}.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Additional properties to set if source_format is set to "CSV". Structure is documented below.</summary>
    [JsonPropertyName("csvOptions")]
    public V1beta1TableStatusAtProviderExternalDataConfigurationCsvOptions? CsvOptions { get; set; }

    /// <summary>Specifies how source URIs are interpreted for constructing the file set to load. By default source URIs are expanded against the underlying storage. Other options include specifying manifest files. Only applicable to object storage systems. Docs</summary>
    [JsonPropertyName("fileSetSpecType")]
    public string? FileSetSpecType { get; set; }

    /// <summary>Additional options if source_format is set to "GOOGLE_SHEETS". Structure is documented below.</summary>
    [JsonPropertyName("googleSheetsOptions")]
    public V1beta1TableStatusAtProviderExternalDataConfigurationGoogleSheetsOptions? GoogleSheetsOptions { get; set; }

    /// <summary>When set, configures hive partitioning support. Not all storage formats support hive partitioning -- requesting hive partitioning on an unsupported format will lead to an error, as will providing an invalid specification. Structure is documented below.</summary>
    [JsonPropertyName("hivePartitioningOptions")]
    public V1beta1TableStatusAtProviderExternalDataConfigurationHivePartitioningOptions? HivePartitioningOptions { get; set; }

    /// <summary>Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>Used to indicate that a JSON variant, rather than normal JSON, is being used as the sourceFormat. This should only be used in combination with the JSON source format. Valid values are: GEOJSON.</summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>Additional properties to set if source_format is set to "JSON". Structure is documented below.</summary>
    [JsonPropertyName("jsonOptions")]
    public V1beta1TableStatusAtProviderExternalDataConfigurationJsonOptions? JsonOptions { get; set; }

    /// <summary>The maximum number of bad records that BigQuery can ignore when reading data.</summary>
    [JsonPropertyName("maxBadRecords")]
    public double? MaxBadRecords { get; set; }

    /// <summary>Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source. Valid values are AUTOMATIC and MANUAL.</summary>
    [JsonPropertyName("metadataCacheMode")]
    public string? MetadataCacheMode { get; set; }

    /// <summary>Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If object_metadata is set, source_format should be omitted.</summary>
    [JsonPropertyName("objectMetadata")]
    public string? ObjectMetadata { get; set; }

    /// <summary>Additional properties to set if source_format is set to "PARQUET". Structure is documented below.</summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta1TableStatusAtProviderExternalDataConfigurationParquetOptions? ParquetOptions { get; set; }

    /// <summary>When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.</summary>
    [JsonPropertyName("referenceFileSchemaUri")]
    public string? ReferenceFileSchemaUri { get; set; }

    /// <summary>A JSON schema for the external table. Schema is required for CSV and JSON formats if autodetect is not on. Schema is disallowed for Google Cloud Bigtable, Cloud Datastore backups, Avro, Iceberg, ORC and Parquet formats. ~&gt;NOTE: Because this field expects a JSON string, any changes to the string will create a diff, even if the JSON itself hasn't changed. Furthermore drift for this field cannot not be detected because BigQuery only uses this schema to compute the effective schema for the table, therefore any changes on the configured value will force the table to be recreated. This schema is effectively only applied when creating a table from an external datasource, after creation the computed schema will be stored in google_bigquery_table.schema</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The data format. Please see sourceFormat under ExternalDataConfiguration in Bigquery's public API documentation for supported formats. To use "GOOGLE_SHEETS" the scopes must include "https://www.googleapis.com/auth/drive.readonly".</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>A list of the fully-qualified URIs that point to your data in Google Cloud.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string>? SourceUris { get; set; }
}

/// <summary>If specified, configures this table as a materialized view. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderMaterializedView
{
    /// <summary>Allow non incremental materialized view definition. The default value is false.</summary>
    [JsonPropertyName("allowNonIncrementalDefinition")]
    public bool? AllowNonIncrementalDefinition { get; set; }

    /// <summary>Specifies whether to use BigQuery's automatic refresh for this materialized view when the base table is updated. The default value is true.</summary>
    [JsonPropertyName("enableRefresh")]
    public bool? EnableRefresh { get; set; }

    /// <summary>A query whose result is persisted.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The maximum frequency at which this materialized view will be refreshed. The default value is 1800000</summary>
    [JsonPropertyName("refreshIntervalMs")]
    public double? RefreshIntervalMs { get; set; }
}

/// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderRangePartitioningRange
{
    /// <summary>End of the range partitioning, exclusive.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>The width of each range within the partition.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Start of the range partitioning, inclusive.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>If specified, configures range-based partitioning for this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderRangePartitioning
{
    /// <summary>The field used to determine how to create a range-based partition.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Information required to partition based on ranges. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public V1beta1TableStatusAtProviderRangePartitioningRange? Range { get; set; }
}

/// <summary>Specifies metadata of the foreign data type definition in field schema. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderSchemaForeignTypeInfo
{
    /// <summary>Specifies the system which defines the foreign data type.</summary>
    [JsonPropertyName("typeSystem")]
    public string? TypeSystem { get; set; }
}

/// <summary>The pair of the foreign key column and primary key column. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTableConstraintsForeignKeysColumnReferences
{
    /// <summary>The column in the primary key that are referenced by the referencingColumn</summary>
    [JsonPropertyName("referencedColumn")]
    public string? ReferencedColumn { get; set; }

    /// <summary>The column that composes the foreign key.</summary>
    [JsonPropertyName("referencingColumn")]
    public string? ReferencingColumn { get; set; }
}

/// <summary>The table that holds the primary key and is referenced by this foreign key. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTableConstraintsForeignKeysReferencedTable
{
    /// <summary>The ID of the dataset containing this table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The ID of the project containing this table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>A unique ID for the resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTableConstraintsForeignKeys
{
    /// <summary>The pair of the foreign key column and primary key column. Structure is documented below.</summary>
    [JsonPropertyName("columnReferences")]
    public V1beta1TableStatusAtProviderTableConstraintsForeignKeysColumnReferences? ColumnReferences { get; set; }

    /// <summary>Name of the SerDe. The maximum length is 256 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The table that holds the primary key and is referenced by this foreign key. Structure is documented below.</summary>
    [JsonPropertyName("referencedTable")]
    public V1beta1TableStatusAtProviderTableConstraintsForeignKeysReferencedTable? ReferencedTable { get; set; }
}

/// <summary>Represents the primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTableConstraintsPrimaryKey
{
    /// <summary>The columns that are composed of the primary key constraint.</summary>
    [JsonPropertyName("columns")]
    public IList<string>? Columns { get; set; }
}

/// <summary>Defines the primary key and foreign keys. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTableConstraints
{
    /// <summary>Present only if the table has a foreign key. The foreign key is not enforced. Structure is documented below.</summary>
    [JsonPropertyName("foreignKeys")]
    public IList<V1beta1TableStatusAtProviderTableConstraintsForeignKeys>? ForeignKeys { get; set; }

    /// <summary>Represents the primary key constraint on a table's columns. Present only if the table has a primary key. The primary key is not enforced. Structure is documented below.</summary>
    [JsonPropertyName("primaryKey")]
    public V1beta1TableStatusAtProviderTableConstraintsPrimaryKey? PrimaryKey { get; set; }
}

/// <summary>Replication info of a table created using "AS REPLICA" DDL like: CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTableReplicationInfo
{
    /// <summary>The interval at which the source materialized view is polled for updates. The default is 300000.</summary>
    [JsonPropertyName("replicationIntervalMs")]
    public double? ReplicationIntervalMs { get; set; }

    /// <summary>The ID of the source dataset.</summary>
    [JsonPropertyName("sourceDatasetId")]
    public string? SourceDatasetId { get; set; }

    /// <summary>The ID of the source project.</summary>
    [JsonPropertyName("sourceProjectId")]
    public string? SourceProjectId { get; set; }

    /// <summary>The ID of the source materialized view.</summary>
    [JsonPropertyName("sourceTableId")]
    public string? SourceTableId { get; set; }
}

/// <summary>If specified, configures time-based partitioning for this table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTimePartitioning
{
    /// <summary>Number of milliseconds for which to keep the storage for a partition.</summary>
    [JsonPropertyName("expirationMs")]
    public double? ExpirationMs { get; set; }

    /// <summary>The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified. require_partition_filter is deprecated and will be removed in a future major release. Use the top level field with the same name instead.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderView
{
    /// <summary>A query that BigQuery executes when the view is referenced.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Specifies whether to use BigQuery's legacy SQL for this view. The default value is true. If set to false, the view will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProvider
{
    /// <summary>Specifies the configuration of a BigLake managed table. Structure is documented below</summary>
    [JsonPropertyName("biglakeConfiguration")]
    public V1beta1TableStatusAtProviderBiglakeConfiguration? BiglakeConfiguration { get; set; }

    /// <summary>Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.</summary>
    [JsonPropertyName("clustering")]
    public IList<string>? Clustering { get; set; }

    /// <summary>The time when this table was created, in milliseconds since the epoch.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>The dataset ID to create the table in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>When the field is set to false, deleting the table is allowed..</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The field description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.  Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1TableStatusAtProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A hash of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.</summary>
    [JsonPropertyName("expirationTime")]
    public double? ExpirationTime { get; set; }

    /// <summary>Options defining open source compatible table. Structure is documented below.</summary>
    [JsonPropertyName("externalCatalogTableOptions")]
    public V1beta1TableStatusAtProviderExternalCatalogTableOptions? ExternalCatalogTableOptions { get; set; }

    /// <summary>Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table. Structure is documented below.</summary>
    [JsonPropertyName("externalDataConfiguration")]
    public V1beta1TableStatusAtProviderExternalDataConfiguration? ExternalDataConfiguration { get; set; }

    /// <summary>A descriptive name for the table.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>An identifier for the resource with format projects/{{project}}/datasets/{{dataset}}/tables/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of fields which should be ignored for each column in schema. NOTE: Right now only dataPolicies field is supported. We might support others in the future.</summary>
    [JsonPropertyName("ignoreSchemaChanges")]
    public IList<string>? IgnoreSchemaChanges { get; set; }

    /// <summary>A mapping of labels to assign to the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The time when this table was last modified, in milliseconds since the epoch.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public double? LastModifiedTime { get; set; }

    /// <summary>The geographic location where the table resides. This value is inherited from the dataset.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If specified, configures this table as a materialized view. Structure is documented below.</summary>
    [JsonPropertyName("materializedView")]
    public V1beta1TableStatusAtProviderMaterializedView? MaterializedView { get; set; }

    /// <summary>The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of SQL IntervalValue type.</summary>
    [JsonPropertyName("maxStaleness")]
    public string? MaxStaleness { get; set; }

    /// <summary>The size of this table in bytes, excluding any data in the streaming buffer.</summary>
    [JsonPropertyName("numBytes")]
    public double? NumBytes { get; set; }

    /// <summary>The number of bytes in the table that are considered "long-term storage".</summary>
    [JsonPropertyName("numLongTermBytes")]
    public double? NumLongTermBytes { get; set; }

    /// <summary>The number of rows of data in this table, excluding any data in the streaming buffer.</summary>
    [JsonPropertyName("numRows")]
    public double? NumRows { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If specified, configures range-based partitioning for this table. Structure is documented below.</summary>
    [JsonPropertyName("rangePartitioning")]
    public V1beta1TableStatusAtProviderRangePartitioning? RangePartitioning { get; set; }

    /// <summary>If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example "123456789012/environment" where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example "Production". See Tag definitions for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IDictionary<string, string>? ResourceTags { get; set; }

    /// <summary>A JSON schema for the table.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Specifies metadata of the foreign data type definition in field schema. Structure is documented below.</summary>
    [JsonPropertyName("schemaForeignTypeInfo")]
    public V1beta1TableStatusAtProviderSchemaForeignTypeInfo? SchemaForeignTypeInfo { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Defines the primary key and foreign keys. Structure is documented below.</summary>
    [JsonPropertyName("tableConstraints")]
    public V1beta1TableStatusAtProviderTableConstraints? TableConstraints { get; set; }

    /// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
    [JsonPropertyName("tableMetadataView")]
    public string? TableMetadataView { get; set; }

    /// <summary>Replication info of a table created using "AS REPLICA" DDL like: CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv. Structure is documented below.</summary>
    [JsonPropertyName("tableReplicationInfo")]
    public V1beta1TableStatusAtProviderTableReplicationInfo? TableReplicationInfo { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>If specified, configures time-based partitioning for this table. Structure is documented below.</summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta1TableStatusAtProviderTimePartitioning? TimePartitioning { get; set; }

    /// <summary>Describes the table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If specified, configures this table as a view. Structure is documented below.</summary>
    [JsonPropertyName("view")]
    public V1beta1TableStatusAtProviderView? View { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusConditions
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

/// <summary>TableStatus defines the observed state of Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TableStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Table is the Schema for the Tables API. Creates a table resource in a dataset for Google BigQuery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Table : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TableSpec>, IStatus<V1beta1TableStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Table";
    public const string KubeGroup = "bigquery.gcp.m.upbound.io";
    public const string KubePluralName = "tables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TableSpec defines the desired state of Table</summary>
    [JsonPropertyName("spec")]
    public V1beta1TableSpec Spec { get; set; }

    /// <summary>TableStatus defines the observed state of Table.</summary>
    [JsonPropertyName("status")]
    public V1beta1TableStatus? Status { get; set; }
}

/// <summary>Table is the Schema for the Tables API. Creates a table resource in a dataset for Google BigQuery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Table>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TableList";
    public const string KubeGroup = "bigquery.gcp.m.upbound.io";
    public const string KubePluralName = "tables";
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
    public IList<V1beta1Table> Items { get; set; }
}