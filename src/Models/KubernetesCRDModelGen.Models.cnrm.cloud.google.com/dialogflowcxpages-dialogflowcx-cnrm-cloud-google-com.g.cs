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
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesOutputAudioText
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesPlayAudio
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string AudioUri { get; set; }
}

/// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }
}

/// <summary>The text response message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
    [JsonPropertyName("conversationSuccess")]
    public V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
    [JsonPropertyName("outputAudioText")]
    public V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    [JsonPropertyName("playAudio")]
    public V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>The text response message.</summary>
    [JsonPropertyName("text")]
    public V1alpha1DialogflowCXPageSpecEntryFulfillmentMessagesText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The fulfillment to call when the session is entering the page.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEntryFulfillment
{
    /// <summary>Conditional cases for this fulfillment.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1alpha1DialogflowCXPageSpecEntryFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DialogflowCXPageSpecEntryFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1alpha1DialogflowCXPageSpecEntryFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesOutputAudioText
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string AudioUri { get; set; }
}

/// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }
}

/// <summary>The text response message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
    [JsonPropertyName("conversationSuccess")]
    public V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
    [JsonPropertyName("outputAudioText")]
    public V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    [JsonPropertyName("playAudio")]
    public V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>The text response message.</summary>
    [JsonPropertyName("text")]
    public V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecEventHandlers
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
    public V1alpha1DialogflowCXPageSpecEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string AudioUri { get; set; }
}

/// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }
}

