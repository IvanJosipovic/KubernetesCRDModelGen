using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sns.aws.upbound.io;
public enum V1beta1PlatformApplicationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate failureFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate failureFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Application Platform credential. See Credential for type of credential required for platform.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderPlatformCredentialSecretRef
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

/// <summary>Application Platform principal. See Principal for type of principal required for platform.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderPlatformPrincipalSecretRef
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

public enum V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate successFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate successFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PlatformApplicationSpecForProvider
{
    /// <summary>The bundle identifier that's assigned to your iOS app. May only include alphanumeric characters, hyphens (-), and periods (.).</summary>
    [JsonPropertyName("applePlatformBundleId")]
    public string? ApplePlatformBundleId { get; set; }

    /// <summary>The identifier that's assigned to your Apple developer account team. Must be 10 alphanumeric characters.</summary>
    [JsonPropertyName("applePlatformTeamId")]
    public string? ApplePlatformTeamId { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.</summary>
    [JsonPropertyName("eventDeliveryFailureTopicArn")]
    public string? EventDeliveryFailureTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when a new platform endpoint is added to your platform application.</summary>
    [JsonPropertyName("eventEndpointCreatedTopicArn")]
    public string? EventEndpointCreatedTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when an existing platform endpoint is deleted from your platform application.</summary>
    [JsonPropertyName("eventEndpointDeletedTopicArn")]
    public string? EventEndpointDeletedTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when an existing platform endpoint is changed from your platform application.</summary>
    [JsonPropertyName("eventEndpointUpdatedTopicArn")]
    public string? EventEndpointUpdatedTopicArn { get; set; }

    /// <summary>The IAM role ARN permitted to receive failure feedback for this application and give SNS write access to use CloudWatch logs on your behalf.</summary>
    [JsonPropertyName("failureFeedbackRoleArn")]
    public string? FailureFeedbackRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate failureFeedbackRoleArn.</summary>
    [JsonPropertyName("failureFeedbackRoleArnRef")]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRef? FailureFeedbackRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate failureFeedbackRoleArn.</summary>
    [JsonPropertyName("failureFeedbackRoleArnSelector")]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelector? FailureFeedbackRoleArnSelector { get; set; }

    /// <summary>The platform that the app is registered with. See Platform for supported platforms.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Application Platform credential. See Credential for type of credential required for platform.</summary>
    [JsonPropertyName("platformCredentialSecretRef")]
    public V1beta1PlatformApplicationSpecForProviderPlatformCredentialSecretRef? PlatformCredentialSecretRef { get; set; }

    /// <summary>Application Platform principal. See Principal for type of principal required for platform.</summary>
    [JsonPropertyName("platformPrincipalSecretRef")]
    public V1beta1PlatformApplicationSpecForProviderPlatformPrincipalSecretRef? PlatformPrincipalSecretRef { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The IAM role ARN permitted to receive success feedback for this application and give SNS write access to use CloudWatch logs on your behalf.</summary>
    [JsonPropertyName("successFeedbackRoleArn")]
    public string? SuccessFeedbackRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate successFeedbackRoleArn.</summary>
    [JsonPropertyName("successFeedbackRoleArnRef")]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRef? SuccessFeedbackRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate successFeedbackRoleArn.</summary>
    [JsonPropertyName("successFeedbackRoleArnSelector")]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelector? SuccessFeedbackRoleArnSelector { get; set; }

    /// <summary>The sample rate percentage (0-100) of successfully delivered messages.</summary>
    [JsonPropertyName("successFeedbackSampleRate")]
    public string? SuccessFeedbackSampleRate { get; set; }
}

public enum V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate failureFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate failureFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Application Platform credential. See Credential for type of credential required for platform.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderPlatformCredentialSecretRef
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

/// <summary>Application Platform principal. See Principal for type of principal required for platform.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderPlatformPrincipalSecretRef
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

public enum V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate successFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate successFeedbackRoleArn.</summary>
public partial class V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1PlatformApplicationSpecInitProvider
{
    /// <summary>The bundle identifier that's assigned to your iOS app. May only include alphanumeric characters, hyphens (-), and periods (.).</summary>
    [JsonPropertyName("applePlatformBundleId")]
    public string? ApplePlatformBundleId { get; set; }

    /// <summary>The identifier that's assigned to your Apple developer account team. Must be 10 alphanumeric characters.</summary>
    [JsonPropertyName("applePlatformTeamId")]
    public string? ApplePlatformTeamId { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.</summary>
    [JsonPropertyName("eventDeliveryFailureTopicArn")]
    public string? EventDeliveryFailureTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when a new platform endpoint is added to your platform application.</summary>
    [JsonPropertyName("eventEndpointCreatedTopicArn")]
    public string? EventEndpointCreatedTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when an existing platform endpoint is deleted from your platform application.</summary>
    [JsonPropertyName("eventEndpointDeletedTopicArn")]
    public string? EventEndpointDeletedTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when an existing platform endpoint is changed from your platform application.</summary>
    [JsonPropertyName("eventEndpointUpdatedTopicArn")]
    public string? EventEndpointUpdatedTopicArn { get; set; }

    /// <summary>The IAM role ARN permitted to receive failure feedback for this application and give SNS write access to use CloudWatch logs on your behalf.</summary>
    [JsonPropertyName("failureFeedbackRoleArn")]
    public string? FailureFeedbackRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate failureFeedbackRoleArn.</summary>
    [JsonPropertyName("failureFeedbackRoleArnRef")]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRef? FailureFeedbackRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate failureFeedbackRoleArn.</summary>
    [JsonPropertyName("failureFeedbackRoleArnSelector")]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelector? FailureFeedbackRoleArnSelector { get; set; }

    /// <summary>The platform that the app is registered with. See Platform for supported platforms.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Application Platform credential. See Credential for type of credential required for platform.</summary>
    [JsonPropertyName("platformCredentialSecretRef")]
    public V1beta1PlatformApplicationSpecInitProviderPlatformCredentialSecretRef PlatformCredentialSecretRef { get; set; }

    /// <summary>Application Platform principal. See Principal for type of principal required for platform.</summary>
    [JsonPropertyName("platformPrincipalSecretRef")]
    public V1beta1PlatformApplicationSpecInitProviderPlatformPrincipalSecretRef? PlatformPrincipalSecretRef { get; set; }

    /// <summary>The IAM role ARN permitted to receive success feedback for this application and give SNS write access to use CloudWatch logs on your behalf.</summary>
    [JsonPropertyName("successFeedbackRoleArn")]
    public string? SuccessFeedbackRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate successFeedbackRoleArn.</summary>
    [JsonPropertyName("successFeedbackRoleArnRef")]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRef? SuccessFeedbackRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate successFeedbackRoleArn.</summary>
    [JsonPropertyName("successFeedbackRoleArnSelector")]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelector? SuccessFeedbackRoleArnSelector { get; set; }

    /// <summary>The sample rate percentage (0-100) of successfully delivered messages.</summary>
    [JsonPropertyName("successFeedbackSampleRate")]
    public string? SuccessFeedbackSampleRate { get; set; }
}

public enum V1beta1PlatformApplicationSpecManagementPoliciesEnum
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

public enum V1beta1PlatformApplicationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PlatformApplicationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1PlatformApplicationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1PlatformApplicationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PlatformApplicationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PlatformApplicationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PlatformApplicationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1PlatformApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PlatformApplicationSpec defines the desired state of PlatformApplication</summary>
public partial class V1beta1PlatformApplicationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlatformApplicationSpecDeletionPolicyEnum>))]
    public V1beta1PlatformApplicationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PlatformApplicationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PlatformApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PlatformApplicationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PlatformApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PlatformApplicationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PlatformApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1PlatformApplicationStatusAtProvider
{
    /// <summary>The bundle identifier that's assigned to your iOS app. May only include alphanumeric characters, hyphens (-), and periods (.).</summary>
    [JsonPropertyName("applePlatformBundleId")]
    public string? ApplePlatformBundleId { get; set; }

    /// <summary>The identifier that's assigned to your Apple developer account team. Must be 10 alphanumeric characters.</summary>
    [JsonPropertyName("applePlatformTeamId")]
    public string? ApplePlatformTeamId { get; set; }

    /// <summary>The ARN of the SNS platform application</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.</summary>
    [JsonPropertyName("eventDeliveryFailureTopicArn")]
    public string? EventDeliveryFailureTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when a new platform endpoint is added to your platform application.</summary>
    [JsonPropertyName("eventEndpointCreatedTopicArn")]
    public string? EventEndpointCreatedTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when an existing platform endpoint is deleted from your platform application.</summary>
    [JsonPropertyName("eventEndpointDeletedTopicArn")]
    public string? EventEndpointDeletedTopicArn { get; set; }

    /// <summary>The ARN of the SNS Topic triggered when an existing platform endpoint is changed from your platform application.</summary>
    [JsonPropertyName("eventEndpointUpdatedTopicArn")]
    public string? EventEndpointUpdatedTopicArn { get; set; }

    /// <summary>The IAM role ARN permitted to receive failure feedback for this application and give SNS write access to use CloudWatch logs on your behalf.</summary>
    [JsonPropertyName("failureFeedbackRoleArn")]
    public string? FailureFeedbackRoleArn { get; set; }

    /// <summary>The ARN of the SNS platform application</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The platform that the app is registered with. See Platform for supported platforms.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>The IAM role ARN permitted to receive success feedback for this application and give SNS write access to use CloudWatch logs on your behalf.</summary>
    [JsonPropertyName("successFeedbackRoleArn")]
    public string? SuccessFeedbackRoleArn { get; set; }

    /// <summary>The sample rate percentage (0-100) of successfully delivered messages.</summary>
    [JsonPropertyName("successFeedbackSampleRate")]
    public string? SuccessFeedbackSampleRate { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1PlatformApplicationStatusConditions
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

/// <summary>PlatformApplicationStatus defines the observed state of PlatformApplication.</summary>
public partial class V1beta1PlatformApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PlatformApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PlatformApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>PlatformApplication is the Schema for the PlatformApplications API. Provides an SNS platform application resource.</summary>
public partial class V1beta1PlatformApplication : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PlatformApplicationSpec>, IStatus<V1beta1PlatformApplicationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PlatformApplication";
    public const string KubeGroup = "sns.aws.upbound.io";
    public const string KubePluralName = "platformapplications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PlatformApplicationSpec defines the desired state of PlatformApplication</summary>
    [JsonPropertyName("spec")]
    public V1beta1PlatformApplicationSpec Spec { get; set; }

    /// <summary>PlatformApplicationStatus defines the observed state of PlatformApplication.</summary>
    [JsonPropertyName("status")]
    public V1beta1PlatformApplicationStatus? Status { get; set; }
}