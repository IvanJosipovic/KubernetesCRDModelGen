using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.gcp.upbound.io;
public enum V1beta1AgentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1AgentSpecForProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation. Format: gs://bucket/object-name-or-prefix</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1AgentSpecForProviderAdvancedSettingsDtmfSettings
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

public partial class V1beta1AgentSpecForProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public IList<V1beta1AgentSpecForProviderAdvancedSettingsAudioExportGcsDestination>? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public IList<V1beta1AgentSpecForProviderAdvancedSettingsDtmfSettings>? DtmfSettings { get; set; }
}

public partial class V1beta1AgentSpecForProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1AgentSpecForProviderGitIntegrationSettingsGithubSettings
{
    /// <summary>The access token used to authenticate the access to the GitHub repository. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta1AgentSpecForProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>A list of branches configured to be used from Dialogflow.</summary>
    [JsonPropertyName("branches")]
    public IList<string>? Branches { get; set; }

    /// <summary>The unique repository display name for the GitHub repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The GitHub repository URI related to the agent.</summary>
    [JsonPropertyName("repositoryUri")]
    public string? RepositoryUri { get; set; }

    /// <summary>The branch of the GitHub repository tracked for this agent.</summary>
    [JsonPropertyName("trackingBranch")]
    public string? TrackingBranch { get; set; }
}

public partial class V1beta1AgentSpecForProviderGitIntegrationSettings
{
    /// <summary>Settings of integration with GitHub. Structure is documented below.</summary>
    [JsonPropertyName("githubSettings")]
    public IList<V1beta1AgentSpecForProviderGitIntegrationSettingsGithubSettings>? GithubSettings { get; set; }
}

public partial class V1beta1AgentSpecForProviderSpeechToTextSettings
{
    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("enableSpeechAdaptation")]
    public bool? EnableSpeechAdaptation { get; set; }
}

public partial class V1beta1AgentSpecForProviderTextToSpeechSettings
{
    /// <summary>Configuration of how speech should be synthesized, mapping from language to SynthesizeSpeechConfig. These settings affect:</summary>
    [JsonPropertyName("synthesizeSpeechConfigs")]
    public string? SynthesizeSpeechConfigs { get; set; }
}

public partial class V1beta1AgentSpecForProvider
{
    /// <summary>Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level. Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter. Structure is documented below.</summary>
    [JsonPropertyName("advancedSettings")]
    public IList<V1beta1AgentSpecForProviderAdvancedSettings>? AdvancedSettings { get; set; }

    /// <summary>The URI of the agent's avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.</summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>The default language of the agent as a language tag. See Language Support for a list of the currently supported language codes. This field cannot be updated after creation.</summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the agent, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Git integration settings for this agent. Structure is documented below.</summary>
    [JsonPropertyName("gitIntegrationSettings")]
    public IList<V1beta1AgentSpecForProviderGitIntegrationSettings>? GitIntegrationSettings { get; set; }

    /// <summary>The name of the location this agent is located in. ~&gt; Note: The first time you are deploying an Agent in your project you must configure location settings. This is a one time step but at the moment you can only configure location settings via the Dialogflow CX console. Another options is to use global location so you don't need to manually configure location settings.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Settings related to speech recognition. Structure is documented below.</summary>
    [JsonPropertyName("speechToTextSettings")]
    public IList<V1beta1AgentSpecForProviderSpeechToTextSettings>? SpeechToTextSettings { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the default_language_code).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>Settings related to speech synthesizing. Structure is documented below.</summary>
    [JsonPropertyName("textToSpeechSettings")]
    public IList<V1beta1AgentSpecForProviderTextToSpeechSettings>? TextToSpeechSettings { get; set; }

    /// <summary>The time zone of this agent from the time zone database, e.g., America/New_York, Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1AgentSpecInitProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation. Format: gs://bucket/object-name-or-prefix</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1AgentSpecInitProviderAdvancedSettingsDtmfSettings
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

public partial class V1beta1AgentSpecInitProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public IList<V1beta1AgentSpecInitProviderAdvancedSettingsAudioExportGcsDestination>? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public IList<V1beta1AgentSpecInitProviderAdvancedSettingsDtmfSettings>? DtmfSettings { get; set; }
}

