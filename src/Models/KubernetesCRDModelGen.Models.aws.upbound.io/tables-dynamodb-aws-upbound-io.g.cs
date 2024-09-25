using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dynamodb.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TableSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderAttribute
{
    /// <summary>Name of the attribute</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Attribute type. Valid values are S (string), N (number), B (binary).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderGlobalSecondaryIndex
{
    /// <summary>Name of the hash key in the index; must be defined as an attribute in the resource.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Name of the index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key; must be defined</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Number of write units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTableInputFormatOptionsCsv
{
    /// <summary>The delimiter used for separating items in the CSV file being imported.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>List of the headers used to specify a common header for all source CSV files being imported.</summary>
    [JsonPropertyName("headerList")]
    public IList<string>? HeaderList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTableInputFormatOptions
{
    /// <summary>This block contains the processing options for the CSV file being imported:</summary>
    [JsonPropertyName("csv")]
    public IList<V1beta1TableSpecForProviderImportTableInputFormatOptionsCsv>? Csv { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTableS3BucketSource
{
    /// <summary>The S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The account number of the S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>The key prefix shared by all S3 Objects that are being imported.</summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTable
{
    /// <summary>Type of compression to be used on the input coming from the imported table. Valid values are GZIP, ZSTD and NONE.</summary>
    [JsonPropertyName("inputCompressionType")]
    public string? InputCompressionType { get; set; }

    /// <summary>The format of the source data. Valid values are CSV, DYNAMODB_JSON, and ION.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Describe the format options for the data that was imported into the target table. There is one value, csv. See below.</summary>
    [JsonPropertyName("inputFormatOptions")]
    public IList<V1beta1TableSpecForProviderImportTableInputFormatOptions>? InputFormatOptions { get; set; }

    /// <summary>Values for the S3 bucket the source file is imported from. See below.</summary>
    [JsonPropertyName("s3BucketSource")]
    public IList<V1beta1TableSpecForProviderImportTableS3BucketSource>? S3BucketSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderLocalSecondaryIndex
{
    /// <summary>Name of the index</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderPointInTimeRecovery
{
    /// <summary>Whether to enable point-in-time recovery. It can take 10 minutes to enable for new tables. If the point_in_time_recovery block is not provided, this defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderReplica
{
    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Whether to enable Point In Time Recovery for the replica. Default is false.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public bool? PointInTimeRecovery { get; set; }

    /// <summary>Whether to propagate the global table's tags to a replica. Default is false. Changes to tags only move in one direction: from global (source) to replica. In other words, tag drift on a replica will not trigger an update. Tag or replica changes on the global table, whether from drift or configuration changes, are propagated to replicas. Changing from true to false on a subsequent apply means replica tags are left as they were, unmanaged, not deleted.</summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>Region name of the replica.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderServerSideEncryption
{
    /// <summary>Whether or not to enable encryption at rest using an AWS managed KMS customer master key (CMK). If enabled is false then server-side encryption is set to AWS-owned key (shown as DEFAULT in the AWS console). Potentially confusingly, if enabled is true and no kms_key_arn is specified then server-side encryption is set to the default KMS-managed key (shown as KMS in the AWS console). The AWS KMS documentation explains the difference between AWS-owned and KMS-managed keys.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTtl
{
    /// <summary>Name of the table attribute to store the TTL timestamp in.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>Whether TTL is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProvider
{
    /// <summary>Set of nested attribute definitions. Only required for hash_key and range_key attributes. See below.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1TableSpecForProviderAttribute>? Attribute { get; set; }

    /// <summary>Controls how you are charged for read and write throughput and how you manage capacity. The valid values are PROVISIONED and PAY_PER_REQUEST. Defaults to PROVISIONED.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Enables deletion protection for table. Defaults to false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Describe a GSI for the table; subject to the normal limits on the number of GSIs, projected attributes, etc. See below.</summary>
    [JsonPropertyName("globalSecondaryIndex")]
    public IList<V1beta1TableSpecForProviderGlobalSecondaryIndex>? GlobalSecondaryIndex { get; set; }

    /// <summary>Attribute to use as the hash (partition) key. Must also be defined as an attribute. See below.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Import Amazon S3 data into a new table. See below.</summary>
    [JsonPropertyName("importTable")]
    public IList<V1beta1TableSpecForProviderImportTable>? ImportTable { get; set; }

    /// <summary>Describe an LSI on the table; these can only be allocated at creation so you cannot change this definition after you have created the resource. See below.</summary>
    [JsonPropertyName("localSecondaryIndex")]
    public IList<V1beta1TableSpecForProviderLocalSecondaryIndex>? LocalSecondaryIndex { get; set; }

    /// <summary>Enable point-in-time recovery options. See below.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public IList<V1beta1TableSpecForProviderPointInTimeRecovery>? PointInTimeRecovery { get; set; }

    /// <summary>Attribute to use as the range (sort) key. Must also be defined as an attribute, see below.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration block(s) with DynamoDB Global Tables V2 (version 2019.11.21) replication configurations. See below.</summary>
    [JsonPropertyName("replica")]
    public IList<V1beta1TableSpecForProviderReplica>? Replica { get; set; }

    /// <summary>Time of the point-in-time recovery point to restore.</summary>
    [JsonPropertyName("restoreDateTime")]
    public string? RestoreDateTime { get; set; }

    /// <summary>Name of the table to restore. Must match the name of an existing table.</summary>
    [JsonPropertyName("restoreSourceName")]
    public string? RestoreSourceName { get; set; }

    /// <summary>If set, restores table to the most recent point-in-time recovery point.</summary>
    [JsonPropertyName("restoreToLatestTime")]
    public bool? RestoreToLatestTime { get; set; }

    /// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn't specified. See below.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public IList<V1beta1TableSpecForProviderServerSideEncryption>? ServerSideEncryption { get; set; }

    /// <summary>Whether Streams are enabled.</summary>
    [JsonPropertyName("streamEnabled")]
    public bool? StreamEnabled { get; set; }

    /// <summary>When an item in the table is modified, StreamViewType determines what information is written to the table's stream. Valid values are KEYS_ONLY, NEW_IMAGE, OLD_IMAGE, NEW_AND_OLD_IMAGES.</summary>
    [JsonPropertyName("streamViewType")]
    public string? StreamViewType { get; set; }

    /// <summary>Storage class of the table. Valid values are STANDARD and STANDARD_INFREQUENT_ACCESS. Default value is STANDARD.</summary>
    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for TTL. See below.</summary>
    [JsonPropertyName("ttl")]
    public IList<V1beta1TableSpecForProviderTtl>? Ttl { get; set; }

    /// <summary>Number of write units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderAttribute
{
    /// <summary>Name of the attribute</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Attribute type. Valid values are S (string), N (number), B (binary).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderGlobalSecondaryIndex
{
    /// <summary>Name of the hash key in the index; must be defined as an attribute in the resource.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Name of the index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key; must be defined</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Number of write units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTableInputFormatOptionsCsv
{
    /// <summary>The delimiter used for separating items in the CSV file being imported.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>List of the headers used to specify a common header for all source CSV files being imported.</summary>
    [JsonPropertyName("headerList")]
    public IList<string>? HeaderList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTableInputFormatOptions
{
    /// <summary>This block contains the processing options for the CSV file being imported:</summary>
    [JsonPropertyName("csv")]
    public IList<V1beta1TableSpecInitProviderImportTableInputFormatOptionsCsv>? Csv { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTableS3BucketSource
{
    /// <summary>The S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The account number of the S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>The key prefix shared by all S3 Objects that are being imported.</summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTable
{
    /// <summary>Type of compression to be used on the input coming from the imported table. Valid values are GZIP, ZSTD and NONE.</summary>
    [JsonPropertyName("inputCompressionType")]
    public string? InputCompressionType { get; set; }

    /// <summary>The format of the source data. Valid values are CSV, DYNAMODB_JSON, and ION.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Describe the format options for the data that was imported into the target table. There is one value, csv. See below.</summary>
    [JsonPropertyName("inputFormatOptions")]
    public IList<V1beta1TableSpecInitProviderImportTableInputFormatOptions>? InputFormatOptions { get; set; }

    /// <summary>Values for the S3 bucket the source file is imported from. See below.</summary>
    [JsonPropertyName("s3BucketSource")]
    public IList<V1beta1TableSpecInitProviderImportTableS3BucketSource>? S3BucketSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderLocalSecondaryIndex
{
    /// <summary>Name of the index</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderPointInTimeRecovery
{
    /// <summary>Whether to enable point-in-time recovery. It can take 10 minutes to enable for new tables. If the point_in_time_recovery block is not provided, this defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderReplica
{
    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Whether to enable Point In Time Recovery for the replica. Default is false.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public bool? PointInTimeRecovery { get; set; }

    /// <summary>Whether to propagate the global table's tags to a replica. Default is false. Changes to tags only move in one direction: from global (source) to replica. In other words, tag drift on a replica will not trigger an update. Tag or replica changes on the global table, whether from drift or configuration changes, are propagated to replicas. Changing from true to false on a subsequent apply means replica tags are left as they were, unmanaged, not deleted.</summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>Region name of the replica.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderServerSideEncryption
{
    /// <summary>Whether or not to enable encryption at rest using an AWS managed KMS customer master key (CMK). If enabled is false then server-side encryption is set to AWS-owned key (shown as DEFAULT in the AWS console). Potentially confusingly, if enabled is true and no kms_key_arn is specified then server-side encryption is set to the default KMS-managed key (shown as KMS in the AWS console). The AWS KMS documentation explains the difference between AWS-owned and KMS-managed keys.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTtl
{
    /// <summary>Name of the table attribute to store the TTL timestamp in.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>Whether TTL is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProvider
{
    /// <summary>Set of nested attribute definitions. Only required for hash_key and range_key attributes. See below.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1TableSpecInitProviderAttribute>? Attribute { get; set; }

    /// <summary>Controls how you are charged for read and write throughput and how you manage capacity. The valid values are PROVISIONED and PAY_PER_REQUEST. Defaults to PROVISIONED.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Enables deletion protection for table. Defaults to false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Describe a GSI for the table; subject to the normal limits on the number of GSIs, projected attributes, etc. See below.</summary>
    [JsonPropertyName("globalSecondaryIndex")]
    public IList<V1beta1TableSpecInitProviderGlobalSecondaryIndex>? GlobalSecondaryIndex { get; set; }

    /// <summary>Attribute to use as the hash (partition) key. Must also be defined as an attribute. See below.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Import Amazon S3 data into a new table. See below.</summary>
    [JsonPropertyName("importTable")]
    public IList<V1beta1TableSpecInitProviderImportTable>? ImportTable { get; set; }

    /// <summary>Describe an LSI on the table; these can only be allocated at creation so you cannot change this definition after you have created the resource. See below.</summary>
    [JsonPropertyName("localSecondaryIndex")]
    public IList<V1beta1TableSpecInitProviderLocalSecondaryIndex>? LocalSecondaryIndex { get; set; }

    /// <summary>Enable point-in-time recovery options. See below.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public IList<V1beta1TableSpecInitProviderPointInTimeRecovery>? PointInTimeRecovery { get; set; }

    /// <summary>Attribute to use as the range (sort) key. Must also be defined as an attribute, see below.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Configuration block(s) with DynamoDB Global Tables V2 (version 2019.11.21) replication configurations. See below.</summary>
    [JsonPropertyName("replica")]
    public IList<V1beta1TableSpecInitProviderReplica>? Replica { get; set; }

    /// <summary>Time of the point-in-time recovery point to restore.</summary>
    [JsonPropertyName("restoreDateTime")]
    public string? RestoreDateTime { get; set; }

    /// <summary>Name of the table to restore. Must match the name of an existing table.</summary>
    [JsonPropertyName("restoreSourceName")]
    public string? RestoreSourceName { get; set; }

    /// <summary>If set, restores table to the most recent point-in-time recovery point.</summary>
    [JsonPropertyName("restoreToLatestTime")]
    public bool? RestoreToLatestTime { get; set; }

    /// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn't specified. See below.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public IList<V1beta1TableSpecInitProviderServerSideEncryption>? ServerSideEncryption { get; set; }

    /// <summary>Whether Streams are enabled.</summary>
    [JsonPropertyName("streamEnabled")]
    public bool? StreamEnabled { get; set; }

    /// <summary>When an item in the table is modified, StreamViewType determines what information is written to the table's stream. Valid values are KEYS_ONLY, NEW_IMAGE, OLD_IMAGE, NEW_AND_OLD_IMAGES.</summary>
    [JsonPropertyName("streamViewType")]
    public string? StreamViewType { get; set; }

    /// <summary>Storage class of the table. Valid values are STANDARD and STANDARD_INFREQUENT_ACCESS. Default value is STANDARD.</summary>
    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for TTL. See below.</summary>
    [JsonPropertyName("ttl")]
    public IList<V1beta1TableSpecInitProviderTtl>? Ttl { get; set; }

    /// <summary>Number of write units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TableSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TableSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TableSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TableSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TableSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1TableSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TableSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TableSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TableSpec defines the desired state of Table</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecDeletionPolicyEnum>))]
    public V1beta1TableSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TableSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TableSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderAttribute
{
    /// <summary>Name of the attribute</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Attribute type. Valid values are S (string), N (number), B (binary).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderGlobalSecondaryIndex
{
    /// <summary>Name of the hash key in the index; must be defined as an attribute in the resource.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Name of the index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key; must be defined</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Number of write units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTableInputFormatOptionsCsv
{
    /// <summary>The delimiter used for separating items in the CSV file being imported.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>List of the headers used to specify a common header for all source CSV files being imported.</summary>
    [JsonPropertyName("headerList")]
    public IList<string>? HeaderList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTableInputFormatOptions
{
    /// <summary>This block contains the processing options for the CSV file being imported:</summary>
    [JsonPropertyName("csv")]
    public IList<V1beta1TableStatusAtProviderImportTableInputFormatOptionsCsv>? Csv { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTableS3BucketSource
{
    /// <summary>The S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The account number of the S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>The key prefix shared by all S3 Objects that are being imported.</summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTable
{
    /// <summary>Type of compression to be used on the input coming from the imported table. Valid values are GZIP, ZSTD and NONE.</summary>
    [JsonPropertyName("inputCompressionType")]
    public string? InputCompressionType { get; set; }

    /// <summary>The format of the source data. Valid values are CSV, DYNAMODB_JSON, and ION.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Describe the format options for the data that was imported into the target table. There is one value, csv. See below.</summary>
    [JsonPropertyName("inputFormatOptions")]
    public IList<V1beta1TableStatusAtProviderImportTableInputFormatOptions>? InputFormatOptions { get; set; }

    /// <summary>Values for the S3 bucket the source file is imported from. See below.</summary>
    [JsonPropertyName("s3BucketSource")]
    public IList<V1beta1TableStatusAtProviderImportTableS3BucketSource>? S3BucketSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderLocalSecondaryIndex
{
    /// <summary>Name of the index</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderPointInTimeRecovery
{
    /// <summary>Whether to enable point-in-time recovery. It can take 10 minutes to enable for new tables. If the point_in_time_recovery block is not provided, this defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderReplica
{
    /// <summary>ARN of the replica</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Whether to enable Point In Time Recovery for the replica. Default is false.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public bool? PointInTimeRecovery { get; set; }

    /// <summary>Whether to propagate the global table's tags to a replica. Default is false. Changes to tags only move in one direction: from global (source) to replica. In other words, tag drift on a replica will not trigger an update. Tag or replica changes on the global table, whether from drift or configuration changes, are propagated to replicas. Changing from true to false on a subsequent apply means replica tags are left as they were, unmanaged, not deleted.</summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>Region name of the replica.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }

    /// <summary>ARN of the Table Stream. Only available when stream_enabled = true</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Timestamp, in ISO 8601 format, for this stream. Note that this timestamp is not a unique identifier for the stream on its own. However, the combination of AWS customer ID, table name and this field is guaranteed to be unique. It can be used for creating CloudWatch Alarms. Only available when stream_enabled = true.</summary>
    [JsonPropertyName("streamLabel")]
    public string? StreamLabel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderServerSideEncryption
{
    /// <summary>Whether or not to enable encryption at rest using an AWS managed KMS customer master key (CMK). If enabled is false then server-side encryption is set to AWS-owned key (shown as DEFAULT in the AWS console). Potentially confusingly, if enabled is true and no kms_key_arn is specified then server-side encryption is set to the default KMS-managed key (shown as KMS in the AWS console). The AWS KMS documentation explains the difference between AWS-owned and KMS-managed keys.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTtl
{
    /// <summary>Name of the table attribute to store the TTL timestamp in.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>Whether TTL is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProvider
{
    /// <summary>ARN of the table</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Set of nested attribute definitions. Only required for hash_key and range_key attributes. See below.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1TableStatusAtProviderAttribute>? Attribute { get; set; }

    /// <summary>Controls how you are charged for read and write throughput and how you manage capacity. The valid values are PROVISIONED and PAY_PER_REQUEST. Defaults to PROVISIONED.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Enables deletion protection for table. Defaults to false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Describe a GSI for the table; subject to the normal limits on the number of GSIs, projected attributes, etc. See below.</summary>
    [JsonPropertyName("globalSecondaryIndex")]
    public IList<V1beta1TableStatusAtProviderGlobalSecondaryIndex>? GlobalSecondaryIndex { get; set; }

    /// <summary>Attribute to use as the hash (partition) key. Must also be defined as an attribute. See below.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Name of the table</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Import Amazon S3 data into a new table. See below.</summary>
    [JsonPropertyName("importTable")]
    public IList<V1beta1TableStatusAtProviderImportTable>? ImportTable { get; set; }

    /// <summary>Describe an LSI on the table; these can only be allocated at creation so you cannot change this definition after you have created the resource. See below.</summary>
    [JsonPropertyName("localSecondaryIndex")]
    public IList<V1beta1TableStatusAtProviderLocalSecondaryIndex>? LocalSecondaryIndex { get; set; }

    /// <summary>Enable point-in-time recovery options. See below.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public IList<V1beta1TableStatusAtProviderPointInTimeRecovery>? PointInTimeRecovery { get; set; }

    /// <summary>Attribute to use as the range (sort) key. Must also be defined as an attribute, see below.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Configuration block(s) with DynamoDB Global Tables V2 (version 2019.11.21) replication configurations. See below.</summary>
    [JsonPropertyName("replica")]
    public IList<V1beta1TableStatusAtProviderReplica>? Replica { get; set; }

    /// <summary>Time of the point-in-time recovery point to restore.</summary>
    [JsonPropertyName("restoreDateTime")]
    public string? RestoreDateTime { get; set; }

    /// <summary>Name of the table to restore. Must match the name of an existing table.</summary>
    [JsonPropertyName("restoreSourceName")]
    public string? RestoreSourceName { get; set; }

    /// <summary>If set, restores table to the most recent point-in-time recovery point.</summary>
    [JsonPropertyName("restoreToLatestTime")]
    public bool? RestoreToLatestTime { get; set; }

    /// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn't specified. See below.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public IList<V1beta1TableStatusAtProviderServerSideEncryption>? ServerSideEncryption { get; set; }

    /// <summary>ARN of the Table Stream. Only available when stream_enabled = true</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Whether Streams are enabled.</summary>
    [JsonPropertyName("streamEnabled")]
    public bool? StreamEnabled { get; set; }

    /// <summary>Timestamp, in ISO 8601 format, for this stream. Note that this timestamp is not a unique identifier for the stream on its own. However, the combination of AWS customer ID, table name and this field is guaranteed to be unique. It can be used for creating CloudWatch Alarms. Only available when stream_enabled = true.</summary>
    [JsonPropertyName("streamLabel")]
    public string? StreamLabel { get; set; }

    /// <summary>When an item in the table is modified, StreamViewType determines what information is written to the table's stream. Valid values are KEYS_ONLY, NEW_IMAGE, OLD_IMAGE, NEW_AND_OLD_IMAGES.</summary>
    [JsonPropertyName("streamViewType")]
    public string? StreamViewType { get; set; }

    /// <summary>Storage class of the table. Valid values are STANDARD and STANDARD_INFREQUENT_ACCESS. Default value is STANDARD.</summary>
    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for TTL. See below.</summary>
    [JsonPropertyName("ttl")]
    public IList<V1beta1TableStatusAtProviderTtl>? Ttl { get; set; }

    /// <summary>Number of write units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
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

/// <summary>Table is the Schema for the Tables API. Provides a DynamoDB table resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Table : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TableSpec>, IStatus<V1beta1TableStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Table";
    public const string KubeGroup = "dynamodb.aws.upbound.io";
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