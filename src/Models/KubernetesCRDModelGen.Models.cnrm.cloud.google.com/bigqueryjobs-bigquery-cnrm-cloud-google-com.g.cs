using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.cnrm.cloud.google.com;
/// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecCopyDestinationEncryptionConfigurationKmsKeyRef
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

/// <summary>Immutable. Custom encryption configuration (e.g., Cloud KMS keys).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecCopyDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1BigQueryJobSpecCopyDestinationEncryptionConfigurationKmsKeyRef KmsKeyRef { get; set; }

    /// <summary>Describes the Cloud KMS encryption key version used to protect destination BigQuery table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>A reference to the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecCopyDestinationTableTableRef
{
    /// <summary>Allowed value: The `selfLink` field of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The destination table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecCopyDestinationTable
{
    /// <summary>A reference to the table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1BigQueryJobSpecCopyDestinationTableTableRef TableRef { get; set; }
}

/// <summary>A reference to the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecCopySourceTablesTableRef
{
    /// <summary>Allowed value: The `selfLink` field of a `BigQueryTable` resource.</summary>
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
public partial class V1beta1BigQueryJobSpecCopySourceTables
{
    /// <summary>A reference to the table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1BigQueryJobSpecCopySourceTablesTableRef TableRef { get; set; }
}

/// <summary>Immutable. Copies a table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecCopy
{
    /// <summary>Immutable. Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value: "CREATE_NEVER" Possible values: ["CREATE_IF_NEEDED", "CREATE_NEVER"].</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Immutable. Custom encryption configuration (e.g., Cloud KMS keys).</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta1BigQueryJobSpecCopyDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>Immutable. The destination table.</summary>
    [JsonPropertyName("destinationTable")]
    public V1beta1BigQueryJobSpecCopyDestinationTable? DestinationTable { get; set; }

    /// <summary>Immutable. Source tables to copy.</summary>
    [JsonPropertyName("sourceTables")]
    public IList<V1beta1BigQueryJobSpecCopySourceTables> SourceTables { get; set; }

    /// <summary>Immutable. Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value: "WRITE_EMPTY" Possible values: ["WRITE_TRUNCATE", "WRITE_APPEND", "WRITE_EMPTY"].</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>A reference to the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecExtractSourceTableTableRef
{
    /// <summary>Allowed value: The `selfLink` field of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. A reference to the table being exported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecExtractSourceTable
{
    /// <summary>A reference to the table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1BigQueryJobSpecExtractSourceTableTableRef TableRef { get; set; }
}

/// <summary>Immutable. Configures an extract job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecExtract
{
    /// <summary>Immutable. The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE. The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Immutable. The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models. The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV. The default value for models is SAVED_MODEL.</summary>
    [JsonPropertyName("destinationFormat")]
    public string? DestinationFormat { get; set; }

    /// <summary>Immutable. A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.</summary>
    [JsonPropertyName("destinationUris")]
    public IList<string> DestinationUris { get; set; }

    /// <summary>Immutable. When extracting data in CSV format, this defines the delimiter to use between fields in the exported data. Default is ','.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Immutable. Whether to print out a header row in the results. Default is true.</summary>
    [JsonPropertyName("printHeader")]
    public bool? PrintHeader { get; set; }

    /// <summary>Immutable. A reference to the table being exported.</summary>
    [JsonPropertyName("sourceTable")]
    public V1beta1BigQueryJobSpecExtractSourceTable? SourceTable { get; set; }

    /// <summary>Immutable. Whether to use logical types when extracting to AVRO format.</summary>
    [JsonPropertyName("useAvroLogicalTypes")]
    public bool? UseAvroLogicalTypes { get; set; }
}

/// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecLoadDestinationEncryptionConfigurationKmsKeyRef
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

/// <summary>Immutable. Custom encryption configuration (e.g., Cloud KMS keys).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecLoadDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1BigQueryJobSpecLoadDestinationEncryptionConfigurationKmsKeyRef KmsKeyRef { get; set; }

    /// <summary>Describes the Cloud KMS encryption key version used to protect destination BigQuery table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>A reference to the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecLoadDestinationTableTableRef
{
    /// <summary>Allowed value: The `selfLink` field of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The destination table to load the data into.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecLoadDestinationTable
{
    /// <summary>A reference to the table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1BigQueryJobSpecLoadDestinationTableTableRef TableRef { get; set; }
}

/// <summary>Immutable. Parquet Options for load and make external tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecLoadParquetOptions
{
    /// <summary>Immutable. If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.</summary>
    [JsonPropertyName("enableListInference")]
    public bool? EnableListInference { get; set; }

    /// <summary>Immutable. If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.</summary>
    [JsonPropertyName("enumAsString")]
    public bool? EnumAsString { get; set; }
}

/// <summary>Immutable. Time-based partitioning specification for the destination table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecLoadTimePartitioning
{
    /// <summary>Immutable. Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.</summary>
    [JsonPropertyName("expirationMs")]
    public string? ExpirationMs { get; set; }

    /// <summary>Immutable. If not set, the table is partitioned by pseudo column '_PARTITIONTIME'; if set, the table is partitioned by this field. The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED. A wrapper is used here because an empty string is an invalid value.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Immutable. The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error, but in OnePlatform the field will be treated as unset.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Immutable. Configures a load job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecLoad
{
    /// <summary>Immutable. Accept rows that are missing trailing optional columns. The missing values are treated as nulls. If false, records with missing trailing columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.</summary>
    [JsonPropertyName("allowJaggedRows")]
    public bool? AllowJaggedRows { get; set; }

    /// <summary>Immutable. Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.</summary>
    [JsonPropertyName("allowQuotedNewlines")]
    public bool? AllowQuotedNewlines { get; set; }

    /// <summary>Immutable. Indicates if we should automatically infer the options and schema for CSV and JSON sources.</summary>
    [JsonPropertyName("autodetect")]
    public bool? Autodetect { get; set; }

    /// <summary>Immutable. Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value: "CREATE_NEVER" Possible values: ["CREATE_IF_NEEDED", "CREATE_NEVER"].</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Immutable. Custom encryption configuration (e.g., Cloud KMS keys).</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta1BigQueryJobSpecLoadDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>Immutable. The destination table to load the data into.</summary>
    [JsonPropertyName("destinationTable")]
    public V1beta1BigQueryJobSpecLoadDestinationTable DestinationTable { get; set; }

    /// <summary>Immutable. The character encoding of the data. The supported values are UTF-8 or ISO-8859-1. The default value is UTF-8. BigQuery decodes the data after the raw, binary data has been split using the values of the quote and fieldDelimiter properties.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Immutable. The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character. To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. BigQuery also supports the escape sequence "\t" to specify a tab separator. The default value is a comma (',').</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Immutable. Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false. The sourceFormat property determines what BigQuery treats as an extra value: CSV: Trailing columns JSON: Named values that don't match any column names.</summary>
    [JsonPropertyName("ignoreUnknownValues")]
    public bool? IgnoreUnknownValues { get; set; }

    /// <summary>Immutable. If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON. For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited GeoJSON: set to GEOJSON.</summary>
    [JsonPropertyName("jsonExtension")]
    public string? JsonExtension { get; set; }

    /// <summary>Immutable. The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value, an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.</summary>
    [JsonPropertyName("maxBadRecords")]
    public int? MaxBadRecords { get; set; }

    /// <summary>Immutable. Specifies a string that represents a null value in a CSV file. For example, if you specify "\N", BigQuery interprets "\N" as a null value when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as an empty value.</summary>
    [JsonPropertyName("nullMarker")]
    public string? NullMarker { get; set; }

    /// <summary>Immutable. Parquet Options for load and make external tables.</summary>
    [JsonPropertyName("parquetOptions")]
    public V1beta1BigQueryJobSpecLoadParquetOptions? ParquetOptions { get; set; }

    /// <summary>Immutable. If sourceFormat is set to "DATASTORE_BACKUP", indicates which entity properties to load into BigQuery from a Cloud Datastore backup. Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties. If any named property isn't found in the Cloud Datastore backup, an invalid error is returned in the job result.</summary>
    [JsonPropertyName("projectionFields")]
    public IList<string>? ProjectionFields { get; set; }

    /// <summary>Immutable. The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the data in its raw, binary state. The default value is a double-quote ('"'). If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.</summary>
    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    /// <summary>Immutable. Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>Immutable. The number of rows at the top of a CSV file that BigQuery will skip when loading the data. The default value is 0. This property is useful if you have header rows in the file that should be skipped. When autodetect is on, the behavior is the following: skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected, the row is read as data. Otherwise data is read starting from the second row. skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row. skipLeadingRows = N &gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected, row N is just skipped. Otherwise row N is used to extract column names for the detected schema.</summary>
    [JsonPropertyName("skipLeadingRows")]
    public int? SkipLeadingRows { get; set; }

    /// <summary>Immutable. The format of the data files. For CSV files, specify "CSV". For datastore backups, specify "DATASTORE_BACKUP". For newline-delimited JSON, specify "NEWLINE_DELIMITED_JSON". For Avro, specify "AVRO". For parquet, specify "PARQUET". For orc, specify "ORC". [Beta] For Bigtable, specify "BIGTABLE". The default value is CSV.</summary>
    [JsonPropertyName("sourceFormat")]
    public string? SourceFormat { get; set; }

    /// <summary>Immutable. The fully-qualified URIs that point to your data in Google Cloud. For Google Cloud Storage URIs: Each URI can contain one '\*' wildcard character and it must come after the 'bucket' name. Size limits related to load jobs apply to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table. For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the '\*' wildcard character is not allowed.</summary>
    [JsonPropertyName("sourceUris")]
    public IList<string> SourceUris { get; set; }

    /// <summary>Immutable. Time-based partitioning specification for the destination table.</summary>
    [JsonPropertyName("timePartitioning")]
    public V1beta1BigQueryJobSpecLoadTimePartitioning? TimePartitioning { get; set; }

    /// <summary>Immutable. Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value: "WRITE_EMPTY" Possible values: ["WRITE_TRUNCATE", "WRITE_APPEND", "WRITE_EMPTY"].</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary>A reference to the dataset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryDefaultDatasetDatasetRef
{
    /// <summary>Allowed value: The `selfLink` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryDefaultDataset
{
    /// <summary>A reference to the dataset.</summary>
    [JsonPropertyName("datasetRef")]
    public V1beta1BigQueryJobSpecQueryDefaultDatasetDatasetRef DatasetRef { get; set; }
}

/// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryDestinationEncryptionConfigurationKmsKeyRef
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

/// <summary>Immutable. Custom encryption configuration (e.g., Cloud KMS keys).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryDestinationEncryptionConfiguration
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1BigQueryJobSpecQueryDestinationEncryptionConfigurationKmsKeyRef KmsKeyRef { get; set; }

    /// <summary>Describes the Cloud KMS encryption key version used to protect destination BigQuery table.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }
}

/// <summary>A reference to the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryDestinationTableTableRef
{
    /// <summary>Allowed value: The `selfLink` field of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Describes the table where the query results should be stored. This property must be set for large results that exceed the maximum response size. For queries that produce anonymous (cached) results, this field will be populated by BigQuery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryDestinationTable
{
    /// <summary>A reference to the table.</summary>
    [JsonPropertyName("tableRef")]
    public V1beta1BigQueryJobSpecQueryDestinationTableTableRef TableRef { get; set; }
}

/// <summary>Immutable. Options controlling the execution of scripts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryScriptOptions
{
    /// <summary>Immutable. Determines which statement in the script represents the "key result", used to populate the schema and query results of the script job. Possible values: ["LAST", "FIRST_SELECT"].</summary>
    [JsonPropertyName("keyResultStatement")]
    public string? KeyResultStatement { get; set; }

    /// <summary>Immutable. Limit on the number of bytes billed per statement. Exceeding this budget results in an error.</summary>
    [JsonPropertyName("statementByteBudget")]
    public string? StatementByteBudget { get; set; }

    /// <summary>Immutable. Timeout period for each statement in a script.</summary>
    [JsonPropertyName("statementTimeoutMs")]
    public string? StatementTimeoutMs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQueryUserDefinedFunctionResources
{
    /// <summary>Immutable. An inline resource that contains code for a user-defined function (UDF). Providing a inline code resource is equivalent to providing a URI for a file containing the same code.</summary>
    [JsonPropertyName("inlineCode")]
    public string? InlineCode { get; set; }

    /// <summary>Immutable. A code resource to load from a Google Cloud Storage URI (gs://bucket/path).</summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>Immutable. Configures a query job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpecQuery
{
    /// <summary>Immutable. If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance. Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed. However, you must still set destinationTable when result size exceeds the allowed maximum response size.</summary>
    [JsonPropertyName("allowLargeResults")]
    public bool? AllowLargeResults { get; set; }

    /// <summary>Immutable. Specifies whether the job is allowed to create new tables. The following values are supported: CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table. CREATE_NEVER: The table must already exist. If it does not, a 'notFound' error is returned in the job result. Creation, truncation and append actions occur as one atomic update upon job completion Default value: "CREATE_NEVER" Possible values: ["CREATE_IF_NEEDED", "CREATE_NEVER"].</summary>
    [JsonPropertyName("createDisposition")]
    public string? CreateDisposition { get; set; }

    /// <summary>Immutable. Specifies the default dataset to use for unqualified table names in the query. Note that this does not alter behavior of unqualified dataset names.</summary>
    [JsonPropertyName("defaultDataset")]
    public V1beta1BigQueryJobSpecQueryDefaultDataset? DefaultDataset { get; set; }

    /// <summary>Immutable. Custom encryption configuration (e.g., Cloud KMS keys).</summary>
    [JsonPropertyName("destinationEncryptionConfiguration")]
    public V1beta1BigQueryJobSpecQueryDestinationEncryptionConfiguration? DestinationEncryptionConfiguration { get; set; }

    /// <summary>Immutable. Describes the table where the query results should be stored. This property must be set for large results that exceed the maximum response size. For queries that produce anonymous (cached) results, this field will be populated by BigQuery.</summary>
    [JsonPropertyName("destinationTable")]
    public V1beta1BigQueryJobSpecQueryDestinationTable? DestinationTable { get; set; }

    /// <summary>Immutable. If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results. allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.</summary>
    [JsonPropertyName("flattenResults")]
    public bool? FlattenResults { get; set; }

    /// <summary>Immutable. Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBillingTier")]
    public int? MaximumBillingTier { get; set; }

    /// <summary>Immutable. Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge). If unspecified, this will be set to your project default.</summary>
    [JsonPropertyName("maximumBytesBilled")]
    public string? MaximumBytesBilled { get; set; }

    /// <summary>Immutable. Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.</summary>
    [JsonPropertyName("parameterMode")]
    public string? ParameterMode { get; set; }

    /// <summary>Immutable. Specifies a priority for the query. Default value: "INTERACTIVE" Possible values: ["INTERACTIVE", "BATCH"].</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Immutable. SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL. *NOTE*: queries containing [DML language](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language) ('DELETE', 'UPDATE', 'MERGE', 'INSERT') must specify 'create_disposition = ""' and 'write_disposition = ""'.</summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary>Immutable. Allows the schema of the destination table to be updated as a side effect of the query job. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND; when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified: ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema. ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.</summary>
    [JsonPropertyName("schemaUpdateOptions")]
    public IList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>Immutable. Options controlling the execution of scripts.</summary>
    [JsonPropertyName("scriptOptions")]
    public V1beta1BigQueryJobSpecQueryScriptOptions? ScriptOptions { get; set; }

    /// <summary>Immutable. Specifies whether to use BigQuery's legacy SQL dialect for this query. The default value is true. If set to false, the query will use BigQuery's standard SQL.</summary>
    [JsonPropertyName("useLegacySql")]
    public bool? UseLegacySql { get; set; }

    /// <summary>Immutable. Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified. The default value is true.</summary>
    [JsonPropertyName("useQueryCache")]
    public bool? UseQueryCache { get; set; }

    /// <summary>Immutable. Describes user-defined function resources used in the query.</summary>
    [JsonPropertyName("userDefinedFunctionResources")]
    public IList<V1beta1BigQueryJobSpecQueryUserDefinedFunctionResources>? UserDefinedFunctionResources { get; set; }

    /// <summary>Immutable. Specifies the action that occurs if the destination table already exists. The following values are supported: WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result. WRITE_APPEND: If the table already exists, BigQuery appends the data to the table. WRITE_EMPTY: If the table already exists and contains data, a 'duplicate' error is returned in the job result. Each action is atomic and only occurs if BigQuery is able to complete the job successfully. Creation, truncation and append actions occur as one atomic update upon job completion. Default value: "WRITE_EMPTY" Possible values: ["WRITE_TRUNCATE", "WRITE_APPEND", "WRITE_EMPTY"].</summary>
    [JsonPropertyName("writeDisposition")]
    public string? WriteDisposition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobSpec
{
    /// <summary>Immutable. Copies a table.</summary>
    [JsonPropertyName("copy")]
    public V1beta1BigQueryJobSpecCopy? Copy { get; set; }

    /// <summary>Immutable. Configures an extract job.</summary>
    [JsonPropertyName("extract")]
    public V1beta1BigQueryJobSpecExtract? Extract { get; set; }

    /// <summary>Immutable. Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.</summary>
    [JsonPropertyName("jobTimeoutMs")]
    public string? JobTimeoutMs { get; set; }

    /// <summary>Immutable. Configures a load job.</summary>
    [JsonPropertyName("load")]
    public V1beta1BigQueryJobSpecLoad? Load { get; set; }

    /// <summary>Immutable. The geographic location of the job. The default value is US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. Configures a query job.</summary>
    [JsonPropertyName("query")]
    public V1beta1BigQueryJobSpecQuery? Query { get; set; }

    /// <summary>Immutable. Optional. The jobId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobStatusConditions
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
public partial class V1beta1BigQueryJobStatusStatusErrorResult
{
    /// <summary>Specifies where the error occurred, if present.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A human-readable description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A short error code that summarizes the error.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobStatusStatusErrors
{
    /// <summary>Specifies where the error occurred, if present.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A human-readable description of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A short error code that summarizes the error.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobStatusStatus
{
    /// <summary>Final error result of the job. If present, indicates that the job has completed and was unsuccessful.</summary>
    [JsonPropertyName("errorResult")]
    public IList<V1beta1BigQueryJobStatusStatusErrorResult>? ErrorResult { get; set; }

    /// <summary>The first errors encountered during the running of the job. The final message includes the number of errors that caused the process to stop. Errors here do not necessarily mean that the job has not completed or was unsuccessful.</summary>
    [JsonPropertyName("errors")]
    public IList<V1beta1BigQueryJobStatusStatusErrors>? Errors { get; set; }

    /// <summary>Running state of the job. Valid states include 'PENDING', 'RUNNING', and 'DONE'.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryJobStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigQueryJobStatusConditions>? Conditions { get; set; }

    /// <summary>The type of the job.</summary>
    [JsonPropertyName("jobType")]
    public string? JobType { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The status of this job. Examine this value when polling an asynchronous job to see if the job is complete.</summary>
    [JsonPropertyName("status")]
    public IList<V1beta1BigQueryJobStatusStatus>? Status { get; set; }

    /// <summary>Email address of the user who ran the job.</summary>
    [JsonPropertyName("userEmail")]
    public string? UserEmail { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigQueryJobSpec>, IStatus<V1beta1BigQueryJobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigQueryJob";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryjobs";
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
    public V1beta1BigQueryJobSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1BigQueryJobStatus? Status { get; set; }
}