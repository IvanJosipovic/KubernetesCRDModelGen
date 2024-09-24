using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
public enum V1beta1BucketLoggingSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1BucketLoggingSpecForProviderBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecForProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketLoggingSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecForProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderBucketRefPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecForProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketLoggingSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecForProviderBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketLoggingSpecForProviderBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecForProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketLoggingSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecForProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecForProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketLoggingSpecForProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate targetBucket.</summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecForProviderTargetBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate targetBucket.</summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecForProviderTargetBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetGrantGrantee
{
    /// <summary>Email address of the grantee. See Regions and Endpoints for supported AWS regions where this argument can be specified.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>Canonical user ID of the grantee.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of grantee. Valid values: CanonicalUser, AmazonCustomerByEmail, Group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetGrant
{
    /// <summary>Configuration block for the person being granted permissions. See below.</summary>
    [JsonPropertyName("grantee")]
    public IList<V1beta1BucketLoggingSpecForProviderTargetGrantGrantee>? Grantee { get; set; }

    /// <summary>Logging permissions assigned to the grantee for the bucket. Valid values: FULL_CONTROL, READ, WRITE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetObjectKeyFormatPartitionedPrefix
{
    /// <summary>Specifies the partition date source for the partitioned prefix. Valid values: EventTime, DeliveryTime.</summary>
    [JsonPropertyName("partitionDateSource")]
    public string? PartitionDateSource { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetObjectKeyFormatSimplePrefix
{
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecForProviderTargetObjectKeyFormat
{
    /// <summary>Partitioned S3 key for log objects. See below.</summary>
    [JsonPropertyName("partitionedPrefix")]
    public IList<V1beta1BucketLoggingSpecForProviderTargetObjectKeyFormatPartitionedPrefix>? PartitionedPrefix { get; set; }

    /// <summary>Use the simple format for S3 keys for log objects. To use, set simple_prefix {}.</summary>
    [JsonPropertyName("simplePrefix")]
    public IList<V1beta1BucketLoggingSpecForProviderTargetObjectKeyFormatSimplePrefix>? SimplePrefix { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecForProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketLoggingSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketLoggingSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Name of the bucket where you want Amazon S3 to store server access logs.</summary>
    [JsonPropertyName("targetBucket")]
    public string? TargetBucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate targetBucket.</summary>
    [JsonPropertyName("targetBucketRef")]
    public V1beta1BucketLoggingSpecForProviderTargetBucketRef? TargetBucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate targetBucket.</summary>
    [JsonPropertyName("targetBucketSelector")]
    public V1beta1BucketLoggingSpecForProviderTargetBucketSelector? TargetBucketSelector { get; set; }

    /// <summary>Set of configuration blocks with information for granting permissions. See below.</summary>
    [JsonPropertyName("targetGrant")]
    public IList<V1beta1BucketLoggingSpecForProviderTargetGrant>? TargetGrant { get; set; }

    /// <summary>Amazon S3 key format for log objects. See below.</summary>
    [JsonPropertyName("targetObjectKeyFormat")]
    public IList<V1beta1BucketLoggingSpecForProviderTargetObjectKeyFormat>? TargetObjectKeyFormat { get; set; }

    /// <summary>Prefix for all log object keys.</summary>
    [JsonPropertyName("targetPrefix")]
    public string? TargetPrefix { get; set; }
}

public enum V1beta1BucketLoggingSpecInitProviderBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecInitProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecInitProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderBucketRefPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecInitProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate targetBucket.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate targetBucket.</summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetGrantGrantee
{
    /// <summary>Email address of the grantee. See Regions and Endpoints for supported AWS regions where this argument can be specified.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>Canonical user ID of the grantee.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of grantee. Valid values: CanonicalUser, AmazonCustomerByEmail, Group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetGrant
{
    /// <summary>Configuration block for the person being granted permissions. See below.</summary>
    [JsonPropertyName("grantee")]
    public IList<V1beta1BucketLoggingSpecInitProviderTargetGrantGrantee>? Grantee { get; set; }

    /// <summary>Logging permissions assigned to the grantee for the bucket. Valid values: FULL_CONTROL, READ, WRITE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetObjectKeyFormatPartitionedPrefix
{
    /// <summary>Specifies the partition date source for the partitioned prefix. Valid values: EventTime, DeliveryTime.</summary>
    [JsonPropertyName("partitionDateSource")]
    public string? PartitionDateSource { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetObjectKeyFormatSimplePrefix
{
}

/// <summary></summary>
public partial class V1beta1BucketLoggingSpecInitProviderTargetObjectKeyFormat
{
    /// <summary>Partitioned S3 key for log objects. See below.</summary>
    [JsonPropertyName("partitionedPrefix")]
    public IList<V1beta1BucketLoggingSpecInitProviderTargetObjectKeyFormatPartitionedPrefix>? PartitionedPrefix { get; set; }

    /// <summary>Use the simple format for S3 keys for log objects. To use, set simple_prefix {}.</summary>
    [JsonPropertyName("simplePrefix")]
    public IList<V1beta1BucketLoggingSpecInitProviderTargetObjectKeyFormatSimplePrefix>? SimplePrefix { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1BucketLoggingSpecInitProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketLoggingSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketLoggingSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Name of the bucket where you want Amazon S3 to store server access logs.</summary>
    [JsonPropertyName("targetBucket")]
    public string? TargetBucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate targetBucket.</summary>
    [JsonPropertyName("targetBucketRef")]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketRef? TargetBucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate targetBucket.</summary>
    [JsonPropertyName("targetBucketSelector")]
    public V1beta1BucketLoggingSpecInitProviderTargetBucketSelector? TargetBucketSelector { get; set; }

    /// <summary>Set of configuration blocks with information for granting permissions. See below.</summary>
    [JsonPropertyName("targetGrant")]
    public IList<V1beta1BucketLoggingSpecInitProviderTargetGrant>? TargetGrant { get; set; }

    /// <summary>Amazon S3 key format for log objects. See below.</summary>
    [JsonPropertyName("targetObjectKeyFormat")]
    public IList<V1beta1BucketLoggingSpecInitProviderTargetObjectKeyFormat>? TargetObjectKeyFormat { get; set; }

    /// <summary>Prefix for all log object keys.</summary>
    [JsonPropertyName("targetPrefix")]
    public string? TargetPrefix { get; set; }
}

public enum V1beta1BucketLoggingSpecManagementPoliciesEnum
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

public enum V1beta1BucketLoggingSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketLoggingSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1BucketLoggingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1BucketLoggingSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BucketLoggingSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BucketLoggingSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BucketLoggingSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1BucketLoggingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BucketLoggingSpec defines the desired state of BucketLogging</summary>
public partial class V1beta1BucketLoggingSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketLoggingSpecDeletionPolicyEnum>))]
    public V1beta1BucketLoggingSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketLoggingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketLoggingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BucketLoggingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketLoggingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BucketLoggingSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketLoggingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingStatusAtProviderTargetGrantGrantee
{
    /// <summary></summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Email address of the grantee. See Regions and Endpoints for supported AWS regions where this argument can be specified.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>Canonical user ID of the grantee.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of grantee. Valid values: CanonicalUser, AmazonCustomerByEmail, Group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingStatusAtProviderTargetGrant
{
    /// <summary>Configuration block for the person being granted permissions. See below.</summary>
    [JsonPropertyName("grantee")]
    public IList<V1beta1BucketLoggingStatusAtProviderTargetGrantGrantee>? Grantee { get; set; }

    /// <summary>Logging permissions assigned to the grantee for the bucket. Valid values: FULL_CONTROL, READ, WRITE.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingStatusAtProviderTargetObjectKeyFormatPartitionedPrefix
{
    /// <summary>Specifies the partition date source for the partitioned prefix. Valid values: EventTime, DeliveryTime.</summary>
    [JsonPropertyName("partitionDateSource")]
    public string? PartitionDateSource { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingStatusAtProviderTargetObjectKeyFormatSimplePrefix
{
}

/// <summary></summary>
public partial class V1beta1BucketLoggingStatusAtProviderTargetObjectKeyFormat
{
    /// <summary>Partitioned S3 key for log objects. See below.</summary>
    [JsonPropertyName("partitionedPrefix")]
    public IList<V1beta1BucketLoggingStatusAtProviderTargetObjectKeyFormatPartitionedPrefix>? PartitionedPrefix { get; set; }

    /// <summary>Use the simple format for S3 keys for log objects. To use, set simple_prefix {}.</summary>
    [JsonPropertyName("simplePrefix")]
    public IList<V1beta1BucketLoggingStatusAtProviderTargetObjectKeyFormatSimplePrefix>? SimplePrefix { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketLoggingStatusAtProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>The bucket or bucket and expected_bucket_owner separated by a comma (,) if the latter is provided.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the bucket where you want Amazon S3 to store server access logs.</summary>
    [JsonPropertyName("targetBucket")]
    public string? TargetBucket { get; set; }

    /// <summary>Set of configuration blocks with information for granting permissions. See below.</summary>
    [JsonPropertyName("targetGrant")]
    public IList<V1beta1BucketLoggingStatusAtProviderTargetGrant>? TargetGrant { get; set; }

    /// <summary>Amazon S3 key format for log objects. See below.</summary>
    [JsonPropertyName("targetObjectKeyFormat")]
    public IList<V1beta1BucketLoggingStatusAtProviderTargetObjectKeyFormat>? TargetObjectKeyFormat { get; set; }

    /// <summary>Prefix for all log object keys.</summary>
    [JsonPropertyName("targetPrefix")]
    public string? TargetPrefix { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1BucketLoggingStatusConditions
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

/// <summary>BucketLoggingStatus defines the observed state of BucketLogging.</summary>
public partial class V1beta1BucketLoggingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketLoggingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketLoggingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>BucketLogging is the Schema for the BucketLoggings API. Provides an S3 bucket (server access) logging resource.</summary>
public partial class V1beta1BucketLogging : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketLoggingSpec>, IStatus<V1beta1BucketLoggingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketLogging";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketloggings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketLoggingSpec defines the desired state of BucketLogging</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketLoggingSpec Spec { get; set; }

    /// <summary>BucketLoggingStatus defines the observed state of BucketLogging.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketLoggingStatus? Status { get; set; }
}