using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.gcp.upbound.io;
public enum V1beta1FlowSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1FlowSpecForProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation. Format: gs://bucket/object-name-or-prefix</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1FlowSpecForProviderAdvancedSettingsDtmfSettings
{
    /// <summary>If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a "3" was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

public partial class V1beta1FlowSpecForProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public IList<V1beta1FlowSpecForProviderAdvancedSettingsAudioExportGcsDestination>? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public IList<V1beta1FlowSpecForProviderAdvancedSettingsDtmfSettings>? DtmfSettings { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See Case for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example:</summary>
    [JsonPropertyName("conversationSuccess")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess>? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example:</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff>? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message. Structure is documented below.</summary>
    [JsonPropertyName("outputAudioText")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText>? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response. Structure is documented below.</summary>
    [JsonPropertyName("playAudio")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesPlayAudio>? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint. Structure is documented below.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall>? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesText>? Text { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlersTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment. Structure is documented below.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user. Structure is documented below.</summary>
    [JsonPropertyName("messages")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook. Structure is documented below.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

public partial class V1beta1FlowSpecForProviderEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>The target flow to transition to. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>The target page to transition to. Format: projects//locations//agents//flows//pages/.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks. Structure is documented below.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public IList<V1beta1FlowSpecForProviderEventHandlersTriggerFulfillment>? TriggerFulfillment { get; set; }
}

public partial class V1beta1FlowSpecForProviderNluSettings
{
    /// <summary>To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold. If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.</summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>Indicates NLU model training mode.</summary>
    [JsonPropertyName("modelTrainingMode")]
    public string? ModelTrainingMode { get; set; }

    /// <summary>Indicates the type of NLU model.</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }
}

public enum V1beta1FlowSpecForProviderParentRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecForProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecForProviderParentRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderParentRefPolicyResolutionEnum>))]
    public V1beta1FlowSpecForProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderParentRefPolicyResolveEnum>))]
    public V1beta1FlowSpecForProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderParentRefPolicy? Policy { get; set; }
}

public enum V1beta1FlowSpecForProviderParentSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecForProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecForProviderParentSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderParentSelectorPolicyResolutionEnum>))]
    public V1beta1FlowSpecForProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderParentSelectorPolicyResolveEnum>))]
    public V1beta1FlowSpecForProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecForProviderParentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderParentSelectorPolicy? Policy { get; set; }
}

public enum V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum>))]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolveEnum>))]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRefPolicy? Policy { get; set; }
}

