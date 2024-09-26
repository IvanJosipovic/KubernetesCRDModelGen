using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
/// <summary>Specifies the customer-provided encryption key for Amazon S3 to use in encrypting data. This value is used to store the object and then it is discarded; Amazon S3 does not store the encryption key. The key must be appropriate for use with the algorithm specified in the x-amz-server-side-encryption-customer-algorithm header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecForProviderCustomerKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecForProviderGrant
{
    /// <summary>Email address of the grantee. Used only when type is AmazonCustomerByEmail.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Canonical user ID of the grantee. Used only when type is CanonicalUser.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of permissions to grant to grantee. Valid values are READ, READ_ACP, WRITE_ACP, FULL_CONTROL.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>- Type of grantee. Valid values are CanonicalUser, Group, and AmazonCustomerByEmail.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group. Used only when type is Group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Specifies the AWS KMS Encryption Context to use for object encryption. The value is a base64-encoded UTF-8 string holding JSON with the encryption context key-value pairs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecForProviderKmsEncryptionContextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Specifies the AWS KMS Key ARN to use for object encryption. This value is a fully qualified ARN of the KMS Key. If using aws_kms_key, use the exported arn attribute: kms_key_id = aws_kms_key.foo.arn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecForProviderKmsKeyIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Specifies the customer-provided encryption key for Amazon S3 to use to decrypt the source object. The encryption key provided in this header must be one that was used when the source object was created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecForProviderSourceCustomerKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecForProvider
{
    /// <summary>Canned ACL to apply. Valid values are private, public-read, public-read-write, authenticated-read, aws-exec-read, bucket-owner-read, and bucket-owner-full-control. Conflicts with grant.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>Name of the bucket to put the file in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }

    /// <summary>Specifies caching behavior along the request/reply chain Read w3c cache_control for further details.</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Indicates the algorithm used to create the checksum for the object. If a value is specified and the object is encrypted with KMS, you must have permission to use the kms:Decrypt action. Valid values: CRC32, CRC32C, SHA1, SHA256.</summary>
    [JsonPropertyName("checksumAlgorithm")]
    public string? ChecksumAlgorithm { get; set; }

    /// <summary>Specifies presentational information for the object. Read w3c content_disposition for further information.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read w3c content encoding for further information.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Language the content is in e.g., en-US or en-GB.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Standard MIME type describing the format of the object data, e.g., application/octet-stream. All Valid MIME Types are valid for this input.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Copies the object if its entity tag (ETag) matches the specified tag.</summary>
    [JsonPropertyName("copyIfMatch")]
    public string? CopyIfMatch { get; set; }

    /// <summary>Copies the object if it has been modified since the specified time, in RFC3339 format.</summary>
    [JsonPropertyName("copyIfModifiedSince")]
    public string? CopyIfModifiedSince { get; set; }

    /// <summary>Copies the object if its entity tag (ETag) is different than the specified ETag.</summary>
    [JsonPropertyName("copyIfNoneMatch")]
    public string? CopyIfNoneMatch { get; set; }

    /// <summary>Copies the object if it hasn't been modified since the specified time, in RFC3339 format.</summary>
    [JsonPropertyName("copyIfUnmodifiedSince")]
    public string? CopyIfUnmodifiedSince { get; set; }

    /// <summary>Specifies the algorithm to use to when encrypting the object (for example, AES256).</summary>
    [JsonPropertyName("customerAlgorithm")]
    public string? CustomerAlgorithm { get; set; }

    /// <summary>Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that the encryption key was transmitted without error.</summary>
    [JsonPropertyName("customerKeyMd5")]
    public string? CustomerKeyMd5 { get; set; }

    /// <summary>Specifies the customer-provided encryption key for Amazon S3 to use in encrypting data. This value is used to store the object and then it is discarded; Amazon S3 does not store the encryption key. The key must be appropriate for use with the algorithm specified in the x-amz-server-side-encryption-customer-algorithm header.</summary>
    [JsonPropertyName("customerKeySecretRef")]
    public V1beta1ObjectCopySpecForProviderCustomerKeySecretRef? CustomerKeySecretRef { get; set; }

    /// <summary>Account id of the expected destination bucket owner. If the destination bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Account id of the expected source bucket owner. If the source bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedSourceBucketOwner")]
    public string? ExpectedSourceBucketOwner { get; set; }

    /// <summary>Date and time at which the object is no longer cacheable, in RFC3339 format.</summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }

    /// <summary>Allow the object to be deleted by removing any legal hold on any object version. Default is false. This value should be set to true only if the bucket has S3 object lock enabled.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Configuration block for header grants. Documented below. Conflicts with acl.</summary>
    [JsonPropertyName("grant")]
    public IList<V1beta1ObjectCopySpecForProviderGrant>? Grant { get; set; }

    /// <summary>Name of the object once it is in the bucket.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies the AWS KMS Encryption Context to use for object encryption. The value is a base64-encoded UTF-8 string holding JSON with the encryption context key-value pairs.</summary>
    [JsonPropertyName("kmsEncryptionContextSecretRef")]
    public V1beta1ObjectCopySpecForProviderKmsEncryptionContextSecretRef? KmsEncryptionContextSecretRef { get; set; }

    /// <summary>Specifies the AWS KMS Key ARN to use for object encryption. This value is a fully qualified ARN of the KMS Key. If using aws_kms_key, use the exported arn attribute: kms_key_id = aws_kms_key.foo.arn</summary>
    [JsonPropertyName("kmsKeyIdSecretRef")]
    public V1beta1ObjectCopySpecForProviderKmsKeyIdSecretRef? KmsKeyIdSecretRef { get; set; }

    /// <summary>Map of keys/values to provision metadata (will be automatically prefixed by x-amz-meta-, note that only lowercase label are currently supported by the AWS Go API).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Specifies whether the metadata is copied from the source object or replaced with metadata provided in the request. Valid values are COPY and REPLACE.</summary>
    [JsonPropertyName("metadataDirective")]
    public string? MetadataDirective { get; set; }

    /// <summary>The legal hold status that you want to apply to the specified object. Valid values are ON and OFF.</summary>
    [JsonPropertyName("objectLockLegalHoldStatus")]
    public string? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>Object lock retention mode that you want to apply to this object. Valid values are GOVERNANCE and COMPLIANCE.</summary>
    [JsonPropertyName("objectLockMode")]
    public string? ObjectLockMode { get; set; }

    /// <summary>Date and time, in RFC3339 format, when this object's object lock will expire.</summary>
    [JsonPropertyName("objectLockRetainUntilDate")]
    public string? ObjectLockRetainUntilDate { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Confirms that the requester knows that they will be charged for the request. Bucket owners need not specify this parameter in their requests. For information about downloading objects from requester pays buckets, see Downloading Objects in Requestor Pays Buckets (https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectsinRequesterPaysBuckets.html) in the Amazon S3 Developer Guide. If included, the only valid value is requester.</summary>
    [JsonPropertyName("requestPayer")]
    public string? RequestPayer { get; set; }

    /// <summary>Specifies server-side encryption of the object in S3. Valid values are AES256 and aws:kms.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public string? ServerSideEncryption { get; set; }

    /// <summary>Specifies the source object for the copy operation. You specify the value in one of two formats. For objects not accessed through an access point, specify the name of the source bucket and the key of the source object, separated by a slash (/). For example, testbucket/test1.json. For objects accessed through access points, specify the ARN of the object as accessed through the access point, in the format arn:aws:s3:&lt;Region&gt;:&lt;account-id&gt;:accesspoint/&lt;access-point-name&gt;/object/&lt;key&gt;. For example, arn:aws:s3:us-west-2:9999912999:accesspoint/my-access-point/object/testbucket/test1.json.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Specifies the algorithm to use when decrypting the source object (for example, AES256).</summary>
    [JsonPropertyName("sourceCustomerAlgorithm")]
    public string? SourceCustomerAlgorithm { get; set; }

    /// <summary>Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that the encryption key was transmitted without error.</summary>
    [JsonPropertyName("sourceCustomerKeyMd5")]
    public string? SourceCustomerKeyMd5 { get; set; }

    /// <summary>Specifies the customer-provided encryption key for Amazon S3 to use to decrypt the source object. The encryption key provided in this header must be one that was used when the source object was created.</summary>
    [JsonPropertyName("sourceCustomerKeySecretRef")]
    public V1beta1ObjectCopySpecForProviderSourceCustomerKeySecretRef? SourceCustomerKeySecretRef { get; set; }

    /// <summary>Specifies the desired storage class for the object. Defaults to STANDARD.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Specifies whether the object tag-set are copied from the source object or replaced with tag-set provided in the request. Valid values are COPY and REPLACE.</summary>
    [JsonPropertyName("taggingDirective")]
    public string? TaggingDirective { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a target URL for website redirect.</summary>
    [JsonPropertyName("websiteRedirect")]
    public string? WebsiteRedirect { get; set; }
}

/// <summary>Specifies the customer-provided encryption key for Amazon S3 to use in encrypting data. This value is used to store the object and then it is discarded; Amazon S3 does not store the encryption key. The key must be appropriate for use with the algorithm specified in the x-amz-server-side-encryption-customer-algorithm header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecInitProviderCustomerKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecInitProviderGrant
{
    /// <summary>Email address of the grantee. Used only when type is AmazonCustomerByEmail.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Canonical user ID of the grantee. Used only when type is CanonicalUser.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of permissions to grant to grantee. Valid values are READ, READ_ACP, WRITE_ACP, FULL_CONTROL.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>- Type of grantee. Valid values are CanonicalUser, Group, and AmazonCustomerByEmail.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group. Used only when type is Group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Specifies the AWS KMS Encryption Context to use for object encryption. The value is a base64-encoded UTF-8 string holding JSON with the encryption context key-value pairs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecInitProviderKmsEncryptionContextSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Specifies the AWS KMS Key ARN to use for object encryption. This value is a fully qualified ARN of the KMS Key. If using aws_kms_key, use the exported arn attribute: kms_key_id = aws_kms_key.foo.arn</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecInitProviderKmsKeyIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Specifies the customer-provided encryption key for Amazon S3 to use to decrypt the source object. The encryption key provided in this header must be one that was used when the source object was created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecInitProviderSourceCustomerKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecInitProvider
{
    /// <summary>Canned ACL to apply. Valid values are private, public-read, public-read-write, authenticated-read, aws-exec-read, bucket-owner-read, and bucket-owner-full-control. Conflicts with grant.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>Name of the bucket to put the file in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }

    /// <summary>Specifies caching behavior along the request/reply chain Read w3c cache_control for further details.</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Indicates the algorithm used to create the checksum for the object. If a value is specified and the object is encrypted with KMS, you must have permission to use the kms:Decrypt action. Valid values: CRC32, CRC32C, SHA1, SHA256.</summary>
    [JsonPropertyName("checksumAlgorithm")]
    public string? ChecksumAlgorithm { get; set; }

    /// <summary>Specifies presentational information for the object. Read w3c content_disposition for further information.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read w3c content encoding for further information.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Language the content is in e.g., en-US or en-GB.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Standard MIME type describing the format of the object data, e.g., application/octet-stream. All Valid MIME Types are valid for this input.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Copies the object if its entity tag (ETag) matches the specified tag.</summary>
    [JsonPropertyName("copyIfMatch")]
    public string? CopyIfMatch { get; set; }

    /// <summary>Copies the object if it has been modified since the specified time, in RFC3339 format.</summary>
    [JsonPropertyName("copyIfModifiedSince")]
    public string? CopyIfModifiedSince { get; set; }

    /// <summary>Copies the object if its entity tag (ETag) is different than the specified ETag.</summary>
    [JsonPropertyName("copyIfNoneMatch")]
    public string? CopyIfNoneMatch { get; set; }

    /// <summary>Copies the object if it hasn't been modified since the specified time, in RFC3339 format.</summary>
    [JsonPropertyName("copyIfUnmodifiedSince")]
    public string? CopyIfUnmodifiedSince { get; set; }

    /// <summary>Specifies the algorithm to use to when encrypting the object (for example, AES256).</summary>
    [JsonPropertyName("customerAlgorithm")]
    public string? CustomerAlgorithm { get; set; }

    /// <summary>Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that the encryption key was transmitted without error.</summary>
    [JsonPropertyName("customerKeyMd5")]
    public string? CustomerKeyMd5 { get; set; }

    /// <summary>Specifies the customer-provided encryption key for Amazon S3 to use in encrypting data. This value is used to store the object and then it is discarded; Amazon S3 does not store the encryption key. The key must be appropriate for use with the algorithm specified in the x-amz-server-side-encryption-customer-algorithm header.</summary>
    [JsonPropertyName("customerKeySecretRef")]
    public V1beta1ObjectCopySpecInitProviderCustomerKeySecretRef? CustomerKeySecretRef { get; set; }

    /// <summary>Account id of the expected destination bucket owner. If the destination bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Account id of the expected source bucket owner. If the source bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedSourceBucketOwner")]
    public string? ExpectedSourceBucketOwner { get; set; }

    /// <summary>Date and time at which the object is no longer cacheable, in RFC3339 format.</summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }

    /// <summary>Allow the object to be deleted by removing any legal hold on any object version. Default is false. This value should be set to true only if the bucket has S3 object lock enabled.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Configuration block for header grants. Documented below. Conflicts with acl.</summary>
    [JsonPropertyName("grant")]
    public IList<V1beta1ObjectCopySpecInitProviderGrant>? Grant { get; set; }

    /// <summary>Name of the object once it is in the bucket.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies the AWS KMS Encryption Context to use for object encryption. The value is a base64-encoded UTF-8 string holding JSON with the encryption context key-value pairs.</summary>
    [JsonPropertyName("kmsEncryptionContextSecretRef")]
    public V1beta1ObjectCopySpecInitProviderKmsEncryptionContextSecretRef? KmsEncryptionContextSecretRef { get; set; }

    /// <summary>Specifies the AWS KMS Key ARN to use for object encryption. This value is a fully qualified ARN of the KMS Key. If using aws_kms_key, use the exported arn attribute: kms_key_id = aws_kms_key.foo.arn</summary>
    [JsonPropertyName("kmsKeyIdSecretRef")]
    public V1beta1ObjectCopySpecInitProviderKmsKeyIdSecretRef? KmsKeyIdSecretRef { get; set; }

    /// <summary>Map of keys/values to provision metadata (will be automatically prefixed by x-amz-meta-, note that only lowercase label are currently supported by the AWS Go API).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Specifies whether the metadata is copied from the source object or replaced with metadata provided in the request. Valid values are COPY and REPLACE.</summary>
    [JsonPropertyName("metadataDirective")]
    public string? MetadataDirective { get; set; }

    /// <summary>The legal hold status that you want to apply to the specified object. Valid values are ON and OFF.</summary>
    [JsonPropertyName("objectLockLegalHoldStatus")]
    public string? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>Object lock retention mode that you want to apply to this object. Valid values are GOVERNANCE and COMPLIANCE.</summary>
    [JsonPropertyName("objectLockMode")]
    public string? ObjectLockMode { get; set; }

    /// <summary>Date and time, in RFC3339 format, when this object's object lock will expire.</summary>
    [JsonPropertyName("objectLockRetainUntilDate")]
    public string? ObjectLockRetainUntilDate { get; set; }

    /// <summary>Confirms that the requester knows that they will be charged for the request. Bucket owners need not specify this parameter in their requests. For information about downloading objects from requester pays buckets, see Downloading Objects in Requestor Pays Buckets (https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectsinRequesterPaysBuckets.html) in the Amazon S3 Developer Guide. If included, the only valid value is requester.</summary>
    [JsonPropertyName("requestPayer")]
    public string? RequestPayer { get; set; }

    /// <summary>Specifies server-side encryption of the object in S3. Valid values are AES256 and aws:kms.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public string? ServerSideEncryption { get; set; }

    /// <summary>Specifies the source object for the copy operation. You specify the value in one of two formats. For objects not accessed through an access point, specify the name of the source bucket and the key of the source object, separated by a slash (/). For example, testbucket/test1.json. For objects accessed through access points, specify the ARN of the object as accessed through the access point, in the format arn:aws:s3:&lt;Region&gt;:&lt;account-id&gt;:accesspoint/&lt;access-point-name&gt;/object/&lt;key&gt;. For example, arn:aws:s3:us-west-2:9999912999:accesspoint/my-access-point/object/testbucket/test1.json.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Specifies the algorithm to use when decrypting the source object (for example, AES256).</summary>
    [JsonPropertyName("sourceCustomerAlgorithm")]
    public string? SourceCustomerAlgorithm { get; set; }

    /// <summary>Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that the encryption key was transmitted without error.</summary>
    [JsonPropertyName("sourceCustomerKeyMd5")]
    public string? SourceCustomerKeyMd5 { get; set; }

    /// <summary>Specifies the customer-provided encryption key for Amazon S3 to use to decrypt the source object. The encryption key provided in this header must be one that was used when the source object was created.</summary>
    [JsonPropertyName("sourceCustomerKeySecretRef")]
    public V1beta1ObjectCopySpecInitProviderSourceCustomerKeySecretRef? SourceCustomerKeySecretRef { get; set; }

    /// <summary>Specifies the desired storage class for the object. Defaults to STANDARD.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Specifies whether the object tag-set are copied from the source object or replaced with tag-set provided in the request. Valid values are COPY and REPLACE.</summary>
    [JsonPropertyName("taggingDirective")]
    public string? TaggingDirective { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a target URL for website redirect.</summary>
    [JsonPropertyName("websiteRedirect")]
    public string? WebsiteRedirect { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecProviderConfigRefPolicy
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
public partial class V1beta1ObjectCopySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectCopySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ObjectCopySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ObjectCopySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ObjectCopySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ObjectCopySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ObjectCopySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ObjectCopySpec defines the desired state of ObjectCopy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ObjectCopySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ObjectCopySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ObjectCopySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ObjectCopySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ObjectCopySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopyStatusAtProviderGrant
{
    /// <summary>Email address of the grantee. Used only when type is AmazonCustomerByEmail.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Canonical user ID of the grantee. Used only when type is CanonicalUser.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of permissions to grant to grantee. Valid values are READ, READ_ACP, WRITE_ACP, FULL_CONTROL.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>- Type of grantee. Valid values are CanonicalUser, Group, and AmazonCustomerByEmail.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group. Used only when type is Group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopyStatusAtProvider
{
    /// <summary>Canned ACL to apply. Valid values are private, public-read, public-read-write, authenticated-read, aws-exec-read, bucket-owner-read, and bucket-owner-full-control. Conflicts with grant.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>ARN of the object.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Name of the bucket to put the file in.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }

    /// <summary>Specifies caching behavior along the request/reply chain Read w3c cache_control for further details.</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Indicates the algorithm used to create the checksum for the object. If a value is specified and the object is encrypted with KMS, you must have permission to use the kms:Decrypt action. Valid values: CRC32, CRC32C, SHA1, SHA256.</summary>
    [JsonPropertyName("checksumAlgorithm")]
    public string? ChecksumAlgorithm { get; set; }

    /// <summary>The base64-encoded, 32-bit CRC32 checksum of the object.</summary>
    [JsonPropertyName("checksumCrc32")]
    public string? ChecksumCrc32 { get; set; }

    /// <summary>The base64-encoded, 32-bit CRC32C checksum of the object.</summary>
    [JsonPropertyName("checksumCrc32C")]
    public string? ChecksumCrc32C { get; set; }

    /// <summary>The base64-encoded, 160-bit SHA-1 digest of the object.</summary>
    [JsonPropertyName("checksumSha1")]
    public string? ChecksumSha1 { get; set; }

    /// <summary>The base64-encoded, 256-bit SHA-256 digest of the object.</summary>
    [JsonPropertyName("checksumSha256")]
    public string? ChecksumSha256 { get; set; }

    /// <summary>Specifies presentational information for the object. Read w3c content_disposition for further information.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read w3c content encoding for further information.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Language the content is in e.g., en-US or en-GB.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Standard MIME type describing the format of the object data, e.g., application/octet-stream. All Valid MIME Types are valid for this input.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Copies the object if its entity tag (ETag) matches the specified tag.</summary>
    [JsonPropertyName("copyIfMatch")]
    public string? CopyIfMatch { get; set; }

    /// <summary>Copies the object if it has been modified since the specified time, in RFC3339 format.</summary>
    [JsonPropertyName("copyIfModifiedSince")]
    public string? CopyIfModifiedSince { get; set; }

    /// <summary>Copies the object if its entity tag (ETag) is different than the specified ETag.</summary>
    [JsonPropertyName("copyIfNoneMatch")]
    public string? CopyIfNoneMatch { get; set; }

    /// <summary>Copies the object if it hasn't been modified since the specified time, in RFC3339 format.</summary>
    [JsonPropertyName("copyIfUnmodifiedSince")]
    public string? CopyIfUnmodifiedSince { get; set; }

    /// <summary>Specifies the algorithm to use to when encrypting the object (for example, AES256).</summary>
    [JsonPropertyName("customerAlgorithm")]
    public string? CustomerAlgorithm { get; set; }

    /// <summary>Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that the encryption key was transmitted without error.</summary>
    [JsonPropertyName("customerKeyMd5")]
    public string? CustomerKeyMd5 { get; set; }

    /// <summary>ETag generated for the object (an MD5 sum of the object content). For plaintext objects or objects encrypted with an AWS-managed key, the hash is an MD5 digest of the object data. For objects encrypted with a KMS key or objects created by either the Multipart Upload or Part Copy operation, the hash is not an MD5 digest, regardless of the method of encryption. More information on possible values can be found on Common Response Headers.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Account id of the expected destination bucket owner. If the destination bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Account id of the expected source bucket owner. If the source bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.</summary>
    [JsonPropertyName("expectedSourceBucketOwner")]
    public string? ExpectedSourceBucketOwner { get; set; }

    /// <summary>If the object expiration is configured, this attribute will be set.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>Date and time at which the object is no longer cacheable, in RFC3339 format.</summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }

    /// <summary>Allow the object to be deleted by removing any legal hold on any object version. Default is false. This value should be set to true only if the bucket has S3 object lock enabled.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Configuration block for header grants. Documented below. Conflicts with acl.</summary>
    [JsonPropertyName("grant")]
    public IList<V1beta1ObjectCopyStatusAtProviderGrant>? Grant { get; set; }

    /// <summary>Canonical user ID of the grantee. Used only when type is CanonicalUser.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the object once it is in the bucket.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Returns the date that the object was last modified, in RFC3339 format.</summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }

    /// <summary>Map of keys/values to provision metadata (will be automatically prefixed by x-amz-meta-, note that only lowercase label are currently supported by the AWS Go API).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Specifies whether the metadata is copied from the source object or replaced with metadata provided in the request. Valid values are COPY and REPLACE.</summary>
    [JsonPropertyName("metadataDirective")]
    public string? MetadataDirective { get; set; }

    /// <summary>The legal hold status that you want to apply to the specified object. Valid values are ON and OFF.</summary>
    [JsonPropertyName("objectLockLegalHoldStatus")]
    public string? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>Object lock retention mode that you want to apply to this object. Valid values are GOVERNANCE and COMPLIANCE.</summary>
    [JsonPropertyName("objectLockMode")]
    public string? ObjectLockMode { get; set; }

    /// <summary>Date and time, in RFC3339 format, when this object's object lock will expire.</summary>
    [JsonPropertyName("objectLockRetainUntilDate")]
    public string? ObjectLockRetainUntilDate { get; set; }

    /// <summary>If present, indicates that the requester was successfully charged for the request.</summary>
    [JsonPropertyName("requestCharged")]
    public bool? RequestCharged { get; set; }

    /// <summary>Confirms that the requester knows that they will be charged for the request. Bucket owners need not specify this parameter in their requests. For information about downloading objects from requester pays buckets, see Downloading Objects in Requestor Pays Buckets (https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectsinRequesterPaysBuckets.html) in the Amazon S3 Developer Guide. If included, the only valid value is requester.</summary>
    [JsonPropertyName("requestPayer")]
    public string? RequestPayer { get; set; }

    /// <summary>Specifies server-side encryption of the object in S3. Valid values are AES256 and aws:kms.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public string? ServerSideEncryption { get; set; }

    /// <summary>Specifies the source object for the copy operation. You specify the value in one of two formats. For objects not accessed through an access point, specify the name of the source bucket and the key of the source object, separated by a slash (/). For example, testbucket/test1.json. For objects accessed through access points, specify the ARN of the object as accessed through the access point, in the format arn:aws:s3:&lt;Region&gt;:&lt;account-id&gt;:accesspoint/&lt;access-point-name&gt;/object/&lt;key&gt;. For example, arn:aws:s3:us-west-2:9999912999:accesspoint/my-access-point/object/testbucket/test1.json.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Specifies the algorithm to use when decrypting the source object (for example, AES256).</summary>
    [JsonPropertyName("sourceCustomerAlgorithm")]
    public string? SourceCustomerAlgorithm { get; set; }

    /// <summary>Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that the encryption key was transmitted without error.</summary>
    [JsonPropertyName("sourceCustomerKeyMd5")]
    public string? SourceCustomerKeyMd5 { get; set; }

    /// <summary>Version of the copied object in the source bucket.</summary>
    [JsonPropertyName("sourceVersionId")]
    public string? SourceVersionId { get; set; }

    /// <summary>Specifies the desired storage class for the object. Defaults to STANDARD.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Specifies whether the object tag-set are copied from the source object or replaced with tag-set provided in the request. Valid values are COPY and REPLACE.</summary>
    [JsonPropertyName("taggingDirective")]
    public string? TaggingDirective { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Version ID of the newly created copy.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    /// <summary>Specifies a target URL for website redirect.</summary>
    [JsonPropertyName("websiteRedirect")]
    public string? WebsiteRedirect { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopyStatusConditions
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

/// <summary>ObjectCopyStatus defines the observed state of ObjectCopy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ObjectCopyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ObjectCopyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ObjectCopyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ObjectCopy is the Schema for the ObjectCopys API. Provides a resource for copying an S3 object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ObjectCopy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ObjectCopySpec>, IStatus<V1beta1ObjectCopyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ObjectCopy";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "objectcopies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ObjectCopySpec defines the desired state of ObjectCopy</summary>
    [JsonPropertyName("spec")]
    public V1beta1ObjectCopySpec Spec { get; set; }

    /// <summary>ObjectCopyStatus defines the observed state of ObjectCopy.</summary>
    [JsonPropertyName("status")]
    public V1beta1ObjectCopyStatus? Status { get; set; }
}