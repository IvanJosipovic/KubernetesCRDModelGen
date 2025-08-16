using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>CatalogTable is the Schema for the CatalogTables API. Provides a Glue Catalog Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CatalogTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogTableList";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "catalogtables";
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
    public IList<V1beta1CatalogTable> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInput
{
    /// <summary>A required metadata operation. Can only be set to CREATE.</summary>
    [JsonPropertyName("metadataOperation")]
    public string? MetadataOperation { get; set; }

    /// <summary>The table version for the Iceberg table. Defaults to 2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInput
{
    /// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
    [JsonPropertyName("icebergInput")]
    public IList<V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInput>? IcebergInput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderPartitionIndex
{
    /// <summary>Name of the partition index.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>Keys for the partition index.</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderPartitionKeys
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Partition Key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Datatype of data in the Partition Key.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorColumns
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value pairs defining properties associated with the column.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Datatype of data in the Column.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReferenceSchemaId
{
    /// <summary>Name of the schema registry that contains the schema. Must be provided when schema_name is specified and conflicts with schema_arn.</summary>
    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    /// <summary>ARN of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaArn")]
    public string? SchemaArn { get; set; }

    /// <summary>Name of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReference
{
    /// <summary>Configuration block that contains schema identity fields. Either this or the schema_version_id has to be provided. See schema_id below.</summary>
    [JsonPropertyName("schemaId")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReferenceSchemaId>? SchemaId { get; set; }

    /// <summary>Unique ID assigned to a version of the schema. Either this or the schema_id has to be provided.</summary>
    [JsonPropertyName("schemaVersionId")]
    public string? SchemaVersionId { get; set; }

    /// <summary>Version number of the schema.</summary>
    [JsonPropertyName("schemaVersionNumber")]
    public double? SchemaVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSerDeInfo
{
    /// <summary>Name of the SerDe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of initialization parameters for the SerDe, in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Usually the class that implements the SerDe. An example is org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSkewedInfo
{
    /// <summary>List of names of columns that contain skewed values.</summary>
    [JsonPropertyName("skewedColumnNames")]
    public IList<string>? SkewedColumnNames { get; set; }

    /// <summary>List of values that appear so frequently as to be considered skewed.</summary>
    [JsonPropertyName("skewedColumnValueLocationMaps")]
    public IDictionary<string, string>? SkewedColumnValueLocationMaps { get; set; }

    /// <summary>Map of skewed values to the columns that contain them.</summary>
    [JsonPropertyName("skewedColumnValues")]
    public IList<string>? SkewedColumnValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSortColumns
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public double? SortOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptor
{
    /// <summary>List of locations that point to the path where a Delta table is located.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<string>? AdditionalLocations { get; set; }

    /// <summary>List of reducer grouping columns, clustering columns, and bucketing columns in the table.</summary>
    [JsonPropertyName("bucketColumns")]
    public IList<string>? BucketColumns { get; set; }

    /// <summary>Configuration block for columns in the table. See columns below.</summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorColumns>? Columns { get; set; }

    /// <summary>Whether the data in the table is compressed.</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; set; }

    /// <summary>Input format: SequenceFileInputFormat (binary), or TextInputFormat, or a custom format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Must be specified if the table contains any dimension columns.</summary>
    [JsonPropertyName("numberOfBuckets")]
    public double? NumberOfBuckets { get; set; }

    /// <summary>Output format: SequenceFileOutputFormat (binary), or IgnoreKeyTextOutputFormat, or a custom format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
    [JsonPropertyName("schemaReference")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReference>? SchemaReference { get; set; }

    /// <summary>Configuration block for serialization and deserialization ("SerDe") information. See ser_de_info below.</summary>
    [JsonPropertyName("serDeInfo")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorSerDeInfo>? SerDeInfo { get; set; }

    /// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
    [JsonPropertyName("skewedInfo")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorSkewedInfo>? SkewedInfo { get; set; }

    /// <summary>Configuration block for the sort order of each bucket in the table. See sort_columns below.</summary>
    [JsonPropertyName("sortColumns")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorSortColumns>? SortColumns { get; set; }

    /// <summary>Whether the table data is stored in subdirectories.</summary>
    [JsonPropertyName("storedAsSubDirectories")]
    public bool? StoredAsSubDirectories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderTargetTable
{
    /// <summary>ID of the Data Catalog in which the table resides.</summary>
    [JsonPropertyName("catalogId")]
    public string CatalogId { get; set; }

    /// <summary>Name of the catalog database that contains the target table.</summary>
    [JsonPropertyName("databaseName")]
    public string DatabaseName { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region of the target table.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProvider
{
    /// <summary>ID of the Glue Catalog and database to create the table in. If omitted, this defaults to the AWS Account ID plus the database name.</summary>
    [JsonPropertyName("catalogId")]
    public string CatalogId { get; set; }

    /// <summary>Name of the metadata database where the table metadata resides. For Hive compatibility, this must be all lowercase.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>Description of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
    [JsonPropertyName("openTableFormatInput")]
    public IList<V1beta1CatalogTableSpecForProviderOpenTableFormatInput>? OpenTableFormatInput { get; set; }

    /// <summary>Owner of the table.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Properties associated with this table, as a list of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration block for a maximum of 3 partition indexes. See partition_index below.</summary>
    [JsonPropertyName("partitionIndex")]
    public IList<V1beta1CatalogTableSpecForProviderPartitionIndex>? PartitionIndex { get; set; }

    /// <summary>Configuration block of columns by which the table is partitioned. Only primitive types are supported as partition keys. See partition_keys below.</summary>
    [JsonPropertyName("partitionKeys")]
    public IList<V1beta1CatalogTableSpecForProviderPartitionKeys>? PartitionKeys { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Retention time for this table.</summary>
    [JsonPropertyName("retention")]
    public double? Retention { get; set; }

    /// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptor>? StorageDescriptor { get; set; }

    /// <summary>Type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc.). While optional, some Athena DDL queries such as ALTER TABLE and SHOW CREATE TABLE will fail if this argument is empty.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
    [JsonPropertyName("targetTable")]
    public IList<V1beta1CatalogTableSpecForProviderTargetTable>? TargetTable { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInput
{
    /// <summary>A required metadata operation. Can only be set to CREATE.</summary>
    [JsonPropertyName("metadataOperation")]
    public string? MetadataOperation { get; set; }

    /// <summary>The table version for the Iceberg table. Defaults to 2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInput
{
    /// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
    [JsonPropertyName("icebergInput")]
    public IList<V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInput>? IcebergInput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderPartitionIndex
{
    /// <summary>Name of the partition index.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>Keys for the partition index.</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderPartitionKeys
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Partition Key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Datatype of data in the Partition Key.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorColumns
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value pairs defining properties associated with the column.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Datatype of data in the Column.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReferenceSchemaId
{
    /// <summary>Name of the schema registry that contains the schema. Must be provided when schema_name is specified and conflicts with schema_arn.</summary>
    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    /// <summary>ARN of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaArn")]
    public string? SchemaArn { get; set; }

    /// <summary>Name of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReference
{
    /// <summary>Configuration block that contains schema identity fields. Either this or the schema_version_id has to be provided. See schema_id below.</summary>
    [JsonPropertyName("schemaId")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReferenceSchemaId>? SchemaId { get; set; }

    /// <summary>Unique ID assigned to a version of the schema. Either this or the schema_id has to be provided.</summary>
    [JsonPropertyName("schemaVersionId")]
    public string? SchemaVersionId { get; set; }

    /// <summary>Version number of the schema.</summary>
    [JsonPropertyName("schemaVersionNumber")]
    public double? SchemaVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSerDeInfo
{
    /// <summary>Name of the SerDe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of initialization parameters for the SerDe, in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Usually the class that implements the SerDe. An example is org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSkewedInfo
{
    /// <summary>List of names of columns that contain skewed values.</summary>
    [JsonPropertyName("skewedColumnNames")]
    public IList<string>? SkewedColumnNames { get; set; }

    /// <summary>List of values that appear so frequently as to be considered skewed.</summary>
    [JsonPropertyName("skewedColumnValueLocationMaps")]
    public IDictionary<string, string>? SkewedColumnValueLocationMaps { get; set; }

    /// <summary>Map of skewed values to the columns that contain them.</summary>
    [JsonPropertyName("skewedColumnValues")]
    public IList<string>? SkewedColumnValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSortColumns
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public double? SortOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptor
{
    /// <summary>List of locations that point to the path where a Delta table is located.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<string>? AdditionalLocations { get; set; }

    /// <summary>List of reducer grouping columns, clustering columns, and bucketing columns in the table.</summary>
    [JsonPropertyName("bucketColumns")]
    public IList<string>? BucketColumns { get; set; }

    /// <summary>Configuration block for columns in the table. See columns below.</summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorColumns>? Columns { get; set; }

    /// <summary>Whether the data in the table is compressed.</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; set; }

    /// <summary>Input format: SequenceFileInputFormat (binary), or TextInputFormat, or a custom format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Must be specified if the table contains any dimension columns.</summary>
    [JsonPropertyName("numberOfBuckets")]
    public double? NumberOfBuckets { get; set; }

    /// <summary>Output format: SequenceFileOutputFormat (binary), or IgnoreKeyTextOutputFormat, or a custom format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
    [JsonPropertyName("schemaReference")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReference>? SchemaReference { get; set; }

    /// <summary>Configuration block for serialization and deserialization ("SerDe") information. See ser_de_info below.</summary>
    [JsonPropertyName("serDeInfo")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorSerDeInfo>? SerDeInfo { get; set; }

    /// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
    [JsonPropertyName("skewedInfo")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorSkewedInfo>? SkewedInfo { get; set; }

    /// <summary>Configuration block for the sort order of each bucket in the table. See sort_columns below.</summary>
    [JsonPropertyName("sortColumns")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorSortColumns>? SortColumns { get; set; }

    /// <summary>Whether the table data is stored in subdirectories.</summary>
    [JsonPropertyName("storedAsSubDirectories")]
    public bool? StoredAsSubDirectories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderTargetTable
{
    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProvider
{
    /// <summary>Description of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
    [JsonPropertyName("openTableFormatInput")]
    public IList<V1beta1CatalogTableSpecInitProviderOpenTableFormatInput>? OpenTableFormatInput { get; set; }

    /// <summary>Owner of the table.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Properties associated with this table, as a list of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration block for a maximum of 3 partition indexes. See partition_index below.</summary>
    [JsonPropertyName("partitionIndex")]
    public IList<V1beta1CatalogTableSpecInitProviderPartitionIndex>? PartitionIndex { get; set; }

    /// <summary>Configuration block of columns by which the table is partitioned. Only primitive types are supported as partition keys. See partition_keys below.</summary>
    [JsonPropertyName("partitionKeys")]
    public IList<V1beta1CatalogTableSpecInitProviderPartitionKeys>? PartitionKeys { get; set; }

    /// <summary>Retention time for this table.</summary>
    [JsonPropertyName("retention")]
    public double? Retention { get; set; }

    /// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptor>? StorageDescriptor { get; set; }

    /// <summary>Type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc.). While optional, some Athena DDL queries such as ALTER TABLE and SHOW CREATE TABLE will fail if this argument is empty.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
    [JsonPropertyName("targetTable")]
    public IList<V1beta1CatalogTableSpecInitProviderTargetTable>? TargetTable { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecProviderConfigRefPolicy
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
public partial class V1beta1CatalogTableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CatalogTableSpec defines the desired state of CatalogTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CatalogTableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CatalogTableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CatalogTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CatalogTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInput
{
    /// <summary>A required metadata operation. Can only be set to CREATE.</summary>
    [JsonPropertyName("metadataOperation")]
    public string? MetadataOperation { get; set; }

    /// <summary>The table version for the Iceberg table. Defaults to 2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInput
{
    /// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
    [JsonPropertyName("icebergInput")]
    public IList<V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInput>? IcebergInput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderPartitionIndex
{
    /// <summary>Name of the partition index.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexStatus")]
    public string? IndexStatus { get; set; }

    /// <summary>Keys for the partition index.</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderPartitionKeys
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Partition Key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Datatype of data in the Partition Key.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorColumns
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value pairs defining properties associated with the column.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Datatype of data in the Column.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReferenceSchemaId
{
    /// <summary>Name of the schema registry that contains the schema. Must be provided when schema_name is specified and conflicts with schema_arn.</summary>
    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    /// <summary>ARN of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaArn")]
    public string? SchemaArn { get; set; }

    /// <summary>Name of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReference
{
    /// <summary>Configuration block that contains schema identity fields. Either this or the schema_version_id has to be provided. See schema_id below.</summary>
    [JsonPropertyName("schemaId")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReferenceSchemaId>? SchemaId { get; set; }

    /// <summary>Unique ID assigned to a version of the schema. Either this or the schema_id has to be provided.</summary>
    [JsonPropertyName("schemaVersionId")]
    public string? SchemaVersionId { get; set; }

    /// <summary>Version number of the schema.</summary>
    [JsonPropertyName("schemaVersionNumber")]
    public double? SchemaVersionNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSerDeInfo
{
    /// <summary>Name of the SerDe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of initialization parameters for the SerDe, in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Usually the class that implements the SerDe. An example is org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSkewedInfo
{
    /// <summary>List of names of columns that contain skewed values.</summary>
    [JsonPropertyName("skewedColumnNames")]
    public IList<string>? SkewedColumnNames { get; set; }

    /// <summary>List of values that appear so frequently as to be considered skewed.</summary>
    [JsonPropertyName("skewedColumnValueLocationMaps")]
    public IDictionary<string, string>? SkewedColumnValueLocationMaps { get; set; }

    /// <summary>Map of skewed values to the columns that contain them.</summary>
    [JsonPropertyName("skewedColumnValues")]
    public IList<string>? SkewedColumnValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSortColumns
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public double? SortOrder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptor
{
    /// <summary>List of locations that point to the path where a Delta table is located.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<string>? AdditionalLocations { get; set; }

    /// <summary>List of reducer grouping columns, clustering columns, and bucketing columns in the table.</summary>
    [JsonPropertyName("bucketColumns")]
    public IList<string>? BucketColumns { get; set; }

    /// <summary>Configuration block for columns in the table. See columns below.</summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorColumns>? Columns { get; set; }

    /// <summary>Whether the data in the table is compressed.</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; set; }

    /// <summary>Input format: SequenceFileInputFormat (binary), or TextInputFormat, or a custom format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Must be specified if the table contains any dimension columns.</summary>
    [JsonPropertyName("numberOfBuckets")]
    public double? NumberOfBuckets { get; set; }

    /// <summary>Output format: SequenceFileOutputFormat (binary), or IgnoreKeyTextOutputFormat, or a custom format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
    [JsonPropertyName("schemaReference")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReference>? SchemaReference { get; set; }

    /// <summary>Configuration block for serialization and deserialization ("SerDe") information. See ser_de_info below.</summary>
    [JsonPropertyName("serDeInfo")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorSerDeInfo>? SerDeInfo { get; set; }

    /// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
    [JsonPropertyName("skewedInfo")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorSkewedInfo>? SkewedInfo { get; set; }

    /// <summary>Configuration block for the sort order of each bucket in the table. See sort_columns below.</summary>
    [JsonPropertyName("sortColumns")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorSortColumns>? SortColumns { get; set; }

    /// <summary>Whether the table data is stored in subdirectories.</summary>
    [JsonPropertyName("storedAsSubDirectories")]
    public bool? StoredAsSubDirectories { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderTargetTable
{
    /// <summary>ID of the Data Catalog in which the table resides.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the catalog database that contains the target table.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region of the target table.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProvider
{
    /// <summary>The ARN of the Glue Table.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Glue Catalog and database to create the table in. If omitted, this defaults to the AWS Account ID plus the database name.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the metadata database where the table metadata resides. For Hive compatibility, this must be all lowercase.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Description of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Catalog ID, Database name and of the name table.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
    [JsonPropertyName("openTableFormatInput")]
    public IList<V1beta1CatalogTableStatusAtProviderOpenTableFormatInput>? OpenTableFormatInput { get; set; }

    /// <summary>Owner of the table.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Properties associated with this table, as a list of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration block for a maximum of 3 partition indexes. See partition_index below.</summary>
    [JsonPropertyName("partitionIndex")]
    public IList<V1beta1CatalogTableStatusAtProviderPartitionIndex>? PartitionIndex { get; set; }

    /// <summary>Configuration block of columns by which the table is partitioned. Only primitive types are supported as partition keys. See partition_keys below.</summary>
    [JsonPropertyName("partitionKeys")]
    public IList<V1beta1CatalogTableStatusAtProviderPartitionKeys>? PartitionKeys { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Retention time for this table.</summary>
    [JsonPropertyName("retention")]
    public double? Retention { get; set; }

    /// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptor>? StorageDescriptor { get; set; }

    /// <summary>Type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc.). While optional, some Athena DDL queries such as ALTER TABLE and SHOW CREATE TABLE will fail if this argument is empty.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
    [JsonPropertyName("targetTable")]
    public IList<V1beta1CatalogTableStatusAtProviderTargetTable>? TargetTable { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusConditions
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

/// <summary>CatalogTableStatus defines the observed state of CatalogTable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CatalogTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CatalogTableStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CatalogTable is the Schema for the CatalogTables API. Provides a Glue Catalog Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CatalogTableSpec>, IStatus<V1beta1CatalogTableStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogTable";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "catalogtables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CatalogTableSpec defines the desired state of CatalogTable</summary>
    [JsonPropertyName("spec")]
    public V1beta1CatalogTableSpec Spec { get; set; }

    /// <summary>CatalogTableStatus defines the observed state of CatalogTable.</summary>
    [JsonPropertyName("status")]
    public V1beta1CatalogTableStatus? Status { get; set; }
}