public enum V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum>))]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum>))]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See Case for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example:</summary>
    [JsonPropertyName("conversationSuccess")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess>? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example:</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff>? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message. Structure is documented below.</summary>
    [JsonPropertyName("outputAudioText")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText>? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response. Structure is documented below.</summary>
    [JsonPropertyName("playAudio")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio>? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint. Structure is documented below.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall>? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesText>? Text { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment. Structure is documented below.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user. Structure is documented below.</summary>
    [JsonPropertyName("messages")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook. Structure is documented below.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

public partial class V1beta1FlowSpecForProviderTransitionRoutes
{
    /// <summary>The condition to evaluate against form parameters or session parameters. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>The unique identifier of an Intent. Format: projects//locations//agents//intents/. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>The target flow to transition to. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta1FlowSpecForProviderTransitionRoutesTargetFlowSelector? TargetFlowSelector { get; set; }

    /// <summary>The target page to transition to. Format: projects//locations//agents//flows//pages/.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first. Structure is documented below.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutesTriggerFulfillment>? TriggerFulfillment { get; set; }
}

public partial class V1beta1FlowSpecForProvider
{
    /// <summary>Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level. Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter. Structure is documented below.</summary>
    [JsonPropertyName("advancedSettings")]
    public IList<V1beta1FlowSpecForProviderAdvancedSettings>? AdvancedSettings { get; set; }

    /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the flow.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A flow's event handlers serve two purposes: They are responsible for handling events (e.g. no match, webhook errors) in the flow. They are inherited by every page's [event handlers][Page.event_handlers], which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow. Unlike transitionRoutes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored. Structure is documented below.</summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta1FlowSpecForProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>Marks this as the Default Start Flow for an agent. When you create an agent, the Default Start Flow is created automatically. The Default Start Flow cannot be deleted; deleting the google_dialogflow_cx_flow resource does nothing to the underlying GCP resources.</summary>
    [JsonPropertyName("isDefaultStartFlow")]
    public bool? IsDefaultStartFlow { get; set; }

    /// <summary>The language of the following fields in flow: Flow.event_handlers.trigger_fulfillment.messages Flow.event_handlers.trigger_fulfillment.conditional_cases Flow.transition_routes.trigger_fulfillment.messages Flow.transition_routes.trigger_fulfillment.conditional_cases If not specified, the agent's default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>NLU related settings of the flow. Structure is documented below.</summary>
    [JsonPropertyName("nluSettings")]
    public IList<V1beta1FlowSpecForProviderNluSettings>? NluSettings { get; set; }

    /// <summary>The agent to create a flow for. Format: projects//locations//agents/.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1FlowSpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1FlowSpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>A flow's transition route group serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow. Format:projects//locations//agents//flows//transitionRouteGroups/.</summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>A flow's transition routes serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition routes][Page.transition_routes] and can support use cases such as the user saying "help" or "can I talk to a human?", which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow. TransitionRoutes are evalauted in the following order: TransitionRoutes with intent specified. TransitionRoutes with only condition specified. TransitionRoutes with intent specified are inherited by pages in the flow. Structure is documented below.</summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta1FlowSpecForProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

public partial class V1beta1FlowSpecInitProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation. Format: gs://bucket/object-name-or-prefix</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1FlowSpecInitProviderAdvancedSettingsDtmfSettings
{
    /// <summary>If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a "3" was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

public partial class V1beta1FlowSpecInitProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public IList<V1beta1FlowSpecInitProviderAdvancedSettingsAudioExportGcsDestination>? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public IList<V1beta1FlowSpecInitProviderAdvancedSettingsDtmfSettings>? DtmfSettings { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See Case for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example:</summary>
    [JsonPropertyName("conversationSuccess")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess>? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example:</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff>? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message. Structure is documented below.</summary>
    [JsonPropertyName("outputAudioText")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText>? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response. Structure is documented below.</summary>
    [JsonPropertyName("playAudio")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesPlayAudio>? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint. Structure is documented below.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall>? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesText>? Text { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment. Structure is documented below.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user. Structure is documented below.</summary>
    [JsonPropertyName("messages")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook. Structure is documented below.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

public partial class V1beta1FlowSpecInitProviderEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>The target flow to transition to. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>The target page to transition to. Format: projects//locations//agents//flows//pages/.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks. Structure is documented below.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public IList<V1beta1FlowSpecInitProviderEventHandlersTriggerFulfillment>? TriggerFulfillment { get; set; }
}

public partial class V1beta1FlowSpecInitProviderNluSettings
{
    /// <summary>To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold. If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.</summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>Indicates NLU model training mode.</summary>
    [JsonPropertyName("modelTrainingMode")]
    public string? ModelTrainingMode { get; set; }

    /// <summary>Indicates the type of NLU model.</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }
}

public enum V1beta1FlowSpecInitProviderParentRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecInitProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecInitProviderParentRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderParentRefPolicyResolutionEnum>))]
    public V1beta1FlowSpecInitProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderParentRefPolicyResolveEnum>))]
    public V1beta1FlowSpecInitProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecInitProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderParentRefPolicy? Policy { get; set; }
}

public enum V1beta1FlowSpecInitProviderParentSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecInitProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecInitProviderParentSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderParentSelectorPolicyResolutionEnum>))]
    public V1beta1FlowSpecInitProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderParentSelectorPolicyResolveEnum>))]
    public V1beta1FlowSpecInitProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecInitProviderParentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderParentSelectorPolicy? Policy { get; set; }
}

public enum V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum>))]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolveEnum>))]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicy? Policy { get; set; }
}

