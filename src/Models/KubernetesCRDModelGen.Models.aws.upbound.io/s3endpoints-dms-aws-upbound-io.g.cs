using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dms.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServiceAccessRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServiceAccessRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecForProviderServiceAccessRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServiceAccessRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProviderServiceAccessRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecForProviderServiceAccessRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecForProvider
{
    /// <summary>Whether to add column name information to the .csv output file. Default is false.</summary>
    [JsonPropertyName("addColumnName")]
    public bool? AddColumnName { get; set; }

    /// <summary>Whether to add padding. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("addTrailingPaddingCharacter")]
    public bool? AddTrailingPaddingCharacter { get; set; }

    /// <summary>S3 object prefix.</summary>
    [JsonPropertyName("bucketFolder")]
    public string? BucketFolder { get; set; }

    /// <summary>S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Predefined (canned) access control list for objects created in an S3 bucket. Valid values include none, private, public-read, public-read-write, authenticated-read, aws-exec-read, bucket-owner-read, and bucket-owner-full-control. Default is none.</summary>
    [JsonPropertyName("cannedAclForObjects")]
    public string? CannedAclForObjects { get; set; }

    /// <summary>Whether to write insert and update operations to .csv or .parquet output files. Default is false.</summary>
    [JsonPropertyName("cdcInsertsAndUpdates")]
    public bool? CdcInsertsAndUpdates { get; set; }

    /// <summary>Whether to write insert operations to .csv or .parquet output files. Default is false.</summary>
    [JsonPropertyName("cdcInsertsOnly")]
    public bool? CdcInsertsOnly { get; set; }

    /// <summary>Maximum length of the interval, defined in seconds, after which to output a file to Amazon S3. (AWS default is 60.)</summary>
    [JsonPropertyName("cdcMaxBatchInterval")]
    public double? CdcMaxBatchInterval { get; set; }

    /// <summary>Minimum file size condition as defined in kilobytes to output a file to Amazon S3. (AWS default is 32000 KB.)</summary>
    [JsonPropertyName("cdcMinFileSize")]
    public double? CdcMinFileSize { get; set; }

    /// <summary>Folder path of CDC files. If cdc_path is set, AWS DMS reads CDC files from this path and replicates the data changes to the target endpoint. Supported in AWS DMS versions 3.4.2 and later. Required for CDC.</summary>
    [JsonPropertyName("cdcPath")]
    public string? CdcPath { get; set; }

    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Set to compress target files. Valid values are GZIP and NONE. Default is NONE. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Delimiter used to separate columns in the source files. Default is ,.</summary>
    [JsonPropertyName("csvDelimiter")]
    public string? CsvDelimiter { get; set; }

    /// <summary>Only applies if output files for a CDC load are written in .csv format. If use_csv_no_sup_value is set to true, string to use for all columns not included in the supplemental log. If you do not specify a string value, DMS uses the null value for these columns regardless of use_csv_no_sup_value. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("csvNoSupValue")]
    public string? CsvNoSupValue { get; set; }

    /// <summary>String to as null when writing to the target. (AWS default is NULL.)</summary>
    [JsonPropertyName("csvNullValue")]
    public string? CsvNullValue { get; set; }

    /// <summary>Delimiter used to separate rows in the source files. Default is newline (i.e., \n).</summary>
    [JsonPropertyName("csvRowDelimiter")]
    public string? CsvRowDelimiter { get; set; }

    /// <summary>Output format for the files that AWS DMS uses to create S3 objects. Valid values are csv and parquet.  (Ignored for source endpoints -- only csv is valid.)</summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary>Size of one data page in bytes. (AWS default is 1 MiB, i.e., 1048576.)</summary>
    [JsonPropertyName("dataPageSize")]
    public double? DataPageSize { get; set; }

    /// <summary>Date separating delimiter to use during folder partitioning. Valid values are SLASH, UNDERSCORE, DASH, and NONE. (AWS default is SLASH.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionDelimiter")]
    public string? DatePartitionDelimiter { get; set; }

    /// <summary>Partition S3 bucket folders based on transaction commit dates. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionEnabled")]
    public bool? DatePartitionEnabled { get; set; }

    /// <summary>Date format to use during folder partitioning. Use this parameter when date_partition_enabled is set to true. Valid values are YYYYMMDD, YYYYMMDDHH, YYYYMM, MMYYYYDD, and DDMMYYYY. (AWS default is YYYYMMDD.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionSequence")]
    public string? DatePartitionSequence { get; set; }

    /// <summary>Convert the current UTC time to a timezone. The conversion occurs when a date partition folder is created and a CDC filename is generated. The timezone format is Area/Location (e.g., Europe/Paris). Use this when date_partition_enabled is true. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionTimezone")]
    public string? DatePartitionTimezone { get; set; }

    /// <summary>Undocumented argument for use as directed by AWS Support.</summary>
    [JsonPropertyName("detachTargetOnLobLookupFailureParquet")]
    public bool? DetachTargetOnLobLookupFailureParquet { get; set; }

    /// <summary>Maximum size in bytes of an encoded dictionary page of a column. (AWS default is 1 MiB, i.e., 1048576.)</summary>
    [JsonPropertyName("dictPageSizeLimit")]
    public double? DictPageSizeLimit { get; set; }

    /// <summary>Whether to enable statistics for Parquet pages and row groups. Default is true.</summary>
    [JsonPropertyName("enableStatistics")]
    public bool? EnableStatistics { get; set; }

    /// <summary>Type of encoding to use. Value values are rle_dictionary, plain, and plain_dictionary. (AWS default is rle_dictionary.)</summary>
    [JsonPropertyName("encodingType")]
    public string? EncodingType { get; set; }

    /// <summary>Server-side encryption mode that you want to encrypt your .csv or .parquet object files copied to S3. Valid values are SSE_S3 and SSE_KMS. (AWS default is SSE_S3.) (Ignored for source endpoints -- only SSE_S3 is valid.)</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>Type of endpoint. Valid values are source, target.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Bucket owner to prevent sniping. Value is an AWS account ID.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>JSON document that describes how AWS DMS should interpret the data. Required for source endpoints.</summary>
    [JsonPropertyName("externalTableDefinition")]
    public string? ExternalTableDefinition { get; set; }

    /// <summary>Whether to integrate AWS Glue Data Catalog with an Amazon S3 target. See Using AWS Glue Data Catalog with an Amazon S3 target for AWS DMS for more information. Default is false.</summary>
    [JsonPropertyName("glueCatalogGeneration")]
    public bool? GlueCatalogGeneration { get; set; }

    /// <summary>When this value is set to 1, DMS ignores the first row header in a .csv file. (AWS default is 0.)</summary>
    [JsonPropertyName("ignoreHeaderRows")]
    public double? IgnoreHeaderRows { get; set; }

    /// <summary>Whether to enable a full load to write INSERT operations to the .csv output files only to indicate how the rows were added to the source database. Default is false.</summary>
    [JsonPropertyName("includeOpForFullLoad")]
    public bool? IncludeOpForFullLoad { get; set; }

    /// <summary>ARN for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for kms_key_arn, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1S3EndpointSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1S3EndpointSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Maximum size (in KB) of any .csv file to be created while migrating to an S3 target during full load. Valid values are from 1 to 1048576. (AWS default is 1 GB, i.e., 1048576.)</summary>
    [JsonPropertyName("maxFileSize")]
    public double? MaxFileSize { get; set; }

    /// <summary>- Specifies the precision of any TIMESTAMP column values written to an S3 object file in .parquet format. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("parquetTimestampInMillisecond")]
    public bool? ParquetTimestampInMillisecond { get; set; }

    /// <summary>Version of the .parquet file format. Valid values are parquet-1-0 and parquet-2-0. (AWS default is parquet-1-0.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("parquetVersion")]
    public string? ParquetVersion { get; set; }

    /// <summary>Whether DMS saves the transaction order for a CDC load on the S3 target specified by cdc_path. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("preserveTransactions")]
    public bool? PreserveTransactions { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>For an S3 source, whether each leading double quotation mark has to be followed by an ending double quotation mark. Default is true.</summary>
    [JsonPropertyName("rfc4180")]
    public bool? Rfc4180 { get; set; }

    /// <summary>Number of rows in a row group. (AWS default is 10000.)</summary>
    [JsonPropertyName("rowGroupLength")]
    public double? RowGroupLength { get; set; }

    /// <summary>When encryption_mode is SSE_KMS, ARN for the AWS KMS key. (Ignored for source endpoints -- only SSE_S3 encryption_mode is valid.)</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyId")]
    public string? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyIdRef")]
    public V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdRef? ServerSideEncryptionKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyIdSelector")]
    public V1beta1S3EndpointSpecForProviderServerSideEncryptionKmsKeyIdSelector? ServerSideEncryptionKmsKeyIdSelector { get; set; }

    /// <summary>ARN of the IAM role with permissions to the S3 Bucket.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceAccessRoleArn.</summary>
    [JsonPropertyName("serviceAccessRoleArnRef")]
    public V1beta1S3EndpointSpecForProviderServiceAccessRoleArnRef? ServiceAccessRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceAccessRoleArn.</summary>
    [JsonPropertyName("serviceAccessRoleArnSelector")]
    public V1beta1S3EndpointSpecForProviderServiceAccessRoleArnSelector? ServiceAccessRoleArnSelector { get; set; }

    /// <summary>SSL mode to use for the connection. Valid values are none, require, verify-ca, verify-full. (AWS default is none.)</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Column to add with timestamp information to the endpoint data for an Amazon S3 target.</summary>
    [JsonPropertyName("timestampColumnName")]
    public string? TimestampColumnName { get; set; }

    /// <summary>Whether to use csv_no_sup_value for columns not included in the supplemental log. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("useCsvNoSupValue")]
    public bool? UseCsvNoSupValue { get; set; }

    /// <summary>When set to true, uses the task start time as the timestamp column value instead of the time data is written to target. For full load, when set to true, each row of the timestamp column contains the task start time. For CDC loads, each row of the timestamp column contains the transaction commit time.When set to false, the full load timestamp in the timestamp column increments with the time data arrives at the target. Default is false.</summary>
    [JsonPropertyName("useTaskStartTimeForFullLoadTimestamp")]
    public bool? UseTaskStartTimeForFullLoadTimestamp { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecInitProvider
{
    /// <summary>Whether to add column name information to the .csv output file. Default is false.</summary>
    [JsonPropertyName("addColumnName")]
    public bool? AddColumnName { get; set; }

    /// <summary>Whether to add padding. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("addTrailingPaddingCharacter")]
    public bool? AddTrailingPaddingCharacter { get; set; }

    /// <summary>S3 object prefix.</summary>
    [JsonPropertyName("bucketFolder")]
    public string? BucketFolder { get; set; }

    /// <summary>S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Predefined (canned) access control list for objects created in an S3 bucket. Valid values include none, private, public-read, public-read-write, authenticated-read, aws-exec-read, bucket-owner-read, and bucket-owner-full-control. Default is none.</summary>
    [JsonPropertyName("cannedAclForObjects")]
    public string? CannedAclForObjects { get; set; }

    /// <summary>Whether to write insert and update operations to .csv or .parquet output files. Default is false.</summary>
    [JsonPropertyName("cdcInsertsAndUpdates")]
    public bool? CdcInsertsAndUpdates { get; set; }

    /// <summary>Whether to write insert operations to .csv or .parquet output files. Default is false.</summary>
    [JsonPropertyName("cdcInsertsOnly")]
    public bool? CdcInsertsOnly { get; set; }

    /// <summary>Maximum length of the interval, defined in seconds, after which to output a file to Amazon S3. (AWS default is 60.)</summary>
    [JsonPropertyName("cdcMaxBatchInterval")]
    public double? CdcMaxBatchInterval { get; set; }

    /// <summary>Minimum file size condition as defined in kilobytes to output a file to Amazon S3. (AWS default is 32000 KB.)</summary>
    [JsonPropertyName("cdcMinFileSize")]
    public double? CdcMinFileSize { get; set; }

    /// <summary>Folder path of CDC files. If cdc_path is set, AWS DMS reads CDC files from this path and replicates the data changes to the target endpoint. Supported in AWS DMS versions 3.4.2 and later. Required for CDC.</summary>
    [JsonPropertyName("cdcPath")]
    public string? CdcPath { get; set; }

    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Set to compress target files. Valid values are GZIP and NONE. Default is NONE. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Delimiter used to separate columns in the source files. Default is ,.</summary>
    [JsonPropertyName("csvDelimiter")]
    public string? CsvDelimiter { get; set; }

    /// <summary>Only applies if output files for a CDC load are written in .csv format. If use_csv_no_sup_value is set to true, string to use for all columns not included in the supplemental log. If you do not specify a string value, DMS uses the null value for these columns regardless of use_csv_no_sup_value. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("csvNoSupValue")]
    public string? CsvNoSupValue { get; set; }

    /// <summary>String to as null when writing to the target. (AWS default is NULL.)</summary>
    [JsonPropertyName("csvNullValue")]
    public string? CsvNullValue { get; set; }

    /// <summary>Delimiter used to separate rows in the source files. Default is newline (i.e., \n).</summary>
    [JsonPropertyName("csvRowDelimiter")]
    public string? CsvRowDelimiter { get; set; }

    /// <summary>Output format for the files that AWS DMS uses to create S3 objects. Valid values are csv and parquet.  (Ignored for source endpoints -- only csv is valid.)</summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary>Size of one data page in bytes. (AWS default is 1 MiB, i.e., 1048576.)</summary>
    [JsonPropertyName("dataPageSize")]
    public double? DataPageSize { get; set; }

    /// <summary>Date separating delimiter to use during folder partitioning. Valid values are SLASH, UNDERSCORE, DASH, and NONE. (AWS default is SLASH.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionDelimiter")]
    public string? DatePartitionDelimiter { get; set; }

    /// <summary>Partition S3 bucket folders based on transaction commit dates. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionEnabled")]
    public bool? DatePartitionEnabled { get; set; }

    /// <summary>Date format to use during folder partitioning. Use this parameter when date_partition_enabled is set to true. Valid values are YYYYMMDD, YYYYMMDDHH, YYYYMM, MMYYYYDD, and DDMMYYYY. (AWS default is YYYYMMDD.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionSequence")]
    public string? DatePartitionSequence { get; set; }

    /// <summary>Convert the current UTC time to a timezone. The conversion occurs when a date partition folder is created and a CDC filename is generated. The timezone format is Area/Location (e.g., Europe/Paris). Use this when date_partition_enabled is true. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionTimezone")]
    public string? DatePartitionTimezone { get; set; }

    /// <summary>Undocumented argument for use as directed by AWS Support.</summary>
    [JsonPropertyName("detachTargetOnLobLookupFailureParquet")]
    public bool? DetachTargetOnLobLookupFailureParquet { get; set; }

    /// <summary>Maximum size in bytes of an encoded dictionary page of a column. (AWS default is 1 MiB, i.e., 1048576.)</summary>
    [JsonPropertyName("dictPageSizeLimit")]
    public double? DictPageSizeLimit { get; set; }

    /// <summary>Whether to enable statistics for Parquet pages and row groups. Default is true.</summary>
    [JsonPropertyName("enableStatistics")]
    public bool? EnableStatistics { get; set; }

    /// <summary>Type of encoding to use. Value values are rle_dictionary, plain, and plain_dictionary. (AWS default is rle_dictionary.)</summary>
    [JsonPropertyName("encodingType")]
    public string? EncodingType { get; set; }

    /// <summary>Server-side encryption mode that you want to encrypt your .csv or .parquet object files copied to S3. Valid values are SSE_S3 and SSE_KMS. (AWS default is SSE_S3.) (Ignored for source endpoints -- only SSE_S3 is valid.)</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>Type of endpoint. Valid values are source, target.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Bucket owner to prevent sniping. Value is an AWS account ID.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>JSON document that describes how AWS DMS should interpret the data. Required for source endpoints.</summary>
    [JsonPropertyName("externalTableDefinition")]
    public string? ExternalTableDefinition { get; set; }

    /// <summary>Whether to integrate AWS Glue Data Catalog with an Amazon S3 target. See Using AWS Glue Data Catalog with an Amazon S3 target for AWS DMS for more information. Default is false.</summary>
    [JsonPropertyName("glueCatalogGeneration")]
    public bool? GlueCatalogGeneration { get; set; }

    /// <summary>When this value is set to 1, DMS ignores the first row header in a .csv file. (AWS default is 0.)</summary>
    [JsonPropertyName("ignoreHeaderRows")]
    public double? IgnoreHeaderRows { get; set; }

    /// <summary>Whether to enable a full load to write INSERT operations to the .csv output files only to indicate how the rows were added to the source database. Default is false.</summary>
    [JsonPropertyName("includeOpForFullLoad")]
    public bool? IncludeOpForFullLoad { get; set; }

    /// <summary>ARN for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for kms_key_arn, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1S3EndpointSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1S3EndpointSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Maximum size (in KB) of any .csv file to be created while migrating to an S3 target during full load. Valid values are from 1 to 1048576. (AWS default is 1 GB, i.e., 1048576.)</summary>
    [JsonPropertyName("maxFileSize")]
    public double? MaxFileSize { get; set; }

    /// <summary>- Specifies the precision of any TIMESTAMP column values written to an S3 object file in .parquet format. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("parquetTimestampInMillisecond")]
    public bool? ParquetTimestampInMillisecond { get; set; }

    /// <summary>Version of the .parquet file format. Valid values are parquet-1-0 and parquet-2-0. (AWS default is parquet-1-0.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("parquetVersion")]
    public string? ParquetVersion { get; set; }

    /// <summary>Whether DMS saves the transaction order for a CDC load on the S3 target specified by cdc_path. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("preserveTransactions")]
    public bool? PreserveTransactions { get; set; }

    /// <summary>For an S3 source, whether each leading double quotation mark has to be followed by an ending double quotation mark. Default is true.</summary>
    [JsonPropertyName("rfc4180")]
    public bool? Rfc4180 { get; set; }

    /// <summary>Number of rows in a row group. (AWS default is 10000.)</summary>
    [JsonPropertyName("rowGroupLength")]
    public double? RowGroupLength { get; set; }

    /// <summary>When encryption_mode is SSE_KMS, ARN for the AWS KMS key. (Ignored for source endpoints -- only SSE_S3 encryption_mode is valid.)</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyId")]
    public string? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyIdRef")]
    public V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdRef? ServerSideEncryptionKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate serverSideEncryptionKmsKeyId.</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyIdSelector")]
    public V1beta1S3EndpointSpecInitProviderServerSideEncryptionKmsKeyIdSelector? ServerSideEncryptionKmsKeyIdSelector { get; set; }

    /// <summary>ARN of the IAM role with permissions to the S3 Bucket.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceAccessRoleArn.</summary>
    [JsonPropertyName("serviceAccessRoleArnRef")]
    public V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnRef? ServiceAccessRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceAccessRoleArn.</summary>
    [JsonPropertyName("serviceAccessRoleArnSelector")]
    public V1beta1S3EndpointSpecInitProviderServiceAccessRoleArnSelector? ServiceAccessRoleArnSelector { get; set; }

    /// <summary>SSL mode to use for the connection. Valid values are none, require, verify-ca, verify-full. (AWS default is none.)</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Column to add with timestamp information to the endpoint data for an Amazon S3 target.</summary>
    [JsonPropertyName("timestampColumnName")]
    public string? TimestampColumnName { get; set; }

    /// <summary>Whether to use csv_no_sup_value for columns not included in the supplemental log. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("useCsvNoSupValue")]
    public bool? UseCsvNoSupValue { get; set; }

    /// <summary>When set to true, uses the task start time as the timestamp column value instead of the time data is written to target. For full load, when set to true, each row of the timestamp column contains the task start time. For CDC loads, each row of the timestamp column contains the transaction commit time.When set to false, the full load timestamp in the timestamp column increments with the time data arrives at the target. Default is false.</summary>
    [JsonPropertyName("useTaskStartTimeForFullLoadTimestamp")]
    public bool? UseTaskStartTimeForFullLoadTimestamp { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecProviderConfigRefPolicy
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
public partial class V1beta1S3EndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1S3EndpointSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1S3EndpointSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1S3EndpointSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1S3EndpointSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1S3EndpointSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>S3EndpointSpec defines the desired state of S3Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1S3EndpointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1S3EndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1S3EndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1S3EndpointSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1S3EndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointStatusAtProvider
{
    /// <summary>Whether to add column name information to the .csv output file. Default is false.</summary>
    [JsonPropertyName("addColumnName")]
    public bool? AddColumnName { get; set; }

    /// <summary>Whether to add padding. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("addTrailingPaddingCharacter")]
    public bool? AddTrailingPaddingCharacter { get; set; }

    /// <summary>S3 object prefix.</summary>
    [JsonPropertyName("bucketFolder")]
    public string? BucketFolder { get; set; }

    /// <summary>S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Predefined (canned) access control list for objects created in an S3 bucket. Valid values include none, private, public-read, public-read-write, authenticated-read, aws-exec-read, bucket-owner-read, and bucket-owner-full-control. Default is none.</summary>
    [JsonPropertyName("cannedAclForObjects")]
    public string? CannedAclForObjects { get; set; }

    /// <summary>Whether to write insert and update operations to .csv or .parquet output files. Default is false.</summary>
    [JsonPropertyName("cdcInsertsAndUpdates")]
    public bool? CdcInsertsAndUpdates { get; set; }

    /// <summary>Whether to write insert operations to .csv or .parquet output files. Default is false.</summary>
    [JsonPropertyName("cdcInsertsOnly")]
    public bool? CdcInsertsOnly { get; set; }

    /// <summary>Maximum length of the interval, defined in seconds, after which to output a file to Amazon S3. (AWS default is 60.)</summary>
    [JsonPropertyName("cdcMaxBatchInterval")]
    public double? CdcMaxBatchInterval { get; set; }

    /// <summary>Minimum file size condition as defined in kilobytes to output a file to Amazon S3. (AWS default is 32000 KB.)</summary>
    [JsonPropertyName("cdcMinFileSize")]
    public double? CdcMinFileSize { get; set; }

    /// <summary>Folder path of CDC files. If cdc_path is set, AWS DMS reads CDC files from this path and replicates the data changes to the target endpoint. Supported in AWS DMS versions 3.4.2 and later. Required for CDC.</summary>
    [JsonPropertyName("cdcPath")]
    public string? CdcPath { get; set; }

    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Set to compress target files. Valid values are GZIP and NONE. Default is NONE. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Delimiter used to separate columns in the source files. Default is ,.</summary>
    [JsonPropertyName("csvDelimiter")]
    public string? CsvDelimiter { get; set; }

    /// <summary>Only applies if output files for a CDC load are written in .csv format. If use_csv_no_sup_value is set to true, string to use for all columns not included in the supplemental log. If you do not specify a string value, DMS uses the null value for these columns regardless of use_csv_no_sup_value. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("csvNoSupValue")]
    public string? CsvNoSupValue { get; set; }

    /// <summary>String to as null when writing to the target. (AWS default is NULL.)</summary>
    [JsonPropertyName("csvNullValue")]
    public string? CsvNullValue { get; set; }

    /// <summary>Delimiter used to separate rows in the source files. Default is newline (i.e., \n).</summary>
    [JsonPropertyName("csvRowDelimiter")]
    public string? CsvRowDelimiter { get; set; }

    /// <summary>Output format for the files that AWS DMS uses to create S3 objects. Valid values are csv and parquet.  (Ignored for source endpoints -- only csv is valid.)</summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary>Size of one data page in bytes. (AWS default is 1 MiB, i.e., 1048576.)</summary>
    [JsonPropertyName("dataPageSize")]
    public double? DataPageSize { get; set; }

    /// <summary>Date separating delimiter to use during folder partitioning. Valid values are SLASH, UNDERSCORE, DASH, and NONE. (AWS default is SLASH.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionDelimiter")]
    public string? DatePartitionDelimiter { get; set; }

    /// <summary>Partition S3 bucket folders based on transaction commit dates. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionEnabled")]
    public bool? DatePartitionEnabled { get; set; }

    /// <summary>Date format to use during folder partitioning. Use this parameter when date_partition_enabled is set to true. Valid values are YYYYMMDD, YYYYMMDDHH, YYYYMM, MMYYYYDD, and DDMMYYYY. (AWS default is YYYYMMDD.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionSequence")]
    public string? DatePartitionSequence { get; set; }

    /// <summary>Convert the current UTC time to a timezone. The conversion occurs when a date partition folder is created and a CDC filename is generated. The timezone format is Area/Location (e.g., Europe/Paris). Use this when date_partition_enabled is true. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("datePartitionTimezone")]
    public string? DatePartitionTimezone { get; set; }

    /// <summary>Undocumented argument for use as directed by AWS Support.</summary>
    [JsonPropertyName("detachTargetOnLobLookupFailureParquet")]
    public bool? DetachTargetOnLobLookupFailureParquet { get; set; }

    /// <summary>Maximum size in bytes of an encoded dictionary page of a column. (AWS default is 1 MiB, i.e., 1048576.)</summary>
    [JsonPropertyName("dictPageSizeLimit")]
    public double? DictPageSizeLimit { get; set; }

    /// <summary>Whether to enable statistics for Parquet pages and row groups. Default is true.</summary>
    [JsonPropertyName("enableStatistics")]
    public bool? EnableStatistics { get; set; }

    /// <summary>Type of encoding to use. Value values are rle_dictionary, plain, and plain_dictionary. (AWS default is rle_dictionary.)</summary>
    [JsonPropertyName("encodingType")]
    public string? EncodingType { get; set; }

    /// <summary>Server-side encryption mode that you want to encrypt your .csv or .parquet object files copied to S3. Valid values are SSE_S3 and SSE_KMS. (AWS default is SSE_S3.) (Ignored for source endpoints -- only SSE_S3 is valid.)</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>ARN for the endpoint.</summary>
    [JsonPropertyName("endpointArn")]
    public string? EndpointArn { get; set; }

    /// <summary>Type of endpoint. Valid values are source, target.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Expanded name for the engine name.</summary>
    [JsonPropertyName("engineDisplayName")]
    public string? EngineDisplayName { get; set; }

    /// <summary>Bucket owner to prevent sniping. Value is an AWS account ID.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Can be used for cross-account validation. Use it in another account with aws_dms_s3_endpoint to create the endpoint cross-account.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>JSON document that describes how AWS DMS should interpret the data. Required for source endpoints.</summary>
    [JsonPropertyName("externalTableDefinition")]
    public string? ExternalTableDefinition { get; set; }

    /// <summary>Whether to integrate AWS Glue Data Catalog with an Amazon S3 target. See Using AWS Glue Data Catalog with an Amazon S3 target for AWS DMS for more information. Default is false.</summary>
    [JsonPropertyName("glueCatalogGeneration")]
    public bool? GlueCatalogGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>When this value is set to 1, DMS ignores the first row header in a .csv file. (AWS default is 0.)</summary>
    [JsonPropertyName("ignoreHeaderRows")]
    public double? IgnoreHeaderRows { get; set; }

    /// <summary>Whether to enable a full load to write INSERT operations to the .csv output files only to indicate how the rows were added to the source database. Default is false.</summary>
    [JsonPropertyName("includeOpForFullLoad")]
    public bool? IncludeOpForFullLoad { get; set; }

    /// <summary>ARN for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for kms_key_arn, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Maximum size (in KB) of any .csv file to be created while migrating to an S3 target during full load. Valid values are from 1 to 1048576. (AWS default is 1 GB, i.e., 1048576.)</summary>
    [JsonPropertyName("maxFileSize")]
    public double? MaxFileSize { get; set; }

    /// <summary>- Specifies the precision of any TIMESTAMP column values written to an S3 object file in .parquet format. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("parquetTimestampInMillisecond")]
    public bool? ParquetTimestampInMillisecond { get; set; }

    /// <summary>Version of the .parquet file format. Valid values are parquet-1-0 and parquet-2-0. (AWS default is parquet-1-0.) (Ignored for source endpoints.)</summary>
    [JsonPropertyName("parquetVersion")]
    public string? ParquetVersion { get; set; }

    /// <summary>Whether DMS saves the transaction order for a CDC load on the S3 target specified by cdc_path. Default is false. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("preserveTransactions")]
    public bool? PreserveTransactions { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>For an S3 source, whether each leading double quotation mark has to be followed by an ending double quotation mark. Default is true.</summary>
    [JsonPropertyName("rfc4180")]
    public bool? Rfc4180 { get; set; }

    /// <summary>Number of rows in a row group. (AWS default is 10000.)</summary>
    [JsonPropertyName("rowGroupLength")]
    public double? RowGroupLength { get; set; }

    /// <summary>When encryption_mode is SSE_KMS, ARN for the AWS KMS key. (Ignored for source endpoints -- only SSE_S3 encryption_mode is valid.)</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyId")]
    public string? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>ARN of the IAM role with permissions to the S3 Bucket.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>SSL mode to use for the connection. Valid values are none, require, verify-ca, verify-full. (AWS default is none.)</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }

    /// <summary>Status of the endpoint.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Column to add with timestamp information to the endpoint data for an Amazon S3 target.</summary>
    [JsonPropertyName("timestampColumnName")]
    public string? TimestampColumnName { get; set; }

    /// <summary>Whether to use csv_no_sup_value for columns not included in the supplemental log. (Ignored for source endpoints.)</summary>
    [JsonPropertyName("useCsvNoSupValue")]
    public bool? UseCsvNoSupValue { get; set; }

    /// <summary>When set to true, uses the task start time as the timestamp column value instead of the time data is written to target. For full load, when set to true, each row of the timestamp column contains the task start time. For CDC loads, each row of the timestamp column contains the transaction commit time.When set to false, the full load timestamp in the timestamp column increments with the time data arrives at the target. Default is false.</summary>
    [JsonPropertyName("useTaskStartTimeForFullLoadTimestamp")]
    public bool? UseTaskStartTimeForFullLoadTimestamp { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointStatusConditions
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

/// <summary>S3EndpointStatus defines the observed state of S3Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1S3EndpointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1S3EndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1S3EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>S3Endpoint is the Schema for the S3Endpoints API. Provides a DMS (Data Migration Service) S3 endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1S3Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1S3EndpointSpec>, IStatus<V1beta1S3EndpointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "S3Endpoint";
    public const string KubeGroup = "dms.aws.upbound.io";
    public const string KubePluralName = "s3endpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>S3EndpointSpec defines the desired state of S3Endpoint</summary>
    [JsonPropertyName("spec")]
    public V1beta1S3EndpointSpec Spec { get; set; }

    /// <summary>S3EndpointStatus defines the observed state of S3Endpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1S3EndpointStatus? Status { get; set; }
}

/// <summary>S3Endpoint is the Schema for the S3Endpoints API. Provides a DMS (Data Migration Service) S3 endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1S3EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1S3Endpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "S3EndpointList";
    public const string KubeGroup = "dms.aws.upbound.io";
    public const string KubePluralName = "s3endpoints";
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
    public IList<V1beta1S3Endpoint> Items { get; set; }
}