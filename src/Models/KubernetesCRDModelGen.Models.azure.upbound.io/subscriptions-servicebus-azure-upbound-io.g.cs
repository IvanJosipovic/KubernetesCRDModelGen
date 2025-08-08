using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderClientScopedSubscription
{
    /// <summary>Specifies the Client ID of the application that created the client-scoped subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Whether the client scoped subscription is shareable. Defaults to true Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isClientScopedSubscriptionShareable")]
    public bool? IsClientScopedSubscriptionShareable { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in servicebus to populate topicId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderTopicIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in servicebus to populate topicId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderTopicIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProvider
{
    /// <summary>The idle interval after which the topic is automatically deleted as an ISO 8601 duration. The minimum duration is 5 minutes or PT5M. Defaults to P10675199DT2H48M5.4775807S.</summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription supports batched operations.</summary>
    [JsonPropertyName("batchedOperationsEnabled")]
    public bool? BatchedOperationsEnabled { get; set; }

    /// <summary>A client_scoped_subscription block as defined below.</summary>
    [JsonPropertyName("clientScopedSubscription")]
    public IList<V1beta1SubscriptionSpecForProviderClientScopedSubscription>? ClientScopedSubscription { get; set; }

    /// <summary>whether the subscription is scoped to a client id. Defaults to false.</summary>
    [JsonPropertyName("clientScopedSubscriptionEnabled")]
    public bool? ClientScopedSubscriptionEnabled { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription has dead letter support on filter evaluation exceptions. Defaults to true.</summary>
    [JsonPropertyName("deadLetteringOnFilterEvaluationError")]
    public bool? DeadLetteringOnFilterEvaluationError { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription has dead letter support when a message expires.</summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>The Default message timespan to live as an ISO 8601 duration. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the value used when TimeToLive is not set on a message itself. Defaults to P10675199DT2H48M5.4775807S.</summary>
    [JsonPropertyName("defaultMessageTtl")]
    public string? DefaultMessageTtl { get; set; }

    /// <summary>The name of a Queue or Topic to automatically forward Dead Letter messages to.</summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>The name of a Queue or Topic to automatically forward messages to.</summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary>The lock duration for the subscription as an ISO 8601 duration. The default value is 1 minute or P0DT0H1M0S . The maximum value is 5 minutes or P0DT0H5M0S . Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The maximum number of deliveries.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>Boolean flag which controls whether this Subscription supports the concept of a session. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }

    /// <summary>The status of the Subscription. Possible values are Active,ReceiveDisabled, or Disabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID of the ServiceBus Topic to create this Subscription in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topicId")]
    public string? TopicId { get; set; }

    /// <summary>Reference to a Topic in servicebus to populate topicId.</summary>
    [JsonPropertyName("topicIdRef")]
    public V1beta1SubscriptionSpecForProviderTopicIdRef? TopicIdRef { get; set; }

    /// <summary>Selector for a Topic in servicebus to populate topicId.</summary>
    [JsonPropertyName("topicIdSelector")]
    public V1beta1SubscriptionSpecForProviderTopicIdSelector? TopicIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderClientScopedSubscription
{
    /// <summary>Specifies the Client ID of the application that created the client-scoped subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Whether the client scoped subscription is shareable. Defaults to true Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isClientScopedSubscriptionShareable")]
    public bool? IsClientScopedSubscriptionShareable { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProvider
{
    /// <summary>The idle interval after which the topic is automatically deleted as an ISO 8601 duration. The minimum duration is 5 minutes or PT5M. Defaults to P10675199DT2H48M5.4775807S.</summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription supports batched operations.</summary>
    [JsonPropertyName("batchedOperationsEnabled")]
    public bool? BatchedOperationsEnabled { get; set; }

    /// <summary>A client_scoped_subscription block as defined below.</summary>
    [JsonPropertyName("clientScopedSubscription")]
    public IList<V1beta1SubscriptionSpecInitProviderClientScopedSubscription>? ClientScopedSubscription { get; set; }

    /// <summary>whether the subscription is scoped to a client id. Defaults to false.</summary>
    [JsonPropertyName("clientScopedSubscriptionEnabled")]
    public bool? ClientScopedSubscriptionEnabled { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription has dead letter support on filter evaluation exceptions. Defaults to true.</summary>
    [JsonPropertyName("deadLetteringOnFilterEvaluationError")]
    public bool? DeadLetteringOnFilterEvaluationError { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription has dead letter support when a message expires.</summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>The Default message timespan to live as an ISO 8601 duration. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the value used when TimeToLive is not set on a message itself. Defaults to P10675199DT2H48M5.4775807S.</summary>
    [JsonPropertyName("defaultMessageTtl")]
    public string? DefaultMessageTtl { get; set; }

    /// <summary>The name of a Queue or Topic to automatically forward Dead Letter messages to.</summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>The name of a Queue or Topic to automatically forward messages to.</summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary>The lock duration for the subscription as an ISO 8601 duration. The default value is 1 minute or P0DT0H1M0S . The maximum value is 5 minutes or P0DT0H5M0S . Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The maximum number of deliveries.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>Boolean flag which controls whether this Subscription supports the concept of a session. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }

    /// <summary>The status of the Subscription. Possible values are Active,ReceiveDisabled, or Disabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecProviderConfigRefPolicy
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
public partial class V1beta1SubscriptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubscriptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubscriptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderClientScopedSubscription
{
    /// <summary>Specifies the Client ID of the application that created the client-scoped subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Whether the client scoped subscription is durable. This property can only be controlled from the application side.</summary>
    [JsonPropertyName("isClientScopedSubscriptionDurable")]
    public bool? IsClientScopedSubscriptionDurable { get; set; }

    /// <summary>Whether the client scoped subscription is shareable. Defaults to true Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isClientScopedSubscriptionShareable")]
    public bool? IsClientScopedSubscriptionShareable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProvider
{
    /// <summary>The idle interval after which the topic is automatically deleted as an ISO 8601 duration. The minimum duration is 5 minutes or PT5M. Defaults to P10675199DT2H48M5.4775807S.</summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription supports batched operations.</summary>
    [JsonPropertyName("batchedOperationsEnabled")]
    public bool? BatchedOperationsEnabled { get; set; }

    /// <summary>A client_scoped_subscription block as defined below.</summary>
    [JsonPropertyName("clientScopedSubscription")]
    public IList<V1beta1SubscriptionStatusAtProviderClientScopedSubscription>? ClientScopedSubscription { get; set; }

    /// <summary>whether the subscription is scoped to a client id. Defaults to false.</summary>
    [JsonPropertyName("clientScopedSubscriptionEnabled")]
    public bool? ClientScopedSubscriptionEnabled { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription has dead letter support on filter evaluation exceptions. Defaults to true.</summary>
    [JsonPropertyName("deadLetteringOnFilterEvaluationError")]
    public bool? DeadLetteringOnFilterEvaluationError { get; set; }

    /// <summary>Boolean flag which controls whether the Subscription has dead letter support when a message expires.</summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>The Default message timespan to live as an ISO 8601 duration. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the value used when TimeToLive is not set on a message itself. Defaults to P10675199DT2H48M5.4775807S.</summary>
    [JsonPropertyName("defaultMessageTtl")]
    public string? DefaultMessageTtl { get; set; }

    /// <summary>The name of a Queue or Topic to automatically forward Dead Letter messages to.</summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>The name of a Queue or Topic to automatically forward messages to.</summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary>The ServiceBus Subscription ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The lock duration for the subscription as an ISO 8601 duration. The default value is 1 minute or P0DT0H1M0S . The maximum value is 5 minutes or P0DT0H5M0S . Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The maximum number of deliveries.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>Boolean flag which controls whether this Subscription supports the concept of a session. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }

    /// <summary>The status of the Subscription. Possible values are Active,ReceiveDisabled, or Disabled. Defaults to Active.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID of the ServiceBus Topic to create this Subscription in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topicId")]
    public string? TopicId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusConditions
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

/// <summary>SubscriptionStatus defines the observed state of Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Subscription is the Schema for the Subscriptions API. Manages a ServiceBus Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Subscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubscriptionSpec>, IStatus<V1beta1SubscriptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Subscription";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "subscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubscriptionSpec Spec { get; set; }

    /// <summary>SubscriptionStatus defines the observed state of Subscription.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubscriptionStatus? Status { get; set; }
}

/// <summary>Subscription is the Schema for the Subscriptions API. Manages a ServiceBus Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Subscription>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubscriptionList";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "subscriptions";
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
    public IList<V1beta1Subscription> Items { get; set; }
}