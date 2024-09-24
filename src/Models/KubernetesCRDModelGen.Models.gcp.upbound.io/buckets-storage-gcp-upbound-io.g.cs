using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.gcp.upbound.io;
public enum V1beta1BucketSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1BucketSpecForProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object's access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

public partial class V1beta1BucketSpecForProviderCors
{
    /// <summary>The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }

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

public partial class V1beta1BucketSpecForProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

public partial class V1beta1BucketSpecForProviderEncryption
{
    /// <summary>: The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.</summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

public partial class V1beta1BucketSpecForProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1BucketSpecForProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object.</summary>
    [JsonPropertyName("daysSinceNoncurrentTime")]
    public double? DaysSinceNoncurrentTime { get; set; }

    /// <summary>One or more matching name prefixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesPrefix")]
    public IList<string>? MatchesPrefix { get; set; }

    /// <summary>Storage Class of objects to satisfy this condition. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, DURABLE_REDUCED_AVAILABILITY.</summary>
    [JsonPropertyName("matchesStorageClass")]
    public IList<string>? MatchesStorageClass { get; set; }

    /// <summary>One or more matching name suffixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesSuffix")]
    public IList<string>? MatchesSuffix { get; set; }

    /// <summary>While set true, age value will be omitted. Note Required to set true when age is unset in the config file.</summary>
    [JsonPropertyName("noAge")]
    public bool? NoAge { get; set; }

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, days_since_custom_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_custom_time field. It can be used alone or together with days_since_custom_time.</summary>
    [JsonPropertyName("sendDaysSinceCustomTimeIfZero")]
    public bool? SendDaysSinceCustomTimeIfZero { get; set; }

    /// <summary>While set true, days_since_noncurrent_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_noncurrent_time field. It can be used alone or together with days_since_noncurrent_time.</summary>
    [JsonPropertyName("sendDaysSinceNoncurrentTimeIfZero")]
    public bool? SendDaysSinceNoncurrentTimeIfZero { get; set; }

    /// <summary>While set true, num_newer_versions value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the num_newer_versions field. It can be used alone or together with num_newer_versions.</summary>
    [JsonPropertyName("sendNumNewerVersionsIfZero")]
    public bool? SendNumNewerVersionsIfZero { get; set; }

    /// <summary>Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: "LIVE", "ARCHIVED", "ANY".</summary>
    [JsonPropertyName("withState")]
    public string? WithState { get; set; }
}

public partial class V1beta1BucketSpecForProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1BucketSpecForProviderLifecycleRuleAction>? Action { get; set; }

    /// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1BucketSpecForProviderLifecycleRuleCondition>? Condition { get; set; }
}

public partial class V1beta1BucketSpecForProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>The object prefix for log objects. If it's not provided, by default GCS sets this to this bucket's name.</summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

public partial class V1beta1BucketSpecForProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket's retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

public partial class V1beta1BucketSpecForProviderSoftDeletePolicy
{
    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

public partial class V1beta1BucketSpecForProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1BucketSpecForProviderWebsite
{
    /// <summary>Behaves as the bucket's directory index where missing objects are treated as potential directories.</summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>The custom object to return when a requested resource is not found.</summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

public partial class V1beta1BucketSpecForProvider
{
    /// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public IList<V1beta1BucketSpecForProviderAutoclass>? Autoclass { get; set; }

    /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1BucketSpecForProviderCors>? Cors { get; set; }

    /// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public IList<V1beta1BucketSpecForProviderCustomPlacementConfig>? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1BucketSpecForProviderEncryption>? Encryption { get; set; }

    /// <summary>When deleting a bucket, this boolean option will delete all contained objects.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket's Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1BucketSpecForProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket's Access & Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1BucketSpecForProviderLogging>? Logging { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are "inherited" or "enforced". If "inherited", the bucket uses public access prevention. only if the bucket is subject to the public access prevention organization policy constraint. Defaults to "inherited".</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1BucketSpecForProviderRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. "DEFAULT" sets default replication. "ASYNC_TURBO" value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to "DEFAULT" for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public IList<V1beta1BucketSpecForProviderSoftDeletePolicy>? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public IList<V1beta1BucketSpecForProviderVersioning>? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public IList<V1beta1BucketSpecForProviderWebsite>? Website { get; set; }
}

public partial class V1beta1BucketSpecInitProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object's access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

public partial class V1beta1BucketSpecInitProviderCors
{
    /// <summary>The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }

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

public partial class V1beta1BucketSpecInitProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

public partial class V1beta1BucketSpecInitProviderEncryption
{
    /// <summary>: The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.</summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

public partial class V1beta1BucketSpecInitProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1BucketSpecInitProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object.</summary>
    [JsonPropertyName("daysSinceNoncurrentTime")]
    public double? DaysSinceNoncurrentTime { get; set; }

