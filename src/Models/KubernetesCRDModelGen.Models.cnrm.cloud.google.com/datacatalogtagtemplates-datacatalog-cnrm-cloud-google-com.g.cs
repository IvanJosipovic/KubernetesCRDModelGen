using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.cnrm.cloud.google.com;
public partial class V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumTypeAllowedValues
{
    /// <summary>The display name of the enum value.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
}

public partial class V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumType
{
    /// <summary>The set of allowed values for this enum. The display names of the values must be case-insensitively unique within this set. Currently, enum values can only be added to the list of allowed values. Deletion and renaming of enum values are not supported. Can have up to 500 allowed values.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumTypeAllowedValues> AllowedValues { get; set; }
}

public partial class V1alpha1DataCatalogTagTemplateSpecFieldsType
{
    /// <summary>Represents an enum type.  Exactly one of 'primitive_type' or 'enum_type' must be set.</summary>
    [JsonPropertyName("enumType")]
    public V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumType? EnumType { get; set; }

    /// <summary>Represents primitive types - string, bool etc.  Exactly one of 'primitive_type' or 'enum_type' must be set Possible values: ["DOUBLE", "STRING", "BOOL", "TIMESTAMP"].</summary>
    [JsonPropertyName("primitiveType")]
    public string? PrimitiveType { get; set; }
}

public partial class V1alpha1DataCatalogTagTemplateSpecFields
{
    /// <summary>A description for this field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name for this field.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldId")]
    public string FieldId { get; set; }

    /// <summary>Whether this is a required field. Defaults to false.</summary>
    [JsonPropertyName("isRequired")]
    public bool? IsRequired { get; set; }

    /// <summary>The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order of this field with respect to other fields in this tag template. A higher value indicates a more important field. The value can be negative. Multiple fields can have the same order, and field orders within a tag do not have to be sequential.</summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>The type of value this tag field can contain.</summary>
    [JsonPropertyName("type")]
    public V1alpha1DataCatalogTagTemplateSpecFieldsType Type { get; set; }
}

public partial class V1alpha1DataCatalogTagTemplateSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1alpha1DataCatalogTagTemplateSpec
{
    /// <summary>The display name for this template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Set of tag template field IDs and the settings for the field. This set is an exhaustive list of the allowed fields. This set must contain at least one field and at most 500 fields. The change of field_id will be resulting in re-creating of field. The change of primitive_type will be resulting in re-creating of field, however if the field is a required, you cannot update it.</summary>
    [JsonPropertyName("fields")]
    public IList<V1alpha1DataCatalogTagTemplateSpecFields> Fields { get; set; }

    /// <summary>This confirms the deletion of any possible tags using this template. Must be set to true in order to delete the tag template.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DataCatalogTagTemplateSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Template location region.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The id of the tag template to create.</summary>
    [JsonPropertyName("tagTemplateId")]
    public string TagTemplateId { get; set; }
}

public partial class V1alpha1DataCatalogTagTemplateStatusConditions
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

public partial class V1alpha1DataCatalogTagTemplateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataCatalogTagTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name of the tag template in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogTagTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataCatalogTagTemplateSpec>, IStatus<V1alpha1DataCatalogTagTemplateStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogTagTemplate";
    public const string KubeGroup = "datacatalog.cnrm.cloud.google.com";
    public const string KubePluralName = "datacatalogtagtemplates";
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
    public V1alpha1DataCatalogTagTemplateSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DataCatalogTagTemplateStatus? Status { get; set; }
}