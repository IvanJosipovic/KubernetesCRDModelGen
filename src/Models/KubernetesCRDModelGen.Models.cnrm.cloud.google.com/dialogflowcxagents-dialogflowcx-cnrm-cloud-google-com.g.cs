using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.cnrm.cloud.google.com;
public partial class V1alpha1DialogflowCXAgentSpecProjectRef
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

public partial class V1alpha1DialogflowCXAgentSpecSpeechToTextSettings
{
    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("enableSpeechAdaptation")]
    public bool? EnableSpeechAdaptation { get; set; }
}

public partial class V1alpha1DialogflowCXAgentSpec
{
    /// <summary>The URI of the agent's avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.</summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>Immutable. The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/cx/docs/reference/language) for a list of the currently supported language codes. This field cannot be updated after creation.</summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string DefaultLanguageCode { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the agent, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Immutable. The name of the location this agent is located in.  ~&gt; **Note:** The first time you are deploying an Agent in your project you must configure location settings.  This is a one time step but at the moment you can only [configure location settings](https://cloud.google.com/dialogflow/cx/docs/concept/region#location-settings) via the Dialogflow CX console.  Another options is to use global location so you don't need to manually configure location settings.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DialogflowCXAgentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/securitySettings/&lt;Security Settings ID&gt;.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Settings related to speech recognition.</summary>
    [JsonPropertyName("speechToTextSettings")]
    public V1alpha1DialogflowCXAgentSpecSpeechToTextSettings? SpeechToTextSettings { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the default_language_code).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York, Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }
}

public partial class V1alpha1DialogflowCXAgentStatusConditions
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

public partial class V1alpha1DialogflowCXAgentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowCXAgentStatusConditions>? Conditions { get; set; }

    /// <summary>The unique identifier of the agent.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;.</summary>
    [JsonPropertyName("startFlow")]
    public string? StartFlow { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowCXAgent : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowCXAgentSpec>, IStatus<V1alpha1DialogflowCXAgentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowCXAgent";
    public const string KubeGroup = "dialogflowcx.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowcxagents";
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
    public V1alpha1DialogflowCXAgentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowCXAgentStatus? Status { get; set; }
}