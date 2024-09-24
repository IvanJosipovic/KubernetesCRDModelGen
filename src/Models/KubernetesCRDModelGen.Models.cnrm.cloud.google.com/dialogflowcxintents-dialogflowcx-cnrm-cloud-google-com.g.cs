using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXIntentSpecParameters
{
    /// <summary>The entity type of the parameter. Format: projects/-/locations/-/agents/-/entityTypes/&lt;System Entity Type ID&gt; for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/entityTypes/&lt;Entity Type ID&gt; for developer entity types.</summary>
    [JsonPropertyName("entityType")]
    public string EntityType { get; set; }

    /// <summary>The unique identifier of the parameter. This field is used by training phrases to annotate their parts.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Indicates whether the parameter represents a list of values.</summary>
    [JsonPropertyName("isList")]
    public bool? IsList { get; set; }

    /// <summary>Indicates whether the parameter content should be redacted in log. If redaction is enabled, the parameter content will be replaced by parameter name during logging. Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.</summary>
    [JsonPropertyName("redact")]
    public bool? Redact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXIntentSpecTrainingPhrasesParts
{
    /// <summary>The parameter used to annotate this part of the training phrase. This field is required for annotated parts of the training phrase.</summary>
    [JsonPropertyName("parameterId")]
    public string? ParameterId { get; set; }

    /// <summary>The text for this part.</summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXIntentSpecTrainingPhrases
{
    /// <summary>The unique identifier of the training phrase.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ordered list of training phrase parts. The parts are concatenated in order to form the training phrase. Note: The API does not automatically annotate training phrases like the Dialogflow Console does. Note: Do not forget to include whitespace at part boundaries, so the training phrase is well formatted when the parts are concatenated. If the training phrase does not need to be annotated with parameters, you just need a single part with only the Part.text field set. If you want to annotate the training phrase, you must create multiple parts, where the fields of each part are populated in one of two ways: Part.text is set to a part of the phrase that has no parameters. Part.text is set to a part of the phrase that you want to annotate, and the parameterId field is set.</summary>
    [JsonPropertyName("parts")]
    public IList<V1alpha1DialogflowCXIntentSpecTrainingPhrasesParts> Parts { get; set; }

    /// <summary>Indicates how many times this example was added to the intent.</summary>
    [JsonPropertyName("repeatCount")]
    public int? RepeatCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXIntentSpec
{
    /// <summary>Human readable description for better understanding an intent like its scope, content, result etc. Maximum character limit: 140 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the intent, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Indicates whether this is a fallback intent. Currently only default fallback intent is allowed in the agent, which is added upon agent creation. Adding training phrases to fallback intent is useful in the case of requests that are mistakenly matched, since training phrases assigned to fallback intents act as negative examples that triggers no-match event.</summary>
    [JsonPropertyName("isFallback")]
    public bool? IsFallback { get; set; }

    /// <summary>Immutable. The language of the following fields in intent: Intent.training_phrases.parts.text If not specified, the agent's default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>The collection of parameters associated with the intent.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1DialogflowCXIntentSpecParameters>? Parameters { get; set; }

    /// <summary>Immutable. The agent to create an intent for. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>The priority of this intent. Higher numbers represent higher priorities. If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds to the Normal priority in the console. If the supplied value is negative, the intent is ignored in runtime detect intent requests.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The collection of training phrases the agent is trained on to identify the intent.</summary>
    [JsonPropertyName("trainingPhrases")]
    public IList<V1alpha1DialogflowCXIntentSpecTrainingPhrases>? TrainingPhrases { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXIntentStatusConditions
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
public partial class V1alpha1DialogflowCXIntentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowCXIntentStatusConditions>? Conditions { get; set; }

    /// <summary>The unique identifier of the intent. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/intents/&lt;Intent ID&gt;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowCXIntent : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowCXIntentSpec>, IStatus<V1alpha1DialogflowCXIntentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowCXIntent";
    public const string KubeGroup = "dialogflowcx.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowcxintents";
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
    public V1alpha1DialogflowCXIntentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowCXIntentStatus? Status { get; set; }
}