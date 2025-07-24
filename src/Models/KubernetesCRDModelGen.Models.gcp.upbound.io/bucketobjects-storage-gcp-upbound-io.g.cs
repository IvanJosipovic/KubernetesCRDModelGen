using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.gcp.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketObjectSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecForProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketObjectSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Base64 encoded Customer-Supplied Encryption Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecForProviderCustomerEncryptionEncryptionKeySecretRef
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
public partial class V1beta1BucketObjectSpecForProviderCustomerEncryption
{
    /// <summary>Encryption algorithm. Default: AES256</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>Base64 encoded Customer-Supplied Encryption Key.</summary>
    [JsonPropertyName("encryptionKeySecretRef")]
    public V1beta1BucketObjectSpecForProviderCustomerEncryptionEncryptionKeySecretRef EncryptionKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecForProviderRetention
{
    /// <summary>The retention policy mode. Either Locked or Unlocked.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The time to retain the object until in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("retainUntilTime")]
    public string? RetainUntilTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecForProvider
{
    /// <summary>The name of the containing bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketObjectSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketObjectSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Content-Disposition of the object data.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content-Encoding of the object data.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Content-Language of the object data.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Content-Type of the object data. Defaults to "application/octet-stream" or "text/plain; charset=utf-8".</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys) Structure is documented below.</summary>
    [JsonPropertyName("customerEncryption")]
    public IList<V1beta1BucketObjectSpecForProviderCustomerEncryption>? CustomerEncryption { get; set; }

    /// <summary>MD5 hash of the data, encoded using base64. This field is not present for composite objects. For more information about using the MD5 hash, see Hashes and ETags: Best Practices.</summary>
    [JsonPropertyName("detectMd5Hash")]
    public string? DetectMd5Hash { get; set; }

    /// <summary>Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold's release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).</summary>
    [JsonPropertyName("eventBasedHold")]
    public bool? EventBasedHold { get; set; }

    /// <summary>The resource name of the Cloud KMS key that will be used to encrypt the object.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>User-provided metadata, in key/value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the object. If you're interpolating the name of this object, see output_name instead.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
    [JsonPropertyName("retention")]
    public IList<V1beta1BucketObjectSpecForProviderRetention>? Retention { get; set; }

    /// <summary>A path to the data you want to upload. Must be defined if content is not.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>User-provided md5hash to trigger replacement of object in storage bucket, Must be Base 64 MD5 hash of the object data. The usual way to set this is filemd5("file.zip"), where "file.zip" is the local filename</summary>
    [JsonPropertyName("sourceMd5Hash")]
    public string? SourceMd5Hash { get; set; }

    /// <summary>The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket's default storage class or to a standard class.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.</summary>
    [JsonPropertyName("temporaryHold")]
    public bool? TemporaryHold { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketObjectSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecInitProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketObjectSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecInitProviderCustomerEncryption
{
    /// <summary>Encryption algorithm. Default: AES256</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecInitProviderRetention
{
    /// <summary>The retention policy mode. Either Locked or Unlocked.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The time to retain the object until in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("retainUntilTime")]
    public string? RetainUntilTime { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecInitProvider
{
    /// <summary>The name of the containing bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketObjectSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketObjectSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Content-Disposition of the object data.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content-Encoding of the object data.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Content-Language of the object data.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Content-Type of the object data. Defaults to "application/octet-stream" or "text/plain; charset=utf-8".</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys) Structure is documented below.</summary>
    [JsonPropertyName("customerEncryption")]
    public IList<V1beta1BucketObjectSpecInitProviderCustomerEncryption>? CustomerEncryption { get; set; }

    /// <summary>MD5 hash of the data, encoded using base64. This field is not present for composite objects. For more information about using the MD5 hash, see Hashes and ETags: Best Practices.</summary>
    [JsonPropertyName("detectMd5Hash")]
    public string? DetectMd5Hash { get; set; }

    /// <summary>Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold's release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).</summary>
    [JsonPropertyName("eventBasedHold")]
    public bool? EventBasedHold { get; set; }

    /// <summary>The resource name of the Cloud KMS key that will be used to encrypt the object.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>User-provided metadata, in key/value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the object. If you're interpolating the name of this object, see output_name instead.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
    [JsonPropertyName("retention")]
    public IList<V1beta1BucketObjectSpecInitProviderRetention>? Retention { get; set; }

    /// <summary>A path to the data you want to upload. Must be defined if content is not.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>User-provided md5hash to trigger replacement of object in storage bucket, Must be Base 64 MD5 hash of the object data. The usual way to set this is filemd5("file.zip"), where "file.zip" is the local filename</summary>
    [JsonPropertyName("sourceMd5Hash")]
    public string? SourceMd5Hash { get; set; }

    /// <summary>The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket's default storage class or to a standard class.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.</summary>
    [JsonPropertyName("temporaryHold")]
    public bool? TemporaryHold { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecProviderConfigRefPolicy
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
public partial class V1beta1BucketObjectSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketObjectSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1BucketObjectSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketObjectSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BucketObjectSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BucketObjectSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BucketObjectSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BucketObjectSpec defines the desired state of BucketObject</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketObjectSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketObjectSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketObjectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BucketObjectSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketObjectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectStatusAtProviderCustomerEncryption
{
    /// <summary>Encryption algorithm. Default: AES256</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectStatusAtProviderRetention
{
    /// <summary>The retention policy mode. Either Locked or Unlocked.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The time to retain the object until in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.</summary>
    [JsonPropertyName("retainUntilTime")]
    public string? RetainUntilTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectStatusAtProvider
{
    /// <summary>The name of the containing bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600</summary>
    [JsonPropertyName("cacheControl")]
    public string? CacheControl { get; set; }

    /// <summary>Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Content-Disposition of the object data.</summary>
    [JsonPropertyName("contentDisposition")]
    public string? ContentDisposition { get; set; }

    /// <summary>Content-Encoding of the object data.</summary>
    [JsonPropertyName("contentEncoding")]
    public string? ContentEncoding { get; set; }

    /// <summary>Content-Language of the object data.</summary>
    [JsonPropertyName("contentLanguage")]
    public string? ContentLanguage { get; set; }

    /// <summary>Content-Type of the object data. Defaults to "application/octet-stream" or "text/plain; charset=utf-8".</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>(Computed) Base 64 CRC32 hash of the uploaded data.</summary>
    [JsonPropertyName("crc32c")]
    public string? Crc32c { get; set; }

    /// <summary>Enables object encryption with Customer-Supplied Encryption Key (CSEK). [Google documentation about CSEK.](https://cloud.google.com/storage/docs/encryption/customer-supplied-keys) Structure is documented below.</summary>
    [JsonPropertyName("customerEncryption")]
    public IList<V1beta1BucketObjectStatusAtProviderCustomerEncryption>? CustomerEncryption { get; set; }

    /// <summary>MD5 hash of the data, encoded using base64. This field is not present for composite objects. For more information about using the MD5 hash, see Hashes and ETags: Best Practices.</summary>
    [JsonPropertyName("detectMd5Hash")]
    public string? DetectMd5Hash { get; set; }

    /// <summary>Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold's release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).</summary>
    [JsonPropertyName("eventBasedHold")]
    public bool? EventBasedHold { get; set; }

    /// <summary>(Computed) The content generation of this object. Used for object versioning and soft delete.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource name of the Cloud KMS key that will be used to encrypt the object.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>(Computed) Base 64 MD5 hash of the uploaded data.</summary>
    [JsonPropertyName("md5hash")]
    public string? Md5hash { get; set; }

    /// <summary>(Computed) Hex value of md5hash`</summary>
    [JsonPropertyName("md5hexhash")]
    public string? Md5hexhash { get; set; }

    /// <summary>(Computed) A url reference to download this object.</summary>
    [JsonPropertyName("mediaLink")]
    public string? MediaLink { get; set; }

    /// <summary>User-provided metadata, in key/value pairs.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the object. If you're interpolating the name of this object, see output_name instead.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Computed) The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.</summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>The object retention settings for the object. The retention settings allow an object to be retained until a provided date. Structure is documented below.</summary>
    [JsonPropertyName("retention")]
    public IList<V1beta1BucketObjectStatusAtProviderRetention>? Retention { get; set; }

    /// <summary>(Computed) A url reference to this object.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>A path to the data you want to upload. Must be defined if content is not.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>User-provided md5hash to trigger replacement of object in storage bucket, Must be Base 64 MD5 hash of the object data. The usual way to set this is filemd5("file.zip"), where "file.zip" is the local filename</summary>
    [JsonPropertyName("sourceMd5Hash")]
    public string? SourceMd5Hash { get; set; }

    /// <summary>The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket's default storage class or to a standard class.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.</summary>
    [JsonPropertyName("temporaryHold")]
    public bool? TemporaryHold { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectStatusConditions
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

/// <summary>BucketObjectStatus defines the observed state of BucketObject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketObjectStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketObjectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketObjectStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BucketObject is the Schema for the BucketObjects API. Creates a new object inside a specified bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketObject : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketObjectSpec>, IStatus<V1beta1BucketObjectStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketObject";
    public const string KubeGroup = "storage.gcp.upbound.io";
    public const string KubePluralName = "bucketobjects";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketObjectSpec defines the desired state of BucketObject</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketObjectSpec Spec { get; set; }

    /// <summary>BucketObjectStatus defines the observed state of BucketObject.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketObjectStatus? Status { get; set; }
}

/// <summary>BucketObject is the Schema for the BucketObjects API. Creates a new object inside a specified bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketObjectList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BucketObject>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketObjectList";
    public const string KubeGroup = "storage.gcp.upbound.io";
    public const string KubePluralName = "bucketobjects";
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
    public IList<V1beta1BucketObject> Items { get; set; }
}