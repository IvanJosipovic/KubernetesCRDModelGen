using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflow.cnrm.cloud.google.com;
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowIntentSpecProjectRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowIntentSpec
{
    /// <summary>The name of the action associated with the intent. Note: The action name must not contain whitespaces.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The list of platforms for which the first responses will be copied from the messages in PLATFORM_UNSPECIFIED (i.e. default platform). Possible values: ["FACEBOOK", "SLACK", "TELEGRAM", "KIK", "SKYPE", "LINE", "VIBER", "ACTIONS_ON_GOOGLE", "GOOGLE_HANGOUTS"].</summary>
    [JsonPropertyName("defaultResponsePlatforms")]
    public IList<string>? DefaultResponsePlatforms { get; set; }

    /// <summary>The name of this intent to be displayed on the console.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>The collection of event names that trigger the intent. If the collection of input contexts is not empty, all of the contexts must be present in the active user session for an event to trigger this intent. See the [events reference](https://cloud.google.com/dialogflow/docs/events-overview) for more details.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The list of context names required for this intent to be triggered. Format: projects/&lt;Project ID&gt;/agent/sessions/-/contexts/&lt;Context ID&gt;.</summary>
    [JsonPropertyName("inputContextNames")]
    public IList<string>? InputContextNames { get; set; }

    /// <summary>Indicates whether this is a fallback intent.</summary>
    [JsonPropertyName("isFallback")]
    public bool? IsFallback { get; set; }

    /// <summary>Indicates whether Machine Learning is disabled for the intent. Note: If mlDisabled setting is set to true, then this intent is not taken into account during inference in ML ONLY match mode. Also, auto-markup in the UI is turned off.</summary>
    [JsonPropertyName("mlDisabled")]
    public bool? MlDisabled { get; set; }

    /// <summary>Immutable. The unique identifier of the parent intent in the chain of followup intents. Format: projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;.</summary>
    [JsonPropertyName("parentFollowupIntentName")]
    public string? ParentFollowupIntentName { get; set; }

    /// <summary>The priority of this intent. Higher numbers represent higher priorities.   - If the supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds   to the Normal priority in the console.   - If the supplied value is negative, the intent is ignored in runtime detect intent requests.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DialogflowIntentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Indicates whether to delete all contexts in the current session when this intent is matched.</summary>
    [JsonPropertyName("resetContexts")]
    public bool? ResetContexts { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Indicates whether webhooks are enabled for the intent. * WEBHOOK_STATE_ENABLED: Webhook is enabled in the agent and in the intent. * WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING: Webhook is enabled in the agent and in the intent. Also, each slot filling prompt is forwarded to the webhook. Possible values: ["WEBHOOK_STATE_ENABLED", "WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING"].</summary>
    [JsonPropertyName("webhookState")]
    public string? WebhookState { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowIntentStatusConditions
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
public partial class V1alpha1DialogflowIntentStatusFollowupIntentInfo
{
    /// <summary>The unique identifier of the followup intent. Format: projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;.</summary>
    [JsonPropertyName("followupIntentName")]
    public string? FollowupIntentName { get; set; }

    /// <summary>The unique identifier of the followup intent's parent. Format: projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;.</summary>
    [JsonPropertyName("parentFollowupIntentName")]
    public string? ParentFollowupIntentName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowIntentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowIntentStatusConditions>? Conditions { get; set; }

    /// <summary>Information about all followup intents that have this intent as a direct or indirect parent. We populate this field only in the output.</summary>
    [JsonPropertyName("followupIntentInfo")]
    public IList<V1alpha1DialogflowIntentStatusFollowupIntentInfo>? FollowupIntentInfo { get; set; }

    /// <summary>The unique identifier of this intent. Format: projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The unique identifier of the root intent in the chain of followup intents. It identifies the correct followup intents chain for this intent. Format: projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;.</summary>
    [JsonPropertyName("rootFollowupIntentName")]
    public string? RootFollowupIntentName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowIntent : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowIntentSpec>, IStatus<V1alpha1DialogflowIntentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowIntent";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowintents";
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
    public V1alpha1DialogflowIntentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowIntentStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowIntentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DialogflowIntent>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowIntentList";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowintents";
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
    public IList<V1alpha1DialogflowIntent> Items { get; set; }
}