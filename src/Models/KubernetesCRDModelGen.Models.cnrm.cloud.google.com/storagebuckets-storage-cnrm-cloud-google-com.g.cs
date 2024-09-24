using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.cnrm.cloud.google.com;
/// <summary>The bucket's autoclass configuration.</summary>
public partial class V1beta1StorageBucketSpecAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object's access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageBucketSpecCors
{
    /// <summary>The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public int? MaxAgeSeconds { get; set; }

    /// <summary>The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: "*" is permitted in the list of methods, and means "any method".</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The list of Origins eligible to receive CORS response headers. Note: "*" is permitted in the list of origins, and means "any Origin".</summary>
    [JsonPropertyName("origin")]
    public IList<string>? Origin { get; set; }

    /// <summary>The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<string>? ResponseHeader { get; set; }
}

/// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty.</summary>
public partial class V1beta1StorageBucketSpecCustomPlacementConfig
{
    /// <summary>Immutable. The list of individual regions that comprise a dual-region bucket. See the docs for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string> DataLocations { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageBucketSpecEncryptionKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The bucket's encryption configuration.</summary>
public partial class V1beta1StorageBucketSpecEncryption
{
    /// <summary></summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1StorageBucketSpecEncryptionKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported.</summary>
public partial class V1beta1StorageBucketSpecLifecycleRuleAction
{
    /// <summary>The target Storage Class of objects affected by this Lifecycle Rule. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The Lifecycle Rule's condition configuration.</summary>
public partial class V1beta1StorageBucketSpecLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition.</summary>
    [JsonPropertyName("age")]
    public int? Age { get; set; }

    /// <summary>Creation date of an object in RFC 3339 (e.g. 2017-06-13) to satisfy this condition.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>Creation date of an object in RFC 3339 (e.g. 2017-06-13) to satisfy this condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Number of days elapsed since the user-specified timestamp set on an object.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public int? DaysSinceCustomTime { get; set; }

    /// <summary>Number of days elapsed since the noncurrent timestamp of an object. This 										condition is relevant only for versioned objects.</summary>
    [JsonPropertyName("daysSinceNoncurrentTime")]
    public int? DaysSinceNoncurrentTime { get; set; }

    /// <summary>One or more matching name prefixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesPrefix")]
    public IList<string>? MatchesPrefix { get; set; }

    /// <summary>Storage Class of objects to satisfy this condition. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, STANDARD, DURABLE_REDUCED_AVAILABILITY.</summary>
    [JsonPropertyName("matchesStorageClass")]
    public IList<string>? MatchesStorageClass { get; set; }

    /// <summary>One or more matching name suffixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesSuffix")]
    public IList<string>? MatchesSuffix { get; set; }

    /// <summary>Creation date of an object in RFC 3339 (e.g. 2017-06-13) to satisfy this condition.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public int? NumNewerVersions { get; set; }

    /// <summary>Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: "LIVE", "ARCHIVED", "ANY".</summary>
    [JsonPropertyName("withState")]
    public string? WithState { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageBucketSpecLifecycleRule
{
    /// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported.</summary>
    [JsonPropertyName("action")]
    public V1beta1StorageBucketSpecLifecycleRuleAction Action { get; set; }

    /// <summary>The Lifecycle Rule's condition configuration.</summary>
    [JsonPropertyName("condition")]
    public V1beta1StorageBucketSpecLifecycleRuleCondition Condition { get; set; }
}

/// <summary>The bucket's Access &amp; Storage Logs configuration.</summary>
public partial class V1beta1StorageBucketSpecLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string LogBucket { get; set; }

    /// <summary>The object prefix for log objects. If it's not provided, by default Google Cloud Storage sets this to this bucket's name.</summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

/// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained.</summary>
public partial class V1beta1StorageBucketSpecRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket's retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 3,155,760,000 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public int RetentionPeriod { get; set; }
}

/// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy.</summary>
public partial class V1beta1StorageBucketSpecSoftDeletePolicy
{
    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public int? RetentionDurationSeconds { get; set; }
}

/// <summary>The bucket's Versioning configuration.</summary>
public partial class V1beta1StorageBucketSpecVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Configuration if the bucket acts as a website.</summary>
public partial class V1beta1StorageBucketSpecWebsite
{
    /// <summary>Behaves as the bucket's directory index where missing objects are treated as potential directories.</summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>The custom object to return when a requested resource is not found.</summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageBucketSpec
{
    /// <summary>The bucket's autoclass configuration.</summary>
    [JsonPropertyName("autoclass")]
    public V1beta1StorageBucketSpecAutoclass? Autoclass { get; set; }

    /// <summary>DEPRECATED. Please use the `uniformBucketLevelAccess` field as this field has been renamed by Google. The `uniformBucketLevelAccess` field will supersede this field. Enables Bucket PolicyOnly access to a bucket.</summary>
    [JsonPropertyName("bucketPolicyOnly")]
    public bool? BucketPolicyOnly { get; set; }

    /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1StorageBucketSpecCors>? Cors { get; set; }

    /// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public V1beta1StorageBucketSpecCustomPlacementConfig? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>The bucket's encryption configuration.</summary>
    [JsonPropertyName("encryption")]
    public V1beta1StorageBucketSpecEncryption? Encryption { get; set; }

    /// <summary>The bucket's Lifecycle Rules configuration.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1StorageBucketSpecLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>Immutable. The Google Cloud Storage location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket's Access &amp; Storage Logs configuration.</summary>
    [JsonPropertyName("logging")]
    public V1beta1StorageBucketSpecLogging? Logging { get; set; }

    /// <summary>Prevents public access to a bucket.</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1StorageBucketSpecRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta1StorageBucketSpecSoftDeletePolicy? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Enables uniform bucket-level access on a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The bucket's Versioning configuration.</summary>
    [JsonPropertyName("versioning")]
    public V1beta1StorageBucketSpecVersioning? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website.</summary>
    [JsonPropertyName("website")]
    public V1beta1StorageBucketSpecWebsite? Website { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageBucketStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy.</summary>
public partial class V1beta1StorageBucketStatusObservedStateSoftDeletePolicy
{
    /// <summary>Server-determined value that indicates the time from which the policy, or one with a greater retention, was effective. This value is in RFC 3339 format.</summary>
    [JsonPropertyName("effectiveTime")]
    public string? EffectiveTime { get; set; }

    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public int? RetentionDurationSeconds { get; set; }
}

/// <summary>The observed state of the underlying GCP resource.</summary>
public partial class V1beta1StorageBucketStatusObservedState
{
    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta1StorageBucketStatusObservedStateSoftDeletePolicy? SoftDeletePolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1StorageBucketStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageBucketStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1StorageBucketStatusObservedState? ObservedState { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The base URL of the bucket, in the format gs://&lt;bucket-name&gt;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1StorageBucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageBucketSpec>, IStatus<V1beta1StorageBucketStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageBucket";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagebuckets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1StorageBucketSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1StorageBucketStatus? Status { get; set; }
}