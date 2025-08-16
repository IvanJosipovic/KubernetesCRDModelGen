using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datacatalog.cnrm.cloud.google.com;
/// <summary>DataCatalogTag is the Schema for the DataCatalogTag API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataCatalogTagList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataCatalogTag>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataCatalogTagList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1DataCatalogTag> Items { get; set; }
}

/// <summary>Required. Reference to the DataCatalogEntry that owns this Tag. The entry must be in the same project and location as the tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagSpecEntryRef
{
    /// <summary>A reference to an externally managed DataCatalogEntry resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/entrys/{{entryID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataCatalogEntry resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataCatalogEntry resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The value of a tag field with an enum type.   This value must be one of the allowed values listed in this enum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagSpecFieldsEnumValue
{
    /// <summary>The display name of the enum value.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagSpecFields
{
    /// <summary>The value of a tag field with a boolean type.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>The value of a tag field with a double type.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>The value of a tag field with an enum type.   This value must be one of the allowed values listed in this enum.</summary>
    [JsonPropertyName("enumValue")]
    public V1alpha1DataCatalogTagSpecFieldsEnumValue? EnumValue { get; set; }

    /// <summary>The value of a tag field with a rich text type.   The maximum length is 10 MiB as this value holds HTML descriptions  including encoded images. The maximum length of the text without images  is 100 KiB.</summary>
    [JsonPropertyName("richtextValue")]
    public string? RichtextValue { get; set; }

    /// <summary>The value of a tag field with a string type.   The maximum length is 2000 UTF-8 characters.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>The value of a tag field with a timestamp type.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>Required. The resource name of the tag template this tag uses.   This field cannot be modified after creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagSpecTemplateRef
{
    /// <summary>A reference to an externally managed DataCatalogTagTemplate resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/tagTemplates/{{tagTemplateID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataCatalogTagTemplate resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataCatalogTagTemplate resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>DataCatalogTagSpec defines the desired state of DataCatalogTag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagSpec
{
    /// <summary>Resources like entry can have schemas associated with them. This scope  allows you to attach tags to an individual column based on that schema.   To attach a tag to a nested column, separate column names with a dot  (`.`). Example: `column.nested_column`.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Required. Reference to the DataCatalogEntry that owns this Tag. The entry must be in the same project and location as the tag.</summary>
    [JsonPropertyName("entryRef")]
    public V1alpha1DataCatalogTagSpecEntryRef EntryRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fields")]
    public IDictionary<string, V1alpha1DataCatalogTagSpecFields>? Fields { get; set; }

    /// <summary>The DataCatalogTag name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The resource name of the tag template this tag uses.   This field cannot be modified after creation.</summary>
    [JsonPropertyName("templateRef")]
    public V1alpha1DataCatalogTagSpecTemplateRef TemplateRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagStatusObservedState
{
    /// <summary>Output only. Denotes the transfer status of the Tag Template.</summary>
    [JsonPropertyName("dataplexTransferStatus")]
    public string? DataplexTransferStatus { get; set; }

    /// <summary>Output only. The display name of the tag template.</summary>
    [JsonPropertyName("templateDisplayName")]
    public string? TemplateDisplayName { get; set; }
}

/// <summary>DataCatalogTagStatus defines the config connector machine state of DataCatalogTag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataCatalogTagStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataCatalogTagStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataCatalogTag resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataCatalogTagStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataCatalogTag is the Schema for the DataCatalogTag API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>DataCatalogTagSpec defines the desired state of DataCatalogTag</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DataCatalogTagSpec Spec { get; set; }

    /// <summary>DataCatalogTagStatus defines the config connector machine state of DataCatalogTag</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataCatalogTagStatus? Status { get; set; }
}