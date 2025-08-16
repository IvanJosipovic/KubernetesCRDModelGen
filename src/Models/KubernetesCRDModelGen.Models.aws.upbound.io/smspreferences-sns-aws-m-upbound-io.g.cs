using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sns.aws.m.upbound.io;
/// <summary>SMSPreferences is the Schema for the SMSPreferencess API. Provides a way to set SNS SMS preferences.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SMSPreferencesList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SMSPreferences>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SMSPreferencesList";
    public const string KubeGroup = "sns.aws.m.upbound.io";
    public const string KubePluralName = "smspreferences";
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
    public IList<V1beta1SMSPreferences> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate deliveryStatusIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate deliveryStatusIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecForProvider
{
    /// <summary>A string, such as your business brand, that is displayed as the sender on the receiving device.</summary>
    [JsonPropertyName("defaultSenderId")]
    public string? DefaultSenderId { get; set; }

    /// <summary>The type of SMS message that you will send by default. Possible values are: Promotional, Transactional</summary>
    [JsonPropertyName("defaultSmsType")]
    public string? DefaultSmsType { get; set; }

    /// <summary>The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.</summary>
    [JsonPropertyName("deliveryStatusIamRoleArn")]
    public string? DeliveryStatusIamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate deliveryStatusIamRoleArn.</summary>
    [JsonPropertyName("deliveryStatusIamRoleArnRef")]
    public V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnRef? DeliveryStatusIamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate deliveryStatusIamRoleArn.</summary>
    [JsonPropertyName("deliveryStatusIamRoleArnSelector")]
    public V1beta1SMSPreferencesSpecForProviderDeliveryStatusIamRoleArnSelector? DeliveryStatusIamRoleArnSelector { get; set; }

    /// <summary>The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.</summary>
    [JsonPropertyName("deliveryStatusSuccessSamplingRate")]
    public string? DeliveryStatusSuccessSamplingRate { get; set; }

    /// <summary>The maximum amount in USD that you are willing to spend each month to send SMS messages.</summary>
    [JsonPropertyName("monthlySpendLimit")]
    public double? MonthlySpendLimit { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.</summary>
    [JsonPropertyName("usageReportS3Bucket")]
    public string? UsageReportS3Bucket { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate deliveryStatusIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate deliveryStatusIamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecInitProvider
{
    /// <summary>A string, such as your business brand, that is displayed as the sender on the receiving device.</summary>
    [JsonPropertyName("defaultSenderId")]
    public string? DefaultSenderId { get; set; }

    /// <summary>The type of SMS message that you will send by default. Possible values are: Promotional, Transactional</summary>
    [JsonPropertyName("defaultSmsType")]
    public string? DefaultSmsType { get; set; }

    /// <summary>The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.</summary>
    [JsonPropertyName("deliveryStatusIamRoleArn")]
    public string? DeliveryStatusIamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate deliveryStatusIamRoleArn.</summary>
    [JsonPropertyName("deliveryStatusIamRoleArnRef")]
    public V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnRef? DeliveryStatusIamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate deliveryStatusIamRoleArn.</summary>
    [JsonPropertyName("deliveryStatusIamRoleArnSelector")]
    public V1beta1SMSPreferencesSpecInitProviderDeliveryStatusIamRoleArnSelector? DeliveryStatusIamRoleArnSelector { get; set; }

    /// <summary>The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.</summary>
    [JsonPropertyName("deliveryStatusSuccessSamplingRate")]
    public string? DeliveryStatusSuccessSamplingRate { get; set; }

    /// <summary>The maximum amount in USD that you are willing to spend each month to send SMS messages.</summary>
    [JsonPropertyName("monthlySpendLimit")]
    public double? MonthlySpendLimit { get; set; }

    /// <summary>The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.</summary>
    [JsonPropertyName("usageReportS3Bucket")]
    public string? UsageReportS3Bucket { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpecProviderConfigRef
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
public partial class V1beta1SMSPreferencesSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SMSPreferencesSpec defines the desired state of SMSPreferences</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SMSPreferencesSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SMSPreferencesSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SMSPreferencesSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SMSPreferencesSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesStatusAtProvider
{
    /// <summary>A string, such as your business brand, that is displayed as the sender on the receiving device.</summary>
    [JsonPropertyName("defaultSenderId")]
    public string? DefaultSenderId { get; set; }

    /// <summary>The type of SMS message that you will send by default. Possible values are: Promotional, Transactional</summary>
    [JsonPropertyName("defaultSmsType")]
    public string? DefaultSmsType { get; set; }

    /// <summary>The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.</summary>
    [JsonPropertyName("deliveryStatusIamRoleArn")]
    public string? DeliveryStatusIamRoleArn { get; set; }

    /// <summary>The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.</summary>
    [JsonPropertyName("deliveryStatusSuccessSamplingRate")]
    public string? DeliveryStatusSuccessSamplingRate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum amount in USD that you are willing to spend each month to send SMS messages.</summary>
    [JsonPropertyName("monthlySpendLimit")]
    public double? MonthlySpendLimit { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.</summary>
    [JsonPropertyName("usageReportS3Bucket")]
    public string? UsageReportS3Bucket { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesStatusConditions
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

/// <summary>SMSPreferencesStatus defines the observed state of SMSPreferences.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SMSPreferencesStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SMSPreferencesStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SMSPreferencesStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SMSPreferences is the Schema for the SMSPreferencess API. Provides a way to set SNS SMS preferences.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SMSPreferences : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SMSPreferencesSpec>, IStatus<V1beta1SMSPreferencesStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SMSPreferences";
    public const string KubeGroup = "sns.aws.m.upbound.io";
    public const string KubePluralName = "smspreferences";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SMSPreferencesSpec defines the desired state of SMSPreferences</summary>
    [JsonPropertyName("spec")]
    public V1beta1SMSPreferencesSpec Spec { get; set; }

    /// <summary>SMSPreferencesStatus defines the observed state of SMSPreferences.</summary>
    [JsonPropertyName("status")]
    public V1beta1SMSPreferencesStatus? Status { get; set; }
}