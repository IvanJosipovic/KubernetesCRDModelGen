using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3control.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelActivityMetrics
{
    /// <summary>Whether the activity metrics are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria
{
    /// <summary>The delimiter of the selection criteria being used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>The max depth of the selection criteria.</summary>
    [JsonPropertyName("maxDepth")]
    public double? MaxDepth { get; set; }

    /// <summary>The minimum number of storage bytes percentage whose metrics will be selected.</summary>
    [JsonPropertyName("minStorageBytesPercentage")]
    public double? MinStorageBytesPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
    [JsonPropertyName("selectionCriteria")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria>? SelectionCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel
{
    /// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
    [JsonPropertyName("storageMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics>? StorageMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics>? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics>? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics>? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics>? DetailedStatusCodeMetrics { get; set; }

    /// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
    [JsonPropertyName("prefixLevel")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel>? PrefixLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelActivityMetrics>? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics>? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics>? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>level configuration. See Bucket Level below for more details.</summary>
    [JsonPropertyName("bucketLevel")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevel>? BucketLevel { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics>? DetailedStatusCodeMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAwsOrg
{
    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportCloudWatchMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms
{
    /// <summary>KMS key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption
{
    /// <summary>KMS encryption. See SSE KMS below for more details.</summary>
    [JsonPropertyName("sseKms")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms>? SseKms { get; set; }

    /// <summary>S3 encryption. An empty configuration block {} should be used.</summary>
    [JsonPropertyName("sseS3")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3>? SseS3 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestination
{
    /// <summary>The account ID of the owner of the S3 Storage Lens metrics export bucket.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector? ArnSelector { get; set; }

    /// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption>? Encryption { get; set; }

    /// <summary>The export format. Valid values: CSV, Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The schema version of the export file. Valid values: V_1.</summary>
    [JsonPropertyName("outputSchemaVersion")]
    public string? OutputSchemaVersion { get; set; }

    /// <summary>The prefix of the destination bucket where the metrics export will be delivered.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExport
{
    /// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
    [JsonPropertyName("cloudWatchMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportCloudWatchMetrics>? CloudWatchMetrics { get; set; }

    /// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
    [JsonPropertyName("s3BucketDestination")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestination>? S3BucketDestination { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>References to Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsRefs")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefs>? BucketsRefs { get; set; }

    /// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsSelector")]
    public V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelector? BucketsSelector { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationInclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProviderStorageLensConfiguration
{
    /// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
    [JsonPropertyName("accountLevel")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevel>? AccountLevel { get; set; }

    /// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
    [JsonPropertyName("awsOrg")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationAwsOrg>? AwsOrg { get; set; }

    /// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
    [JsonPropertyName("dataExport")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExport>? DataExport { get; set; }

    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
    [JsonPropertyName("exclude")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationExclude>? Exclude { get; set; }

    /// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
    [JsonPropertyName("include")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfigurationInclude>? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecForProvider
{
    /// <summary>The AWS account ID for the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The ID of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
    [JsonPropertyName("storageLensConfiguration")]
    public IList<V1beta1StorageLensConfigurationSpecForProviderStorageLensConfiguration>? StorageLensConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelActivityMetrics
{
    /// <summary>Whether the activity metrics are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria
{
    /// <summary>The delimiter of the selection criteria being used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>The max depth of the selection criteria.</summary>
    [JsonPropertyName("maxDepth")]
    public double? MaxDepth { get; set; }

    /// <summary>The minimum number of storage bytes percentage whose metrics will be selected.</summary>
    [JsonPropertyName("minStorageBytesPercentage")]
    public double? MinStorageBytesPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
    [JsonPropertyName("selectionCriteria")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria>? SelectionCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel
{
    /// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
    [JsonPropertyName("storageMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics>? StorageMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics>? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics>? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics>? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics>? DetailedStatusCodeMetrics { get; set; }

    /// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
    [JsonPropertyName("prefixLevel")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel>? PrefixLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelActivityMetrics>? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics>? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics>? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>level configuration. See Bucket Level below for more details.</summary>
    [JsonPropertyName("bucketLevel")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevel>? BucketLevel { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics>? DetailedStatusCodeMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAwsOrg
{
    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportCloudWatchMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms
{
    /// <summary>KMS key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption
{
    /// <summary>KMS encryption. See SSE KMS below for more details.</summary>
    [JsonPropertyName("sseKms")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms>? SseKms { get; set; }

    /// <summary>S3 encryption. An empty configuration block {} should be used.</summary>
    [JsonPropertyName("sseS3")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3>? SseS3 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestination
{
    /// <summary>The account ID of the owner of the S3 Storage Lens metrics export bucket.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector? ArnSelector { get; set; }

    /// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption>? Encryption { get; set; }

    /// <summary>The export format. Valid values: CSV, Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The schema version of the export file. Valid values: V_1.</summary>
    [JsonPropertyName("outputSchemaVersion")]
    public string? OutputSchemaVersion { get; set; }

    /// <summary>The prefix of the destination bucket where the metrics export will be delivered.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExport
{
    /// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
    [JsonPropertyName("cloudWatchMetrics")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportCloudWatchMetrics>? CloudWatchMetrics { get; set; }

    /// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
    [JsonPropertyName("s3BucketDestination")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestination>? S3BucketDestination { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>References to Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsRefs")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefs>? BucketsRefs { get; set; }

    /// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsSelector")]
    public V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelector? BucketsSelector { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationInclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfiguration
{
    /// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
    [JsonPropertyName("accountLevel")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevel>? AccountLevel { get; set; }

    /// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
    [JsonPropertyName("awsOrg")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationAwsOrg>? AwsOrg { get; set; }

    /// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
    [JsonPropertyName("dataExport")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExport>? DataExport { get; set; }

    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
    [JsonPropertyName("exclude")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationExclude>? Exclude { get; set; }

    /// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
    [JsonPropertyName("include")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfigurationInclude>? Include { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecInitProvider
{
    /// <summary>The AWS account ID for the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The ID of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
    [JsonPropertyName("storageLensConfiguration")]
    public IList<V1beta1StorageLensConfigurationSpecInitProviderStorageLensConfiguration>? StorageLensConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecProviderConfigRefPolicy
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
public partial class V1beta1StorageLensConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StorageLensConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>StorageLensConfigurationSpec defines the desired state of StorageLensConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StorageLensConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StorageLensConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StorageLensConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StorageLensConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelActivityMetrics
{
    /// <summary>Whether the activity metrics are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria
{
    /// <summary>The delimiter of the selection criteria being used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>The max depth of the selection criteria.</summary>
    [JsonPropertyName("maxDepth")]
    public double? MaxDepth { get; set; }

    /// <summary>The minimum number of storage bytes percentage whose metrics will be selected.</summary>
    [JsonPropertyName("minStorageBytesPercentage")]
    public double? MinStorageBytesPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
    [JsonPropertyName("selectionCriteria")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria>? SelectionCriteria { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel
{
    /// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
    [JsonPropertyName("storageMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics>? StorageMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics>? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics>? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics>? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics>? DetailedStatusCodeMetrics { get; set; }

    /// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
    [JsonPropertyName("prefixLevel")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel>? PrefixLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelActivityMetrics>? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics>? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics>? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>level configuration. See Bucket Level below for more details.</summary>
    [JsonPropertyName("bucketLevel")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevel>? BucketLevel { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics>? DetailedStatusCodeMetrics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAwsOrg
{
    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportCloudWatchMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms
{
    /// <summary>KMS key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption
{
    /// <summary>KMS encryption. See SSE KMS below for more details.</summary>
    [JsonPropertyName("sseKms")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms>? SseKms { get; set; }

    /// <summary>S3 encryption. An empty configuration block {} should be used.</summary>
    [JsonPropertyName("sseS3")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3>? SseS3 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestination
{
    /// <summary>The account ID of the owner of the S3 Storage Lens metrics export bucket.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption>? Encryption { get; set; }

    /// <summary>The export format. Valid values: CSV, Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The schema version of the export file. Valid values: V_1.</summary>
    [JsonPropertyName("outputSchemaVersion")]
    public string? OutputSchemaVersion { get; set; }

    /// <summary>The prefix of the destination bucket where the metrics export will be delivered.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExport
{
    /// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
    [JsonPropertyName("cloudWatchMetrics")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportCloudWatchMetrics>? CloudWatchMetrics { get; set; }

    /// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
    [JsonPropertyName("s3BucketDestination")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestination>? S3BucketDestination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationExclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationInclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfiguration
{
    /// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
    [JsonPropertyName("accountLevel")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevel>? AccountLevel { get; set; }

    /// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
    [JsonPropertyName("awsOrg")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationAwsOrg>? AwsOrg { get; set; }

    /// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
    [JsonPropertyName("dataExport")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExport>? DataExport { get; set; }

    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
    [JsonPropertyName("exclude")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationExclude>? Exclude { get; set; }

    /// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
    [JsonPropertyName("include")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfigurationInclude>? Include { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusAtProvider
{
    /// <summary>The AWS account ID for the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
    [JsonPropertyName("storageLensConfiguration")]
    public IList<V1beta1StorageLensConfigurationStatusAtProviderStorageLensConfiguration>? StorageLensConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatusConditions
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

/// <summary>StorageLensConfigurationStatus defines the observed state of StorageLensConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageLensConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StorageLensConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageLensConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StorageLensConfiguration is the Schema for the StorageLensConfigurations API. Provides a resource to manage an S3 Storage Lens configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageLensConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageLensConfigurationSpec>, IStatus<V1beta1StorageLensConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageLensConfiguration";
    public const string KubeGroup = "s3control.aws.upbound.io";
    public const string KubePluralName = "storagelensconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StorageLensConfigurationSpec defines the desired state of StorageLensConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1StorageLensConfigurationSpec Spec { get; set; }

    /// <summary>StorageLensConfigurationStatus defines the observed state of StorageLensConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1StorageLensConfigurationStatus? Status { get; set; }
}

/// <summary>StorageLensConfiguration is the Schema for the StorageLensConfigurations API. Provides a resource to manage an S3 Storage Lens configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageLensConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StorageLensConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageLensConfigurationList";
    public const string KubeGroup = "s3control.aws.upbound.io";
    public const string KubePluralName = "storagelensconfigurations";
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
    public IList<V1beta1StorageLensConfiguration> Items { get; set; }
}