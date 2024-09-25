using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lexmodels.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BotSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecForProviderAbortStatementMessage
{
    /// <summary>The text of the message.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response.</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecForProviderAbortStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1BotSpecForProviderAbortStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecForProviderClarificationPromptMessage
{
    /// <summary>The text of the message.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response.</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecForProviderClarificationPrompt
{
    /// <summary>The number of times to prompt the user for information.</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1BotSpecForProviderClarificationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecForProviderIntent
{
    /// <summary>The name of the intent. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("intentName")]
    public string? IntentName { get; set; }

    /// <summary>The version of the intent. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("intentVersion")]
    public string? IntentVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecForProvider
{
    /// <summary>The message that Amazon Lex uses to abort a conversation. Attributes are documented under statement.</summary>
    [JsonPropertyName("abortStatement")]
    public IList<V1beta1BotSpecForProviderAbortStatement>? AbortStatement { get; set; }

    /// <summary>By specifying true, you confirm that your use of Amazon Lex is related to a website, program, or other application that is directed or targeted, in whole or in part, to children under age 13 and subject to COPPA. For more information see the Amazon Lex FAQ and the Amazon Lex PutBot API Docs.</summary>
    [JsonPropertyName("childDirected")]
    public bool? ChildDirected { get; set; }

    /// <summary>The message that Amazon Lex uses when it doesn't understand the user's request. Attributes are documented under prompt.</summary>
    [JsonPropertyName("clarificationPrompt")]
    public IList<V1beta1BotSpecForProviderClarificationPrompt>? ClarificationPrompt { get; set; }

    /// <summary>Determines if a new bot version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>A description of the bot. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>When set to true user utterances are sent to Amazon Comprehend for sentiment analysis. If you don't specify detectSentiment, the default is false.</summary>
    [JsonPropertyName("detectSentiment")]
    public bool? DetectSentiment { get; set; }

    /// <summary>Set to true to enable access to natural language understanding improvements. When you set the enable_model_improvements parameter to true you can use the nlu_intent_confidence_threshold parameter to configure confidence scores. For more information, see Confidence Scores. You can only set the enable_model_improvements parameter in certain Regions. If you set the parameter to true, your bot has access to accuracy improvements. For more information see the Amazon Lex Bot PutBot API Docs.</summary>
    [JsonPropertyName("enableModelImprovements")]
    public bool? EnableModelImprovements { get; set; }

    /// <summary>The maximum time in seconds that Amazon Lex retains the data gathered in a conversation. Default is 300. Must be a number between 60 and 86400 (inclusive).</summary>
    [JsonPropertyName("idleSessionTtlInSeconds")]
    public double? IdleSessionTtlInSeconds { get; set; }

    /// <summary>A set of Intent objects. Each intent represents a command that a user can express. Attributes are documented under intent. Can have up to 250 Intent objects.</summary>
    [JsonPropertyName("intent")]
    public IList<V1beta1BotSpecForProviderIntent>? Intent { get; set; }

    /// <summary>Specifies the target locale for the bot. Any intent used in the bot must be compatible with the locale of the bot. For available locales, see Amazon Lex Bot PutBot API Docs. Default is en-US.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Determines the threshold where Amazon Lex will insert the AMAZON.FallbackIntent, AMAZON.KendraSearchIntent, or both when returning alternative intents in a PostContent or PostText response. AMAZON.FallbackIntent and AMAZON.KendraSearchIntent are only inserted if they are configured for the bot. For more information see Amazon Lex Bot PutBot API Docs This value requires enable_model_improvements to be set to true and the default is 0. Must be a float between 0 and 1.</summary>
    [JsonPropertyName("nluIntentConfidenceThreshold")]
    public double? NluIntentConfidenceThreshold { get; set; }

    /// <summary>If you set the process_behavior element to BUILD, Amazon Lex builds the bot so that it can be run. If you set the element to SAVE Amazon Lex saves the bot, but doesn't build it. Default is SAVE.</summary>
    [JsonPropertyName("processBehavior")]
    public string? ProcessBehavior { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The Amazon Polly voice ID that you want Amazon Lex to use for voice interactions with the user. The locale configured for the voice must match the locale of the bot. For more information, see Available Voices in the Amazon Polly Developer Guide.</summary>
    [JsonPropertyName("voiceId")]
    public string? VoiceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecInitProviderAbortStatementMessage
{
    /// <summary>The text of the message.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response.</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecInitProviderAbortStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1BotSpecInitProviderAbortStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecInitProviderClarificationPromptMessage
{
    /// <summary>The text of the message.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response.</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecInitProviderClarificationPrompt
{
    /// <summary>The number of times to prompt the user for information.</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1BotSpecInitProviderClarificationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecInitProviderIntent
{
    /// <summary>The name of the intent. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("intentName")]
    public string? IntentName { get; set; }

    /// <summary>The version of the intent. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("intentVersion")]
    public string? IntentVersion { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecInitProvider
{
    /// <summary>The message that Amazon Lex uses to abort a conversation. Attributes are documented under statement.</summary>
    [JsonPropertyName("abortStatement")]
    public IList<V1beta1BotSpecInitProviderAbortStatement>? AbortStatement { get; set; }

    /// <summary>By specifying true, you confirm that your use of Amazon Lex is related to a website, program, or other application that is directed or targeted, in whole or in part, to children under age 13 and subject to COPPA. For more information see the Amazon Lex FAQ and the Amazon Lex PutBot API Docs.</summary>
    [JsonPropertyName("childDirected")]
    public bool? ChildDirected { get; set; }

    /// <summary>The message that Amazon Lex uses when it doesn't understand the user's request. Attributes are documented under prompt.</summary>
    [JsonPropertyName("clarificationPrompt")]
    public IList<V1beta1BotSpecInitProviderClarificationPrompt>? ClarificationPrompt { get; set; }

    /// <summary>Determines if a new bot version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>A description of the bot. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>When set to true user utterances are sent to Amazon Comprehend for sentiment analysis. If you don't specify detectSentiment, the default is false.</summary>
    [JsonPropertyName("detectSentiment")]
    public bool? DetectSentiment { get; set; }

    /// <summary>Set to true to enable access to natural language understanding improvements. When you set the enable_model_improvements parameter to true you can use the nlu_intent_confidence_threshold parameter to configure confidence scores. For more information, see Confidence Scores. You can only set the enable_model_improvements parameter in certain Regions. If you set the parameter to true, your bot has access to accuracy improvements. For more information see the Amazon Lex Bot PutBot API Docs.</summary>
    [JsonPropertyName("enableModelImprovements")]
    public bool? EnableModelImprovements { get; set; }

    /// <summary>The maximum time in seconds that Amazon Lex retains the data gathered in a conversation. Default is 300. Must be a number between 60 and 86400 (inclusive).</summary>
    [JsonPropertyName("idleSessionTtlInSeconds")]
    public double? IdleSessionTtlInSeconds { get; set; }

    /// <summary>A set of Intent objects. Each intent represents a command that a user can express. Attributes are documented under intent. Can have up to 250 Intent objects.</summary>
    [JsonPropertyName("intent")]
    public IList<V1beta1BotSpecInitProviderIntent>? Intent { get; set; }

    /// <summary>Specifies the target locale for the bot. Any intent used in the bot must be compatible with the locale of the bot. For available locales, see Amazon Lex Bot PutBot API Docs. Default is en-US.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Determines the threshold where Amazon Lex will insert the AMAZON.FallbackIntent, AMAZON.KendraSearchIntent, or both when returning alternative intents in a PostContent or PostText response. AMAZON.FallbackIntent and AMAZON.KendraSearchIntent are only inserted if they are configured for the bot. For more information see Amazon Lex Bot PutBot API Docs This value requires enable_model_improvements to be set to true and the default is 0. Must be a float between 0 and 1.</summary>
    [JsonPropertyName("nluIntentConfidenceThreshold")]
    public double? NluIntentConfidenceThreshold { get; set; }

    /// <summary>If you set the process_behavior element to BUILD, Amazon Lex builds the bot so that it can be run. If you set the element to SAVE Amazon Lex saves the bot, but doesn't build it. Default is SAVE.</summary>
    [JsonPropertyName("processBehavior")]
    public string? ProcessBehavior { get; set; }

    /// <summary>The Amazon Polly voice ID that you want Amazon Lex to use for voice interactions with the user. The locale configured for the voice must match the locale of the bot. For more information, see Available Voices in the Amazon Polly Developer Guide.</summary>
    [JsonPropertyName("voiceId")]
    public string? VoiceId { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BotSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BotSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BotSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BotSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BotSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BotSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BotSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BotSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BotSpec defines the desired state of Bot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BotSpecDeletionPolicyEnum>))]
    public V1beta1BotSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BotSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BotSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BotSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BotSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BotSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BotSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatusAtProviderAbortStatementMessage
{
    /// <summary>The text of the message.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response.</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatusAtProviderAbortStatement
{
    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1BotStatusAtProviderAbortStatementMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatusAtProviderClarificationPromptMessage
{
    /// <summary>The text of the message.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The content type of the message string.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifies the message group that the message belongs to. When a group is assigned to a message, Amazon Lex returns one message from each group in the response.</summary>
    [JsonPropertyName("groupNumber")]
    public double? GroupNumber { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatusAtProviderClarificationPrompt
{
    /// <summary>The number of times to prompt the user for information.</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A set of messages, each of which provides a message string and its type. You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML). Attributes are documented under message.</summary>
    [JsonPropertyName("message")]
    public IList<V1beta1BotStatusAtProviderClarificationPromptMessage>? Message { get; set; }

    /// <summary>The response card. Amazon Lex will substitute session attributes and slot values into the response card. For more information, see Example: Using a Response Card.</summary>
    [JsonPropertyName("responseCard")]
    public string? ResponseCard { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatusAtProviderIntent
{
    /// <summary>The name of the intent. Must be less than or equal to 100 characters in length.</summary>
    [JsonPropertyName("intentName")]
    public string? IntentName { get; set; }

    /// <summary>The version of the intent. Must be less than or equal to 64 characters in length.</summary>
    [JsonPropertyName("intentVersion")]
    public string? IntentVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatusAtProvider
{
    /// <summary>The message that Amazon Lex uses to abort a conversation. Attributes are documented under statement.</summary>
    [JsonPropertyName("abortStatement")]
    public IList<V1beta1BotStatusAtProviderAbortStatement>? AbortStatement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Checksum identifying the version of the bot that was created. The checksum is not included as an argument because the resource will add it automatically when updating the bot.</summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>By specifying true, you confirm that your use of Amazon Lex is related to a website, program, or other application that is directed or targeted, in whole or in part, to children under age 13 and subject to COPPA. For more information see the Amazon Lex FAQ and the Amazon Lex PutBot API Docs.</summary>
    [JsonPropertyName("childDirected")]
    public bool? ChildDirected { get; set; }

    /// <summary>The message that Amazon Lex uses when it doesn't understand the user's request. Attributes are documented under prompt.</summary>
    [JsonPropertyName("clarificationPrompt")]
    public IList<V1beta1BotStatusAtProviderClarificationPrompt>? ClarificationPrompt { get; set; }

    /// <summary>Determines if a new bot version is created when the initial resource is created and on each update. Defaults to false.</summary>
    [JsonPropertyName("createVersion")]
    public bool? CreateVersion { get; set; }

    /// <summary>The date when the bot version was created.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>A description of the bot. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>When set to true user utterances are sent to Amazon Comprehend for sentiment analysis. If you don't specify detectSentiment, the default is false.</summary>
    [JsonPropertyName("detectSentiment")]
    public bool? DetectSentiment { get; set; }

    /// <summary>Set to true to enable access to natural language understanding improvements. When you set the enable_model_improvements parameter to true you can use the nlu_intent_confidence_threshold parameter to configure confidence scores. For more information, see Confidence Scores. You can only set the enable_model_improvements parameter in certain Regions. If you set the parameter to true, your bot has access to accuracy improvements. For more information see the Amazon Lex Bot PutBot API Docs.</summary>
    [JsonPropertyName("enableModelImprovements")]
    public bool? EnableModelImprovements { get; set; }

    /// <summary>If status is FAILED, Amazon Lex provides the reason that it failed to build the bot.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum time in seconds that Amazon Lex retains the data gathered in a conversation. Default is 300. Must be a number between 60 and 86400 (inclusive).</summary>
    [JsonPropertyName("idleSessionTtlInSeconds")]
    public double? IdleSessionTtlInSeconds { get; set; }

    /// <summary>A set of Intent objects. Each intent represents a command that a user can express. Attributes are documented under intent. Can have up to 250 Intent objects.</summary>
    [JsonPropertyName("intent")]
    public IList<V1beta1BotStatusAtProviderIntent>? Intent { get; set; }

    /// <summary>The date when the $LATEST version of this bot was updated.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Specifies the target locale for the bot. Any intent used in the bot must be compatible with the locale of the bot. For available locales, see Amazon Lex Bot PutBot API Docs. Default is en-US.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Determines the threshold where Amazon Lex will insert the AMAZON.FallbackIntent, AMAZON.KendraSearchIntent, or both when returning alternative intents in a PostContent or PostText response. AMAZON.FallbackIntent and AMAZON.KendraSearchIntent are only inserted if they are configured for the bot. For more information see Amazon Lex Bot PutBot API Docs This value requires enable_model_improvements to be set to true and the default is 0. Must be a float between 0 and 1.</summary>
    [JsonPropertyName("nluIntentConfidenceThreshold")]
    public double? NluIntentConfidenceThreshold { get; set; }

    /// <summary>If you set the process_behavior element to BUILD, Amazon Lex builds the bot so that it can be run. If you set the element to SAVE Amazon Lex saves the bot, but doesn't build it. Default is SAVE.</summary>
    [JsonPropertyName("processBehavior")]
    public string? ProcessBehavior { get; set; }

    /// <summary>When you send a request to create or update a bot, Amazon Lex sets the status response element to BUILDING. After Amazon Lex builds the bot, it sets status to READY. If Amazon Lex can't build the bot, it sets status to FAILED. Amazon Lex returns the reason for the failure in the failure_reason response element.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The version of the bot.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The Amazon Polly voice ID that you want Amazon Lex to use for voice interactions with the user. The locale configured for the voice must match the locale of the bot. For more information, see Available Voices in the Amazon Polly Developer Guide.</summary>
    [JsonPropertyName("voiceId")]
    public string? VoiceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatusConditions
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

/// <summary>BotStatus defines the observed state of Bot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BotStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BotStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Bot is the Schema for the Bots API. Provides an Amazon Lex bot resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Bot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BotSpec>, IStatus<V1beta1BotStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Bot";
    public const string KubeGroup = "lexmodels.aws.upbound.io";
    public const string KubePluralName = "bots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BotSpec defines the desired state of Bot</summary>
    [JsonPropertyName("spec")]
    public V1beta1BotSpec Spec { get; set; }

    /// <summary>BotStatus defines the observed state of Bot.</summary>
    [JsonPropertyName("status")]
    public V1beta1BotStatus? Status { get; set; }
}