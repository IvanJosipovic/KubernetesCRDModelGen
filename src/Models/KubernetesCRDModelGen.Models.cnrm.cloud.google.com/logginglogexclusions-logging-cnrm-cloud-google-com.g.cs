using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.cnrm.cloud.google.com;
/// <summary>Immutable. The BillingAccount that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
public partial class V1beta1LoggingLogExclusionSpecBillingAccountRef
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

/// <summary>Immutable. The Folder that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
public partial class V1beta1LoggingLogExclusionSpecFolderRef
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

/// <summary>Immutable. The Organization that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
public partial class V1beta1LoggingLogExclusionSpecOrganizationRef
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

/// <summary>Immutable. The Project that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
public partial class V1beta1LoggingLogExclusionSpecProjectRef
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
public partial class V1beta1LoggingLogExclusionSpec
{
    /// <summary>Immutable. The BillingAccount that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
    [JsonPropertyName("billingAccountRef")]
    public V1beta1LoggingLogExclusionSpecBillingAccountRef? BillingAccountRef { get; set; }

    /// <summary>Optional. A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. If set to True, then this exclusion is disabled and it does not exclude any log entries. You can update an exclusion to change the value of this field.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Required. An (https://cloud.google.com/logging/docs/view/advanced-queries#sample), you can exclude less than 100% of the matching log entries. For example, the following query matches 99% of low-severity log entries from Google Cloud Storage buckets: `"resource.type=gcs_bucket severity</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Immutable. The Folder that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1LoggingLogExclusionSpecFolderRef? FolderRef { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1LoggingLogExclusionSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. Only one of [projectRef, folderRef, organizationRef, billingAccountRef] may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1LoggingLogExclusionSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
public partial class V1beta1LoggingLogExclusionStatusConditions
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
public partial class V1beta1LoggingLogExclusionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoggingLogExclusionStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation timestamp of the exclusion. This field may not be present for older exclusions.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The last update timestamp of the exclusion. This field may not be present for older exclusions.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1LoggingLogExclusion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoggingLogExclusionSpec>, IStatus<V1beta1LoggingLogExclusionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLogExclusion";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglogexclusions";
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
    public V1beta1LoggingLogExclusionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1LoggingLogExclusionStatus? Status { get; set; }
}