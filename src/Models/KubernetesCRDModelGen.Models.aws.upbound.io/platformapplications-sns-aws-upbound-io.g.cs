using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sns.aws.upbound.io;
#nullable enable
/// <summary>PlatformApplication is the Schema for the PlatformApplications API. Provides an SNS platform application resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PlatformApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PlatformApplication>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PlatformApplicationList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1PlatformApplication> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Role in iam to populate failureFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecForProviderFailureFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Role in iam to populate failureFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>Application Platform credential. See Credential for type of credential required for platform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>Application Platform principal. See Principal for type of principal required for platform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Role in iam to populate successFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecForProviderSuccessFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Role in iam to populate successFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Role in iam to populate failureFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecInitProviderFailureFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Role in iam to populate failureFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>Application Platform credential. See Credential for type of credential required for platform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>Application Platform principal. See Principal for type of principal required for platform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Role in iam to populate successFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecInitProviderSuccessFeedbackRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Role in iam to populate successFeedbackRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlatformApplicationSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PlatformApplicationSpec defines the desired state of PlatformApplication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlatformApplicationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PlatformApplicationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PlatformApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PlatformApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PlatformApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The IAM role ARN permitted to receive success feedback for this application and give SNS write access to use CloudWatch logs on your behalf.</summary>
    [JsonPropertyName("successFeedbackRoleArn")]
    public string? SuccessFeedbackRoleArn { get; set; }

    /// <summary>The sample rate percentage (0-100) of successfully delivered messages.</summary>
    [JsonPropertyName("successFeedbackSampleRate")]
    public string? SuccessFeedbackSampleRate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>PlatformApplicationStatus defines the observed state of PlatformApplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
#nullable disable

#nullable enable
/// <summary>PlatformApplication is the Schema for the PlatformApplications API. Provides an SNS platform application resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
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
#nullable disable
