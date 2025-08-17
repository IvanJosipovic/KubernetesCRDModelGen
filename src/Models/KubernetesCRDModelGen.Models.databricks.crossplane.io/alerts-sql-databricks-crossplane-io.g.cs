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
/// <summary>Alert is the Schema for the Alerts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AlertList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Alert>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AlertList";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "alerts";
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
    public IList<V1alpha1Alert> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecForProviderConditionOperandColumn
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecForProviderConditionOperand
{
    /// <summary>Block describing the column from the query result to use for comparison in alert evaluation:</summary>
    [JsonPropertyName("column")]
    public IList<V1alpha1AlertSpecForProviderConditionOperandColumn>? Column { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecForProviderConditionThresholdValue
{
    /// <summary>boolean value (true or false) to compare against boolean results.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>double value to compare against integer and double results.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>string value to compare against string results.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecForProviderConditionThreshold
{
    /// <summary>actual value used in comparison (one of the attributes is required):</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1AlertSpecForProviderConditionThresholdValue>? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecForProviderCondition
{
    /// <summary>Alert state if the result is empty (UNKNOWN, OK, TRIGGERED)</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>Operator used for comparison in alert evaluation. (Enum: GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, EQUAL, NOT_EQUAL, IS_NULL)</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>Name of the column from the query result to use for comparison in alert evaluation:</summary>
    [JsonPropertyName("operand")]
    public IList<V1alpha1AlertSpecForProviderConditionOperand>? Operand { get; set; }

    /// <summary>Threshold value used for comparison in alert evaluation:</summary>
    [JsonPropertyName("threshold")]
    public IList<V1alpha1AlertSpecForProviderConditionThreshold>? Threshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecForProvider
{
    /// <summary>Trigger conditions of the alert. Block consists of the following attributes:</summary>
    [JsonPropertyName("condition")]
    public IList<V1alpha1AlertSpecForProviderCondition>? Condition { get; set; }

    /// <summary>Custom body of alert notification, if it exists. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customBody")]
    public string? CustomBody { get; set; }

    /// <summary>Custom subject of alert notification, if it exists. This includes email subject, Slack notification header, etc. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>Name of the alert.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to notify alert subscribers when alert returns back to normal.</summary>
    [JsonPropertyName("notifyOnOk")]
    public bool? NotifyOnOk { get; set; }

    /// <summary>Alert owner's username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>The path to a workspace folder containing the alert. The default is the user's home folder.  If changed, the alert will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>ID of the query evaluated by the alert.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>Number of seconds an alert must wait after being triggered to rearm itself. After rearming, it can be triggered again. If 0 or not specified, the alert will not be triggered again.</summary>
    [JsonPropertyName("secondsToRetrigger")]
    public double? SecondsToRetrigger { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecInitProviderConditionOperandColumn
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecInitProviderConditionOperand
{
    /// <summary>Block describing the column from the query result to use for comparison in alert evaluation:</summary>
    [JsonPropertyName("column")]
    public IList<V1alpha1AlertSpecInitProviderConditionOperandColumn>? Column { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecInitProviderConditionThresholdValue
{
    /// <summary>boolean value (true or false) to compare against boolean results.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>double value to compare against integer and double results.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>string value to compare against string results.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecInitProviderConditionThreshold
{
    /// <summary>actual value used in comparison (one of the attributes is required):</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1AlertSpecInitProviderConditionThresholdValue>? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecInitProviderCondition
{
    /// <summary>Alert state if the result is empty (UNKNOWN, OK, TRIGGERED)</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>Operator used for comparison in alert evaluation. (Enum: GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, EQUAL, NOT_EQUAL, IS_NULL)</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>Name of the column from the query result to use for comparison in alert evaluation:</summary>
    [JsonPropertyName("operand")]
    public IList<V1alpha1AlertSpecInitProviderConditionOperand>? Operand { get; set; }

    /// <summary>Threshold value used for comparison in alert evaluation:</summary>
    [JsonPropertyName("threshold")]
    public IList<V1alpha1AlertSpecInitProviderConditionThreshold>? Threshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecInitProvider
{
    /// <summary>Trigger conditions of the alert. Block consists of the following attributes:</summary>
    [JsonPropertyName("condition")]
    public IList<V1alpha1AlertSpecInitProviderCondition>? Condition { get; set; }

    /// <summary>Custom body of alert notification, if it exists. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customBody")]
    public string? CustomBody { get; set; }

    /// <summary>Custom subject of alert notification, if it exists. This includes email subject, Slack notification header, etc. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>Name of the alert.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to notify alert subscribers when alert returns back to normal.</summary>
    [JsonPropertyName("notifyOnOk")]
    public bool? NotifyOnOk { get; set; }

    /// <summary>Alert owner's username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>The path to a workspace folder containing the alert. The default is the user's home folder.  If changed, the alert will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>ID of the query evaluated by the alert.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>Number of seconds an alert must wait after being triggered to rearm itself. After rearming, it can be triggered again. If 0 or not specified, the alert will not be triggered again.</summary>
    [JsonPropertyName("secondsToRetrigger")]
    public double? SecondsToRetrigger { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecProviderConfigRefPolicy
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
public partial class V1alpha1AlertSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AlertSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1AlertSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AlertSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1AlertSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1AlertSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1AlertSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpecWriteConnectionSecretToRef
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
/// <summary>AlertSpec defines the desired state of Alert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1AlertSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1AlertSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1AlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1AlertSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1AlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatusAtProviderConditionOperandColumn
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatusAtProviderConditionOperand
{
    /// <summary>Block describing the column from the query result to use for comparison in alert evaluation:</summary>
    [JsonPropertyName("column")]
    public IList<V1alpha1AlertStatusAtProviderConditionOperandColumn>? Column { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatusAtProviderConditionThresholdValue
{
    /// <summary>boolean value (true or false) to compare against boolean results.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>double value to compare against integer and double results.</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>string value to compare against string results.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatusAtProviderConditionThreshold
{
    /// <summary>actual value used in comparison (one of the attributes is required):</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1AlertStatusAtProviderConditionThresholdValue>? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatusAtProviderCondition
{
    /// <summary>Alert state if the result is empty (UNKNOWN, OK, TRIGGERED)</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>Operator used for comparison in alert evaluation. (Enum: GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, EQUAL, NOT_EQUAL, IS_NULL)</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>Name of the column from the query result to use for comparison in alert evaluation:</summary>
    [JsonPropertyName("operand")]
    public IList<V1alpha1AlertStatusAtProviderConditionOperand>? Operand { get; set; }

    /// <summary>Threshold value used for comparison in alert evaluation:</summary>
    [JsonPropertyName("threshold")]
    public IList<V1alpha1AlertStatusAtProviderConditionThreshold>? Threshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatusAtProvider
{
    /// <summary>Trigger conditions of the alert. Block consists of the following attributes:</summary>
    [JsonPropertyName("condition")]
    public IList<V1alpha1AlertStatusAtProviderCondition>? Condition { get; set; }

    /// <summary>The timestamp string indicating when the alert was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Custom body of alert notification, if it exists. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customBody")]
    public string? CustomBody { get; set; }

    /// <summary>Custom subject of alert notification, if it exists. This includes email subject, Slack notification header, etc. See Alerts API reference for custom templating instructions.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>Name of the alert.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>unique ID of the Alert.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The workspace state of the alert. Used for tracking trashed status. (Possible values are ACTIVE or TRASHED).</summary>
    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    /// <summary>Whether to notify alert subscribers when alert returns back to normal.</summary>
    [JsonPropertyName("notifyOnOk")]
    public bool? NotifyOnOk { get; set; }

    /// <summary>Alert owner's username.</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>The path to a workspace folder containing the alert. The default is the user's home folder.  If changed, the alert will be recreated.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>ID of the query evaluated by the alert.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }

    /// <summary>Number of seconds an alert must wait after being triggered to rearm itself. After rearming, it can be triggered again. If 0 or not specified, the alert will not be triggered again.</summary>
    [JsonPropertyName("secondsToRetrigger")]
    public double? SecondsToRetrigger { get; set; }

    /// <summary>Current state of the alert's trigger status (UNKNOWN, OK, TRIGGERED). This field is set to UNKNOWN if the alert has not yet been evaluated or ran into an error during the last evaluation.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The timestamp string when the alert was last triggered if the alert has been triggered before.</summary>
    [JsonPropertyName("triggerTime")]
    public string? TriggerTime { get; set; }

    /// <summary>The timestamp string indicating when the alert was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatusConditions
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
/// <summary>AlertStatus defines the observed state of Alert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlertStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1AlertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AlertStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Alert is the Schema for the Alerts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Alert : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AlertSpec>, IStatus<V1alpha1AlertStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Alert";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "alerts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlertSpec defines the desired state of Alert</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AlertSpec Spec { get; set; }

    /// <summary>AlertStatus defines the observed state of Alert.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AlertStatus? Status { get; set; }
}
#nullable disable
