using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.com;
/// <summary>Storage version of v1api20240101.Action Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecAction
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>Storage version of v1api20240101.CorrelationFilter Represents the correlation filter expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecCorrelationFilter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary></summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20240101.NamespacesTopicsSubscriptionsRuleOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a servicebus.azure.com/NamespacesTopicsSubscription resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240101.SqlFilter Represents a filter which is a composition of an expression and an action that is executed in the pub/sub pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecSqlFilter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>Storage version of v1api20240101.NamespacesTopicsSubscriptionsRule_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240101.Action Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression.</summary>
    [JsonPropertyName("action")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecAction? Action { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240101.CorrelationFilter Represents the correlation filter expression.</summary>
    [JsonPropertyName("correlationFilter")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecCorrelationFilter? CorrelationFilter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>Storage version of v1api20240101.NamespacesTopicsSubscriptionsRuleOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a servicebus.azure.com/NamespacesTopicsSubscription resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240101.SqlFilter Represents a filter which is a composition of an expression and an action that is executed in the pub/sub pipeline.</summary>
    [JsonPropertyName("sqlFilter")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleSpecSqlFilter? SqlFilter { get; set; }
}

/// <summary>Storage version of v1api20240101.Action_STATUS Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusAction
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20240101.CorrelationFilter_STATUS Represents the correlation filter expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusCorrelationFilter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary></summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary>Storage version of v1api20240101.SqlFilter_STATUS Represents a filter which is a composition of an expression and an action that is executed in the pub/sub pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusSqlFilter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compatibilityLevel")]
    public int? CompatibilityLevel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresPreprocessing")]
    public bool? RequiresPreprocessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlExpression")]
    public string? SqlExpression { get; set; }
}

/// <summary>Storage version of v1api20240101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20240101.NamespacesTopicsSubscriptionsRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRuleStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240101.Action_STATUS Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression.</summary>
    [JsonPropertyName("action")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusAction? Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20240101.CorrelationFilter_STATUS Represents the correlation filter expression.</summary>
    [JsonPropertyName("correlationFilter")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusCorrelationFilter? CorrelationFilter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240101.SqlFilter_STATUS Represents a filter which is a composition of an expression and an action that is executed in the pub/sub pipeline.</summary>
    [JsonPropertyName("sqlFilter")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusSqlFilter? SqlFilter { get; set; }

    /// <summary>Storage version of v1api20240101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240101.NamespacesTopicsSubscriptionsRule Generator information: - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/Rules.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101storageNamespacesTopicsSubscriptionsRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240101storageNamespacesTopicsSubscriptionsRuleSpec>, IStatus<V1api20240101storageNamespacesTopicsSubscriptionsRuleStatus>
{
    public const string KubeApiVersion = "v1api20240101storage";
    public const string KubeKind = "NamespacesTopicsSubscriptionsRule";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacestopicssubscriptionsrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240101.NamespacesTopicsSubscriptionsRule_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240101.NamespacesTopicsSubscriptionsRule_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240101storageNamespacesTopicsSubscriptionsRuleStatus? Status { get; set; }
}