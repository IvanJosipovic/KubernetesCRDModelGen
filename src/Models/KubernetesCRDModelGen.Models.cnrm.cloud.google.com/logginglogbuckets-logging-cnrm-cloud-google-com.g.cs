using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.cnrm.cloud.google.com;
/// <summary>Immutable. The BillingAccount that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogBucketSpecBillingAccountRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a Google Cloud Billing Account (format: `billingAccounts/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] BillingAccount not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Folder that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogBucketSpecFolderRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a `Folder` resource (format: `folders/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Organization that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogBucketSpecOrganizationRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a Google Cloud Organization (format: `organizations/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] Organization not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogBucketSpecProjectRef
{
    /// <summary>Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogBucketSpec
{
    /// <summary>Immutable. The BillingAccount that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("billingAccountRef")]
    public V1beta1LoggingLogBucketSpecBillingAccountRef? BillingAccountRef { get; set; }

    /// <summary>Describes this bucket.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary> Whether or not Log Analytics is enabled. Logs for buckets with Log Analytics enabled can be queried in the Log Analytics page using SQL queries. Cannot be disabled once enabled.</summary>
    [JsonPropertyName("enableAnalytics")]
    public bool? EnableAnalytics { get; set; }

    /// <summary>Immutable. The Folder that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1LoggingLogBucketSpecFolderRef? FolderRef { get; set; }

    /// <summary>Immutable. The location of the resource. The supported locations are: global, us-central1, us-east1, us-west1, asia-east1, europe-west1.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Whether the bucket has been locked. The retention period on a locked bucket may not be changed. Locked buckets may only be deleted if they are empty.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1LoggingLogBucketSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. Only one of [billingAccountRef, folderRef, organizationRef, projectRef] may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1LoggingLogBucketSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Logs will be retained by default for this amount of time, after which they will automatically be deleted. The minimum retention period is 1 day. If this value is set to zero at bucket creation time, the default time of 30 days will be used.</summary>
    [JsonPropertyName("retentionDays")]
    public long? RetentionDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogBucketStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogBucketStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoggingLogBucketStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation timestamp of the bucket. This is not set for any of the default buckets.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The bucket lifecycle state. Possible values: LIFECYCLE_STATE_UNSPECIFIED, ACTIVE, DELETE_REQUESTED</summary>
    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The last update timestamp of the bucket.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLogBucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoggingLogBucketSpec>, IStatus<V1beta1LoggingLogBucketStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLogBucket";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglogbuckets";
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
    public V1beta1LoggingLogBucketSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1LoggingLogBucketStatus? Status { get; set; }
}