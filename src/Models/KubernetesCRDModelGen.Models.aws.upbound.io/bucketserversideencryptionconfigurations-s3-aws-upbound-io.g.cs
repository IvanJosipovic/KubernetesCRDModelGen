using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
public enum V1beta1BucketServerSideEncryptionConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsMasterKeyId.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsMasterKeyId.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefault
{
    /// <summary>AWS KMS master key ID used for the SSE-KMS encryption. This can only be used when you set the value of sse_algorithm as aws:kms. The default aws/s3 AWS KMS master key is used if this element is absent while the sse_algorithm is aws:kms.</summary>
    [JsonPropertyName("kmsMasterKeyId")]
    public string? KmsMasterKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsMasterKeyId.</summary>
    [JsonPropertyName("kmsMasterKeyIdRef")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRef? KmsMasterKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsMasterKeyId.</summary>
    [JsonPropertyName("kmsMasterKeyIdSelector")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelector? KmsMasterKeyIdSelector { get; set; }

    /// <summary>Server-side encryption algorithm to use. Valid values are AES256, aws:kms, and aws:kms:dsse</summary>
    [JsonPropertyName("sseAlgorithm")]
    public string? SseAlgorithm { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRule
{
    /// <summary>Single object for setting server-side encryption by default. See below.</summary>
    [JsonPropertyName("applyServerSideEncryptionByDefault")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRuleApplyServerSideEncryptionByDefault>? ApplyServerSideEncryptionByDefault { get; set; }

    /// <summary>Whether or not to use Amazon S3 Bucket Keys for SSE-KMS.</summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecForProvider
{
    /// <summary>ID (name) of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Set of server-side encryption configuration rules. See below. Currently, only a single rule is supported.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationSpecForProviderRule>? Rule { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsMasterKeyId.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsMasterKeyId.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefault
{
    /// <summary>AWS KMS master key ID used for the SSE-KMS encryption. This can only be used when you set the value of sse_algorithm as aws:kms. The default aws/s3 AWS KMS master key is used if this element is absent while the sse_algorithm is aws:kms.</summary>
    [JsonPropertyName("kmsMasterKeyId")]
    public string? KmsMasterKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsMasterKeyId.</summary>
    [JsonPropertyName("kmsMasterKeyIdRef")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdRef? KmsMasterKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsMasterKeyId.</summary>
    [JsonPropertyName("kmsMasterKeyIdSelector")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefaultKmsMasterKeyIdSelector? KmsMasterKeyIdSelector { get; set; }

    /// <summary>Server-side encryption algorithm to use. Valid values are AES256, aws:kms, and aws:kms:dsse</summary>
    [JsonPropertyName("sseAlgorithm")]
    public string? SseAlgorithm { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRule
{
    /// <summary>Single object for setting server-side encryption by default. See below.</summary>
    [JsonPropertyName("applyServerSideEncryptionByDefault")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRuleApplyServerSideEncryptionByDefault>? ApplyServerSideEncryptionByDefault { get; set; }

    /// <summary>Whether or not to use Amazon S3 Bucket Keys for SSE-KMS.</summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecInitProvider
{
    /// <summary>ID (name) of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Set of server-side encryption configuration rules. See below. Currently, only a single rule is supported.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationSpecInitProviderRule>? Rule { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecManagementPoliciesEnum
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

public enum V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BucketServerSideEncryptionConfigurationSpec defines the desired state of BucketServerSideEncryptionConfiguration</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketServerSideEncryptionConfigurationSpecDeletionPolicyEnum>))]
    public V1beta1BucketServerSideEncryptionConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketServerSideEncryptionConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationStatusAtProviderRuleApplyServerSideEncryptionByDefault
{
    /// <summary>AWS KMS master key ID used for the SSE-KMS encryption. This can only be used when you set the value of sse_algorithm as aws:kms. The default aws/s3 AWS KMS master key is used if this element is absent while the sse_algorithm is aws:kms.</summary>
    [JsonPropertyName("kmsMasterKeyId")]
    public string? KmsMasterKeyId { get; set; }

    /// <summary>Server-side encryption algorithm to use. Valid values are AES256, aws:kms, and aws:kms:dsse</summary>
    [JsonPropertyName("sseAlgorithm")]
    public string? SseAlgorithm { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationStatusAtProviderRule
{
    /// <summary>Single object for setting server-side encryption by default. See below.</summary>
    [JsonPropertyName("applyServerSideEncryptionByDefault")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationStatusAtProviderRuleApplyServerSideEncryptionByDefault>? ApplyServerSideEncryptionByDefault { get; set; }

    /// <summary>Whether or not to use Amazon S3 Bucket Keys for SSE-KMS.</summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationStatusAtProvider
{
    /// <summary>ID (name) of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>The bucket or bucket and expected_bucket_owner separated by a comma (,) if the latter is provided.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Set of server-side encryption configuration rules. See below. Currently, only a single rule is supported.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationStatusAtProviderRule>? Rule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationStatusConditions
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

/// <summary>BucketServerSideEncryptionConfigurationStatus defines the observed state of BucketServerSideEncryptionConfiguration.</summary>
public partial class V1beta1BucketServerSideEncryptionConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketServerSideEncryptionConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketServerSideEncryptionConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>BucketServerSideEncryptionConfiguration is the Schema for the BucketServerSideEncryptionConfigurations API. Provides a S3 bucket server-side encryption configuration resource.</summary>
public partial class V1beta1BucketServerSideEncryptionConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketServerSideEncryptionConfigurationSpec>, IStatus<V1beta1BucketServerSideEncryptionConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketServerSideEncryptionConfiguration";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketserversideencryptionconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketServerSideEncryptionConfigurationSpec defines the desired state of BucketServerSideEncryptionConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketServerSideEncryptionConfigurationSpec Spec { get; set; }

    /// <summary>BucketServerSideEncryptionConfigurationStatus defines the observed state of BucketServerSideEncryptionConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketServerSideEncryptionConfigurationStatus? Status { get; set; }
}