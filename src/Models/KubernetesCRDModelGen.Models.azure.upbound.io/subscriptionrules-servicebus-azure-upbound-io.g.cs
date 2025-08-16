using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.upbound.io;
/// <summary>SubscriptionRule is the Schema for the SubscriptionRules API. Manages a ServiceBus Subscription Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubscriptionRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SubscriptionRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubscriptionRuleList";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "subscriptionrules";
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
    public IList<V1beta1SubscriptionRule> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecForProviderCorrelationFilter
{
    /// <summary>Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>A list of user defined properties to be included in the filter. Specified as a map of name/value pairs.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecForProviderSubscriptionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subscription in servicebus to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecForProviderSubscriptionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionRuleSpecForProviderSubscriptionIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subscription in servicebus to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecForProviderSubscriptionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecForProvider
{
    /// <summary>Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
    [JsonPropertyName("correlationFilter")]
    public IList<V1beta1SubscriptionRuleSpecForProviderCorrelationFilter>? CorrelationFilter { get; set; }

    /// <summary>Type of filter to be applied to a BrokeredMessage. Possible values are SqlFilter and CorrelationFilter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when filter_type is set to SqlFilter.</summary>
    [JsonPropertyName("sqlFilter")]
    public string? SqlFilter { get; set; }

    /// <summary>The ID of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>Reference to a Subscription in servicebus to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdRef")]
    public V1beta1SubscriptionRuleSpecForProviderSubscriptionIdRef? SubscriptionIdRef { get; set; }

    /// <summary>Selector for a Subscription in servicebus to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdSelector")]
    public V1beta1SubscriptionRuleSpecForProviderSubscriptionIdSelector? SubscriptionIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecInitProviderCorrelationFilter
{
    /// <summary>Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>A list of user defined properties to be included in the filter. Specified as a map of name/value pairs.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecInitProvider
{
    /// <summary>Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
    [JsonPropertyName("correlationFilter")]
    public IList<V1beta1SubscriptionRuleSpecInitProviderCorrelationFilter>? CorrelationFilter { get; set; }

    /// <summary>Type of filter to be applied to a BrokeredMessage. Possible values are SqlFilter and CorrelationFilter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when filter_type is set to SqlFilter.</summary>
    [JsonPropertyName("sqlFilter")]
    public string? SqlFilter { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecProviderConfigRefPolicy
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
public partial class V1beta1SubscriptionRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SubscriptionRuleSpec defines the desired state of SubscriptionRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubscriptionRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubscriptionRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubscriptionRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubscriptionRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleStatusAtProviderCorrelationFilter
{
    /// <summary>Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>A list of user defined properties to be included in the filter. Specified as a map of name/value pairs.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleStatusAtProvider
{
    /// <summary>Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
    [JsonPropertyName("correlationFilter")]
    public IList<V1beta1SubscriptionRuleStatusAtProviderCorrelationFilter>? CorrelationFilter { get; set; }

    /// <summary>Type of filter to be applied to a BrokeredMessage. Possible values are SqlFilter and CorrelationFilter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>The ServiceBus Subscription Rule ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when filter_type is set to SqlFilter.</summary>
    [JsonPropertyName("sqlFilter")]
    public string? SqlFilter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlFilterCompatibilityLevel")]
    public double? SqlFilterCompatibilityLevel { get; set; }

    /// <summary>The ID of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleStatusConditions
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

/// <summary>SubscriptionRuleStatus defines the observed state of SubscriptionRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubscriptionRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubscriptionRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SubscriptionRule is the Schema for the SubscriptionRules API. Manages a ServiceBus Subscription Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubscriptionRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubscriptionRuleSpec>, IStatus<V1beta1SubscriptionRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubscriptionRule";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "subscriptionrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionRuleSpec defines the desired state of SubscriptionRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubscriptionRuleSpec Spec { get; set; }

    /// <summary>SubscriptionRuleStatus defines the observed state of SubscriptionRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubscriptionRuleStatus? Status { get; set; }
}