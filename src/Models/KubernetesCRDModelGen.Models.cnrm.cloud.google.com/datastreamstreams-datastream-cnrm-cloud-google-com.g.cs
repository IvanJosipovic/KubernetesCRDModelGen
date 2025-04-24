using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamMetadata
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The MySQL data type. Full data types list can be found here: https://dev.mysql.com/doc/refman/8.0/en/data-types.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables
{
    /// <summary>MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabases
{
    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string Database { get; set; }

    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("mysqlTables")]
    public IList<DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>MySQL data source objects to avoid backfilling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllMysqlExcludedObjects
{
    /// <summary>MySQL databases on the server.</summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabases> MysqlDatabases { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The Oracle data type. Full data types list can be found here: https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column encoding.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTables
{
    /// <summary>Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("oracleColumns")]
    public IList<DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemas
{
    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("oracleTables")]
    public IList<DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>Schema name.</summary>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }
}

/// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllOracleExcludedObjects
{
    /// <summary>Oracle schemas/databases in the database server.</summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemas> OracleSchemas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The PostgreSQL data type. Full data types list can be found here: https://www.postgresql.org/docs/current/datatype.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas
{
    /// <summary>Tables in the schema.</summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }
}

/// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAllPostgresqlExcludedObjects
{
    /// <summary>PostgreSQL schemas on the server.</summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas> PostgresqlSchemas { get; set; }
}

/// <summary>Backfill strategy to automatically backfill the Stream's objects. Specific objects can be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecBackfillAll
{
    /// <summary>MySQL data source objects to avoid backfilling.</summary>
    [JsonPropertyName("mysqlExcludedObjects")]
    public DatastreamStreamSpecBackfillAllMysqlExcludedObjects? MysqlExcludedObjects { get; set; }

    /// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
    [JsonPropertyName("oracleExcludedObjects")]
    public DatastreamStreamSpecBackfillAllOracleExcludedObjects? OracleExcludedObjects { get; set; }

    /// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
    [JsonPropertyName("postgresqlExcludedObjects")]
    public DatastreamStreamSpecBackfillAllPostgresqlExcludedObjects? PostgresqlExcludedObjects { get; set; }
}

/// <summary>A single target dataset to which all data will be streamed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSingleTargetDataset
{
    /// <summary>Dataset ID in the format projects/{project}/datasets/{dataset_id} or {project}:{dataset_id}.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }
}

/// <summary>Dataset template used for dynamic dataset creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate
{
    /// <summary>If supplied, every created dataset will have its name prefixed by the provided value. The prefix and name will be separated by an underscore. i.e. _.</summary>
    [JsonPropertyName("datasetIdPrefix")]
    public string? DatasetIdPrefix { get; set; }

    /// <summary>Immutable. Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table. The BigQuery Service Account associated with your project requires access to this encryption key. i.e. projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{cryptoKey}. See https://cloud.google.com/bigquery/docs/customer-managed-encryption for more information.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The geographic location where the dataset should reside. See https://cloud.google.com/bigquery/docs/locations for supported locations.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }
}

/// <summary>Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets
{
    /// <summary>Dataset template used for dynamic dataset creation.</summary>
    [JsonPropertyName("datasetTemplate")]
    public DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate DatasetTemplate { get; set; }
}

/// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecDestinationConfigBigqueryDestinationConfig
{
    /// <summary>The guaranteed data freshness (in seconds) when querying tables created by the stream. Editing this field will only affect new tables created in the future, but existing tables will not be impacted. Lower values mean that queries will return fresher data, but may result in higher cost. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Defaults to 900s.</summary>
    [JsonPropertyName("dataFreshness")]
    public string? DataFreshness { get; set; }

    /// <summary>A single target dataset to which all data will be streamed.</summary>
    [JsonPropertyName("singleTargetDataset")]
    public DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSingleTargetDataset? SingleTargetDataset { get; set; }

    /// <summary>Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.</summary>
    [JsonPropertyName("sourceHierarchyDatasets")]
    public DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets? SourceHierarchyDatasets { get; set; }
}

/// <summary>JSON file format configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecDestinationConfigGcsDestinationConfigJsonFileFormat
{
    /// <summary>Compression of the loaded JSON file. Possible values: ["NO_COMPRESSION", "GZIP"].</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The schema file format along JSON data files. Possible values: ["NO_SCHEMA_FILE", "AVRO_SCHEMA_FILE"].</summary>
    [JsonPropertyName("schemaFileFormat")]
    public string? SchemaFileFormat { get; set; }
}

/// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecDestinationConfigGcsDestinationConfig
{
    /// <summary>AVRO file format configuration.</summary>
    [JsonPropertyName("avroFileFormat")]
    public JsonNode? AvroFileFormat { get; set; }

    /// <summary>The maximum duration for which new events are added before a file is closed and a new file is created. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Defaults to 900s.</summary>
    [JsonPropertyName("fileRotationInterval")]
    public string? FileRotationInterval { get; set; }

    /// <summary>The maximum file size to be saved in the bucket.</summary>
    [JsonPropertyName("fileRotationMb")]
    public int? FileRotationMb { get; set; }

    /// <summary>JSON file format configuration.</summary>
    [JsonPropertyName("jsonFileFormat")]
    public DatastreamStreamSpecDestinationConfigGcsDestinationConfigJsonFileFormat? JsonFileFormat { get; set; }

    /// <summary>Path inside the Cloud Storage bucket to write data to.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Destination connection profile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecDestinationConfig
{
    /// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
    [JsonPropertyName("bigqueryDestinationConfig")]
    public DatastreamStreamSpecDestinationConfigBigqueryDestinationConfig? BigqueryDestinationConfig { get; set; }

    /// <summary>Immutable. Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}.</summary>
    [JsonPropertyName("destinationConnectionProfile")]
    public string DestinationConnectionProfile { get; set; }

    /// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
    [JsonPropertyName("gcsDestinationConfig")]
    public DatastreamStreamSpecDestinationConfigGcsDestinationConfig? GcsDestinationConfig { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
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
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The MySQL data type. Full data types list can be found here: https://dev.mysql.com/doc/refman/8.0/en/data-types.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases
{
    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string Database { get; set; }

    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("mysqlTables")]
    public IList<DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>MySQL objects to exclude from the stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjects
{
    /// <summary>MySQL databases on the server.</summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases> MysqlDatabases { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The MySQL data type. Full data types list can be found here: https://dev.mysql.com/doc/refman/8.0/en/data-types.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases
{
    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string Database { get; set; }

    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("mysqlTables")]
    public IList<DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>MySQL objects to retrieve from the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjects
{
    /// <summary>MySQL databases on the server.</summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases> MysqlDatabases { get; set; }
}

/// <summary>MySQL data source configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigMysqlSourceConfig
{
    /// <summary>MySQL objects to exclude from the stream.</summary>
    [JsonPropertyName("excludeObjects")]
    public DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>MySQL objects to retrieve from the source.</summary>
    [JsonPropertyName("includeObjects")]
    public DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Maximum number of concurrent backfill tasks. The number should be non negative. If not set (or set to 0), the system's default value will be used.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public int? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Maximum number of concurrent CDC tasks. The number should be non negative. If not set (or set to 0), the system's default value will be used.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public int? MaxConcurrentCdcTasks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The Oracle data type. Full data types list can be found here: https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column encoding.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables
{
    /// <summary>Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("oracleColumns")]
    public IList<DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas
{
    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("oracleTables")]
    public IList<DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>Schema name.</summary>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }
}

/// <summary>Oracle objects to exclude from the stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjects
{
    /// <summary>Oracle schemas/databases in the database server.</summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas> OracleSchemas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The Oracle data type. Full data types list can be found here: https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column encoding.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables
{
    /// <summary>Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("oracleColumns")]
    public IList<DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas
{
    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("oracleTables")]
    public IList<DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>Schema name.</summary>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }
}

/// <summary>Oracle objects to retrieve from the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjects
{
    /// <summary>Oracle schemas/databases in the database server.</summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas> OracleSchemas { get; set; }
}

/// <summary>MySQL data source configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigOracleSourceConfig
{
    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("dropLargeObjects")]
    public JsonNode? DropLargeObjects { get; set; }

    /// <summary>Oracle objects to exclude from the stream.</summary>
    [JsonPropertyName("excludeObjects")]
    public DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>Oracle objects to retrieve from the source.</summary>
    [JsonPropertyName("includeObjects")]
    public DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Maximum number of concurrent backfill tasks. The number should be non negative. If not set (or set to 0), the system's default value will be used.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public int? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Maximum number of concurrent CDC tasks. The number should be non negative. If not set (or set to 0), the system's default value will be used.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public int? MaxConcurrentCdcTasks { get; set; }

    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("streamLargeObjects")]
    public JsonNode? StreamLargeObjects { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The PostgreSQL data type. Full data types list can be found here: https://www.postgresql.org/docs/current/datatype.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas
{
    /// <summary>Tables in the schema.</summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }
}

/// <summary>PostgreSQL objects to exclude from the stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjects
{
    /// <summary>PostgreSQL schemas on the server.</summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas> PostgresqlSchemas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The PostgreSQL data type. Full data types list can be found here: https://www.postgresql.org/docs/current/datatype.html.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string Table { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas
{
    /// <summary>Tables in the schema.</summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }
}

/// <summary>PostgreSQL objects to retrieve from the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjects
{
    /// <summary>PostgreSQL schemas on the server.</summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas> PostgresqlSchemas { get; set; }
}

/// <summary>PostgreSQL data source configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfigPostgresqlSourceConfig
{
    /// <summary>PostgreSQL objects to exclude from the stream.</summary>
    [JsonPropertyName("excludeObjects")]
    public DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>PostgreSQL objects to retrieve from the source.</summary>
    [JsonPropertyName("includeObjects")]
    public DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Maximum number of concurrent backfill tasks. The number should be non negative. If not set (or set to 0), the system's default value will be used.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public int? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>The name of the publication that includes the set of all tables that are defined in the stream's include_objects.</summary>
    [JsonPropertyName("publication")]
    public string Publication { get; set; }

    /// <summary>The name of the logical replication slot that's configured with the pgoutput plugin.</summary>
    [JsonPropertyName("replicationSlot")]
    public string ReplicationSlot { get; set; }
}

/// <summary>Source connection profile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpecSourceConfig
{
    /// <summary>MySQL data source configuration.</summary>
    [JsonPropertyName("mysqlSourceConfig")]
    public DatastreamStreamSpecSourceConfigMysqlSourceConfig? MysqlSourceConfig { get; set; }

    /// <summary>MySQL data source configuration.</summary>
    [JsonPropertyName("oracleSourceConfig")]
    public DatastreamStreamSpecSourceConfigOracleSourceConfig? OracleSourceConfig { get; set; }

    /// <summary>PostgreSQL data source configuration.</summary>
    [JsonPropertyName("postgresqlSourceConfig")]
    public DatastreamStreamSpecSourceConfigPostgresqlSourceConfig? PostgresqlSourceConfig { get; set; }

    /// <summary>Immutable. Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}.</summary>
    [JsonPropertyName("sourceConnectionProfile")]
    public string SourceConnectionProfile { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamSpec
{
    /// <summary>Backfill strategy to automatically backfill the Stream's objects. Specific objects can be excluded.</summary>
    [JsonPropertyName("backfillAll")]
    public DatastreamStreamSpecBackfillAll? BackfillAll { get; set; }

    /// <summary>Backfill strategy to disable automatic backfill for the Stream's objects.</summary>
    [JsonPropertyName("backfillNone")]
    public JsonNode? BackfillNone { get; set; }

    /// <summary>Immutable. A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data will be encrypted using an internal Stream-specific encryption key provisioned through KMS.</summary>
    [JsonPropertyName("customerManagedEncryptionKey")]
    public string? CustomerManagedEncryptionKey { get; set; }

    /// <summary>Desired state of the Stream. Set this field to 'RUNNING' to start the stream, and 'PAUSED' to pause the stream.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Destination connection profile configuration.</summary>
    [JsonPropertyName("destinationConfig")]
    public DatastreamStreamSpecDestinationConfig DestinationConfig { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Immutable. The name of the location this stream is located in.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public DatastreamStreamSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The streamId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Source connection profile configuration.</summary>
    [JsonPropertyName("sourceConfig")]
    public DatastreamStreamSpecSourceConfig SourceConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStreamStatusConditions
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
public partial class DatastreamStreamStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<DatastreamStreamStatusConditions>? Conditions { get; set; }

    /// <summary>The stream's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The state of the stream.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class DatastreamStream
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public DatastreamStreamMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public DatastreamStreamSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public DatastreamStreamStatus? Status { get; set; }
}