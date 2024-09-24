using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.cnrm.cloud.google.com;
public partial class V1alpha1DialogflowCXEntityTypeSpecEntities
{
    /// <summary>A collection of value synonyms. For example, if the entity type is vegetable, and value is scallions, a synonym could be green onions. For KIND_LIST entity types: This collection must contain exactly one synonym equal to value.</summary>
    [JsonPropertyName("synonyms")]
    public IList<string>? Synonyms { get; set; }

    /// <summary>The primary value associated with this entity entry. For example, if the entity type is vegetable, the value could be scallions. For KIND_MAP entity types: A canonical value to be used in place of synonyms. For KIND_LIST entity types: A string that can contain references to other entity types (with or without aliases).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1alpha1DialogflowCXEntityTypeSpecExcludedPhrases
{
    /// <summary>The word or phrase to be excluded.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1alpha1DialogflowCXEntityTypeSpec
{
    /// <summary>Represents kinds of entities. * AUTO_EXPANSION_MODE_UNSPECIFIED: Auto expansion disabled for the entity. * AUTO_EXPANSION_MODE_DEFAULT: Allows an agent to recognize values that have not been explicitly listed in the entity. Possible values: ["AUTO_EXPANSION_MODE_DEFAULT", "AUTO_EXPANSION_MODE_UNSPECIFIED"].</summary>
    [JsonPropertyName("autoExpansionMode")]
    public string? AutoExpansionMode { get; set; }

    /// <summary>The human-readable name of the entity type, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Enables fuzzy entity extraction during classification.</summary>
    [JsonPropertyName("enableFuzzyExtraction")]
    public bool? EnableFuzzyExtraction { get; set; }

    /// <summary>The collection of entity entries associated with the entity type.</summary>
    [JsonPropertyName("entities")]
    public IList<V1alpha1DialogflowCXEntityTypeSpecEntities> Entities { get; set; }

    /// <summary>Collection of exceptional words and phrases that shouldn't be matched. For example, if you have a size entity type with entry giant(an adjective), you might consider adding giants(a noun) as an exclusion. If the kind of entity type is KIND_MAP, then the phrases specified by entities and excluded phrases should be mutually exclusive.</summary>
    [JsonPropertyName("excludedPhrases")]
    public IList<V1alpha1DialogflowCXEntityTypeSpecExcludedPhrases>? ExcludedPhrases { get; set; }

    /// <summary>Indicates whether the entity type can be automatically expanded. * KIND_MAP: Map entity types allow mapping of a group of synonyms to a canonical value. * KIND_LIST: List entity types contain a set of entries that do not map to canonical values. However, list entity types can contain references to other entity types (with or without aliases). * KIND_REGEXP: Regexp entity types allow to specify regular expressions in entries values. Possible values: ["KIND_MAP", "KIND_LIST", "KIND_REGEXP"].</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Immutable. The language of the following fields in entityType: EntityType.entities.value EntityType.entities.synonyms EntityType.excluded_phrases.value If not specified, the agent's default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Immutable. The agent to create a entity type for. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Indicates whether parameters of the entity type should be redacted in log. If redaction is enabled, page parameters and intent parameters referring to the entity type will be replaced by parameter name when logging.</summary>
    [JsonPropertyName("redact")]
    public bool? Redact { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1DialogflowCXEntityTypeStatusConditions
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

public partial class V1alpha1DialogflowCXEntityTypeStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowCXEntityTypeStatusConditions>? Conditions { get; set; }

    /// <summary>The unique identifier of the entity type. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/entityTypes/&lt;Entity Type ID&gt;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowCXEntityType : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowCXEntityTypeSpec>, IStatus<V1alpha1DialogflowCXEntityTypeStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowCXEntityType";
    public const string KubeGroup = "dialogflowcx.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowcxentitytypes";
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
    public V1alpha1DialogflowCXEntityTypeSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowCXEntityTypeStatus? Status { get; set; }
}