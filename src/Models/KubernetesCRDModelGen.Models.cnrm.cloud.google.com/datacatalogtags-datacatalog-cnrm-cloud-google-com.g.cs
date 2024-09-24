using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.cnrm.cloud.google.com;
public partial class V1alpha1DataCatalogTagSpecFields
{
    /// <summary>Holds the value for a tag field with boolean type.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>The display name of this field.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Holds the value for a tag field with double type.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>The display name of the enum value.</summary>
    [JsonPropertyName("enumValue")]
    public string? EnumValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldName")]
    public string FieldName { get; set; }

    /// <summary>The order of this field with respect to other fields in this tag. For example, a higher value can indicate a more important field. The value can be negative. Multiple fields can have the same order, and field orders within a tag do not have to be sequential.</summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>Holds the value for a tag field with string type.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>Holds the value for a tag field with timestamp type.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

public partial class V1alpha1DataCatalogTagSpec
{
    /// <summary>Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an individual column based on that schema.  For attaching a tag to a nested column, use '.' to separate the column names. Example: 'outer_column.inner_column'.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>This maps the ID of a tag field to the value of and additional information about that field. Valid field IDs are defined by the tag's template. A tag must have at least 1 field and at most 500 fields.</summary>
    [JsonPropertyName("fields")]
    public IList<V1alpha1DataCatalogTagSpecFields> Fields { get; set; }

    /// <summary>Immutable. The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to all entries in that group.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The resource name of the tag template that this tag uses. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId} This field cannot be modified after creation.</summary>
    [JsonPropertyName("template")]
    public string Template { get; set; }
}

public partial class V1alpha1DataCatalogTagStatusConditions
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

public partial class V1alpha1DataCatalogTagStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataCatalogTagStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name of the tag in URL format. Example: projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id} where tag_id is a system-generated identifier. Note that this Tag may not actually be stored in the location in this name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The display name of the tag template.</summary>
    [JsonPropertyName("templateDisplayname")]
    public string? TemplateDisplayname { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogTag : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataCatalogTagSpec>, IStatus<V1alpha1DataCatalogTagStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogTag";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogtags";
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
    public V1alpha1DataCatalogTagSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DataCatalogTagStatus? Status { get; set; }
}