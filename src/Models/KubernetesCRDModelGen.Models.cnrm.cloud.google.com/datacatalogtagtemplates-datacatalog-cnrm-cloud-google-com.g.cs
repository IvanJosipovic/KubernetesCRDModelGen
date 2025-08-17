using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.cnrm.cloud.google.com;
#nullable enable
/// <summary>DataCatalogTagTemplate is the Schema for the DataCatalogTagTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogTagTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataCatalogTagTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogTagTemplateList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1DataCatalogTagTemplate> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumTypeAllowedValues
{
    /// <summary>Required. The display name of the enum value. Must not be an empty  string.   The name must contain only Unicode letters, numbers (0-9), underscores  (_), dashes (-), spaces ( ), and can't start or end with spaces. The  maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An enum type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumType
{
    /// <summary>The set of allowed values for this enum.   This set must not be empty and can include up to 100 allowed values.  The display names of the values in this set must not be empty and must  be case-insensitively unique within this set.   The order of items in this set is preserved. This field can be used to  create, remove, and reorder enum values. To rename enum values, use the  `RenameTagTemplateFieldEnumValue` method.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumTypeAllowedValues>? AllowedValues { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The type of value this tag field can contain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateSpecFieldsType
{
    /// <summary>An enum type.</summary>
    [JsonPropertyName("enumType")]
    public V1alpha1DataCatalogTagTemplateSpecFieldsTypeEnumType? EnumType { get; set; }

    /// <summary>Primitive types, such as string, boolean, etc.</summary>
    [JsonPropertyName("primitiveType")]
    public string? PrimitiveType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateSpecFields
{
    /// <summary>The description for this field. Defaults to an empty string.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name for this field. Defaults to an empty string.   The name must contain only Unicode letters, numbers (0-9), underscores (_),  dashes (-), spaces ( ), and can't start or end with spaces.  The maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If true, this field is required. Defaults to false.</summary>
    [JsonPropertyName("isRequired")]
    public bool? IsRequired { get; set; }

    /// <summary>Identifier. The resource name of the tag template field in URL format.   Note: The tag template field itself might not be stored in the location  specified in its name.   The name must contain only letters (a-z, A-Z), numbers (0-9),  or underscores (_), and must start with a letter or underscore.  The maximum length is 64 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order of this field with respect to other fields in this tag  template.   For example, a higher value can indicate a more important field.  The value can be negative. Multiple fields can have the same order and  field orders within a tag don't have to be sequential.</summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>Required. The type of value this tag field can contain.</summary>
    [JsonPropertyName("type")]
    public V1alpha1DataCatalogTagTemplateSpecFieldsType Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogTagTemplateSpec defines the desired state of DataCatalogTagTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateSpec
{
    /// <summary>Display name for this template. Defaults to an empty string.   The name must contain only Unicode letters, numbers (0-9), underscores (_),  dashes (-), spaces ( ), and can't start or end with spaces.  The maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Fields used to create a Tag</summary>
    [JsonPropertyName("fields")]
    public IDictionary<string, V1alpha1DataCatalogTagTemplateSpecFields>? Fields { get; set; }

    /// <summary>Indicates whether tags created with this template are public. Public tags  do not require tag template access to appear in  [ListTags][google.cloud.datacatalog.v1.DataCatalog.ListTags] API response.   Additionally, you can search for a public tag by value with a  simple search query in addition to using a ``tag:`` predicate.</summary>
    [JsonPropertyName("isPubliclyReadable")]
    public bool? IsPubliclyReadable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DataCatalogTagTemplateSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataCatalogTagTemplate name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateStatusObservedState
{
    /// <summary>Optional. Transfer status of the TagTemplate</summary>
    [JsonPropertyName("dataplexTransferStatus")]
    public string? DataplexTransferStatus { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogTagTemplateStatus defines the config connector machine state of DataCatalogTagTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagTemplateStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataCatalogTagTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataCatalogTagTemplate resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataCatalogTagTemplateStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DataCatalogTagTemplate is the Schema for the DataCatalogTagTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>DataCatalogTagTemplateSpec defines the desired state of DataCatalogTagTemplate</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataCatalogTagTemplateSpec Spec { get; set; }

    /// <summary>DataCatalogTagTemplateStatus defines the config connector machine state of DataCatalogTagTemplate</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataCatalogTagTemplateStatus? Status { get; set; }
}
#nullable disable
