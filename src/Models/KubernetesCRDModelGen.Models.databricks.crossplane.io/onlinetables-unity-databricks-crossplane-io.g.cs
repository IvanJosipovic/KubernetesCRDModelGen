using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecForProviderSpecRunContinuously
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecForProviderSpecRunTriggered
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecForProviderSpec
{
    /// <summary>Whether to create a full-copy pipeline -- a pipeline that stops after creates a full copy of the source table upon initialization and does not process any change data feeds (CDFs) afterwards. The pipeline can still be manually triggered afterwards, but it always perform a full copy of the source table and there are no incremental updates. This mode is useful for syncing views or tables without CDFs to online tables. Note that the full-copy pipeline only supports "triggered" scheduling policy.</summary>
    [JsonPropertyName("performFullCopy")]
    public bool? PerformFullCopy { get; set; }

    /// <summary>list of the columns comprising the primary key.</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
    [JsonPropertyName("runContinuously")]
    public IList<V1alpha1OnlineTableSpecForProviderSpecRunContinuously>? RunContinuously { get; set; }

    /// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
    [JsonPropertyName("runTriggered")]
    public IList<V1alpha1OnlineTableSpecForProviderSpecRunTriggered>? RunTriggered { get; set; }

    /// <summary>full name of the source table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key.</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecForProvider
{
    /// <summary>3-level name of the Online Table to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>object containing specification of the online table:</summary>
    [JsonPropertyName("spec")]
    public IList<V1alpha1OnlineTableSpecForProviderSpec>? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecInitProviderSpecRunContinuously
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecInitProviderSpecRunTriggered
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecInitProviderSpec
{
    /// <summary>Whether to create a full-copy pipeline -- a pipeline that stops after creates a full copy of the source table upon initialization and does not process any change data feeds (CDFs) afterwards. The pipeline can still be manually triggered afterwards, but it always perform a full copy of the source table and there are no incremental updates. This mode is useful for syncing views or tables without CDFs to online tables. Note that the full-copy pipeline only supports "triggered" scheduling policy.</summary>
    [JsonPropertyName("performFullCopy")]
    public bool? PerformFullCopy { get; set; }

    /// <summary>list of the columns comprising the primary key.</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
    [JsonPropertyName("runContinuously")]
    public IList<V1alpha1OnlineTableSpecInitProviderSpecRunContinuously>? RunContinuously { get; set; }

    /// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
    [JsonPropertyName("runTriggered")]
    public IList<V1alpha1OnlineTableSpecInitProviderSpecRunTriggered>? RunTriggered { get; set; }

    /// <summary>full name of the source table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key.</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecInitProvider
{
    /// <summary>3-level name of the Online Table to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>object containing specification of the online table:</summary>
    [JsonPropertyName("spec")]
    public IList<V1alpha1OnlineTableSpecInitProviderSpec>? Spec { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecProviderConfigRefPolicy
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
public partial class V1alpha1OnlineTableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1OnlineTableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1OnlineTableSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1OnlineTableSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1OnlineTableSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>OnlineTableSpec defines the desired state of OnlineTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1OnlineTableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1OnlineTableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1OnlineTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1OnlineTableSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1OnlineTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderSpecRunContinuously
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderSpecRunTriggered
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderSpec
{
    /// <summary>Whether to create a full-copy pipeline -- a pipeline that stops after creates a full copy of the source table upon initialization and does not process any change data feeds (CDFs) afterwards. The pipeline can still be manually triggered afterwards, but it always perform a full copy of the source table and there are no incremental updates. This mode is useful for syncing views or tables without CDFs to online tables. Note that the full-copy pipeline only supports "triggered" scheduling policy.</summary>
    [JsonPropertyName("performFullCopy")]
    public bool? PerformFullCopy { get; set; }

    /// <summary>ID of the associated Delta Live Table pipeline.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>list of the columns comprising the primary key.</summary>
    [JsonPropertyName("primaryKeyColumns")]
    public IList<string>? PrimaryKeyColumns { get; set; }

    /// <summary>empty block that specifies that pipeline runs continuously after generating the initial data.  Conflicts with run_triggered.</summary>
    [JsonPropertyName("runContinuously")]
    public IList<V1alpha1OnlineTableStatusAtProviderSpecRunContinuously>? RunContinuously { get; set; }

    /// <summary>empty block that specifies that pipeline stops after generating the initial data and can be triggered later (manually, through a cron job or through data triggers).</summary>
    [JsonPropertyName("runTriggered")]
    public IList<V1alpha1OnlineTableStatusAtProviderSpecRunTriggered>? RunTriggered { get; set; }

    /// <summary>full name of the source table.</summary>
    [JsonPropertyName("sourceTableFullName")]
    public string? SourceTableFullName { get; set; }

    /// <summary>Time series key to deduplicate (tie-break) rows with the same primary key.</summary>
    [JsonPropertyName("timeseriesKey")]
    public string? TimeseriesKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatusContinuousUpdateStatusInitialPipelineSyncProgress
{
    /// <summary></summary>
    [JsonPropertyName("estimatedCompletionTimeSeconds")]
    public double? EstimatedCompletionTimeSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestVersionCurrentlyProcessing")]
    public double? LatestVersionCurrentlyProcessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncProgressCompletion")]
    public double? SyncProgressCompletion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedRowCount")]
    public double? SyncedRowCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalRowCount")]
    public double? TotalRowCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatusContinuousUpdateStatus
{
    /// <summary></summary>
    [JsonPropertyName("initialPipelineSyncProgress")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatusContinuousUpdateStatusInitialPipelineSyncProgress>? InitialPipelineSyncProgress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastProcessedCommitVersion")]
    public double? LastProcessedCommitVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatusFailedStatus
{
    /// <summary></summary>
    [JsonPropertyName("lastProcessedCommitVersion")]
    public double? LastProcessedCommitVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatusProvisioningStatusInitialPipelineSyncProgress
{
    /// <summary></summary>
    [JsonPropertyName("estimatedCompletionTimeSeconds")]
    public double? EstimatedCompletionTimeSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestVersionCurrentlyProcessing")]
    public double? LatestVersionCurrentlyProcessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncProgressCompletion")]
    public double? SyncProgressCompletion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedRowCount")]
    public double? SyncedRowCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalRowCount")]
    public double? TotalRowCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatusProvisioningStatus
{
    /// <summary></summary>
    [JsonPropertyName("initialPipelineSyncProgress")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatusProvisioningStatusInitialPipelineSyncProgress>? InitialPipelineSyncProgress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatusTriggeredUpdateStatusTriggeredUpdateProgress
{
    /// <summary></summary>
    [JsonPropertyName("estimatedCompletionTimeSeconds")]
    public double? EstimatedCompletionTimeSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("latestVersionCurrentlyProcessing")]
    public double? LatestVersionCurrentlyProcessing { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncProgressCompletion")]
    public double? SyncProgressCompletion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncedRowCount")]
    public double? SyncedRowCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalRowCount")]
    public double? TotalRowCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatusTriggeredUpdateStatus
{
    /// <summary></summary>
    [JsonPropertyName("lastProcessedCommitVersion")]
    public double? LastProcessedCommitVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("triggeredUpdateProgress")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatusTriggeredUpdateStatusTriggeredUpdateProgress>? TriggeredUpdateProgress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProviderStatus
{
    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("continuousUpdateStatus")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatusContinuousUpdateStatus>? ContinuousUpdateStatus { get; set; }

    /// <summary>The state of the online table.</summary>
    [JsonPropertyName("detailedState")]
    public string? DetailedState { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("failedStatus")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatusFailedStatus>? FailedStatus { get; set; }

    /// <summary>A text description of the current state of the online table.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("provisioningStatus")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatusProvisioningStatus>? ProvisioningStatus { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("triggeredUpdateStatus")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatusTriggeredUpdateStatus>? TriggeredUpdateStatus { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusAtProvider
{
    /// <summary>The same as the name of the online table.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>3-level name of the Online Table to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>object containing specification of the online table:</summary>
    [JsonPropertyName("spec")]
    public IList<V1alpha1OnlineTableStatusAtProviderSpec>? Spec { get; set; }

    /// <summary>object describing status of the online table:</summary>
    [JsonPropertyName("status")]
    public IList<V1alpha1OnlineTableStatusAtProviderStatus>? Status { get; set; }

    /// <summary>Data serving REST API URL for this table.</summary>
    [JsonPropertyName("tableServingUrl")]
    public string? TableServingUrl { get; set; }

    /// <summary>The provisioning state of the online table entity in Unity Catalog. This is distinct from the state of the data synchronization pipeline (i.e. the table may be in "ACTIVE" but the pipeline may be in "PROVISIONING" as it runs asynchronously).</summary>
    [JsonPropertyName("unityCatalogProvisioningState")]
    public string? UnityCatalogProvisioningState { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatusConditions
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

/// <summary>OnlineTableStatus defines the observed state of OnlineTable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OnlineTableStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1OnlineTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OnlineTableStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OnlineTable is the Schema for the OnlineTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OnlineTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OnlineTableSpec>, IStatus<V1alpha1OnlineTableStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OnlineTable";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "onlinetables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OnlineTableSpec defines the desired state of OnlineTable</summary>
    [JsonPropertyName("spec")]
    public V1alpha1OnlineTableSpec Spec { get; set; }

    /// <summary>OnlineTableStatus defines the observed state of OnlineTable.</summary>
    [JsonPropertyName("status")]
    public V1alpha1OnlineTableStatus? Status { get; set; }
}

/// <summary>OnlineTable is the Schema for the OnlineTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OnlineTableList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OnlineTable>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OnlineTableList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "onlinetables";
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
    public IList<V1alpha1OnlineTable> Items { get; set; }
}