    /// <summary>One or more matching name prefixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesPrefix")]
    public IList<string>? MatchesPrefix { get; set; }

    /// <summary>Storage Class of objects to satisfy this condition. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, DURABLE_REDUCED_AVAILABILITY.</summary>
    [JsonPropertyName("matchesStorageClass")]
    public IList<string>? MatchesStorageClass { get; set; }

    /// <summary>One or more matching name suffixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesSuffix")]
    public IList<string>? MatchesSuffix { get; set; }

    /// <summary>While set true, age value will be omitted. Note Required to set true when age is unset in the config file.</summary>
    [JsonPropertyName("noAge")]
    public bool? NoAge { get; set; }

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, days_since_custom_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_custom_time field. It can be used alone or together with days_since_custom_time.</summary>
    [JsonPropertyName("sendDaysSinceCustomTimeIfZero")]
    public bool? SendDaysSinceCustomTimeIfZero { get; set; }

    /// <summary>While set true, days_since_noncurrent_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_noncurrent_time field. It can be used alone or together with days_since_noncurrent_time.</summary>
    [JsonPropertyName("sendDaysSinceNoncurrentTimeIfZero")]
    public bool? SendDaysSinceNoncurrentTimeIfZero { get; set; }

    /// <summary>While set true, num_newer_versions value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the num_newer_versions field. It can be used alone or together with num_newer_versions.</summary>
    [JsonPropertyName("sendNumNewerVersionsIfZero")]
    public bool? SendNumNewerVersionsIfZero { get; set; }

    /// <summary>Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: "LIVE", "ARCHIVED", "ANY".</summary>
    [JsonPropertyName("withState")]
    public string? WithState { get; set; }
}

public partial class V1beta1BucketSpecInitProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1BucketSpecInitProviderLifecycleRuleAction>? Action { get; set; }

    /// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1BucketSpecInitProviderLifecycleRuleCondition>? Condition { get; set; }
}

public partial class V1beta1BucketSpecInitProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>The object prefix for log objects. If it's not provided, by default GCS sets this to this bucket's name.</summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

public partial class V1beta1BucketSpecInitProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket's retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

public partial class V1beta1BucketSpecInitProviderSoftDeletePolicy
{
    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

public partial class V1beta1BucketSpecInitProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1BucketSpecInitProviderWebsite
{
    /// <summary>Behaves as the bucket's directory index where missing objects are treated as potential directories.</summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>The custom object to return when a requested resource is not found.</summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

public partial class V1beta1BucketSpecInitProvider
{
    /// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public IList<V1beta1BucketSpecInitProviderAutoclass>? Autoclass { get; set; }

    /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1BucketSpecInitProviderCors>? Cors { get; set; }

    /// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public IList<V1beta1BucketSpecInitProviderCustomPlacementConfig>? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1BucketSpecInitProviderEncryption>? Encryption { get; set; }

    /// <summary>When deleting a bucket, this boolean option will delete all contained objects.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket's Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1BucketSpecInitProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket's Access & Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1BucketSpecInitProviderLogging>? Logging { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are "inherited" or "enforced". If "inherited", the bucket uses public access prevention. only if the bucket is subject to the public access prevention organization policy constraint. Defaults to "inherited".</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1BucketSpecInitProviderRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. "DEFAULT" sets default replication. "ASYNC_TURBO" value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to "DEFAULT" for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public IList<V1beta1BucketSpecInitProviderSoftDeletePolicy>? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public IList<V1beta1BucketSpecInitProviderVersioning>? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public IList<V1beta1BucketSpecInitProviderWebsite>? Website { get; set; }
}

public enum V1beta1BucketSpecManagementPoliciesEnum
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

public enum V1beta1BucketSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BucketSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BucketSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BucketSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1BucketSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1BucketSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1BucketSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BucketSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BucketSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1BucketSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1BucketSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketSpecDeletionPolicyEnum>))]
    public V1beta1BucketSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BucketSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BucketSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1BucketStatusAtProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object's access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

public partial class V1beta1BucketStatusAtProviderCors
{
    /// <summary>The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }

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

public partial class V1beta1BucketStatusAtProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

public partial class V1beta1BucketStatusAtProviderEncryption
{
    /// <summary>: The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.</summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

public partial class V1beta1BucketStatusAtProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1BucketStatusAtProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object.</summary>
    [JsonPropertyName("daysSinceNoncurrentTime")]
    public double? DaysSinceNoncurrentTime { get; set; }