/// <summary>The text response message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
    [JsonPropertyName("conversationSuccess")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
    [JsonPropertyName("outputAudioText")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    [JsonPropertyName("playAudio")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>The text response message.</summary>
    [JsonPropertyName("text")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessagesText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillment
{
    /// <summary>Conditional cases for this fulfillment.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string AudioUri { get; set; }
}

/// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }
}

/// <summary>The text response message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
    [JsonPropertyName("conversationSuccess")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
    [JsonPropertyName("outputAudioText")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    [JsonPropertyName("playAudio")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>The text response message.</summary>
    [JsonPropertyName("text")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlers
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
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>Defines fill behavior for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParametersFillBehavior
{
    /// <summary>The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.</summary>
    [JsonPropertyName("initialPromptFulfillment")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorInitialPromptFulfillment? InitialPromptFulfillment { get; set; }

    /// <summary>The handlers for parameter-level events, used to provide reprompt for the parameter or transition to a different page/flow. The supported events are: * sys.no-match-&lt;N&gt;, where N can be from 1 to 6 * sys.no-match-default * sys.no-input-&lt;N&gt;, where N can be from 1 to 6 * sys.no-input-default * sys.invalid-parameter [initialPromptFulfillment][initialPromptFulfillment] provides the first prompt for the parameter. If the user's response does not fill the parameter, a no-match/no-input event will be triggered, and the fulfillment associated with the sys.no-match-1/sys.no-input-1 handler (if defined) will be called to provide a prompt. The sys.no-match-2/sys.no-input-2 handler (if defined) will respond to the next no-match/no-input event, and so on. A sys.no-match-default or sys.no-input-default handler will be used to handle all following no-match/no-input events after all numbered no-match/no-input handlers for the parameter are consumed. A sys.invalid-parameter handler can be defined to handle the case where the parameter values have been invalidated by webhook. For example, if the user's response fill the parameter, however the parameter was invalidated by webhook, the fulfillment associated with the sys.invalid-parameter handler (if defined) will be called to provide a prompt. If the event handler for the corresponding event can't be found on the parameter, initialPromptFulfillment will be re-prompted.</summary>
    [JsonPropertyName("repromptEventHandlers")]
    public IList<V1alpha1DialogflowCXPageSpecFormParametersFillBehaviorRepromptEventHandlers>? RepromptEventHandlers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecFormParameters
{
    /// <summary>The default value of an optional parameter. If the parameter is required, the default value will be ignored.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The human-readable name of the parameter, unique within the form.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The entity type of the parameter. Format: projects/-/locations/-/agents/-/entityTypes/&lt;System Entity Type ID&gt; for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/entityTypes/&lt;Entity Type ID&gt; for developer entity types.</summary>
    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }

    /// <summary>Defines fill behavior for the parameter.</summary>
    [JsonPropertyName("fillBehavior")]
    public V1alpha1DialogflowCXPageSpecFormParametersFillBehavior? FillBehavior { get; set; }

    /// <summary>Indicates whether the parameter represents a list of values.</summary>
    [JsonPropertyName("isList")]
    public bool? IsList { get; set; }

    /// <summary>Indicates whether the parameter content should be redacted in log. If redaction is enabled, the parameter content will be replaced by parameter name during logging. Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.</summary>
    [JsonPropertyName("redact")]
    public bool? Redact { get; set; }

    /// <summary>Indicates whether the parameter is required. Optional parameters will not trigger prompts; however, they are filled if the user specifies them. Required parameters must be filled before form filling concludes.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }
}

/// <summary>The form associated with the page, used for collecting parameters relevant to the page.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecForm
{
    /// <summary>Parameters to collect from the user.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1DialogflowCXPageSpecFormParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See [Case](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/Fulfillment#case) for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string AudioUri { get; set; }
}

/// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }
}

/// <summary>The text response message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates that the conversation succeeded. * In a webhook response when you determine that you handled the customer issue.</summary>
    [JsonPropertyName("conversationSuccess")]
    public V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example: * In the entryFulfillment of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook response when you determine that the customer issue can only be handled by a human.</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.</summary>
    [JsonPropertyName("outputAudioText")]
    public V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    [JsonPropertyName("playAudio")]
    public V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>The text response message.</summary>
    [JsonPropertyName("text")]
    public V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user.</summary>
    [JsonPropertyName("messages")]
    public IList<V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/webhooks/&lt;Webhook ID&gt;.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpecTransitionRoutes
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
    public V1alpha1DialogflowCXPageSpecTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageSpec
{
    /// <summary>The human-readable name of the page, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>The fulfillment to call when the session is entering the page.</summary>
    [JsonPropertyName("entryFulfillment")]
    public V1alpha1DialogflowCXPageSpecEntryFulfillment? EntryFulfillment { get; set; }

    /// <summary>Handlers associated with the page to handle events such as webhook errors, no match or no input.</summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1alpha1DialogflowCXPageSpecEventHandlers>? EventHandlers { get; set; }

    /// <summary>The form associated with the page, used for collecting parameters relevant to the page.</summary>
    [JsonPropertyName("form")]
    public V1alpha1DialogflowCXPageSpecForm? Form { get; set; }

    /// <summary>Immutable. The language of the following fields in page:  Page.entry_fulfillment.messages Page.entry_fulfillment.conditional_cases Page.event_handlers.trigger_fulfillment.messages Page.event_handlers.trigger_fulfillment.conditional_cases Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages Page.form.parameters.fill_behavior.initial_prompt_fulfillment.conditional_cases Page.form.parameters.fill_behavior.reprompt_event_handlers.messages Page.form.parameters.fill_behavior.reprompt_event_handlers.conditional_cases Page.transition_routes.trigger_fulfillment.messages Page.transition_routes.trigger_fulfillment.conditional_cases If not specified, the agent's default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Immutable. The flow to create a page for. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page. If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page's transition route -&gt; page's transition route group -&gt; flow's transition routes. If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence. Format:projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;/transitionRouteGroups/&lt;TransitionRouteGroup ID&gt;.</summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow. When we are in a certain page, the TransitionRoutes are evalauted in the following order: TransitionRoutes defined in the page with intent specified. TransitionRoutes defined in the transition route groups with intent specified. TransitionRoutes defined in flow with intent specified. TransitionRoutes defined in the transition route groups with intent specified. TransitionRoutes defined in the page with only condition specified. TransitionRoutes defined in the transition route groups with only condition specified.</summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1alpha1DialogflowCXPageSpecTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowCXPageStatusConditions
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
public partial class V1alpha1DialogflowCXPageStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowCXPageStatusConditions>? Conditions { get; set; }

    /// <summary>The unique identifier of the page. Format: projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/flows/&lt;Flow ID&gt;/pages/&lt;Page ID&gt;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowCXPage : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowCXPageSpec>, IStatus<V1alpha1DialogflowCXPageStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowCXPage";
    public const string KubeGroup = "dialogflowcx.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowcxpages";
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
    public V1alpha1DialogflowCXPageSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DialogflowCXPageStatus? Status { get; set; }
}