using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.gcp.m.upbound.io;
/// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object's access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

/// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderEncryption
{
    /// <summary>: The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.</summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

/// <summary>The bucket's hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderHierarchicalNamespace
{
    /// <summary>Enables hierarchical namespace for the bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderIpFilterPublicNetworkSource
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderIpFilterVpcNetworkSources
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }

    /// <summary>Name of the network. Format: projects/PROJECT_ID/global/networks/NETWORK_NAME</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderIpFilter
{
    /// <summary>While set true, allows all service agents to access the bucket regardless of the IP filter configuration.</summary>
    [JsonPropertyName("allowAllServiceAgentAccess")]
    public bool? AllowAllServiceAgentAccess { get; set; }

    /// <summary>While set true, allows cross-org VPCs in the bucket's IP filter configuration.</summary>
    [JsonPropertyName("allowCrossOrgVpcs")]
    public bool? AllowCrossOrgVpcs { get; set; }

    /// <summary>The state of the IP filter configuration. Valid values are Enabled and Disabled. When set to Enabled, IP filtering rules are applied to a bucket and all incoming requests to the bucket are evaluated against these rules. When set to Disabled, IP filtering rules are not applied to a bucket. Note: allow_all_service_agent_access must be supplied when mode is set to Enabled, it can be ommited for other values.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
    [JsonPropertyName("publicNetworkSource")]
    public V1beta1BucketSpecForProviderIpFilterPublicNetworkSource? PublicNetworkSource { get; set; }

    /// <summary>The list of VPC networks that can access the bucket. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta1BucketSpecForProviderIpFilterVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition. Note To set 0 value of age, send_age_if_zero should be set true otherwise 0 value of age field will be ignored.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_custom_time condition.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_noncurrent_time condition.</summary>
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

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent. When set to 0 it will be ignored, and your state will treat it as though you supplied no noncurrent_time_before condition.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition. When set to 0 it will be ignored and your state will treat it as though you supplied no num_newer_versions condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, age value will be sent in the request even for zero value of the field. This field is only useful and required for setting 0 value to the age field. It can be used alone or together with age attribute. NOTE age attibute with 0 value will be ommitted from the API request if send_age_if_zero field is having false value.</summary>
    [JsonPropertyName("sendAgeIfZero")]
    public bool? SendAgeIfZero { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public V1beta1BucketSpecForProviderLifecycleRuleAction? Action { get; set; }

    /// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public V1beta1BucketSpecForProviderLifecycleRuleCondition? Condition { get; set; }
}

/// <summary>The bucket's Access &amp; Storage Logs configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>The object prefix for log objects. If it's not provided, by default GCS sets this to this bucket's name.</summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

/// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket's retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

/// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderSoftDeletePolicy
{
    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

/// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProviderWebsite
{
    /// <summary>Behaves as the bucket's directory index where missing objects are treated as potential directories.</summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>The custom object to return when a requested resource is not found.</summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecForProvider
{
    /// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public V1beta1BucketSpecForProviderAutoclass? Autoclass { get; set; }

    /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1BucketSpecForProviderCors>? Cors { get; set; }

    /// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public V1beta1BucketSpecForProviderCustomPlacementConfig? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public V1beta1BucketSpecForProviderEncryption? Encryption { get; set; }

    /// <summary>When deleting a bucket, this boolean option will delete all contained objects.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The bucket's hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
    [JsonPropertyName("hierarchicalNamespace")]
    public V1beta1BucketSpecForProviderHierarchicalNamespace? HierarchicalNamespace { get; set; }

    /// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
    [JsonPropertyName("ipFilter")]
    public V1beta1BucketSpecForProviderIpFilter? IpFilter { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket's Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1BucketSpecForProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket's Access &amp; Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public V1beta1BucketSpecForProviderLogging? Logging { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are "inherited" or "enforced". If "inherited", the bucket uses public access prevention only if the bucket is subject to the public access prevention organization policy constraint. Defaults to "inherited".</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1BucketSpecForProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. "DEFAULT" sets default replication. "ASYNC_TURBO" value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to "DEFAULT" for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta1BucketSpecForProviderSoftDeletePolicy? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public V1beta1BucketSpecForProviderVersioning? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public V1beta1BucketSpecForProviderWebsite? Website { get; set; }
}

/// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object's access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

/// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderEncryption
{
    /// <summary>: The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.</summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

/// <summary>The bucket's hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderHierarchicalNamespace
{
    /// <summary>Enables hierarchical namespace for the bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderIpFilterPublicNetworkSource
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderIpFilterVpcNetworkSources
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }

    /// <summary>Name of the network. Format: projects/PROJECT_ID/global/networks/NETWORK_NAME</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderIpFilter
{
    /// <summary>While set true, allows all service agents to access the bucket regardless of the IP filter configuration.</summary>
    [JsonPropertyName("allowAllServiceAgentAccess")]
    public bool? AllowAllServiceAgentAccess { get; set; }

    /// <summary>While set true, allows cross-org VPCs in the bucket's IP filter configuration.</summary>
    [JsonPropertyName("allowCrossOrgVpcs")]
    public bool? AllowCrossOrgVpcs { get; set; }

    /// <summary>The state of the IP filter configuration. Valid values are Enabled and Disabled. When set to Enabled, IP filtering rules are applied to a bucket and all incoming requests to the bucket are evaluated against these rules. When set to Disabled, IP filtering rules are not applied to a bucket. Note: allow_all_service_agent_access must be supplied when mode is set to Enabled, it can be ommited for other values.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
    [JsonPropertyName("publicNetworkSource")]
    public V1beta1BucketSpecInitProviderIpFilterPublicNetworkSource? PublicNetworkSource { get; set; }

    /// <summary>The list of VPC networks that can access the bucket. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta1BucketSpecInitProviderIpFilterVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition. Note To set 0 value of age, send_age_if_zero should be set true otherwise 0 value of age field will be ignored.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_custom_time condition.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_noncurrent_time condition.</summary>
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

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent. When set to 0 it will be ignored, and your state will treat it as though you supplied no noncurrent_time_before condition.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition. When set to 0 it will be ignored and your state will treat it as though you supplied no num_newer_versions condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, age value will be sent in the request even for zero value of the field. This field is only useful and required for setting 0 value to the age field. It can be used alone or together with age attribute. NOTE age attibute with 0 value will be ommitted from the API request if send_age_if_zero field is having false value.</summary>
    [JsonPropertyName("sendAgeIfZero")]
    public bool? SendAgeIfZero { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public V1beta1BucketSpecInitProviderLifecycleRuleAction? Action { get; set; }

    /// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public V1beta1BucketSpecInitProviderLifecycleRuleCondition? Condition { get; set; }
}

/// <summary>The bucket's Access &amp; Storage Logs configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>The object prefix for log objects. If it's not provided, by default GCS sets this to this bucket's name.</summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

/// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket's retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

/// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderSoftDeletePolicy
{
    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

/// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProviderWebsite
{
    /// <summary>Behaves as the bucket's directory index where missing objects are treated as potential directories.</summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>The custom object to return when a requested resource is not found.</summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecInitProvider
{
    /// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public V1beta1BucketSpecInitProviderAutoclass? Autoclass { get; set; }

    /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1BucketSpecInitProviderCors>? Cors { get; set; }

    /// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public V1beta1BucketSpecInitProviderCustomPlacementConfig? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public V1beta1BucketSpecInitProviderEncryption? Encryption { get; set; }

    /// <summary>When deleting a bucket, this boolean option will delete all contained objects.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The bucket's hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
    [JsonPropertyName("hierarchicalNamespace")]
    public V1beta1BucketSpecInitProviderHierarchicalNamespace? HierarchicalNamespace { get; set; }

    /// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
    [JsonPropertyName("ipFilter")]
    public V1beta1BucketSpecInitProviderIpFilter? IpFilter { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket's Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1BucketSpecInitProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket's Access &amp; Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public V1beta1BucketSpecInitProviderLogging? Logging { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are "inherited" or "enforced". If "inherited", the bucket uses public access prevention only if the bucket is subject to the public access prevention organization policy constraint. Defaults to "inherited".</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1BucketSpecInitProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. "DEFAULT" sets default replication. "ASYNC_TURBO" value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to "DEFAULT" for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta1BucketSpecInitProviderSoftDeletePolicy? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public V1beta1BucketSpecInitProviderVersioning? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public V1beta1BucketSpecInitProviderWebsite? Website { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BucketSpec defines the desired state of Bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object's access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

/// <summary>The bucket's encryption configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderEncryption
{
    /// <summary>: The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.</summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

/// <summary>The bucket's hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderHierarchicalNamespace
{
    /// <summary>Enables hierarchical namespace for the bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderIpFilterPublicNetworkSource
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderIpFilterVpcNetworkSources
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }

    /// <summary>Name of the network. Format: projects/PROJECT_ID/global/networks/NETWORK_NAME</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderIpFilter
{
    /// <summary>While set true, allows all service agents to access the bucket regardless of the IP filter configuration.</summary>
    [JsonPropertyName("allowAllServiceAgentAccess")]
    public bool? AllowAllServiceAgentAccess { get; set; }

    /// <summary>While set true, allows cross-org VPCs in the bucket's IP filter configuration.</summary>
    [JsonPropertyName("allowCrossOrgVpcs")]
    public bool? AllowCrossOrgVpcs { get; set; }

    /// <summary>The state of the IP filter configuration. Valid values are Enabled and Disabled. When set to Enabled, IP filtering rules are applied to a bucket and all incoming requests to the bucket are evaluated against these rules. When set to Disabled, IP filtering rules are not applied to a bucket. Note: allow_all_service_agent_access must be supplied when mode is set to Enabled, it can be ommited for other values.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
    [JsonPropertyName("publicNetworkSource")]
    public V1beta1BucketStatusAtProviderIpFilterPublicNetworkSource? PublicNetworkSource { get; set; }

    /// <summary>The list of VPC networks that can access the bucket. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta1BucketStatusAtProviderIpFilterVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition. Note To set 0 value of age, send_age_if_zero should be set true otherwise 0 value of age field will be ignored.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_custom_time condition.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_noncurrent_time condition.</summary>
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

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent. When set to 0 it will be ignored, and your state will treat it as though you supplied no noncurrent_time_before condition.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition. When set to 0 it will be ignored and your state will treat it as though you supplied no num_newer_versions condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, age value will be sent in the request even for zero value of the field. This field is only useful and required for setting 0 value to the age field. It can be used alone or together with age attribute. NOTE age attibute with 0 value will be ommitted from the API request if send_age_if_zero field is having false value.</summary>
    [JsonPropertyName("sendAgeIfZero")]
    public bool? SendAgeIfZero { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule's action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public V1beta1BucketStatusAtProviderLifecycleRuleAction? Action { get; set; }

    /// <summary>The Lifecycle Rule's condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public V1beta1BucketStatusAtProviderLifecycleRuleCondition? Condition { get; set; }
}

/// <summary>The bucket's Access &amp; Storage Logs configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>The object prefix for log objects. If it's not provided, by default GCS sets this to this bucket's name.</summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

/// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket's retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

/// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderSoftDeletePolicy
{
    /// <summary>(Computed) Server-determined value that indicates the time from which the policy, or one with a greater retention, was effective. This value is in RFC 3339 format.</summary>
    [JsonPropertyName("effectiveTime")]
    public string? EffectiveTime { get; set; }

    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

/// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProviderWebsite
{
    /// <summary>Behaves as the bucket's directory index where missing objects are treated as potential directories.</summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>The custom object to return when a requested resource is not found.</summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketStatusAtProvider
{
    /// <summary>The bucket's Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public V1beta1BucketStatusAtProviderAutoclass? Autoclass { get; set; }

    /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta1BucketStatusAtProviderCors>? Cors { get; set; }

    /// <summary>The bucket's custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public V1beta1BucketStatusAtProviderCustomPlacementConfig? CustomPlacementConfig { get; set; }

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
    public V1beta1BucketStatusAtProviderEncryption? Encryption { get; set; }

    /// <summary>When deleting a bucket, this boolean option will delete all contained objects.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The bucket's hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
    [JsonPropertyName("hierarchicalNamespace")]
    public V1beta1BucketStatusAtProviderHierarchicalNamespace? HierarchicalNamespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
    [JsonPropertyName("ipFilter")]
    public V1beta1BucketStatusAtProviderIpFilter? IpFilter { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket's Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta1BucketStatusAtProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket's Access &amp; Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public V1beta1BucketStatusAtProviderLogging? Logging { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectNumber")]
    public double? ProjectNumber { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are "inherited" or "enforced". If "inherited", the bucket uses public access prevention only if the bucket is subject to the public access prevention organization policy constraint. Defaults to "inherited".</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket's data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta1BucketStatusAtProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. "DEFAULT" sets default replication. "ASYNC_TURBO" value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to "DEFAULT" for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta1BucketStatusAtProviderSoftDeletePolicy? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>(Computed) The creation time of the bucket in RFC 3339 format.</summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>(Computed) The time at which the bucket's metadata or IAM policy was last updated, in RFC 3339 format.</summary>
    [JsonPropertyName("updated")]
    public string? Updated { get; set; }

    /// <summary>The base URL of the bucket, in the format gs://&lt;bucket-name&gt;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The bucket's Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public V1beta1BucketStatusAtProviderVersioning? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public V1beta1BucketStatusAtProviderWebsite? Website { get; set; }
}

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

/// <summary>Bucket is the Schema for the Buckets API. Creates a new bucket in Google Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Bucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketSpec>, IStatus<V1beta1BucketStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Bucket";
    public const string KubeGroup = "storage.gcp.m.upbound.io";
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

/// <summary>Bucket is the Schema for the Buckets API. Creates a new bucket in Google Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Bucket>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketList";
    public const string KubeGroup = "storage.gcp.m.upbound.io";
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