public partial class V1beta1AgentSpecInitProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1AgentSpecInitProviderGitIntegrationSettingsGithubSettings
{
    /// <summary>The access token used to authenticate the access to the GitHub repository. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta1AgentSpecInitProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>A list of branches configured to be used from Dialogflow.</summary>
    [JsonPropertyName("branches")]
    public IList<string>? Branches { get; set; }

    /// <summary>The unique repository display name for the GitHub repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The GitHub repository URI related to the agent.</summary>
    [JsonPropertyName("repositoryUri")]
    public string? RepositoryUri { get; set; }

    /// <summary>The branch of the GitHub repository tracked for this agent.</summary>
    [JsonPropertyName("trackingBranch")]
    public string? TrackingBranch { get; set; }
}

public partial class V1beta1AgentSpecInitProviderGitIntegrationSettings
{
    /// <summary>Settings of integration with GitHub. Structure is documented below.</summary>
    [JsonPropertyName("githubSettings")]
    public IList<V1beta1AgentSpecInitProviderGitIntegrationSettingsGithubSettings>? GithubSettings { get; set; }
}

public partial class V1beta1AgentSpecInitProviderSpeechToTextSettings
{
    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("enableSpeechAdaptation")]
    public bool? EnableSpeechAdaptation { get; set; }
}

public partial class V1beta1AgentSpecInitProviderTextToSpeechSettings
{
    /// <summary>Configuration of how speech should be synthesized, mapping from language to SynthesizeSpeechConfig. These settings affect:</summary>
    [JsonPropertyName("synthesizeSpeechConfigs")]
    public string? SynthesizeSpeechConfigs { get; set; }
}

public partial class V1beta1AgentSpecInitProvider
{
    /// <summary>Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level. Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter. Structure is documented below.</summary>
    [JsonPropertyName("advancedSettings")]
    public IList<V1beta1AgentSpecInitProviderAdvancedSettings>? AdvancedSettings { get; set; }

    /// <summary>The URI of the agent's avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.</summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>The default language of the agent as a language tag. See Language Support for a list of the currently supported language codes. This field cannot be updated after creation.</summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the agent, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Git integration settings for this agent. Structure is documented below.</summary>
    [JsonPropertyName("gitIntegrationSettings")]
    public IList<V1beta1AgentSpecInitProviderGitIntegrationSettings>? GitIntegrationSettings { get; set; }

    /// <summary>The name of the location this agent is located in. ~&gt; Note: The first time you are deploying an Agent in your project you must configure location settings. This is a one time step but at the moment you can only configure location settings via the Dialogflow CX console. Another options is to use global location so you don't need to manually configure location settings.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Settings related to speech recognition. Structure is documented below.</summary>
    [JsonPropertyName("speechToTextSettings")]
    public IList<V1beta1AgentSpecInitProviderSpeechToTextSettings>? SpeechToTextSettings { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the default_language_code).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>Settings related to speech synthesizing. Structure is documented below.</summary>
    [JsonPropertyName("textToSpeechSettings")]
    public IList<V1beta1AgentSpecInitProviderTextToSpeechSettings>? TextToSpeechSettings { get; set; }

    /// <summary>The time zone of this agent from the time zone database, e.g., America/New_York, Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public enum V1beta1AgentSpecManagementPoliciesEnum
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

public enum V1beta1AgentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AgentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1AgentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AgentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AgentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1AgentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1AgentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1AgentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1AgentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AgentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AgentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1AgentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1AgentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AgentSpecDeletionPolicyEnum>))]
    public V1beta1AgentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AgentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AgentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AgentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AgentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AgentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AgentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1AgentStatusAtProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation. Format: gs://bucket/object-name-or-prefix</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1AgentStatusAtProviderAdvancedSettingsDtmfSettings
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

