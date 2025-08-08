using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lexmodels.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecForProviderConversationLogsLogSettings
{
    /// <summary>The destination where logs are delivered. Options are CLOUDWATCH_LOGS or S3.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the key used to encrypt audio logs in an S3 bucket. This can only be specified when destination is set to S3. Must be between 20 and 2048 characters in length.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The type of logging that is enabled. Options are AUDIO or TEXT.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch Logs log group or S3 bucket where the logs are delivered. Must be less than or equal to 2048 characters in length.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>The settings that determine how Amazon Lex uses conversation logs for the alias. Attributes are documented under conversation_logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecForProviderConversationLogs
{
    /// <summary>The Amazon Resource Name (ARN) of the IAM role used to write your logs to CloudWatch Logs or an S3 bucket. Must be between 20 and 2048 characters in length.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>The settings for your conversation logs. You can log text, audio, or both. Attributes are documented under log_settings.</summary>
    [JsonPropertyName("logSettings")]
    public IList<V1beta1BotAliasSpecForProviderConversationLogsLogSettings>? LogSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecForProvider
{
    /// <summary>The name of the bot.</summary>
    [JsonPropertyName("botName")]
    public string? BotName { get; set; }

    /// <summary>The version of the bot.</summary>
    [JsonPropertyName("botVersion")]
    public string? BotVersion { get; set; }

    /// <summary>The settings that determine how Amazon Lex uses conversation logs for the alias. Attributes are documented under conversation_logs.</summary>
    [JsonPropertyName("conversationLogs")]
    public V1beta1BotAliasSpecForProviderConversationLogs? ConversationLogs { get; set; }

    /// <summary>A description of the alias. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecInitProviderConversationLogsLogSettings
{
    /// <summary>The destination where logs are delivered. Options are CLOUDWATCH_LOGS or S3.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the key used to encrypt audio logs in an S3 bucket. This can only be specified when destination is set to S3. Must be between 20 and 2048 characters in length.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The type of logging that is enabled. Options are AUDIO or TEXT.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch Logs log group or S3 bucket where the logs are delivered. Must be less than or equal to 2048 characters in length.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>The settings that determine how Amazon Lex uses conversation logs for the alias. Attributes are documented under conversation_logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecInitProviderConversationLogs
{
    /// <summary>The Amazon Resource Name (ARN) of the IAM role used to write your logs to CloudWatch Logs or an S3 bucket. Must be between 20 and 2048 characters in length.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>The settings for your conversation logs. You can log text, audio, or both. Attributes are documented under log_settings.</summary>
    [JsonPropertyName("logSettings")]
    public IList<V1beta1BotAliasSpecInitProviderConversationLogsLogSettings>? LogSettings { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecInitProvider
{
    /// <summary>The name of the bot.</summary>
    [JsonPropertyName("botName")]
    public string? BotName { get; set; }

    /// <summary>The version of the bot.</summary>
    [JsonPropertyName("botVersion")]
    public string? BotVersion { get; set; }

    /// <summary>The settings that determine how Amazon Lex uses conversation logs for the alias. Attributes are documented under conversation_logs.</summary>
    [JsonPropertyName("conversationLogs")]
    public V1beta1BotAliasSpecInitProviderConversationLogs? ConversationLogs { get; set; }

    /// <summary>A description of the alias. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BotAliasSpec defines the desired state of BotAlias</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BotAliasSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BotAliasSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BotAliasSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BotAliasSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasStatusAtProviderConversationLogsLogSettings
{
    /// <summary>The destination where logs are delivered. Options are CLOUDWATCH_LOGS or S3.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the key used to encrypt audio logs in an S3 bucket. This can only be specified when destination is set to S3. Must be between 20 and 2048 characters in length.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>The type of logging that is enabled. Options are AUDIO or TEXT.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the CloudWatch Logs log group or S3 bucket where the logs are delivered. Must be less than or equal to 2048 characters in length.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>(Computed) The prefix of the S3 object key for AUDIO logs or the log stream name for TEXT logs.</summary>
    [JsonPropertyName("resourcePrefix")]
    public string? ResourcePrefix { get; set; }
}

/// <summary>The settings that determine how Amazon Lex uses conversation logs for the alias. Attributes are documented under conversation_logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasStatusAtProviderConversationLogs
{
    /// <summary>The Amazon Resource Name (ARN) of the IAM role used to write your logs to CloudWatch Logs or an S3 bucket. Must be between 20 and 2048 characters in length.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>The settings for your conversation logs. You can log text, audio, or both. Attributes are documented under log_settings.</summary>
    [JsonPropertyName("logSettings")]
    public IList<V1beta1BotAliasStatusAtProviderConversationLogsLogSettings>? LogSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasStatusAtProvider
{
    /// <summary>The ARN of the bot alias.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The name of the bot.</summary>
    [JsonPropertyName("botName")]
    public string? BotName { get; set; }

    /// <summary>The version of the bot.</summary>
    [JsonPropertyName("botVersion")]
    public string? BotVersion { get; set; }

    /// <summary>Checksum of the bot alias.</summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>The settings that determine how Amazon Lex uses conversation logs for the alias. Attributes are documented under conversation_logs.</summary>
    [JsonPropertyName("conversationLogs")]
    public V1beta1BotAliasStatusAtProviderConversationLogs? ConversationLogs { get; set; }

    /// <summary>The date that the bot alias was created.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>A description of the alias. Must be less than or equal to 200 characters in length.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date that the bot alias was updated. When you create a resource, the creation date and the last updated date are the same.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasStatusConditions
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

/// <summary>BotAliasStatus defines the observed state of BotAlias.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BotAliasStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BotAliasStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BotAliasStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BotAlias is the Schema for the BotAliass API. Provides an Amazon Lex Bot Alias resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BotAlias : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BotAliasSpec>, IStatus<V1beta1BotAliasStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BotAlias";
    public const string KubeGroup = "lexmodels.aws.m.upbound.io";
    public const string KubePluralName = "botaliases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BotAliasSpec defines the desired state of BotAlias</summary>
    [JsonPropertyName("spec")]
    public V1beta1BotAliasSpec Spec { get; set; }

    /// <summary>BotAliasStatus defines the observed state of BotAlias.</summary>
    [JsonPropertyName("status")]
    public V1beta1BotAliasStatus? Status { get; set; }
}

/// <summary>BotAlias is the Schema for the BotAliass API. Provides an Amazon Lex Bot Alias resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BotAliasList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BotAlias>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BotAliasList";
    public const string KubeGroup = "lexmodels.aws.m.upbound.io";
    public const string KubePluralName = "botaliases";
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
    public IList<V1beta1BotAlias> Items { get; set; }
}