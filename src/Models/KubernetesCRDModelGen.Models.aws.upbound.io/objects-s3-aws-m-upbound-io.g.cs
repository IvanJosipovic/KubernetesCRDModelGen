using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.m.upbound.io;
#nullable enable
/// <summary>Object is the Schema for the Objects API. Provides an S3 object resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ObjectList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Object>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ObjectList";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "objects";
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
    public IList<V1beta1Object> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectSpecForProviderBucketRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderBucketSelector
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
    public V1beta1ObjectSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderKmsKeyIdSelector
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
    public V1beta1ObjectSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Override the provider default_tags configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderOverrideProviderDefaultTags
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Override provider-level configuration options. See Override Provider below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProviderOverrideProvider
{
    /// <summary>Override the provider default_tags configuration block.</summary>
    [JsonPropertyName("defaultTags")]
    public V1beta1ObjectSpecForProviderOverrideProviderDefaultTags? DefaultTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecForProvider
{
    /// <summary>Canned ACL to apply. Valid values are private, public-read, public-read-write, aws-exec-read, authenticated-read, bucket-owner-read, and bucket-owner-full-control.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>Name of the bucket to put the file in. Alternatively, an S3 access point ARN can be specified.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether or not to use Amazon S3 Bucket Keys for SSE-KMS.</summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ObjectSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ObjectSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Caching behavior along the request/reply chain Read w3c cache_control for further details.</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Indicates the algorithm used to create the checksum for the object. If a value is specified and the object is encrypted with KMS, you must have permission to use the kms:Decrypt action. Valid values: CRC32, CRC32C, CRC64NVME, SHA1, SHA256.</summary>
    [JsonPropertyName("checksumAlgorithm")]
    public string? ChecksumAlgorithm { get; set; }

    /// <summary>Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the gzipbase64 function with small text strings. For larger objects, use source to stream the content from a disk file.</summary>
    [JsonPropertyName("contentBase64")]
    public string? ContentBase64 { get; set; }

    /// <summary>Presentational information for the object. Read w3c content_disposition for further information.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content encodings that have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read w3c content encoding for further information.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Language the content is in e.g., en-US or en-GB.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Standard MIME type describing the format of the object data, e.g., application/octet-stream. All Valid MIME Types are valid for this input.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Triggers updates when the value changes.11.11.11 or earlier). This attribute is not compatible with KMS encryption, kms_key_id or server_side_encryption = "aws:kms", also if an object is larger than 16 MB, the AWS Management Console will upload or copy that object as a Multipart Upload, and therefore the ETag will not be an MD5 digest (see source_hash instead).</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Whether to allow the object to be deleted by removing any legal hold on any object version. Default is false. This value should be set to true only if the bucket has S3 object lock enabled.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Name of the object once it is in the bucket.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>ARN of the KMS Key to use for object encryption. If the S3 Bucket has server-side encryption enabled, that value will automatically be used. If referencing the aws_kms_key resource, use the arn attribute. If referencing the aws_kms_alias data source or resource, use the target_key_arn attribute.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ObjectSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ObjectSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Map of keys/values to provision metadata (will be automatically prefixed by x-amz-meta-, note that only lowercase label are currently supported by the AWS Go API).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Legal hold status that you want to apply to the specified object. Valid values are ON and OFF.</summary>
    [JsonPropertyName("objectLockLegalHoldStatus")]
    public string? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>Object lock retention mode that you want to apply to this object. Valid values are GOVERNANCE and COMPLIANCE.</summary>
    [JsonPropertyName("objectLockMode")]
    public string? ObjectLockMode { get; set; }

    /// <summary>Date and time, in RFC3339 format, when this object's object lock will expire.</summary>
    [JsonPropertyName("objectLockRetainUntilDate")]
    public string? ObjectLockRetainUntilDate { get; set; }

    /// <summary>Override provider-level configuration options. See Override Provider below for more details.</summary>
    [JsonPropertyName("overrideProvider")]
    public V1beta1ObjectSpecForProviderOverrideProvider? OverrideProvider { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Server-side encryption of the object in S3. Valid values are "AES256" and "aws:kms".</summary>
    [JsonPropertyName("serverSideEncryption")]
    public string? ServerSideEncryption { get; set; }

    /// <summary>Path to a file that will be read and uploaded as raw bytes for the object content.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Triggers updates like etag but useful to address etag encryption limitations.11.12 or later). (The value is only stored in state and not saved by AWS.)</summary>
    [JsonPropertyName("sourceHash")]
    public string? SourceHash { get; set; }

    /// <summary>Storage Class for the object. Defaults to "STANDARD".</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target URL for website redirect.</summary>
    [JsonPropertyName("websiteRedirect")]
    public string? WebsiteRedirect { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectSpecInitProviderBucketRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderBucketSelector
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
    public V1beta1ObjectSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderKmsKeyIdSelector
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
    public V1beta1ObjectSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Override the provider default_tags configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderOverrideProviderDefaultTags
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Override provider-level configuration options. See Override Provider below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProviderOverrideProvider
{
    /// <summary>Override the provider default_tags configuration block.</summary>
    [JsonPropertyName("defaultTags")]
    public V1beta1ObjectSpecInitProviderOverrideProviderDefaultTags? DefaultTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecInitProvider
{
    /// <summary>Canned ACL to apply. Valid values are private, public-read, public-read-write, aws-exec-read, authenticated-read, bucket-owner-read, and bucket-owner-full-control.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>Name of the bucket to put the file in. Alternatively, an S3 access point ARN can be specified.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether or not to use Amazon S3 Bucket Keys for SSE-KMS.</summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1ObjectSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1ObjectSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Caching behavior along the request/reply chain Read w3c cache_control for further details.</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Indicates the algorithm used to create the checksum for the object. If a value is specified and the object is encrypted with KMS, you must have permission to use the kms:Decrypt action. Valid values: CRC32, CRC32C, CRC64NVME, SHA1, SHA256.</summary>
    [JsonPropertyName("checksumAlgorithm")]
    public string? ChecksumAlgorithm { get; set; }

    /// <summary>Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the gzipbase64 function with small text strings. For larger objects, use source to stream the content from a disk file.</summary>
    [JsonPropertyName("contentBase64")]
    public string? ContentBase64 { get; set; }

    /// <summary>Presentational information for the object. Read w3c content_disposition for further information.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content encodings that have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read w3c content encoding for further information.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Language the content is in e.g., en-US or en-GB.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Standard MIME type describing the format of the object data, e.g., application/octet-stream. All Valid MIME Types are valid for this input.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Triggers updates when the value changes.11.11.11 or earlier). This attribute is not compatible with KMS encryption, kms_key_id or server_side_encryption = "aws:kms", also if an object is larger than 16 MB, the AWS Management Console will upload or copy that object as a Multipart Upload, and therefore the ETag will not be an MD5 digest (see source_hash instead).</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Whether to allow the object to be deleted by removing any legal hold on any object version. Default is false. This value should be set to true only if the bucket has S3 object lock enabled.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Name of the object once it is in the bucket.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>ARN of the KMS Key to use for object encryption. If the S3 Bucket has server-side encryption enabled, that value will automatically be used. If referencing the aws_kms_key resource, use the arn attribute. If referencing the aws_kms_alias data source or resource, use the target_key_arn attribute.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ObjectSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ObjectSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Map of keys/values to provision metadata (will be automatically prefixed by x-amz-meta-, note that only lowercase label are currently supported by the AWS Go API).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Legal hold status that you want to apply to the specified object. Valid values are ON and OFF.</summary>
    [JsonPropertyName("objectLockLegalHoldStatus")]
    public string? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>Object lock retention mode that you want to apply to this object. Valid values are GOVERNANCE and COMPLIANCE.</summary>
    [JsonPropertyName("objectLockMode")]
    public string? ObjectLockMode { get; set; }

    /// <summary>Date and time, in RFC3339 format, when this object's object lock will expire.</summary>
    [JsonPropertyName("objectLockRetainUntilDate")]
    public string? ObjectLockRetainUntilDate { get; set; }

    /// <summary>Override provider-level configuration options. See Override Provider below for more details.</summary>
    [JsonPropertyName("overrideProvider")]
    public V1beta1ObjectSpecInitProviderOverrideProvider? OverrideProvider { get; set; }

    /// <summary>Server-side encryption of the object in S3. Valid values are "AES256" and "aws:kms".</summary>
    [JsonPropertyName("serverSideEncryption")]
    public string? ServerSideEncryption { get; set; }

    /// <summary>Path to a file that will be read and uploaded as raw bytes for the object content.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Triggers updates like etag but useful to address etag encryption limitations.11.12 or later). (The value is only stored in state and not saved by AWS.)</summary>
    [JsonPropertyName("sourceHash")]
    public string? SourceHash { get; set; }

    /// <summary>Storage Class for the object. Defaults to "STANDARD".</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target URL for website redirect.</summary>
    [JsonPropertyName("websiteRedirect")]
    public string? WebsiteRedirect { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObjectSpec defines the desired state of Object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ObjectSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ObjectSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ObjectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ObjectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Override the provider default_tags configuration block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectStatusAtProviderOverrideProviderDefaultTags
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Override provider-level configuration options. See Override Provider below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectStatusAtProviderOverrideProvider
{
    /// <summary>Override the provider default_tags configuration block.</summary>
    [JsonPropertyName("defaultTags")]
    public V1beta1ObjectStatusAtProviderOverrideProviderDefaultTags? DefaultTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectStatusAtProvider
{
    /// <summary>Canned ACL to apply. Valid values are private, public-read, public-read-write, aws-exec-read, authenticated-read, bucket-owner-read, and bucket-owner-full-control.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>ARN of the object.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Name of the bucket to put the file in. Alternatively, an S3 access point ARN can be specified.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether or not to use Amazon S3 Bucket Keys for SSE-KMS.</summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }

    /// <summary>Caching behavior along the request/reply chain Read w3c cache_control for further details.</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Indicates the algorithm used to create the checksum for the object. If a value is specified and the object is encrypted with KMS, you must have permission to use the kms:Decrypt action. Valid values: CRC32, CRC32C, CRC64NVME, SHA1, SHA256.</summary>
    [JsonPropertyName("checksumAlgorithm")]
    public string? ChecksumAlgorithm { get; set; }

    /// <summary>The base64-encoded, 32-bit CRC32 checksum of the object.</summary>
    [JsonPropertyName("checksumCrc32")]
    public string? ChecksumCrc32 { get; set; }

    /// <summary>The base64-encoded, 32-bit CRC32C checksum of the object.</summary>
    [JsonPropertyName("checksumCrc32C")]
    public string? ChecksumCrc32C { get; set; }

    /// <summary>The base64-encoded, 64-bit CRC64NVME checksum of the object.</summary>
    [JsonPropertyName("checksumCrc64Nvme")]
    public string? ChecksumCrc64Nvme { get; set; }

    /// <summary>The base64-encoded, 160-bit SHA-1 digest of the object.</summary>
    [JsonPropertyName("checksumSha1")]
    public string? ChecksumSha1 { get; set; }

    /// <summary>The base64-encoded, 256-bit SHA-256 digest of the object.</summary>
    [JsonPropertyName("checksumSha256")]
    public string? ChecksumSha256 { get; set; }

    /// <summary>Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the gzipbase64 function with small text strings. For larger objects, use source to stream the content from a disk file.</summary>
    [JsonPropertyName("contentBase64")]
    public string? ContentBase64 { get; set; }

    /// <summary>Presentational information for the object. Read w3c content_disposition for further information.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content encodings that have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read w3c content encoding for further information.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Language the content is in e.g., en-US or en-GB.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Standard MIME type describing the format of the object data, e.g., application/octet-stream. All Valid MIME Types are valid for this input.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Triggers updates when the value changes.11.11.11 or earlier). This attribute is not compatible with KMS encryption, kms_key_id or server_side_encryption = "aws:kms", also if an object is larger than 16 MB, the AWS Management Console will upload or copy that object as a Multipart Upload, and therefore the ETag will not be an MD5 digest (see source_hash instead).</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Whether to allow the object to be deleted by removing any legal hold on any object version. Default is false. This value should be set to true only if the bucket has S3 object lock enabled.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the object once it is in the bucket.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>ARN of the KMS Key to use for object encryption. If the S3 Bucket has server-side encryption enabled, that value will automatically be used. If referencing the aws_kms_key resource, use the arn attribute. If referencing the aws_kms_alias data source or resource, use the target_key_arn attribute.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Map of keys/values to provision metadata (will be automatically prefixed by x-amz-meta-, note that only lowercase label are currently supported by the AWS Go API).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Legal hold status that you want to apply to the specified object. Valid values are ON and OFF.</summary>
    [JsonPropertyName("objectLockLegalHoldStatus")]
    public string? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>Object lock retention mode that you want to apply to this object. Valid values are GOVERNANCE and COMPLIANCE.</summary>
    [JsonPropertyName("objectLockMode")]
    public string? ObjectLockMode { get; set; }

    /// <summary>Date and time, in RFC3339 format, when this object's object lock will expire.</summary>
    [JsonPropertyName("objectLockRetainUntilDate")]
    public string? ObjectLockRetainUntilDate { get; set; }

    /// <summary>Override provider-level configuration options. See Override Provider below for more details.</summary>
    [JsonPropertyName("overrideProvider")]
    public V1beta1ObjectStatusAtProviderOverrideProvider? OverrideProvider { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Server-side encryption of the object in S3. Valid values are "AES256" and "aws:kms".</summary>
    [JsonPropertyName("serverSideEncryption")]
    public string? ServerSideEncryption { get; set; }

    /// <summary>Path to a file that will be read and uploaded as raw bytes for the object content.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Triggers updates like etag but useful to address etag encryption limitations.11.12 or later). (The value is only stored in state and not saved by AWS.)</summary>
    [JsonPropertyName("sourceHash")]
    public string? SourceHash { get; set; }

    /// <summary>Storage Class for the object. Defaults to "STANDARD".</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Unique version ID value for the object, if bucket versioning is enabled.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    /// <summary>Target URL for website redirect.</summary>
    [JsonPropertyName("websiteRedirect")]
    public string? WebsiteRedirect { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ObjectStatus defines the observed state of Object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ObjectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ObjectStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object is the Schema for the Objects API. Provides an S3 object resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Object : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ObjectSpec>, IStatus<V1beta1ObjectStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Object";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "objects";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ObjectSpec defines the desired state of Object</summary>
    [JsonPropertyName("spec")]
    public V1beta1ObjectSpec Spec { get; set; }

    /// <summary>ObjectStatus defines the observed state of Object.</summary>
    [JsonPropertyName("status")]
    public V1beta1ObjectStatus? Status { get; set; }
}
#nullable disable
