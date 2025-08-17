using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.log.databricks.crossplane.io;
#nullable enable
/// <summary>MwsLogDelivery is the Schema for the MwsLogDeliverys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsLogDeliveryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsLogDelivery>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsLogDeliveryList";
    public const string KubeGroup = "log.databricks.crossplane.io";
    public const string KubePluralName = "mwslogdeliveries";
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
    public IList<V1alpha1MwsLogDelivery> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliverySpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Databricks log delivery configuration ID.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The optional human-readable name of the log delivery configuration. Defaults to empty.</summary>
    [JsonPropertyName("configName")]
    public string? ConfigName { get; set; }

    /// <summary>The ID for a Databricks credential configuration that represents the AWS IAM role with policy and trust relationship as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Defaults to empty, which means that logs are delivered to the root of the bucket. The value must be a valid S3 object key. It must not start or end with a slash character.</summary>
    [JsonPropertyName("deliveryPathPrefix")]
    public string? DeliveryPathPrefix { get; set; }

    /// <summary>The optional start month and year for delivery, specified in YYYY-MM format. Defaults to current year and month. Usage is not available before 2019-03.</summary>
    [JsonPropertyName("deliveryStartTime")]
    public string? DeliveryStartTime { get; set; }

    /// <summary>The type of log delivery. BILLABLE_USAGE and AUDIT_LOGS are supported.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The file type of log delivery. Currently CSV (for BILLABLE_USAGE) and JSON (for AUDIT_LOGS) are supported.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Status of log delivery configuration. Set to ENABLED or DISABLED. Defaults to ENABLED. This is the only field you can update.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID for a Databricks storage configuration that represents the S3 bucket with bucket policy as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>By default, this log configuration applies to all workspaces associated with your account ID. If your account is on the multitenant version of the platform or on a select custom plan that allows multiple workspaces per account, you may have multiple workspaces associated with your account ID. You can optionally set the field as mentioned earlier to an array of workspace IDs. If you plan to use different log delivery configurations for several workspaces, set this explicitly rather than leaving it blank. If you leave this blank and your account ID gets additional workspaces in the future, this configuration will also apply to the new workspaces.</summary>
    [JsonPropertyName("workspaceIdsFilter")]
    public IList<double>? WorkspaceIdsFilter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliverySpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Databricks log delivery configuration ID.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The optional human-readable name of the log delivery configuration. Defaults to empty.</summary>
    [JsonPropertyName("configName")]
    public string? ConfigName { get; set; }

    /// <summary>The ID for a Databricks credential configuration that represents the AWS IAM role with policy and trust relationship as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Defaults to empty, which means that logs are delivered to the root of the bucket. The value must be a valid S3 object key. It must not start or end with a slash character.</summary>
    [JsonPropertyName("deliveryPathPrefix")]
    public string? DeliveryPathPrefix { get; set; }

    /// <summary>The optional start month and year for delivery, specified in YYYY-MM format. Defaults to current year and month. Usage is not available before 2019-03.</summary>
    [JsonPropertyName("deliveryStartTime")]
    public string? DeliveryStartTime { get; set; }

    /// <summary>The type of log delivery. BILLABLE_USAGE and AUDIT_LOGS are supported.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The file type of log delivery. Currently CSV (for BILLABLE_USAGE) and JSON (for AUDIT_LOGS) are supported.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Status of log delivery configuration. Set to ENABLED or DISABLED. Defaults to ENABLED. This is the only field you can update.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID for a Databricks storage configuration that represents the S3 bucket with bucket policy as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>By default, this log configuration applies to all workspaces associated with your account ID. If your account is on the multitenant version of the platform or on a select custom plan that allows multiple workspaces per account, you may have multiple workspaces associated with your account ID. You can optionally set the field as mentioned earlier to an array of workspace IDs. If you plan to use different log delivery configurations for several workspaces, set this explicitly rather than leaving it blank. If you leave this blank and your account ID gets additional workspaces in the future, this configuration will also apply to the new workspaces.</summary>
    [JsonPropertyName("workspaceIdsFilter")]
    public IList<double>? WorkspaceIdsFilter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliverySpecProviderConfigRefPolicy
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
public partial class V1alpha1MwsLogDeliverySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsLogDeliverySpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliverySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1MwsLogDeliverySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsLogDeliverySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliverySpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1MwsLogDeliverySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1MwsLogDeliverySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1MwsLogDeliverySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliverySpecWriteConnectionSecretToRef
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
/// <summary>MwsLogDeliverySpec defines the desired state of MwsLogDelivery</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliverySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1MwsLogDeliverySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1MwsLogDeliverySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsLogDeliverySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1MwsLogDeliverySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsLogDeliverySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliveryStatusAtProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Databricks log delivery configuration ID.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The optional human-readable name of the log delivery configuration. Defaults to empty.</summary>
    [JsonPropertyName("configName")]
    public string? ConfigName { get; set; }

    /// <summary>The ID for a Databricks credential configuration that represents the AWS IAM role with policy and trust relationship as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Defaults to empty, which means that logs are delivered to the root of the bucket. The value must be a valid S3 object key. It must not start or end with a slash character.</summary>
    [JsonPropertyName("deliveryPathPrefix")]
    public string? DeliveryPathPrefix { get; set; }

    /// <summary>The optional start month and year for delivery, specified in YYYY-MM format. Defaults to current year and month. Usage is not available before 2019-03.</summary>
    [JsonPropertyName("deliveryStartTime")]
    public string? DeliveryStartTime { get; set; }

    /// <summary>the ID of log delivery configuration in form of account_id|config_id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of log delivery. BILLABLE_USAGE and AUDIT_LOGS are supported.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The file type of log delivery. Currently CSV (for BILLABLE_USAGE) and JSON (for AUDIT_LOGS) are supported.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Status of log delivery configuration. Set to ENABLED or DISABLED. Defaults to ENABLED. This is the only field you can update.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID for a Databricks storage configuration that represents the S3 bucket with bucket policy as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>By default, this log configuration applies to all workspaces associated with your account ID. If your account is on the multitenant version of the platform or on a select custom plan that allows multiple workspaces per account, you may have multiple workspaces associated with your account ID. You can optionally set the field as mentioned earlier to an array of workspace IDs. If you plan to use different log delivery configurations for several workspaces, set this explicitly rather than leaving it blank. If you leave this blank and your account ID gets additional workspaces in the future, this configuration will also apply to the new workspaces.</summary>
    [JsonPropertyName("workspaceIdsFilter")]
    public IList<double>? WorkspaceIdsFilter { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliveryStatusConditions
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
/// <summary>MwsLogDeliveryStatus defines the observed state of MwsLogDelivery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsLogDeliveryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsLogDeliveryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsLogDeliveryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MwsLogDelivery is the Schema for the MwsLogDeliverys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsLogDelivery : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsLogDeliverySpec>, IStatus<V1alpha1MwsLogDeliveryStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsLogDelivery";
    public const string KubeGroup = "log.databricks.crossplane.io";
    public const string KubePluralName = "mwslogdeliveries";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsLogDeliverySpec defines the desired state of MwsLogDelivery</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MwsLogDeliverySpec Spec { get; set; }

    /// <summary>MwsLogDeliveryStatus defines the observed state of MwsLogDelivery.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsLogDeliveryStatus? Status { get; set; }
}
#nullable disable
