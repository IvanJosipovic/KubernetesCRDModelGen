using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lexmodels.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderConclusionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderConclusionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecForProviderConclusionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderConfirmationPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderConfirmationPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecForProviderConfirmationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderDialogCodeHook
{
    /// <summary>The version of the request-response that you want Amazon Lex to use to invoke your Lambda function. For more information, see Using Lambda Functions. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lambda function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderFollowUpPromptPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderFollowUpPromptPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecForProviderFollowUpPromptPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderFollowUpPromptRejectionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderFollowUpPromptRejectionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecForProviderFollowUpPromptRejectionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderFollowUpPrompt
{
    /// <summary>Prompts for information from the user. Attributes are documented under prompt.</summary>
    [JsonPropertyName("prompt")]
    public IList<V1beta1IntentSpecForProviderFollowUpPromptPrompt>? Prompt { get; set; }

    /// <summary>If the user answers "no" to the question defined in the prompt field, Amazon Lex responds with this statement to acknowledge that the intent was canceled. Attributes are documented below under statement.</summary>
    [JsonPropertyName("rejectionStatement")]
    public IList<V1beta1IntentSpecForProviderFollowUpPromptRejectionStatement>? RejectionStatement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderFulfillmentActivityCodeHook
{
    /// <summary>The version of the request-response that you want Amazon Lex to use to invoke your Lambda function. For more information, see Using Lambda Functions. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lambda function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderFulfillmentActivity
{
    /// <summary>A description of the Lambda function that is run to fulfill the intent. Required if type is CodeHook. Attributes are documented under code_hook.</summary>
    [JsonPropertyName("codeHook")]
    public IList<V1beta1IntentSpecForProviderFulfillmentActivityCodeHook>? CodeHook { get; set; }

    /// <summary>How the intent should be fulfilled, either by running a Lambda function or by returning the slot data to the client application. Type can be either ReturnIntent or CodeHook, as documented here.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderRejectionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderRejectionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecForProviderRejectionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderSlotValueElicitationPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderSlotValueElicitationPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecForProviderSlotValueElicitationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProviderSlot
{
    /// <summary>A description of the bot. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the intent slot that you want to create. The name is case sensitive. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Directs Lex the order in which to elicit this slot value from the user. For example, if the intent has two slots with priorities 1 and 2, AWS Lex first elicits a value for the slot with priority 1. If multiple slots share the same priority, the order in which Lex elicits values is arbitrary. Must be between 1 and 100.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }

    /// <summary>If you know a specific pattern with which users might respond to an Amazon Lex request for a slot value, you can provide those utterances to improve accuracy. This is optional. In most cases, Amazon Lex is capable of understanding user utterances. Must have between 1 and 10 items in the list, and each item must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("sampleUtterances")]
    public IList<string>? SampleUtterances { get; set; }

    /// <summary>Specifies whether the slot is required or optional.</summary>
    [JsonPropertyName("slotConstraint")]
    public string? SlotConstraint { get; set; }

    /// <summary>The type of the slot, either a custom slot type that you defined or one of the built-in slot types. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("slotType")]
    public string? SlotType { get; set; }

    /// <summary>The version of the slot type. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("slotTypeVersion")]
    public string? SlotTypeVersion { get; set; }

    /// <summary>The prompt that Amazon Lex uses to elicit the slot value from the user. Attributes are documented under prompt.</summary>
    [JsonPropertyName("valueElicitationPrompt")]
    public IList<V1beta1IntentSpecForProviderSlotValueElicitationPrompt>? ValueElicitationPrompt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecForProvider
{
    /// <summary>The statement that you want Amazon Lex to convey to the user after the intent is successfully fulfilled by the Lambda function. This element is relevant only if you provide a Lambda function in the fulfillment_activity. If you return the intent to the client application, you can't specify this element. The follow_up_prompt and conclusion_statement are mutually exclusive. You can specify only one. Attributes are documented under statement.</summary>
    [JsonPropertyName("conclusionStatement")]
    public IList<V1beta1IntentSpecForProviderConclusionStatement>? ConclusionStatement { get; set; }

    /// <summary>Prompts the user to confirm the intent. This question should have a yes or no answer. You you must provide both the rejection_statement and confirmation_prompt, or neither. Attributes are documented under prompt.</summary>
    [JsonPropertyName("confirmationPrompt")]
    public IList<V1beta1IntentSpecForProviderConfirmationPrompt>? ConfirmationPrompt { get; set; }

    /// <summary>Determines if a new slot type version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>A description of the intent. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a Lambda function to invoke for each user input. You can invoke this Lambda function to personalize user interaction. Attributes are documented under code_hook.</summary>
    [JsonPropertyName("dialogCodeHook")]
    public IList<V1beta1IntentSpecForProviderDialogCodeHook>? DialogCodeHook { get; set; }

    /// <summary>Amazon Lex uses this prompt to solicit additional activity after fulfilling an intent. For example, after the OrderPizza intent is fulfilled, you might prompt the user to order a drink. The follow_up_prompt field and the conclusion_statement field are mutually exclusive. You can specify only one. Attributes are documented under follow_up_prompt.</summary>
    [JsonPropertyName("followUpPrompt")]
    public IList<V1beta1IntentSpecForProviderFollowUpPrompt>? FollowUpPrompt { get; set; }

    /// <summary>Describes how the intent is fulfilled. For example, after a user provides all of the information for a pizza order, fulfillment_activity defines how the bot places an order with a local pizza store. Attributes are documented under fulfillment_activity.</summary>
    [JsonPropertyName("fulfillmentActivity")]
    public IList<V1beta1IntentSpecForProviderFulfillmentActivity>? FulfillmentActivity { get; set; }

    /// <summary>A unique identifier for the built-in intent to base this intent on. To find the signature for an intent, see Standard Built-in Intents in the Alexa Skills Kit.</summary>
    [JsonPropertyName("parentIntentSignature")]
    public string? ParentIntentSignature { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>When the user answers "no" to the question defined in confirmation_prompt, Amazon Lex responds with this statement to acknowledge that the intent was canceled. You must provide both the rejection_statement and the confirmation_prompt, or neither. Attributes are documented under statement.</summary>
    [JsonPropertyName("rejectionStatement")]
    public IList<V1beta1IntentSpecForProviderRejectionStatement>? RejectionStatement { get; set; }

    /// <summary>An array of utterances (strings) that a user might say to signal the intent. For example, "I want {PizzaSize} pizza", "Order {Quantity} {PizzaSize} pizzas". In each utterance, a slot name is enclosed in curly braces. Must have between 1 and 10 items in the list, and each item must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("sampleUtterances")]
    public IList<string>? SampleUtterances { get; set; }

    /// <summary>An list of intent slots. At runtime, Amazon Lex elicits required slot values from the user using prompts defined in the slots. Attributes are documented under slot.</summary>
    [JsonPropertyName("slot")]
    public IList<V1beta1IntentSpecForProviderSlot>? Slot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderConclusionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderConclusionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecInitProviderConclusionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderConfirmationPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderConfirmationPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecInitProviderConfirmationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderDialogCodeHook
{
    /// <summary>The version of the request-response that you want Amazon Lex to use to invoke your Lambda function. For more information, see Using Lambda Functions. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lambda function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderFollowUpPromptPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderFollowUpPromptPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecInitProviderFollowUpPromptPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderFollowUpPromptRejectionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderFollowUpPromptRejectionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecInitProviderFollowUpPromptRejectionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderFollowUpPrompt
{
    /// <summary>Prompts for information from the user. Attributes are documented under prompt.</summary>
    [JsonPropertyName("prompt")]
    public IList<V1beta1IntentSpecInitProviderFollowUpPromptPrompt>? Prompt { get; set; }

    /// <summary>If the user answers "no" to the question defined in the prompt field, Amazon Lex responds with this statement to acknowledge that the intent was canceled. Attributes are documented below under statement.</summary>
    [JsonPropertyName("rejectionStatement")]
    public IList<V1beta1IntentSpecInitProviderFollowUpPromptRejectionStatement>? RejectionStatement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderFulfillmentActivityCodeHook
{
    /// <summary>The version of the request-response that you want Amazon Lex to use to invoke your Lambda function. For more information, see Using Lambda Functions. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lambda function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderFulfillmentActivity
{
    /// <summary>A description of the Lambda function that is run to fulfill the intent. Required if type is CodeHook. Attributes are documented under code_hook.</summary>
    [JsonPropertyName("codeHook")]
    public IList<V1beta1IntentSpecInitProviderFulfillmentActivityCodeHook>? CodeHook { get; set; }

    /// <summary>How the intent should be fulfilled, either by running a Lambda function or by returning the slot data to the client application. Type can be either ReturnIntent or CodeHook, as documented here.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderRejectionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderRejectionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecInitProviderRejectionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderSlotValueElicitationPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderSlotValueElicitationPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentSpecInitProviderSlotValueElicitationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProviderSlot
{
    /// <summary>A description of the bot. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the intent slot that you want to create. The name is case sensitive. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Directs Lex the order in which to elicit this slot value from the user. For example, if the intent has two slots with priorities 1 and 2, AWS Lex first elicits a value for the slot with priority 1. If multiple slots share the same priority, the order in which Lex elicits values is arbitrary. Must be between 1 and 100.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }

    /// <summary>If you know a specific pattern with which users might respond to an Amazon Lex request for a slot value, you can provide those utterances to improve accuracy. This is optional. In most cases, Amazon Lex is capable of understanding user utterances. Must have between 1 and 10 items in the list, and each item must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("sampleUtterances")]
    public IList<string>? SampleUtterances { get; set; }

    /// <summary>Specifies whether the slot is required or optional.</summary>
    [JsonPropertyName("slotConstraint")]
    public string? SlotConstraint { get; set; }

    /// <summary>The type of the slot, either a custom slot type that you defined or one of the built-in slot types. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("slotType")]
    public string? SlotType { get; set; }

    /// <summary>The version of the slot type. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("slotTypeVersion")]
    public string? SlotTypeVersion { get; set; }

    /// <summary>The prompt that Amazon Lex uses to elicit the slot value from the user. Attributes are documented under prompt.</summary>
    [JsonPropertyName("valueElicitationPrompt")]
    public IList<V1beta1IntentSpecInitProviderSlotValueElicitationPrompt>? ValueElicitationPrompt { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecInitProvider
{
    /// <summary>The statement that you want Amazon Lex to convey to the user after the intent is successfully fulfilled by the Lambda function. This element is relevant only if you provide a Lambda function in the fulfillment_activity. If you return the intent to the client application, you can't specify this element. The follow_up_prompt and conclusion_statement are mutually exclusive. You can specify only one. Attributes are documented under statement.</summary>
    [JsonPropertyName("conclusionStatement")]
    public IList<V1beta1IntentSpecInitProviderConclusionStatement>? ConclusionStatement { get; set; }

    /// <summary>Prompts the user to confirm the intent. This question should have a yes or no answer. You you must provide both the rejection_statement and confirmation_prompt, or neither. Attributes are documented under prompt.</summary>
    [JsonPropertyName("confirmationPrompt")]
    public IList<V1beta1IntentSpecInitProviderConfirmationPrompt>? ConfirmationPrompt { get; set; }

    /// <summary>Determines if a new slot type version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>A description of the intent. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a Lambda function to invoke for each user input. You can invoke this Lambda function to personalize user interaction. Attributes are documented under code_hook.</summary>
    [JsonPropertyName("dialogCodeHook")]
    public IList<V1beta1IntentSpecInitProviderDialogCodeHook>? DialogCodeHook { get; set; }

    /// <summary>Amazon Lex uses this prompt to solicit additional activity after fulfilling an intent. For example, after the OrderPizza intent is fulfilled, you might prompt the user to order a drink. The follow_up_prompt field and the conclusion_statement field are mutually exclusive. You can specify only one. Attributes are documented under follow_up_prompt.</summary>
    [JsonPropertyName("followUpPrompt")]
    public IList<V1beta1IntentSpecInitProviderFollowUpPrompt>? FollowUpPrompt { get; set; }

    /// <summary>Describes how the intent is fulfilled. For example, after a user provides all of the information for a pizza order, fulfillment_activity defines how the bot places an order with a local pizza store. Attributes are documented under fulfillment_activity.</summary>
    [JsonPropertyName("fulfillmentActivity")]
    public IList<V1beta1IntentSpecInitProviderFulfillmentActivity>? FulfillmentActivity { get; set; }

    /// <summary>A unique identifier for the built-in intent to base this intent on. To find the signature for an intent, see Standard Built-in Intents in the Alexa Skills Kit.</summary>
    [JsonPropertyName("parentIntentSignature")]
    public string? ParentIntentSignature { get; set; }

    /// <summary>When the user answers "no" to the question defined in confirmation_prompt, Amazon Lex responds with this statement to acknowledge that the intent was canceled. You must provide both the rejection_statement and the confirmation_prompt, or neither. Attributes are documented under statement.</summary>
    [JsonPropertyName("rejectionStatement")]
    public IList<V1beta1IntentSpecInitProviderRejectionStatement>? RejectionStatement { get; set; }

    /// <summary>An array of utterances (strings) that a user might say to signal the intent. For example, "I want {PizzaSize} pizza", "Order {Quantity} {PizzaSize} pizzas". In each utterance, a slot name is enclosed in curly braces. Must have between 1 and 10 items in the list, and each item must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("sampleUtterances")]
    public IList<string>? SampleUtterances { get; set; }

    /// <summary>An list of intent slots. At runtime, Amazon Lex elicits required slot values from the user using prompts defined in the slots. Attributes are documented under slot.</summary>
    [JsonPropertyName("slot")]
    public IList<V1beta1IntentSpecInitProviderSlot>? Slot { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IntentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>IntentSpec defines the desired state of Intent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IntentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IntentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IntentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IntentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderConclusionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderConclusionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentStatusAtProviderConclusionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderConfirmationPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderConfirmationPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentStatusAtProviderConfirmationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderDialogCodeHook
{
    /// <summary>The version of the request-response that you want Amazon Lex to use to invoke your Lambda function. For more information, see Using Lambda Functions. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lambda function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderFollowUpPromptPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderFollowUpPromptPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentStatusAtProviderFollowUpPromptPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderFollowUpPromptRejectionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderFollowUpPromptRejectionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentStatusAtProviderFollowUpPromptRejectionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderFollowUpPrompt
{
    /// <summary>Prompts for information from the user. Attributes are documented under prompt.</summary>
    [JsonPropertyName("prompt")]
    public IList<V1beta1IntentStatusAtProviderFollowUpPromptPrompt>? Prompt { get; set; }

    /// <summary>If the user answers "no" to the question defined in the prompt field, Amazon Lex responds with this statement to acknowledge that the intent was canceled. Attributes are documented below under statement.</summary>
    [JsonPropertyName("rejectionStatement")]
    public IList<V1beta1IntentStatusAtProviderFollowUpPromptRejectionStatement>? RejectionStatement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderFulfillmentActivityCodeHook
{
    /// <summary>The version of the request-response that you want Amazon Lex to use to invoke your Lambda function. For more information, see Using Lambda Functions. Must be less than or equal to 5 characters in length.</summary>
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lambda function.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderFulfillmentActivity
{
    /// <summary>A description of the Lambda function that is run to fulfill the intent. Required if type is CodeHook. Attributes are documented under code_hook.</summary>
    [JsonPropertyName("codeHook")]
    public IList<V1beta1IntentStatusAtProviderFulfillmentActivityCodeHook>? CodeHook { get; set; }

    /// <summary>How the intent should be fulfilled, either by running a Lambda function or by returning the slot data to the client application. Type can be either ReturnIntent or CodeHook, as documented here.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderRejectionStatementMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderRejectionStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentStatusAtProviderRejectionStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderSlotValueElicitationPromptMessage
{
    /// <summary>The text of the message. Must be less than or equal to 1000 characters in length.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderSlotValueElicitationPrompt
{
    /// <summary>The number of times to prompt the user for information. Must be a number between 1 and 5 (inclusive).</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message. Must contain between 1 and 15 messages.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1IntentStatusAtProviderSlotValueElicitationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProviderSlot
{
    /// <summary>A description of the bot. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the intent slot that you want to create. The name is case sensitive. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Directs Lex the order in which to elicit this slot value from the user. For example, if the intent has two slots with priorities 1 and 2, AWS Lex first elicits a value for the slot with priority 1. If multiple slots share the same priority, the order in which Lex elicits values is arbitrary. Must be between 1 and 100.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card. Must be less than or equal to 50000 characters in length.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }

    /// <summary>If you know a specific pattern with which users might respond to an Amazon Lex request for a slot value, you can provide those utterances to improve accuracy. This is optional. In most cases, Amazon Lex is capable of understanding user utterances. Must have between 1 and 10 items in the list, and each item must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("sampleUtterances")]
    public IList<string>? SampleUtterances { get; set; }

    /// <summary>Specifies whether the slot is required or optional.</summary>
    [JsonPropertyName("slotConstraint")]
    public string? SlotConstraint { get; set; }

    /// <summary>The type of the slot, either a custom slot type that you defined or one of the built-in slot types. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("slotType")]
    public string? SlotType { get; set; }

    /// <summary>The version of the slot type. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("slotTypeVersion")]
    public string? SlotTypeVersion { get; set; }

    /// <summary>The prompt that Amazon Lex uses to elicit the slot value from the user. Attributes are documented under prompt.</summary>
    [JsonPropertyName("valueElicitationPrompt")]
    public IList<V1beta1IntentStatusAtProviderSlotValueElicitationPrompt>? ValueElicitationPrompt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusAtProvider
{
    /// <summary>The ARN of the Lex intent.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Checksum identifying the version of the intent that was created. The checksum is not included as an argument because the resource will add it automatically when updating the intent.</summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>The statement that you want Amazon Lex to convey to the user after the intent is successfully fulfilled by the Lambda function. This element is relevant only if you provide a Lambda function in the fulfillment_activity. If you return the intent to the client application, you can't specify this element. The follow_up_prompt and conclusion_statement are mutually exclusive. You can specify only one. Attributes are documented under statement.</summary>
    [JsonPropertyName("conclusionStatement")]
    public IList<V1beta1IntentStatusAtProviderConclusionStatement>? ConclusionStatement { get; set; }

    /// <summary>Prompts the user to confirm the intent. This question should have a yes or no answer. You you must provide both the rejection_statement and confirmation_prompt, or neither. Attributes are documented under prompt.</summary>
    [JsonPropertyName("confirmationPrompt")]
    public IList<V1beta1IntentStatusAtProviderConfirmationPrompt>? ConfirmationPrompt { get; set; }

    /// <summary>Determines if a new slot type version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>The date when the intent version was created.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>A description of the intent. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a Lambda function to invoke for each user input. You can invoke this Lambda function to personalize user interaction. Attributes are documented under code_hook.</summary>
    [JsonPropertyName("dialogCodeHook")]
    public IList<V1beta1IntentStatusAtProviderDialogCodeHook>? DialogCodeHook { get; set; }

    /// <summary>Amazon Lex uses this prompt to solicit additional activity after fulfilling an intent. For example, after the OrderPizza intent is fulfilled, you might prompt the user to order a drink. The follow_up_prompt field and the conclusion_statement field are mutually exclusive. You can specify only one. Attributes are documented under follow_up_prompt.</summary>
    [JsonPropertyName("followUpPrompt")]
    public IList<V1beta1IntentStatusAtProviderFollowUpPrompt>? FollowUpPrompt { get; set; }

    /// <summary>Describes how the intent is fulfilled. For example, after a user provides all of the information for a pizza order, fulfillment_activity defines how the bot places an order with a local pizza store. Attributes are documented under fulfillment_activity.</summary>
    [JsonPropertyName("fulfillmentActivity")]
    public IList<V1beta1IntentStatusAtProviderFulfillmentActivity>? FulfillmentActivity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date when the $LATEST version of this intent was updated.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>A unique identifier for the built-in intent to base this intent on. To find the signature for an intent, see Standard Built-in Intents in the Alexa Skills Kit.</summary>
    [JsonPropertyName("parentIntentSignature")]
    public string? ParentIntentSignature { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>When the user answers "no" to the question defined in confirmation_prompt, Amazon Lex responds with this statement to acknowledge that the intent was canceled. You must provide both the rejection_statement and the confirmation_prompt, or neither. Attributes are documented under statement.</summary>
    [JsonPropertyName("rejectionStatement")]
    public IList<V1beta1IntentStatusAtProviderRejectionStatement>? RejectionStatement { get; set; }

    /// <summary>An array of utterances (strings) that a user might say to signal the intent. For example, "I want {PizzaSize} pizza", "Order {Quantity} {PizzaSize} pizzas". In each utterance, a slot name is enclosed in curly braces. Must have between 1 and 10 items in the list, and each item must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("sampleUtterances")]
    public IList<string>? SampleUtterances { get; set; }

    /// <summary>An list of intent slots. At runtime, Amazon Lex elicits required slot values from the user using prompts defined in the slots. Attributes are documented under slot.</summary>
    [JsonPropertyName("slot")]
    public IList<V1beta1IntentStatusAtProviderSlot>? Slot { get; set; }

    /// <summary>The version of the bot.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatusConditions
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

/// <summary>IntentStatus defines the observed state of Intent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IntentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IntentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IntentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Intent is the Schema for the Intents API. Provides an Amazon Lex intent resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Intent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IntentSpec>, IStatus<V1beta1IntentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Intent";
    public const string KubeGroup = "lexmodels.aws.upbound.io";
    public const string KubePluralName = "intents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IntentSpec defines the desired state of Intent</summary>
    [JsonPropertyName("spec")]
    public V1beta1IntentSpec Spec { get; set; }

    /// <summary>IntentStatus defines the observed state of Intent.</summary>
    [JsonPropertyName("status")]
    public V1beta1IntentStatus? Status { get; set; }
}

/// <summary>Intent is the Schema for the Intents API. Provides an Amazon Lex intent resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IntentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Intent>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IntentList";
    public const string KubeGroup = "lexmodels.aws.upbound.io";
    public const string KubePluralName = "intents";
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
    public IList<V1beta1Intent> Items { get; set; }
}