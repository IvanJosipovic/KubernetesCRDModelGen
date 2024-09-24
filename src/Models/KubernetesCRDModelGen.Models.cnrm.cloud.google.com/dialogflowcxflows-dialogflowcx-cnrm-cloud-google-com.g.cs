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
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>The raw text to be synthesized.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string AudioUri { get; set; }
}

/// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }
}

/// <summary>The text response message.</summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
    [JsonPropertyName("conversationSuccess")]
    public V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
    [JsonPropertyName("outputAudioText")]
    public V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    [JsonPropertyName("playAudio")]
    public V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>The text response message.</summary>
    [JsonPropertyName("text")]
    public V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.</summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpecEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>The unique identifier of this event handler.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The target flow to transition to. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>The target page to transition to. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;/pages/&lt;Page ID&gt;.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1alpha1DialogflowCXFlowSpecEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>NLU related settings of the flow.</summary>
public partial class V1alpha1DialogflowCXFlowSpecNluSettings
{
    /// <summary>To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold. If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.</summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>Indicates NLU model training mode. * MODEL_TRAINING_MODE_AUTOMATIC: NLU model training is automatically triggered when a flow gets modified. User can also manually trigger model training in this mode. * MODEL_TRAINING_MODE_MANUAL: User needs to manually trigger NLU model training. Best for large flows whose models take long time to train. Possible values: ["MODEL_TRAINING_MODE_AUTOMATIC", "MODEL_TRAINING_MODE_MANUAL"].</summary>
    [JsonPropertyName("modelTrainingMode")]
    public string? ModelTrainingMode { get; set; }

    /// <summary>Indicates the type of NLU model. * MODEL_TYPE_STANDARD: Use standard NLU model. * MODEL_TYPE_ADVANCED: Use advanced NLU model. Possible values: ["MODEL_TYPE_STANDARD", "MODEL_TYPE_ADVANCED"].</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>The raw text to be synthesized.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string AudioUri { get; set; }
}

/// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }
}

/// <summary>The text response message.</summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
    [JsonPropertyName("conversationSuccess")]
    public V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
    [JsonPropertyName("outputAudioText")]
    public V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    [JsonPropertyName("playAudio")]
    public V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>The text response message.</summary>
    [JsonPropertyName("text")]
    public V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.</summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpecTransitionRoutes
{
    /// <summary>The condition to evaluate against form parameters or session parameters. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>The unique identifier of an Intent. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/intents/&lt;Intent ID&gt;. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>The unique identifier of this transition route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The target flow to transition to. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>The target page to transition to. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;/pages/&lt;Page ID&gt;.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1alpha1DialogflowCXFlowSpecTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowSpec
{
    /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the flow.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>A flow's event handlers serve two purposes: They are responsible for handling events (e.g. no match, webhook errors) in the flow. They are inherited by every page's [event handlers][Page.event_handlers], which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow. Unlike transitionRoutes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored.</summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1alpha1DialogflowCXFlowSpecEventHandlers>? EventHandlers { get; set; }

    /// <summary>Immutable. The language of the following fields in flow: Flow.event_handlers.trigger_fulfillment.messages Flow.event_handlers.trigger_fulfillment.conditional_cases Flow.transition_routes.trigger_fulfillment.messages Flow.transition_routes.trigger_fulfillment.conditional_cases If not specified, the agent's default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>NLU related settings of the flow.</summary>
    [JsonPropertyName("nluSettings")]
    public V1alpha1DialogflowCXFlowSpecNluSettings? NluSettings { get; set; }

    /// <summary>Immutable. The agent to create a flow for. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A flow's transition route group serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow. Format:projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;/transitionRouteGroups/&lt;TransitionRouteGroup ID&gt;.</summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>A flow's transition routes serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition routes][Page.transition_routes] and can support use cases such as the user saying "help" or "can I talk to a human?", which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow.  TransitionRoutes are evalauted in the following order:   TransitionRoutes with intent specified.   TransitionRoutes with only condition specified.   TransitionRoutes with intent specified are inherited by pages in the flow.</summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1alpha1DialogflowCXFlowSpecTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DialogflowCXFlowStatusConditions
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
public partial class V1alpha1DialogflowCXFlowStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowCXFlowStatusConditions>? Conditions { get; set; }

    /// <summary>The unique identifier of the flow. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1DialogflowCXFlow : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowCXFlowSpec>, IStatus<V1alpha1DialogflowCXFlowStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowCXFlow";
    public const string KubeGroup = "dialogflowcx.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowcxflows";
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
    public V1alpha1DialogflowCXFlowSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowCXFlowStatus? Status { get; set; }
}