public enum V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum>))]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum>))]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See Case for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example:</summary>
    [JsonPropertyName("conversationSuccess")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess>? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example:</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff>? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message. Structure is documented below.</summary>
    [JsonPropertyName("outputAudioText")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText>? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response. Structure is documented below.</summary>
    [JsonPropertyName("playAudio")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio>? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint. Structure is documented below.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall>? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesText>? Text { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment. Structure is documented below.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user. Structure is documented below.</summary>
    [JsonPropertyName("messages")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook. Structure is documented below.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

public partial class V1beta1FlowSpecInitProviderTransitionRoutes
{
    /// <summary>The condition to evaluate against form parameters or session parameters. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>The unique identifier of an Intent. Format: projects//locations//agents//intents/. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>The target flow to transition to. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta1FlowSpecInitProviderTransitionRoutesTargetFlowSelector? TargetFlowSelector { get; set; }

    /// <summary>The target page to transition to. Format: projects//locations//agents//flows//pages/.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first. Structure is documented below.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutesTriggerFulfillment>? TriggerFulfillment { get; set; }
}

public partial class V1beta1FlowSpecInitProvider
{
    /// <summary>Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level. Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter. Structure is documented below.</summary>
    [JsonPropertyName("advancedSettings")]
    public IList<V1beta1FlowSpecInitProviderAdvancedSettings>? AdvancedSettings { get; set; }

    /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the flow.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A flow's event handlers serve two purposes: They are responsible for handling events (e.g. no match, webhook errors) in the flow. They are inherited by every page's [event handlers][Page.event_handlers], which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow. Unlike transitionRoutes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored. Structure is documented below.</summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta1FlowSpecInitProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>Marks this as the Default Start Flow for an agent. When you create an agent, the Default Start Flow is created automatically. The Default Start Flow cannot be deleted; deleting the google_dialogflow_cx_flow resource does nothing to the underlying GCP resources.</summary>
    [JsonPropertyName("isDefaultStartFlow")]
    public bool? IsDefaultStartFlow { get; set; }

    /// <summary>The language of the following fields in flow: Flow.event_handlers.trigger_fulfillment.messages Flow.event_handlers.trigger_fulfillment.conditional_cases Flow.transition_routes.trigger_fulfillment.messages Flow.transition_routes.trigger_fulfillment.conditional_cases If not specified, the agent's default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>NLU related settings of the flow. Structure is documented below.</summary>
    [JsonPropertyName("nluSettings")]
    public IList<V1beta1FlowSpecInitProviderNluSettings>? NluSettings { get; set; }

    /// <summary>The agent to create a flow for. Format: projects//locations//agents/.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1FlowSpecInitProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1FlowSpecInitProviderParentSelector? ParentSelector { get; set; }

    /// <summary>A flow's transition route group serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow. Format:projects//locations//agents//flows//transitionRouteGroups/.</summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>A flow's transition routes serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition routes][Page.transition_routes] and can support use cases such as the user saying "help" or "can I talk to a human?", which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow. TransitionRoutes are evalauted in the following order: TransitionRoutes with intent specified. TransitionRoutes with only condition specified. TransitionRoutes with intent specified are inherited by pages in the flow. Structure is documented below.</summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta1FlowSpecInitProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

public enum V1beta1FlowSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1FlowSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FlowSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FlowSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FlowSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlowSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1FlowSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1FlowSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FlowSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FlowSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1FlowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1FlowSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FlowSpecDeletionPolicyEnum>))]
    public V1beta1FlowSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FlowSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FlowSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FlowSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FlowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FlowSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FlowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1FlowStatusAtProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation. Format: gs://bucket/object-name-or-prefix</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1FlowStatusAtProviderAdvancedSettingsDtmfSettings
{
    /// <summary>If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a "3" was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

public partial class V1beta1FlowStatusAtProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public IList<V1beta1FlowStatusAtProviderAdvancedSettingsAudioExportGcsDestination>? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public IList<V1beta1FlowStatusAtProviderAdvancedSettingsDtmfSettings>? DtmfSettings { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See Case for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>(Output) Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>(Output) Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>(Output) Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example:</summary>
    [JsonPropertyName("conversationSuccess")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess>? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example:</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff>? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message. Structure is documented below.</summary>
    [JsonPropertyName("outputAudioText")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText>? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response. Structure is documented below.</summary>
    [JsonPropertyName("playAudio")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesPlayAudio>? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint. Structure is documented below.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall>? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesText>? Text { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment. Structure is documented below.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user. Structure is documented below.</summary>
    [JsonPropertyName("messages")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook. Structure is documented below.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

public partial class V1beta1FlowStatusAtProviderEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>(Output) The unique identifier of this event handler.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The target flow to transition to. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>The target page to transition to. Format: projects//locations//agents//flows//pages/.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks. Structure is documented below.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public IList<V1beta1FlowStatusAtProviderEventHandlersTriggerFulfillment>? TriggerFulfillment { get; set; }
}

public partial class V1beta1FlowStatusAtProviderNluSettings
{
    /// <summary>To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold. If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.</summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>Indicates NLU model training mode.</summary>
    [JsonPropertyName("modelTrainingMode")]
    public string? ModelTrainingMode { get; set; }

    /// <summary>Indicates the type of NLU model.</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored. See Case for the schema.</summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>(Output) Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>(Output) Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>(Output) Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.</summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for example:</summary>
    [JsonPropertyName("conversationSuccess")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess>? ConversationSuccess { get; set; }

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures. You may set this, for example:</summary>
    [JsonPropertyName("liveAgentHandoff")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff>? LiveAgentHandoff { get; set; }

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message. Structure is documented below.</summary>
    [JsonPropertyName("outputAudioText")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText>? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Specifies an audio clip to be played by the client as part of the response. Structure is documented below.</summary>
    [JsonPropertyName("playAudio")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio>? PlayAudio { get; set; }

    /// <summary>Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint. Structure is documented below.</summary>
    [JsonPropertyName("telephonyTransferCall")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall>? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesText>? Text { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>Conditional cases for this fulfillment. Structure is documented below.</summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>The list of rich message responses to present to the user. Structure is documented below.</summary>
    [JsonPropertyName("messages")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>Set parameter values before executing the webhook. Structure is documented below.</summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

public partial class V1beta1FlowStatusAtProviderTransitionRoutes
{
    /// <summary>The condition to evaluate against form parameters or session parameters. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>The unique identifier of an Intent. Format: projects//locations//agents//intents/. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.</summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>(Output) The unique identifier of this transition route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The target flow to transition to. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>The target page to transition to. Format: projects//locations//agents//flows//pages/.</summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first. Structure is documented below.</summary>
    [JsonPropertyName("triggerFulfillment")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutesTriggerFulfillment>? TriggerFulfillment { get; set; }
}

public partial class V1beta1FlowStatusAtProvider
{
    /// <summary>Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level. Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter. Structure is documented below.</summary>
    [JsonPropertyName("advancedSettings")]
    public IList<V1beta1FlowStatusAtProviderAdvancedSettings>? AdvancedSettings { get; set; }

    /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the flow.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A flow's event handlers serve two purposes: They are responsible for handling events (e.g. no match, webhook errors) in the flow. They are inherited by every page's [event handlers][Page.event_handlers], which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow. Unlike transitionRoutes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored. Structure is documented below.</summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta1FlowStatusAtProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/flows/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Marks this as the Default Start Flow for an agent. When you create an agent, the Default Start Flow is created automatically. The Default Start Flow cannot be deleted; deleting the google_dialogflow_cx_flow resource does nothing to the underlying GCP resources.</summary>
    [JsonPropertyName("isDefaultStartFlow")]
    public bool? IsDefaultStartFlow { get; set; }

    /// <summary>The language of the following fields in flow: Flow.event_handlers.trigger_fulfillment.messages Flow.event_handlers.trigger_fulfillment.conditional_cases Flow.transition_routes.trigger_fulfillment.messages Flow.transition_routes.trigger_fulfillment.conditional_cases If not specified, the agent's default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>The unique identifier of the flow. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NLU related settings of the flow. Structure is documented below.</summary>
    [JsonPropertyName("nluSettings")]
    public IList<V1beta1FlowStatusAtProviderNluSettings>? NluSettings { get; set; }

    /// <summary>The agent to create a flow for. Format: projects//locations//agents/.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>A flow's transition route group serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow. Format:projects//locations//agents//flows//transitionRouteGroups/.</summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>A flow's transition routes serve two purposes: They are responsible for matching the user's first utterances in the flow. They are inherited by every page's [transition routes][Page.transition_routes] and can support use cases such as the user saying "help" or "can I talk to a human?", which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow. TransitionRoutes are evalauted in the following order: TransitionRoutes with intent specified. TransitionRoutes with only condition specified. TransitionRoutes with intent specified are inherited by pages in the flow. Structure is documented below.</summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta1FlowStatusAtProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

public partial class V1beta1FlowStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1beta1FlowStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FlowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FlowStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Flow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FlowSpec>, IStatus<V1beta1FlowStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Flow";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FlowSpec defines the desired state of Flow</summary>
    [JsonPropertyName("spec")]
    public V1beta1FlowSpec Spec { get; set; }

    /// <summary>FlowStatus defines the observed state of Flow.</summary>
    [JsonPropertyName("status")]
    public V1beta1FlowStatus? Status { get; set; }
}