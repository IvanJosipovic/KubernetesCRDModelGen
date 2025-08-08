using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firehose.aws.m.upbound.io;
/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Domain in elasticsearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Domain in elasticsearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelector
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
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsSelector
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
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to Elastic Search associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>Configuration options when destination is elasticsearch. See elasticsearch_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderElasticsearchConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the cluster. Conflicts with domain_arn.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>The ARN of the Amazon ES domain.  The pattern needs to be arn:.*.  Conflicts with cluster_endpoint.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>Reference to a Domain in elasticsearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnRef")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnRef? DomainArnRef { get; set; }

    /// <summary>Selector for a Domain in elasticsearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationDomainArnSelector? DomainArnSelector { get; set; }

    /// <summary>The Elasticsearch index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The Elasticsearch index rotation period.  Index rotation appends a timestamp to the IndexName to facilitate expiration of old data.  Valid values are NoRotation, OneHour, OneDay, OneWeek, and OneMonth.  The default value is OneDay.</summary>
    [JsonPropertyName("indexRotationPeriod")]
    public string? IndexRotationPeriod { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Amazon Elasticsearch, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon ES Configuration API and for indexing documents.  The IAM role must have permission for DescribeElasticsearchDomain, DescribeElasticsearchDomains, and DescribeElasticsearchDomainConfig.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Elasticsearch type name with maximum length of 100 characters.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to Elastic Search associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Specifies the native Hive / HCatalog JsonSerDe. More details below. See hive_json_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerHiveJsonSerDe
{
    /// <summary>A list of how you want Kinesis Data Firehose to parse the date and time stamps that may be present in your input data JSON. To specify these format strings, follow the pattern syntax of JodaTime's DateTimeFormat format strings. For more information, see Class DateTimeFormat. You can also use the special value millis to parse time stamps in epoch milliseconds. If you don't specify a format, Kinesis Data Firehose uses java.sql.Timestamp::valueOf by default.</summary>
    [JsonPropertyName("timestampFormats")]
    public IList<string>? TimestampFormats { get; set; }
}

/// <summary>Specifies the OpenX SerDe. See open_x_json_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe
{
    /// <summary>When set to true, which is the default, Kinesis Data Firehose converts JSON keys to lowercase before deserializing them.</summary>
    [JsonPropertyName("caseInsensitive")]
    public bool? CaseInsensitive { get; set; }

    /// <summary>A map of column names to JSON keys that aren't identical to the column names. This is useful when the JSON contains keys that are Hive keywords. For example, timestamp is a Hive keyword. If you have a JSON key named timestamp, set this parameter to { ts = "timestamp" } to map this key to a column named ts.</summary>
    [JsonPropertyName("columnToJsonKeyMappings")]
    public IDictionary<string, string>? ColumnToJsonKeyMappings { get; set; }

    /// <summary>When set to true, specifies that the names of the keys include dots and that you want Kinesis Data Firehose to replace them with underscores. This is useful because Apache Hive does not allow dots in column names. For example, if the JSON contains a key whose name is "a.b", you can define the column name to be "a_b" when using this option. Defaults to false.</summary>
    [JsonPropertyName("convertDotsInJsonKeysToUnderscores")]
    public bool? ConvertDotsInJsonKeysToUnderscores { get; set; }
}

/// <summary>Specifies which deserializer to use. You can choose either the Apache Hive JSON SerDe or the OpenX JSON SerDe. See deserializer block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer
{
    /// <summary>Specifies the native Hive / HCatalog JsonSerDe. More details below. See hive_json_ser_de block below for details.</summary>
    [JsonPropertyName("hiveJsonSerDe")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerHiveJsonSerDe? HiveJsonSerDe { get; set; }

    /// <summary>Specifies the OpenX SerDe. See open_x_json_ser_de block below for details.</summary>
    [JsonPropertyName("openXJsonSerDe")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe? OpenXJsonSerDe { get; set; }
}

/// <summary>Specifies the deserializer that you want Kinesis Data Firehose to use to convert the format of your data from JSON. See input_format_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration
{
    /// <summary>Specifies which deserializer to use. You can choose either the Apache Hive JSON SerDe or the OpenX JSON SerDe. See deserializer block below for details.</summary>
    [JsonPropertyName("deserializer")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer? Deserializer { get; set; }
}

/// <summary>Specifies converting data to the ORC format before storing it in Amazon S3. For more information, see Apache ORC. See orc_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe
{
    /// <summary>The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.</summary>
    [JsonPropertyName("blockSizeBytes")]
    public double? BlockSizeBytes { get; set; }

    /// <summary>A list of column names for which you want Kinesis Data Firehose to create bloom filters.</summary>
    [JsonPropertyName("bloomFilterColumns")]
    public IList<string>? BloomFilterColumns { get; set; }

    /// <summary>The Bloom filter false positive probability (FPP). The lower the FPP, the bigger the Bloom filter. The default value is 0.05, the minimum is 0, and the maximum is 1.</summary>
    [JsonPropertyName("bloomFilterFalsePositiveProbability")]
    public double? BloomFilterFalsePositiveProbability { get; set; }

    /// <summary>The compression code to use over data blocks. The possible values are UNCOMPRESSED, SNAPPY, and GZIP, with the default being SNAPPY. Use SNAPPY for higher decompression speed. Use GZIP if the compression ratio is more important than speed.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>A float that represents the fraction of the total number of non-null rows. To turn off dictionary encoding, set this fraction to a number that is less than the number of distinct keys in a dictionary. To always use dictionary encoding, set this threshold to 1.</summary>
    [JsonPropertyName("dictionaryKeyThreshold")]
    public double? DictionaryKeyThreshold { get; set; }

    /// <summary>Set this to true to indicate that you want stripes to be padded to the HDFS block boundaries. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is false.</summary>
    [JsonPropertyName("enablePadding")]
    public bool? EnablePadding { get; set; }

    /// <summary>The version of the file to write. The possible values are V0_11 and V0_12. The default is V0_12.</summary>
    [JsonPropertyName("formatVersion")]
    public string? FormatVersion { get; set; }

    /// <summary>A float between 0 and 1 that defines the tolerance for block padding as a decimal fraction of stripe size. The default value is 0.05, which means 5 percent of stripe size. For the default values of 64 MiB ORC stripes and 256 MiB HDFS blocks, the default block padding tolerance of 5 percent reserves a maximum of 3.2 MiB for padding within the 256 MiB block. In such a case, if the available size within the block is more than 3.2 MiB, a new, smaller stripe is inserted to fit within that space. This ensures that no stripe crosses block boundaries and causes remote reads within a node-local task. Kinesis Data Firehose ignores this parameter when enable_padding is false.</summary>
    [JsonPropertyName("paddingTolerance")]
    public double? PaddingTolerance { get; set; }

    /// <summary>The number of rows between index entries. The default is 10000 and the minimum is 1000.</summary>
    [JsonPropertyName("rowIndexStride")]
    public double? RowIndexStride { get; set; }

    /// <summary>The number of bytes in each stripe. The default is 64 MiB and the minimum is 8 MiB.</summary>
    [JsonPropertyName("stripeSizeBytes")]
    public double? StripeSizeBytes { get; set; }
}

/// <summary>Specifies converting data to the Parquet format before storing it in Amazon S3. For more information, see Apache Parquet. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe
{
    /// <summary>The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.</summary>
    [JsonPropertyName("blockSizeBytes")]
    public double? BlockSizeBytes { get; set; }

    /// <summary>The compression code to use over data blocks. The possible values are UNCOMPRESSED, SNAPPY, and GZIP, with the default being SNAPPY. Use SNAPPY for higher decompression speed. Use GZIP if the compression ratio is more important than speed.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Indicates whether to enable dictionary compression.</summary>
    [JsonPropertyName("enableDictionaryCompression")]
    public bool? EnableDictionaryCompression { get; set; }

    /// <summary>The maximum amount of padding to apply. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 0.</summary>
    [JsonPropertyName("maxPaddingBytes")]
    public double? MaxPaddingBytes { get; set; }

    /// <summary>The Parquet page size. Column chunks are divided into pages. A page is conceptually an indivisible unit (in terms of compression and encoding). The minimum value is 64 KiB and the default is 1 MiB.</summary>
    [JsonPropertyName("pageSizeBytes")]
    public double? PageSizeBytes { get; set; }

    /// <summary>Indicates the version of row format to output. The possible values are V1 and V2. The default is V1.</summary>
    [JsonPropertyName("writerVersion")]
    public string? WriterVersion { get; set; }
}

/// <summary>Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet SerDe. See serializer block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer
{
    /// <summary>Specifies converting data to the ORC format before storing it in Amazon S3. For more information, see Apache ORC. See orc_ser_de block below for details.</summary>
    [JsonPropertyName("orcSerDe")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe? OrcSerDe { get; set; }

    /// <summary>Specifies converting data to the Parquet format before storing it in Amazon S3. For more information, see Apache Parquet. More details below.</summary>
    [JsonPropertyName("parquetSerDe")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe? ParquetSerDe { get; set; }
}

/// <summary>Specifies the serializer that you want Kinesis Data Firehose to use to convert the format of your data to the Parquet or ORC format. See output_format_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration
{
    /// <summary>Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet SerDe. See serializer block below for details.</summary>
    [JsonPropertyName("serializer")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer? Serializer { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelector
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
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the AWS Glue Data Catalog table that contains the column information. See schema_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration
{
    /// <summary>The ID of the AWS Glue Data Catalog. If you don't supply this, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Specifies the name of the AWS Glue database that contains the schema for the output data.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>If you don't specify an AWS Region, the default is the current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Specifies the AWS Glue table that contains the column information that constitutes your data schema.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelector? TableNameSelector { get; set; }

    /// <summary>Specifies the table version for the output data schema. Defaults to LATEST.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>Nested argument for the serializer, deserializer, and schema for converting data from the JSON format to the Parquet or ORC format before writing it to Amazon S3. See data_format_conversion_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the deserializer that you want Kinesis Data Firehose to use to convert the format of your data from JSON. See input_format_configuration block below for details.</summary>
    [JsonPropertyName("inputFormatConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration? InputFormatConfiguration { get; set; }

    /// <summary>Specifies the serializer that you want Kinesis Data Firehose to use to convert the format of your data to the Parquet or ORC format. See output_format_configuration block below for details.</summary>
    [JsonPropertyName("outputFormatConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration? OutputFormatConfiguration { get; set; }

    /// <summary>Specifies the AWS Glue Data Catalog table that contains the column information. See schema_configuration block below for details.</summary>
    [JsonPropertyName("schemaConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration? SchemaConfiguration { get; set; }
}

/// <summary>The configuration for dynamic partitioning. Required when using dynamic partitioning. See dynamic_partitioning_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDynamicPartitioningConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>After an initial failure to deliver to Splunk, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationS3BackupConfiguration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Enhanced configuration options for the s3 destination. See extended_s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderExtendedS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>The time zone you prefer. Valid values are UTC or a non-3-letter IANA time zones (for example, America/Los_Angeles). Default value is UTC.</summary>
    [JsonPropertyName("customTimeZone")]
    public string? CustomTimeZone { get; set; }

    /// <summary>Nested argument for the serializer, deserializer, and schema for converting data from the JSON format to the Parquet or ORC format before writing it to Amazon S3. See data_format_conversion_configuration block below for details.</summary>
    [JsonPropertyName("dataFormatConversionConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDataFormatConversionConfiguration? DataFormatConversionConfiguration { get; set; }

    /// <summary>The configuration for dynamic partitioning. Required when using dynamic partitioning. See dynamic_partitioning_configuration block below for details.</summary>
    [JsonPropertyName("dynamicPartitioningConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationDynamicPartitioningConfiguration? DynamicPartitioningConfiguration { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>The file extension to override the default file extension (for example, .json).</summary>
    [JsonPropertyName("fileExtension")]
    public string? FileExtension { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object.</summary>
    [JsonPropertyName("s3BackupConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3ConfigurationS3BackupConfiguration? S3BackupConfiguration { get; set; }

    /// <summary>The Amazon S3 backup mode.  Valid values are Disabled and Enabled.  Default value is Disabled.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }
}

/// <summary>The access key required for Kinesis Firehose to authenticate with the HTTP endpoint selected as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationAccessKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRequestConfigurationCommonAttributes
{
    /// <summary>The name of the HTTP endpoint common attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP endpoint common attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The request configuration.  See request_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRequestConfiguration
{
    /// <summary>Describes the metadata sent to the HTTP endpoint destination. See common_attributes block below for details.</summary>
    [JsonPropertyName("commonAttributes")]
    public IList<V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRequestConfigurationCommonAttributes>? CommonAttributes { get; set; }

    /// <summary>Kinesis Data Firehose uses the content encoding to compress the body of a request before sending the request to the destination. Valid values are NONE and GZIP.  Default value is NONE.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secret Manager Configuration. See secrets_manager_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is http_endpoint. Requires the user to also specify an s3_configuration block.  See http_endpoint_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderHttpEndpointConfiguration
{
    /// <summary>The access key required for Kinesis Firehose to authenticate with the HTTP endpoint selected as the destination.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds, before delivering it to the destination. The default value is 300 (5 minutes).</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs, before delivering it to the destination. The default value is 5.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The HTTP endpoint name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The request configuration.  See request_configuration block below for details.</summary>
    [JsonPropertyName("requestConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRequestConfiguration? RequestConfiguration { get; set; }

    /// <summary>Total amount of seconds Firehose spends on retries. This duration starts after the initial attempt fails, It does not include the time periods during which Firehose waits for acknowledgment from the specified destination after each attempt. Valid values between 0 and 7200. Default is 300.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>Kinesis Data Firehose uses this IAM role for all the permissions that the delivery stream needs. The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDataOnly and AllData.  Default value is FailedDataOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secret Manager Configuration. See secrets_manager_configuration block below for details.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The HTTP endpoint URL to which Kinesis Firehose sends your data.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRefPolicy
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
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelectorPolicy
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
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelector
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
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameSelector
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
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfiguration
{
    /// <summary>Specifies the name of the AWS Glue database that contains the schema for the output data.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The table specific S3 error output prefix. All the errors that occurred while delivering to this table will be prefixed with this value in S3 destination.</summary>
    [JsonPropertyName("s3ErrorOutputPrefix")]
    public string? S3ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the AWS Glue table that contains the column information that constitutes your data schema.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfigurationTableNameSelector? TableNameSelector { get; set; }

    /// <summary>A list of unique keys for a given Apache Iceberg table. Firehose will use these for running Create, Update, or Delete operations on the given Iceberg table.</summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<string>? UniqueKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderIcebergConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderIcebergConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Configuration options when destination is iceberg. See iceberg_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderIcebergConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 and 900, before delivering it to the destination. The default value is 300.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 and 128, before delivering it to the destination. The default value is 5.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>Glue catalog ARN identifier of the destination Apache Iceberg Tables. You must specify the ARN in the format arn:aws:glue:region:account-id:catalog</summary>
    [JsonPropertyName("catalogArn")]
    public string? CatalogArn { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>Destination table configurations which Firehose uses to deliver data to Apache Iceberg Tables. Firehose will write data with insert if table specific configuration is not provided. See destination_table_configuration block below for details.</summary>
    [JsonPropertyName("destinationTableConfiguration")]
    public IList<V1beta1DeliveryStreamSpecForProviderIcebergConfigurationDestinationTableConfiguration>? DestinationTableConfiguration { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The period of time, in seconds between 0 to 7200, during which Firehose retries to deliver data to the specified destination.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling Apache Iceberg Tables.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedEventsOnly and AllEvents.  Default value is FailedEventsOnly. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if hec_token is not provided.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>The stream and role Amazon Resource Names (ARNs) for a Kinesis data stream used as the source for a delivery stream. See kinesis_source_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderKinesisSourceConfiguration
{
    /// <summary>The kinesis stream used as the source of the firehose delivery stream.</summary>
    [JsonPropertyName("kinesisStreamArn")]
    public string? KinesisStreamArn { get; set; }

    /// <summary>The ARN of the role that provides access to the source Kinesis stream.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The authentication configuration of the Amazon MSK cluster. See authentication_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderMskSourceConfigurationAuthenticationConfiguration
{
    /// <summary>The type of connectivity used to access the Amazon MSK cluster. Valid values: PUBLIC, PRIVATE.</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }

    /// <summary>The ARN of the role used to access the Amazon MSK cluster.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The configuration for the Amazon MSK cluster to be used as the source for a delivery stream. See msk_source_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderMskSourceConfiguration
{
    /// <summary>The authentication configuration of the Amazon MSK cluster. See authentication_configuration block below for details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderMskSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>The ARN of the Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }

    /// <summary>The start date and time in UTC for the offset position within your MSK topic from where Firehose begins to read. By default, this is set to timestamp when Firehose becomes Active. If you want to create a Firehose stream with Earliest start position set the read_from_timestamp parameter to Epoch (1970-01-01T00:00:00Z).</summary>
    [JsonPropertyName("readFromTimestamp")]
    public string? ReadFromTimestamp { get; set; }

    /// <summary>The topic name within the Amazon MSK cluster.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The method for setting up document ID. See [document_id_options block] below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDocumentIdOptions
{
    /// <summary>The method for setting up document ID. Valid values: FIREHOSE_DEFAULT, NO_DOCUMENT_ID.</summary>
    [JsonPropertyName("defaultDocumentIdFormat")]
    public string? DefaultDocumentIdFormat { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration. See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to OpenSearch associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>Configuration options when destination is opensearch. See opensearch_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the cluster. Conflicts with domain_arn.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>The method for setting up document ID. See [document_id_options block] below for details.</summary>
    [JsonPropertyName("documentIdOptions")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDocumentIdOptions? DocumentIdOptions { get; set; }

    /// <summary>The ARN of the Amazon ES domain.  The pattern needs to be arn:.*.  Conflicts with cluster_endpoint.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnRef? DomainArnRef { get; set; }

    /// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationDomainArnSelector? DomainArnSelector { get; set; }

    /// <summary>The OpenSearch index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The OpenSearch index rotation period.  Index rotation appends a timestamp to the IndexName to facilitate expiration of old data.  Valid values are NoRotation, OneHour, OneDay, OneWeek, and OneMonth.  The default value is OneDay.</summary>
    [JsonPropertyName("indexRotationPeriod")]
    public string? IndexRotationPeriod { get; set; }

    /// <summary>The data processing configuration. See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Amazon OpenSearch, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon ES Configuration API and for indexing documents.  The IAM role must have permission for DescribeDomain, DescribeDomains, and DescribeDomainConfig.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Elasticsearch type name with maximum length of 100 characters. Types are deprecated in OpenSearch_1.1. TypeName must be empty.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to OpenSearch associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Collection in opensearchserverless to populate collectionEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Collection in opensearchserverless to populate collectionEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to OpenSearch Serverless associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>Configuration options when destination is opensearchserverless. See opensearchserverless_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the collection in the Serverless offering for Amazon OpenSearch Service.</summary>
    [JsonPropertyName("collectionEndpoint")]
    public string? CollectionEndpoint { get; set; }

    /// <summary>Reference to a Collection in opensearchserverless to populate collectionEndpoint.</summary>
    [JsonPropertyName("collectionEndpointRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointRef? CollectionEndpointRef { get; set; }

    /// <summary>Selector for a Collection in opensearchserverless to populate collectionEndpoint.</summary>
    [JsonPropertyName("collectionEndpointSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationCollectionEndpointSelector? CollectionEndpointSelector { get; set; }

    /// <summary>The Serverless offering for Amazon OpenSearch Service index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to the Serverless offering for Amazon OpenSearch Service, the total amount of time, in seconds between 0 to 7200, during which Kinesis Data Firehose retries delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role to be assumed by Kinesis Data Firehose for calling the Serverless offering for Amazon OpenSearch Service Configuration API and for indexing documents.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to OpenSearch Serverless associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The password for the username above. This value is required if secrets_manager_configuration is not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if username and password are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfiguration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is redshift. Requires the user to also specify an s3_configuration block. See redshift_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderRedshiftConfiguration
{
    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The jdbcurl of the redshift cluster.</summary>
    [JsonPropertyName("clusterJdbcurl")]
    public string? ClusterJdbcurl { get; set; }

    /// <summary>Copy options for copying the data from the s3 intermediate bucket into redshift, for example to change the default delimiter. For valid values, see the AWS documentation</summary>
    [JsonPropertyName("copyOptions")]
    public string? CopyOptions { get; set; }

    /// <summary>The data table columns that will be targeted by the copy command.</summary>
    [JsonPropertyName("dataTableColumns")]
    public string? DataTableColumns { get; set; }

    /// <summary>The name of the table in the redshift cluster that the s3 bucket will copy to.</summary>
    [JsonPropertyName("dataTableName")]
    public string? DataTableName { get; set; }

    /// <summary>The password for the username above. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The length of time during which Firehose retries delivery after a failure, starting from the initial request and including the first attempt. The default value is 3600 seconds (60 minutes). Firehose does not retry if the value of DurationInSeconds is 0 (zero) or if the first delivery attempt takes longer than the current value.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The arn of the role the stream assumes.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if username and password are not provided.</summary>
    [JsonPropertyName("s3BackupConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3BackupConfiguration? S3BackupConfiguration { get; set; }

    /// <summary>The Amazon S3 backup mode.  Valid values are Disabled and Enabled.  Default value is Disabled.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The username that the firehose delivery stream will assume. It is strongly recommended that the username and password provided is used exclusively for Amazon Kinesis Firehose purposes, and that the permissions for the account are restricted for Amazon Redshift INSERT permissions. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Encrypt at rest options. See server_side_encryption block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderServerSideEncryption
{
    /// <summary>Whether to enable encryption at rest. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the encryption key. Required when key_type is CUSTOMER_MANAGED_CMK.</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }

    /// <summary>Type of encryption key. Default is AWS_OWNED_CMK. Valid values are AWS_OWNED_CMK and CUSTOMER_MANAGED_CMK</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The passphrase for the private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationKeyPassphraseSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The private key for authentication. This value is required if secrets_manager_configuration is not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The processing configuration. See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>The configuration for Snowflake role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationSnowflakeRoleConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Snowflake role.</summary>
    [JsonPropertyName("snowflakeRole")]
    public string? SnowflakeRole { get; set; }
}

/// <summary>The VPC configuration for Snowflake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationSnowflakeVpcConfiguration
{
    /// <summary>The VPCE ID for Firehose to privately connect with Snowflake.</summary>
    [JsonPropertyName("privateLinkVpceId")]
    public string? PrivateLinkVpceId { get; set; }
}

/// <summary>Configuration options when destination is snowflake. See snowflake_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSnowflakeConfiguration
{
    /// <summary>The URL of the Snowflake account. Format: https://[account_identifier].snowflakecomputing.com.</summary>
    [JsonPropertyName("accountUrl")]
    public string? AccountUrl { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 0s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 128, before delivering it to the destination.  The default value is 1MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The name of the content column.</summary>
    [JsonPropertyName("contentColumnName")]
    public string? ContentColumnName { get; set; }

    /// <summary>The data loading option.</summary>
    [JsonPropertyName("dataLoadingOption")]
    public string? DataLoadingOption { get; set; }

    /// <summary>The Snowflake database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The passphrase for the private key.</summary>
    [JsonPropertyName("keyPassphraseSecretRef")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationKeyPassphraseSecretRef? KeyPassphraseSecretRef { get; set; }

    /// <summary>The name of the metadata column.</summary>
    [JsonPropertyName("metadataColumnName")]
    public string? MetadataColumnName { get; set; }

    /// <summary>The private key for authentication. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>The processing configuration. See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Snowflake, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 60s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The S3 backup mode.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Snowflake schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The configuration for Snowflake role.</summary>
    [JsonPropertyName("snowflakeRoleConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationSnowflakeRoleConfiguration? SnowflakeRoleConfiguration { get; set; }

    /// <summary>The VPC configuration for Snowflake.</summary>
    [JsonPropertyName("snowflakeVpcConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfigurationSnowflakeVpcConfiguration? SnowflakeVpcConfiguration { get; set; }

    /// <summary>The Snowflake table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>The user for authentication. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The GUID that you obtain from your Splunk cluster when you create a new HEC endpoint. This value is required if secrets_manager_configuration is not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationHecTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecForProviderSplunkConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecForProviderSplunkConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is splunk. See splunk_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProviderSplunkConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The amount of time, in seconds between 180 and 600, that Kinesis Firehose waits to receive an acknowledgment from Splunk after it sends it data.</summary>
    [JsonPropertyName("hecAcknowledgmentTimeout")]
    public double? HecAcknowledgmentTimeout { get; set; }

    /// <summary>The HTTP Event Collector (HEC) endpoint to which Kinesis Firehose sends your data.</summary>
    [JsonPropertyName("hecEndpoint")]
    public string? HecEndpoint { get; set; }

    /// <summary>The HEC endpoint type. Valid values are Raw or Event. The default value is Raw.</summary>
    [JsonPropertyName("hecEndpointType")]
    public string? HecEndpointType { get; set; }

    /// <summary>The GUID that you obtain from your Splunk cluster when you create a new HEC endpoint. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("hecTokenSecretRef")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationHecTokenSecretRef? HecTokenSecretRef { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Splunk, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedEventsOnly and AllEvents.  Default value is FailedEventsOnly. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if hec_token is not provided.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecForProvider
{
    /// <summary>This is the destination to where the data is delivered. The only options are s3 (Deprecated, use extended_s3 instead), extended_s3, redshift, elasticsearch, splunk, http_endpoint, opensearch, opensearchserverless and snowflake.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>Configuration options when destination is elasticsearch. See elasticsearch_configuration block below for details.</summary>
    [JsonPropertyName("elasticsearchConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderElasticsearchConfiguration? ElasticsearchConfiguration { get; set; }

    /// <summary>Enhanced configuration options for the s3 destination. See extended_s3_configuration block below for details.</summary>
    [JsonPropertyName("extendedS3Configuration")]
    public V1beta1DeliveryStreamSpecForProviderExtendedS3Configuration? ExtendedS3Configuration { get; set; }

    /// <summary>Configuration options when destination is http_endpoint. Requires the user to also specify an s3_configuration block.  See http_endpoint_configuration block below for details.</summary>
    [JsonPropertyName("httpEndpointConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderHttpEndpointConfiguration? HttpEndpointConfiguration { get; set; }

    /// <summary>Configuration options when destination is iceberg. See iceberg_configuration block below for details.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderIcebergConfiguration? IcebergConfiguration { get; set; }

    /// <summary>The stream and role Amazon Resource Names (ARNs) for a Kinesis data stream used as the source for a delivery stream. See kinesis_source_configuration block below for details.</summary>
    [JsonPropertyName("kinesisSourceConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderKinesisSourceConfiguration? KinesisSourceConfiguration { get; set; }

    /// <summary>The configuration for the Amazon MSK cluster to be used as the source for a delivery stream. See msk_source_configuration block below for details.</summary>
    [JsonPropertyName("mskSourceConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderMskSourceConfiguration? MskSourceConfiguration { get; set; }

    /// <summary>A name to identify the stream. This is unique to the AWS account and region the Stream is created in. When using for WAF logging, name must be prefixed with aws-waf-logs-. See AWS Documentation for more details.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration options when destination is opensearch. See opensearch_configuration block below for details.</summary>
    [JsonPropertyName("opensearchConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchConfiguration? OpensearchConfiguration { get; set; }

    /// <summary>Configuration options when destination is opensearchserverless. See opensearchserverless_configuration block below for details.</summary>
    [JsonPropertyName("opensearchserverlessConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderOpensearchserverlessConfiguration? OpensearchserverlessConfiguration { get; set; }

    /// <summary>Configuration options when destination is redshift. Requires the user to also specify an s3_configuration block. See redshift_configuration block below for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Encrypt at rest options. See server_side_encryption block below for details.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public V1beta1DeliveryStreamSpecForProviderServerSideEncryption? ServerSideEncryption { get; set; }

    /// <summary>Configuration options when destination is snowflake. See snowflake_configuration block below for details.</summary>
    [JsonPropertyName("snowflakeConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSnowflakeConfiguration? SnowflakeConfiguration { get; set; }

    /// <summary>Configuration options when destination is splunk. See splunk_configuration block below for details.</summary>
    [JsonPropertyName("splunkConfiguration")]
    public V1beta1DeliveryStreamSpecForProviderSplunkConfiguration? SplunkConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the table version for the output data schema. Defaults to LATEST.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Domain in elasticsearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Domain in elasticsearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelector
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
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsSelector
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
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to Elastic Search associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>Configuration options when destination is elasticsearch. See elasticsearch_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderElasticsearchConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the cluster. Conflicts with domain_arn.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>The ARN of the Amazon ES domain.  The pattern needs to be arn:.*.  Conflicts with cluster_endpoint.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>Reference to a Domain in elasticsearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnRef? DomainArnRef { get; set; }

    /// <summary>Selector for a Domain in elasticsearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationDomainArnSelector? DomainArnSelector { get; set; }

    /// <summary>The Elasticsearch index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The Elasticsearch index rotation period.  Index rotation appends a timestamp to the IndexName to facilitate expiration of old data.  Valid values are NoRotation, OneHour, OneDay, OneWeek, and OneMonth.  The default value is OneDay.</summary>
    [JsonPropertyName("indexRotationPeriod")]
    public string? IndexRotationPeriod { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Amazon Elasticsearch, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon ES Configuration API and for indexing documents.  The IAM role must have permission for DescribeElasticsearchDomain, DescribeElasticsearchDomains, and DescribeElasticsearchDomainConfig.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Elasticsearch type name with maximum length of 100 characters.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to Elastic Search associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Specifies the native Hive / HCatalog JsonSerDe. More details below. See hive_json_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerHiveJsonSerDe
{
    /// <summary>A list of how you want Kinesis Data Firehose to parse the date and time stamps that may be present in your input data JSON. To specify these format strings, follow the pattern syntax of JodaTime's DateTimeFormat format strings. For more information, see Class DateTimeFormat. You can also use the special value millis to parse time stamps in epoch milliseconds. If you don't specify a format, Kinesis Data Firehose uses java.sql.Timestamp::valueOf by default.</summary>
    [JsonPropertyName("timestampFormats")]
    public IList<string>? TimestampFormats { get; set; }
}

/// <summary>Specifies the OpenX SerDe. See open_x_json_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe
{
    /// <summary>When set to true, which is the default, Kinesis Data Firehose converts JSON keys to lowercase before deserializing them.</summary>
    [JsonPropertyName("caseInsensitive")]
    public bool? CaseInsensitive { get; set; }

    /// <summary>A map of column names to JSON keys that aren't identical to the column names. This is useful when the JSON contains keys that are Hive keywords. For example, timestamp is a Hive keyword. If you have a JSON key named timestamp, set this parameter to { ts = "timestamp" } to map this key to a column named ts.</summary>
    [JsonPropertyName("columnToJsonKeyMappings")]
    public IDictionary<string, string>? ColumnToJsonKeyMappings { get; set; }

    /// <summary>When set to true, specifies that the names of the keys include dots and that you want Kinesis Data Firehose to replace them with underscores. This is useful because Apache Hive does not allow dots in column names. For example, if the JSON contains a key whose name is "a.b", you can define the column name to be "a_b" when using this option. Defaults to false.</summary>
    [JsonPropertyName("convertDotsInJsonKeysToUnderscores")]
    public bool? ConvertDotsInJsonKeysToUnderscores { get; set; }
}

/// <summary>Specifies which deserializer to use. You can choose either the Apache Hive JSON SerDe or the OpenX JSON SerDe. See deserializer block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer
{
    /// <summary>Specifies the native Hive / HCatalog JsonSerDe. More details below. See hive_json_ser_de block below for details.</summary>
    [JsonPropertyName("hiveJsonSerDe")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerHiveJsonSerDe? HiveJsonSerDe { get; set; }

    /// <summary>Specifies the OpenX SerDe. See open_x_json_ser_de block below for details.</summary>
    [JsonPropertyName("openXJsonSerDe")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe? OpenXJsonSerDe { get; set; }
}

/// <summary>Specifies the deserializer that you want Kinesis Data Firehose to use to convert the format of your data from JSON. See input_format_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration
{
    /// <summary>Specifies which deserializer to use. You can choose either the Apache Hive JSON SerDe or the OpenX JSON SerDe. See deserializer block below for details.</summary>
    [JsonPropertyName("deserializer")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer? Deserializer { get; set; }
}

/// <summary>Specifies converting data to the ORC format before storing it in Amazon S3. For more information, see Apache ORC. See orc_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe
{
    /// <summary>The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.</summary>
    [JsonPropertyName("blockSizeBytes")]
    public double? BlockSizeBytes { get; set; }

    /// <summary>A list of column names for which you want Kinesis Data Firehose to create bloom filters.</summary>
    [JsonPropertyName("bloomFilterColumns")]
    public IList<string>? BloomFilterColumns { get; set; }

    /// <summary>The Bloom filter false positive probability (FPP). The lower the FPP, the bigger the Bloom filter. The default value is 0.05, the minimum is 0, and the maximum is 1.</summary>
    [JsonPropertyName("bloomFilterFalsePositiveProbability")]
    public double? BloomFilterFalsePositiveProbability { get; set; }

    /// <summary>The compression code to use over data blocks. The possible values are UNCOMPRESSED, SNAPPY, and GZIP, with the default being SNAPPY. Use SNAPPY for higher decompression speed. Use GZIP if the compression ratio is more important than speed.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>A float that represents the fraction of the total number of non-null rows. To turn off dictionary encoding, set this fraction to a number that is less than the number of distinct keys in a dictionary. To always use dictionary encoding, set this threshold to 1.</summary>
    [JsonPropertyName("dictionaryKeyThreshold")]
    public double? DictionaryKeyThreshold { get; set; }

    /// <summary>Set this to true to indicate that you want stripes to be padded to the HDFS block boundaries. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is false.</summary>
    [JsonPropertyName("enablePadding")]
    public bool? EnablePadding { get; set; }

    /// <summary>The version of the file to write. The possible values are V0_11 and V0_12. The default is V0_12.</summary>
    [JsonPropertyName("formatVersion")]
    public string? FormatVersion { get; set; }

    /// <summary>A float between 0 and 1 that defines the tolerance for block padding as a decimal fraction of stripe size. The default value is 0.05, which means 5 percent of stripe size. For the default values of 64 MiB ORC stripes and 256 MiB HDFS blocks, the default block padding tolerance of 5 percent reserves a maximum of 3.2 MiB for padding within the 256 MiB block. In such a case, if the available size within the block is more than 3.2 MiB, a new, smaller stripe is inserted to fit within that space. This ensures that no stripe crosses block boundaries and causes remote reads within a node-local task. Kinesis Data Firehose ignores this parameter when enable_padding is false.</summary>
    [JsonPropertyName("paddingTolerance")]
    public double? PaddingTolerance { get; set; }

    /// <summary>The number of rows between index entries. The default is 10000 and the minimum is 1000.</summary>
    [JsonPropertyName("rowIndexStride")]
    public double? RowIndexStride { get; set; }

    /// <summary>The number of bytes in each stripe. The default is 64 MiB and the minimum is 8 MiB.</summary>
    [JsonPropertyName("stripeSizeBytes")]
    public double? StripeSizeBytes { get; set; }
}

/// <summary>Specifies converting data to the Parquet format before storing it in Amazon S3. For more information, see Apache Parquet. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe
{
    /// <summary>The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.</summary>
    [JsonPropertyName("blockSizeBytes")]
    public double? BlockSizeBytes { get; set; }

    /// <summary>The compression code to use over data blocks. The possible values are UNCOMPRESSED, SNAPPY, and GZIP, with the default being SNAPPY. Use SNAPPY for higher decompression speed. Use GZIP if the compression ratio is more important than speed.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Indicates whether to enable dictionary compression.</summary>
    [JsonPropertyName("enableDictionaryCompression")]
    public bool? EnableDictionaryCompression { get; set; }

    /// <summary>The maximum amount of padding to apply. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 0.</summary>
    [JsonPropertyName("maxPaddingBytes")]
    public double? MaxPaddingBytes { get; set; }

    /// <summary>The Parquet page size. Column chunks are divided into pages. A page is conceptually an indivisible unit (in terms of compression and encoding). The minimum value is 64 KiB and the default is 1 MiB.</summary>
    [JsonPropertyName("pageSizeBytes")]
    public double? PageSizeBytes { get; set; }

    /// <summary>Indicates the version of row format to output. The possible values are V1 and V2. The default is V1.</summary>
    [JsonPropertyName("writerVersion")]
    public string? WriterVersion { get; set; }
}

/// <summary>Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet SerDe. See serializer block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer
{
    /// <summary>Specifies converting data to the ORC format before storing it in Amazon S3. For more information, see Apache ORC. See orc_ser_de block below for details.</summary>
    [JsonPropertyName("orcSerDe")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe? OrcSerDe { get; set; }

    /// <summary>Specifies converting data to the Parquet format before storing it in Amazon S3. For more information, see Apache Parquet. More details below.</summary>
    [JsonPropertyName("parquetSerDe")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe? ParquetSerDe { get; set; }
}

/// <summary>Specifies the serializer that you want Kinesis Data Firehose to use to convert the format of your data to the Parquet or ORC format. See output_format_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration
{
    /// <summary>Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet SerDe. See serializer block below for details.</summary>
    [JsonPropertyName("serializer")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer? Serializer { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelector
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
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies the AWS Glue Data Catalog table that contains the column information. See schema_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration
{
    /// <summary>The ID of the AWS Glue Data Catalog. If you don't supply this, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Specifies the name of the AWS Glue database that contains the schema for the output data.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Specifies the AWS Glue table that contains the column information that constitutes your data schema.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfigurationTableNameSelector? TableNameSelector { get; set; }

    /// <summary>Specifies the table version for the output data schema. Defaults to LATEST.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>Nested argument for the serializer, deserializer, and schema for converting data from the JSON format to the Parquet or ORC format before writing it to Amazon S3. See data_format_conversion_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the deserializer that you want Kinesis Data Firehose to use to convert the format of your data from JSON. See input_format_configuration block below for details.</summary>
    [JsonPropertyName("inputFormatConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration? InputFormatConfiguration { get; set; }

    /// <summary>Specifies the serializer that you want Kinesis Data Firehose to use to convert the format of your data to the Parquet or ORC format. See output_format_configuration block below for details.</summary>
    [JsonPropertyName("outputFormatConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration? OutputFormatConfiguration { get; set; }

    /// <summary>Specifies the AWS Glue Data Catalog table that contains the column information. See schema_configuration block below for details.</summary>
    [JsonPropertyName("schemaConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration? SchemaConfiguration { get; set; }
}

/// <summary>The configuration for dynamic partitioning. Required when using dynamic partitioning. See dynamic_partitioning_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDynamicPartitioningConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>After an initial failure to deliver to Splunk, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationS3BackupConfiguration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Enhanced configuration options for the s3 destination. See extended_s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderExtendedS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>The time zone you prefer. Valid values are UTC or a non-3-letter IANA time zones (for example, America/Los_Angeles). Default value is UTC.</summary>
    [JsonPropertyName("customTimeZone")]
    public string? CustomTimeZone { get; set; }

    /// <summary>Nested argument for the serializer, deserializer, and schema for converting data from the JSON format to the Parquet or ORC format before writing it to Amazon S3. See data_format_conversion_configuration block below for details.</summary>
    [JsonPropertyName("dataFormatConversionConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDataFormatConversionConfiguration? DataFormatConversionConfiguration { get; set; }

    /// <summary>The configuration for dynamic partitioning. Required when using dynamic partitioning. See dynamic_partitioning_configuration block below for details.</summary>
    [JsonPropertyName("dynamicPartitioningConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationDynamicPartitioningConfiguration? DynamicPartitioningConfiguration { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>The file extension to override the default file extension (for example, .json).</summary>
    [JsonPropertyName("fileExtension")]
    public string? FileExtension { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object.</summary>
    [JsonPropertyName("s3BackupConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3ConfigurationS3BackupConfiguration? S3BackupConfiguration { get; set; }

    /// <summary>The Amazon S3 backup mode.  Valid values are Disabled and Enabled.  Default value is Disabled.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }
}

/// <summary>The access key required for Kinesis Firehose to authenticate with the HTTP endpoint selected as the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationAccessKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRequestConfigurationCommonAttributes
{
    /// <summary>The name of the HTTP endpoint common attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP endpoint common attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The request configuration.  See request_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRequestConfiguration
{
    /// <summary>Describes the metadata sent to the HTTP endpoint destination. See common_attributes block below for details.</summary>
    [JsonPropertyName("commonAttributes")]
    public IList<V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRequestConfigurationCommonAttributes>? CommonAttributes { get; set; }

    /// <summary>Kinesis Data Firehose uses the content encoding to compress the body of a request before sending the request to the destination. Valid values are NONE and GZIP.  Default value is NONE.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secret Manager Configuration. See secrets_manager_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is http_endpoint. Requires the user to also specify an s3_configuration block.  See http_endpoint_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfiguration
{
    /// <summary>The access key required for Kinesis Firehose to authenticate with the HTTP endpoint selected as the destination.</summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds, before delivering it to the destination. The default value is 300 (5 minutes).</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs, before delivering it to the destination. The default value is 5.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The HTTP endpoint name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The request configuration.  See request_configuration block below for details.</summary>
    [JsonPropertyName("requestConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRequestConfiguration? RequestConfiguration { get; set; }

    /// <summary>Total amount of seconds Firehose spends on retries. This duration starts after the initial attempt fails, It does not include the time periods during which Firehose waits for acknowledgment from the specified destination after each attempt. Valid values between 0 and 7200. Default is 300.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>Kinesis Data Firehose uses this IAM role for all the permissions that the delivery stream needs. The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDataOnly and AllData.  Default value is FailedDataOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secret Manager Configuration. See secrets_manager_configuration block below for details.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The HTTP endpoint URL to which Kinesis Firehose sends your data.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRefPolicy
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
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelectorPolicy
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
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelector
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
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameSelector
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
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfiguration
{
    /// <summary>Specifies the name of the AWS Glue database that contains the schema for the output data.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The table specific S3 error output prefix. All the errors that occurred while delivering to this table will be prefixed with this value in S3 destination.</summary>
    [JsonPropertyName("s3ErrorOutputPrefix")]
    public string? S3ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the AWS Glue table that contains the column information that constitutes your data schema.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameRef")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameRef? TableNameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate tableName.</summary>
    [JsonPropertyName("tableNameSelector")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfigurationTableNameSelector? TableNameSelector { get; set; }

    /// <summary>A list of unique keys for a given Apache Iceberg table. Firehose will use these for running Create, Update, or Delete operations on the given Iceberg table.</summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<string>? UniqueKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Configuration options when destination is iceberg. See iceberg_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderIcebergConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 and 900, before delivering it to the destination. The default value is 300.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 and 128, before delivering it to the destination. The default value is 5.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>Glue catalog ARN identifier of the destination Apache Iceberg Tables. You must specify the ARN in the format arn:aws:glue:region:account-id:catalog</summary>
    [JsonPropertyName("catalogArn")]
    public string? CatalogArn { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>Destination table configurations which Firehose uses to deliver data to Apache Iceberg Tables. Firehose will write data with insert if table specific configuration is not provided. See destination_table_configuration block below for details.</summary>
    [JsonPropertyName("destinationTableConfiguration")]
    public IList<V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationDestinationTableConfiguration>? DestinationTableConfiguration { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The period of time, in seconds between 0 to 7200, during which Firehose retries to deliver data to the specified destination.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling Apache Iceberg Tables.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedEventsOnly and AllEvents.  Default value is FailedEventsOnly. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if hec_token is not provided.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>The stream and role Amazon Resource Names (ARNs) for a Kinesis data stream used as the source for a delivery stream. See kinesis_source_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderKinesisSourceConfiguration
{
    /// <summary>The kinesis stream used as the source of the firehose delivery stream.</summary>
    [JsonPropertyName("kinesisStreamArn")]
    public string? KinesisStreamArn { get; set; }

    /// <summary>The ARN of the role that provides access to the source Kinesis stream.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The authentication configuration of the Amazon MSK cluster. See authentication_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderMskSourceConfigurationAuthenticationConfiguration
{
    /// <summary>The type of connectivity used to access the Amazon MSK cluster. Valid values: PUBLIC, PRIVATE.</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }

    /// <summary>The ARN of the role used to access the Amazon MSK cluster.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The configuration for the Amazon MSK cluster to be used as the source for a delivery stream. See msk_source_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderMskSourceConfiguration
{
    /// <summary>The authentication configuration of the Amazon MSK cluster. See authentication_configuration block below for details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderMskSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>The ARN of the Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }

    /// <summary>The start date and time in UTC for the offset position within your MSK topic from where Firehose begins to read. By default, this is set to timestamp when Firehose becomes Active. If you want to create a Firehose stream with Earliest start position set the read_from_timestamp parameter to Epoch (1970-01-01T00:00:00Z).</summary>
    [JsonPropertyName("readFromTimestamp")]
    public string? ReadFromTimestamp { get; set; }

    /// <summary>The topic name within the Amazon MSK cluster.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The method for setting up document ID. See [document_id_options block] below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDocumentIdOptions
{
    /// <summary>The method for setting up document ID. Valid values: FIREHOSE_DEFAULT, NO_DOCUMENT_ID.</summary>
    [JsonPropertyName("defaultDocumentIdFormat")]
    public string? DefaultDocumentIdFormat { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration. See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to OpenSearch associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsRefs")]
    public IList<V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsRefs>? SubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdsSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfigSubnetIdsSelector? SubnetIdsSelector { get; set; }
}

/// <summary>Configuration options when destination is opensearch. See opensearch_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the cluster. Conflicts with domain_arn.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>The method for setting up document ID. See [document_id_options block] below for details.</summary>
    [JsonPropertyName("documentIdOptions")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDocumentIdOptions? DocumentIdOptions { get; set; }

    /// <summary>The ARN of the Amazon ES domain.  The pattern needs to be arn:.*.  Conflicts with cluster_endpoint.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>Reference to a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnRef? DomainArnRef { get; set; }

    /// <summary>Selector for a Domain in opensearch to populate domainArn.</summary>
    [JsonPropertyName("domainArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationDomainArnSelector? DomainArnSelector { get; set; }

    /// <summary>The OpenSearch index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The OpenSearch index rotation period.  Index rotation appends a timestamp to the IndexName to facilitate expiration of old data.  Valid values are NoRotation, OneHour, OneDay, OneWeek, and OneMonth.  The default value is OneDay.</summary>
    [JsonPropertyName("indexRotationPeriod")]
    public string? IndexRotationPeriod { get; set; }

    /// <summary>The data processing configuration. See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Amazon OpenSearch, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon ES Configuration API and for indexing documents.  The IAM role must have permission for DescribeDomain, DescribeDomains, and DescribeDomainConfig.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Elasticsearch type name with maximum length of 100 characters. Types are deprecated in OpenSearch_1.1. TypeName must be empty.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to OpenSearch associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Collection in opensearchserverless to populate collectionEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Collection in opensearchserverless to populate collectionEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to OpenSearch Serverless associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>Configuration options when destination is opensearchserverless. See opensearchserverless_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the collection in the Serverless offering for Amazon OpenSearch Service.</summary>
    [JsonPropertyName("collectionEndpoint")]
    public string? CollectionEndpoint { get; set; }

    /// <summary>Reference to a Collection in opensearchserverless to populate collectionEndpoint.</summary>
    [JsonPropertyName("collectionEndpointRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointRef? CollectionEndpointRef { get; set; }

    /// <summary>Selector for a Collection in opensearchserverless to populate collectionEndpoint.</summary>
    [JsonPropertyName("collectionEndpointSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationCollectionEndpointSelector? CollectionEndpointSelector { get; set; }

    /// <summary>The Serverless offering for Amazon OpenSearch Service index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to the Serverless offering for Amazon OpenSearch Service, the total amount of time, in seconds between 0 to 7200, during which Kinesis Data Firehose retries delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role to be assumed by Kinesis Data Firehose for calling the Serverless offering for Amazon OpenSearch Service Configuration API and for indexing documents.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to OpenSearch Serverless associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The password for the username above. This value is required if secrets_manager_configuration is not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if username and password are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfiguration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is redshift. Requires the user to also specify an s3_configuration block. See redshift_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderRedshiftConfiguration
{
    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The jdbcurl of the redshift cluster.</summary>
    [JsonPropertyName("clusterJdbcurl")]
    public string? ClusterJdbcurl { get; set; }

    /// <summary>Copy options for copying the data from the s3 intermediate bucket into redshift, for example to change the default delimiter. For valid values, see the AWS documentation</summary>
    [JsonPropertyName("copyOptions")]
    public string? CopyOptions { get; set; }

    /// <summary>The data table columns that will be targeted by the copy command.</summary>
    [JsonPropertyName("dataTableColumns")]
    public string? DataTableColumns { get; set; }

    /// <summary>The name of the table in the redshift cluster that the s3 bucket will copy to.</summary>
    [JsonPropertyName("dataTableName")]
    public string? DataTableName { get; set; }

    /// <summary>The password for the username above. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The length of time during which Firehose retries delivery after a failure, starting from the initial request and including the first attempt. The default value is 3600 seconds (60 minutes). Firehose does not retry if the value of DurationInSeconds is 0 (zero) or if the first delivery attempt takes longer than the current value.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The arn of the role the stream assumes.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if username and password are not provided.</summary>
    [JsonPropertyName("s3BackupConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3BackupConfiguration? S3BackupConfiguration { get; set; }

    /// <summary>The Amazon S3 backup mode.  Valid values are Disabled and Enabled.  Default value is Disabled.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The username that the firehose delivery stream will assume. It is strongly recommended that the username and password provided is used exclusively for Amazon Kinesis Firehose purposes, and that the permissions for the account are restricted for Amazon Redshift INSERT permissions. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Encrypt at rest options. See server_side_encryption block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderServerSideEncryption
{
    /// <summary>Whether to enable encryption at rest. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the encryption key. Required when key_type is CUSTOMER_MANAGED_CMK.</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }

    /// <summary>Type of encryption key. Default is AWS_OWNED_CMK. Valid values are AWS_OWNED_CMK and CUSTOMER_MANAGED_CMK</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The passphrase for the private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationKeyPassphraseSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The private key for authentication. This value is required if secrets_manager_configuration is not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The processing configuration. See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>The configuration for Snowflake role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationSnowflakeRoleConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Snowflake role.</summary>
    [JsonPropertyName("snowflakeRole")]
    public string? SnowflakeRole { get; set; }
}

/// <summary>The VPC configuration for Snowflake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationSnowflakeVpcConfiguration
{
    /// <summary>The VPCE ID for Firehose to privately connect with Snowflake.</summary>
    [JsonPropertyName("privateLinkVpceId")]
    public string? PrivateLinkVpceId { get; set; }
}

/// <summary>Configuration options when destination is snowflake. See snowflake_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSnowflakeConfiguration
{
    /// <summary>The URL of the Snowflake account. Format: https://[account_identifier].snowflakecomputing.com.</summary>
    [JsonPropertyName("accountUrl")]
    public string? AccountUrl { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 0s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 128, before delivering it to the destination.  The default value is 1MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The name of the content column.</summary>
    [JsonPropertyName("contentColumnName")]
    public string? ContentColumnName { get; set; }

    /// <summary>The data loading option.</summary>
    [JsonPropertyName("dataLoadingOption")]
    public string? DataLoadingOption { get; set; }

    /// <summary>The Snowflake database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The passphrase for the private key.</summary>
    [JsonPropertyName("keyPassphraseSecretRef")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationKeyPassphraseSecretRef? KeyPassphraseSecretRef { get; set; }

    /// <summary>The name of the metadata column.</summary>
    [JsonPropertyName("metadataColumnName")]
    public string? MetadataColumnName { get; set; }

    /// <summary>The private key for authentication. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>The processing configuration. See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Snowflake, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 60s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The S3 backup mode.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Snowflake schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The configuration for Snowflake role.</summary>
    [JsonPropertyName("snowflakeRoleConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationSnowflakeRoleConfiguration? SnowflakeRoleConfiguration { get; set; }

    /// <summary>The VPC configuration for Snowflake.</summary>
    [JsonPropertyName("snowflakeVpcConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfigurationSnowflakeVpcConfiguration? SnowflakeVpcConfiguration { get; set; }

    /// <summary>The Snowflake table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>The user for authentication. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The GUID that you obtain from your Splunk cluster when you create a new HEC endpoint. This value is required if secrets_manager_configuration is not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationHecTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnSelector
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
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnRef? BucketArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketArn.</summary>
    [JsonPropertyName("bucketArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationBucketArnSelector? BucketArnSelector { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3ConfigurationRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is splunk. See splunk_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProviderSplunkConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The amount of time, in seconds between 180 and 600, that Kinesis Firehose waits to receive an acknowledgment from Splunk after it sends it data.</summary>
    [JsonPropertyName("hecAcknowledgmentTimeout")]
    public double? HecAcknowledgmentTimeout { get; set; }

    /// <summary>The HTTP Event Collector (HEC) endpoint to which Kinesis Firehose sends your data.</summary>
    [JsonPropertyName("hecEndpoint")]
    public string? HecEndpoint { get; set; }

    /// <summary>The HEC endpoint type. Valid values are Raw or Event. The default value is Raw.</summary>
    [JsonPropertyName("hecEndpointType")]
    public string? HecEndpointType { get; set; }

    /// <summary>The GUID that you obtain from your Splunk cluster when you create a new HEC endpoint. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("hecTokenSecretRef")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationHecTokenSecretRef? HecTokenSecretRef { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Splunk, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedEventsOnly and AllEvents.  Default value is FailedEventsOnly. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if hec_token is not provided.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecInitProvider
{
    /// <summary>This is the destination to where the data is delivered. The only options are s3 (Deprecated, use extended_s3 instead), extended_s3, redshift, elasticsearch, splunk, http_endpoint, opensearch, opensearchserverless and snowflake.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>Configuration options when destination is elasticsearch. See elasticsearch_configuration block below for details.</summary>
    [JsonPropertyName("elasticsearchConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderElasticsearchConfiguration? ElasticsearchConfiguration { get; set; }

    /// <summary>Enhanced configuration options for the s3 destination. See extended_s3_configuration block below for details.</summary>
    [JsonPropertyName("extendedS3Configuration")]
    public V1beta1DeliveryStreamSpecInitProviderExtendedS3Configuration? ExtendedS3Configuration { get; set; }

    /// <summary>Configuration options when destination is http_endpoint. Requires the user to also specify an s3_configuration block.  See http_endpoint_configuration block below for details.</summary>
    [JsonPropertyName("httpEndpointConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderHttpEndpointConfiguration? HttpEndpointConfiguration { get; set; }

    /// <summary>Configuration options when destination is iceberg. See iceberg_configuration block below for details.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderIcebergConfiguration? IcebergConfiguration { get; set; }

    /// <summary>The stream and role Amazon Resource Names (ARNs) for a Kinesis data stream used as the source for a delivery stream. See kinesis_source_configuration block below for details.</summary>
    [JsonPropertyName("kinesisSourceConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderKinesisSourceConfiguration? KinesisSourceConfiguration { get; set; }

    /// <summary>The configuration for the Amazon MSK cluster to be used as the source for a delivery stream. See msk_source_configuration block below for details.</summary>
    [JsonPropertyName("mskSourceConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderMskSourceConfiguration? MskSourceConfiguration { get; set; }

    /// <summary>A name to identify the stream. This is unique to the AWS account and region the Stream is created in. When using for WAF logging, name must be prefixed with aws-waf-logs-. See AWS Documentation for more details.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration options when destination is opensearch. See opensearch_configuration block below for details.</summary>
    [JsonPropertyName("opensearchConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchConfiguration? OpensearchConfiguration { get; set; }

    /// <summary>Configuration options when destination is opensearchserverless. See opensearchserverless_configuration block below for details.</summary>
    [JsonPropertyName("opensearchserverlessConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderOpensearchserverlessConfiguration? OpensearchserverlessConfiguration { get; set; }

    /// <summary>Configuration options when destination is redshift. Requires the user to also specify an s3_configuration block. See redshift_configuration block below for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Encrypt at rest options. See server_side_encryption block below for details.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public V1beta1DeliveryStreamSpecInitProviderServerSideEncryption? ServerSideEncryption { get; set; }

    /// <summary>Configuration options when destination is snowflake. See snowflake_configuration block below for details.</summary>
    [JsonPropertyName("snowflakeConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSnowflakeConfiguration? SnowflakeConfiguration { get; set; }

    /// <summary>Configuration options when destination is splunk. See splunk_configuration block below for details.</summary>
    [JsonPropertyName("splunkConfiguration")]
    public V1beta1DeliveryStreamSpecInitProviderSplunkConfiguration? SplunkConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the table version for the output data schema. Defaults to LATEST.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpecProviderConfigRef
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
public partial class V1beta1DeliveryStreamSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>DeliveryStreamSpec defines the desired state of DeliveryStream</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DeliveryStreamSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DeliveryStreamSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DeliveryStreamSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DeliveryStreamSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to Elastic Search associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>Configuration options when destination is elasticsearch. See elasticsearch_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderElasticsearchConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the cluster. Conflicts with domain_arn.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>The ARN of the Amazon ES domain.  The pattern needs to be arn:.*.  Conflicts with cluster_endpoint.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>The Elasticsearch index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The Elasticsearch index rotation period.  Index rotation appends a timestamp to the IndexName to facilitate expiration of old data.  Valid values are NoRotation, OneHour, OneDay, OneWeek, and OneMonth.  The default value is OneDay.</summary>
    [JsonPropertyName("indexRotationPeriod")]
    public string? IndexRotationPeriod { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Amazon Elasticsearch, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon ES Configuration API and for indexing documents.  The IAM role must have permission for DescribeElasticsearchDomain, DescribeElasticsearchDomains, and DescribeElasticsearchDomainConfig.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Elasticsearch type name with maximum length of 100 characters.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to Elastic Search associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamStatusAtProviderElasticsearchConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>Specifies the native Hive / HCatalog JsonSerDe. More details below. See hive_json_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerHiveJsonSerDe
{
    /// <summary>A list of how you want Kinesis Data Firehose to parse the date and time stamps that may be present in your input data JSON. To specify these format strings, follow the pattern syntax of JodaTime's DateTimeFormat format strings. For more information, see Class DateTimeFormat. You can also use the special value millis to parse time stamps in epoch milliseconds. If you don't specify a format, Kinesis Data Firehose uses java.sql.Timestamp::valueOf by default.</summary>
    [JsonPropertyName("timestampFormats")]
    public IList<string>? TimestampFormats { get; set; }
}

/// <summary>Specifies the OpenX SerDe. See open_x_json_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe
{
    /// <summary>When set to true, which is the default, Kinesis Data Firehose converts JSON keys to lowercase before deserializing them.</summary>
    [JsonPropertyName("caseInsensitive")]
    public bool? CaseInsensitive { get; set; }

    /// <summary>A map of column names to JSON keys that aren't identical to the column names. This is useful when the JSON contains keys that are Hive keywords. For example, timestamp is a Hive keyword. If you have a JSON key named timestamp, set this parameter to { ts = "timestamp" } to map this key to a column named ts.</summary>
    [JsonPropertyName("columnToJsonKeyMappings")]
    public IDictionary<string, string>? ColumnToJsonKeyMappings { get; set; }

    /// <summary>When set to true, specifies that the names of the keys include dots and that you want Kinesis Data Firehose to replace them with underscores. This is useful because Apache Hive does not allow dots in column names. For example, if the JSON contains a key whose name is "a.b", you can define the column name to be "a_b" when using this option. Defaults to false.</summary>
    [JsonPropertyName("convertDotsInJsonKeysToUnderscores")]
    public bool? ConvertDotsInJsonKeysToUnderscores { get; set; }
}

/// <summary>Specifies which deserializer to use. You can choose either the Apache Hive JSON SerDe or the OpenX JSON SerDe. See deserializer block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer
{
    /// <summary>Specifies the native Hive / HCatalog JsonSerDe. More details below. See hive_json_ser_de block below for details.</summary>
    [JsonPropertyName("hiveJsonSerDe")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerHiveJsonSerDe? HiveJsonSerDe { get; set; }

    /// <summary>Specifies the OpenX SerDe. See open_x_json_ser_de block below for details.</summary>
    [JsonPropertyName("openXJsonSerDe")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe? OpenXJsonSerDe { get; set; }
}

/// <summary>Specifies the deserializer that you want Kinesis Data Firehose to use to convert the format of your data from JSON. See input_format_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration
{
    /// <summary>Specifies which deserializer to use. You can choose either the Apache Hive JSON SerDe or the OpenX JSON SerDe. See deserializer block below for details.</summary>
    [JsonPropertyName("deserializer")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer? Deserializer { get; set; }
}

/// <summary>Specifies converting data to the ORC format before storing it in Amazon S3. For more information, see Apache ORC. See orc_ser_de block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe
{
    /// <summary>The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.</summary>
    [JsonPropertyName("blockSizeBytes")]
    public double? BlockSizeBytes { get; set; }

    /// <summary>A list of column names for which you want Kinesis Data Firehose to create bloom filters.</summary>
    [JsonPropertyName("bloomFilterColumns")]
    public IList<string>? BloomFilterColumns { get; set; }

    /// <summary>The Bloom filter false positive probability (FPP). The lower the FPP, the bigger the Bloom filter. The default value is 0.05, the minimum is 0, and the maximum is 1.</summary>
    [JsonPropertyName("bloomFilterFalsePositiveProbability")]
    public double? BloomFilterFalsePositiveProbability { get; set; }

    /// <summary>The compression code to use over data blocks. The possible values are UNCOMPRESSED, SNAPPY, and GZIP, with the default being SNAPPY. Use SNAPPY for higher decompression speed. Use GZIP if the compression ratio is more important than speed.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>A float that represents the fraction of the total number of non-null rows. To turn off dictionary encoding, set this fraction to a number that is less than the number of distinct keys in a dictionary. To always use dictionary encoding, set this threshold to 1.</summary>
    [JsonPropertyName("dictionaryKeyThreshold")]
    public double? DictionaryKeyThreshold { get; set; }

    /// <summary>Set this to true to indicate that you want stripes to be padded to the HDFS block boundaries. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is false.</summary>
    [JsonPropertyName("enablePadding")]
    public bool? EnablePadding { get; set; }

    /// <summary>The version of the file to write. The possible values are V0_11 and V0_12. The default is V0_12.</summary>
    [JsonPropertyName("formatVersion")]
    public string? FormatVersion { get; set; }

    /// <summary>A float between 0 and 1 that defines the tolerance for block padding as a decimal fraction of stripe size. The default value is 0.05, which means 5 percent of stripe size. For the default values of 64 MiB ORC stripes and 256 MiB HDFS blocks, the default block padding tolerance of 5 percent reserves a maximum of 3.2 MiB for padding within the 256 MiB block. In such a case, if the available size within the block is more than 3.2 MiB, a new, smaller stripe is inserted to fit within that space. This ensures that no stripe crosses block boundaries and causes remote reads within a node-local task. Kinesis Data Firehose ignores this parameter when enable_padding is false.</summary>
    [JsonPropertyName("paddingTolerance")]
    public double? PaddingTolerance { get; set; }

    /// <summary>The number of rows between index entries. The default is 10000 and the minimum is 1000.</summary>
    [JsonPropertyName("rowIndexStride")]
    public double? RowIndexStride { get; set; }

    /// <summary>The number of bytes in each stripe. The default is 64 MiB and the minimum is 8 MiB.</summary>
    [JsonPropertyName("stripeSizeBytes")]
    public double? StripeSizeBytes { get; set; }
}

/// <summary>Specifies converting data to the Parquet format before storing it in Amazon S3. For more information, see Apache Parquet. More details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe
{
    /// <summary>The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.</summary>
    [JsonPropertyName("blockSizeBytes")]
    public double? BlockSizeBytes { get; set; }

    /// <summary>The compression code to use over data blocks. The possible values are UNCOMPRESSED, SNAPPY, and GZIP, with the default being SNAPPY. Use SNAPPY for higher decompression speed. Use GZIP if the compression ratio is more important than speed.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Indicates whether to enable dictionary compression.</summary>
    [JsonPropertyName("enableDictionaryCompression")]
    public bool? EnableDictionaryCompression { get; set; }

    /// <summary>The maximum amount of padding to apply. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 0.</summary>
    [JsonPropertyName("maxPaddingBytes")]
    public double? MaxPaddingBytes { get; set; }

    /// <summary>The Parquet page size. Column chunks are divided into pages. A page is conceptually an indivisible unit (in terms of compression and encoding). The minimum value is 64 KiB and the default is 1 MiB.</summary>
    [JsonPropertyName("pageSizeBytes")]
    public double? PageSizeBytes { get; set; }

    /// <summary>Indicates the version of row format to output. The possible values are V1 and V2. The default is V1.</summary>
    [JsonPropertyName("writerVersion")]
    public string? WriterVersion { get; set; }
}

/// <summary>Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet SerDe. See serializer block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer
{
    /// <summary>Specifies converting data to the ORC format before storing it in Amazon S3. For more information, see Apache ORC. See orc_ser_de block below for details.</summary>
    [JsonPropertyName("orcSerDe")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe? OrcSerDe { get; set; }

    /// <summary>Specifies converting data to the Parquet format before storing it in Amazon S3. For more information, see Apache Parquet. More details below.</summary>
    [JsonPropertyName("parquetSerDe")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe? ParquetSerDe { get; set; }
}

/// <summary>Specifies the serializer that you want Kinesis Data Firehose to use to convert the format of your data to the Parquet or ORC format. See output_format_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration
{
    /// <summary>Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet SerDe. See serializer block below for details.</summary>
    [JsonPropertyName("serializer")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer? Serializer { get; set; }
}

/// <summary>Specifies the AWS Glue Data Catalog table that contains the column information. See schema_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration
{
    /// <summary>The ID of the AWS Glue Data Catalog. If you don't supply this, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Specifies the name of the AWS Glue database that contains the schema for the output data.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>If you don't specify an AWS Region, the default is the current region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies the AWS Glue table that contains the column information that constitutes your data schema.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Specifies the table version for the output data schema. Defaults to LATEST.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>Nested argument for the serializer, deserializer, and schema for converting data from the JSON format to the Parquet or ORC format before writing it to Amazon S3. See data_format_conversion_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the deserializer that you want Kinesis Data Firehose to use to convert the format of your data from JSON. See input_format_configuration block below for details.</summary>
    [JsonPropertyName("inputFormatConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration? InputFormatConfiguration { get; set; }

    /// <summary>Specifies the serializer that you want Kinesis Data Firehose to use to convert the format of your data to the Parquet or ORC format. See output_format_configuration block below for details.</summary>
    [JsonPropertyName("outputFormatConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration? OutputFormatConfiguration { get; set; }

    /// <summary>Specifies the AWS Glue Data Catalog table that contains the column information. See schema_configuration block below for details.</summary>
    [JsonPropertyName("schemaConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration? SchemaConfiguration { get; set; }
}

/// <summary>The configuration for dynamic partitioning. Required when using dynamic partitioning. See dynamic_partitioning_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDynamicPartitioningConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>After an initial failure to deliver to Splunk, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationS3BackupConfiguration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Enhanced configuration options for the s3 destination. See extended_s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderExtendedS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>The time zone you prefer. Valid values are UTC or a non-3-letter IANA time zones (for example, America/Los_Angeles). Default value is UTC.</summary>
    [JsonPropertyName("customTimeZone")]
    public string? CustomTimeZone { get; set; }

    /// <summary>Nested argument for the serializer, deserializer, and schema for converting data from the JSON format to the Parquet or ORC format before writing it to Amazon S3. See data_format_conversion_configuration block below for details.</summary>
    [JsonPropertyName("dataFormatConversionConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDataFormatConversionConfiguration? DataFormatConversionConfiguration { get; set; }

    /// <summary>The configuration for dynamic partitioning. Required when using dynamic partitioning. See dynamic_partitioning_configuration block below for details.</summary>
    [JsonPropertyName("dynamicPartitioningConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationDynamicPartitioningConfiguration? DynamicPartitioningConfiguration { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>The file extension to override the default file extension (for example, .json).</summary>
    [JsonPropertyName("fileExtension")]
    public string? FileExtension { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object.</summary>
    [JsonPropertyName("s3BackupConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3ConfigurationS3BackupConfiguration? S3BackupConfiguration { get; set; }

    /// <summary>The Amazon S3 backup mode.  Valid values are Disabled and Enabled.  Default value is Disabled.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationRequestConfigurationCommonAttributes
{
    /// <summary>The name of the HTTP endpoint common attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP endpoint common attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The request configuration.  See request_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationRequestConfiguration
{
    /// <summary>Describes the metadata sent to the HTTP endpoint destination. See common_attributes block below for details.</summary>
    [JsonPropertyName("commonAttributes")]
    public IList<V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationRequestConfigurationCommonAttributes>? CommonAttributes { get; set; }

    /// <summary>Kinesis Data Firehose uses the content encoding to compress the body of a request before sending the request to the destination. Valid values are NONE and GZIP.  Default value is NONE.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Secret Manager Configuration. See secrets_manager_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is http_endpoint. Requires the user to also specify an s3_configuration block.  See http_endpoint_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds, before delivering it to the destination. The default value is 300 (5 minutes).</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs, before delivering it to the destination. The default value is 5.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The HTTP endpoint name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The request configuration.  See request_configuration block below for details.</summary>
    [JsonPropertyName("requestConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationRequestConfiguration? RequestConfiguration { get; set; }

    /// <summary>Total amount of seconds Firehose spends on retries. This duration starts after the initial attempt fails, It does not include the time periods during which Firehose waits for acknowledgment from the specified destination after each attempt. Valid values between 0 and 7200. Default is 300.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>Kinesis Data Firehose uses this IAM role for all the permissions that the delivery stream needs. The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDataOnly and AllData.  Default value is FailedDataOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secret Manager Configuration. See secrets_manager_configuration block below for details.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The HTTP endpoint URL to which Kinesis Firehose sends your data.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationDestinationTableConfiguration
{
    /// <summary>Specifies the name of the AWS Glue database that contains the schema for the output data.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The table specific S3 error output prefix. All the errors that occurred while delivering to this table will be prefixed with this value in S3 destination.</summary>
    [JsonPropertyName("s3ErrorOutputPrefix")]
    public string? S3ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the AWS Glue table that contains the column information that constitutes your data schema.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>A list of unique keys for a given Apache Iceberg table. Firehose will use these for running Create, Update, or Delete operations on the given Iceberg table.</summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<string>? UniqueKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Configuration options when destination is iceberg. See iceberg_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderIcebergConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 and 900, before delivering it to the destination. The default value is 300.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 and 128, before delivering it to the destination. The default value is 5.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>Glue catalog ARN identifier of the destination Apache Iceberg Tables. You must specify the ARN in the format arn:aws:glue:region:account-id:catalog</summary>
    [JsonPropertyName("catalogArn")]
    public string? CatalogArn { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>Destination table configurations which Firehose uses to deliver data to Apache Iceberg Tables. Firehose will write data with insert if table specific configuration is not provided. See destination_table_configuration block below for details.</summary>
    [JsonPropertyName("destinationTableConfiguration")]
    public IList<V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationDestinationTableConfiguration>? DestinationTableConfiguration { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The period of time, in seconds between 0 to 7200, during which Firehose retries to deliver data to the specified destination.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling Apache Iceberg Tables.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedEventsOnly and AllEvents.  Default value is FailedEventsOnly. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if hec_token is not provided.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderIcebergConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>The stream and role Amazon Resource Names (ARNs) for a Kinesis data stream used as the source for a delivery stream. See kinesis_source_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderKinesisSourceConfiguration
{
    /// <summary>The kinesis stream used as the source of the firehose delivery stream.</summary>
    [JsonPropertyName("kinesisStreamArn")]
    public string? KinesisStreamArn { get; set; }

    /// <summary>The ARN of the role that provides access to the source Kinesis stream.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The authentication configuration of the Amazon MSK cluster. See authentication_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderMskSourceConfigurationAuthenticationConfiguration
{
    /// <summary>The type of connectivity used to access the Amazon MSK cluster. Valid values: PUBLIC, PRIVATE.</summary>
    [JsonPropertyName("connectivity")]
    public string? Connectivity { get; set; }

    /// <summary>The ARN of the role used to access the Amazon MSK cluster.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The configuration for the Amazon MSK cluster to be used as the source for a delivery stream. See msk_source_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderMskSourceConfiguration
{
    /// <summary>The authentication configuration of the Amazon MSK cluster. See authentication_configuration block below for details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderMskSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

    /// <summary>The ARN of the Amazon MSK cluster.</summary>
    [JsonPropertyName("mskClusterArn")]
    public string? MskClusterArn { get; set; }

    /// <summary>The start date and time in UTC for the offset position within your MSK topic from where Firehose begins to read. By default, this is set to timestamp when Firehose becomes Active. If you want to create a Firehose stream with Earliest start position set the read_from_timestamp parameter to Epoch (1970-01-01T00:00:00Z).</summary>
    [JsonPropertyName("readFromTimestamp")]
    public string? ReadFromTimestamp { get; set; }

    /// <summary>The topic name within the Amazon MSK cluster.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The method for setting up document ID. See [document_id_options block] below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationDocumentIdOptions
{
    /// <summary>The method for setting up document ID. Valid values: FIREHOSE_DEFAULT, NO_DOCUMENT_ID.</summary>
    [JsonPropertyName("defaultDocumentIdFormat")]
    public string? DefaultDocumentIdFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration. See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to OpenSearch associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>Configuration options when destination is opensearch. See opensearch_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the cluster. Conflicts with domain_arn.</summary>
    [JsonPropertyName("clusterEndpoint")]
    public string? ClusterEndpoint { get; set; }

    /// <summary>The method for setting up document ID. See [document_id_options block] below for details.</summary>
    [JsonPropertyName("documentIdOptions")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationDocumentIdOptions? DocumentIdOptions { get; set; }

    /// <summary>The ARN of the Amazon ES domain.  The pattern needs to be arn:.*.  Conflicts with cluster_endpoint.</summary>
    [JsonPropertyName("domainArn")]
    public string? DomainArn { get; set; }

    /// <summary>The OpenSearch index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The OpenSearch index rotation period.  Index rotation appends a timestamp to the IndexName to facilitate expiration of old data.  Valid values are NoRotation, OneHour, OneDay, OneWeek, and OneMonth.  The default value is OneDay.</summary>
    [JsonPropertyName("indexRotationPeriod")]
    public string? IndexRotationPeriod { get; set; }

    /// <summary>The data processing configuration. See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Amazon OpenSearch, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon ES Configuration API and for indexing documents.  The IAM role must have permission for DescribeDomain, DescribeDomains, and DescribeDomainConfig.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Elasticsearch type name with maximum length of 100 characters. Types are deprecated in OpenSearch_1.1. TypeName must be empty.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to OpenSearch associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The VPC configuration for the delivery stream to connect to OpenSearch Serverless associated with the VPC. See vpc_config block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationVpcConfig
{
    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A list of security group IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs to associate with Kinesis Firehose.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>Configuration options when destination is opensearchserverless. See opensearchserverless_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 300s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 100, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The endpoint to use when communicating with the collection in the Serverless offering for Amazon OpenSearch Service.</summary>
    [JsonPropertyName("collectionEndpoint")]
    public string? CollectionEndpoint { get; set; }

    /// <summary>The Serverless offering for Amazon OpenSearch Service index name.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to the Serverless offering for Amazon OpenSearch Service, the total amount of time, in seconds between 0 to 7200, during which Kinesis Data Firehose retries delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role to be assumed by Kinesis Data Firehose for calling the Serverless offering for Amazon OpenSearch Service Configuration API and for indexing documents.  The pattern needs to be arn:.*.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedDocumentsOnly and AllDocuments.  Default value is FailedDocumentsOnly.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The VPC configuration for the delivery stream to connect to OpenSearch Serverless associated with the VPC. See vpc_config block below for details.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfigurationVpcConfig? VpcConfig { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if username and password are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3BackupConfiguration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is redshift. Requires the user to also specify an s3_configuration block. See redshift_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderRedshiftConfiguration
{
    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The jdbcurl of the redshift cluster.</summary>
    [JsonPropertyName("clusterJdbcurl")]
    public string? ClusterJdbcurl { get; set; }

    /// <summary>Copy options for copying the data from the s3 intermediate bucket into redshift, for example to change the default delimiter. For valid values, see the AWS documentation</summary>
    [JsonPropertyName("copyOptions")]
    public string? CopyOptions { get; set; }

    /// <summary>The data table columns that will be targeted by the copy command.</summary>
    [JsonPropertyName("dataTableColumns")]
    public string? DataTableColumns { get; set; }

    /// <summary>The name of the table in the redshift cluster that the s3 bucket will copy to.</summary>
    [JsonPropertyName("dataTableName")]
    public string? DataTableName { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>The length of time during which Firehose retries delivery after a failure, starting from the initial request and including the first attempt. The default value is 3600 seconds (60 minutes). Firehose does not retry if the value of DurationInSeconds is 0 (zero) or if the first delivery attempt takes longer than the current value.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The arn of the role the stream assumes.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The configuration for backup in Amazon S3. Required if s3_backup_mode is Enabled. Supports the same fields as s3_configuration object. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if username and password are not provided.</summary>
    [JsonPropertyName("s3BackupConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3BackupConfiguration? S3BackupConfiguration { get; set; }

    /// <summary>The Amazon S3 backup mode.  Valid values are Disabled and Enabled.  Default value is Disabled.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The username that the firehose delivery stream will assume. It is strongly recommended that the username and password provided is used exclusively for Amazon Kinesis Firehose purposes, and that the permissions for the account are restricted for Amazon Redshift INSERT permissions. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Encrypt at rest options. See server_side_encryption block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderServerSideEncryption
{
    /// <summary>Whether to enable encryption at rest. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the encryption key. Required when key_type is CUSTOMER_MANAGED_CMK.</summary>
    [JsonPropertyName("keyArn")]
    public string? KeyArn { get; set; }

    /// <summary>Type of encryption key. Default is AWS_OWNED_CMK. Valid values are AWS_OWNED_CMK and CUSTOMER_MANAGED_CMK</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The processing configuration. See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>The configuration for Snowflake role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationSnowflakeRoleConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Snowflake role.</summary>
    [JsonPropertyName("snowflakeRole")]
    public string? SnowflakeRole { get; set; }
}

/// <summary>The VPC configuration for Snowflake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationSnowflakeVpcConfiguration
{
    /// <summary>The VPCE ID for Firehose to privately connect with Snowflake.</summary>
    [JsonPropertyName("privateLinkVpceId")]
    public string? PrivateLinkVpceId { get; set; }
}

/// <summary>Configuration options when destination is snowflake. See snowflake_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSnowflakeConfiguration
{
    /// <summary>The URL of the Snowflake account. Format: https://[account_identifier].snowflakecomputing.com.</summary>
    [JsonPropertyName("accountUrl")]
    public string? AccountUrl { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 900, before delivering it to the destination.  The default value is 0s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 128, before delivering it to the destination.  The default value is 1MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The name of the content column.</summary>
    [JsonPropertyName("contentColumnName")]
    public string? ContentColumnName { get; set; }

    /// <summary>The data loading option.</summary>
    [JsonPropertyName("dataLoadingOption")]
    public string? DataLoadingOption { get; set; }

    /// <summary>The Snowflake database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The name of the metadata column.</summary>
    [JsonPropertyName("metadataColumnName")]
    public string? MetadataColumnName { get; set; }

    /// <summary>The processing configuration. See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Snowflake, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 60s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>The ARN of the IAM role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The S3 backup mode.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Snowflake schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }

    /// <summary>The configuration for Snowflake role.</summary>
    [JsonPropertyName("snowflakeRoleConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationSnowflakeRoleConfiguration? SnowflakeRoleConfiguration { get; set; }

    /// <summary>The VPC configuration for Snowflake.</summary>
    [JsonPropertyName("snowflakeVpcConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfigurationSnowflakeVpcConfiguration? SnowflakeVpcConfiguration { get; set; }

    /// <summary>The Snowflake table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>The user for authentication. This value is required if secrets_manager_configuration is not provided.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationProcessingConfigurationProcessorsParameters
{
    /// <summary>Parameter name. Valid Values: LambdaArn, NumberOfRetries, MetadataExtractionQuery, JsonParsingEngine, RoleArn, BufferSizeInMBs, BufferIntervalInSeconds, SubRecordType, Delimiter, CompressionFormat, DataMessageExtraction. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.</summary>
    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationProcessingConfigurationProcessors
{
    /// <summary>Specifies the processor parameters as multiple blocks. See parameters block below for details.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationProcessingConfigurationProcessorsParameters>? Parameters { get; set; }

    /// <summary>The type of processor. Valid Values: RecordDeAggregation, Lambda, MetadataExtraction, AppendDelimiterToRecord, Decompression, CloudWatchLogProcessing. Validation is done against AWS SDK constants; so values not explicitly listed may also work.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationProcessingConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the data processors as multiple blocks. See processors block below for details.</summary>
    [JsonPropertyName("processors")]
    public IList<V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationProcessingConfigurationProcessors>? Processors { get; set; }
}

/// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationS3ConfigurationCloudwatchLoggingOptions
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The CloudWatch group name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The CloudWatch log stream name for logging. This value is required if enabled is true.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }
}

/// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationS3Configuration
{
    /// <summary>The ARN of the S3 bucket</summary>
    [JsonPropertyName("bucketArn")]
    public string? BucketArn { get; set; }

    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationS3ConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP, Snappy, &amp; HADOOP_SNAPPY.</summary>
    [JsonPropertyName("compressionFormat")]
    public string? CompressionFormat { get; set; }

    /// <summary>Prefix added to failed records before writing them to S3. Not currently supported for redshift destination. This prefix appears immediately following the bucket name. For information about how to specify this prefix, see Custom Prefixes for Amazon S3 Objects.</summary>
    [JsonPropertyName("errorOutputPrefix")]
    public string? ErrorOutputPrefix { get; set; }

    /// <summary>Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will be used.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationSecretsManagerConfiguration
{
    /// <summary>Enables or disables the logging. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ARN of the IAM role to be assumed by Firehose for calling the Amazon EC2 configuration API and for creating network interfaces. Make sure role has necessary IAM permissions</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the Secrets Manager secret. This value is required if enabled is true.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Configuration options when destination is splunk. See splunk_configuration block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProviderSplunkConfiguration
{
    /// <summary>Buffer incoming data for the specified period of time, in seconds between 0 to 60, before delivering it to the destination.  The default value is 60s.</summary>
    [JsonPropertyName("bufferingInterval")]
    public double? BufferingInterval { get; set; }

    /// <summary>Buffer incoming data to the specified size, in MBs between 1 to 5, before delivering it to the destination.  The default value is 5MB.</summary>
    [JsonPropertyName("bufferingSize")]
    public double? BufferingSize { get; set; }

    /// <summary>The CloudWatch Logging Options for the delivery stream. See cloudwatch_logging_options block below for details.</summary>
    [JsonPropertyName("cloudwatchLoggingOptions")]
    public V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationCloudwatchLoggingOptions? CloudwatchLoggingOptions { get; set; }

    /// <summary>The amount of time, in seconds between 180 and 600, that Kinesis Firehose waits to receive an acknowledgment from Splunk after it sends it data.</summary>
    [JsonPropertyName("hecAcknowledgmentTimeout")]
    public double? HecAcknowledgmentTimeout { get; set; }

    /// <summary>The HTTP Event Collector (HEC) endpoint to which Kinesis Firehose sends your data.</summary>
    [JsonPropertyName("hecEndpoint")]
    public string? HecEndpoint { get; set; }

    /// <summary>The HEC endpoint type. Valid values are Raw or Event. The default value is Raw.</summary>
    [JsonPropertyName("hecEndpointType")]
    public string? HecEndpointType { get; set; }

    /// <summary>The data processing configuration.  See processing_configuration block below for details.</summary>
    [JsonPropertyName("processingConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationProcessingConfiguration? ProcessingConfiguration { get; set; }

    /// <summary>After an initial failure to deliver to Splunk, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.</summary>
    [JsonPropertyName("retryDuration")]
    public double? RetryDuration { get; set; }

    /// <summary>Defines how documents should be delivered to Amazon S3.  Valid values are FailedEventsOnly and AllEvents.  Default value is FailedEventsOnly. secrets_manager_configuration -  The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if hec_token is not provided.</summary>
    [JsonPropertyName("s3BackupMode")]
    public string? S3BackupMode { get; set; }

    /// <summary>The S3 Configuration. See s3_configuration block below for details.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationS3Configuration? S3Configuration { get; set; }

    /// <summary>The Secrets Manager configuration. See secrets_manager_configuration block below for details. This value is required if user and private_key are not provided.</summary>
    [JsonPropertyName("secretsManagerConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSplunkConfigurationSecretsManagerConfiguration? SecretsManagerConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) specifying the Stream</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>This is the destination to where the data is delivered. The only options are s3 (Deprecated, use extended_s3 instead), extended_s3, redshift, elasticsearch, splunk, http_endpoint, opensearch, opensearchserverless and snowflake.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>Configuration options when destination is elasticsearch. See elasticsearch_configuration block below for details.</summary>
    [JsonPropertyName("elasticsearchConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderElasticsearchConfiguration? ElasticsearchConfiguration { get; set; }

    /// <summary>Enhanced configuration options for the s3 destination. See extended_s3_configuration block below for details.</summary>
    [JsonPropertyName("extendedS3Configuration")]
    public V1beta1DeliveryStreamStatusAtProviderExtendedS3Configuration? ExtendedS3Configuration { get; set; }

    /// <summary>Configuration options when destination is http_endpoint. Requires the user to also specify an s3_configuration block.  See http_endpoint_configuration block below for details.</summary>
    [JsonPropertyName("httpEndpointConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderHttpEndpointConfiguration? HttpEndpointConfiguration { get; set; }

    /// <summary>Configuration options when destination is iceberg. See iceberg_configuration block below for details.</summary>
    [JsonPropertyName("icebergConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderIcebergConfiguration? IcebergConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The stream and role Amazon Resource Names (ARNs) for a Kinesis data stream used as the source for a delivery stream. See kinesis_source_configuration block below for details.</summary>
    [JsonPropertyName("kinesisSourceConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderKinesisSourceConfiguration? KinesisSourceConfiguration { get; set; }

    /// <summary>The configuration for the Amazon MSK cluster to be used as the source for a delivery stream. See msk_source_configuration block below for details.</summary>
    [JsonPropertyName("mskSourceConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderMskSourceConfiguration? MskSourceConfiguration { get; set; }

    /// <summary>A name to identify the stream. This is unique to the AWS account and region the Stream is created in. When using for WAF logging, name must be prefixed with aws-waf-logs-. See AWS Documentation for more details.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration options when destination is opensearch. See opensearch_configuration block below for details.</summary>
    [JsonPropertyName("opensearchConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchConfiguration? OpensearchConfiguration { get; set; }

    /// <summary>Configuration options when destination is opensearchserverless. See opensearchserverless_configuration block below for details.</summary>
    [JsonPropertyName("opensearchserverlessConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderOpensearchserverlessConfiguration? OpensearchserverlessConfiguration { get; set; }

    /// <summary>Configuration options when destination is redshift. Requires the user to also specify an s3_configuration block. See redshift_configuration block below for details.</summary>
    [JsonPropertyName("redshiftConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderRedshiftConfiguration? RedshiftConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Encrypt at rest options. See server_side_encryption block below for details.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public V1beta1DeliveryStreamStatusAtProviderServerSideEncryption? ServerSideEncryption { get; set; }

    /// <summary>Configuration options when destination is snowflake. See snowflake_configuration block below for details.</summary>
    [JsonPropertyName("snowflakeConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSnowflakeConfiguration? SnowflakeConfiguration { get; set; }

    /// <summary>Configuration options when destination is splunk. See splunk_configuration block below for details.</summary>
    [JsonPropertyName("splunkConfiguration")]
    public V1beta1DeliveryStreamStatusAtProviderSplunkConfiguration? SplunkConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Specifies the table version for the output data schema. Defaults to LATEST.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatusConditions
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

/// <summary>DeliveryStreamStatus defines the observed state of DeliveryStream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DeliveryStreamStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DeliveryStreamStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DeliveryStreamStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DeliveryStream is the Schema for the DeliveryStreams API. Provides a AWS Kinesis Firehose Delivery Stream</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DeliveryStream : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DeliveryStreamSpec>, IStatus<V1beta1DeliveryStreamStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeliveryStream";
    public const string KubeGroup = "firehose.aws.m.upbound.io";
    public const string KubePluralName = "deliverystreams";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeliveryStreamSpec defines the desired state of DeliveryStream</summary>
    [JsonPropertyName("spec")]
    public V1beta1DeliveryStreamSpec Spec { get; set; }

    /// <summary>DeliveryStreamStatus defines the observed state of DeliveryStream.</summary>
    [JsonPropertyName("status")]
    public V1beta1DeliveryStreamStatus? Status { get; set; }
}

/// <summary>DeliveryStream is the Schema for the DeliveryStreams API. Provides a AWS Kinesis Firehose Delivery Stream</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DeliveryStreamList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DeliveryStream>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DeliveryStreamList";
    public const string KubeGroup = "firehose.aws.m.upbound.io";
    public const string KubePluralName = "deliverystreams";
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
    public IList<V1beta1DeliveryStream> Items { get; set; }
}