    /// <summary>One or more matching name prefixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesPrefix")]
    public IList<string>? MatchesPrefix { get; set; }

    /// <summary>Storage Class of objects to satisfy this condition. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, DURABLE_REDUCED_AVAILABILITY.</summary>
    [JsonPropertyName("matchesStorageClass")]
    public IList<string>? MatchesStorageClass { get; set; }

    /// <summary>One or more matching name suffixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesSuffix")]
    public IList<string>? MatchesSuffix { get; set; }

    /// <summary>While set true, age value will be omitted. Note Required to set true when age is unset in the config file.</summary>
    [JsonPropertyName("noAge")]
    public bool? NoAge { get; set; }

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, days_since_custom_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_custom_time field. It can be used alone or together with days_since_custom_time.</summary>
    [JsonPropertyName("sendDaysSinceCustomTimeIfZero")]
    public bool? SendDaysSinceCustomTimeIfZero { get; set; }

    /// <summary>While set true, days_since_noncurrent_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_noncurrent_time field. It can be used alone or together with days_since_noncurrent_time.</summary>
    [JsonPropertyName("sendDaysSinceNoncurrentTimeIfZero")]
    public bool? SendDaysSinceNoncurrentTimeIfZero { get; set; }

    /// <summary>While set true, num_newer_versions value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the num_newer_versions field. It can be used alone or together with num_newer_versions.</summary>
    [JsonPropertyName("sendNumNewerVersionsIfZero")]
    public bool? SendNumNewerVersionsIfZero { get; set; }

    /// <summary>Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: "LIVE", "ARCHIVED", "ANY".</summary>
    [JsonPropertyName("withState")]
    public string? WithState { get; set; }
}

public partial class V1beta1BucketStatusAtProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRuleAction>? Action { get; set; }

    /// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRuleCondition>? Condition { get; set; }
}

public partial class V1beta1BucketStatusAtProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>The object prefix for log objects. If it's not provided, by default GCS sets this to this bucket's name.</summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

public partial class V1beta1BucketStatusAtProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket's retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

public partial class V1beta1BucketStatusAtProviderSoftDeletePolicy
{
    /// <summary>(Computed) Server-determined value that indicates the time from which the policy, or one with a greater retention, was effective. This value is in RFC 3339 format.</summary>
    [JsonPropertyName("effectiveTime")]
    public string? EffectiveTime { get; set; }

    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

public partial class V1beta1BucketStatusAtProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1BucketStatusAtProviderWebsite
{
    /// <summary>Behaves as the bucket's directory index where missing objects are treated as potential directories.</summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>The custom object to return when a requested resource is not found.</summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

public partial class V1beta1BucketStatusAtProvider
{
    /// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public IList<V1beta1BucketStatusAtProviderAutoclass>? Autoclass { get; set; }

    /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1BucketStatusAtProviderCors>? Cors { get; set; }

    /// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public IList<V1beta1BucketStatusAtProviderCustomPlacementConfig>? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1BucketStatusAtProviderEncryption>? Encryption { get; set; }

    /// <summary>When deleting a bucket, this boolean option will delete all contained objects.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket's Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket's Access & Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public IList<V1beta1BucketStatusAtProviderLogging>? Logging { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectNumber")]
    public double? ProjectNumber { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are "inherited" or "enforced". If "inherited", the bucket uses public access prevention. only if the bucket is subject to the public access prevention organization policy constraint. Defaults to "inherited".</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1BucketStatusAtProviderRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. "DEFAULT" sets default replication. "ASYNC_TURBO" value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to "DEFAULT" for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public IList<V1beta1BucketStatusAtProviderSoftDeletePolicy>? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The base URL of the bucket, in the format gs://<bucket-name>.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public IList<V1beta1BucketStatusAtProviderVersioning>? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public IList<V1beta1BucketStatusAtProviderWebsite>? Website { get; set; }
}

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

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Bucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketSpec>, IStatus<V1beta1BucketStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Bucket";
    public const string KubeGroup = "storage.gcp.upbound.io";
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