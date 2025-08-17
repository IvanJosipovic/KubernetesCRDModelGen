using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.finops.databricks.crossplane.io;
#nullable enable
/// <summary>Budget is the Schema for the Budgets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BudgetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Budget>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BudgetList";
    public const string KubeGroup = "finops.databricks.crossplane.io";
    public const string KubePluralName = "budgets";
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
    public IList<V1alpha1Budget> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecForProviderAlertConfigurationsActionConfigurations
{
    /// <summary></summary>
    [JsonPropertyName("actionConfigurationId")]
    public string? ActionConfigurationId { get; set; }

    /// <summary>The type of action to take when the budget alert is triggered. (Enum: EMAIL_NOTIFICATION)</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The target of the action. For EMAIL_NOTIFICATION, this is the email address to send the notification to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecForProviderAlertConfigurations
{
    /// <summary>List of action configurations to take when the budget alert is triggered. Consists of the following fields:</summary>
    [JsonPropertyName("actionConfigurations")]
    public IList<V1alpha1BudgetSpecForProviderAlertConfigurationsActionConfigurations>? ActionConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertConfigurationId")]
    public string? AlertConfigurationId { get; set; }

    /// <summary>The threshold for the budget alert to determine if it is in a triggered state. The number is evaluated based on quantity_type.</summary>
    [JsonPropertyName("quantityThreshold")]
    public string? QuantityThreshold { get; set; }

    /// <summary>The way to calculate cost for this budget alert. This is what quantity_threshold is measured in. (Enum: LIST_PRICE_DOLLARS_USD)</summary>
    [JsonPropertyName("quantityType")]
    public string? QuantityType { get; set; }

    /// <summary>The time window of usage data for the budget. (Enum: MONTH)</summary>
    [JsonPropertyName("timePeriod")]
    public string? TimePeriod { get; set; }

    /// <summary>The evaluation method to determine when this budget alert is in a triggered state. (Enum: CUMULATIVE_SPENDING_EXCEEDED)</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecForProviderFilterTagsValue
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecForProviderFilterTags
{
    /// <summary>The key of the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Consists of the following fields:</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1BudgetSpecForProviderFilterTagsValue>? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecForProviderFilterWorkspaceId
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecForProviderFilter
{
    /// <summary>List of tags to filter by. Consists of the following fields:</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1BudgetSpecForProviderFilterTags>? Tags { get; set; }

    /// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
    [JsonPropertyName("workspaceId")]
    public IList<V1alpha1BudgetSpecForProviderFilterWorkspaceId>? WorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecForProvider
{
    /// <summary>The ID of the Databricks Account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertConfigurations")]
    public IList<V1alpha1BudgetSpecForProviderAlertConfigurations>? AlertConfigurations { get; set; }

    /// <summary>The ID of the budget configuration.</summary>
    [JsonPropertyName("budgetConfigurationId")]
    public string? BudgetConfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createTime")]
    public double? CreateTime { get; set; }

    /// <summary>Name of the budget in Databricks Account.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filter")]
    public IList<V1alpha1BudgetSpecForProviderFilter>? Filter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updateTime")]
    public double? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecInitProviderAlertConfigurationsActionConfigurations
{
    /// <summary></summary>
    [JsonPropertyName("actionConfigurationId")]
    public string? ActionConfigurationId { get; set; }

    /// <summary>The type of action to take when the budget alert is triggered. (Enum: EMAIL_NOTIFICATION)</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The target of the action. For EMAIL_NOTIFICATION, this is the email address to send the notification to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecInitProviderAlertConfigurations
{
    /// <summary>List of action configurations to take when the budget alert is triggered. Consists of the following fields:</summary>
    [JsonPropertyName("actionConfigurations")]
    public IList<V1alpha1BudgetSpecInitProviderAlertConfigurationsActionConfigurations>? ActionConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertConfigurationId")]
    public string? AlertConfigurationId { get; set; }

    /// <summary>The threshold for the budget alert to determine if it is in a triggered state. The number is evaluated based on quantity_type.</summary>
    [JsonPropertyName("quantityThreshold")]
    public string? QuantityThreshold { get; set; }

    /// <summary>The way to calculate cost for this budget alert. This is what quantity_threshold is measured in. (Enum: LIST_PRICE_DOLLARS_USD)</summary>
    [JsonPropertyName("quantityType")]
    public string? QuantityType { get; set; }

    /// <summary>The time window of usage data for the budget. (Enum: MONTH)</summary>
    [JsonPropertyName("timePeriod")]
    public string? TimePeriod { get; set; }

    /// <summary>The evaluation method to determine when this budget alert is in a triggered state. (Enum: CUMULATIVE_SPENDING_EXCEEDED)</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecInitProviderFilterTagsValue
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecInitProviderFilterTags
{
    /// <summary>The key of the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Consists of the following fields:</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1BudgetSpecInitProviderFilterTagsValue>? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecInitProviderFilterWorkspaceId
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecInitProviderFilter
{
    /// <summary>List of tags to filter by. Consists of the following fields:</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1BudgetSpecInitProviderFilterTags>? Tags { get; set; }

    /// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
    [JsonPropertyName("workspaceId")]
    public IList<V1alpha1BudgetSpecInitProviderFilterWorkspaceId>? WorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecInitProvider
{
    /// <summary>The ID of the Databricks Account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertConfigurations")]
    public IList<V1alpha1BudgetSpecInitProviderAlertConfigurations>? AlertConfigurations { get; set; }

    /// <summary>The ID of the budget configuration.</summary>
    [JsonPropertyName("budgetConfigurationId")]
    public string? BudgetConfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createTime")]
    public double? CreateTime { get; set; }

    /// <summary>Name of the budget in Databricks Account.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filter")]
    public IList<V1alpha1BudgetSpecInitProviderFilter>? Filter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updateTime")]
    public double? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecProviderConfigRefPolicy
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
public partial class V1alpha1BudgetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BudgetSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecPublishConnectionDetailsToConfigRefPolicy
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
/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1BudgetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecPublishConnectionDetailsToMetadata
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
#nullable disable

#nullable enable
/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1BudgetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1BudgetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpecWriteConnectionSecretToRef
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
/// <summary>BudgetSpec defines the desired state of Budget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1BudgetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1BudgetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1BudgetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1BudgetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1BudgetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusAtProviderAlertConfigurationsActionConfigurations
{
    /// <summary></summary>
    [JsonPropertyName("actionConfigurationId")]
    public string? ActionConfigurationId { get; set; }

    /// <summary>The type of action to take when the budget alert is triggered. (Enum: EMAIL_NOTIFICATION)</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>The target of the action. For EMAIL_NOTIFICATION, this is the email address to send the notification to.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusAtProviderAlertConfigurations
{
    /// <summary>List of action configurations to take when the budget alert is triggered. Consists of the following fields:</summary>
    [JsonPropertyName("actionConfigurations")]
    public IList<V1alpha1BudgetStatusAtProviderAlertConfigurationsActionConfigurations>? ActionConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertConfigurationId")]
    public string? AlertConfigurationId { get; set; }

    /// <summary>The threshold for the budget alert to determine if it is in a triggered state. The number is evaluated based on quantity_type.</summary>
    [JsonPropertyName("quantityThreshold")]
    public string? QuantityThreshold { get; set; }

    /// <summary>The way to calculate cost for this budget alert. This is what quantity_threshold is measured in. (Enum: LIST_PRICE_DOLLARS_USD)</summary>
    [JsonPropertyName("quantityType")]
    public string? QuantityType { get; set; }

    /// <summary>The time window of usage data for the budget. (Enum: MONTH)</summary>
    [JsonPropertyName("timePeriod")]
    public string? TimePeriod { get; set; }

    /// <summary>The evaluation method to determine when this budget alert is in a triggered state. (Enum: CUMULATIVE_SPENDING_EXCEEDED)</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusAtProviderFilterTagsValue
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusAtProviderFilterTags
{
    /// <summary>The key of the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Consists of the following fields:</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1BudgetStatusAtProviderFilterTagsValue>? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusAtProviderFilterWorkspaceId
{
    /// <summary>The operator to use for the filter. (Enum: IN)</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The values to filter by.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusAtProviderFilter
{
    /// <summary>List of tags to filter by. Consists of the following fields:</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1BudgetStatusAtProviderFilterTags>? Tags { get; set; }

    /// <summary>Filter by workspace ID (if empty, include usage all usage for this account). Consists of the following fields:</summary>
    [JsonPropertyName("workspaceId")]
    public IList<V1alpha1BudgetStatusAtProviderFilterWorkspaceId>? WorkspaceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusAtProvider
{
    /// <summary>The ID of the Databricks Account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alertConfigurations")]
    public IList<V1alpha1BudgetStatusAtProviderAlertConfigurations>? AlertConfigurations { get; set; }

    /// <summary>The ID of the budget configuration.</summary>
    [JsonPropertyName("budgetConfigurationId")]
    public string? BudgetConfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createTime")]
    public double? CreateTime { get; set; }

    /// <summary>Name of the budget in Databricks Account.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filter")]
    public IList<V1alpha1BudgetStatusAtProviderFilter>? Filter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updateTime")]
    public double? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatusConditions
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
/// <summary>BudgetStatus defines the observed state of Budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BudgetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1BudgetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BudgetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Budget is the Schema for the Budgets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Budget : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BudgetSpec>, IStatus<V1alpha1BudgetStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Budget";
    public const string KubeGroup = "finops.databricks.crossplane.io";
    public const string KubePluralName = "budgets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetSpec defines the desired state of Budget</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BudgetSpec Spec { get; set; }

    /// <summary>BudgetStatus defines the observed state of Budget.</summary>
    [JsonPropertyName("status")]
    public V1alpha1BudgetStatus? Status { get; set; }
}
#nullable disable
