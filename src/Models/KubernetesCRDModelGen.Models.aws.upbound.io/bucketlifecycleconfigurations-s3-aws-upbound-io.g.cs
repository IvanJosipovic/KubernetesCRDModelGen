using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
/// <summary>BucketLifecycleConfiguration is the Schema for the BucketLifecycleConfigurations API. Provides a S3 bucket lifecycle configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketLifecycleConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BucketLifecycleConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketLifecycleConfigurationList";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketlifecycleconfigurations";
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
    public IList<V1beta1BucketLifecycleConfiguration> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLifecycleConfigurationSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLifecycleConfigurationSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleAbortIncompleteMultipartUpload
{
    /// <summary>Number of days after which Amazon S3 aborts an incomplete multipart upload.</summary>
    [JsonPropertyName("daysAfterInitiation")]
    public double? DaysAfterInitiation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleExpiration
{
    /// <summary>Date objects are transitioned to the specified storage class. The date value must be in RFC3339 full-date format e.g. 2023-08-22.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Number of days after creation when objects are transitioned to the specified storage class. The value must be a positive integer. If both days and date are not specified, defaults to 0. Valid values depend on storage_class, see Transition objects using Amazon S3 Lifecycle for more details.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions. If set to true, the delete marker will be expired; if set to false the policy takes no action.</summary>
    [JsonPropertyName("expiredObjectDeleteMarker")]
    public bool? ExpiredObjectDeleteMarker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleFilterAnd
{
    /// <summary>Minimum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeGreaterThan")]
    public double? ObjectSizeGreaterThan { get; set; }

    /// <summary>Maximum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeLessThan")]
    public double? ObjectSizeLessThan { get; set; }

    /// <summary>Prefix identifying one or more objects to which the rule applies.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Key-value map of resource tags. All of these tags must exist in the object's tag set in order for the rule to apply. If set, must contain at least one key-value pair.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleFilterTag
{
    /// <summary>Name of the object key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of the tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleFilter
{
    /// <summary>Configuration block used to apply a logical AND to two or more predicates. See below. The Lifecycle Rule will apply to any object matching all the predicates configured inside the and block.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleFilterAnd>? And { get; set; }

    /// <summary>Minimum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeGreaterThan")]
    public double? ObjectSizeGreaterThan { get; set; }

    /// <summary>Maximum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeLessThan")]
    public double? ObjectSizeLessThan { get; set; }

    /// <summary>Prefix identifying one or more objects to which the rule applies. Defaults to an empty string ("") if not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleFilterTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleNoncurrentVersionExpiration
{
    /// <summary>Number of noncurrent versions Amazon S3 will retain. Must be a non-zero positive integer.</summary>
    [JsonPropertyName("newerNoncurrentVersions")]
    public double? NewerNoncurrentVersions { get; set; }

    /// <summary>Number of days an object is noncurrent before Amazon S3 can perform the associated action.</summary>
    [JsonPropertyName("noncurrentDays")]
    public double? NoncurrentDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleNoncurrentVersionTransition
{
    /// <summary>Number of noncurrent versions Amazon S3 will retain. Must be a non-zero positive integer.</summary>
    [JsonPropertyName("newerNoncurrentVersions")]
    public double? NewerNoncurrentVersions { get; set; }

    /// <summary>Number of days an object is noncurrent before Amazon S3 can perform the associated action.</summary>
    [JsonPropertyName("noncurrentDays")]
    public double? NoncurrentDays { get; set; }

    /// <summary>Class of storage used to store the object. Valid Values: GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, GLACIER_IR.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRuleTransition
{
    /// <summary>Date objects are transitioned to the specified storage class. The date value must be in RFC3339 full-date format e.g. 2023-08-22.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Number of days after creation when objects are transitioned to the specified storage class. The value must be a positive integer. If both days and date are not specified, defaults to 0. Valid values depend on storage_class, see Transition objects using Amazon S3 Lifecycle for more details.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Class of storage used to store the object. Valid Values: GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, GLACIER_IR.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProviderRule
{
    /// <summary>Configuration block that specifies the days since the initiation of an incomplete multipart upload that Amazon S3 will wait before permanently removing all parts of the upload. See below.</summary>
    [JsonPropertyName("abortIncompleteMultipartUpload")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleAbortIncompleteMultipartUpload>? AbortIncompleteMultipartUpload { get; set; }

    /// <summary>Configuration block that specifies the expiration for the lifecycle of the object in the form of date, days and, whether the object has a delete marker. See below.</summary>
    [JsonPropertyName("expiration")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleExpiration>? Expiration { get; set; }

    /// <summary>Configuration block used to identify objects that a Lifecycle Rule applies to. See below. If not specified, the rule will default to using prefix. One of filter or prefix should be specified.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleFilter>? Filter { get; set; }

    /// <summary>Unique identifier for the rule. The value cannot be longer than 255 characters.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block that specifies when noncurrent object versions expire. See below.</summary>
    [JsonPropertyName("noncurrentVersionExpiration")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleNoncurrentVersionExpiration>? NoncurrentVersionExpiration { get; set; }

    /// <summary>Set of configuration blocks that specify the transition rule for the lifecycle rule that describes when noncurrent objects transition to a specific storage class. See below.</summary>
    [JsonPropertyName("noncurrentVersionTransition")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleNoncurrentVersionTransition>? NoncurrentVersionTransition { get; set; }

    /// <summary>DEPRECATED Use filter instead. This has been deprecated by Amazon S3. Prefix identifying one or more objects to which the rule applies. Defaults to an empty string ("") if filter is not specified. One of prefix or filter should be specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Whether the rule is currently being applied. Valid values: Enabled or Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Set of configuration blocks that specify when an Amazon S3 object transitions to a specified storage class. See below.</summary>
    [JsonPropertyName("transition")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRuleTransition>? Transition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecForProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketLifecycleConfigurationSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketLifecycleConfigurationSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner. If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketLifecycleConfigurationSpecForProviderRule>? Rule { get; set; }

    /// <summary>The default minimum object size behavior applied to the lifecycle configuration. Valid values: all_storage_classes_128K (default), varies_by_storage_class. To customize the minimum object size for any transition you can add a filter that specifies a custom object_size_greater_than or object_size_less_than value. Custom filters always take precedence over the default transition behavior.</summary>
    [JsonPropertyName("transitionDefaultMinimumObjectSize")]
    public string? TransitionDefaultMinimumObjectSize { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLifecycleConfigurationSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLifecycleConfigurationSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleAbortIncompleteMultipartUpload
{
    /// <summary>Number of days after which Amazon S3 aborts an incomplete multipart upload.</summary>
    [JsonPropertyName("daysAfterInitiation")]
    public double? DaysAfterInitiation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleExpiration
{
    /// <summary>Date objects are transitioned to the specified storage class. The date value must be in RFC3339 full-date format e.g. 2023-08-22.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Number of days after creation when objects are transitioned to the specified storage class. The value must be a positive integer. If both days and date are not specified, defaults to 0. Valid values depend on storage_class, see Transition objects using Amazon S3 Lifecycle for more details.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions. If set to true, the delete marker will be expired; if set to false the policy takes no action.</summary>
    [JsonPropertyName("expiredObjectDeleteMarker")]
    public bool? ExpiredObjectDeleteMarker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleFilterAnd
{
    /// <summary>Minimum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeGreaterThan")]
    public double? ObjectSizeGreaterThan { get; set; }

    /// <summary>Maximum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeLessThan")]
    public double? ObjectSizeLessThan { get; set; }

    /// <summary>Prefix identifying one or more objects to which the rule applies.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Key-value map of resource tags. All of these tags must exist in the object's tag set in order for the rule to apply. If set, must contain at least one key-value pair.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleFilterTag
{
    /// <summary>Name of the object key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of the tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleFilter
{
    /// <summary>Configuration block used to apply a logical AND to two or more predicates. See below. The Lifecycle Rule will apply to any object matching all the predicates configured inside the and block.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleFilterAnd>? And { get; set; }

    /// <summary>Minimum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeGreaterThan")]
    public double? ObjectSizeGreaterThan { get; set; }

    /// <summary>Maximum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeLessThan")]
    public double? ObjectSizeLessThan { get; set; }

    /// <summary>Prefix identifying one or more objects to which the rule applies. Defaults to an empty string ("") if not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleFilterTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleNoncurrentVersionExpiration
{
    /// <summary>Number of noncurrent versions Amazon S3 will retain. Must be a non-zero positive integer.</summary>
    [JsonPropertyName("newerNoncurrentVersions")]
    public double? NewerNoncurrentVersions { get; set; }

    /// <summary>Number of days an object is noncurrent before Amazon S3 can perform the associated action.</summary>
    [JsonPropertyName("noncurrentDays")]
    public double? NoncurrentDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleNoncurrentVersionTransition
{
    /// <summary>Number of noncurrent versions Amazon S3 will retain. Must be a non-zero positive integer.</summary>
    [JsonPropertyName("newerNoncurrentVersions")]
    public double? NewerNoncurrentVersions { get; set; }

    /// <summary>Number of days an object is noncurrent before Amazon S3 can perform the associated action.</summary>
    [JsonPropertyName("noncurrentDays")]
    public double? NoncurrentDays { get; set; }

    /// <summary>Class of storage used to store the object. Valid Values: GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, GLACIER_IR.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRuleTransition
{
    /// <summary>Date objects are transitioned to the specified storage class. The date value must be in RFC3339 full-date format e.g. 2023-08-22.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Number of days after creation when objects are transitioned to the specified storage class. The value must be a positive integer. If both days and date are not specified, defaults to 0. Valid values depend on storage_class, see Transition objects using Amazon S3 Lifecycle for more details.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Class of storage used to store the object. Valid Values: GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, GLACIER_IR.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProviderRule
{
    /// <summary>Configuration block that specifies the days since the initiation of an incomplete multipart upload that Amazon S3 will wait before permanently removing all parts of the upload. See below.</summary>
    [JsonPropertyName("abortIncompleteMultipartUpload")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleAbortIncompleteMultipartUpload>? AbortIncompleteMultipartUpload { get; set; }

    /// <summary>Configuration block that specifies the expiration for the lifecycle of the object in the form of date, days and, whether the object has a delete marker. See below.</summary>
    [JsonPropertyName("expiration")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleExpiration>? Expiration { get; set; }

    /// <summary>Configuration block used to identify objects that a Lifecycle Rule applies to. See below. If not specified, the rule will default to using prefix. One of filter or prefix should be specified.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleFilter>? Filter { get; set; }

    /// <summary>Unique identifier for the rule. The value cannot be longer than 255 characters.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block that specifies when noncurrent object versions expire. See below.</summary>
    [JsonPropertyName("noncurrentVersionExpiration")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleNoncurrentVersionExpiration>? NoncurrentVersionExpiration { get; set; }

    /// <summary>Set of configuration blocks that specify the transition rule for the lifecycle rule that describes when noncurrent objects transition to a specific storage class. See below.</summary>
    [JsonPropertyName("noncurrentVersionTransition")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleNoncurrentVersionTransition>? NoncurrentVersionTransition { get; set; }

    /// <summary>DEPRECATED Use filter instead. This has been deprecated by Amazon S3. Prefix identifying one or more objects to which the rule applies. Defaults to an empty string ("") if filter is not specified. One of prefix or filter should be specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Whether the rule is currently being applied. Valid values: Enabled or Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Set of configuration blocks that specify when an Amazon S3 object transitions to a specified storage class. See below.</summary>
    [JsonPropertyName("transition")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRuleTransition>? Transition { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecInitProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketLifecycleConfigurationSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketLifecycleConfigurationSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner. If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketLifecycleConfigurationSpecInitProviderRule>? Rule { get; set; }

    /// <summary>The default minimum object size behavior applied to the lifecycle configuration. Valid values: all_storage_classes_128K (default), varies_by_storage_class. To customize the minimum object size for any transition you can add a filter that specifies a custom object_size_greater_than or object_size_less_than value. Custom filters always take precedence over the default transition behavior.</summary>
    [JsonPropertyName("transitionDefaultMinimumObjectSize")]
    public string? TransitionDefaultMinimumObjectSize { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecProviderConfigRefPolicy
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
public partial class V1beta1BucketLifecycleConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLifecycleConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BucketLifecycleConfigurationSpec defines the desired state of BucketLifecycleConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketLifecycleConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketLifecycleConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketLifecycleConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketLifecycleConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleAbortIncompleteMultipartUpload
{
    /// <summary>Number of days after which Amazon S3 aborts an incomplete multipart upload.</summary>
    [JsonPropertyName("daysAfterInitiation")]
    public double? DaysAfterInitiation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleExpiration
{
    /// <summary>Date objects are transitioned to the specified storage class. The date value must be in RFC3339 full-date format e.g. 2023-08-22.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Number of days after creation when objects are transitioned to the specified storage class. The value must be a positive integer. If both days and date are not specified, defaults to 0. Valid values depend on storage_class, see Transition objects using Amazon S3 Lifecycle for more details.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Indicates whether Amazon S3 will remove a delete marker with no noncurrent versions. If set to true, the delete marker will be expired; if set to false the policy takes no action.</summary>
    [JsonPropertyName("expiredObjectDeleteMarker")]
    public bool? ExpiredObjectDeleteMarker { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleFilterAnd
{
    /// <summary>Minimum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeGreaterThan")]
    public double? ObjectSizeGreaterThan { get; set; }

    /// <summary>Maximum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeLessThan")]
    public double? ObjectSizeLessThan { get; set; }

    /// <summary>Prefix identifying one or more objects to which the rule applies.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Key-value map of resource tags. All of these tags must exist in the object's tag set in order for the rule to apply. If set, must contain at least one key-value pair.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleFilterTag
{
    /// <summary>Name of the object key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value of the tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleFilter
{
    /// <summary>Configuration block used to apply a logical AND to two or more predicates. See below. The Lifecycle Rule will apply to any object matching all the predicates configured inside the and block.</summary>
    [JsonPropertyName("and")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleFilterAnd>? And { get; set; }

    /// <summary>Minimum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeGreaterThan")]
    public double? ObjectSizeGreaterThan { get; set; }

    /// <summary>Maximum object size (in bytes) to which the rule applies.</summary>
    [JsonPropertyName("objectSizeLessThan")]
    public double? ObjectSizeLessThan { get; set; }

    /// <summary>Prefix identifying one or more objects to which the rule applies. Defaults to an empty string ("") if not specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Configuration block for specifying a tag key and value. See below.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleFilterTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleNoncurrentVersionExpiration
{
    /// <summary>Number of noncurrent versions Amazon S3 will retain. Must be a non-zero positive integer.</summary>
    [JsonPropertyName("newerNoncurrentVersions")]
    public double? NewerNoncurrentVersions { get; set; }

    /// <summary>Number of days an object is noncurrent before Amazon S3 can perform the associated action.</summary>
    [JsonPropertyName("noncurrentDays")]
    public double? NoncurrentDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleNoncurrentVersionTransition
{
    /// <summary>Number of noncurrent versions Amazon S3 will retain. Must be a non-zero positive integer.</summary>
    [JsonPropertyName("newerNoncurrentVersions")]
    public double? NewerNoncurrentVersions { get; set; }

    /// <summary>Number of days an object is noncurrent before Amazon S3 can perform the associated action.</summary>
    [JsonPropertyName("noncurrentDays")]
    public double? NoncurrentDays { get; set; }

    /// <summary>Class of storage used to store the object. Valid Values: GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, GLACIER_IR.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRuleTransition
{
    /// <summary>Date objects are transitioned to the specified storage class. The date value must be in RFC3339 full-date format e.g. 2023-08-22.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Number of days after creation when objects are transitioned to the specified storage class. The value must be a positive integer. If both days and date are not specified, defaults to 0. Valid values depend on storage_class, see Transition objects using Amazon S3 Lifecycle for more details.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Class of storage used to store the object. Valid Values: GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, GLACIER_IR.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProviderRule
{
    /// <summary>Configuration block that specifies the days since the initiation of an incomplete multipart upload that Amazon S3 will wait before permanently removing all parts of the upload. See below.</summary>
    [JsonPropertyName("abortIncompleteMultipartUpload")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleAbortIncompleteMultipartUpload>? AbortIncompleteMultipartUpload { get; set; }

    /// <summary>Configuration block that specifies the expiration for the lifecycle of the object in the form of date, days and, whether the object has a delete marker. See below.</summary>
    [JsonPropertyName("expiration")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleExpiration>? Expiration { get; set; }

    /// <summary>Configuration block used to identify objects that a Lifecycle Rule applies to. See below. If not specified, the rule will default to using prefix. One of filter or prefix should be specified.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleFilter>? Filter { get; set; }

    /// <summary>Unique identifier for the rule. The value cannot be longer than 255 characters.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block that specifies when noncurrent object versions expire. See below.</summary>
    [JsonPropertyName("noncurrentVersionExpiration")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleNoncurrentVersionExpiration>? NoncurrentVersionExpiration { get; set; }

    /// <summary>Set of configuration blocks that specify the transition rule for the lifecycle rule that describes when noncurrent objects transition to a specific storage class. See below.</summary>
    [JsonPropertyName("noncurrentVersionTransition")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleNoncurrentVersionTransition>? NoncurrentVersionTransition { get; set; }

    /// <summary>DEPRECATED Use filter instead. This has been deprecated by Amazon S3. Prefix identifying one or more objects to which the rule applies. Defaults to an empty string ("") if filter is not specified. One of prefix or filter should be specified.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Whether the rule is currently being applied. Valid values: Enabled or Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Set of configuration blocks that specify when an Amazon S3 object transitions to a specified storage class. See below.</summary>
    [JsonPropertyName("transition")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRuleTransition>? Transition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusAtProvider
{
    /// <summary>Name of the source S3 bucket you want Amazon S3 to monitor.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Account ID of the expected bucket owner. If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>and status)</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>List of configuration blocks describing the rules managing the replication. See below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketLifecycleConfigurationStatusAtProviderRule>? Rule { get; set; }

    /// <summary>The default minimum object size behavior applied to the lifecycle configuration. Valid values: all_storage_classes_128K (default), varies_by_storage_class. To customize the minimum object size for any transition you can add a filter that specifies a custom object_size_greater_than or object_size_less_than value. Custom filters always take precedence over the default transition behavior.</summary>
    [JsonPropertyName("transitionDefaultMinimumObjectSize")]
    public string? TransitionDefaultMinimumObjectSize { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatusConditions
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

/// <summary>BucketLifecycleConfigurationStatus defines the observed state of BucketLifecycleConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketLifecycleConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketLifecycleConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketLifecycleConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BucketLifecycleConfiguration is the Schema for the BucketLifecycleConfigurations API. Provides a S3 bucket lifecycle configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketLifecycleConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketLifecycleConfigurationSpec>, IStatus<V1beta1BucketLifecycleConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketLifecycleConfiguration";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketlifecycleconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketLifecycleConfigurationSpec defines the desired state of BucketLifecycleConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketLifecycleConfigurationSpec Spec { get; set; }

    /// <summary>BucketLifecycleConfigurationStatus defines the observed state of BucketLifecycleConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketLifecycleConfigurationStatus? Status { get; set; }
}