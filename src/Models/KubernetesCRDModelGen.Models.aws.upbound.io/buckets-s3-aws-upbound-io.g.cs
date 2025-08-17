using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
#nullable enable
/// <summary>Bucket is the Schema for the Buckets API. Provides a S3 bucket resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Bucket>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketList";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "buckets";
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
    public IList<V1beta1Bucket> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProvider
{
    /// <summary>Boolean that indicates all objects (including any locked objects) should be deleted from the bucket when the bucket is destroyed so that the bucket can be destroyed without error. These objects are not recoverable. This only deletes objects when the bucket is destroyed, not when setting this parameter to true. If setting this field in the same operation that would require replacing the bucket or destroying the bucket, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Indicates whether this bucket has an Object Lock configuration enabled. Valid values are true or false. This argument is not supported in all regions or partitions.</summary>
    [JsonPropertyName("objectLockEnabled")]
    public bool? ObjectLockEnabled { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProvider
{
    /// <summary>Boolean that indicates all objects (including any locked objects) should be deleted from the bucket when the bucket is destroyed so that the bucket can be destroyed without error. These objects are not recoverable. This only deletes objects when the bucket is destroyed, not when setting this parameter to true. If setting this field in the same operation that would require replacing the bucket or destroying the bucket, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Indicates whether this bucket has an Object Lock configuration enabled. Valid values are true or false. This argument is not supported in all regions or partitions.</summary>
    [JsonPropertyName("objectLockEnabled")]
    public bool? ObjectLockEnabled { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BucketSpec defines the desired state of Bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderCorsRule
{
    /// <summary>List of headers allowed.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>One or more HTTP methods that you allow the origin to execute. Can be GET, PUT, POST, DELETE or HEAD.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>One or more origins you want customers to be able to access the bucket from.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>One or more headers in the response that you want customers to be able to access from their applications (for example, from a JavaScript XMLHttpRequest object).</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies time in seconds that browser can cache the response for a preflight request.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderGrant
{
    /// <summary>Canonical user id to grant for. Used only when type is CanonicalUser.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of permissions to apply for grantee. Valid values are READ, WRITE, READ_ACP, WRITE_ACP, FULL_CONTROL.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Type of grantee to apply for. Valid values are CanonicalUser and Group. AmazonCustomerByEmail is not supported.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Uri address to grant for. Used only when type is Group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRuleExpiration
{
    /// <summary>Specifies the date after which you want the corresponding action to take effect.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>On a versioned bucket (versioning-enabled or versioning-suspended bucket), you can add this element in the lifecycle configuration to direct Amazon S3 to delete expired object delete markers. This cannot be specified with Days or Date in a Lifecycle Expiration Policy.</summary>
    [JsonPropertyName("expiredObjectDeleteMarker")]
    public bool? ExpiredObjectDeleteMarker { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRuleNoncurrentVersionExpiration
{
    /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRuleNoncurrentVersionTransition
{
    /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Specifies the Amazon S3 storage class to which you want the object to transition.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRuleTransition
{
    /// <summary>Specifies the date after which you want the corresponding action to take effect.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Specifies the Amazon S3 storage class to which you want the object to transition.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRule
{
    /// <summary>Specifies the number of days after initiating a multipart upload when the multipart upload must be completed.</summary>
    [JsonPropertyName("abortIncompleteMultipartUploadDays")]
    public double? AbortIncompleteMultipartUploadDays { get; set; }

    /// <summary>Specifies lifecycle rule status.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies a period in the object's expire. See Expiration below for details.</summary>
    [JsonPropertyName("expiration")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRuleExpiration>? Expiration { get; set; }

    /// <summary>Unique identifier for the rule. Must be less than or equal to 255 characters in length.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies when noncurrent object versions expire. See Noncurrent Version Expiration below for details.</summary>
    [JsonPropertyName("noncurrentVersionExpiration")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRuleNoncurrentVersionExpiration>? NoncurrentVersionExpiration { get; set; }

    /// <summary>Specifies when noncurrent object versions transitions. See Noncurrent Version Transition below for details.</summary>
    [JsonPropertyName("noncurrentVersionTransition")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRuleNoncurrentVersionTransition>? NoncurrentVersionTransition { get; set; }

    /// <summary>Object key prefix identifying one or more objects to which the rule applies.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Specifies object tags key and value.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a period in the object's transitions. See Transition below for details.</summary>
    [JsonPropertyName("transition")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRuleTransition>? Transition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLogging
{
    /// <summary>Name of the bucket that will receive the log objects.</summary>
    [JsonPropertyName("targetBucket")]
    public string? TargetBucket { get; set; }

    /// <summary>To specify a key prefix for log objects.</summary>
    [JsonPropertyName("targetPrefix")]
    public string? TargetPrefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderObjectLockConfigurationRuleDefaultRetention
{
    /// <summary>Number of days that you want to specify for the default retention period.</summary>
    [JsonPropertyName("days")]
    public double? Days { get; set; }

    /// <summary>Default Object Lock retention mode you want to apply to new objects placed in this bucket. Valid values are GOVERNANCE and COMPLIANCE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Number of years that you want to specify for the default retention period.</summary>
    [JsonPropertyName("years")]
    public double? Years { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderObjectLockConfigurationRule
{
    /// <summary>Default retention period that you want to apply to new objects placed in this bucket (documented below).</summary>
    [JsonPropertyName("defaultRetention")]
    public IList<V1beta1BucketStatusAtProviderObjectLockConfigurationRuleDefaultRetention>? DefaultRetention { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderObjectLockConfiguration
{
    /// <summary>Indicates whether this bucket has an Object Lock configuration enabled. Valid value is Enabled. Use the top-level argument object_lock_enabled instead.</summary>
    [JsonPropertyName("objectLockEnabled")]
    public string? ObjectLockEnabled { get; set; }

    /// <summary>Object Lock rule in place for this bucket (documented below).</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketStatusAtProviderObjectLockConfigurationRule>? Rule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestinationAccessControlTranslation
{
    /// <summary>Specifies the replica ownership. For default and valid values, see PUT bucket replication in the Amazon S3 API Reference. The only valid value is Destination.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestinationMetrics
{
    /// <summary>Threshold within which objects are to be replicated. The only valid value is 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Status of RTC. Either Enabled or Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestinationReplicationTime
{
    /// <summary>Threshold within which objects are to be replicated. The only valid value is 15.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Status of RTC. Either Enabled or Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestination
{
    /// <summary>Specifies the overrides to use for object owners on replication (documented below). Must be used in conjunction with account_id owner override configuration.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestinationAccessControlTranslation>? AccessControlTranslation { get; set; }

    /// <summary>Account ID to use for overriding the object owner on replication. Must be used in conjunction with access_control_translation override configuration.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>ARN of the S3 bucket where you want Amazon S3 to store replicas of the object identified by the rule.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Enables replication metrics  (documented below).</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestinationMetrics>? Metrics { get; set; }

    /// <summary>Destination KMS encryption key ARN for SSE-KMS replication. Must be used in conjunction with sse_kms_encrypted_objects source selection criteria.</summary>
    [JsonPropertyName("replicaKmsKeyId")]
    public string? ReplicaKmsKeyId { get; set; }

    /// <summary>Enables S3 Replication Time Control (S3 RTC) (documented below).</summary>
    [JsonPropertyName("replicationTime")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestinationReplicationTime>? ReplicationTime { get; set; }

    /// <summary>Specifies the Amazon S3 storage class to which you want the object to transition.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRulesFilter
{
    /// <summary>Object keyname prefix that identifies subset of objects to which the rule applies. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>A map of tags that identifies subset of objects to which the rule applies. The rule applies only to objects having all the tags in its tagset.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects
{
    /// <summary>Enable versioning. Once you version-enable a bucket, it can never return to an unversioned state. You can, however, suspend versioning on that bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRulesSourceSelectionCriteria
{
    /// <summary>Match SSE-KMS encrypted objects (documented below). If specified, replica_kms_key_id in destination must be specified as well.</summary>
    [JsonPropertyName("sseKmsEncryptedObjects")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects>? SseKmsEncryptedObjects { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfigurationRules
{
    /// <summary>Whether delete markers are replicated. The only valid value is Enabled. To disable, omit this argument. This argument is only valid with V2 replication configurations (i.e., when filter is used).</summary>
    [JsonPropertyName("deleteMarkerReplicationStatus")]
    public string? DeleteMarkerReplicationStatus { get; set; }

    /// <summary>Specifies the destination for the rule (documented below).</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRulesDestination>? Destination { get; set; }

    /// <summary>Filter that identifies subset of objects to which the replication rule applies (documented below).</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRulesFilter>? Filter { get; set; }

    /// <summary>Unique identifier for the rule. Must be less than or equal to 255 characters in length.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Object keyname prefix identifying one or more objects to which the rule applies. Must be less than or equal to 1024 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Priority associated with the rule. Priority should only be set if filter is configured. If not provided, defaults to 0. Priority must be unique between multiple rules.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies special object selection criteria (documented below).</summary>
    [JsonPropertyName("sourceSelectionCriteria")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRulesSourceSelectionCriteria>? SourceSelectionCriteria { get; set; }

    /// <summary>Status of the rule. Either Enabled or Disabled. The rule is ignored if status is not Enabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderReplicationConfiguration
{
    /// <summary>ARN of the IAM role for Amazon S3 to assume when replicating the objects.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Specifies the rules managing the replication (documented below).</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfigurationRules>? Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
{
    /// <summary>AWS KMS master key ID used for the SSE-KMS encryption. This can only be used when you set the value of sse_algorithm as aws:kms. The default aws/s3 AWS KMS master key is used if this element is absent while the sse_algorithm is aws:kms.</summary>
    [JsonPropertyName("kmsMasterKeyId")]
    public string? KmsMasterKeyId { get; set; }

    /// <summary>Server-side encryption algorithm to use. Valid values are AES256 and aws:kms</summary>
    [JsonPropertyName("sseAlgorithm")]
    public string? SseAlgorithm { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderServerSideEncryptionConfigurationRule
{
    /// <summary>Single object for setting server-side encryption by default. (documented below)</summary>
    [JsonPropertyName("applyServerSideEncryptionByDefault")]
    public IList<V1beta1BucketStatusAtProviderServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault>? ApplyServerSideEncryptionByDefault { get; set; }

    /// <summary>Whether or not to use Amazon S3 Bucket Keys for SSE-KMS.</summary>
    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderServerSideEncryptionConfiguration
{
    /// <summary>Single object for server-side encryption by default configuration. (documented below)</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1BucketStatusAtProviderServerSideEncryptionConfigurationRule>? Rule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderVersioning
{
    /// <summary>Enable versioning. Once you version-enable a bucket, it can never return to an unversioned state. You can, however, suspend versioning on that bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Enable MFA delete for either Change the versioning state of your bucket or Permanently delete an object version. Default is false. This cannot be used to toggle this setting but is available to allow managed buckets to reflect the state in AWS</summary>
    [JsonPropertyName("mfaDelete")]
    public bool? MfaDelete { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderWebsite
{
    /// <summary>Absolute path to the document to return in case of a 4XX error.</summary>
    [JsonPropertyName("errorDocument")]
    public string? ErrorDocument { get; set; }

    /// <summary>Amazon S3 returns this index document when requests are made to the root domain or any of the subfolders.</summary>
    [JsonPropertyName("indexDocument")]
    public string? IndexDocument { get; set; }

    /// <summary>Hostname to redirect all website requests for this bucket to. Hostname can optionally be prefixed with a protocol (http:// or https://) to use when redirecting requests. The default is the protocol that is used in the original request.</summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public string? RedirectAllRequestsTo { get; set; }

    /// <summary>JSON array containing routing rules describing redirect behavior and when redirects are applied.</summary>
    [JsonPropertyName("routingRules")]
    public string? RoutingRules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProvider
{
    /// <summary>Sets the accelerate configuration of an existing bucket. Can be Enabled or Suspended. Cannot be used in cn-north-1 or us-gov-west-1. Use the resource aws_s3_bucket_accelerate_configuration instead.</summary>
    [JsonPropertyName("accelerationStatus")]
    public string? AccelerationStatus { get; set; }

    /// <summary>The canned ACL to apply. Valid values are private, public-read, public-read-write, aws-exec-read, authenticated-read, and log-delivery-write. Defaults to private.  Conflicts with grant. Use the resource aws_s3_bucket_acl instead.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>ARN of the bucket. Will be of format arn:aws:s3:::bucketname.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Bucket domain name. Will be of format bucketname.s3.amazonaws.com.</summary>
    [JsonPropertyName("bucketDomainName")]
    public string? BucketDomainName { get; set; }

    /// <summary>AWS region this bucket resides in.</summary>
    [JsonPropertyName("bucketRegion")]
    public string? BucketRegion { get; set; }

    /// <summary>The bucket region-specific domain name. The bucket domain name including the region name. Please refer to the S3 endpoints reference for format. Note: AWS CloudFront allows specifying an S3 region-specific endpoint when creating an S3 origin. This will prevent redirect issues from CloudFront to the S3 Origin URL. For more information, see the Virtual Hosted-Style Requests for Other Regions section in the AWS S3 User Guide.</summary>
    [JsonPropertyName("bucketRegionalDomainName")]
    public string? BucketRegionalDomainName { get; set; }

    /// <summary>Rule of Cross-Origin Resource Sharing. See CORS rule below for details. Use the resource aws_s3_bucket_cors_configuration instead.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1BucketStatusAtProviderCorsRule>? CorsRule { get; set; }

    /// <summary>Boolean that indicates all objects (including any locked objects) should be deleted from the bucket when the bucket is destroyed so that the bucket can be destroyed without error. These objects are not recoverable. This only deletes objects when the bucket is destroyed, not when setting this parameter to true. If setting this field in the same operation that would require replacing the bucket or destroying the bucket, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>An ACL policy grant. See Grant below for details. Conflicts with acl. Use the resource aws_s3_bucket_acl instead.</summary>
    [JsonPropertyName("grant")]
    public IList<V1beta1BucketStatusAtProviderGrant>? Grant { get; set; }

    /// <summary>Route 53 Hosted Zone ID for this bucket's region.</summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration of object lifecycle management. See Lifecycle Rule below for details. Use the resource aws_s3_bucket_lifecycle_configuration instead.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>Configuration of S3 bucket logging parameters. See Logging below for details. Use the resource aws_s3_bucket_logging instead.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1BucketStatusAtProviderLogging>? Logging { get; set; }

    /// <summary>Configuration of S3 object locking. See Object Lock Configuration below for details. Use the object_lock_enabled parameter and the resource aws_s3_bucket_object_lock_configuration instead.</summary>
    [JsonPropertyName("objectLockConfiguration")]
    public IList<V1beta1BucketStatusAtProviderObjectLockConfiguration>? ObjectLockConfiguration { get; set; }

    /// <summary>Indicates whether this bucket has an Object Lock configuration enabled. Valid values are true or false. This argument is not supported in all regions or partitions.</summary>
    [JsonPropertyName("objectLockEnabled")]
    public bool? ObjectLockEnabled { get; set; }

    /// <summary>Valid bucket policy JSON document. In this case, please make sure you use the verbose/specific version of the policy. Use the resource aws_s3_bucket_policy instead.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration of replication configuration. See Replication Configuration below for details. Use the resource aws_s3_bucket_replication_configuration instead.</summary>
    [JsonPropertyName("replicationConfiguration")]
    public IList<V1beta1BucketStatusAtProviderReplicationConfiguration>? ReplicationConfiguration { get; set; }

    /// <summary>Specifies who should bear the cost of Amazon S3 data transfer. Can be either BucketOwner or Requester. By default, the owner of the S3 bucket would incur the costs of any data transfer. See Requester Pays Buckets developer guide for more information. Use the resource aws_s3_bucket_request_payment_configuration instead.</summary>
    [JsonPropertyName("requestPayer")]
    public string? RequestPayer { get; set; }

    /// <summary>Configuration of server-side encryption configuration. See Server Side Encryption Configuration below for details. Use the resource aws_s3_bucket_server_side_encryption_configuration instead.</summary>
    [JsonPropertyName("serverSideEncryptionConfiguration")]
    public IList<V1beta1BucketStatusAtProviderServerSideEncryptionConfiguration>? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration of the S3 bucket versioning state. See Versioning below for details. Use the resource aws_s3_bucket_versioning instead.</summary>
    [JsonPropertyName("versioning")]
    public IList<V1beta1BucketStatusAtProviderVersioning>? Versioning { get; set; }

    /// <summary>Configuration of the S3 bucket website. See Website below for details. Use the resource aws_s3_bucket_website_configuration instead.</summary>
    [JsonPropertyName("website")]
    public IList<V1beta1BucketStatusAtProviderWebsite>? Website { get; set; }

    /// <summary>(Deprecated) Domain of the website endpoint, if the bucket is configured with a website. If not, this will be an empty string. This is used to create Route 53 alias records. Use the resource aws_s3_bucket_website_configuration instead.</summary>
    [JsonPropertyName("websiteDomain")]
    public string? WebsiteDomain { get; set; }

    /// <summary>(Deprecated) Website endpoint, if the bucket is configured with a website. If not, this will be an empty string. Use the resource aws_s3_bucket_website_configuration instead.</summary>
    [JsonPropertyName("websiteEndpoint")]
    public string? WebsiteEndpoint { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusConditions
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
/// <summary>BucketStatus defines the observed state of Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Bucket is the Schema for the Buckets API. Provides a S3 bucket resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Bucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketSpec>, IStatus<V1beta1BucketStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Bucket";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "buckets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketSpec defines the desired state of Bucket</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketSpec Spec { get; set; }

    /// <summary>BucketStatus defines the observed state of Bucket.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketStatus? Status { get; set; }
}
#nullable disable