public partial class V1beta1AgentStatusAtProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public IList<V1beta1AgentStatusAtProviderAdvancedSettingsAudioExportGcsDestination>? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public IList<V1beta1AgentStatusAtProviderAdvancedSettingsDtmfSettings>? DtmfSettings { get; set; }
}

public partial class V1beta1AgentStatusAtProviderGitIntegrationSettingsGithubSettings
{
    /// <summary>A list of branches configured to be used from Dialogflow.</summary>
    [JsonPropertyName("branches")]
    public IList<string>? Branches { get; set; }

    /// <summary>The unique repository display name for the GitHub repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The GitHub repository URI related to the agent.</summary>
    [JsonPropertyName("repositoryUri")]
    public string? RepositoryUri { get; set; }

    /// <summary>The branch of the GitHub repository tracked for this agent.</summary>
    [JsonPropertyName("trackingBranch")]
    public string? TrackingBranch { get; set; }
}

public partial class V1beta1AgentStatusAtProviderGitIntegrationSettings
{
    /// <summary>Settings of integration with GitHub. Structure is documented below.</summary>
    [JsonPropertyName("githubSettings")]
    public IList<V1beta1AgentStatusAtProviderGitIntegrationSettingsGithubSettings>? GithubSettings { get; set; }
}

public partial class V1beta1AgentStatusAtProviderSpeechToTextSettings
{
    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("enableSpeechAdaptation")]
    public bool? EnableSpeechAdaptation { get; set; }
}

public partial class V1beta1AgentStatusAtProviderTextToSpeechSettings
{
    /// <summary>Configuration of how speech should be synthesized, mapping from language to SynthesizeSpeechConfig. These settings affect:</summary>
    [JsonPropertyName("synthesizeSpeechConfigs")]
    public string? SynthesizeSpeechConfigs { get; set; }
}

public partial class V1beta1AgentStatusAtProvider
{
    /// <summary>Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level. Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter. Structure is documented below.</summary>
    [JsonPropertyName("advancedSettings")]
    public IList<V1beta1AgentStatusAtProviderAdvancedSettings>? AdvancedSettings { get; set; }

    /// <summary>The URI of the agent's avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.</summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>The default language of the agent as a language tag. See Language Support for a list of the currently supported language codes. This field cannot be updated after creation.</summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the agent, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>Git integration settings for this agent. Structure is documented below.</summary>
    [JsonPropertyName("gitIntegrationSettings")]
    public IList<V1beta1AgentStatusAtProviderGitIntegrationSettings>? GitIntegrationSettings { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/agents/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the location this agent is located in. ~&gt; Note: The first time you are deploying an Agent in your project you must configure location settings. This is a one time step but at the moment you can only configure location settings via the Dialogflow CX console. Another options is to use global location so you don't need to manually configure location settings.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The unique identifier of the agent.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>Settings related to speech recognition. Structure is documented below.</summary>
    [JsonPropertyName("speechToTextSettings")]
    public IList<V1beta1AgentStatusAtProviderSpeechToTextSettings>? SpeechToTextSettings { get; set; }

    /// <summary>Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("startFlow")]
    public string? StartFlow { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the default_language_code).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>Settings related to speech synthesizing. Structure is documented below.</summary>
    [JsonPropertyName("textToSpeechSettings")]
    public IList<V1beta1AgentStatusAtProviderTextToSpeechSettings>? TextToSpeechSettings { get; set; }

    /// <summary>The time zone of this agent from the time zone database, e.g., America/New_York, Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1AgentStatusConditions
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

public partial class V1beta1AgentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AgentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AgentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Agent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AgentSpec>, IStatus<V1beta1AgentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Agent";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "agents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AgentSpec defines the desired state of Agent</summary>
    [JsonPropertyName("spec")]
    public V1beta1AgentSpec Spec { get; set; }

    /// <summary>AgentStatus defines the observed state of Agent.</summary>
    [JsonPropertyName("status")]
    public V1beta1AgentStatus? Status { get; set; }
}