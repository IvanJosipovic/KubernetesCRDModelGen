using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.crossplane.io;
#nullable enable
/// <summary>SQLAlert is the Schema for the SQLAlerts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLAlertList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SQLAlert>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLAlertList";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "sqlalerts";
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
    public IList<V1alpha1SQLAlert> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecForProviderOptions
{
    /// <summary>Name of column in the query result to compare in alert evaluation.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Custom body of alert notification, if it exists. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customBody")]
    public string? CustomBody { get; set; }

    /// <summary>Custom subject of alert notification, if it exists. This includes email subject, Slack notification header, etc. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>State that alert evaluates to when query result is empty.  Currently supported values are unknown, triggered, ok - check API documentation for full list of supported values.</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>Whether or not the alert is muted. If an alert is muted, it will not notify users and alert destinations when triggered.</summary>
    [JsonPropertyName("muted")]
    public bool? Muted { get; set; }

    /// <summary>Operator used to compare in alert evaluation. (Enum: &gt;, &gt;=, &lt;, &lt;=, ==, !=)</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>Value used to compare in alert evaluation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Name of the alert.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Alert configuration options.</summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1SQLAlertSpecForProviderOptions>? Options { get; set; }

    /// <summary>The identifier of the workspace folder containing the alert. The default is ther user's home folder. The folder identifier is formatted as folder/&lt;folder_id&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>ID of the query evaluated by the alert.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>Number of seconds after being triggered before the alert rearms itself and can be triggered again. If not defined, alert will never be triggered again.</summary>
    [JsonPropertyName("rearm")]
    public double? Rearm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecInitProviderOptions
{
    /// <summary>Name of column in the query result to compare in alert evaluation.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Custom body of alert notification, if it exists. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customBody")]
    public string? CustomBody { get; set; }

    /// <summary>Custom subject of alert notification, if it exists. This includes email subject, Slack notification header, etc. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>State that alert evaluates to when query result is empty.  Currently supported values are unknown, triggered, ok - check API documentation for full list of supported values.</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>Whether or not the alert is muted. If an alert is muted, it will not notify users and alert destinations when triggered.</summary>
    [JsonPropertyName("muted")]
    public bool? Muted { get; set; }

    /// <summary>Operator used to compare in alert evaluation. (Enum: &gt;, &gt;=, &lt;, &lt;=, ==, !=)</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>Value used to compare in alert evaluation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Name of the alert.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Alert configuration options.</summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1SQLAlertSpecInitProviderOptions>? Options { get; set; }

    /// <summary>The identifier of the workspace folder containing the alert. The default is ther user's home folder. The folder identifier is formatted as folder/&lt;folder_id&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>ID of the query evaluated by the alert.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>Number of seconds after being triggered before the alert rearms itself and can be triggered again. If not defined, alert will never be triggered again.</summary>
    [JsonPropertyName("rearm")]
    public double? Rearm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecProviderConfigRefPolicy
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
public partial class V1alpha1SQLAlertSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLAlertSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1SQLAlertSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLAlertSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1SQLAlertSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1SQLAlertSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1SQLAlertSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpecWriteConnectionSecretToRef
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
/// <summary>SQLAlertSpec defines the desired state of SQLAlert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1SQLAlertSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1SQLAlertSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SQLAlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1SQLAlertSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SQLAlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertStatusAtProviderOptions
{
    /// <summary>Name of column in the query result to compare in alert evaluation.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Custom body of alert notification, if it exists. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customBody")]
    public string? CustomBody { get; set; }

    /// <summary>Custom subject of alert notification, if it exists. This includes email subject, Slack notification header, etc. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>State that alert evaluates to when query result is empty.  Currently supported values are unknown, triggered, ok - check API documentation for full list of supported values.</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>Whether or not the alert is muted. If an alert is muted, it will not notify users and alert destinations when triggered.</summary>
    [JsonPropertyName("muted")]
    public bool? Muted { get; set; }

    /// <summary>Operator used to compare in alert evaluation. (Enum: &gt;, &gt;=, &lt;, &lt;=, ==, !=)</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>Value used to compare in alert evaluation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>unique ID of the SQL Alert.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the alert.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Alert configuration options.</summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1SQLAlertStatusAtProviderOptions>? Options { get; set; }

    /// <summary>The identifier of the workspace folder containing the alert. The default is ther user's home folder. The folder identifier is formatted as folder/&lt;folder_id&gt;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>ID of the query evaluated by the alert.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>Number of seconds after being triggered before the alert rearms itself and can be triggered again. If not defined, alert will never be triggered again.</summary>
    [JsonPropertyName("rearm")]
    public double? Rearm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertStatusConditions
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
/// <summary>SQLAlertStatus defines the observed state of SQLAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLAlertStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1SQLAlertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SQLAlertStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SQLAlert is the Schema for the SQLAlerts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SQLAlertSpec>, IStatus<V1alpha1SQLAlertStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLAlert";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "sqlalerts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLAlertSpec defines the desired state of SQLAlert</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SQLAlertSpec Spec { get; set; }

    /// <summary>SQLAlertStatus defines the observed state of SQLAlert.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SQLAlertStatus? Status { get; set; }
}
#nullable disable
